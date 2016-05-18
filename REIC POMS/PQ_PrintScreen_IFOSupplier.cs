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
    public partial class PQ_PrintScreen_IFOSupplier : Form
    { //This results from Create PQ's [Save & Generate PDF] button or View PQ [PDF] icon

        //ATTRIBUTES
        private MySqlConnection connection;
        private reicpomsDataSet reicpomsds;
        private MySqlDataAdapter adapter;
        private string pqNo; //Used to retrieve a specific PQ
        private bool firstTime; //If it's the first time the report's made, it's saved into the computer
        //private string inFavorOf;

        //CONSTRUCTOR
        public PQ_PrintScreen_IFOSupplier()
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

        /*public string InFavorOf //Different IFO values have slightly different PQs
        {
            set { inFavorOf = value; }
            get { return inFavorOf; }
        }*/

        private void PQ_PrintScreen_IFOSupplier_Load(object sender, EventArgs e)
        { //When screen loads, details of the RFQ Printout should already be displayed.
            //---MYSQL CONNECTION
            connection = new MySqlConnection("server=localhost; database=reicpoms; user=root; password=; convert zero datetime=true; allow zero datetime=true;");
            connection.Open();

            //---SELECT Statements
            reicpomsds = new reicpomsDataSet();

            //Data from supplier_t
            string selectPQSupplier = string.Format("SELECT DISTINCT supplier_t.* " +
                                                  "FROM rfq_order_line_t, item_t, supplier_t " +
                                                  "WHERE rfq_no = '{0}' " +
                                                  "AND rfq_order_line_t.part_number = item_t.part_number " +
                                                  "AND item_t.supplier_id = supplier_t.supplier_id;", PQNo);
            adapter = new MySqlDataAdapter(selectPQSupplier, connection);
            adapter.Fill(reicpomsds, "supplier_t");

            //Data from pq_order_line_t, inserted into item_t
            string selectPQOrderLineItems = string.Format("SELECT item_t.* " +
                                                          "FROM pq_order_line_t, item_t " +
                                                          "WHERE pq_no = '{0}' " +
                                                          "AND pq_order_line_t.part_number = item_t.part_number;", PQNo);
            adapter = new MySqlDataAdapter(selectPQOrderLineItems, connection);
            adapter.Fill(reicpomsds, "item_t"); //Inserted into item_t, since it's where item_name, item_description, and unit_of_measurement can be found

            //Data from pq_t
            string selectPQ = string.Format("SELECT * FROM pq_t WHERE pq_no='{0}';", PQNo);
            adapter = new MySqlDataAdapter(selectPQ, connection);
            adapter.Fill(reicpomsds, "pq_t");

            //Data from pq_order_line_t
            string selectPQOrderLine = string.Format("SELECT * FROM pq_order_line_t WHERE pq_no='{0}';", PQNo);
            adapter = new MySqlDataAdapter(selectPQOrderLine, connection);
            adapter.Fill(reicpomsds, "pq_order_line_t");

            connection.Close();

            //---INSTANTIATE CRYSTAL REPORT
            PQ_Printout_IFOSupplier pq = new PQ_Printout_IFOSupplier();
            pq.Load();
            pq.SetDataSource(reicpomsds);
            string fileName = "C:\\REIC Files\\Price Quotations\\PQ " + PQNo + ".pdf";
            if (FirstTime == true)
            {
                pq.ExportToDisk(ExportFormatType.PortableDocFormat, fileName);
                MessageBox.Show("A PDF file of this Price Quotation can be found in \nC:\\REIC Files\\Price Quotations.");
            }
            CrystalReportViewer.ReportSource = pq;
        }
    }
}
