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
    public partial class PQ_CreateForm : Form
    {

        private MySQLDatabaseDriver sql;
        private ArrayList customerList; //To temporarily store all customers (Names only). REPLACE W/ MYSQL LATER?
      //  private ArrayList customerDropdownList; //Just for the text to display in the dropdown list
        private ArrayList itemList; //To temporarily store all items. 
       // private ArrayList rfqItemList; //Items in the RFQ
        private ArrayList pqOrderLineList;
        private int dateResult;
        private int customerIDFK;       


        public PQ_CreateForm()
        {
            InitializeComponent();
            sql = new MySQLDatabaseDriver(); 

            itemList = new ArrayList();
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

            cbbBillTo.SelectedIndex = 0;
            cbbShipTo.SelectedIndex = 0;
            cbbInFavorOf.SelectedIndex = 0; 
            cbbPaymentTerms.SelectedIndex = 0;
            cbbDeliveryTerms.SelectedIndex = 0; 
            customerList = new ArrayList();
            //sql.SelectAllSuppliers(customerList);

            //customerDropdownList = new ArrayList();
            //sql.SelectAllCustomerNames(customerDropdownList);
            //customerDropdownList.Sort(); 
            //customerDropdownList.Insert(0, "Select Customer");
            //cbbCustomerName.DataSource = customerDropdownList; 
            pqOrderLineList = new ArrayList();
        
        }

        private void PQ_CreateForm_Load(object sender, EventArgs e)
        {
            
            sql.SelectSpecificPQRFQOrderLine(RFQNo, dgvPQItems);
        }

        public bool cancel;

        public string PQNo
        {
            set { txtPQNumber.Text = value; }
            get { return txtPQNumber.Text; }
        }

        /*public string PQDate
        {
            set { dtpDate.Text = value; }
            get { return dtpDate.Text; }
        }*/

        public DateTime PQDate
        {
           get { return dtpDate.Value; }
        }

        public string RFQNo
        {
            set { txtRFQNumber.Text = value; }
            get { return txtRFQNumber.Text; }
        } 

       /* public string FromDate
        {
            set { dtpFromDate.Text = value; }
            get { return dtpFromDate.Text; }
        }

        public string ToDate
        {
            set { dtpToDate.Text = value; }
            get { return dtpToDate.Text; }
        }*/

         public DateTime FromDate
        {
            get { return dtpFromDate.Value; }
        }

        public DateTime ToDate
        {
            get { return dtpToDate.Value; }
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

        public string BillTo
        {
            set { cbbBillTo.Text = value; }
            get { return cbbBillTo.Text; }
        }

        public string ShipTo
        {
            set { cbbShipTo.Text = value; }
            get { return cbbShipTo.Text; }
        }

        public string InFavorOf
        {
            set { cbbInFavorOf.Text = value; }
            get { return cbbInFavorOf.Text; }
        }

        public string TotalAmount
        {
            set { txtTotalAmount.Text = value; }
            get { return txtTotalAmount.Text; }
        }
        
        public string CustomerName
        {
            set { txtCustomerName.Text = value; }
            get { return txtCustomerName.Text; }
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
        
        public ArrayList PQOrderLineList
        {
            set { pqOrderLineList = value; }
            get { return pqOrderLineList; }
        }

        public int CustomerIDFK
        {
            set { customerIDFK = value; }
            get { return customerIDFK; }
        }

        public string ItemTotal
        {
            set { txtItemTotal.Text = value; }
            get { return txtItemTotal.Text; }
        }

        public string REICPrice
        {
            set { txtUnitPrice.Text = value; }
            get { return txtUnitPrice.Text; }
        }

        public string Quantity { get { return nupItemQuantity.Text; } }

        public bool Cancel
        {
            get { return cancel; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dateResult = DateTime.Compare(FromDate, ToDate);


            if (DateTime.Now < PQDate)
            {
                MessageBox.Show("It is not the date today for Price Quotation Date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabPQForm.SelectedTab = tabPQForm.TabPages["tabQuotationDetails"];
                return;
            }

            if (dateResult > 0)
            {
                MessageBox.Show("To Date of Validity Period should be later than From Date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabPQForm.SelectedTab = tabPQForm.TabPages["tabQuotationDetails"];
                return;
            }

            if (dateResult == 0)
            {
                MessageBox.Show("To Date of Validity Period should be later than From Date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabPQForm.SelectedTab = tabPQForm.TabPages["tabQuotationDetails"];
                return;
            }

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

            if (cbbBillTo.Text == "Select")
            {
                MessageBox.Show("Please select an option for Bill To.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabPQForm.SelectedTab = tabPQForm.TabPages["TabQuotationDetails"]; //Directs user to the Request Details tab.
                return;
            }

            if (cbbShipTo.Text == "Select")
            {
                MessageBox.Show("Please select an option for Ship To.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvPQItems.Rows.Count == 0)
                {
                    MessageBox.Show("Please include item(s) in the Price Quotation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabPQForm.SelectedTab = tabPQForm.TabPages["tabItemDetails"]; //Directs user to the Item Details tab.
                    return;
                }

            else
            {
                CustomerIDFK = sql.SelectCustomerID(CustomerName);
                for (int i = 0; i < dgvPQItems.RowCount; i++)
                {
                    DataGridViewRow row = dgvPQItems.Rows[i]; //Store row number
                    pqOrderLineList.Add(new PQ_OrderLine(txtPQNumber.Text,
                                                           row.Cells["PQItemPartNo"].Value.ToString(),
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

        private void btnAddtoPQ_Click(object sender, EventArgs e)
        {
            if (txtItemName.TextLength == 0)
            {
                MessageBox.Show("There is nothing to add in the Price Quotation.", "Nothing to Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow selectedRow = dgvItemSelection.SelectedRows[0]; 
            for (int i = 0; i < dgvPQItems.RowCount; i++) 
            {
                if (selectedRow.Cells["PartNo"].Value == dgvPQItems.Rows[i].Cells["PQItemPartNo"].Value)
                    {
                        MessageBox.Show("That item has already been added in the Price Quotation. If you wish to change the item quantity, please remove that item and add it again.", "Item Already in PQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }
            }
            dgvPQItems.Rows.Add(selectedRow.Cells["ItemName"].Value, 
                   selectedRow.Cells["PartNo"].Value, 
                   selectedRow.Cells["Description"].Value,
                   selectedRow.Cells["UnitPrice"].Value,
                   nupItemQuantity.Value,
                   selectedRow.Cells["UOM"].Value,
                   ItemTotal);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvPQItems.Rows.Count == 0) //Empty DGV
                {
                    MessageBox.Show("There are no items to remove from the Price Quotation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //Enables user to interact with the form again
                }
            dgvPQItems.Rows.RemoveAt(dgvPQItems.CurrentRow.Index);
        }

        private void btnClearItems_Click(object sender, EventArgs e)
            {
                if (dgvPQItems.Rows.Count == 0)
                    { MessageBox.Show("There are no items to remove from the Request for Price Quotation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                dgvPQItems.Rows.Clear();
            }

        private void dgvItemSelection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvItemSelection.SelectedRows[0]; //Store row number of selected row
            txtItemName.Text = selectedRow.Cells["ItemName"].Value.ToString(); //Set the content of Item Name textbox to the selected row's item name
            nupItemQuantity.Text = "1";
            string partNumber = selectedRow.Cells["PartNo"].Value.ToString();
            txtUnitPrice.Text = (sql.SelectItemPrice(partNumber)).ToString();
              
        }

        private void nupItemQuantity_ValueChanged(object sender, EventArgs e)
        {
            CalculateAndUpdateUI();
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

        void CalculateTotal()
        {
            double itemTotal = 0;
            double itemPrice;

            for (int i = 0; i < dgvPQItems.Rows.Count; i++)
            {
                {
                    itemPrice = double.Parse(dgvPQItems.Rows[i].Cells["totalItem"].Value.ToString()); 
                }
                itemTotal += itemPrice;
            }
            txtTotalAmount.Text = itemTotal.ToString("0.00");
        }

        private void dgvPQItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateTotal();
        }

        private void dgvPQItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateTotal();
        }
    }
}
