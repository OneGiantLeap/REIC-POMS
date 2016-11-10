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
    public partial class SIDR_CreateForm : Form
    {
        //Some code from Ken's code here

        private ArrayList customerList;
        private ArrayList itemList;
        private ArrayList SIDROrderlineList;
        private int customerIDFK;

        public SIDR_CreateForm()
        {
            InitializeComponent();
            // NO MYSQL YET 
            //sql = new MySQLDatabaseDriver();

            itemList = new ArrayList();
            //sql.SelectAllItems(itemList);
            for (int i = 0; i < itemList.Count; i++)
            {
                Item itemToAdd = (Item)itemList[i];
                dgvItemSelection.Rows.Add(itemToAdd.PartNumber,
                                          itemToAdd.ItemName,
                                          itemToAdd.ItemDescription,
                                          itemToAdd.Uom,
                                          itemToAdd.ReicUnitPrice.ToString("0.00"));

            }
            cbbDeliveryTerms.SelectedIndex = 0;
            customerList = new ArrayList();

            SIDROrderlineList = new ArrayList();
        }



        private void SIDR_CreateForm_Load(object sender, EventArgs e)
        {


        }

        //---------------------
        //  SPECIAL VARIABLES |
        //---------------------
        //Insert private bool cancel here
        public bool cancel;

        //-------------------
        //  GETTERS-SETTERS |
        //-------------------
        public string CustomerName
        {
            set { cbbCustomerName.Text = value; }
            get { return cbbCustomerName.Text; }
        }

        public string CustomerPerson
        {
            set { txtCustomerPerson.Text = value; }
            get { return txtCustomerPerson.Text; }
        }

        public string CustomerNumber
        {
            set { txtCustomerNumber.Text = value; }
            get { return txtCustomerNumber.Text; }
        }

        public string CustomerEmail
        {
            set { txtCustomerEmail.Text = value; }
            get { return txtCustomerEmail.Text; }
        }

        public string CustomerAddress
        {
            set { txtCustomerAddress.Text = value; }
            get { return txtCustomerAddress.Text; }
        }

        public string TinNumber1
        {
            set { txtTinNumber1.Text = value; }
            get { return txtTinNumber1.Text; }
        }
        public string TinNumber2
        {
            set { txtTinNumber2.Text = value; }
            get { return txtTinNumber2.Text; }
        }
        public string TinNumber3
        {
            set { txtTinNumber3.Text = value; }
            get { return txtTinNumber3.Text; }
        }
        public string TinNumber4
        {
            set { txtTinNumber4.Text = value; }
            get { return txtTinNumber4.Text; }
        }

        public DateTime SIDRDate
        {
            get { return dtpDate.Value; }
        }

        public string SONumber
        {
            set { txtSONumber.Text = value; }
            get { return txtSONumber.Text; }
        }

        public string DeliveryTerms
        {
            set { cbbDeliveryTerms.Text = value; }
            get { return cbbDeliveryTerms.Text; }
        }

        public string PONumber
        {
            set { txtPONumber.Text = value; }
            get { return txtPONumber.Text; }

        }

        public string SINumber
        {
            set { txtSINumber.Text = value; }
            get { return txtSINumber.Text; }
        }

        public string DRNumber
        {
            set { txtDRNumber.Text = value; }
            get { return txtDRNumber.Text; }
        }

        public string SearchFor
        {
            set { txtSearchFor.Text = value; }
            get { return txtSearchFor.Text; }
        }

        public string FilterBy
        {
            set { cbbFilterBy.Text = value; }
            get { return cbbFilterBy.Text; }
        }

        public string ItemProductName
        {
            set { txtItemName.Text = value; }
            get { return txtItemName.Text; }
        }

        public string ItemQuantity
        {
            set { nupItemQuantity.Text = value; }
            get { return nupItemQuantity.Text; }
        }

        public string ItemUnitPrice
        {
            set { txtUnitPrice.Text = value; }
            get { return txtUnitPrice.Text; }
        }

        public string ItemTotal
        {
            set { txtItemTotal.Text = value; }
            get { return txtItemTotal.Text; }
        }

        public string TotalSales
        {
            set { txtTotalSales.Text = value; }
            get { return txtTotalSales.Text; }
        }

        public string LessVAT
        {
            set { txtLessVAT.Text = value; }
            get { return txtLessVAT.Text; }
        }

        public string Total
        {
            set { txtTotal.Text = value; }
            get { return txtTotal.Text; }
        }

        public string TotalAmountDue
        {
            set { txtTotalAmountDue.Text = value; }
            get { return txtTotalAmountDue.Text; }
        }

        public string VATSale
        {
            set { txtVATSale.Text = value; }
            get { return txtVATSale.Text; }
        }

        public string VATExemptSale
        {
            set { txtVATExemptSale.Text = value; }
            get { return txtVATExemptSale.Text; }
        }

        public string VATZeroRatedSale
        {
            set { txtVATZeroRatedSale.Text = value; }
            get { return txtVATZeroRatedSale.Text; }
        }

        public string AddPercentSale
        {
            set { txtAddPercentSale.Text = value; }
            get { return txtAddPercentSale.Text; }
        }
        public bool Cancel
        {
            get { return cancel; }
        }


        //-------------------
        //  BUTTON METHODS  |
        //-------------------

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbbDeliveryTerms.Text == "") //"I'm not sure if "Select" is the default option (or if there's a default function)
            {
                MessageBox.Show("Please select an option for Payment Terms.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabSIDRForm.SelectedTab = tabSIDRForm.TabPages["TabQuotationDetails"]; //Directs user to SIDR Details Tab
                return;
            }

            if (cbbCustomerName.Text == "") //"I'm not sure if "Select" is the default option (or if there's a default function)
            {
                MessageBox.Show("Please select a Customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabSIDRForm.SelectedTab = tabSIDRForm.TabPages["TabQuotationDetails"]; //Directs user to the SIDR Tab
                return;
            }

            if (txtSONumber.Text == "") //--->REMOVE? SO NO IS GENERATED BY US
            {
                MessageBox.Show("Please input the Sales Order No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabSIDRForm.SelectedTab = tabSIDRForm.TabPages["TabQuotationDetails"]; //Directs user to the SIDR Tab
                return;
            }

            if (txtPONumber.Text == "")
            {
                MessageBox.Show("Please input the Purchase Order No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabSIDRForm.SelectedTab = tabSIDRForm.TabPages["TabQuotationDetails"]; //Directs user to the SIDR Tab
                return;
            }

            if (txtSINumber.Text == "")
            {
                MessageBox.Show("Please input the Sales Invoice No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabSIDRForm.SelectedTab = tabSIDRForm.TabPages["TabQuotationDetails"]; //Directs user to the SIDR Tab
                return;
            }

            if (txtDRNumber.Text == "")
            {
                MessageBox.Show("Please input the Delivery Receipt No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabSIDRForm.SelectedTab = tabSIDRForm.TabPages["TabQuotationDetails"]; //Directs user to the SIDR Tab
                return;
            }

            //If there are no items added to the RFQ
            if (dgvSIDRItems.Rows.Count == 0)
            {
                MessageBox.Show("Please include item(s) in the Sales Invoice and Delivery Receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabSIDRForm.SelectedTab = tabSIDRForm.TabPages["tabItemDetails"]; //Directs user to the Item Details tab.
                return;
            }

            else
            {
                //add to mysql database
                for (int i = 0; i < dgvSIDRItems.RowCount; i++)
                {
                    DataGridViewRow row = dgvSIDRItems.Rows[i]; //Store row number
                    SIDROrderlineList.Add(new SIDR_OrderLine(int.Parse(txtSONumber.Text),
                                                           row.Cells["SIDRItemPartNo"].Value.ToString(),
                                                           double.Parse(row.Cells["UnitREICPrice"].Value.ToString()),
                                                           int.Parse(row.Cells["Qty"].Value.ToString()),
                                                           double.Parse(row.Cells["TotalItem"].Value.ToString())));
                }

                cancel = false;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAddtoRequest_Click(object sender, EventArgs e)
        {
            //STEP 1: Validate input in numericUpDown
            int validatedItemQuantity;
            bool isPriceInteger = int.TryParse(nupItemQuantity.Value.ToString(), out validatedItemQuantity);
            if (isPriceInteger == false)
            {
                MessageBox.Show("Quantity of the item to be added must be an integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtItemName.TextLength == 0) //What is this? - Gayle
            {
                MessageBox.Show("There is nothing to add in the Sales Invoice and Delivery Receipt.", "Nothing to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow selectedRow = dgvItemSelection.SelectedRows[0];
            for (int i = 0; i < dgvSIDRItems.RowCount; i++)
            {
                if (selectedRow.Cells["PartNo"].Value == dgvSIDRItems.Rows[i].Cells["PQItemPartNo"].Value)
                {
                    MessageBox.Show("That item has already been added in the Sales Invoice & Delivery Receipt. If you wish to change the item quantity, please remove that item and add it again.", "Item Already in PQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            dgvSIDRItems.Rows.Add(selectedRow.Cells["ItemName"].Value,
                   selectedRow.Cells["PartNo"].Value,
                   selectedRow.Cells["Description"].Value,
                   selectedRow.Cells["UOM"].Value,
                   selectedRow.Cells["UnitPrice"].Value,
                   //nupItemQuantity.Value, 
                   //commented because of an error: 'DomainUpDown' does not contain a definition 'Value' and no extension method 'Value' accepting a first argument of time 'DomainUpDown' could be found (Are you missing a using directive or an assembly reference?)
                   ItemTotal);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvSIDRItems.Rows.Count == 0) //Empty DGV
            {
                MessageBox.Show("There are no items to remove from the Sales Invoice & Delivery Receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //Enables user to interact with the form again
            }
            else
            {
                dgvSIDRItems.Rows.RemoveAt(dgvSIDRItems.CurrentRow.Index);
            }
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            if (dgvSIDRItems.Rows.Count == 0)
            { MessageBox.Show("There are no items to remove from the Sales Invoice & Delivery Receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                dgvSIDRItems.Rows.Clear();
            }
        }

        //-----------------------------------------
        //  OTHER FORM ELEMENTS: SIDR DETAILS TAB |
        //-----------------------------------------
        //---TIN NUMBERS
        //If User has input 3 characters in a TIN textbox part, text cursor jumps to the next textbox part.
        private void txtTinNumber1_TextChanged(object sender, EventArgs e)
        {
            if (txtTinNumber1.TextLength == 3)
            {
                txtTinNumber2.Select();
                txtTinNumber2.Focus();
            }
        }

        private void txtTinNumber2_TextChanged(object sender, EventArgs e)
        {
            if (txtTinNumber2.TextLength == 3)
            {
                txtTinNumber3.Select();
                txtTinNumber3.Focus();
            }
        }

        private void txtTinNumber3_TextChanged(object sender, EventArgs e)
        {
            if (txtTinNumber3.TextLength == 3)
            {
                txtTinNumber4.Select();
                txtTinNumber4.Focus();
            }
        }

        //------------------------------------------
        //  OTHER FORM ELEMENTS: ITEM DETAILS TAB  |
        //------------------------------------------
        private void dgvItemSelection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvItemSelection.SelectedRows[0]; //Store row number of selected row
            txtItemName.Text = selectedRow.Cells["ItemName"].Value.ToString(); //Set the content of Item Name textbox to the selected row's item name
            nupItemQuantity.Text = "1";
            string partNumber = selectedRow.Cells["PartNo"].Value.ToString();
            //txtUnitPrice.Text = (sql.SelectItemPrice(partNumber)).ToString();
        }

        private void nupItemQuantity_ValueChanged(object sender, EventArgs e)
        {
            CalculateAndUpdateUI();
        }

        private void CalculateAndUpdateUI()
        {
            double totalPrice, unitPrice;
            int quantity;
            totalPrice = 0;

            double.TryParse(ItemUnitPrice, out unitPrice);
            double.TryParse(ItemTotal, out totalPrice);
            int.TryParse(ItemQuantity, out quantity);

            totalPrice = quantity * unitPrice;

            txtItemTotal.Text = totalPrice.ToString("0.00");
        }

        private void CalculateTotal()
        {
            double itemTotal = 0;
            double itemPrice;

            for (int i = 0; i < dgvSIDRItems.Rows.Count; i++)
            {
                {
                    itemPrice = double.Parse(dgvSIDRItems.Rows[i].Cells["totalItem"].Value.ToString());
                }
                itemTotal += itemPrice;
            }

            txtTotal.Text = itemTotal.ToString("0.00");
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateAndUpdateUI();
        }

        private void txtItemTotal_TextChanged(object sender, EventArgs e)
        {
            CalculateAndUpdateUI();
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void dgvSIDRItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateTotal();
        }

        private void dgvSIDRItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateTotal();
        }

        //---------------
        //  ANIMATIONS  |
        //---------------
        private void txtSearchFor_GotFocus(object sender, EventArgs e)
        { //When Search box is clicked, content becomes blank.
            if (txtSearchFor.Text == "Search for...")
            { txtSearchFor.Clear(); }
        }

        private void txtSearchFor_LostFocus(object sender, EventArgs e)
        { //User clicks on textbox. Then when he clicks elsewhere, content returns to default text.
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
