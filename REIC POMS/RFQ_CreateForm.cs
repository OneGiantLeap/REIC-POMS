using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Enables Filestream  (Temporary, since no MySQL yet)
using System.Collections; //Enables use of ArrayList

namespace REIC_POMS
{
    public partial class RFQ_CreateForm : Form
    {
        private ArrayList customerList; //To temporarily store all customers (Names only). REPLACE W/ MYSQL LATER?
        private ArrayList supplierList; //To temporarily store all suppliers. REPLACE W/ MYSQL LATER?
        private ArrayList supplierDropdownList; //Just for the text to display in the dropdown list
        private ArrayList itemList; //To temporarily store all items. REPLACE W/ MYSQL LATER?
        private ArrayList rfqItemList; //Items in the RFQ

        public RFQ_CreateForm()
        {
            InitializeComponent();

            customerList = new ArrayList(); //To temporarily store all customers. REPLACE W/ MYSQL LATER?
            supplierList = new ArrayList(); //To temporarily store all suppliers. REPLACE W/ MYSQL LATER?
            supplierDropdownList = new ArrayList(); //Just for the text to display in the dropdown list
            itemList = new ArrayList(); //To temporarily store all items. REPLACE W/ MYSQL LATER?
            rfqItemList = new ArrayList();

            //Populate the Customers Dropdown List (Names only) *WARNING: Temporary Streamreader. Replace w/ MySQL later
            try
                {
                    FileStream fs = new FileStream(@"customer.txt", FileMode.Open);
                    StreamReader readin = new StreamReader(fs);
                    while (!readin.EndOfStream)
                    {
                        string[] text = readin.ReadLine().Split('|');
                        customerList.Add(text[3]); //Just noting the Customer Names
                    }
                    readin.Close();
                    fs.Close();
                    customerList.Sort(); //Sort list alphabetically
                    customerList.Insert(0, "Select Customer");
                    cbbCustomerName.DataSource = customerList; //Populate the dropdown w/ all Customer Names
                }
                catch (Exception /*e*/) { }

            //Populate the Suppliers Dropdown List (Names only) *WARNING: Temporary Streamreader. Replace w/ MySQL later
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
                    supplierDropdownList.Insert(0, "Select Supplier");
                    cbbSupplierName.DataSource = supplierDropdownList; //Populate the dropdown w/ all Customer Names
                }
                catch (Exception /*e*/) { }

            //Populate the Item Selection DGV *WARNING: Temporary Streamreader. Replace w/ MySQL later
                try
                {
                    FileStream fs = new FileStream(@"item.txt", FileMode.Open);
                    StreamReader readin = new StreamReader(fs);
                    while (!readin.EndOfStream)
                    {
                        string[] text = readin.ReadLine().Split('|');
                        //Place Item at Item Selection DGV (Part No., Item Name, Description, UOM, Supplier's Unit Price)
                        dgvItemSelection.Rows.Add(text[0], text[1], text[9], text[6], decimal.Parse(text[3]).ToString("0.00")); 
                        itemList.Add(new Item(text[0], text[1], double.Parse(text[2]), double.Parse(text[3]), double.Parse(text[4]),
                                                int.Parse(text[5]), text[6], text[7], text[8], text[9],
                                                text[10], text[11], text[12], text[13], text[14])); //Recreate the Item
                    }
                    readin.Close();
                    fs.Close();
                }
                catch (Exception /*e*/) { }

            //Change DGV Borderline color to gray instead of black (DOESN'T WORK GAYLE HAHA).
            dgvItemSelection.GridColor = Color.FromArgb(137, 137, 137);
            dgvRFQItems.GridColor = Color.FromArgb(137, 137, 137);

            //Set default Combo Box values
            cbbFilterBy.SelectedIndex = 0; //"Filter by..."
            cbbPaymentTerms.SelectedIndex = 0; //"Select"
            cbbDeliveryTerms.SelectedIndex = 0; // "Select"
            cbbInFavorOf.SelectedIndex = 0; //"Select"
            //cbbCustomerName.Text = "Select Customer";
            //cbbSupplierName.Text = "Select Supplier";
            txtItemName.Text = dgvItemSelection.SelectedRows[0].Cells["ItemName"].Value.ToString();

            //---ADJUST DATAGRIDVIEW COLUMN ALIGNMENT
            //Center column headings
            dgvItemSelection.Columns["UOM"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvItemSelection.Columns["UOM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRFQItems.Columns["RFQUOM"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRFQItems.Columns["Qty"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Center column cell contents
            dgvItemSelection.Columns["PartNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvItemSelection.Columns["UOM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRFQItems.Columns["RFQUOM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRFQItems.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Right-align column headings
            dgvItemSelection.Columns["UnitPrice"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //Right-align column cell contents
            dgvItemSelection.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        //---------------------
        //  SPECIAL VARIABLES |
        //---------------------
        private bool cancel; //Will be used by Main Screen to know if it will create the RFQ or not

        //-------------------
        //  GETTERS-SETTERS |
        //-------------------
        public string RFQNo { //ENIGMA: Format for RFQ No.
            set { txtRFQNo.Text = value; } //Setter added, since it's auto-generated
            get { return txtRFQNo.Text; } }

        public string RequestDate { //ENIGMA: string or datetime?
            set { dtpDateOfRequest.Text = value; } //Setter added to set it to today's date by default?
            get { return dtpDateOfRequest.Text; } }

        public string PaymentTerms {
            get { return cbbPaymentTerms.Text; } }

        public string AccountNumber { //IN DATA DICTIONARY, IT'S VARCHAR(16)
            get { return txtAccountNumber.Text; } }

        public string DeliveryTerms {
            get { return cbbDeliveryTerms.Text; } }

        public string InFavorOf {
            get { return cbbInFavorOf.Text; } }

        public string CustomerName {
            get { return cbbCustomerName.Text; } }

        public string SupplierName {
            get { return cbbSupplierName.Text; } }

        public string SupplierPerson {
            set { txtSupplierPerson.Text = value; } //Setter placed for the auto-complete feature
            get { return txtSupplierPerson.Text; } }

        public string SupplierNumber {
            set { txtSupplierNumber.Text = value; } //Setter placed for the auto-complete feature
            get { return txtSupplierNumber.Text; } }

        public string SupplierEmail {
            set { txtSupplierEmail.Text = value; } //Setter placed for the auto-complete feature
            get { return txtSupplierEmail.Text; } }

        public string SupplierAddress {
            set { txtSupplierAddress.Text = value; } //Setter placed for the auto-complete feature
            get { return txtSupplierAddress.Text; } }

        public ArrayList RFQItemsList {
            get { return rfqItemList; } }
        
        public bool Cancel { //Will be used by Customer_MainScreen.cs
            get { return cancel; } }

        //-------------------
        //  BUTTON METHODS  |
        //-------------------
        /* FOR: btnSave_Click,
                btnCancel_Click,
                btnAddToRequest_Click,
                btnRemoveItem_Click,
                btnClearItems_Click
        */

        private void btnSave_Click(object sender, EventArgs e)
        {   //-------------------------------------------------------
            // btnSave_Click: ERROR MESSAGES FOR INCOMPLETE FIELDS  |
            //-------------------------------------------------------
            /*NO LONGER APPLIES (Account Number is editable for ALL options)
            //If Payment Term is Credit, then Account Number must be filled out
            if ((cbbPaymentTerms.Text == "Credit") && (txtAccountNumber.TextLength == 0))
            { MessageBox.Show("Since Credit is selected for Payment Terms, please include an Account Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabRFQForm.SelectedTab = tabRFQForm.TabPages["tabRequestDetails"]; //Directs user to the Request Details tab.
                return; } //return; enables user to edit the form again*/

            //If any text field that can't be null is empty, display error message.
            if (cbbPaymentTerms.Text == "Select") //"Select" is the default option
            { MessageBox.Show("Please select an option for Payment Terms.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabRFQForm.SelectedTab = tabRFQForm.TabPages["tabRequestDetails"]; //Directs user to the Request Details tab.
                return; } 

            if (cbbDeliveryTerms.Text == "Select")
            { MessageBox.Show("Please select an option for Delivery Terms.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabRFQForm.SelectedTab = tabRFQForm.TabPages["tabRequestDetails"]; //Directs user to the Request Details tab.
                return; } 

            if (cbbInFavorOf.Text == "Select")
            { MessageBox.Show("Please select an option for In Favor Of.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabRFQForm.SelectedTab = tabRFQForm.TabPages["tabRequestDetails"]; //Directs user to the Request Details tab.
                return; } 

            //If no Customer was selected
            if (cbbCustomerName.Text == "Select Customer")
            { MessageBox.Show("Please select a Customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabRFQForm.SelectedTab = tabRFQForm.TabPages["tabRequestDetails"]; //Directs user to the Request Details tab.
                return; }

            //If no Supplier was selected
            if (cbbSupplierName.Text == "Select Supplier")
            { MessageBox.Show("Please select a Supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabRFQForm.SelectedTab = tabRFQForm.TabPages["tabRequestDetails"]; //Directs user to the Request Details tab.
                return; }

            //If there are no items added to the RFQ
            if (dgvRFQItems.Rows.Count == 0)
            { MessageBox.Show("Please include item(s) in the Request for Price Quotation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabRFQForm.SelectedTab = tabRFQForm.TabPages["tabItemDetails"]; //Directs user to the Item Details tab.
                return; }

            //--------------------------------------
            // btnSave_Click: CONFIRMATION MESSAGE |
            //--------------------------------------
            DialogResult result = MessageBox.Show("Are you ABSOLUTELY SURE of ALL the details in the Request for Price Quotation? Once the form has been created, it CANNOT be edited anymore.",
            "Confirm Creation of RFQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            { //---CLOSING THE FORM
                cancel = false; //Will be used by RFQ Main Screen
                Close(); //Only RFQ_MainScreen.cs remains
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            Close();
        }

        private void dgvItemSelection_CellClick(object sender, DataGridViewCellEventArgs e)
        { /*When you click on a row of the Item Selection DGV, its item details
            should appear under the Item Selected group box.*/
            DataGridViewRow selectedRow = dgvItemSelection.SelectedRows[0]; //Store row number of selected row
            txtItemName.Text = selectedRow.Cells["ItemName"].Value.ToString(); //Set the content of Item Name textbox to the selected row's item name
            nupItemQuantity.Text = "1";
        }

        private void btnAddtoRequest_Click(object sender, EventArgs e)
        {   //TO-DO: Disallow adding of the same item.
            //Adding the item to the "Items in RFQ" DGV
            //Searching for the Item's other details (to be added in dgvRFQItems)
            for (int i = 0; i < itemList.Count; i++)
            {
                Item item = (Item)itemList[i]; //Casting. So can retrieve attribute values from this specific Item.
                DataGridViewRow selectedRow = dgvItemSelection.SelectedRows[0]; //Store row number of selected row

                if (item.PartNumber == selectedRow.Cells["PartNo"].Value.ToString()) //If Part Number matches
                {
                    rfqItemList.Add(new Item(item.PartNumber,
                                             item.ItemName,
                                             item.SupplierUnitPrice,
                                             item.Markup,
                                             item.ReicUnitPrice,
                                             item.Moq,
                                             item.Uom,
                                             item.FromDateNoTime,
                                             item.ToDateNoTime,
                                             item.ItemDescription,
                                             item.SupplierName,
                                             item.SupplierPerson,
                                             item.SupplierNumber,
                                             item.SupplierEmail,
                                             item.SupplierAddress));

                    dgvRFQItems.Rows.Add(item.ItemName, item.ItemDescription, nupItemQuantity.Text, item.Uom);
                    break; //Once item is found, end the search process.
                } 
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        { 
            if (dgvRFQItems.Rows.Count == 0)
            {
                MessageBox.Show("There are no items to remove from the Request for Price Quotation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //Enables user to act on the form again
            }

            //Remove the selected item from the RFQ Items List
            rfqItemList.RemoveAt(dgvRFQItems.SelectedRows[0].Index); //Not tested for possible null-references or index out-of-bounds

            //Remove the selected item from the RFQ
            dgvRFQItems.Rows.RemoveAt(dgvRFQItems.SelectedRows[0].Index);
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            if (dgvRFQItems.Rows.Count == 0)
            { MessageBox.Show("There are no items to remove from the Request for Price Quotation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            rfqItemList.Clear(); //Empty the ArrayList of items in the RFQ
            dgvRFQItems.Rows.Clear(); //Empty the DGV of items in the RFQ
        }

        //------------------------
        //  OTHER FORM ELEMENTS  |
        //------------------------
        private void cbbPaymentTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If the user selects "Credit" under the Payment Terms dropdown, Account Number textbox can be edited.
            if (cbbPaymentTerms.Text == "Credit")
            { txtAccountNumber.Enabled = true; }
            else
            { txtAccountNumber.Enabled = false;
              txtAccountNumber.Text = null; }
        }

        private void cbbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        { //Once a Supplier has been selected, the other Supplier-related fields should be auto-completed
            if (cbbSupplierName.Text == "Select Supplier")
            {
                SupplierPerson = null;
                SupplierNumber = null;
                SupplierEmail = null;
                SupplierAddress = null;
                return;
            }

            //Searching for the Supplier's other details
            for (int i = 0; i < supplierList.Count; i++)
            {
                Supplier s = (Supplier)supplierList[i]; //Casting. So can retrieve attribute values from this specific Supplier.
                if (s.SupplierName == cbbSupplierName.Text)
                {
                    SupplierPerson = s.SupplierPerson;
                    SupplierNumber = s.SupplierNumber;
                    SupplierEmail = s.SupplierEmail;
                    SupplierAddress = s.SupplierAddress;
                    break; //Once the other fields are auto-complated, end the search process.
                } 
            }
        }

        private void btnRemoveItem_MouseEnter(object sender, EventArgs e)
        { btnRemoveItem.BackgroundImage = Properties.Resources.ButtonRemoveItemsHover; }

        private void btnRemoveItem_MouseLeave(object sender, EventArgs e)
        { btnRemoveItem.BackgroundImage = Properties.Resources.ButtonRemoveItems; }

        private void btnClearItems_MouseEnter(object sender, EventArgs e)
        { btnClearItems.BackgroundImage = Properties.Resources.ButtonClearAllItemsHover; }

        private void btnClearItems_MouseLeave(object sender, EventArgs e)
        { btnClearItems.BackgroundImage = Properties.Resources.ButtonClearAllItems; }
    }
}
