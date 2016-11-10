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
        //ATTRIBUTES
        private MySQLDatabaseDriver sql;
        private ArrayList customerDropdownList; //All Customer NAMES
        private ArrayList supplierList; //All Suppliers
        private ArrayList supplierDropdownList; //All Supplier NAMES
        private ArrayList supplierItemList; //All Items offered by the selected Supplier
        private ArrayList rfqOrderLineList; //Items in the RFQ
        private int customerIDFK; //RFQ Foreign Key 1
        private int supplierIDFK; //RFQ Foreign Key 2

        //CONSTRUCTOR
        public RFQ_CreateForm()
        {
            InitializeComponent();
            sql = new MySQLDatabaseDriver();

            //Instantiate ArrayLists and populate them
            customerDropdownList = new ArrayList();
            sql.SelectAllCustomerNames(customerDropdownList);
            customerDropdownList.Sort(); //Sort list alphabetically
            customerDropdownList.Insert(0, "Select Customer");
            cbbCustomerName.DataSource = customerDropdownList; //Populate the dropdown

            supplierItemList = new ArrayList();
            supplierList = new ArrayList(); //Need all the Supplier Details, since there's Supplier auto-complete
            sql.SelectAllSuppliers(supplierList);

            supplierDropdownList = new ArrayList();
            sql.SelectAllSupplierNames(supplierDropdownList);
            supplierDropdownList.Sort(); //Sort list alphabetically
            supplierDropdownList.Insert(0, "Select Supplier");
            cbbSupplierName.DataSource = supplierDropdownList; //Populate the dropdown

            //Set default Combo Box values
            cbbFilterBy.SelectedIndex = 0; //"Filter by..."
            cbbPaymentTerms.SelectedIndex = 0; //"Select"
            cbbDeliveryTerms.SelectedIndex = 0; // "Select"
            //txtItemName.Text = dgvItemSelection.SelectedRows[0].Cells["ItemName"].Value.ToString(); --> Moved to cbbSupplierName_SelectedIndexChanged

            rfqOrderLineList = new ArrayList();

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
        public string RFQNo
        {
            set { txtRFQNo.Text = value; } //Setter added, since it's auto-generated
            get { return txtRFQNo.Text; }
        }

        public string RequestDate
        {
            set { dtpDateOfRequest.Text = value; }
            get { return dtpDateOfRequest.Text; }
        }

        public string PaymentTerms
        {
            get { return cbbPaymentTerms.Text; }
        }

        /*public string AccountNumber -> No longer needed
        {
            get { return txtAccountNumber.Text; }
        }*/

        public string DeliveryTerms
        {
            get { return cbbDeliveryTerms.Text; }
        }

        /*
        public string InFavorOf -> No longer needed
        {
            get { return cbbInFavorOf.Text; }
        }*/

        public int CustomerIDFK
        {
            set { customerIDFK = value; }
            get { return customerIDFK; }
        }

        public string CustomerName
        {
            get { return cbbCustomerName.Text; } //For SelectCustomerID SQL function
        }

        public int SupplierIDFK
        {
            set { supplierIDFK = value; }
            get { return supplierIDFK; }
        }

        public string SupplierName
        {
            get { return cbbSupplierName.Text; } //For SelectSupplierID SQL function
        }

        public string SupplierPerson
        {
            set { txtSupplierPerson.Text = value; } //Setter placed for the auto-complete feature
            get { return txtSupplierPerson.Text; } //No longer needed
        }

        public string SupplierNumber
        {
            set { txtSupplierNumber.Text = value; } //Setter placed for the auto-complete feature
            get { return txtSupplierNumber.Text; } //No longer needed
        }

        public string SupplierEmail
        {
            set { txtSupplierEmail.Text = value; } //Setter placed for the auto-complete feature
            get { return txtSupplierEmail.Text; } //No longer needed
        }

        public string SupplierAddress
        {
            set { txtSupplierAddress.Text = value; } //Setter placed for the auto-complete feature
            get { return txtSupplierAddress.Text; } //No longer needed
        }

        public ArrayList RFQOrderLineList
        {
            get { return rfqOrderLineList; }
        }

        public bool Cancel
        { 
            get { return cancel; } //Will be used by RFQ_MainScreen.cs
        }

        //-------------------
        //  BUTTON METHODS  |
        //-------------------
        /* FOR: btnSave_Click,
                btnCancel_Click,
                btnSearch_Click,
                btnClearSearch_Click,
                btnAddToRequest_Click,
                btnRemoveItem_Click,
                btnClearItems_Click     */

        private void btnSave_Click(object sender, EventArgs e)
        {   //-------------------------------------------------------
            // btnSave_Click: ERROR MESSAGES FOR INCOMPLETE FIELDS  |
            //-------------------------------------------------------
            //If any text field that can't be null is empty, display error message.
            if (cbbPaymentTerms.Text == "Select")
            {
                MessageBox.Show("Please select an option for Payment Terms.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabRFQForm.SelectedTab = tabRFQForm.TabPages["tabRequestDetails"]; //Directs user to the Request Details tab.
                return;
            }

            if (cbbDeliveryTerms.Text == "Select")
            {
                MessageBox.Show("Please select an option for Delivery Terms.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabRFQForm.SelectedTab = tabRFQForm.TabPages["tabRequestDetails"]; //Directs user to the Request Details tab.
                return;
            }

            //If no Customer was selected
            if (cbbCustomerName.Text == "Select Customer")
            {
                MessageBox.Show("Please select a Customer.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabRFQForm.SelectedTab = tabRFQForm.TabPages["tabRequestDetails"]; //Directs user to the Request Details tab.
                return;
            }

            //If no Supplier was selected
            if (cbbSupplierName.Text == "Select Supplier")
            {
                MessageBox.Show("Please select a Supplier.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabRFQForm.SelectedTab = tabRFQForm.TabPages["tabRequestDetails"]; //Directs user to the Request Details tab.
                return;
            }

            //If there are no items added to the RFQ
            if (dgvRFQItems.Rows.Count == 0)
            {
                MessageBox.Show("Please include item(s) in the Request for Price Quotation.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabRFQForm.SelectedTab = tabRFQForm.TabPages["tabItemDetails"]; //Directs user to the Item Details tab.
                return;
            }

            //--------------------------------------
            // btnSave_Click: CONFIRMATION MESSAGE |
            //--------------------------------------
            DialogResult result = MessageBox.Show("Are you ABSOLUTELY SURE of ALL the details in the Request for Price Quotation? Once the form has been created, it CANNOT be edited anymore.",
            "Confirm Creation of RFQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //---SET CUSTOMER ID Foreign Key
                CustomerIDFK = sql.SelectCustomerID(CustomerName);

                //---SET SUPPLIER ID Foreign Key
                SupplierIDFK = sql.SelectSupplierID(SupplierName);

                //---ADD all items in RFQ to the rfqOrderLineList. (Parameters based on Data Dictionary)
                for (int i = 0; i < dgvRFQItems.RowCount; i++)
                {
                    DataGridViewRow row = dgvRFQItems.Rows[i]; //Store row number
                    rfqOrderLineList.Add(new RFQ_OrderLine(txtRFQNo.Text,
                                                           row.Cells["RFQItemPartNo"].Value.ToString(),
                                                           int.Parse(row.Cells["Qty"].Value.ToString())));
                }

                //---CLOSING THE FORM
                cancel = false; //Will be used by RFQ Main Screen
                Close(); //Only RFQ_MainScreen.cs remains
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            Close();
        }

        //-----------------------------
        //  ITEM DETAILS TAB METHODS  |
        //-----------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((txtSearchFor.Text == "Search for...") || (txtSearchFor.Text == ""))
            {
                MessageBox.Show("Please input something to search for.", "Nothing to Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbFilterBy.Text == "Filter by...")
            {
                MessageBox.Show("Please select a filter option.", "No Filter Option", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Valid search input
            if (dgvItemSelection.Rows.Count == 0) //If Supplier selected doesn't offer anything
            {
                MessageBox.Show("There is nothing to search for.", "No Items to Search For", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Valid search input, and there are items in dgvItemSelection
            SupplierIDFK = sql.SelectSupplierID(SupplierName); //Extract Supplier ID; use it next query
            dgvItemSelection.Rows.Clear();
            sql.SearchSupplierItems(dgvItemSelection, cbbFilterBy.Text, SupplierIDFK, txtSearchFor.Text);
            if (dgvItemSelection.Rows.Count == 0) //Empty search results
            {
                MessageBox.Show("No item(s) was found.", "Empty Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearchFor.Text = "Search for...";
            dgvItemSelection.Rows.Clear(); //Erase search results
            SupplierIDFK = sql.SelectSupplierID(SupplierName);
            sql.SelectSupplierItems(dgvItemSelection, SupplierIDFK);
            if (dgvItemSelection.RowCount != 0) //If Supplier offers at least 1 item, set the Item Name text to the first row's item name
            {
                txtItemName.Text = dgvItemSelection.SelectedRows[0].Cells["ItemName"].Value.ToString();
                nupItemQuantity.Value = 1;
            }
        }

        private void dgvItemSelection_CellClick(object sender, DataGridViewCellEventArgs e)
        { /*When you click on a row of the Item Selection DGV, its item details
            should appear under the Item Selected group box.*/
            DataGridViewRow selectedRow = dgvItemSelection.SelectedRows[0]; //Store row number of selected row
            txtItemName.Text = selectedRow.Cells["ItemName"].Value.ToString(); //Set the content of Item Name textbox to the selected row's item name
            nupItemQuantity.Text = "1";
        }

        private void btnAddtoRequest_Click(object sender, EventArgs e)
        { //---GOAL: Add the selected item to the "Items in RFQ" DGV (dgvRFQItems)
            //STEP 1: Validate input in numericUpDown
            int validatedItemQuantity;
            bool isPriceInteger = int.TryParse(nupItemQuantity.Value.ToString(), out validatedItemQuantity);
            if (isPriceInteger == false)
            {
                MessageBox.Show("Quantity of the item to be added must be an integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //STEP 2: Validation - CHECK if the item to be added in the RFQ has already been added.
            DataGridViewRow selectedRow = dgvItemSelection.SelectedRows[0]; //Store row number of selected row
            for (int i = 0; i < dgvRFQItems.RowCount; i++) //Loop through dgvRFQItems
            {
                //STEP 1.1 - If yes, error message
                //How it checks: Compares the Part Numbers of the selected item in dgvItemSelection and the rows of dgvRFQItems
                //This is why there's a HIDDEN Part Number column in the dgvRFQItems for searching and database purposes.
                if (selectedRow.Cells["PartNo"].Value == dgvRFQItems.Rows[i].Cells["RFQItemPartNo"].Value)
                {
                    MessageBox.Show("That item has already been added in the Request for Price Quotation. If you wish to change the item quantity, please remove that item and add it again.", "Item Already in RFQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //Enables User to interact with the form
                }
            }

            //STEP 3: Add selected item to dgvRFQItems
            dgvRFQItems.Rows.Add(selectedRow.Cells["PartNo"].Value, //Hidden, so it won't display in the DGV. Why it exists? It's for Step 1.
                                 selectedRow.Cells["ItemName"].Value,
                                 selectedRow.Cells["Description"].Value,
                                 nupItemQuantity.Value,
                                 selectedRow.Cells["UOM"].Value);

            /*CODING NOTES
            1. Adding the items to the rfqOrderLineList happens at btnSave_Click, not here.
                - Why? If it's added right away and the User later removes any item, hassle additional code needed
                  since you have to locate the item inside the rfqOrderLineList and remove it at the correct index.
            2. Transferring of rfqOrderLineList contents to the database happens later in the Main Screen. */
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvRFQItems.Rows.Count == 0) //Empty DGV
            {
                MessageBox.Show("There are no items to remove from the Request for Price Quotation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //Enables user to interact with the form again
            }
            dgvRFQItems.Rows.RemoveAt(dgvRFQItems.CurrentRow.Index);
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            if (dgvRFQItems.Rows.Count == 0)
            { MessageBox.Show("There are no items to remove from the Request for Price Quotation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            rfqOrderLineList.Clear();
            dgvRFQItems.Rows.Clear();
        }

        //------------------------
        //  OTHER FORM ELEMENTS  |
        //------------------------
        private void dtpDateOfRequest_ValueChanged(object sender, EventArgs e)
        { //If the User wants to input an RFQ with date of year/month != current year/month
            string year = dtpDateOfRequest.Value.ToString("yy");
            string month = dtpDateOfRequest.Value.ToString("MM");
            int rfqCount = sql.GetRowCount("rfq_t", year, month);
            string generatedRFQNo = year + month + "-" + (rfqCount + 1).ToString("D3");
            RFQNo = generatedRFQNo;
        }

        private void cbbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        { //Once a Supplier has been selected, the other Supplier-related fields should be auto-completed. dgvItemSelection should change.
            dgvItemSelection.Rows.Clear(); //Empty DGV contents (to be refilled upon Supplier selection)
            if (dgvRFQItems.RowCount != 0) //Do we need this messagebox?
            {
                MessageBox.Show("Note: Items not provided by the chosen Supplier are excluded from the Request for Price Quotation.", "Important!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvRFQItems.Rows.Clear();
            }
            
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

                    //Populating the dgvItemSelection with what this Supplier offers
                    sql.SelectSupplierItems(dgvItemSelection, s.SupplierID);
                    if (dgvItemSelection.RowCount != 0) //If Supplier offers at least 1 item, set the Item Name text to the first row's item name
                    {
                        txtItemName.Text = dgvItemSelection.SelectedRows[0].Cells["ItemName"].Value.ToString();
                        nupItemQuantity.Value = 1;
                    }
                    break; //Once the other fields are auto-completed, end the search process.
                }
            }
        }

        private void txtSearchFor_GotFocus(object sender, EventArgs e)
        { //When Search box is clicked, content becomes blank.
            if (txtSearchFor.Text == "Search for...")
            { txtSearchFor.Clear(); }
        }

        private void txtSearchFor_LostFocus(object sender, EventArgs e)
        { //User clicks on textbox. Then when he clicks elsewhre, content returns to default text.
            if (txtSearchFor.Text == "")
            { txtSearchFor.Text = "Search for..."; }
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        { btnSearch.BackgroundImage = Properties.Resources.ButtonSearchHover; }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        { btnSearch.BackgroundImage = Properties.Resources.ButtonSearch; }

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
