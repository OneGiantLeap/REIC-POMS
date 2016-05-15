using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REIC_POMS
{
    public partial class RFQ_ViewForm : Form
    {
        //ATTRIBUTES
        private MySQLDatabaseDriver sql;

        public RFQ_ViewForm()
        {
            InitializeComponent();
            sql = new MySQLDatabaseDriver();

            //---ADJUST DATAGRIDVIEW COLUMN ALIGNMENT
            //Center column headings
                dgvRFQItems.Columns["UOM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvRFQItems.Columns["Qty"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Center column cell contents
                dgvRFQItems.Columns["UOM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvRFQItems.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void RFQ_ViewForm_Load(object sender, EventArgs e)
        {
            sql.SelectSpecificRFQOrderLine(RFQNoToView, dgvRFQItems); //Has to be placed HERE, not in initialize
        }

        //---------------------
        //  SPECIAL VARIABLES |
        //---------------------
        //private bool cancel; //I probably don't need this, pero ayaw ko pa i-let go. Hay...

        //-------------------
        //  GETTERS-SETTERS |
        //-------------------
        public string RFQNoToView {
            set { outputRFQNo.Text = value; }
            get { return outputRFQNo.Text; } }

        public string RequestDateToView {
            set { outputDateOfRequest.Text = value; }
            get { return outputDateOfRequest.Text; } }

        public string PaymentTermsToView {
            set { outputPaymentTerms.Text = value; }
            get { return outputPaymentTerms.Text; } }

        /*public string AccountNumberToView { --> No longer needed
            set { outputAccountNumber.Text = value; }
            get { return outputAccountNumber.Text; } }*/

        public string DeliveryTermsToView {
            set { outputDeliveryTerms.Text = value; }
            get { return outputDeliveryTerms.Text; } }

        public string CustomerNameToView {
            set { outputCustomerName.Text = value; }
            get { return outputCustomerName.Text; } }

        public string SupplierNameToView {
            set { outputSupplierName.Text = value; }
            get { return outputSupplierName.Text; } }

        public string SupplierPersonToView {
            set { outputSupplierPerson.Text = value; }
            get { return outputSupplierPerson.Text; } }

        public string SupplierNumberToView {
            set { outputSupplierNumber.Text = value; }
            get { return outputSupplierNumber.Text; } }

        public string SupplierEmailToView {
            set { outputSupplierEmail.Text = value;  }
            get { return outputSupplierEmail.Text; } }

        public string SupplierAddressToView {
            set { outputSupplierAddress.Text = value; }
            get { return outputSupplierAddress.Text; } }

        /*public bool Cancel {
            get { return cancel; } }*/

        //-------------------
        //  BUTTON METHODS  |
        //-------------------
        private void btnCreatePQ_Click(object sender, EventArgs e)
        {
            /*
                Logic:
                Instantiate PQ form
                Transfer details. FUDGE.
            */

            //---CLOSING THE FORM
            //cancel = false; Still thinking if I still need thiiis
            Close(); //Only RFQ_MainScreen.cs remains
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //cancel = true; Still thinking if I still need thiiis
            Close(); 
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            RFQ_PrintScreen rfqps = new RFQ_PrintScreen();
            rfqps.RFQNo = RFQNoToView; //For the Print Screen to use in its SQL statement
            rfqps.ShowDialog();
        }
    }
}
