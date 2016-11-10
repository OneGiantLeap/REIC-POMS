using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Enables use of DataTable
using MySql.Data.MySqlClient; //Enables connection to MySQL
using System.Windows.Forms;
using System.Collections; //Enables use of ArrayList
using System.Globalization;

namespace REIC_POMS
{
    class MySQLDatabaseDriver
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader myReader;

        //----------------
        //  CODING NOTES |
        //----------------
        /*  ExecuteNonQuery
                - Used for operations where there is nothing returned from the SQL Query or Stored Procedure.
                - Preferred use will be for INSERT, UPDATE and DELETE Operations.
            ExecuteScalar
                - When you just need one Cell value i.e. one column and one row.
                * For SelectCustomerID and SelectSupplierID
        */

        //------------------------
        //  CONNECT & DISCONNECT |
        //------------------------
        // IMPORTANT: Please change the password depending on your MySQL configuration.
        public void ConnectToSQL() //Activate the connection between VS and MySQL
        {
            //connection = new MySqlConnection("server=localhost; database=reicpoms; user=root; password=; convert zero datetime=true; allow zero datetime=true;");
            connection = new MySqlConnection(ConnectionStringManager.reicpomsConnection.ConnectionString);
            connection.Open();
            //ConnectionStringManager.reicpomsConnectionString.Open();

            //DEBUG MESSAGES
            /*if (connection.State == System.Data.ConnectionState.Open)
            { MessageBox.Show("Connection to SQL successful!"); }
            else
            { MessageBox.Show("Connection to SQL failed!"); }*/
        }

        //What is this?
        internal void SelectSpecificRFQOrderLine(string rFQNo, object dgvPQItems)
        {
            throw new NotImplementedException();
        }

        public void DisconnectFromSQL()
        {
            connection.Close();
        }

        //--------------------
        //  BACKUP & RESTORE |
        //--------------------
        // Reference: http://mysqlbackupnet.codeplex.com/
        // ADD ON TOP: using MySql.Data.MySqlClient;
        // If access denied, try running Visual Studio as an Administrator
        // So far, tested to backup & restore in C:\. Tried elsewhere but received an "access denied" error.
        public void Backup()
        { //Called everytime the User clicks on any "X" to close the POMS
            try
            {
                string file = "C:\\REIC Files\\reicpoms_backup.sql";
                using (MySqlConnection conn = new MySqlConnection(ConnectionStringManager.reicpomsConnection.ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(file);
                            conn.Close();
                            MessageBox.Show("Backup completed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void Restore()
        { //Called upon launching the system (Log-in Screen)
          //NOTE: This will result to an error if you don't have the reicpoms_backup.sql file in your C:\\
            try
            {
                string file = "C:\\REIC Files\\reicpoms_backup.sql";
                using (MySqlConnection conn = new MySqlConnection(ConnectionStringManager.reicpomsConnection.ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(file);
                            conn.Close();
                            MessageBox.Show("Restore completed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //---------------------
        //  SELECT STATEMENTS |
        //---------------------
        /// <summary>
        /// Aids in the auto-generation of RFQ, PQ, and PO numbers. Checks the number of existing RFQ/PQ/PO of a given year and month.
        /// Numbering convention of document numbers is YYMM-NNN where NNN is the nth RFQ/PO/PO of that year and month.
        /// </summary>
        /// <param name="tableName">Which table to inspect, rfq_t, pq_t, or po_t?</param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns>The number of existing RFQ/PQ/PO of the given year and month.</returns>
        public int GetRowCount(string tableName, string year, string month)
        {
            int rowCount = -1;
            try
            {
                ConnectToSQL();
                string yearMonth = year + month;
                MySqlCommand countCommand = null;
                switch (tableName)
                {
                    case "rfq_t":
                        countCommand = new MySqlCommand("SELECT COUNT(*) FROM rfq_t WHERE rfq_no LIKE @YearMonth", connection);
                        break;
                    case "pq_t":
                        countCommand = new MySqlCommand("SELECT COUNT(*) FROM pq_t WHERE pq_no LIKE @YearMonth", connection);
                        break;
                    case "po_t":
                        countCommand = new MySqlCommand("SELECT COUNT(*) FROM po_t WHERE po_no LIKE @YearMonth", connection);
                        break;
                }
                countCommand.Parameters.AddWithValue("@YearMonth", yearMonth + "%");
                object countReader = countCommand.ExecuteScalar();
                rowCount = int.Parse(countReader.ToString());
                //MessageBox.Show(rowCount.ToString()); //Debug purposes
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rowCount;
        }

        /// <summary>
        /// Fills the given ArrayList with all details of the Item table.
        /// </summary>
        /// <param name="result">The ArrayList where all details of the Item table will be stored in.</param>
        public void SelectAllItems(ArrayList result)
        { //Purpose: Streamreader data from database into ArrayList
            try
            {
                ConnectToSQL();
                //command = new MySqlCommand("SELECT part_number, item_name, item_description, supplier_unit_price, mark_up_percentage, reic_unit_price, minimum_order_quantity, unit_of_measurement, DATE_FORMAT(from_date, '%m/%d/%Y'), DATE_FORMAT(to_date, '%m/%d/%Y') FROM item_t;", connection);
                command = new MySqlCommand("SELECT * FROM item_t;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    result.Add(new Item(myReader["part_number"].ToString(),
                                        myReader["item_name"].ToString(),
                                        myReader["item_description"].ToString(),
                                        double.Parse(myReader["supplier_unit_price"].ToString()),
                                        int.Parse(myReader["mark_up_percentage"].ToString()),
                                        double.Parse(myReader["reic_unit_price"].ToString()),
                                        int.Parse(myReader["minimum_order_quantity"].ToString()),
                                        myReader["unit_of_measurement"].ToString(),
                                        myReader["from_date"].ToString(),
                                        myReader["to_date"].ToString(),
                                        //myReader["DATE_FORMAT(from_date, '%m/%d/%Y')"].ToString(),
                                        //myReader["DATE_FORMAT(to_date, '%m/%d/%Y')"].ToString(),
                                        int.Parse(myReader["supplier_id"].ToString())));
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    /*    public void SearchItems(DataGridView dgvName, string inputSearch)
        {
            ConnectToSQL();
            switch (inputSearch)
            {
                case "partNumber":
                    command = new MySqlCommand(string.Format("SELECT part_number, item_name, supplier_name " +
                                                     "FROM item_t, supplier_t " +
                                                     "WHERE item_t.part_number = {0} " +
                                                     "AND item_t.supplier_id = supplier_t.supplier_id;", inputSearch), connection);
                    break;
                case "itemName":
                    command = new MySqlCommand(string.Format("SELECT part_number, item_name, supplier_name " +
                                                     "FROM item_t, supplier_t " +
                                                     "WHERE item_t.item_name = {0} " +
                                                     "AND item_t.supplier_id = supplier_t.supplier_id;", inputSearch), connection);
                    break;
            }
                    myReader = command.ExecuteReader();
            
            while (myReader.Read())
            {
                dgvName.Rows.Add(myReader["part_number"].ToString(),
                                 myReader["item_name"].ToString(),
                                 myReader["supplier_name"].ToString());
            }
            DisconnectFromSQL();
        }  */

        public void SearchPNItems(DataGridView dgvName, string inputSearch)
        {
            try
            {
                ConnectToSQL();

                command = new MySqlCommand("SELECT part_number, item_name, supplier_name " +
                                           "FROM item_t, supplier_t " +
                                           "WHERE item_t.part_number = @PartNumber " +
                                           "AND item_t.supplier_id = supplier_t.supplier_id;", connection);
                command.Parameters.AddWithValue("@PartNumber", inputSearch);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Clear();
                    dgvName.Rows.Add(myReader["part_number"].ToString(),
                                     myReader["item_name"].ToString(),
                                     myReader["supplier_name"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SelectAllItemsDGV(DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT part_number, item_name, supplier_name " +
                                           "FROM item_t, supplier_t " +
                                           "WHERE item_t.supplier_id = supplier_t.supplier_id;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["part_number"].ToString(),
                                     myReader["item_name"].ToString(),
                                     myReader["supplier_name"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public double SelectItemPrice(string partNumber)
        {
            double priceResult = -1;
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT reic_unit_price FROM item_t WHERE part_number = @PartNumber;", connection);
                command.Parameters.AddWithValue("@PartNumber", partNumber);
                object queryPrice = command.ExecuteScalar();
                //MessageBox.Show("Unit Price: " + queryPrice.ToString()); //Debug purposes
                priceResult = double.Parse(queryPrice.ToString());
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return priceResult;
        }

        public Item SelectItemDetails(string partNumber) //NEWLY ADDED
        { //Retrieves a specific PQ's row | Used in View Forms of PQ
            Item item = null;
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT * FROM item_t WHERE part_number = @PartNumber;", connection);
                command.Parameters.AddWithValue("@PartNumber", partNumber);
                myReader = command.ExecuteReader();
                myReader.Read();
                item = new Item(partNumber,
                                       myReader["item_name"].ToString(),
                                       myReader["item_description"].ToString(),
                                       double.Parse(myReader["supplier_unit_price"].ToString()),
                                       int.Parse(myReader["mark_up_percentage"].ToString()),
                                       double.Parse(myReader["reic_unit_price"].ToString()),
                                       int.Parse(myReader["minimum_order_quantity"].ToString()),
                                       myReader["unit_of_measurement"].ToString(),
                                       myReader["from_date"].ToString(),
                                       (myReader["to_date"].ToString()),
                                       int.Parse(myReader["supplier_id"].ToString()));
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return item;
        }

        /*  public void SelectPOItems(DataGridView dgvName, int supplierID)
          { //For populating the dgvItemSelection of the forms (IMPORTANT: SUPPLIER'S PRICE)
              ConnectToSQL();
              command = new MySqlCommand(string.Format("SELECT item_name, item_description, unit_of_measurement, reic_unit_price " +
                                                       "FROM item_t, supplier_t " +
                                                       "WHERE supplier_t.supplier_id = {0} " +
                                                       "AND item_t.supplier_id = supplier_t.supplier_id;", supplierID), connection);
              myReader = command.ExecuteReader();
              while (myReader.Read())
              {
                  dgvName.Rows.Add(myReader["item_name"].ToString(),
                                   myReader["item_description"].ToString(),
                                   myReader["unit_of_measurement"].ToString(),
                                   myReader["reic_unit_price"].ToString()); //Double-check: Should have 2 decimal points
              }
              DisconnectFromSQL();
          } */

        /// <summary>
        /// Retrieves all Order Lines of a specific Purchase Order. Used in the View PO form.
        /// </summary>
        /// <param name="supplierID"></param>
        /// <param name="dgvName"></param>
        public void SelectPOItems(string supplierID, DataGridView dgvName)
        { //WHY DOES THE METHOD NAME SAY PO BUT THE CODE SAYS PQ???
            try
            {
                ConnectToSQL();
                MessageBox.Show("push pa");
                command = new MySqlCommand("SELECT item_name, item_description, unit_of_measurement, item_t.reic_unit_price, quantity, item_total " +
                                           "FROM item_t, pq_order_line_t  " +
                                           "WHERE supplier_id = @SupplierID " +
                                           "AND pq_order_line_t.part_number = item_t.part_number;", connection);
                command.Parameters.AddWithValue("@SupplierID", supplierID);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    double reic_unit_price = double.Parse(myReader["reic_unit_price"].ToString());
                    double total_item = double.Parse(myReader["item_total"].ToString());
                    dgvName.Rows.Add(myReader["item_name"].ToString(),
                                     myReader["item_description"].ToString(),
                                     myReader["unit_of_measurement"].ToString(),
                                     reic_unit_price.ToString("0.00"),
                                     int.Parse(myReader["quantity"].ToString()),
                                     total_item.ToString("0.00"));
                    MessageBox.Show("Added");
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Checks if the item part number already exists.
        /// </summary>
        /// <param name="partNumber">The part number to check.</param>
        /// <returns>The number of Item rows that match the given part number.</returns>
        public int GetPNCount(string partNumber)
        {
            int rowCount = 0;
            try
            {
                ConnectToSQL();
                MySqlCommand countCmd = null;
                //MessageBox.Show("code runs until here"); //debug
                {
                    //Original: countCmd = new MySqlCommand(string.Format("SELECT COUNT(*) FROM item_t WHERE part_number LIKE '{0}%'" + ";", partNumber), connection);
                    countCmd = new MySqlCommand("SELECT COUNT(*) FROM item_t WHERE part_number LIKE @PartNumber", connection);
                }
                countCmd.Parameters.AddWithValue("@PartNumber", partNumber + "%");
                object countReader = countCmd.ExecuteScalar();
                rowCount = int.Parse(countReader.ToString());
                //MessageBox.Show(rowCount.ToString()); //Debug purposes
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rowCount;
        }

        /// <summary>
        /// Fills the given ArrayList with all details of the Customer table.
        /// </summary>
        /// <param name="result">The ArrayList where all details of the Customer table will be stored in.</param>
        public void SelectAllCustomers(ArrayList result)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT * FROM customer_t;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    result.Add(new Customer(int.Parse(myReader["customer_id"].ToString()),
                                            myReader["business_name_style"].ToString(),
                                            myReader["tin_number"].ToString(),
                                            myReader["company_name"].ToString(),
                                            myReader["contact_person"].ToString(),
                                            myReader["contact_number"].ToString(),
                                            myReader["account_number"].ToString(),
                                            myReader["email_address"].ToString(),
                                            myReader["address"].ToString()));
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="result"></param>
        public void SelectAllCustomerNames(ArrayList result)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT company_name FROM customer_t;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    result.Add(myReader[0].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Retrieves the Customer ID of a specific Customer.
        /// </summary>
        /// <param name="customerName"></param>
        /// <returns>The given Customer name's Customer ID.</returns>
        public int SelectCustomerID(string customerName)
        {
            int idResult = -1;
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT customer_id FROM customer_t WHERE company_name = @CustomerName;", connection);
                command.Parameters.AddWithValue("@CustomerName", customerName);
                object queryResult = command.ExecuteScalar();
                //MessageBox.Show("Customer ID: " + queryResult.ToString()); //Debug purposes
                idResult = int.Parse(queryResult.ToString());
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return idResult;
        }

        /// <summary>
        /// Retrieves all details of a specific Customer.
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public Customer SelectCustomerDetails(int customerID)
        { //Used in PQ getting from rfq
            Customer c = null;
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT * FROM customer_t WHERE customer_id = @CustomerID;", connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                myReader = command.ExecuteReader();
                myReader.Read();
                c = new Customer(customerID,
                                 myReader["business_name_style"].ToString(),
                                 myReader["tin_number"].ToString(),
                                 myReader["company_name"].ToString(),
                                 myReader["contact_person"].ToString(),
                                 myReader["contact_number"].ToString(),
                                 myReader["account_number"].ToString(),
                                 myReader["email_address"].ToString(),
                                 myReader["address"].ToString());
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return c;
        }

        /// <summary>
        /// Fills the given ArrayList with all details of the Supplier table.
        /// </summary>
        /// <param name="result">The ArrayList where all details of the Supplier table will be stored in.</param>
        public void SelectAllSuppliers(ArrayList result)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT * FROM supplier_t;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    result.Add(new Supplier(int.Parse(myReader["supplier_id"].ToString()),
                                            myReader["supplier_name"].ToString(),
                                            myReader["contact_person"].ToString(),
                                            myReader["contact_number"].ToString(),
                                            myReader["email_address"].ToString(),
                                            myReader["address"].ToString()));
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Fills the given ArrayList with all Supplier names.
        /// </summary>
        /// <param name="result">The ArrayList where all Supplier names will be stored.</param>
        public void SelectAllSupplierNames(ArrayList result)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT supplier_name FROM supplier_t;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    result.Add(myReader[0].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Retrieves the Supplier ID of a given Supplier name.
        /// </summary>
        /// <param name="supplierName"></param>
        /// <returns></returns>
        public int SelectSupplierID(string supplierName)
        {
            int idResult = -1;
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT supplier_id FROM supplier_t WHERE supplier_name = @SupplierName;", connection);
                command.Parameters.AddWithValue("@SupplierName", supplierName);
                object queryResult = command.ExecuteScalar();
                //MessageBox.Show("Supplier ID: " + queryResult.ToString()); //Debug purposes
                if (queryResult.ToString() != null)
                {
                    idResult = int.Parse(queryResult.ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return idResult;
        }

        /// <summary>
        /// For filling the Item Selection DataGridView with all the items a Supplier offers.
        /// NOTE: Supplier's Unit Price is displayed, NOT REIC's Unit Price.
        /// </summary>
        /// <param name="dgvName"></param>
        /// <param name="supplierID"></param>
        public void SelectSupplierItems(DataGridView dgvName, int supplierID)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT part_number, item_name, item_description, unit_of_measurement, TRUNCATE(supplier_unit_price, 2) " +
                                           "FROM item_t, supplier_t " +
                                           "WHERE supplier_t.supplier_id = @SupplierID " +
                                           "AND item_t.supplier_id = supplier_t.supplier_id;", connection);
                command.Parameters.AddWithValue("@SupplierID", supplierID);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["part_number"].ToString(),
                                     myReader["item_name"].ToString(),
                                     myReader["item_description"].ToString(),
                                     myReader["unit_of_measurement"].ToString(),
                                     myReader["TRUNCATE(supplier_unit_price, 2)"].ToString()); //TRUNCATE: Ensure 2 decimal places
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Displays the item search results in the Item Selection DataGridView.
        /// NOTE: Supplier's Unit Price is displayed, NOT REIC's Unit Price.
        /// </summary>
        /// <param name="dgvName">The DataGridView where the search results will be displayed.</param>
        /// <param name="searchType">By "Part Number" or by "Item Name"?</param>
        /// <param name="supplierID">Which Supplier's items to search for?</param>
        /// <param name="searchFor">What text to search for?</param>
        public void SearchSupplierItems(DataGridView dgvName, string searchType, int supplierID, string searchFor)
        {
            try
            {
                ConnectToSQL();
                string sqlSelectFromWhere = "SELECT part_number, item_name, item_description, unit_of_measurement, TRUNCATE(supplier_unit_price, 2) " +
                                            "FROM item_t, supplier_t " +
                                            "WHERE item_t.supplier_id = supplier_t.supplier_id " +
                                            "AND supplier_t.supplier_id = @SupplierID ";
                switch (searchType)
                {
                    case "Part Number":
                        command = new MySqlCommand(sqlSelectFromWhere + "AND part_number LIKE @SearchText;", connection);

                        break;

                    case "Item Name":
                        command = new MySqlCommand(sqlSelectFromWhere + "AND item_name LIKE @SearchText;", connection);
                        break;
                }
                command.Parameters.AddWithValue("@SupplierID", supplierID);
                command.Parameters.AddWithValue("@SearchText", "%" + searchFor + "%");
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["part_number"].ToString(),
                                     myReader["item_name"].ToString(),
                                     myReader["item_description"].ToString(),
                                     myReader["unit_of_measurement"].ToString(),
                                     myReader["TRUNCATE(supplier_unit_price, 2)"].ToString()); //TRUNCATE: Ensure 2 decimal places
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Retrieves all details of a specific Supplier.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Supplier SelectSupplierDetails(int id)
        {
            Supplier s = null;
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT * FROM supplier_t WHERE supplier_id = @SupplierID;", connection);
                command.Parameters.AddWithValue("@SupplierID", id);
                myReader = command.ExecuteReader();
                myReader.Read();
                s = new Supplier(id,
                                 myReader["supplier_name"].ToString(),
                                 myReader["contact_person"].ToString(),
                                 myReader["contact_number"].ToString(),
                                 myReader["email_address"].ToString(),
                                 myReader["address"].ToString());
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return s;
        }

        /// <summary>
        /// Fills the given ArrayList with all details of the RFQ table.
        /// </summary>
        /// <param name="result">The ArrayList where all details of the RFQ table will be stored.</param>
        public void SelectAllRFQ(ArrayList result)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT * FROM rfq_t;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    result.Add(new RFQ(myReader["rfq_no"].ToString(),
                                       myReader["date_of_request"].ToString(),
                                       myReader["payment_terms"].ToString(),
                                       myReader["delivery_terms"].ToString(),
                                       int.Parse(myReader["customer_id"].ToString()),
                                       int.Parse(myReader["supplier_id"].ToString()),
                                       myReader["pq_no"].ToString()));
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Populates the RFQ Main Screen's DataGridView.
        /// </summary>
        /// <param name="dgvName"></param>
        public void SelectAllRFQDGV(DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT rfq_no, DATE_FORMAT(date_of_request, '%m/%d/%Y'), supplier_name, company_name " +
                                           "FROM rfq_t, customer_t, supplier_t " +
                                           "WHERE rfq_t.customer_id = customer_t.customer_id " +
                                           "AND rfq_t.supplier_id = supplier_t.supplier_id;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["rfq_no"].ToString(),
                                     myReader["DATE_FORMAT(date_of_request, '%m/%d/%Y')"].ToString(),
                                     myReader["supplier_name"].ToString(),
                                     myReader["company_name"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Retrieves all details of a specific RFQ.
        /// *Used in RFQ View Forms, RFQ Crystal Report Printout
        /// </summary>
        /// <param name="rfqNo"></param>
        /// <returns></returns>
        public RFQ SelectRFQDetails(string rfqNo)
        { 
            RFQ r = null;
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT rfq_no, DATE_FORMAT(date_of_request, '%m/%d/%Y'), payment_terms, delivery_terms, customer_id, supplier_id, pq_no FROM rfq_t WHERE rfq_no = @RFQNo;", connection);
                //SELECT Statement is the same as "SELECT * FROM rfq_t WHERE rfq_no={0};" Had to mention all, since will format the date
                command.Parameters.AddWithValue("@RFQNo", rfqNo);
                myReader = command.ExecuteReader();
                myReader.Read();
                r = new RFQ(rfqNo,
                            myReader["DATE_FORMAT(date_of_request, '%m/%d/%Y')"].ToString(),
                            myReader["payment_terms"].ToString(),
                            myReader["delivery_terms"].ToString(),
                            int.Parse(myReader["customer_id"].ToString()),
                            int.Parse(myReader["supplier_id"].ToString()),
                            myReader["pq_no"].ToString());
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return r;
        }

        /// <summary>
        /// Retrieves all Order Lines of a specific RFQ.
        /// </summary>
        /// <param name="rfqNo"></param>
        /// <param name="dgvName"></param>
        public void SelectSpecificRFQOrderLine(string rfqNo, DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT item_name, item_description, quantity, unit_of_measurement " +
                                           "FROM rfq_order_line_t, item_t p " +
                                           "WHERE rfq_no = @RFQNo " +
                                           "AND rfq_order_line_t.part_number = p.part_number;", connection);
                command.Parameters.AddWithValue("@RFQNo", rfqNo);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["item_name"].ToString(),
                                     myReader["item_description"].ToString(),
                                     myReader["unit_of_measurement"].ToString(),
                                     int.Parse(myReader["quantity"].ToString()));
                    //MessageBox.Show("Added");
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rfqNo"></param>
        /// <param name="dgvName"></param>
        public void SelectSpecificPQRFQOrderLine(string rfqNo, DataGridView dgvName) //newly Added to avoid conflict with Gayle's use of selectspecificRFQOL
        { //Retrieves all OrderLines of a specific RFQ | Used in View Forms
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT item_name, p.part_number, item_description, reic_unit_price, quantity, unit_of_measurement, (reic_unit_price*quantity) tprice " +
                                           "FROM rfq_order_line_t, item_t p " +
                                           "WHERE rfq_no = @RFQNo " +
                                           "AND rfq_order_line_t.part_number = p.part_number;", connection);
                command.Parameters.AddWithValue("@RFQNo", rfqNo);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    double totalPrice = double.Parse(myReader["tprice"].ToString()); //to be able to put decimal point on the amount .ToString("0.00")
                    dgvName.Rows.Add(myReader["item_name"].ToString(),
                                     myReader["part_number"].ToString(),
                                     myReader["item_description"].ToString(),
                                     myReader["reic_unit_price"].ToString(),
                                     int.Parse(myReader["quantity"].ToString()),
                                     myReader["unit_of_measurement"].ToString(),
                                     totalPrice.ToString("0.00"));
                    //MessageBox.Show("Added");
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Fills the given ArrayList with all details of the PQ table.
        /// </summary>
        /// <param name="result"></param>
        public void SelectAllPQ(ArrayList result)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT * FROM pq_t;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    result.Add(new PQ(myReader["pq_no"].ToString(),
                                      myReader["pq_date"].ToString(),
                                      myReader["from_date"].ToString(),
                                      myReader["to_date"].ToString(),
                                      myReader["payment_terms"].ToString(),
                                      myReader["delivery_terms"].ToString(),
                                      myReader["bill_to"].ToString(),
                                      myReader["ship_to"].ToString(),
                                      myReader["in_favor_of"].ToString(),
                                      double.Parse(myReader["total_amount"].ToString()),
                                      int.Parse(myReader["customer_id"].ToString())));
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /// <summary>
        /// Populates the PQ Main Screen DataGridView. (Displays the actual Customer names, not their IDs.)
        /// </summary>
        /// <param name="dgvName"></param>
        public void SelectAllPQDGV(DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT DATE_FORMAT(pq_date, '%m/%d/%Y'), company_name, pq_no, CONCAT(DATE_FORMAT(from_date, '%m/%d/%Y'), ' - ', DATE_FORMAT(to_date, '%m/%d/%Y'))" +
                                           "FROM pq_t, customer_t " +
                                           "WHERE pq_t.customer_id = customer_t.customer_id ", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["DATE_FORMAT(pq_date, '%m/%d/%Y')"].ToString(),
                                     myReader["company_name"].ToString(),
                                     myReader["pq_no"].ToString(),
                                     myReader["CONCAT(DATE_FORMAT(from_date, '%m/%d/%Y'), ' - ', DATE_FORMAT(to_date, '%m/%d/%Y'))"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgvName"></param>
        public void PopulatePOFromPQ(DataGridView dgvName) // newly added for createpofrompq dgv to avoid conflict in populating dgv
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT DATE_FORMAT(pq_date, '%m/%d/%Y'), company_name, pq_no, CONCAT(DATE_FORMAT(from_date, '%m/%d/%Y'), ' - ', DATE_FORMAT(to_date, '%m/%d/%Y'))" +
                                           "FROM pq_t, customer_t " +
                                           "WHERE pq_t.customer_id = customer_t.customer_id ", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["pq_no"].ToString(),
                                     myReader["DATE_FORMAT(pq_date, '%m/%d/%Y')"].ToString(),
                                     myReader["company_name"].ToString(),
                                     myReader["CONCAT(DATE_FORMAT(from_date, '%m/%d/%Y'), ' - ', DATE_FORMAT(to_date, '%m/%d/%Y'))"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Retrieves all details of a specific PQ.
        /// </summary>
        /// <param name="pqNo"></param>
        /// <returns></returns>
        public PQ SelectPQDetails(string pqNo)
        {
            PQ p = null;
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT pq_no, DATE_FORMAT(pq_date, '%m/%d/%Y'), DATE_FORMAT(from_date, '%m/%d/%Y'), DATE_FORMAT(to_date, '%m/%d/%Y'), payment_terms, delivery_terms, bill_to, ship_to, in_favor_of, total_amount, customer_id FROM pq_t WHERE pq_no = @PQNo;", connection);
                command.Parameters.AddWithValue("@PQNo", pqNo);
                myReader = command.ExecuteReader();
                myReader.Read();
                p = new PQ(pqNo,
                           myReader["DATE_FORMAT(pq_date, '%m/%d/%Y')"].ToString(),
                           myReader["DATE_FORMAT(from_date, '%m/%d/%Y')"].ToString(),
                           myReader["DATE_FORMAT(to_date, '%m/%d/%Y')"].ToString(),
                           myReader["payment_terms"].ToString(),
                           myReader["delivery_terms"].ToString(),
                           myReader["bill_to"].ToString(),
                           myReader["ship_to"].ToString(),
                           myReader["in_favor_of"].ToString(),
                           double.Parse(myReader["total_amount"].ToString()),
                           int.Parse(myReader["customer_id"].ToString()));
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return p;
        }

        /// <summary>
        /// Retrieves all Order Lines of a specific PQ.
        /// </summary>
        /// <param name="pqNo"></param>
        /// <param name="dgvName"></param>
        public void SelectSpecificPQOrderLine(string pqNo, DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT item_name, item_description, unit_of_measurement, item_t.reic_unit_price, quantity, TRUNCATE(item_total, 2) " +
                                           "FROM pq_order_line_t, item_t " +
                                           "WHERE pq_no = @PQNo " +
                                           "AND pq_order_line_t.part_number = item_t.part_number;", connection);
                command.Parameters.AddWithValue("@PQNo", pqNo);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    double reic_unit_price = double.Parse(myReader["reic_unit_price"].ToString());
                    double total_item = double.Parse(myReader["TRUNCATE(item_total, 2)"].ToString());
                    dgvName.Rows.Add(myReader["item_name"].ToString(),
                                     myReader["item_description"].ToString(),
                                     myReader["unit_of_measurement"].ToString(),
                                     reic_unit_price.ToString("0.00"),
                                     int.Parse(myReader["quantity"].ToString()),
                                     total_item.ToString("0.00"));
                    //MessageBox.Show("Added");
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Retrieves the Order Line of a specific PQ.
        /// </summary>
        /// <param name="pqNo"></param>
        /// <returns></returns>
        public PQ_OrderLine SelectPQOrderLine(string pqNo)
        {
            PQ_OrderLine pqol = null;
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT item_t.part_number, item_t.reic_unit_price, quantity, item_total " +
                                           "FROM pq_order_line_t, item_t " +
                                           "WHERE pq_no = @PQNo " +
                                           "AND pq_order_line_t.part_number = item_t.part_number;", connection);
                command.Parameters.AddWithValue("@PQNo", pqNo);
                myReader = command.ExecuteReader();
                myReader.Read();
                double reic_unit_price = double.Parse(myReader["reic_unit_price"].ToString());
                double total_item = double.Parse(myReader["item_total"].ToString());
                pqol = new PQ_OrderLine(pqNo,
                                     myReader["part_number"].ToString(),
                                     double.Parse(reic_unit_price.ToString("0.00")),
                                     int.Parse(myReader["quantity"].ToString()),
                                     double.Parse(total_item.ToString("0.00")));

                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return pqol;
        }

        /// <summary>
        /// Fills the given ArrayList with all details of the PO table.
        /// </summary>
        /// <param name="result"></param>
        public void SelectAllPO(ArrayList result)
        {
            try
            {
                ConnectToSQL();
                //Logic
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        ///  Populates the PO Main Screen's DataGridView. (Also, displays the actual Customer and Supplier names, not their IDs.)
        /// </summary>
        /// <param name="dgvName"></param>
        public void SelectAllPODGV(DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT DATE_FORMAT(order_date, '%m/%d/%Y'), DATE_FORMAT(required_delivery_date, '%m/%d/%Y'), company_name, po_no, supplier_name " +
                                           "FROM po_t, customer_t, supplier_t " +
                                           "WHERE po_t.customer_id = customer_t.customer_id " +
                                           "AND po_t.supplier_id = supplier_t.supplier_id;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["DATE_FORMAT(order_date, '%m/%d/%Y')"].ToString(),
                                     myReader["DATE_FORMAT(required_delivery_date, '%m/%d/%Y')"].ToString(),
                                     myReader["company_name"].ToString(),
                                     myReader["po_no"].ToString(),
                                     myReader["supplier_name"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Fills the given ArrayList with all details of the SIDR table.
        /// </summary>
        /// <param name="result"></param>
        public void SelectAllSIDR(ArrayList result)
        {
            try
            {
                ConnectToSQL();
                //Logic
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Populates the SIDR Main Screen's DataGridView (Also, displays the actual Customer names, not their IDs)
        /// </summary>
        /// <param name="dgvName"></param>
        public void SelectAllSIDRDGV(DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT so_date, so_no, company_name, TRUNCATE(invoice_total, 2) " + //Truncate: Ensure X decimal places (in our case, 2)
                                           "FROM sidr_t, customer_t " +
                                           "WHERE sidr_t.customer_id = customer_t.customer_id;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["so_date"].ToString(),
                                     myReader["so_no"].ToString(),
                                     myReader["company_name"].ToString(),
                                     myReader["TRUNCATE(invoice_total, 2)"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //---------------------------------
        //  MAIN SCREEN SEARCH STATEMENTS |
        //---------------------------------
        public void SearchCustomer(string textToSearch, DataGridView dgvResults)
        { //Main Screen: 
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT company_name, contact_person, contact_number, email_address " +
                                           "FROM customer_t " +
                                           "WHERE company_name LIKE @CustomerName;", connection);
                command.Parameters.AddWithValue("@CustomerName", "%" + textToSearch + "%");
                myReader = command.ExecuteReader();
                if (myReader.HasRows)
                {
                    dgvResults.Rows.Clear(); //Make way for the search results
                }
                while (myReader.Read())
                {
                    dgvResults.Rows.Add(myReader["company_name"].ToString(),
                                        myReader["contact_person"].ToString(),
                                        myReader["contact_number"].ToString(),
                                        myReader["email_address"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SearchRFQ(string searchType, string textToSearch, DataGridView dgvResults)
        { //Main Screen: 
            try
            {
                ConnectToSQL();
                string whereClause = string.Empty;
                switch (searchType)
                {
                    case "Customer Name":
                        whereClause = "WHERE company_name LIKE @SearchText ";
                        break;
                    case "RFQ No.":
                        whereClause = "WHERE rfq_no LIKE @SearchText ";
                        break;
                    case "Request Date":
                        whereClause = "WHERE date_of_request LIKE @SearchText ";
                        break;
                }
                command = new MySqlCommand("SELECT rfq_no, DATE_FORMAT(date_of_request, '%m/%d/%Y'), supplier_name, company_name " +
                                           "FROM rfq_t, supplier_t, customer_t " +
                                            whereClause +
                                           "AND rfq_t.customer_id = customer_t.customer_id " +
                                           "AND rfq_t.supplier_id = supplier_t.supplier_id " +
                                           "ORDER BY rfq_no DESC;", connection);
                command.Parameters.AddWithValue("@SearchText", "%" + textToSearch + "%");
                myReader = command.ExecuteReader();
                if (myReader.HasRows)
                {
                    dgvResults.Rows.Clear();
                }
                while (myReader.Read())
                {
                    dgvResults.Rows.Add(myReader["rfq_no"].ToString(),
                                         myReader["DATE_FORMAT(date_of_request, '%m/%d/%Y')"].ToString(),
                                         myReader["supplier_name"].ToString(),
                                         myReader["company_name"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SearchPQ(string searchType, string textToSearch, DataGridView dgvResults)
        { //Main Screen: 
            try
            {
                ConnectToSQL();
                string whereClause = string.Empty;
                switch (searchType)
                {
                    case "Customer Name":
                        whereClause = "WHERE company_name LIKE @SearchText ";
                        break;
                    case "PQ No.":
                        whereClause = "WHERE pq_no LIKE @SearchText ";
                        break;
                    case "Quotation Date":
                        whereClause = "WHERE pq_date LIKE @SearchText ";
                        break;
                }
                command = new MySqlCommand("SELECT DATE_FORMAT(pq_date, '%m/%d/%Y'), company_name, pq_no, CONCAT(DATE_FORMAT(from_date, '%m/%d/%Y'), ' - ', DATE_FORMAT(to_date, '%m/%d/%Y')) " +
                                           "FROM pq_t, customer_t " +
                                            whereClause +
                                           "AND pq_t.customer_id = customer_t.customer_id " +
                                           "ORDER BY pq_no DESC;", connection);
                command.Parameters.AddWithValue("@SearchText", "%" + textToSearch + "%");
                myReader = command.ExecuteReader();
                if (myReader.HasRows)
                {
                    dgvResults.Rows.Clear();
                }
                while (myReader.Read())
                {
                    dgvResults.Rows.Add(myReader["DATE_FORMAT(pq_date, '%m/%d/%Y')"].ToString(),
                                         myReader["company_name"].ToString(),
                                         myReader["pq_no"].ToString(),
                                         myReader["CONCAT(DATE_FORMAT(from_date, '%m/%d/%Y'), ' - ', DATE_FORMAT(to_date, '%m/%d/%Y'))"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SearchPO(string searchType, string textToSearch, DataGridView dgvResults)
        { //Main Screen: 
            try
            {
                ConnectToSQL();
                string whereClause = string.Empty;
                switch (searchType)
                {
                    case "Customer Name":
                        whereClause = "WHERE company_name LIKE @SearchText ";
                        break;
                    case "PO No.":
                        whereClause = "WHERE pq_no LIKE @SearchText ";
                        break;
                    case "Order Date":
                        whereClause = "WHERE DATE_FORMAT(order_date, '%m/%d/%Y') LIKE @SearchText ";
                        break;
                }
                command = new MySqlCommand("SELECT DATE_FORMAT(order_date, '%m/%d/%Y'), DATE_FORMAT(required_delivery_date, '%m/%d/%Y'), company_name, po_no, supplier_name " +
                                           "FROM po_t, customer_t, supplier_t " +
                                            whereClause +
                                           "AND po_t.customer_id = customer_t.customer_id " +
                                           "AND po_t.supplier_id = supplier_t.supplier_id " +
                                           "ORDER BY po_no DESC;", connection);
                command.Parameters.AddWithValue("@SearchText", "%" + textToSearch + "%");
                myReader = command.ExecuteReader();
                if (myReader.HasRows)
                {
                    dgvResults.Rows.Clear();
                }
                while (myReader.Read())
                {
                    dgvResults.Rows.Add(myReader["DATE_FORMAT(order_date, '%m/%d/%Y')"].ToString(),
                                        myReader["DATE_FORMAT(required_delivery_date, '%m/%d/%Y')"].ToString(),
                                        myReader["company_name"].ToString(),
                                        myReader["po_no"].ToString(),
                                        myReader["supplier_name"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //-------------------------
        //  SPR SELECT STATEMENTS |
        //-------------------------
        /// <summary>
        /// Retrieves the sales of over the span of 12 months, starting from the specified date.
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="results"></param>
        public void SelectMonthlySales(DateTime fromDate, double[] results)
        {
            try
            {
                ConnectToSQL();
                for (int i = 0; i < 12; i++)
                {
                    DateTime dateToCheck = fromDate.AddMonths(i);
                    string year = dateToCheck.ToString("yyyy");
                    string month = dateToCheck.ToString("MM");
                    command = new MySqlCommand("SELECT TRUNCATE(SUM(invoice_total), 2) FROM sidr_t WHERE so_date LIKE @Date;", connection);
                    command.Parameters.AddWithValue("@Date", year + "-" + month + "%");
                    object queryResult = command.ExecuteScalar();
                    if (string.IsNullOrEmpty(queryResult.ToString()) == false)
                    {
                        results[i] = double.Parse(queryResult.ToString());
                    }
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Retrieves the sales of each fiscal year of a specified date range.
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="range"></param>
        /// <param name="results"></param>
        public void SelectAnnualSales(DateTime fromDate, DateTime toDate, int range, double[] results)
        {
            try
            {
                ConnectToSQL();
                for (int i = 0; i < range; i++)
                {
                    DateTime startFiscalYear = fromDate.AddYears(i);
                    DateTime endFiscalYear = startFiscalYear.AddMonths(12).AddDays(-1); //Assumes until the last day of the month
                    command = new MySqlCommand("SELECT TRUNCATE(SUM(invoice_total), 2) FROM sidr_t WHERE so_date BETWEEN @StartDate AND @EndDate;", connection);
                    command.Parameters.AddWithValue("@StartDate", startFiscalYear);
                    command.Parameters.AddWithValue("@EndDate", endFiscalYear);
                    object queryResult = command.ExecuteScalar();
                    if (string.IsNullOrEmpty(queryResult.ToString()) == false)
                    {
                        results[i] = double.Parse(queryResult.ToString());
                    }
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SelectPendingRFQ(DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT rfq_no, DATE_FORMAT(date_of_request, '%m/%d/%Y'), supplier_name, company_name " +
                                           "FROM rfq_t, supplier_t, customer_t " +
                                           "WHERE pq_no IS NULL " +
                                           "AND rfq_t.supplier_id = supplier_t.supplier_id " +
                                           "AND rfq_t.customer_id = customer_t.customer_id " +
                                           "ORDER BY rfq_no DESC;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["rfq_no"].ToString(),
                                     myReader["DATE_FORMAT(date_of_request, '%m/%d/%Y')"].ToString(),
                                     myReader["supplier_name"].ToString(),
                                     myReader["company_name"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void SelectCompletedRFQ(DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT rfq_no, DATE_FORMAT(date_of_request, '%m/%d/%Y'), supplier_name, company_name " +
                                           "FROM rfq_t, supplier_t, customer_t " +
                                           "WHERE pq_no IS NOT NULL " +
                                           "AND rfq_t.supplier_id = supplier_t.supplier_id " +
                                           "AND rfq_t.customer_id = customer_t.customer_id " +
                                           "ORDER BY rfq_no DESC;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["rfq_no"].ToString(),
                                     myReader["DATE_FORMAT(date_of_request, '%m/%d/%Y')"].ToString(),
                                     myReader["supplier_name"].ToString(),
                                     myReader["company_name"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SelectAllRFQSPR(DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT rfq_no, DATE_FORMAT(date_of_request, '%m/%d/%Y'), supplier_name, company_name " +
                                           "FROM rfq_t, supplier_t, customer_t " +
                                           "WHERE rfq_t.supplier_id = supplier_t.supplier_id " +
                                           "AND rfq_t.customer_id = customer_t.customer_id " +
                                           "ORDER BY rfq_no DESC;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["rfq_no"].ToString(),
                                     myReader["DATE_FORMAT(date_of_request, '%m/%d/%Y')"].ToString(),
                                     myReader["supplier_name"].ToString(),
                                     myReader["company_name"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SelectPendingPQ(DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand(//"SELECT DISTINCT pq_t.pq_no, DATE_FORMAT(pq_date, '%m/%d/%Y'), DATE_FORMAT(from_date, '%m/%d/%Y'), DATE_FORMAT(to_date, '%m/%d/%Y'), pq_t.payment_terms, pq_t.delivery_terms, in_favor_of, bill_to, ship_to, pq_t.total_amount, customer_t.customer_id  " +
                                           "SELECT DISTINCT DATE_FORMAT(pq_date, '%m/%d/%Y'), company_name, pq_t.pq_no, CONCAT(DATE_FORMAT(from_date, '%m/%d/%Y'), ' - ', DATE_FORMAT(to_date, '%m/%d/%Y')) " +
                                           "FROM customer_t, pq_t, po_t " +
                                           "WHERE pq_t.pq_no NOT IN (" +
                                               "SELECT po_t.pq_no " +
                                               "FROM po_t " +
                                               "WHERE pq_t.pq_no = po_t.pq_no) " +
                                           "AND pq_t.customer_id = customer_t.customer_id " +
                                           "ORDER BY pq_t.pq_no DESC;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["DATE_FORMAT(pq_date, '%m/%d/%Y')"].ToString(),
                                     myReader["company_name"].ToString(),
                                     myReader["pq_no"].ToString(),
                                     myReader["CONCAT(DATE_FORMAT(from_date, '%m/%d/%Y'), ' - ', DATE_FORMAT(to_date, '%m/%d/%Y'))"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SelectCompletedPQ(DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT DISTINCT DATE_FORMAT(pq_date, '%m/%d/%Y'), company_name, pq_t.pq_no, CONCAT(DATE_FORMAT(from_date, '%m/%d/%Y'), ' - ', DATE_FORMAT(to_date, '%m/%d/%Y')) " +
                                           "FROM customer_t, pq_t, po_t " +
                                           "WHERE pq_t.pq_no = po_t.pq_no " +
                                           "AND pq_t.customer_id = customer_t.customer_id " +
                                           "ORDER BY pq_t.pq_no DESC;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["DATE_FORMAT(pq_date, '%m/%d/%Y')"].ToString(),
                                     myReader["company_name"].ToString(),
                                     myReader["pq_no"].ToString(),
                                     myReader["CONCAT(DATE_FORMAT(from_date, '%m/%d/%Y'), ' - ', DATE_FORMAT(to_date, '%m/%d/%Y'))"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SelectAllPQSPR(DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT DISTINCT DATE_FORMAT(pq_date, '%m/%d/%Y'), company_name, pq_t.pq_no, CONCAT(DATE_FORMAT(from_date, '%m/%d/%Y'), ' - ', DATE_FORMAT(to_date, '%m/%d/%Y')) " +
                                           "FROM customer_t, pq_t, po_t " +
                                           "WHERE pq_t.customer_id = customer_t.customer_id " +
                                           "ORDER BY pq_t.pq_no DESC;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["DATE_FORMAT(pq_date, '%m/%d/%Y')"].ToString(),
                                     myReader["company_name"].ToString(),
                                     myReader["pq_no"].ToString(),
                                     myReader["CONCAT(DATE_FORMAT(from_date, '%m/%d/%Y'), ' - ', DATE_FORMAT(to_date, '%m/%d/%Y'))"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SelectPendingPO(DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT DATE_FORMAT(order_date, '%m/%d/%Y'), DATE_FORMAT(required_delivery_date, '%m/%d/%Y'), company_name, po_no, supplier_name " +
                                           "FROM po_t, customer_t, supplier_t " +
                                           "WHERE so_no IS NULL " +
                                           "AND po_t.customer_id = customer_t.customer_id " +
                                           "AND po_t.supplier_id = supplier_t.supplier_id " +
                                           "ORDER BY po_no DESC;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["DATE_FORMAT(order_date, '%m/%d/%Y')"].ToString(),
                                     myReader["DATE_FORMAT(required_delivery_date, '%m/%d/%Y')"].ToString(),
                                     myReader["company_name"].ToString(),
                                     myReader["po_no"].ToString(),
                                     myReader["supplier_name"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SelectCompletedPO(DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT DATE_FORMAT(order_date, '%m/%d/%Y'), DATE_FORMAT(required_delivery_date, '%m/%d/%Y'), company_name, po_no, supplier_name " +
                                           "FROM po_t, customer_t, supplier_t " +
                                           "WHERE so_no IS NOT NULL " +
                                           "AND po_t.customer_id = customer_t.customer_id " +
                                           "AND po_t.supplier_id = supplier_t.supplier_id " +
                                           "ORDER BY po_no DESC;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["DATE_FORMAT(order_date, '%m/%d/%Y')"].ToString(),
                                     myReader["DATE_FORMAT(required_delivery_date, '%m/%d/%Y')"].ToString(),
                                     myReader["company_name"].ToString(),
                                     myReader["po_no"].ToString(),
                                     myReader["supplier_name"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SelectAllPOSPR(DataGridView dgvName)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("SELECT DATE_FORMAT(order_date, '%m/%d/%Y'), DATE_FORMAT(required_delivery_date, '%m/%d/%Y'), company_name, po_no, supplier_name " +
                                           "FROM po_t, customer_t, supplier_t " +
                                           "WHERE po_t.customer_id = customer_t.customer_id " +
                                           "AND po_t.supplier_id = supplier_t.supplier_id " +
                                           "ORDER BY po_no DESC;", connection);
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    dgvName.Rows.Add(myReader["DATE_FORMAT(order_date, '%m/%d/%Y')"].ToString(),
                                     myReader["DATE_FORMAT(required_delivery_date, '%m/%d/%Y')"].ToString(),
                                     myReader["company_name"].ToString(),
                                     myReader["po_no"].ToString(),
                                     myReader["supplier_name"].ToString());
                }
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //---------------------
        //  INSERT STATEMENTS |
        //---------------------
        //STR_TO_DATE Function: http://www.w3resource.com/mysql/date-and-time-functions/mysql-str_to_date-function.php
        public void InsertItem(Item i)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("INSERT INTO item_t (part_number, item_name, item_description, supplier_unit_price, mark_up_percentage, reic_unit_price, minimum_order_quantity, unit_of_measurement, from_date, to_date, supplier_id) " +
                                           "VALUES (@PartNumber, @ItemName, @Description, @SupplierUnitPrice, @Markup, @ReicUnitPrice, @Moq, @Uom, STR_TO_DATE(@FromDate, '%m/%d/%Y'), STR_TO_DATE(@ToDate, '%m/%d/%Y'), @SupplierID);", connection);
                command.Parameters.AddWithValue("@PartNumber", i.PartNumber);
                command.Parameters.AddWithValue("@ItemName", i.ItemName);
                command.Parameters.AddWithValue("@Description", i.ItemDescription);
                command.Parameters.AddWithValue("@SupplierUnitPrice", i.SupplierUnitPrice);
                command.Parameters.AddWithValue("@Markup", i.Markup);
                command.Parameters.AddWithValue("@ReicUnitPrice", i.ReicUnitPrice);
                command.Parameters.AddWithValue("@Moq", i.Moq);
                command.Parameters.AddWithValue("@Uom", i.Uom);
                command.Parameters.AddWithValue("@FromDate", i.FromDateNoTime);
                command.Parameters.AddWithValue("@ToDate", i.ToDateNoTime);
                command.Parameters.AddWithValue("@SupplierID", i.SupplierID);
                command.ExecuteNonQuery();
                MessageBox.Show(i.ItemName + " has been successfully added.");
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        public void InsertSupplier(Supplier s)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("INSERT INTO supplier_t (supplier_id, supplier_name, contact_person, contact_number, email_address, address) " +
                                           "VALUES (@SupplierID, @SupplierName, @ContactPerson, @ContactNumber, @EmailAddress, @Address);", connection);
                command.Parameters.AddWithValue("@SupplierID", s.SupplierID);
                command.Parameters.AddWithValue("@SupplierName", s.SupplierName);
                command.Parameters.AddWithValue("@ContactPerson", s.SupplierPerson);
                command.Parameters.AddWithValue("@ContactNumber", s.SupplierNumber);
                command.Parameters.AddWithValue("@EmailAddress", s.SupplierEmail);
                command.Parameters.AddWithValue("@Address", s.SupplierAddress);
                command.ExecuteNonQuery();
                MessageBox.Show(s.SupplierName + " has been successfully added as a Supplier.");
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertCustomer(Customer c)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("INSERT INTO customer_t (customer_id, business_name_style, tin_number, company_name, contact_person, contact_number, account_number, email_address, address) " +
                                           "VALUES (@CustomerID, @BusinessName, @TinNumber, @CustomerName, @ContactPerson, @ContactNumber, @AccountNumber, @EmailAddress, @Address);", connection);
                command.Parameters.AddWithValue("@CustomerID", c.CustomerID);
                command.Parameters.AddWithValue("@BusinessName", c.BusinessName);
                command.Parameters.AddWithValue("@TinNumber", c.TinNumber);
                command.Parameters.AddWithValue("@CustomerName", c.CustomerName);
                command.Parameters.AddWithValue("@ContactPerson", c.CustomerPerson);
                command.Parameters.AddWithValue("@ContactNumber", c.CustomerNumber);
                command.Parameters.AddWithValue("@AccountNumber", c.AccountNumber);
                command.Parameters.AddWithValue("@EmailAddress", c.CustomerEmail);
                command.Parameters.AddWithValue("@Address", c.CustomerAddress);
                command.ExecuteNonQuery();
                MessageBox.Show(c.CustomerName + " has been successfully added as a Customer.");
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertRFQ(RFQ r)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("INSERT INTO rfq_t (rfq_no, date_of_request, payment_terms, delivery_terms, customer_id, supplier_id, pq_no) " +
                                           "VALUES (@RFQNo, STR_TO_DATE(@RFQDate, '%m/%d/%Y'), @PaymentTerms, @DeliveryTerms, @CustomerID, @SupplierID, @PQNo);", connection);
                command.Parameters.AddWithValue("@RFQNo", r.RFQNo);
                command.Parameters.AddWithValue("@RFQDate", r.RequestDate);
                command.Parameters.AddWithValue("@PaymentTerms", r.PaymentTerms);
                command.Parameters.AddWithValue("@DeliveryTerms", r.DeliveryTerms);
                command.Parameters.AddWithValue("@CustomerID", r.CustomerID);
                command.Parameters.AddWithValue("@SupplierID", r.SupplierID);
                command.Parameters.AddWithValue("@PQNo", DBNull.Value); //PQ_No foreign key will be set when its PQ has been created
                command.ExecuteNonQuery();
                MessageBox.Show("RFQ " + r.RFQNo + " has been successfully created.");
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertRFQOrderLine(RFQ_OrderLine rol)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("INSERT INTO rfq_order_line_t (rfq_no, part_number, quantity) " +
                                           "VALUES (@RFQNo, @PartNumber, @Quantity);", connection);
                command.Parameters.AddWithValue("@RFQNo", rol.RFQNo);
                command.Parameters.AddWithValue("@PartNumber", rol.PartNumber);
                command.Parameters.AddWithValue("@Quantity", rol.Quantity);
                command.ExecuteNonQuery();
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertPQ(PQ p)    
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("INSERT INTO pq_t (pq_no, pq_date, from_date, to_date, payment_terms, delivery_terms, bill_to, ship_to, in_favor_of, total_amount, customer_id) " +
                                           "VALUES (@PQNo, STR_TO_DATE(@PQDate, '%m/%d/%Y'), STR_TO_DATE(@FromDate, '%m/%d/%Y'), STR_TO_DATE(@ToDate, '%m/%d/%Y'), @PaymentTerms, @DeliveryTerms, @BillTo, @ShipTo, @InFavorOf, @TotalAmount, @CustomerID);", connection);
                command.Parameters.AddWithValue("@PQNo", p.PQNo);
                command.Parameters.AddWithValue("@PQDate", p.PQDate);
                command.Parameters.AddWithValue("@FromDate", p.PQFromDate);
                command.Parameters.AddWithValue("@ToDate", p.PQToDate);
                command.Parameters.AddWithValue("@PaymentTerms", p.PaymentTerms);
                command.Parameters.AddWithValue("@DeliveryTerms", p.DeliveryTerms);
                command.Parameters.AddWithValue("@BillTo", p.BillTo);
                command.Parameters.AddWithValue("@ShipTo", p.ShipTo);
                command.Parameters.AddWithValue("@InFavorOf", p.InFavorOf);
                command.Parameters.AddWithValue("@TotalAmount", p.TotalAmount);
                command.Parameters.AddWithValue("@CustomerID", p.CustomerID);
                command.ExecuteNonQuery();
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        public void InsertPQOrderLine(PQ_OrderLine pol)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("INSERT INTO pq_order_line_t (pq_no, part_number, reic_unit_price, quantity, item_total) " +
                                           "VALUES (@PQNo, @PartNumber, @ReicUnitPrice, @Quantity, @ItemTotal);", connection);
                command.Parameters.AddWithValue("@PQNo", pol.PQNo);
                command.Parameters.AddWithValue("@PartNumber", pol.PartNumber);
                command.Parameters.AddWithValue("@ReicUnitPrice", pol.ReicUnitPrice);
                command.Parameters.AddWithValue("@Quantity", pol.Quantity);
                command.Parameters.AddWithValue("@ItemTotal", pol.ItemTotal);
                command.ExecuteNonQuery();
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InsertPO(PO p)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("INSERT INTO po_t (po_no, order_date, required_delivery_date, order_description, pq_no, payment_terms, delivery_terms, net_item_subtotal, delivery_cost, order_total, supplier_id, customer_id, so_no) " +
                                           "VALUES (@PONo, @OrderDate, @DeliveryDate, @Description, @PQNo, @PaymentTerms, @DeliveryTerms, @NetSubtotal, @DeliveryCost, @OrderTotal, @SupplierID, @CustomerID, @SONo);", connection);
                command.Parameters.AddWithValue("@PONo", p.PONo);
                command.Parameters.AddWithValue("@OrderDate", p.OrderDate);
                command.Parameters.AddWithValue("@DeliveryDate", p.DeliveryDate);
                command.Parameters.AddWithValue("@Description", p.OrderDescription);
                command.Parameters.AddWithValue("@PQNo", p.PQNo);
                command.Parameters.AddWithValue("@PaymentTerms", p.PaymentTerms);
                command.Parameters.AddWithValue("@DeliveryTerms", p.DeliveryTerms);
                command.Parameters.AddWithValue("@NetSubtotal", p.NetSubtotal);
                command.Parameters.AddWithValue("@DeliveryCost", p.DeliveryCost);
                command.Parameters.AddWithValue("@OrderTotal", p.OrderTotal);
                command.Parameters.AddWithValue("@SupplierID", p.SupplierID);
                command.Parameters.AddWithValue("@CustomerID", p.CustomerID);
                command.Parameters.AddWithValue("@SONo", DBNull.Value); //SO foreign key will be set when the PO's SO has been created
                command.ExecuteNonQuery();
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InsertPOOrderLine(PO_OrderLine pol)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("INSERT INTO po_order_line_t (po_no, part_number, supplier_unit_price, quantity, item_total) " +
                                           "VALUES (@PONo, @PartNumber, @SupplierUnitPrice, @Quantity, @ItemTotal);", connection);
                command.Parameters.AddWithValue("@PONo", pol.PONo);
                command.Parameters.AddWithValue("@PartNumber", pol.PartNumber);
                command.Parameters.AddWithValue("@SupplierUnitPrice", pol.SupplierUnitPrice);
                command.Parameters.AddWithValue("@Quantity", pol.Quantity);
                command.Parameters.AddWithValue("@ItemTotal", pol.ItemTotal);
                command.ExecuteNonQuery();
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*
        public void InsertSIDR(SIDR s)
        {

        }

        public void InsertSIDROrderLine(SIDR_OrderLine sol)
        {

        }
        */

        //---------------------
        //  UPDATE STATEMENTS |
        //---------------------
        public void UpdateItem(Item i)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("UPDATE item_t " +
                                           "SET item_name=@ItemName, item_description=@Description, supplier_unit_price=@SupplierUnitPrice, mark_up_percentage=@Markup, reic_unit_price=@ReicUnitPrice, minimum_order_quantity=@Moq, unit_of_measurement=@Uom, from_date=STR_TO_DATE(@FromDate, '%m/%d/%Y'), to_date=STR_TO_DATE(@ToDate, '%m/%d/%Y'), supplier_id=@SupplierID " +
                                           "WHERE part_number=@PartNumber;", connection);
                command.Parameters.AddWithValue("@ItemName", i.ItemName);
                command.Parameters.AddWithValue("@Description", i.ItemDescription);
                command.Parameters.AddWithValue("@SupplierUnitPrice", i.SupplierUnitPrice);
                command.Parameters.AddWithValue("@Markup", i.Markup);
                command.Parameters.AddWithValue("@ReicUnitPrice", i.ReicUnitPrice);
                command.Parameters.AddWithValue("@Moq", i.Moq);
                command.Parameters.AddWithValue("@Uom", i.Uom);
                command.Parameters.AddWithValue("@FromDate", i.FromDateNoTime);
                command.Parameters.AddWithValue("@ToDate", i.ToDateNoTime);
                command.Parameters.AddWithValue("@SupplierID", i.SupplierID);
                command.Parameters.AddWithValue("@PartNumber", i.PartNumber);
                command.ExecuteNonQuery();
                MessageBox.Show(i.ItemName + " has been successfully updated.");
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateCustomer(Customer c)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("UPDATE customer_t " +
                                           "SET business_name_style=@BusinessName, tin_number=@TinNumber, company_name=@CustomerName, contact_person=@ContactPerson, contact_number=@ContactNumber, account_number=@AccountNumber, email_address=@EmailAddress, address=@Address " +
                                           "WHERE customer_id=@CustomerID;", connection);
                command.Parameters.AddWithValue("@BusinessName", c.BusinessName);
                command.Parameters.AddWithValue("@TinNumber", c.TinNumber);
                command.Parameters.AddWithValue("@CustomerName", c.CustomerName);
                command.Parameters.AddWithValue("@ContactPerson", c.CustomerPerson);
                command.Parameters.AddWithValue("@ContactNumber", c.CustomerNumber);
                command.Parameters.AddWithValue("@AccountNumber", c.AccountNumber);
                command.Parameters.AddWithValue("@EmailAddress", c.CustomerEmail);
                command.Parameters.AddWithValue("@Address", c.CustomerAddress);
                command.Parameters.AddWithValue("@CustomerID", c.CustomerID);
                command.ExecuteNonQuery();
                MessageBox.Show(c.CustomerName + " has been successfully updated.");
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateSupplier(Supplier s)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand("UPDATE supplier_t " +
                                           "SET supplier_name=@SupplierName, contact_person=@ContactPerson, contact_number=@ContactNumber, email_address=@EmailAddress, address=@Address " +
                                           "WHERE supplier_id=@SupplierID;", connection);
                command.Parameters.AddWithValue("@SupplierName", s.SupplierName);
                command.Parameters.AddWithValue("@ContactPerson", s.SupplierPerson);
                command.Parameters.AddWithValue("@ContactNumber", s.SupplierNumber);
                command.Parameters.AddWithValue("@EmailAddress", s.SupplierEmail);
                command.Parameters.AddWithValue("@Address", s.SupplierAddress);
                command.Parameters.AddWithValue("@SupplierID", s.SupplierID);
                command.ExecuteNonQuery();
                MessageBox.Show(s.SupplierName + " has been successfully updated.");
                DisconnectFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
