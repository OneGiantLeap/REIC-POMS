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
    public partial class SPR_POAll_PrintScreen : Form
    {
        //ATTRIBUTES
        private MySqlConnection connection;
        private reicpomsDataSet reicpomsds;
        private MySqlDataAdapter adapter;

        //CONSTRUCTOR
        public SPR_POAll_PrintScreen()
        {
            InitializeComponent();
            CrystalReportViewer.ReportSource = null;
        }

        private void SPR_POCompleted_PrintScreen_Load(object sender, EventArgs e)
        {
            //---MYSQL CONNECTION
            connection = new MySqlConnection(ConnectionStringManager.reicpomsConnection.ConnectionString);
            connection.Open();

            //---SELECT Statements
            reicpomsds = new reicpomsDataSet();

            //Data from PO Suppliers
            string selectPOSuppliers = string.Format("SELECT DISTINCT supplier_t.* " +
                                                      "FROM supplier_t, po_t " +
                                                      "WHERE so_no IS NOT NULL " +
                                                      "AND po_t.supplier_id = supplier_t.supplier_id " +
                                                      "ORDER BY po_no;");
            adapter = new MySqlDataAdapter(selectPOSuppliers, connection);
            adapter.Fill(reicpomsds, "supplier_t");

            //Data from PO Customers
            string selectPOCustomers = string.Format("SELECT DISTINCT customer_t.* " +
                                                      "FROM customer_t, po_t " +
                                                      "WHERE so_no IS NOT NULL " +
                                                      "AND po_t.customer_id = customer_t.customer_id " +
                                                      "ORDER BY po_no;");
            adapter = new MySqlDataAdapter(selectPOCustomers, connection);
            adapter.Fill(reicpomsds, "customer_t");

            //Data from po_t
            string selectCompletedPO = "SELECT * FROM po_t WHERE so_no IS NOT NULL ORDER BY po_no;";
            adapter = new MySqlDataAdapter(selectCompletedPO, connection);
            adapter.Fill(reicpomsds, "po_t");

            connection.Close();

            //---INSTANTIATE CRYSTAL REPORT
            SPR_POCompleted poc = new SPR_POCompleted();
            poc.Load();
            poc.SetDataSource(reicpomsds); //Added a code snippet in app.config file. If else, will result to a System.IOFileNotFoundException error.

            //---EXPORT TO PDF
            string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd hhmmtt");
            string filePath = "C:\\REIC Files\\Sales Performance Report & Summary\\Purchase Orders - All\\All PO (" + currentDateTime + ").pdf";
            poc.ExportToDisk(ExportFormatType.PortableDocFormat, filePath);

            MessageBox.Show("A PDF file of this report on completed purchase orders can be found in \nC:\\REIC Files\\Sales Performance Report & Summary\\\nPurchase Orders - All.");
            CrystalReportViewer.ReportSource = poc;
        }
    }
}
