using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace REIC_POMS
{
    public partial class Item_UpdateForm : Form
    {
        private MySQLDatabaseDriver sql;
        private ArrayList supplierList;
        private ArrayList supplierDropdownList;
        public bool cancel;
        public Item_UpdateForm()
        {
            InitializeComponent();
            sql = new MySQLDatabaseDriver();

            supplierList = new ArrayList();
            sql.SelectAllSuppliers(supplierList);

            supplierDropdownList = new ArrayList();
            sql.SelectAllSupplierNames(supplierDropdownList);
            supplierDropdownList.Sort(); //Sort list alphabetically
            supplierDropdownList.Insert(0, "Select Supplier");
            cbbSupplierName.DataSource = supplierDropdownList;
            
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

        public DateTime FromDatetoEdit
        {
            set { dtpFromDate.Value = value; }
            get { return dtpFromDate.Value; }
        }

        public DateTime ToDatetoEdit
        {
            set { dtpToDate.Value = value; }
            get { return dtpToDate.Value; }
        }

        public string ItemDescriptiontoEdit
        {
            set { txtItemDesc.Text = value; }
            get { return txtItemDesc.Text; }
        }

        public string SupplierNametoEdit
        {
            set { cbbSupplierName.Text = value; }
            get { return cbbSupplierName.Text; }
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
            int numericPartNumber;
            bool numberNumeric = int.TryParse(PartNumbertoEdit, out numericPartNumber);
            int dateResult = DateTime.Compare(FromDatetoEdit, ToDatetoEdit);

            if ((PartNumbertoEdit.Length == 0) ||
                (ItemNametoEdit.Length == 0) ||
                (SupplierUnitPricetoEdit.Length == 0) ||
                (MarkuptoEdit.Length == 0) ||
                (ReicUnitPricetoEdit.Length == 0) ||
                (MoqtoEdit.Length == 0) ||
                (UomtoEdit.Length == 0))
            {
                MessageBox.Show("All Fields are Required to be Filled out.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabItemForm.SelectedTab = tabItemForm.TabPages["tabItemDetails"];
                return;
            }

            if (numberNumeric == false) //to check if partNumber only consists of numbers.
            {
                MessageBox.Show("Part Number consists of Alphabet.", "Incorrect Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabItemForm.SelectedTab = tabItemForm.TabPages["tabItemDetails"];
                return;
            }

            if (nudSuppPrice.Text == "0") //SuppPrice cannot be zero
            {
                MessageBox.Show("Supplier's Unit Price cannot be zero.", "Incorrect Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabItemForm.SelectedTab = tabItemForm.TabPages["tabItemDetails"];
                return;
            }

            if (cbbSupplierName.Text == "Select Supplier")
            {
                MessageBox.Show("Please Select a Supplier.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabItemForm.SelectedTab = tabItemForm.TabPages["tabSupplierDetails"];
                return;
            }

            if (dateResult > 0)
            {
                MessageBox.Show("To Date of Validity Period should be later than FromDate.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabItemForm.SelectedTab = tabItemForm.TabPages["tabItemDetails"];
                return;
            }
            if (dateResult == 0)
            {
                MessageBox.Show("To Date of Validity Period should be later than From Date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabItemForm.SelectedTab = tabItemForm.TabPages["tabItemDetails"];
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

        }

        private void nudSuppPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateAndUpdateUI();
        }

        private void cbbMarkup_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateAndUpdateUI();
        }

        void CalculateAndUpdateUI()
        {

            if ((SupplierUnitPricetoEdit.Length != 0) || (MarkuptoEdit.Length != 0))
            {

                double suppUnitPrice, markup, reicPrice;
                suppUnitPrice = 0;
                reicPrice = 0;
                markup = 0;

                double.TryParse(SupplierUnitPricetoEdit, out suppUnitPrice);
                double.TryParse(MarkuptoEdit, out markup);

                reicPrice = suppUnitPrice + (suppUnitPrice * markup / 100);

                txtREICPrice.Text = reicPrice.ToString("0.00");
            }
        }

        private void cbbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbSupplierName.Text == "Select Supplier")
            {
                SupplierPersontoEdit = null;
                SupplierNumbertoEdit = null;
                SupplierEmailtoEdit = null;
                SupplierAddresstoEdit = null;
                return;
            }

            for (int i = 0; i < supplierList.Count; i++)
            {
                Supplier s = (Supplier)supplierList[i];

                if (s.SupplierName == cbbSupplierName.Text)
                {
                    SupplierPersontoEdit = s.SupplierPerson;
                    SupplierNumbertoEdit = s.SupplierNumber;
                    SupplierEmailtoEdit = s.SupplierEmail;
                    SupplierAddresstoEdit = s.SupplierAddress;
                    break;
                }
            }
        }
    }
}
