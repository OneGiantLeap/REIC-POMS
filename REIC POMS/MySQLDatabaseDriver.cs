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
        private MySqlCommand countCommand; //Added (used in Select methods)
        private MySqlDataReader myReader; //Added

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
            connection = new MySqlConnection("server=localhost; database=reicpoms; user=root; password=; convert zero datetime=true; allow zero datetime=true;");
            connection.Open();

            //DEBUG MESSAGES
            /*if (connection.State == System.Data.ConnectionState.Open)
            { MessageBox.Show("Connection to SQL successful!"); }
            else
            { MessageBox.Show("Connection to SQL failed!"); }*/
        }

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
        // using MySql.Data.MySqlClient;
        // If access denied, try running Visual Studio as an Administrator
        // So far, tested to backup & restore in C:\. Tried elsewhere but received an "access denied" error.
    /*    public void Backup()
        { //Called everytime the User clicks on "X" to close the POMS
            string constring = "server=localhost; user=root; pwd=; database=reicpoms;";
            string file = "C:\\REIC Files\\reicpoms_backup.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
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
        */
    /*    public void Restore()
        { //Called upon launching the system (Log-in Screen)
          //NOTE: This will result to an error if you don't have the reicpoms_backup.sql file in your C:\\
            string constring = "server=localhost; user=root; pwd=; database=reicpoms;";
            string file = "C:\\REIC Files\\reicpoms_backup.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
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
        */
        //---------------------
        //  SELECT STATEMENTS |
        //---------------------
        public int GetRowCount(string tableName, string year, string month)
        { //Purpose: Aid in autogeneration of RFQ, PQ, and PO numbers
            ConnectToSQL();
            string yearMonth = year + month;
            //MessageBox.Show("Yearmonth:" + yearMonth);
            switch (tableName)
            {
                case "rfq_t":
                    countCommand = new MySqlCommand(string.Format("SELECT COUNT(*) FROM rfq_t WHERE rfq_no LIKE '{0}%'" + ";", yearMonth), connection);
                    break;
                case "pq_t":
                    countCommand = new MySqlCommand(string.Format("SELECT COUNT(*) FROM pq_t WHERE pq_no LIKE '{0}%'" + ";", yearMonth), connection);
                    break;
                case "po_t":
                    countCommand = new MySqlCommand(string.Format("SELECT COUNT(*) FROM po_t WHERE po_no LIKE '{0}%'" + ";", yearMonth), connection);
                    break;
            }
            object countReader = countCommand.ExecuteScalar();
            int rowCount = int.Parse(countReader.ToString());
            //MessageBox.Show(rowCount.ToString()); //Debug purposes
            DisconnectFromSQL();
            return rowCount;
        }

        public void SelectAllItems(ArrayList result)
        { //Purpose: Streamreader data from database into ArrayList
            
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
            ConnectToSQL();

            command = new MySqlCommand(string.Format("SELECT part_number, item_name, supplier_name " +
                                             "FROM item_t, supplier_t " +
                                             "WHERE item_t.part_number = {0} " +
                                             "AND item_t.supplier_id = supplier_t.supplier_id;", inputSearch), connection);
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

        public void SelectAllItemsDGV(DataGridView dgvName)
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

        public double SelectItemPrice(string partNumber)
        {
            ConnectToSQL();
            double priceResult;
            command = new MySqlCommand(string.Format("SELECT reic_unit_price FROM item_t WHERE part_number = '{0}';",partNumber), connection);
            object queryPrice = command.ExecuteScalar();
            //MessageBox.Show("Unit Price: " + queryPrice.ToString()); //Debug purposes
            priceResult = double.Parse(queryPrice.ToString());
            DisconnectFromSQL();
            return priceResult;
        }

        public Item SelectItemDetails(string partNumber) //NEWLY ADDED
        { //Retrieves a specific PQ's row | Used in View Forms of PQ
            ConnectToSQL();
            Item item;
            command = new MySqlCommand(string.Format("SELECT * FROM item_t WHERE part_number='{0}';", partNumber), connection);
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

        public void SelectPOItems(string supplierID, DataGridView dgvName)
        { //Retrieves all OrderLines of a specific PQ | Used in View Forms
            ConnectToSQL();
            MessageBox.Show("push pa");
            command = new MySqlCommand(string.Format("SELECT item_name, item_description, unit_of_measurement, item_t.reic_unit_price, quantity, item_total " +
                                                     "FROM item_t, pq_order_line_t  " +
                                                     "WHERE supplier_id='{0}' " +
                                                     "AND pq_order_line_t.part_number = item_t.part_number; ", supplierID), connection);
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

        public int GetPNCount(string partNumber)
        { //Purpose: Count if partnumber already exist
            ConnectToSQL();
            //MessageBox.Show("code runs until here"); //debug
            { 
                    countCommand = new MySqlCommand(string.Format("SELECT COUNT(*) FROM item_t WHERE part_number LIKE '{0}%'" + ";", partNumber), connection);
            }
            object countReader = countCommand.ExecuteScalar();
            int rowCount = int.Parse(countReader.ToString());
            //MessageBox.Show(rowCount.ToString()); //Debug purposes
            DisconnectFromSQL();
            return rowCount;
        }


        public void SelectAllCustomers(ArrayList result)
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

        public void SelectAllCustomerNames(ArrayList result)
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

        public int SelectCustomerID(string customerName)
        {
            ConnectToSQL();
            int idResult;
            command = new MySqlCommand(string.Format("SELECT customer_id FROM customer_t WHERE company_name='{0}';", customerName), connection);
            object queryResult = command.ExecuteScalar();
            //MessageBox.Show("Customer ID: " + queryResult.ToString()); //Debug purposes
            idResult = int.Parse(queryResult.ToString());
            DisconnectFromSQL();
            return idResult;
        }

        public Customer SelectCustomerDetails(int id)
        { //Retrieves a specific Customer's row | Used in PQ getting from rfq
            ConnectToSQL();
            Customer c;
            command = new MySqlCommand(string.Format("SELECT * FROM customer_t WHERE customer_id={0};", id), connection);
            myReader = command.ExecuteReader();
            myReader.Read();
            c = new Customer(id,
                             myReader["business_name_style"].ToString(),
                             myReader["tin_number"].ToString(),
                             myReader["company_name"].ToString(),
                             myReader["contact_person"].ToString(),
                             myReader["contact_number"].ToString(),
                             myReader["account_number"].ToString(),
                             myReader["email_address"].ToString(),
                             myReader["address"].ToString());
            DisconnectFromSQL();
            return c;
        }

        public void SelectAllSuppliers(ArrayList result)
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

        public void SelectAllSupplierNames(ArrayList result)
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

        public int SelectSupplierID(string supplierName)
        {
            ConnectToSQL();
            int idResult;
            command = new MySqlCommand(string.Format("SELECT supplier_id FROM supplier_t WHERE supplier_name='{0}';", supplierName), connection);
            object queryResult = command.ExecuteScalar();
            //MessageBox.Show("Supplier ID: " + queryResult.ToString()); //Debug purposes
            idResult = int.Parse(queryResult.ToString());
            DisconnectFromSQL();
            return idResult;
        }

        public void SelectSupplierItems(DataGridView dgvName, int supplierID)
        { //For populating the dgvItemSelection of the forms (IMPORTANT: SUPPLIER'S PRICE)
            ConnectToSQL();
            command = new MySqlCommand(string.Format("SELECT part_number, item_name, item_description, unit_of_measurement, supplier_unit_price " +
                                                     "FROM item_t, supplier_t " +
                                                     "WHERE supplier_t.supplier_id = {0} " +
                                                     "AND item_t.supplier_id = supplier_t.supplier_id;", supplierID), connection);
            myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                dgvName.Rows.Add(myReader["part_number"].ToString(),
                                 myReader["item_name"].ToString(),
                                 myReader["item_description"].ToString(),
                                 myReader["unit_of_measurement"].ToString(),
                                 myReader["supplier_unit_price"].ToString()); //Double-check: Should have 2 decimal points
            }
            DisconnectFromSQL();
        }

        public Supplier SelectSupplierDetails(int id)
        { //Retrieves a specific Supplier's row | Used in View Forms of RFQ and PO
            ConnectToSQL();
            Supplier s;
            command = new MySqlCommand(string.Format("SELECT * FROM supplier_t WHERE supplier_id={0};", id), connection);
            myReader = command.ExecuteReader();
            myReader.Read();
            s = new Supplier(id,
                             myReader["supplier_name"].ToString(),
                             myReader["contact_person"].ToString(),
                             myReader["contact_number"].ToString(),
                             myReader["email_address"].ToString(),
                             myReader["address"].ToString());
            DisconnectFromSQL();
            return s;
        }

        public void SelectAllRFQ(ArrayList result)
        { //For the ArrayList containing ALL RFQ | Used to set values of View Form's labels
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

        public void SelectAllRFQDGV(DataGridView dgvName)
        { //To populate the RFQ Main Screen DGV (Plus the actual Customer & Supplier names, not their IDs)
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
              

        public RFQ SelectRFQDetails(string rfqNo) //NEWLY ADDED
        { //Retrieves a specific RFQ's row | Used in View Forms of RFQ & RFQPrintout Crystal Reports
            ConnectToSQL();
            RFQ r;
            command = new MySqlCommand(string.Format("SELECT rfq_no, DATE_FORMAT(date_of_request, '%m/%d/%Y'), payment_terms, delivery_terms, customer_id, supplier_id, pq_no FROM rfq_t WHERE rfq_no='{0}';", rfqNo), connection);
            //SELECT Statement is the same as "SELECT * FROM rfq_t WHERE rfq_no={0};" Had to mention all, since will format the date
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
            return r;
        }

        public void SelectSpecificRFQOrderLine(string rfqNo, DataGridView dgvName)
        { //Retrieves all OrderLines of a specific RFQ | Used in View Forms
            ConnectToSQL();
            command = new MySqlCommand(string.Format("SELECT item_name, item_description, quantity, unit_of_measurement " +
                                                     "FROM rfq_order_line_t, item_t p " +
                                                     "WHERE rfq_no='{0}' " +
                                                     "AND rfq_order_line_t.part_number = p.part_number; ", rfqNo), connection);
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

        public void SelectSpecificPQRFQOrderLine(string rfqNo, DataGridView dgvName) //newly Added to avoid conflict with Gayle's use of selectspecificRFQOL
        { //Retrieves all OrderLines of a specific RFQ | Used in View Forms
            ConnectToSQL();
            command = new MySqlCommand(string.Format("SELECT item_name, p.part_number, item_description, reic_unit_price, quantity, unit_of_measurement, (reic_unit_price*quantity) tprice " +
                                                     "FROM rfq_order_line_t, item_t p " +
                                                     "WHERE rfq_no='{0}' " +
                                                     "AND rfq_order_line_t.part_number = p.part_number; ", rfqNo), connection);
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
                                 totalPrice.ToString("0.00")
                                );

                //MessageBox.Show("Added");
            }
            DisconnectFromSQL();
        }


        public void SelectAllPQ(ArrayList result)
        { //For the ArrayList containing ALL PQ
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
        
        public void SelectAllPQDGV(DataGridView dgvName)
        { //To populate the PQ Main Screen DGV (Plus the actual Customer names, not their IDs)
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

        public void PopulatePOFromPQ(DataGridView dgvName) // newly added for createpofrompq dgv to avoid conflict in populating dgv
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

        public PQ SelectPQDetails(string pqNo) //NEWLY ADDED
        { //Retrieves a specific PQ's row | Used in View Forms of PQ
            ConnectToSQL();
            PQ p;
            command = new MySqlCommand(string.Format("SELECT pq_no, DATE_FORMAT(pq_date, '%m/%d/%Y'), DATE_FORMAT(from_date, '%m/%d/%Y'), DATE_FORMAT(to_date, '%m/%d/%Y'), payment_terms, delivery_terms, bill_to, ship_to, in_favor_of, total_amount, customer_id FROM pq_t WHERE pq_no='{0}';", pqNo), connection);
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
            return p;
        }

    public void SelectSpecificPQOrderLine(string pqNo, DataGridView dgvName)
        { //Retrieves all OrderLines of a specific PQ | Used in View Forms
            ConnectToSQL();
            command = new MySqlCommand(string.Format("SELECT item_name, item_description, unit_of_measurement, item_t.reic_unit_price, quantity, item_total " +
                                                     "FROM pq_order_line_t, item_t " +
                                                     "WHERE pq_no='{0}' " +
                                                     "AND pq_order_line_t.part_number = item_t.part_number; ", pqNo), connection);
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
                //MessageBox.Show("Added");
            }
            DisconnectFromSQL();
        }

        public PQ_OrderLine SelectPQOrderLine(string pqNo)
        { //Retrieve OrderLine of a specific PQ | Used in Create PO
            ConnectToSQL();
            PQ_OrderLine pqol;
            command = new MySqlCommand(string.Format("SELECT item_t.part_number, item_t.reic_unit_price, quantity, item_total " +
                                                     "FROM pq_order_line_t, item_t " +
                                                     "WHERE pq_no='{0}' " +
                                                     "AND pq_order_line_t.part_number = item_t.part_number; ", pqNo), connection);
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
            return pqol;
        }
      
        public void SelectAllPO(ArrayList result)
        { //For the ArrayList containing ALL PO

        }

        public void SelectAllPODGV(DataGridView dgvName)
        { //To populate the PO Main Screen DGV (Plus the actual Customer and Supplier names, not their IDs)
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

        public void SelectAllSIDR(ArrayList result)
        { //For the ArrayList containing ALL SIDR

        }

        public void SelectAllSIDRDGV(DataGridView dgvName)
        { //To populate the SIDR Main Screen DGV (Plus the actual Customer names, not their IDs)

        }

        //---------------------------------
        //  MAIN SCREEN SEARCH STATEMENTS |
        //---------------------------------
        public void SearchCustomer(string textToSearch, DataGridView dgvResults)
        { //Main Screen: 
            ConnectToSQL();
            command = new MySqlCommand(string.Format("SELECT company_name, contact_person, contact_number, email_address " +
                                                    "FROM customer_t " +
                                                    "WHERE company_name LIKE '%{0}%'; ", textToSearch), connection);
            myReader = command.ExecuteReader();
            if (myReader.Read()) //Has laman, so for sure have to empty the dgvResults
            {
                dgvResults.Rows.Clear();
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

        public void SearchRFQ(string searchType, string textToSearch, DataGridView dgvResults)
        { //Main Screen: 
            ConnectToSQL();
            switch (searchType)
            {
                case "Customer Name":
                    command = new MySqlCommand(string.Format("SELECT rfq_no, DATE_FORMAT(date_of_request, '%m/%d/%Y'), supplier_name, company_name " +
                                                                  "FROM rfq_t, supplier_t, customer_t " +
                                                                  "WHERE rfq_t.customer_id = customer_t.customer_id " +
                                                                  "AND rfq_t.supplier_id = supplier_t.supplier_id " +
                                                                  "AND company_name LIKE '%{0}%' " +
                                                                  "ORDER BY rfq_no DESC;", textToSearch), connection);
                    break;
                case "RFQ No.":
                    command = new MySqlCommand(string.Format("SELECT rfq_no, DATE_FORMAT(date_of_request, '%m/%d/%Y'), supplier_name, company_name " +
                                                             "FROM rfq_t, supplier_t, customer_t " +
                                                             "WHERE rfq_no LIKE '%{0}%' " +
                                                             "AND rfq_t.customer_id = customer_t.customer_id " +
                                                             "AND rfq_t.supplier_id = supplier_t.supplier_id " +
                                                             "ORDER BY rfq_no DESC;", textToSearch), connection);
                    break;
                case "Request Date":
                    command = new MySqlCommand(string.Format("SELECT rfq_no, DATE_FORMAT(date_of_request, '%m/%d/%Y'), supplier_name, company_name " +
                                                             "FROM rfq_t, supplier_t, customer_t " +
                                                             "WHERE date_of_request LIKE '%{0}%' " +
                                                             "AND rfq_t.customer_id = customer_t.customer_id " +
                                                             "AND rfq_t.supplier_id = supplier_t.supplier_id " +
                                                             "ORDER BY rfq_no DESC;", textToSearch), connection);
                    break;
            }
            myReader = command.ExecuteReader();
            if (myReader.Read()) //Has laman, so for sure have to empty the dgvResults
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

        public void SearchPQ(string searchType, string textToSearch, DataGridView dgvResults)
        { //Main Screen: 
            ConnectToSQL();
            switch (searchType)
            {
                case "Customer Name":
                    command = new MySqlCommand(string.Format("SELECT DATE_FORMAT(pq_date, '%m/%d/%Y'), company_name, pq_no, CONCAT(DATE_FORMAT(from_date, '%m/%d/%Y'), ' - ', DATE_FORMAT(to_date, '%m/%d/%Y')) " +
                                                                  "FROM pq_t, customer_t " +
                                                                  "WHERE pq_t.customer_id = customer_t.customer_id " +
                                                                  "AND company_name LIKE '%{0}%' " +
                                                                  "ORDER BY pq_no DESC;", textToSearch), connection);
                    break;
                case "PQ No.":
                    command = new MySqlCommand(string.Format("SELECT DATE_FORMAT(pq_date, '%m/%d/%Y'), company_name, pq_no, CONCAT(DATE_FORMAT(from_date, '%m/%d/%Y'), ' - ', DATE_FORMAT(to_date, '%m/%d/%Y')) " +
                                                             "FROM pq_t, customer_t " +
                                                             "WHERE pq_no LIKE '%{0}%' " +
                                                             "AND pq_t.customer_id = customer_t.customer_id " +
                                                             "ORDER BY pq_no DESC;", textToSearch), connection);
                    break;
                case "Quotation Date":
                    command = new MySqlCommand(string.Format("SELECT DATE_FORMAT(pq_date, '%m/%d/%Y'), company_name, pq_no, CONCAT(DATE_FORMAT(from_date, '%m/%d/%Y'), ' - ', DATE_FORMAT(to_date, '%m/%d/%Y')) " +
                                                             "FROM pq_t, customer_t " +
                                                             "WHERE pq_date LIKE '%{0}%' " +
                                                             "AND pq_t.customer_id = customer_t.customer_id " +
                                                             "ORDER BY pq_no DESC;", textToSearch), connection);
                    break;
            }
            myReader = command.ExecuteReader();
            if (myReader.Read()) //Has laman, so for sure have to empty the dgvResults
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

        public void SearchPO(string searchType, string textToSearch, DataGridView dgvResults)
        { //Main Screen: 
            ConnectToSQL();
            switch (searchType)
            {
                case "Customer Name":
                    command = new MySqlCommand(string.Format("SELECT DATE_FORMAT(order_date, '%m/%d/%Y'), DATE_FORMAT(required_delivery_date, '%m/%d/%Y'), company_name, po_no, supplier_name " +
                                                                  "FROM po_t, customer_t, supplier_t " +
                                                                  "WHERE company_name LIKE '%{0}%' " +
                                                                  "AND po_t.customer_id = customer_t.customer_id " +
                                                                  "AND po_t.supplier_id = supplier_t.supplier_id " +
                                                                  "ORDER BY po_no DESC;", textToSearch), connection);
                    break;
                case "PO No.":
                    command = new MySqlCommand(string.Format("SELECT DATE_FORMAT(order_date, '%m/%d/%Y'), DATE_FORMAT(required_delivery_date, '%m/%d/%Y'), company_name, po_no, supplier_name " +
                                                             "FROM po_t, customer_t, supplier_t " +
                                                             "WHERE pq_no LIKE '%{0}%' " +
                                                             "AND po_t.customer_id = customer_t.customer_id " +
                                                             "AND po_t.supplier_id = supplier_t.supplier_id " +
                                                             "ORDER BY po_no DESC;", textToSearch), connection);
                    break;
                case "Order Date":
                    command = new MySqlCommand(string.Format("SELECT DATE_FORMAT(order_date, '%m/%d/%Y'), DATE_FORMAT(required_delivery_date, '%m/%d/%Y'), company_name, po_no, supplier_name " +
                                                             "FROM po_t, customer_t, supplier_t " +
                                                             "WHERE DATE_FORMAT(order_date, '%m/%d/%Y') LIKE '%{0}%' " +
                                                             "AND po_t.customer_id = customer_t.customer_id " +
                                                             "AND po_t.supplier_id = supplier_t.supplier_id " +
                                                             "ORDER BY po_no DESC;", textToSearch), connection);
                    break;
            }
            myReader = command.ExecuteReader();
            if (myReader.Read()) //Has laman, so for sure have to empty the dgvResults
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

        //-------------------------
        //  SPR SELECT STATEMENTS |
        //-------------------------
        public void SelectMonthlySales()
        {
            //To ponder on
        }

        public double SelectAnnualSales(string dateToQuery)
        { //Have to break it down into months, or I'll go crazy.
            ConnectToSQL();
            double salesResult = 0;
            command = new MySqlCommand(string.Format("SELECT SUM(invoice_total)FROM sidr_t WHERE so_date LIKE '{0}%';", dateToQuery), connection);
            object queryResult = command.ExecuteScalar();
            if (queryResult.ToString() != null)
            {
                salesResult = double.Parse(queryResult.ToString(), CultureInfo.InvariantCulture); //FormatException
            }
            DisconnectFromSQL();
            return salesResult;
        }

        public void SelectPendingRFQ(DataGridView dgvName)
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

        public void SelectCompletedRFQ(DataGridView dgvName)
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

        public void SelectAllRFQSPR(DataGridView dgvName)
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

        public void SelectPendingPQ(DataGridView dgvName)
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

        public void SelectCompletedPQ(DataGridView dgvName)
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

        public void SelectAllPQSPR(DataGridView dgvName)
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

        public void SelectPendingPO(DataGridView dgvName)
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

        public void SelectCompletedPO(DataGridView dgvName)
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

        public void SelectAllPOSPR(DataGridView dgvName)
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

        //---------------------
        //  INSERT STATEMENTS |
        //---------------------
        public void Insert(string insertStatement)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand(insertStatement, connection);
                command.ExecuteNonQuery();
                //MessageBox.Show("Save successful.");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            DisconnectFromSQL();
        }

        public void InsertItem(Item i)
        {
            //Dates must be inserted in SQL's format: YYYY-MM-DD
            string[] dateFromParts = i.FromDateNoTime.Split('/');
            string convertedFromDate = dateFromParts[2] + "-" + dateFromParts[0] + "-" + dateFromParts[1];
            string[] dateToParts = i.ToDateNoTime.Split('/');
            string convertedToDate = dateToParts[2] + "-" + dateToParts[0] + "-" + dateToParts[1];
            Insert(string.Format("INSERT INTO item_t " +
                "(part_number, item_name, item_description, supplier_unit_price, mark_up_percentage, reic_unit_price, minimum_order_quantity, unit_of_measurement, from_date, to_date, supplier_id) " +
                "VALUES ('{0}', '{1}', '{2}', {3}, {4}, {5}, {6}, '{7}', '{8}', '{9}', {10});", i.PartNumber,
                                                                                               i.ItemName,
                                                                                               i.ItemDescription,
                                                                                               i.SupplierUnitPrice,
                                                                                               i.Markup,
                                                                                               i.ReicUnitPrice,
                                                                                               i.Moq,
                                                                                               i.Uom,
                                                                                               convertedFromDate,
                                                                                               convertedToDate,
                                                                                              // i.FromDateNoTime,
                                                                                             //  i.ToDateNoTime,
                                                                                               i.SupplierID));
        }
    
        public void InsertSupplier(Supplier s)
        {
            Insert(string.Format("INSERT INTO supplier_t " +
                "(supplier_id, supplier_name, contact_person, contact_number, email_address, address) " + 
                "VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}');", s.SupplierID,
                                                                    s.SupplierName,
                                                                    s.SupplierPerson,
                                                                    s.SupplierNumber,
                                                                    s.SupplierEmail,
                                                                    s.SupplierAddress));
        }

        public void InsertCustomer(Customer c)
        {
            Insert(string.Format("INSERT INTO customer_t " +
                   "(customer_id, business_name_style, tin_number, company_name, contact_person, contact_number, account_number, email_address, address) " +
                   "VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');", c.CustomerID,
                                                                                            c.BusinessName,
                                                                                            c.TinNumber,
                                                                                            c.CustomerName,
                                                                                            c.CustomerPerson,
                                                                                            c.CustomerNumber,
                                                                                            c.AccountNumber,
                                                                                            c.CustomerEmail,
                                                                                            c.CustomerAddress));
        }

        public void InsertRFQ(RFQ r)
        {
            //Have to convert any date from REIC's format to SQL's format (or else, what'll be saved into database is '0000-00-00')
            string[] dateParts = r.RequestDate.Split('/'); //REIC's format: 05/06/2016 (MM/DD/YYYY)
            string convertedDate = dateParts[2] + "-" + dateParts[0] + "-" + dateParts[1]; //SQL's format: 2016-05-06 (YYYY-MM-DD)
            Insert(string.Format("INSERT INTO rfq_t " +
                "(rfq_no, date_of_request, payment_terms, delivery_terms, customer_id, supplier_id, pq_no) " + 
                "VALUES ('{0}', '{1}', '{2}', '{3}', {4}, {5}, null);", r.RFQNo,
                                                                       convertedDate,
                                                                       r.PaymentTerms,
                                                                       r.DeliveryTerms,
                                                                       r.CustomerID,
                                                                       r.SupplierID)); //PQ_No foreign key will be set when its PQ has been created
        }

        public void InsertRFQOrderLine(RFQ_OrderLine rol)
        {
            //MessageBox.Show("Insert Order Line");
            Insert(string.Format("INSERT INTO rfq_order_line_t " +
                "(rfq_no, part_number, quantity) " +
                "VALUES ('{0}', '{1}', {2});", rol.RFQNo, rol.PartNumber, rol.Quantity));
        }

        public void InsertPQ(PQ p)    
        {
            string[] datePQParts = p.PQDate.Split('/');
            string convertedPQDate = datePQParts[2] + "-" + datePQParts[0] + "-" + datePQParts[1];
            string[] dateFromParts = p.PQFromDate.Split('/'); 
            string convertedFromDate = dateFromParts[2] + "-" + dateFromParts[0] + "-" + dateFromParts[1];
            string[] dateToParts = p.PQToDate.Split('/');
            string convertedToDate = dateToParts[2] + "-" + dateToParts[0] + "-" + dateToParts[1];
            Insert(string.Format("INSERT INTO pq_t " +
       "(pq_no, pq_date, from_date, to_date, payment_terms, delivery_terms, bill_to, ship_to, in_favor_of, total_amount, customer_id) " +
       "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', {9}, '{10}');", p.PQNo,
                                                         convertedPQDate,
                                                         convertedFromDate,
                                                         convertedToDate,
                                                         p.PaymentTerms,
                                                         p.DeliveryTerms,
                                                         p.BillTo,
                                                         p.ShipTo,
                                                         p.InFavorOf,
                                                         p.TotalAmount,
                                                         p.CustomerID));
        }

        
        public void InsertPQOrderLine(PQ_OrderLine pol)
        {
            Insert(string.Format("INSERT INTO pq_order_line_t " +
                "(pq_no, part_number, reic_unit_price, quantity, item_total) " +
                "VALUES ('{0}', '{1}', {2}, {3}, {4});", pol.PQNo, pol.PartNumber, pol.ReicUnitPrice, pol.Quantity, pol.ItemTotal));
        }
        
        public void InsertPO(PO p)
        {
            string[] datePQParts = p.OrderDate.Split('/');
            string convertedPQDate = datePQParts[2] + "-" + datePQParts[0] + "-" + datePQParts[1];
            string[] dateFromParts = p.DeliveryDate.Split('/'); 
            string convertedFromDate = dateFromParts[2] + "-" + dateFromParts[0] + "-" + dateFromParts[1];
          
            Insert(string.Format("INSERT INTO po_t " +
       "(po_no, order_date, required_delivery_date, order_description, pq_no, payment_terms, delivery_terms, net_item_subtotal, delivery_cost, order_total, supplier_id, customer_id, so_no) " +
       "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7}, {8}, {9}, '{10}', '{11}', '{12}');", p.PONo,
                                                         convertedPQDate,
                                                         convertedFromDate,
                                                         p.OrderDescription,
                                                         p.PQNo,
                                                         p.PaymentTerms,
                                                         p.DeliveryTerms,
                                                         p.NetSubtotal,
                                                         p.DeliveryCost,
                                                         p.OrderTotal,
                                                         p.SupplierID,
                                                         p.CustomerID,
                                                         null));
        }
        
        public void InsertPOOrderLine(PO_OrderLine pol)
        {
            Insert(string.Format("INSERT INTO po_order_line_t " +
               "(po_no, part_number, supplier_unit_price, quantity, item_total) " +
               "VALUES ('{0}', '{1}', {2}, {3}, {4});", pol.PONo, pol.PartNumber, pol.SupplierUnitPrice, pol.Quantity, pol.ItemTotal));
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
        public void Update(string updateStatement)
        {
            try
            {
                ConnectToSQL();
                command = new MySqlCommand(updateStatement, connection);
                command.ExecuteNonQuery();
                //MessageBox.Show("Update successful.");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            DisconnectFromSQL();
        }
      
        public void UpdateItem(Item i)
        {
            string[] dateFromParts = i.FromDateNoTime.Split('/');
            string convertedFromDate = dateFromParts[2] + "-" + dateFromParts[0] + "-" + dateFromParts[1];
            string[] dateToParts = i.ToDateNoTime.Split('/');
            string convertedToDate = dateToParts[2] + "-" + dateToParts[0] + "-" + dateToParts[1];

            /* Update(string.Format("UPDATE item_t " +
             "SET part_number='{0}', item_name='{1}', item_description='{2}', supplier_unit_price={3}, mark_up_percentage={4}, reic_unit_price={5}, minimum_order_quantity={6}, unit_of_measurement='{7}', from_date='{8}', to_date='{9}', supplier_id={10} " +
             "WHERE part_number= '{0}';", i.PartNumber,
                                       i.ItemName,
                                       i.ItemDescription,
                                       i.SupplierUnitPrice,
                                       i.Markup,
                                       i.ReicUnitPrice,
                                       i.Moq,
                                       i.Uom,
                                       convertedFromDate,
                                       convertedToDate,
                                       i.SupplierID)); */

            Update(string.Format("UPDATE item_t " +
           "SET item_name='{0}', item_description='{1}', supplier_unit_price={2}, mark_up_percentage={3}, reic_unit_price={4}, minimum_order_quantity={5}, unit_of_measurement='{6}', from_date='{7}', to_date='{8}', supplier_id={9} " +
           "WHERE part_number= '{10}';",
                                     i.ItemName,
                                     i.ItemDescription,
                                     i.SupplierUnitPrice,
                                     i.Markup,
                                     i.ReicUnitPrice,
                                     i.Moq,
                                     i.Uom,
                                     convertedFromDate,
                                     convertedToDate,
                                     i.SupplierID,
                                     i.PartNumber));
        }

        public void UpdateCustomer(Customer c)
        {
            Update(string.Format("UPDATE customer_t " +
               "SET business_name_style='{0}', tin_number='{1}', company_name='{2}', contact_person='{3}', contact_number='{4}', account_number='{5}', email_address='{6}', address='{7}' " +
               "WHERE customer_id={8};", c.BusinessName,
                                         c.TinNumber,
                                         c.CustomerName,
                                         c.CustomerPerson,
                                         c.CustomerNumber,
                                         c.AccountNumber,
                                         c.CustomerEmail,
                                         c.CustomerAddress,
                                         c.CustomerID));
        }

        public void UpdateSupplier(Supplier s)
        {
            Update(string.Format("UPDATE supplier_t " +
               "SET supplier_name='{0}', contact_person='{1}', contact_number='{2}', email_address='{3}', address='{4}' " +
               "WHERE supplier_id={5};", s.SupplierName,
                                         s.SupplierPerson,
                                         s.SupplierNumber,
                                         s.SupplierEmail,
                                         s.SupplierAddress,
                                         s.SupplierID));
        }
    }
}
