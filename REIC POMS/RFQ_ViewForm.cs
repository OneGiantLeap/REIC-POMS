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
        public string RFQNoToView { //ENIGMA: Format for RFQ No.
            set { outputRFQNo.Text = value; }
            get { return outputRFQNo.Text; } }

        public string RequestDateToView { //ENIGMA: string or datetime?
            set { outputDateOfRequest.Text = value; } //Set it to today's date by default?
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

        /*public DataGridView RFQItemsToView
        {
            set { dgvRFQItems.DataSource = value; }
            get;
        }*/

        /*public bool Cancel {
            get { return cancel; } }*/

        //-------------------
        //  BUTTON METHODS  |
        //-------------------
        private void btnCreatePQ_Click(object sender, EventArgs e)
        {
            /*
            
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
    }
}
