using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Enables Filestream (Debug purposes, since no MySQL yet)
using System.Collections; //Enables use of ArrayList

namespace REIC_POMS
{
    public partial class RFQ_MainScreen : Form
    {
        //ATTRIBUTES
        private MySQLDatabaseDriver sql;
        private ArrayList rfqList; //All RFQs

        //CONSTRUCTOR
        public RFQ_MainScreen()
        {
            InitializeComponent();
            sql = new MySQLDatabaseDriver();
            rfqList = new ArrayList();

            //---ADJUST DATAGRIDVIEW COLUMN ALIGNMENT
            //Center column headings
            dgvRFQ.Columns["RequestDate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRFQ.Columns["RFQNo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Center column cell contents
            dgvRFQ.Columns["RFQNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRFQ.Columns["RequestDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //---STREAM READER
            sql.SelectAllRFQDGV(dgvRFQ); //Populate DGV
            sql.SelectAllRFQ(rfqList);
        }

        private void RFQ_MainScreen_Load(object sender, EventArgs e)
        {
            cbbFilterBy.SelectedIndex = 0; //Sets the default combobox value to "Filter by..."
        }

        //--------------------------------------
        // MINIMIZE AND CLOSE BUTTONS METHODS  |
        //--------------------------------------
        private void btnMinimize_Click(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Minimized; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close(); //Exit the program
        }

        //------------------------
        // ITEMS NAVBAR METHODS  |
        //------------------------
        private void btnItems_Click(object sender, EventArgs e)
        {
            Item_MainScreen itemsMain = new Item_MainScreen();
            this.Hide();
            itemsMain.ShowDialog();
            this.Close();
        }

        private void btnItems_MouseEnter(object sender, EventArgs e)
        { btnItems.BackgroundImage = Properties.Resources.ButtonHoverItems; }

        private void btnItems_MouseLeave(object sender, EventArgs e)
        { btnItems.BackgroundImage = Properties.Resources.ButtonInactiveItems; }

        //---------------------------
        // CUSTOMER NAVBAR METHODS  |
        //---------------------------
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customer_MainScreen customerMain = new Customer_MainScreen();
            this.Hide();
            customerMain.ShowDialog();
            this.Close();
        }

        private void btnCustomers_MouseEnter(object sender, EventArgs e)
        { btnCustomers.BackgroundImage = Properties.Resources.ButtonHoverCustomers; }

        private void btnCustomers_MouseLeave(object sender, EventArgs e)
        { btnCustomers.BackgroundImage = Properties.Resources.ButtonInactiveCustomers; }

        //---------------------------
        // SUPPLIER NAVBAR METHODS  |
        //---------------------------
        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            Supplier_MainScreen supplierMain = new Supplier_MainScreen();
            this.Hide();
            supplierMain.ShowDialog();
            this.Close();
        }

        private void btnSuppliers_MouseEnter(object sender, EventArgs e)
        { btnSuppliers.BackgroundImage = Properties.Resources.ButtonHoverSuppliers; }

        private void btnSuppliers_MouseLeave(object sender, EventArgs e)
        { btnSuppliers.BackgroundImage = Properties.Resources.ButtonInactiveSuppliers; }

        //----------------------------------------------
        // REQUEST FOR PRICE QUOTATION NAVBAR METHODS  |
        //----------------------------------------------
        private void btnRFQ_Click(object sender, EventArgs e)
        { /*Nothing needed to add*/ }

        private void btnRFQ_MouseEnter(object sender, EventArgs e)
        { /*Nothing needed to add*/ }

        private void btnRFQ_MouseLeave(object sender, EventArgs e)
        { /*Nothing needed to add*/ }

        //----------------------------------
        // PRICE QUOTATION NAVBAR METHODS  |
        //----------------------------------
        private void btnPQ_Click(object sender, EventArgs e)
        {
            PQ_MainScreen pqMain = new PQ_MainScreen();
            this.Hide();
            pqMain.ShowDialog();
            this.Close();
        }

        private void btnPQ_MouseEnter(object sender, EventArgs e)
        { btnPQ.BackgroundImage = Properties.Resources.ButtonHoverPQ; }

        private void btnPQ_MouseLeave(object sender, EventArgs e)
        { btnPQ.BackgroundImage = Properties.Resources.ButtonInactivePQ; }

        //---------------------------------
        // PURCHASE ORDER NAVBAR METHODS  |
        //---------------------------------
        private void btnPO_Click(object sender, EventArgs e)
        {
            PO_MainScreen poMain = new PO_MainScreen();
            this.Hide();
            poMain.ShowDialog();
            this.Close();
        }

        private void btnPO_MouseEnter(object sender, EventArgs e)
        { btnPO.BackgroundImage = Properties.Resources.ButtonHoverPO; }

        private void btnPO_MouseLeave(object sender, EventArgs e)
        { btnPO.BackgroundImage = Properties.Resources.ButtonInactivePO; }

        //---------------------------------------------------
        // SALES INVOICE & DELIVERY RECEIPT NAVBAR METHODS  |
        //---------------------------------------------------
        private void btnSIDR_Click(object sender, EventArgs e)
        {
            SIDR_MainScreen sidrMain = new SIDR_MainScreen();
            this.Hide();
            sidrMain.ShowDialog();
            this.Close();
        }

        private void btnSIDR_MouseEnter(object sender, EventArgs e)
        { btnSIDR.BackgroundImage = Properties.Resources.ButtonHoverSIDR; }

        private void btnSIDR_MouseLeave(object sender, EventArgs e)
        { btnSIDR.BackgroundImage = Properties.Resources.ButtonInactiveSIDR; }

        //-----------------------------------------------------
        // SALES PERFORMANCE REPORT & SUMMARY NAVBAR METHODS  |
        //-----------------------------------------------------
        private void btnSPRS_Click(object sender, EventArgs e)
        {
            SPR_MainScreen sprMain = new SPR_MainScreen();
            this.Hide();
            sprMain.ShowDialog();
            this.Close();
        }

        private void btnSPRS_MouseEnter(object sender, EventArgs e)
        { btnSPRS.BackgroundImage = Properties.Resources.ButtonHoverSPRS; }

        private void btnSPRS_MouseLeave(object sender, EventArgs e)
        { btnSPRS.BackgroundImage = Properties.Resources.ButtonInactiveSPRS; }

        //--------------------------
        // SIGNOUT NAVBAR METHODS  |
        //--------------------------
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            //TEST CODE 
            DialogResult result = MessageBox.Show("Are you sure you want to sign out?", "Confirm Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                //LoginScreen login = new LoginScreen(); //Log-in Screen ---> This doesn't work, so I placed Application.Restart(); instead
                //login.ShowDialog(); ---> This doesn't work, so I placed Application.Restart(); instead
                Application.Restart(); //Restarts the application; goes back to Log-in Screen
        }

        private void btnSignOut_MouseEnter(object sender, EventArgs e)
        { btnSignOut.BackgroundImage = Properties.Resources.ButtonHoverSignOut; }

        private void btnSignOut_MouseLeave(object sender, EventArgs e)
        { btnSignOut.BackgroundImage = Properties.Resources.ButtonInactiveSignOut; }

        //-----------------------------
        // CREATE RFQ BUTTON METHODS  |
        //-----------------------------
        private void btnCreateRFQ_Click(object sender, EventArgs e)
        {
            RFQ_CreateForm crfq = new RFQ_CreateForm();
            //Generating the RFQ No.
            //Search SQL for existing RFQs with "YYMM-%" (e.g. 1604-%). nthRFQ is +1 to the number of rows returned.
            string year = DateTime.Now.ToString("yy"); //Last two digits of year (e.g. 2016 becomes 16)
            string month = DateTime.Now.ToString("MM");
            int rfqCount = sql.GetRowCount("rfq_t", year, month);
            string generatedRFQNo = year + month + "-" + (rfqCount + 1).ToString("D3"); //D3 for padded zeroes and ensure there are 3 digits.

            crfq.RFQNo = generatedRFQNo;
            crfq.ShowDialog(); //Validation happens at RFQ_CreateForm.cs

            if (crfq.Cancel == false) //Meaning, will create the RFQ. If Cancel is true, nothing happens.
            {
                //---ADD the new Request for Price Quotation to the ArrayList
                rfqList.Add(new RFQ(crfq.RFQNo,
                                    crfq.RequestDate,
                                    crfq.PaymentTerms,
                                    crfq.DeliveryTerms,
                                    crfq.CustomerIDFK,
                                    crfq.SupplierIDFK));

                //Save to rfq_t database
                RFQ newRFQ = (RFQ)rfqList[(rfqList.Count - 1)]; //Casting
                sql.InsertRFQ(newRFQ);

                for (int i = 0; i < crfq.RFQOrderLineList.Count; i++) //Go through newly created RFQs' OrderLines
                {
                    //Add to ArrayList
                    RFQ_OrderLine rol = (RFQ_OrderLine)crfq.RFQOrderLineList[i]; //Casting
                    /*rfqOrderLineList.Add(new RFQ_OrderLine(rol.RFQNo,
                                                           rol.PartNumber,
                                                           rol.Quantity));*/
                    //Save to rfq_order_line_t database
                    sql.InsertRFQOrderLine(rol);

                    MessageBox.Show("OrderLine added to comprehensive list: " + rol.RFQNo + ", " + rol.PartNumber + ", " + rol.Quantity);
                }

                //---DISPLAY the newly created RFQ in the Main Screen DGV
                dgvRFQ.Rows.Add(crfq.RFQNo, crfq.RequestDate, crfq.SupplierName, crfq.CustomerName);

                //---MESSAGEBOX FOR DEBUG PURPOSES
                MessageBox.Show("RFQ CREATED: " + crfq.RFQNo + ", " + crfq.RequestDate + ", " + crfq.PaymentTerms + ", " + 
                                crfq.DeliveryTerms + ", " + "Customer " + crfq.CustomerIDFK + ", " + "Supplier " + crfq.SupplierIDFK + ", "
                                + "With " + crfq.RFQOrderLineList.Count + " Orderlines. Inserted to ArrayList index [" + (rfqList.Count - 1) + "]");
            }

        }

        private void btnCreateRFQ_MouseEnter(object sender, EventArgs e)
        { btnCreateRFQ.BackgroundImage = Properties.Resources.ButtonCreateRFQHover; }

        private void btnCreateRFQ_MouseLeave(object sender, EventArgs e)
        { btnCreateRFQ.BackgroundImage = Properties.Resources.ButtonCreateRFQ; }

        //---------------------------
        // VIEW RFQ BUTTON METHODS  |
        //---------------------------
        private void btnViewRFQ_Click(object sender, EventArgs e)
        {
            //---SEARCH for the other values of the selected RFQ
            for (int i = 0; i < rfqList.Count; i++) //Finding the RFQ in the ArrayList
            {
                if (rfqList[i] != null)
                {
                    RFQ r = (RFQ)rfqList[i]; //Casting. So I can retrieve values from this specific RFQ.

                    if (r.RFQNo == dgvRFQ.SelectedRows[0].Cells[0].Value.ToString()) //If RFQ Numbers match
                    {
                        //---SET values in forms' labels & DISPLAY the view form
                        RFQ_ViewForm rfqvf = new RFQ_ViewForm();
                        rfqvf.RFQNoToView = r.RFQNo;
                        rfqvf.RequestDateToView = r.RequestDate;
                        rfqvf.PaymentTermsToView = r.PaymentTerms;
                        rfqvf.DeliveryTermsToView = r.DeliveryTerms;
                        rfqvf.CustomerNameToView = dgvRFQ.SelectedRows[0].Cells[2].Value.ToString();
                        rfqvf.SupplierNameToView = dgvRFQ.SelectedRows[0].Cells[3].Value.ToString();

                        //Retrieve other Supplier Details
                        Supplier s = sql.SelectSupplierDetails(r.SupplierID);
                        rfqvf.SupplierPersonToView = s.SupplierPerson;
                        rfqvf.SupplierNumberToView = s.SupplierNumber;
                        rfqvf.SupplierEmailToView = s.SupplierEmail;
                        rfqvf.SupplierAddressToView = s.SupplierAddress;

                         //Retrieve Order Line Details
                         //Happens in View Form: at RFQ_OrderLine_Load

                         //Open RFQ_ViewForm.cs
                         rfqvf.ShowDialog();
                    }
                }
            }
        }

        private void btnViewRFQ_MouseEnter(object sender, EventArgs e)
        { btnViewRFQ.BackgroundImage = Properties.Resources.ButtonViewRFQHover; }

        private void btnViewRFQ_MouseLeave(object sender, EventArgs e)
        { btnViewRFQ.BackgroundImage = Properties.Resources.ButtonViewRFQ; }

        //---------------------------
        // SEARCH AND CLEAR SEARCH  |
        //---------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //INSERT SEARCH MAGIC HERE
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Search for...";
            cbbFilterBy.SelectedIndex = 0; //Sets the combobox value to "Filter by..."
        }
    }
}
