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
    public partial class SPR_RFQPending_PrintScreen : Form
    { //This results from Create RFQ's [Save & Generate PDF] button or View RFQ [PDF] icon

        //ATTRIBUTES
        private MySqlConnection connection;
        private reicpomsDataSet reicpomsds;
        private MySqlDataAdapter adapter;

        private MySQLDatabaseDriver sql;

        //CONSTRUCTOR
        public SPR_RFQPending_PrintScreen()
        {
            InitializeComponent();
            CrystalReportViewer.ReportSource = null;
        }

        private void SPR_RFQPending_PrintScreen_Load(object sender, EventArgs e)
        {
            //---MYSQL CONNECTION
            connection = new MySqlConnection(ConnectionStringManager.reicpomsConnection.ConnectionString);
            connection.Open();

            //---SELECT Statements
            reicpomsds = new reicpomsDataSet();

            //Data from RFQ Suppliers
            //Old, slower: string selectAllSuppliers = "SELECT * FROM supplier_t;"; --> Data from ALL supplier_t (Needed to avoid a ContstraintException in selectPendingRFQ)
            string selectAllSuppliers = string.Format("SELECT DISTINCT supplier_t.* " +
                                                      "FROM supplier_t, rfq_t " +
                                                      "WHERE pq_no IS NULL " +
                                                      "AND rfq_t.supplier_id = supplier_t.supplier_id " +
                                                      "ORDER BY rfq_no DESC;");
            adapter = new MySqlDataAdapter(selectAllSuppliers, connection);
            adapter.Fill(reicpomsds, "supplier_t");

            //Data from RFQ Customers
            //Old, slower: string selectAllCustomers = "SELECT * FROM customer_t;"; --> Data from ALL customer_t (Needed to avoid a ContstraintException in selectRFQCustomer)
            string selectAllCustomers = string.Format("SELECT DISTINCT customer_t.* " +
                                                      "FROM customer_t, rfq_t " +
                                                      "WHERE pq_no IS NULL " +
                                                      "AND rfq_t.customer_id = customer_t.customer_id " +
                                                      "ORDER BY rfq_no DESC;");
            adapter = new MySqlDataAdapter(selectAllCustomers, connection);
            adapter.Fill(reicpomsds, "customer_t");

            //Data from rfq_t
            string selectPendingRFQ = "SELECT * FROM rfq_t WHERE pq_no IS NULL ORDER BY rfq_no DESC;";
            adapter = new MySqlDataAdapter(selectPendingRFQ, connection);
            adapter.Fill(reicpomsds, "rfq_t");

            connection.Close();

            //---INSTANTIATE CRYSTAL REPORT
            SPR_RFQPending rfqpending = new SPR_RFQPending();
            rfqpending.Load();
            rfqpending.SetDataSource(reicpomsds); //Added a code snippet in app.config file. If else, will result to a System.IOFileNotFoundException error.
            string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd hhmmtt");
            string fileName = "C:\\REIC Files\\Sales Performance Report & Summary\\Requests for Price Quotation - Pending\\Pending RFQ (" + currentDateTime + ").pdf";
            rfqpending.ExportToDisk(ExportFormatType.PortableDocFormat, fileName);
            MessageBox.Show("A PDF file of this report on pending requests for price quotation can be found in C:\\REIC Files\\Sales Performance Report & Summary\\\nRequests for Price Quotation - Pending.");
            CrystalReportViewer.ReportSource = rfqpending; //Display SPR_RFQPending.rpt in the print preview
        }
    }
}
