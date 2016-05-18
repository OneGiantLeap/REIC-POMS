using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Added
using CrystalDecisions.CrystalReports.Engine; //Added
using CrystalDecisions.Shared; //Added to enable export to file

namespace REIC_POMS
{
    public partial class RFQ_PrintScreen : Form
    { //This results from Create RFQ's [Save & Generate PDF] button or View RFQ [PDF] icon

        //----------------------------
        //  CODING NOTES/EXPLANATION |
        //----------------------------
        /*
            Set-up
            1. Install Crystal Reports into your PC.
            2. Create your Crystal Report forms (.rpt).
            3. Create a Windows Form showing your print preview of the Crystal Report (See RFQ_PrintScreen Designer)
            
            Main Code
            0. In the RFQ Main Screen form and in the RFQ View Form, set the value of rfqNo.
                - Since saving happens in the Main Screen, I placed the Crystal Report-related code in the Main Screen.
                - View Form is where the PDF button can be found.
            1. Use rfqNo to call on select statements to populate the tables involved in the RFQ (supplier_t, item_t, rfq_t, and rfq_order_line_t)
            2. Populate the dataset with the results of the select statements
            3. Instantiate the Crystal Report and use the dataset as its datasource
            4. Success!
        */

        //ATTRIBUTES
        private MySqlConnection connection;
        private reicpomsDataSet reicpomsds;
        private MySqlDataAdapter adapter;
        private string rfqNo; //Used to retrieve a specific RFQ
        private bool firstTime; //If it's the first time the report's made, it's saved into the computer

        //CONSTRUCTOR
        public RFQ_PrintScreen()
        {
            InitializeComponent();
            CrystalReportViewer.ReportSource = null;
        }

        //-------------------
        //  GETTERS-SETTERS |
        //-------------------
        public string RFQNo //To use in SQL statement
        {
            set { rfqNo = value; } //Value set as this form is instantiated
            get { return rfqNo; }
        }
        
        public bool FirstTime
        {
            set { firstTime = value; }
            get { return firstTime; }
        }

        private void RFQ_PrintScreen_Load(object sender, EventArgs e)
        { //When screen loads, details of the RFQ Printout should already be displayed.
            //---MYSQL CONNECTION
            connection = new MySqlConnection("server=localhost; database=reicpoms; user=root; password=; convert zero datetime=true; allow zero datetime=true;");
            connection.Open();

                //DEBUG MESSAGES
                if (connection.State == System.Data.ConnectionState.Open)
                { MessageBox.Show("Crystal Report: Connection to SQL successful!"); }
                else
                { MessageBox.Show("Crystal Report: Connection to SQL failed!"); }

            //---SELECT Statements
            //Why I didn't use MySQLDatabaseDriver: MySqlDataAdapter needs the select statement strings as one of its parameters (MySqlDataAdapter needed to fill the datasets)

            reicpomsds = new reicpomsDataSet();

            //Data from supplier_t (RFQ's Supplier)
            string selectRFQSupplier = string.Format("SELECT supplier_t.* " +
                                                  "FROM rfq_t, supplier_t " +
                                                  "WHERE rfq_no = '{0}' " +
                                                  "AND rfq_t.supplier_id = supplier_t.supplier_id;", rfqNo);
            adapter = new MySqlDataAdapter(selectRFQSupplier, connection);
            adapter.Fill(reicpomsds, "supplier_t_rfq");

            //Further data from supplier_t (Supplier of all the items in the RFQ OrderLine | For some reason, if an item's supplier changes, the item won't appear in the RFQ anymore)
            string selectAllItemSupplier = string.Format("SELECT DISTINCT supplier_t.* " +
                                                         "FROM rfq_order_line_t, item_t, supplier_t " +
                                                         "WHERE rfq_no = '{0}' " +
                                                         "AND rfq_order_line_t.part_number = item_t.part_number " +
                                                         "AND item_t.supplier_id = supplier_t.supplier_id;", rfqNo);
            adapter = new MySqlDataAdapter(selectAllItemSupplier, connection);
            adapter.Fill(reicpomsds, "supplier_t");

            //Data from rfq_order_line_t, inserted into item_t
            string selectRFQOrderLineItems = string.Format(//"SELECT item_t.part_number, item_name, item_description, supplier_unit_price, mark_up_percentage, reic_unit_price, minimum_order_quantity, unit_of_measurement, from_date, to_date, supplier_id " +
                                                        "SELECT item_t.*" +
                                                        "FROM rfq_order_line_t, item_t " +
                                                        "WHERE rfq_no = '{0}' " +
                                                        "AND rfq_order_line_t.part_number = item_t.part_number;", rfqNo);
                                                        //Will use only item_name, item_description, unit_of_measurement
            adapter = new MySqlDataAdapter(selectRFQOrderLineItems, connection);
            adapter.Fill(reicpomsds, "item_t"); //Inserted into item_t, since it's where item_name, item_description, and unit_of_measurement can be found

            //Data from rfq_t
            string selectRFQ = string.Format("SELECT * FROM rfq_t WHERE rfq_no='{0}';", rfqNo);
            adapter = new MySqlDataAdapter(selectRFQ, connection);
            adapter.Fill(reicpomsds, "rfq_t");

            //Data from rfq_order_line_t
            string selectRFQOrderLine = string.Format("SELECT * FROM rfq_order_line_t WHERE rfq_no='{0}';", rfqNo);
            adapter = new MySqlDataAdapter(selectRFQOrderLine, connection);
            adapter.Fill(reicpomsds, "rfq_order_line_t");

            connection.Close();

            //---INSTANTIATE CRYSTAL REPORT
            RFQPrintout rfq = new RFQPrintout();
            rfq.Load();
            rfq.SetDataSource(reicpomsds); //Added a code snippet in app.config file. If else, will result to a System.IOFileNotFoundException error.
            string fileName = "C:\\REIC Files\\Requests for Price Quotation\\RFQ " + RFQNo + ".pdf";
            if (FirstTime == true)
            {
                rfq.ExportToDisk(ExportFormatType.PortableDocFormat, fileName);
                MessageBox.Show("A PDF file of this Request for Price Quotation can be found in \nC:\\REIC Files\\Requests for Price Quotation.");
            }
            CrystalReportViewer.ReportSource = rfq; //Display RFQPrintout.rpt in the print preview
        }
    }
}
