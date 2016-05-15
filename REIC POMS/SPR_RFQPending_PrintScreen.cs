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

        //CONSTRUCTOR
        public SPR_RFQPending_PrintScreen()
        {
            InitializeComponent();
            CrystalReportViewer.ReportSource = null;
        }

        private void SPR_RFQPending_PrintScreen_Load(object sender, EventArgs e)
        {
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

            //Data from ALL supplier_t (Needed to avoid a ContstraintException in selectPendingRFQ)
            string selectAllSuppliers = "SELECT * FROM supplier_t;";
            adapter = new MySqlDataAdapter(selectAllSuppliers, connection);
            adapter.Fill(reicpomsds, "supplier_t");

            //Data from ALL customer_t (Needed to avoid a ContstraintException in selectRFQCustomer)
            string selectAllCustomers = "SELECT * FROM customer_t;";
            adapter = new MySqlDataAdapter(selectAllCustomers, connection);
            adapter.Fill(reicpomsds, "customer_t");

            //Data from customer
            string selectRFQCustomer = string.Format("SELECT customer_t.customer_id, business_name_style, tin_number, company_name, contact_person, contact_number, account_number, email_address, address " +
                                                     "FROM rfq_t, customer_t " +
                                                     "WHERE pq_no IS NULL " +
                                                     "AND rfq_t.customer_id = customer_t.customer_id;");
            adapter = new MySqlDataAdapter(selectRFQCustomer, connection);
            adapter.Fill(reicpomsds, "customer_t"); //Overwrites the customer_t

            //Data from rfq_t
            string selectPendingRFQ = "SELECT * FROM rfq_t WHERE pq_no IS NULL;";
            adapter = new MySqlDataAdapter(selectPendingRFQ, connection);
            adapter.Fill(reicpomsds, "rfq_t");

            //Data from supplier_t
            string selectRFQSupplier = string.Format("SELECT supplier_t.supplier_id, supplier_name, contact_person, contact_number, email_address, address " +
                                                     "FROM rfq_t, supplier_t " +
                                                     "WHERE pq_no IS NULL " +
                                                     "AND rfq_t.supplier_id = supplier_t.supplier_id;");
            adapter = new MySqlDataAdapter(selectRFQSupplier, connection);
            adapter.Fill(reicpomsds, "supplier_t"); //Overwrites the supplier_t

            connection.Close();

            //---INSTANTIATE CRYSTAL REPORT
            SPR_RFQPending rfqpending = new SPR_RFQPending();
            rfqpending.Load();
            rfqpending.SetDataSource(reicpomsds); //Added a code snippet in app.config file. If else, will result to a System.IOFileNotFoundException error.
            string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd hhmmtt");
            string fileName = "C:\\REIC Files\\Report - Pending RFQ\\Pending RFQ (" + currentDateTime + ").pdf";
            rfqpending.ExportToDisk(ExportFormatType.PortableDocFormat, fileName);
            MessageBox.Show("A PDF file of this report on pending requests for price quotation can be found in \nC:\\REIC Files\\Report - Pending RFQ.");
            CrystalReportViewer.ReportSource = rfqpending; //Display SPR_RFQPending.rpt in the print preview
        }
    }
}
