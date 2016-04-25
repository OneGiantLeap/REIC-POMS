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
    public partial class Item_UpdateForm : Form
    {
        public bool cancel;
        public Item_UpdateForm()
        {
            InitializeComponent();
        }

        public string PartNumbertoEdit
        {
            set { txtPartNumber.Text = value; }
            get { return txtPartNumber.Text; }
        }

        public string ItemNametoEdit
        {
            set { txtItemName.Text = value; }
            get { return txtItemName.Text; }
        }

        public string SupplierUnitPricetoEdit
        {
            set { nudSuppPrice.Text = value; }
            get { return nudSuppPrice.Value.ToString(); }
        }

        public string MarkuptoEdit
        {
            set { cbbMarkup.Text = value; }
            get { return cbbMarkup.Text; }
        }

        public string ReicUnitPricetoEdit
        {
            set { txtREICPrice.Text = value; }
            get { return txtREICPrice.Text; }
        }

        public string MoqtoEdit
        {
            set { nudMOQ.Text = value; }
            get { return nudMOQ.Value.ToString(); }
        }

        public string UomtoEdit
        {
            set { cbbUOM.Text = value; }
            get { return cbbUOM.Text; }
        }

        public string FromDatetoEdit
        {
            set { dtpFromDate.Text = value; }
            get { return dtpFromDate.Text; }
        }

        public string ToDatetoEdit
        {
            set { dtpToDate.Text = value; }
            get { return dtpToDate.Text; }
        }

        public string ItemDescriptiontoEdit
        {
            set { txtItemDesc.Text = value; }
            get { return txtItemDesc.Text; }
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

            if ((PartNumbertoEdit.Length == 0) ||
                (ItemNametoEdit.Length == 0) ||
                (SupplierUnitPricetoEdit.Length == 0) ||
                (MarkuptoEdit.Length == 0) ||
                (ReicUnitPricetoEdit.Length == 0) ||
                (MoqtoEdit.Length == 0) ||
                (UomtoEdit.Length == 0) ||
                (FromDatetoEdit.Length == 0) ||
                (ToDatetoEdit.Length == 0) ||
                (SupplierNametoEdit.Length == 0) ||
                (SupplierPersontoEdit.Length == 0) ||
                (SupplierNumbertoEdit.Length == 0) ||
                (SupplierEmailtoEdit.Length == 0) ||
                (SupplierAddresstoEdit.Length == 0))

            {
                MessageBox.Show("All fields should be completed", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cancel = false;
            this.Close();
        }

        public bool Cancel
        {
            get { return cancel; }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabItemForm.SelectedTab = tabSupplierDetails;
        }

        private void cbbUOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbUOM.SelectedIndex = 0;
        }
    }
}
