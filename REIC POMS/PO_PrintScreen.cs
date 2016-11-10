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
    public partial class PO_PrintScreen : Form
    { //This results from Create PO's [Save & Generate PDF] button or View PO [PDF] icon

        //ATTRIBUTES
        private MySqlConnection connection;
        private reicpomsDataSet reicpomsds;
        private MySqlDataAdapter adapter;
        private string poNo; //Used to retrieve a specific RFQ
        private bool firstTime; //If it's the first time the report's made, it's saved into the computer

        //CONSTRUCTOR
        public PO_PrintScreen()
        {
            InitializeComponent();
            CrystalReportViewer.ReportSource = null;
        }

        //-------------------
        //  GETTERS-SETTERS |
        //-------------------
        public string PONo //To use in SQL statement
        {
            set { poNo = value; } //Value set as this form is instantiated
            get { return poNo; }
        }

        public bool FirstTime
        {
            set { firstTime = value; }
            get { return firstTime; }
        }

        private void PO_PrintScreen_Load(object sender, EventArgs e)
        { //When screen loads, details of the RFQ Printout should already be displayed.
            //---MYSQL CONNECTION
            connection = new MySqlConnection(ConnectionStringManager.reicpomsConnection.ConnectionString);
            connection.Open();

            //DEBUG MESSAGES
            if (connection.State == System.Data.ConnectionState.Open)
            { MessageBox.Show("Crystal Report: Connection to SQL successful!"); }
            else
            { MessageBox.Show("Crystal Report: Connection to SQL failed!"); }

            //---SELECT Statements
            reicpomsds = new reicpomsDataSet();

            //Data from supplier_t
            string selectRFQSupplier = string.Format("SELECT supplier_t.supplier_id, supplier_name, contact_person, contact_number, email_address, address " +
                                                  "FROM po_t, supplier_t " +
                                                  "WHERE po_t = '{0}' " +
                                                  "AND po_t.supplier_id = supplier_t.supplier_id;", PONo);
            adapter = new MySqlDataAdapter(selectRFQSupplier, connection);
            adapter.Fill(reicpomsds, "supplier_t");

            //Data from po_order_line_t, inserted into item_t
            string selectPOOrderLineItems = string.Format("SELECT item_t.part_number, item_name, item_description, supplier_unit_price, mark_up_percentage, reic_unit_price, minimum_order_quantity, unit_of_measurement, from_date, to_date, supplier_id " +
                                                        "FROM po_order_line_t, item_t " +
                                                        "WHERE po_no = '{0}' " +
                                                        "AND po_order_line_t.part_number = item_t.part_number;", PONo);
            adapter = new MySqlDataAdapter(selectPOOrderLineItems, connection);
            adapter.Fill(reicpomsds, "item_t");

            //Data from po_t
            string selectPO = string.Format("SELECT * FROM po_t WHERE po_no='{0}';", PONo);
            adapter = new MySqlDataAdapter(selectPO, connection);
            adapter.Fill(reicpomsds, "po_t");

            //Data from po_order_line_t
            string selectPOOrderLine = string.Format("SELECT * FROM po_order_line_t WHERE po_no='{0}';", PONo);
            adapter = new MySqlDataAdapter(selectPOOrderLine, connection);
            adapter.Fill(reicpomsds, "po_order_line_t");

            connection.Close();

            //---INSTANTIATE CRYSTAL REPORT
            POPrintout po = new POPrintout();
            po.Load();
            po.SetDataSource(reicpomsds); //Added a code snippet in app.config file. If else, will result to a System.IOFileNotFoundException error.
            string fileName = "C:\\REIC Files\\Purchase Orders\\PO " + PONo + ".pdf";
            if (FirstTime == true)
            {
                po.ExportToDisk(ExportFormatType.PortableDocFormat, fileName);
                MessageBox.Show("A PDF file of this Purchase Order can be found in \nC:\\REIC Files\\Purchase Orders.");
            }
            CrystalReportViewer.ReportSource = po; //Display POPrintout.rpt in the print preview
        }
    }
}
