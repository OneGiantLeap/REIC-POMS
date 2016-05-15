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
using MySql.Data.MySqlClient;

namespace REIC_POMS
{
    public partial class Item_AddForm : Form
    {
        private MySQLDatabaseDriver sql;
        private ArrayList supplierList;
        private ArrayList supplierDropdownList;
        private ArrayList itemList;
        private bool cancel;
        private int dateResult;
        private int supplierIDFK;

        public Item_AddForm()
        {
            InitializeComponent();
            sql = new MySQLDatabaseDriver();

            itemList = new ArrayList();
            supplierList = new ArrayList();
            sql.SelectAllSuppliers(supplierList);

            supplierDropdownList = new ArrayList();
            sql.SelectAllSupplierNames(supplierDropdownList);
            supplierDropdownList.Sort(); //Sort list alphabetically
            supplierDropdownList.Insert(0, "Select Supplier");
            cbbSupplierName.DataSource = supplierDropdownList; //Populate the dropdown


        }

        private void Item_AddForm_Load(object sender, EventArgs e)
        { }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.CustomFormat = "MM/dd/yyyy";
            dtpToDate.CustomFormat = "MM/dd/yyyy";
        }

        private void cbbUOM_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cbbUOM.SelectedIndex = 0;
        }

        /*
        we use DateTime, para we could compare two dates if FromDate is earlier than ToDate through DateTime.Compare 
        pero if we could think of ways pa how to compare this as a String, we could just put it as "dtpFromDate.Value.ToString()"
        */
        public string PartNumber { get { return txtPartNumber.Text; } }
        public string ItemName { get { return txtItemName.Text; } }
        public string SupplierUnitPrice { get { return nudSuppPrice.Value.ToString(); } }
        public string Markup { get { return cbbMarkup.Text; } }
        public string ReicUnitPrice { get { return txtREICPrice.Text; } }
        public string Moq { get { return nudMOQ.Value.ToString(); } }
        public string Uom { get { return cbbUOM.Text; } }
        public DateTime FromDate { get { return dtpFromDate.Value; } }
        public DateTime ToDate { get { return dtpToDate.Value; } }
        public string ItemDescription { get { return txtItemDesc.Text; } }
        public string SupplierName { get { return cbbSupplierName.Text; } }
        public string SupplierPerson
        {
            set { txtSupplierPerson.Text = value; }
            get { return txtSupplierPerson.Text; }
        }

        public string SupplierNumber
        {
            set { txtSupplierNumber.Text = value; }
            get { return txtSupplierNumber.Text; }
        }

        public string SupplierEmail
        {
            set { txtSupplierEmail.Text = value; }
            get { return txtSupplierEmail.Text; }
        }

        public string SupplierAddress
        {
            set { txtSupplierAddress.Text = value; }
            get { return txtSupplierAddress.Text; }
        }

        public int SupplierIDFK
        {
            set { supplierIDFK = value; }
            get { return supplierIDFK; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //   do
            //  {
            /*  for (int i = 0; i < itemList.Count; i++)
              {
                  Item item = (Item)itemList[i]; //retrieve attribute values from this specific RFQ.
                  if (item.PartNumber == txtPartNumber.Text)
                  {
                      MessageBox.Show("PartNumber already exist", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      tabItemForm.SelectedTab = tabItemForm.TabPages["tabItemDetails"];
                      return;
                  } */
            
                
                int numericPartNumber;
                bool numberNumeric = int.TryParse(PartNumber, out numericPartNumber);
                int countPartNumber = sql.GetPNCount(PartNumber); //call db to check if there is already that part number that exist
                dateResult = DateTime.Compare(FromDate, ToDate);

                if (
                    (PartNumber.Length == 0) ||
                    (ItemName.Length == 0) ||
                    (SupplierUnitPrice.Length == 0) ||
                    (Markup.Length == 0) ||
                    (ReicUnitPrice.Length == 0) ||
                    (Moq.Length == 0) ||
                    (Uom.Length == 0)
                    )
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

                if (countPartNumber > 0)
                {
                MessageBox.Show("Part Number already exist.", "Incorrect Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("To Date of Validity Period should be later than From Date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabItemForm.SelectedTab = tabItemForm.TabPages["tabItemDetails"];
                    return;
                }


                if (dateResult == 0)
                {
                    MessageBox.Show("To Date of Validity Period should be later than From Date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabItemForm.SelectedTab = tabItemForm.TabPages["tabItemDetails"];
                    return;
                }
                SupplierIDFK = sql.SelectSupplierID(SupplierName);
          
            
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
           
            if ((SupplierUnitPrice.Length != 0) || (Markup.Length != 0))
            {

                double suppUnitPrice, markup, reicPrice;
                suppUnitPrice = 0;
                reicPrice = 0;
                markup = 0;

                double.TryParse(SupplierUnitPrice, out suppUnitPrice);
                double.TryParse(Markup, out markup);

                reicPrice = suppUnitPrice + (suppUnitPrice * markup/100);
                
                txtREICPrice.Text = reicPrice.ToString("0.00");
            }
        }

       private void txtREICPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateAndUpdateUI();
        }

        private void cbbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSupplierName.Text == "Select Supplier")
            {
                SupplierPerson = null;
                SupplierNumber = null;
                SupplierEmail = null;
                SupplierAddress = null;
                return;
            }

            for (int i = 0; i < supplierList.Count; i++)
            {
                Supplier s = (Supplier)supplierList[i]; 
                if (s.SupplierName == cbbSupplierName.Text)
                {
                    SupplierPerson = s.SupplierPerson;
                    SupplierNumber = s.SupplierNumber;
                    SupplierEmail = s.SupplierEmail;
                    SupplierAddress = s.SupplierAddress;
                    break; 
                }
            }
        }
    }
}
