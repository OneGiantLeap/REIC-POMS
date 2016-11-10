using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace REIC_POMS
{
    public partial class PO_CreateForm : Form
    {
        private MySQLDatabaseDriver sql;
        private ArrayList itemList;
        private ArrayList poList;
        private ArrayList pqOrderLineList;

        private int customerIDFK;



        public PO_CreateForm()
        {
            InitializeComponent();
            sql = new MySQLDatabaseDriver();


            itemList = new ArrayList();
            poList = new ArrayList();
            pqOrderLineList = new ArrayList();
            sql.SelectAllItems(itemList);
            for (int i = 0; i < itemList.Count; i++)
            {
                Item itemToAdd = (Item)itemList[i];
                dgvItemSelection.Rows.Add(itemToAdd.PartNumber,
                                          itemToAdd.ItemName,
                                          itemToAdd.ItemDescription,
                                          itemToAdd.Uom,
                                          itemToAdd.ReicUnitPrice.ToString("0.00"));
            }
          //  cbbInFavorOf.SelectedIndex = 0;
          //  cbbPaymentTerms.SelectedIndex = 0;
         //   cbbDeliveryTerms.SelectedIndex = 0;
        }

        public int CustomerIDFK
        {
            set { customerIDFK = value; }
            get { return customerIDFK; }
        }



        public string PONo
        {
            set { txtPONumber.Text = value; }
            get { return txtPONumber.Text; }
        }

        public string PQNo
        {
            set { txtPQNumber.Text = value; }
            get { return txtPQNumber.Text; }
        }

        public string SupplierID
        {
            set { txtSupplierID.Text = value; }
            get { return txtSupplierID.Text; }
        }

        public string SupplierName
        {
            set { cbbSupplierName.Text = value; }
            get { return cbbSupplierName.Text; }
        }

        public string REICPrice
        {
            set { txtUnitPrice.Text = value; }
            get { return txtUnitPrice.Text; }
        }

        public string ItemTotal
        {
            set { txtItemTotal.Text = value; }
            get { return txtItemTotal.Text; }
        }

        public string SupplierPerson
        {
            set { txtContactPerson.Text = value; }
            get { return txtContactPerson.Text; }
        }

        public string SupplierNumber
        {
            set { txtContactNumber.Text = value; }
            get { return txtContactNumber.Text; }
        }

        public string SupplierEmail
        {
            set { txtSupplierEmail.Text = value; }
            get { return txtSupplierEmail.Text; }
        }

        public string SupplierAddress
        {
            set { txtCompanyAddress.Text = value; }
            get { return txtCompanyAddress.Text; }
        }

        public string CustomerName
        {
            set { cbbCustomerName.Text = value; }
            get { return cbbCustomerName.Text; }
        }

        public DateTime OrderDate
        {
            get { return dtpOrderDate.Value; }
        }

        public DateTime RequiredDate
        {
            get { return dtpRequiredDate.Value; }
        }

        public string OrderDesc
        {
            set { txtOrderDesc.Text = value; }
            get { return txtOrderDesc.Text; }
        }

        public string PaymentTerms
        {
            set { cbbPaymentTerms.Text = value; }
            get { return cbbPaymentTerms.Text; }
        }

        public string DeliveryTerms
        {
            set { cbbDeliveryTerms.Text = value; }
            get { return cbbDeliveryTerms.Text; }
        }

        public string NetSubTotal
        {
            set { txtItemSubtotal.Text = value; }
            get { return txtItemSubtotal.Text; }
        }

        public string DeliveryCosts
        {
            set { txtDeliveryCosts.Text = value; }
            get { return txtDeliveryCosts.Text; }
        }

        public ArrayList POOrderLineList
        {
            set { pqOrderLineList = value; }
            get { return pqOrderLineList; }
        }

        public string OrderTotal
        {
            set { txtOrderTotal.Text = value; }
            get { return txtOrderTotal.Text; }
        }



        public bool cancel;

        public bool Cancel
        {
            get { return cancel; }
        }

        public string Quantity { get { return nupItemQuantity.Text; } }


        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        
        private void cbbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbPaymentTerms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

   /*     private void CreatePQ_Load(object sender, EventArgs e)
        {
            sql.SelectSpecificPQOrderLine(SupplierID, dgvPOItems);
        }
        */
        private void PO_CreateForm_Load(object sender, EventArgs e)
        {
            sql.SelectPOItems(SupplierID, dgvPOItems);
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            if (cbbPaymentTerms.Text == "Select") //"Select" is the default option
            {
                MessageBox.Show("Please select an option for Payment Terms.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabPQForm.SelectedTab = tabPQForm.TabPages["TabQuotationDetails"]; //Directs user to the Request Details tab.
                return;
            }

            if (cbbDeliveryTerms.Text == "Select")
            {
                MessageBox.Show("Please select an option for Delivery Terms.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabPQForm.SelectedTab = tabPQForm.TabPages["TabQuotationDetails"]; //Directs user to the Request Details tab.
                return;
            }

         
            if (cbbInFavorOf.Text == "Select")
            {
                MessageBox.Show("Please select an option for In Favor Of.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabPQForm.SelectedTab = tabPQForm.TabPages["TabQuotationDetails"]; //Directs user to the Request Details tab.
                return;
            }

            //If there are no items added to the RFQ
            if (dgvPOItems.Rows.Count == 0)
            {
                MessageBox.Show("Please include item(s) in the Price Quotation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabPQForm.SelectedTab = tabPQForm.TabPages["tabItemDetails"]; //Directs user to the Item Details tab.
                return;
            }

            else
            {
                CustomerIDFK = sql.SelectCustomerID(CustomerName);
                for (int i = 0; i < dgvPOItems.RowCount; i++)
                {
                    DataGridViewRow row = dgvPOItems.Rows[i]; //Store row number
                    poList.Add(new PO_OrderLine(txtPQNumber.Text,
                                                           row.Cells["POItemPartNo"].Value.ToString(),
                                                           double.Parse(row.Cells["SupplierREICPrice"].Value.ToString()),
                                                           int.Parse(row.Cells["Qty"].Value.ToString()),
                                                           double.Parse(row.Cells["TotalItem"].Value.ToString())));
                }
                cancel = false;
                Close();
            }
        }

        private void txtItemSubtotal_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        void CalculateAndUpdateUI()
        {
            double totalPrice, unitPrice;
            int quantity;
            totalPrice = 0;

            double.TryParse(REICPrice, out unitPrice);
            double.TryParse(ItemTotal, out totalPrice);
            int.TryParse(Quantity, out quantity);

            totalPrice = quantity * unitPrice;

            txtItemTotal.Text = totalPrice.ToString("0.00");
        }

        void CalculateTotal()
        {
            double itemTotal = 0;
            double itemPrice;

            for (int i = 0; i < dgvPOItems.Rows.Count; i++)
            {
                {
                    itemPrice = double.Parse(dgvPOItems.Rows[i].Cells["POItemTotal"].Value.ToString());
                }
                itemTotal += itemPrice;
            }
            txtItemSubtotal.Text = itemTotal.ToString("0.00");
        }

        private void dgvItemSelection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvItemSelection.SelectedRows[0]; //Store row number of selected row
            txtItemName.Text = selectedRow.Cells["ItemName"].Value.ToString(); //Set the content of Item Name textbox to the selected row's item name
            nupItemQuantity.Text = "1";
            string partNumber = selectedRow.Cells["PartNo"].Value.ToString();
            txtUnitPrice.Text = (sql.SelectItemPrice(partNumber)).ToString();
        }

        private void dgvPOItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateTotal();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        //------------------------
        //  OTHER FORM ELEMENTS  |
        //------------------------
        //e.g. DGV, textchange events, etc.
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {

        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {

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
