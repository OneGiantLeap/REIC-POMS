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
    public partial class RFQ_CreateForm : Form
    {
        public RFQ_CreateForm()
        {
            InitializeComponent();

            //Change DGV Borderline color to gray instead of black (DOESN'T WORK GAYLE HAHA).
                dgvItemSelection.GridColor = Color.FromArgb(137, 137, 137);
                dgvRFQItems.GridColor = Color.FromArgb(137, 137, 137);

            //Set default Combo Box values
                cbbFilterBy.SelectedIndex = 0; //"Filter by..."
                cbbPaymentTerms.SelectedIndex = 0; //"Select"
                cbbDeliveryTerms.SelectedIndex = 0; // "Select"
                cbbInFavorOf.SelectedIndex = 0; //"Select"
        }

        //---------------------
        //  SPECIAL VARIABLES |
        //---------------------
        private bool cancel; //Will be used by Main Screen to know if it will create the RFQ or not

        //-------------------
        //  GETTERS-SETTERS |
        //-------------------
        public string RFQNo { //ENIGMA: Format for RFQ No.
            set { txtRFQNo.Text = value; }
            get { return txtRFQNo.Text; } }

        public string RequestDate { //ENIGMA: string or datetime?
            set { dtpDateOfRequest.Text = value; } //Set it to today's date by default?
            get { return dtpDateOfRequest.Text; } }

        public string PaymentTerms {
            get { return cbbPaymentTerms.Text; } }

        public int AccountNumber { //IN DATA DICTIONARY, IT'S VARCHAR(16)
            get { return int.Parse(txtAccountNumber.Text); } }

        public string DeliveryTerms {
            get { return cbbDeliveryTerms.Text; } }

        public string InFavorOf {
            get { return cbbInFavorOf.Text; } }

        public string CustomerName {
            get { return cbbCustomerName.Text; } }

        public string SupplierName {
            get { return cbbSupplierName.Text; } }

        public string SupplierPerson {
            get { return txtSupplierPerson.Text; } }

        public string SupplierNumber {
            get { return txtSupplierNumber.Text; } }

        public string SupplierEmail {
            get { return txtSupplierEmail.Text; } }

        public string SupplierAddress {
            get { return txtSupplierAddress.Text; } }

        //ENIGMA: How about the RFQItems???
        /* <--- May result to error of "Inconsistent Accessibility"
        public Items[] RFQItems {
            get { return RFQItems; }
        }*/
        
        public bool Cancel { //Will be used by Customer_MainScreen.cs
            get { return cancel; } } 

        //-------------------
        //  BUTTON METHODS  |
        //-------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            //---VALIDATING FORM CONTENTS
            /*Special Conditions (List as of 04/13/2016) *Mark [x] if accomplished
                [ ] Maarte na RFQ No. formatting/auto-generation
                [ ] If Payment Terms is Credit, enable AccountNumber field to be edited.
                [ ] If other Payment Terms options are selected, Account Number is disabled.
                [ ] Disallow comboBox values to be edited
            */


            //*****INSERT THY CODE HERE*****


            //---CLOSING THE FORM
            cancel = false; //Will be used by RFQ Main Screen
            Close(); //Only RFQ_MainScreen.cs remains
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            Close();
        }
    }
}
