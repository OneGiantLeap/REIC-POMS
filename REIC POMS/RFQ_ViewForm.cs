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
        public RFQ_ViewForm()
        {
            InitializeComponent();

            //Change DGV Borderline color to gray instead of black
            dgvRFQItems.GridColor = Color.FromArgb(137, 137, 137);
        }

        //---------------------
        //  SPECIAL VARIABLES |
        //---------------------
        private bool cancel; //Will be used by Main Screen to know if it will create the RFQ or not

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

        public string AccountNumberToView { //IN DATA DICTIONARY, IT'S VARCHAR(16)
            set { outputAccountNumber.Text = value; }
            get { return outputAccountNumber.Text; } }

        public string DeliveryTermsToView {
            set { outputDeliveryTerms.Text = value; }
            get { return outputDeliveryTerms.Text; } }

        public string InFavorOfToView {
            set { outputInFavorOf.Text = value; }
            get { return outputInFavorOf.Text; } }

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

        //ENIGMA: How about the RFQItems???
        /* <--- May result to error of "Inconsistent Accessibility"
        public Items[] RFQItems {
            get { return RFQItems; }
        }*/

        public bool Cancel { get { return cancel; } }

        //-------------------
        //  BUTTON METHODS  |
        //-------------------
        private void btnCreatePQ_Click(object sender, EventArgs e)
        {
            /*
            
            */

            //---CLOSING THE FORM
            cancel = false; //Will be used by RFQ Main Screen
            Close(); //Only RFQ_MainScreen.cs remains
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cancel = true;
            Close();
        }
    }
}
