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
        public bool filledOut;


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
            do
            {
                if (
                    (SupplierName.Length == 0) ||
                    (SupplierPerson.Length == 0) ||
                    (SupplierNumber.Length == 0) ||
                    (SupplierEmail.Length == 0) ||
                    (SupplierAddress.Length == 0)
                   )
                {

                    DialogResult result = MessageBox.Show("All fields are required to be filled out.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        return;
                    }
                }

                else { filledOut = true; }

            } while (filledOut == false);

            cancel = false;
            this.Close();
        }

        public bool Cancel
        {
            get { return cancel; }
        }

    }
}
