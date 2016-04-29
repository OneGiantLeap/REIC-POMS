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
        private ArrayList customerList; //To temporarily store all customers (Names only). REPLACE W/ MYSQL LATER?
        private ArrayList customerDropdownList; //Just for the text to display in the dropdown list
        private ArrayList itemList; //To temporarily store all items. REPLACE W/ MYSQL LATER?
        private ArrayList rfqItemList; //Items in the RFQ

   

        public PQ_CreateForm()
        {
            InitializeComponent();
            customerList = new ArrayList(); //To temporarily store all customers. REPLACE W/ MYSQL LATER?
            customerDropdownList = new ArrayList(); //Just for the text to display in the dropdown list
            itemList = new ArrayList(); //To temporarily store all items. REPLACE W/ MYSQL LATER?
            rfqItemList = new ArrayList();

            try
            {
                FileStream fs = new FileStream(@"customer.txt", FileMode.Open);
                StreamReader readin = new StreamReader(fs);
                while (!readin.EndOfStream)
                {
                    string[] text = readin.ReadLine().Split('|');
                  //  customerList.Add(new Customer(text[0], text[1], text[2], text[3], text[4], text[5], text[6], text[7], text[8], text[9]));                  
                   customerDropdownList.Add(text[3]); //Just noting the Customer Names
                }
                readin.Close();
                fs.Close();
                customerList.Sort(); //Sort list alphabetically
                customerList.Insert(0, "Select Customer");
                cbbCustomerName.DataSource = customerList; //Populate the dropdown w/ all Customer Names
            }
            catch (Exception /*e*/) { }
        
        
        }

        public bool cancel;

        public string PQNo
        {
            set { txtPQNumber.Text = value; }
            get { return txtPQNumber.Text; }
        }

        public string PQDate
        {
            set { dtpDate.Text = value; }
            get { return dtpDate.Text; }
        }

        public string RFQNo
        {
            set { txtRFQNumber.Text = value; }
            get { return txtRFQNumber.Text; }
        }

        public string FromDate
        {
            set { dtpFromDate.Text = value; }
            get { return dtpFromDate.Text; }
        }

        public string ToDate
        {
            set { dtpToDate.Text = value; }
            get { return dtpToDate.Text; }
        }

        public string PaymentTerms
        {
            get { return cbbPaymentTerms.Text; }
        }

        public string DeliveryTerms
        {
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

        public string CustomerName
        {
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

        public ArrayList RFQItemsList
        {
            get { return rfqItemList; }
        }

        public bool Cancel
        {
            get { return cancel; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbbPaymentTerms.Text == "Select") //"Select" is the default option
            {
                MessageBox.Show("Please select an option for Payment Terms.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabPQForm.SelectedTab = tabPQForm.TabPages["tabRequestDetails"]; //Directs user to the Request Details tab.
                return;
            }

            if (cbbDeliveryTerms.Text == "Select")
            {
                MessageBox.Show("Please select an option for Delivery Terms.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabPQForm.SelectedTab = tabPQForm.TabPages["tabRequestDetails"]; //Directs user to the Request Details tab.
                return;
            }

            if (cbbInFavorOf.Text == "Select")
            {
                MessageBox.Show("Please select an option for In Favor Of.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabPQForm.SelectedTab = tabPQForm.TabPages["tabRequestDetails"]; //Directs user to the Request Details tab.
                return;
            }

            
            if (cbbCustomerName.Text == "Select Customer")
            {
                MessageBox.Show("Please select a Customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabPQForm.SelectedTab = tabPQForm.TabPages["tabRequestDetails"]; //Directs user to the Request Details tab.
                return;
            }

            //If there are no items added to the RFQ
            if (dgvPQItems.Rows.Count == 0)
            {
                MessageBox.Show("Please include item(s) in the Price Quotation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabPQForm.SelectedTab = tabPQForm.TabPages["tabItemDetails"]; //Directs user to the Item Details tab.
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            Close();
        }

        private void cbbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCustomerName.Text == "Select Customer")
            {
                CustomerPerson = null;
                CustomerNumber = null;
                CustomerEmail = null;
                CustomerAddress = null;
                return;
            }

           
            for (int i = 0; i < customerList.Count; i++)
            {
                Customer c = (Customer)customerList[i]; //Casting. So can retrieve attribute values from this specific Supplier.
                if (c.CustomerName == cbbCustomerName.Text)
                {
                    CustomerPerson = c.CustomerPerson;
                    CustomerNumber = c.CustomerNumber;
                    CustomerEmail = c.CustomerEmail;
                    CustomerAddress = c.CustomerAddress;
                    break; //Once the other fields are auto-complated, end the search process.
                }
            }
        }
    }
}
