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
    public partial class SPR_RFQAll_PrintScreen : Form
    {
        //ATTRIBUTES
        private MySqlConnection connection;
        private reicpomsDataSet reicpomsds;
        private MySqlDataAdapter adapter;

        //CONSTRUCTOR
        public SPR_RFQAll_PrintScreen()
        {
            InitializeComponent();
            CrystalReportViewer.ReportSource = null;
        }

        private void SPR_RFQAll_PrintScreen_Load(object sender, EventArgs e)
        {
            //---MYSQL CONNECTION
            connection = new MySqlConnection(ConnectionStringManager.reicpomsConnection.ConnectionString);
            connection.Open();

            //---SELECT Statements
            reicpomsds = new reicpomsDataSet();

            //IMPORTANT: Placed "DISTINCT" because if not, will result to a ConstraintException
            //Data from RFQ Suppliers
            string selectRFQSuppliers = string.Format("SELECT DISTINCT supplier_t.* " +
                                                      "FROM supplier_t, rfq_t " +
                                                      "WHERE rfq_t.supplier_id = supplier_t.supplier_id " +
                                                      "ORDER BY rfq_no DESC;");
            adapter = new MySqlDataAdapter(selectRFQSuppliers, connection);
            adapter.Fill(reicpomsds, "supplier_t");

            //Data from RFQ Customers
            string selectRFQCustomers = string.Format("SELECT DISTINCT customer_t.* " +
                                                      "FROM customer_t, rfq_t " +
                                                      "WHERE rfq_t.customer_id = customer_t.customer_id " +
                                                      "ORDER BY rfq_no DESC;");
            adapter = new MySqlDataAdapter(selectRFQCustomers, connection);
            adapter.Fill(reicpomsds, "customer_t");

            //Data from rfq_t
            string selectPendingRFQ = "SELECT * FROM rfq_t ORDER BY rfq_no DESC;";
            adapter = new MySqlDataAdapter(selectPendingRFQ, connection);
            adapter.Fill(reicpomsds, "rfq_t");

            connection.Close();

            //---INSTANTIATE CRYSTAL REPORT
            SPR_RFQAll rfq = new SPR_RFQAll();
            rfq.Load();
            rfq.SetDataSource(reicpomsds); //Added a code snippet in app.config file. If else, will result to a System.IOFileNotFoundException error.

            //---EXPORT TO PDF
            string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd hhmmtt");
            string filePath = "C:\\REIC Files\\Sales Performance Report & Summary\\Requests for Price Quotation - All\\All RFQ (" + currentDateTime + ").pdf";
            rfq.ExportToDisk(ExportFormatType.PortableDocFormat, filePath);

            MessageBox.Show("A PDF file of this report on completed requests for price quotation can be found \nin C:\\REIC Files\\Sales Performance Report & Summary\\\nRequests for Price Quotation - All.");
            CrystalReportViewer.ReportSource = rfq;
        }
    }
}
