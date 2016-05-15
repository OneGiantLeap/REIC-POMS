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
    public partial class Customer_AddForm : Form
    {
        public Customer_AddForm()
        {
            InitializeComponent();
        }

        //---------------------
        //  SPECIAL VARIABLES |
        //---------------------
        private bool cancel; //Will be used by Main Screen to know if it will create the Customer or not
        string fullTin; //Entire TIN Number (values from the 4 boxes combined)

        //-------------------
        //  GETTERS-SETTERS |
        //-------------------
        //No getter for CustomerID, since it's an internal variable. (The value will come from Customer Main Screen.)
        public string BusinessName { set { txtBusinessName.Text = value; } //Will be used to set the text to "N/A" if this field is null.
                                     get { return txtBusinessName.Text; } } //Maximum of 25 characters; can be null
        public string FullTinNumber { set { fullTin = value; }
                                      get { return fullTin; } }
        public string TinNumber1 { set { txtTinNumber1.Text = value; } 
                                   get { return txtTinNumber1.Text; } } 
        public string TinNumber2 { set { txtTinNumber2.Text = value; }
                                   get { return txtTinNumber2.Text; } }
        public string TinNumber3 { set { txtTinNumber3.Text = value; }
                                   get { return txtTinNumber3.Text; } }
        public string TinNumber4 { set { txtTinNumber4.Text = value; }
                                   get { return txtTinNumber4.Text; } }
        public string CustomerName { get { return txtCustomerName.Text; } } //Any valid name | I DID NOT SET A MAXLENGTH FOR THIS YET
        public string CustomerPerson { get { return txtCustomerPerson.Text; } } //Any valid name | I DID NOT SET A MAXLENGTH FOR THIS YET
        public string CustomerNumber { get { return txtCustomerNumber.Text; } } //Maximum of 13 characters
        public string AccountNumber { set { txtAccountNumber.Text = value; }
                                      get { return txtAccountNumber.Text; } } //Maximum of 16 characters
        public string CustomerEmail { get { return txtCustomerEmail.Text; } } //Maximum of 40 characters
        public string CustomerAddress { get { return txtCustomerAddress.Text; } } //Maximum of 150 characters
        public bool Cancel { get { return cancel; } } //Will be used by Customer_MainScreen.cs

        //-------------------
        //  BUTTON METHODS  |
        //-------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //---VALIDATION
            //If any text field that can't be null is empty, display error message.
            if ((txtCustomerName.TextLength == 0) ||
                    (txtCustomerPerson.TextLength == 0) ||
                    (txtCustomerNumber.TextLength == 0) ||
                    (txtCustomerEmail.TextLength == 0) ||
                    (txtCustomerAddress.TextLength == 0))
                {
                    MessageBox.Show("All fields, except Business Style/Name, TIN Number, and Account Number, are required to be filled out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //Enables user to edit the form again
            }

            //If E-mail text field doesn't have the @ sign
            if (txtCustomerEmail.Text.Contains("@") == false)
                {
                    MessageBox.Show("Please enter a valid e-mail.", "Error", MessageBoxButtons.OK);
                    return; //Enables user to edit the form again
            }

            //If optional fields are empty, set values to N/A (Will be useful for View Form later on.)
            if (txtBusinessName.TextLength == 0) { BusinessName = "N/A"; }
            fullTin = txtTinNumber1.Text + txtTinNumber2.Text + txtTinNumber3.Text + txtTinNumber4.Text; //For checking
                if ((fullTin == "") || (fullTin.Contains("N/A") == true)) //If fullTin contains no numbers or "N/A"
                { 
                    FullTinNumber = "N/A";
                } 
                else if (fullTin.Length != 12) //If TIN input is partially complete
                {
                    MessageBox.Show("TIN number is incomplete.", "Error", MessageBoxButtons.OK);
                    return; //Enables user to edit the form again
                }
                else //Correct
                {
                    fullTin = txtTinNumber1.Text + "-" + txtTinNumber2.Text + "-" + txtTinNumber3.Text + "-" + txtTinNumber4.Text;
                    FullTinNumber = fullTin;
                }
            if (txtAccountNumber.TextLength == 0) { AccountNumber = "N/A"; }

            //---CLOSE FORM
            cancel = false; //Will be used by Customer Main Screen
            this.Close(); //Only Customer_MainScreen.cs remains
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }

        //------------------------
        //  OTHER FORM ELEMENTS  |
        //------------------------
        //If User has input 3 characters in a TIN textbox part, text cursor jumps to the next textbox part.
        private void txtTinNumber1_TextChanged(object sender, EventArgs e)
        {
            if (txtTinNumber1.TextLength == 3)
            {
                txtTinNumber2.Select();
                txtTinNumber2.Focus();
            }
        }

        private void txtTinNumber2_TextChanged(object sender, EventArgs e)
        {
            if (txtTinNumber2.TextLength == 3)
            {
                txtTinNumber3.Select();
                txtTinNumber3.Focus();
            }
        }

        private void txtTinNumber3_TextChanged(object sender, EventArgs e)
        {
            if (txtTinNumber3.TextLength == 3)
            {
                txtTinNumber4.Select();
                txtTinNumber4.Focus();
            }
        }
    }
}
