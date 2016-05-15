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
    public partial class Supplier_AddForm : Form
    {
        public bool cancel;


        public Supplier_AddForm()
        {
            InitializeComponent();

        }
     
        public string SupplierName { get { return txtSupplierName.Text; } }
        public string SupplierPerson { get { return txtSupplierPerson.Text; } }
        public string SupplierNumber { get { return txtSupplierNumber.Text; } }
        public string SupplierEmail { get { return txtSupplierEmail.Text; } }
        public string SupplierAddress { get { return txtSupplierAddress.Text; } }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
               if (
                    (SupplierName.Length == 0) ||
                    (SupplierPerson.Length == 0) ||
                    (SupplierNumber.Length == 0) ||
                    (SupplierEmail.Length == 0) ||
                    (SupplierAddress.Length == 0)
                   )
                {
                    MessageBox.Show("All Fields are Required to be Filled out.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtSupplierEmail.Text.Contains("@") == false)
                {
                    MessageBox.Show("Please enter a valid e-mail.", "Error", MessageBoxButtons.OK);
                    return; 
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
