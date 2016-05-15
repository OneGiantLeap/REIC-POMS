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
    public partial class Supplier_UpdateForm : Form
    {
        public bool cancel;
        public Supplier_UpdateForm()
        {
            InitializeComponent();
        }

        public string SupplierNametoEdit
        {
            set { txtSupplierName.Text = value; }
            get { return txtSupplierName.Text; }
        }

        public string SupplierPersontoEdit
        {
            set { txtSupplierPerson.Text = value; }
            get { return txtSupplierPerson.Text; }
        }

        public string SupplierNumbertoEdit
        {
            set { txtSupplierNumber.Text = value; }
            get { return txtSupplierNumber.Text; }
        }

        public string SupplierEmailtoEdit
        {
            set { txtSupplierEmail.Text = value; }
            get { return txtSupplierEmail.Text; }
        }

        public string SupplierAddresstoEdit
        {
            set { txtSupplierAddress.Text = value; }
            get { return txtSupplierAddress.Text; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (
                (SupplierNametoEdit.Length == 0) ||
                (SupplierPersontoEdit.Length == 0) ||
                (SupplierNumbertoEdit.Length == 0) ||
                (SupplierEmailtoEdit.Length == 0) ||
                (SupplierAddresstoEdit.Length == 0))

            {
                MessageBox.Show("All Fields are Required to be Filled out.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSupplierEmail.Text.Contains("@") == false)
            {
                MessageBox.Show("Please enter a valid e-mail.", "Error", MessageBoxButtons.OK);
                return; //Enables user to edit the form again
            }

            cancel = false;
            this.Close();
        }

        public bool Cancel
        {
            get { return cancel; }
        }
    }
}
