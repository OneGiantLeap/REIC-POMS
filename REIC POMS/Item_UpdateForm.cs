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
        private ArrayList supplierList;
        private ArrayList supplierDropdownList;
        public bool cancel;
        public Item_UpdateForm()
        {
            InitializeComponent();
            supplierList = new ArrayList();
            supplierDropdownList = new ArrayList();

            try
            {
                FileStream fs = new FileStream(@"supplier.txt", FileMode.Open);
                StreamReader readin = new StreamReader(fs);
                while (!readin.EndOfStream)
                {
                    string[] text = readin.ReadLine().Split('|');
                    supplierList.Add(new Supplier(text[0], text[1], text[2], text[3], text[4], text[5])); //Recreate the Supplier
                    supplierDropdownList.Add(text[1]); //Just the Supplier Names
                                                       /*Reason for two ArrayLists. If I try to display the supplierList in the dropdown, what
                                                       displays is "REIC_POMS.Supplier" I don't know how to just display a specific attribute
                                                       from each Supplier instance.*/
                }
                readin.Close();
                fs.Close();
                supplierDropdownList.Sort(); //Sort list alphabetically
               // supplierDropdownList.Insert(0, "Select Supplier");
                cbbSupplierName.DataSource = supplierDropdownList; //Populate the dropdown w/ all Customer Names
            }
            catch (Exception /*e*/) { }


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
