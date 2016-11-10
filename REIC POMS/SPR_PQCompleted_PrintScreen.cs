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
    public partial class SPR_PQCompleted_PrintScreen : Form
    {
        //ATTRIBUTES
        private MySqlConnection connection;
        private reicpomsDataSet reicpomsds;
        private MySqlDataAdapter adapter;

        //CONSTRUCTOR
        public SPR_PQCompleted_PrintScreen()
        {
            InitializeComponent();
            CrystalReportViewer.ReportSource = null;
        }

        private void SPR_PQCompleted_PrintScreen_Load(object sender, EventArgs e)
        {
            //---MYSQL CONNECTION
            connection = new MySqlConnection(ConnectionStringManager.reicpomsConnection.ConnectionString);
            connection.Open();

            //---SELECT Statements
            reicpomsds = new reicpomsDataSet();

            //Data from PQ Customers (Need DISTINCT, else ConstraintException; for some reason, without DISTINCT, some PQ rows have multiple copies)
            string selectPQCustomers = string.Format("SELECT DISTINCT customer_t.* " +
                                                      "FROM customer_t, pq_t, po_t " +
                                                      "WHERE pq_t.pq_no = po_t.pq_no " +
                                                      "AND pq_t.customer_id = customer_t.customer_id " +
                                                      "ORDER BY pq_t.pq_no DESC;");
            adapter = new MySqlDataAdapter(selectPQCustomers, connection);
            adapter.Fill(reicpomsds, "customer_t");

            //Data from pq_t
            string selectCompletedPQ = string.Format("SELECT DISTINCT pq_t.* " +
                                                     "FROM pq_t, po_t " +
                                                     "WHERE po_t.pq_no = pq_t.pq_no " +
                                                     "ORDER BY pq_t.pq_no DESC;");
            adapter = new MySqlDataAdapter(selectCompletedPQ, connection);
            adapter.Fill(reicpomsds, "pq_t");

            connection.Close();

            //---INSTANTIATE CRYSTAL REPORT
            SPR_PQCompleted pqc = new SPR_PQCompleted();
            pqc.Load();
            pqc.SetDataSource(reicpomsds); //Added a code snippet in app.config file. If else, will result to a System.IOFileNotFoundException error.

            //---EXPORT TO PDF
            string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd hhmmtt");
            string filePath = "C:\\REIC Files\\Sales Performance Report & Summary\\Price Quotations - Completed\\Completed PQ (" + currentDateTime + ").pdf";
            pqc.ExportToDisk(ExportFormatType.PortableDocFormat, filePath);

            MessageBox.Show("A PDF file of this report on completed price quotations can be found in \nC:\\REIC Files\\Sales Performance Report & Summary\\Price Quotations - Completed.");
            CrystalReportViewer.ReportSource = pqc;
        }
    }
}
