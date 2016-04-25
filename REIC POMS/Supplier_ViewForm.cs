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
            Supplier_UpdateForm suf = new Supplier_UpdateForm();

            suf.SupplierNametoEdit = SupplierNametoView;
            suf.SupplierPersontoEdit = SupplierPersontoView;
            suf.SupplierNumbertoEdit = SupplierNumbertoView;
            suf.SupplierEmailtoEdit = SupplierEmailtoView;
            suf.SupplierAddresstoEdit = SupplierAddresstoView;
            this.Hide();
            suf.ShowDialog();

            if (suf.Cancel == false)
            {
                SupplierNametoView = suf.SupplierNametoEdit;
                SupplierPersontoView = suf.SupplierPersontoEdit;
                SupplierNumbertoView = suf.SupplierNumbertoEdit;
                SupplierEmailtoView = suf.SupplierEmailtoEdit;
                SupplierAddresstoView = suf.SupplierAddresstoEdit;
                cancel = false;
            }
            else
            { cancel = true; }
            this.Close();


        }
    }
}
