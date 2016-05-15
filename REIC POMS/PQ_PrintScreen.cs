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
    public partial class PQ_PrintScreen : Form
    { //This results from Create PQ's [Save & Generate PDF] button or View PQ [PDF] icon

        //ATTRIBUTES
        private MySqlConnection connection;
        private reicpomsDataSet reicpomsds;
        private MySqlDataAdapter adapter;
        private string pqNo; //Used to retrieve a specific PQ
        private bool firstTime; //If it's the first time the report's made, it's saved into the computer

        //CONSTRUCTOR
        public PQ_PrintScreen()
        {
            InitializeComponent();
            CrystalReportViewer.ReportSource = null;
        }

        //-------------------
        //  GETTERS-SETTERS |
        //-------------------
        public string PQNo //To use in SQL statement
        {
            set { pqNo = value; } //Value set as this form is instantiated
            get { return pqNo; }
        }

        public bool FirstTime
        {
            set { firstTime = value; }
            get { return firstTime; }
        }

        private void PQ_PrintScreen_Load(object sender, EventArgs e)
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
            reicpomsds = new reicpomsDataSet();

            //Data from supplier_t (Made, since there's supplier_id)
            string selectRFQSupplier = string.Format("SELECT supplier_t.supplier_id, supplier_name, contact_person, contact_number, email_address, address " +
                                                  "FROM pq_t, supplier_t " +
                                                  "WHERE pq_no = '{0}' " +
                                                  "AND pq_t.supplier_id = supplier_t.supplier_id;", pqNo);
            adapter = new MySqlDataAdapter(selectRFQSupplier, connection);
            adapter.Fill(reicpomsds, "supplier_t");

            //Data from pq_order_line_t, inserted into item_t
            string selectPQOrderLineItems = string.Format("SELECT item_t.part_number, item_name, item_description, supplier_unit_price, mark_up_percentage, reic_unit_price, minimum_order_quantity, unit_of_measurement, from_date, to_date, supplier_id " +
                                                        "FROM pq_order_line_t, item_t " +
                                                        "WHERE pq_no = '{0}' " +
                                                        "AND pq_order_line_t.part_number = item_t.part_number;", pqNo);
            //Will use only item_name, item_description, unit_of_measurement
            adapter = new MySqlDataAdapter(selectPQOrderLineItems, connection);
            adapter.Fill(reicpomsds, "item_t"); //Inserted into item_t, since it's where item_name, item_description, and unit_of_measurement can be found

            //Data from pq_t
            string selectPQ = string.Format("SELECT * FROM pq_t WHERE pq_no='{0}';", pqNo);
            adapter = new MySqlDataAdapter(selectPQ, connection);
            adapter.Fill(reicpomsds, "pq_t");

            //Data from rfq_order_line_t
            string selectPQOrderLine = string.Format("SELECT * FROM pq_order_line_t WHERE pq_no='{0}';", pqNo);
            adapter = new MySqlDataAdapter(selectPQOrderLine, connection);
            adapter.Fill(reicpomsds, "pq_order_line_t");

            connection.Close();

            //---INSTANTIATE CRYSTAL REPORT
            PQPrintout pq = new PQPrintout();
            pq.Load();
            pq.SetDataSource(reicpomsds); //Added a code snippet in app.config file. If else, will result to a System.IOFileNotFoundException error.
            string fileName = "C:\\REIC Files\\Price Quotations\\PQ " + PQNo + ".pdf";
            if (FirstTime == true)
            {
                pq.ExportToDisk(ExportFormatType.PortableDocFormat, fileName);
                MessageBox.Show("A PDF file of this Price Quotation can be found in \nC:\\REIC Files\\Price Quotations.");
            }
            CrystalReportViewer.ReportSource = pq; //Display PQPrintout.rpt in the print preview
        }
    }
}
