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
    public partial class SPR_POPending_PrintScreen : Form
    {
        //ATTRIBUTES
        private MySqlConnection connection;
        private reicpomsDataSet reicpomsds;
        private MySqlDataAdapter adapter;

        //CONSTRUCTOR
        public SPR_POPending_PrintScreen()
        {
            InitializeComponent();
            CrystalReportViewer.ReportSource = null;
        }

        private void SPR_POPending_PrintScreen_Load(object sender, EventArgs e)
        {
            //---MYSQL CONNECTION
            connection = new MySqlConnection(ConnectionStringManager.reicpomsConnection.ConnectionString);
            connection.Open();

            //---SELECT Statements
            reicpomsds = new reicpomsDataSet();

            //Data from PO Suppliers
            string selectPOSuppliers = string.Format("SELECT DISTINCT supplier_t.* " +
                                                      "FROM supplier_t, po_t " +
                                                      "WHERE so_no IS NULL " +
                                                      "AND po_t.supplier_id = supplier_t.supplier_id " +
                                                      "ORDER BY po_no DESC;");
            adapter = new MySqlDataAdapter(selectPOSuppliers, connection);
            adapter.Fill(reicpomsds, "supplier_t");

            //Data from PO Customers
            string selectPOCustomers = string.Format("SELECT DISTINCT customer_t.* " +
                                                      "FROM customer_t, po_t " +
                                                      "WHERE so_no IS NULL " +
                                                      "AND po_t.customer_id = customer_t.customer_id " +
                                                      "ORDER BY po_no DESC;");
            adapter = new MySqlDataAdapter(selectPOCustomers, connection);
            adapter.Fill(reicpomsds, "customer_t");

            //Data from po_t
            string selectPendingPO = "SELECT * FROM po_t WHERE so_no IS NULL ORDER BY po_no DESC;";
            adapter = new MySqlDataAdapter(selectPendingPO, connection);
            adapter.Fill(reicpomsds, "po_t");

            connection.Close();

            //---INSTANTIATE CRYSTAL REPORT
            SPR_POPending pop = new SPR_POPending();
            pop.Load();
            pop.SetDataSource(reicpomsds); //Added a code snippet in app.config file. If else, will result to a System.IOFileNotFoundException error.

            //---EXPORT TO PDF
            string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd hhmmtt");
            string filePath = "C:\\REIC Files\\Sales Performance Report & Summary\\Purchase Orders - Pending\\Pending PO (" + currentDateTime + ").pdf";
            pop.ExportToDisk(ExportFormatType.PortableDocFormat, filePath);

            MessageBox.Show("A PDF file of this report on pending purchase orders can be found in \nC:\\REIC Files\\Sales Performance Report & Summary\\Purchase Orders - Pending.");
            CrystalReportViewer.ReportSource = pop;
        }
    }
}
