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
    public partial class Supplier_ViewForm : Form
    {
        public Supplier_ViewForm()
        {
            InitializeComponent();
        }
        public bool cancel;

 
        public string SupplierNametoView
        {
            set { outputSupplierName.Text = value; }
            get { return outputSupplierName.Text; }
        }

        public string SupplierPersontoView
        {
            set { outputSupplierPerson.Text = value; }
            get { return outputSupplierPerson.Text; }
        }

        public string SupplierNumbertoView
        {
            set { outputSupplierNumber.Text = value; }
            get { return outputSupplierNumber.Text; }
        }

        public string SupplierEmailtoView
        {
            set { outputSupplierEmail.Text = value; }
            get { return outputSupplierEmail.Text; }
        }

        public string SupplierAddresstoView
        {
            set { outputSupplierAddress.Text = value; }
            get { return outputSupplierAddress.Text; }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }

        public bool Cancel
        {
            get { return cancel; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Item_UpdateForm iuf = new Item_UpdateForm();

            iuf.SupplierNametoEdit = SupplierNametoView;
            iuf.SupplierPersontoEdit = SupplierPersontoView;
            iuf.SupplierNumbertoEdit = SupplierNumbertoView;
            iuf.SupplierEmailtoEdit = SupplierEmailtoView;
            iuf.SupplierAddresstoEdit = SupplierAddresstoView;
            this.Hide();
            iuf.ShowDialog();

            if (iuf.Cancel == false)
            {
                SupplierNametoView = iuf.SupplierNametoEdit;
                SupplierPersontoView = iuf.SupplierPersontoEdit;
                SupplierNumbertoView = iuf.SupplierNumbertoEdit;
                SupplierEmailtoView = iuf.SupplierEmailtoEdit;
                SupplierAddresstoView = iuf.SupplierAddresstoEdit;
                cancel = false;
            }
            else
            { cancel = true; }
            this.Close();


        }
    }
}
