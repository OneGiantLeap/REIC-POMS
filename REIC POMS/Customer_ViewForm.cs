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
    public partial class Customer_ViewForm : Form
    {
        public Customer_ViewForm()
        {
            InitializeComponent();
        }
        //---------------------
        //  SPECIAL VARIABLES |
        //---------------------
        private bool cancel; //Will be used by Main Screen to know if it will update the Customer array & DGV

        //-------------------
        //  GETTERS-SETTERS |
        //-------------------
        public string BNameToView {
            set { outputBusinessName.Text = value; }
            get { return outputBusinessName.Text; } }

        public string TinToView {
            set { outputTinNumber.Text = value;  }
            get { return outputTinNumber.Text; } }

        public string NameToView {
            set { outputCustomerName.Text = value; }
            get { return outputCustomerName.Text; } }

        public string PersonToView {
            set { outputCustomerPerson.Text = value; }
            get { return outputCustomerPerson.Text; } }

        public string NumberToView {
            set { outputCustomerNumber.Text = value; }
            get { return outputCustomerNumber.Text; } }

        public string AcctNumberToView {
            set { outputAccountNumber.Text = value; }
            get { return outputAccountNumber.Text; } }

        public string EmailToView {
            set { outputCustomerEmail.Text = value; }
            get { return outputCustomerEmail.Text; } }

        public string AddressToView {
            set { outputCustomerAddress.Text = value; }
            get { return outputCustomerAddress.Text; } }

        public bool Cancel { get { return cancel; } }

        //-------------------
        //  BUTTON METHODS  |
        //-------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*---CODING NOTES
                1. The View Form was hidden and not closed right away, because data from the Update Form will be
                passed onto the View Form after the Update Form's Update button has been clicked.
                2. If Update button in Update Form was clicked, update View Form's values, which will be
                where the Customer Main Screen will obtain the updated data from in order to update the
                Customer array and the Main Screen DGV as well.  */

            Customer_UpdateForm cuf = new Customer_UpdateForm();
            //Fill out Update Form's textBoxes + Open Update Form
                cuf.BNameToEdit = BNameToView;
                if (TinToView != "N/A")
                    { cuf.TinFilled = true; }//Tells Update Form that it has to split the "TIN Number" to the 4 text boxes
                cuf.FullTinToEdit = TinToView;
                cuf.NameToEdit = NameToView;
                cuf.PersonToEdit = PersonToView;
                cuf.NumberToEdit = NumberToView;
                cuf.AcctNumberToEdit = AcctNumberToView;
                cuf.EmailToEdit = EmailToView;
                cuf.AddressToEdit = AddressToView;
                this.Hide(); //Hide View Form | If this is added, when you click Update in view form, Main Screen is minimized.
                cuf.ShowDialog(); //Open Customer_UpdateForm.cs
            
            if (cuf.Cancel == false) //Customer values were updated
            { //Update values in View Form so Main Screen can obtain them (Data passing from Update -> View -> Main Screen)
                BNameToView = cuf.BNameToEdit;
                TinToView = cuf.FullTinToEdit;
                NameToView = cuf.NameToEdit;
                PersonToView = cuf.PersonToEdit;
                NumberToView = cuf.NumberToEdit;
                AcctNumberToView = cuf.AcctNumberToEdit;
                EmailToView = cuf.EmailToEdit;
                AddressToView = cuf.AddressToEdit;
                cancel = false;
            }
            else { cancel = true; } //cuf.Cancel == true | Clicked Update button in View Form but Close button in Update Form

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }

    }
}
