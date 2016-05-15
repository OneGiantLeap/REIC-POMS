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
    public partial class PQ_MainScreen : Form
    {
        private MySQLDatabaseDriver sql;
        private ArrayList pqList;

        public PQ_MainScreen()
        {
            InitializeComponent();
            sql = new MySQLDatabaseDriver();
            pqList = new ArrayList();

            //---ADJUST DATAGRIDVIEW COLUMN ALIGNMENT
            //Center column header
            dgvPQ.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvPQ.Columns["PQNumber"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //Center column contents
                    dgvPQ.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvPQ.Columns["PQNumber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //---TEST CODE (For the purpose of customizing the DGV and checking out its appearance)
                /*dgvPQ.Rows.Add("11/20/2015", "ABC Company", "ATPI 1611-016", "01/01/2015 - 11/05/2017");
                dgvPQ.Rows.Add("06/10/2015", "Zen Nutrients Co.", "ATPI 1606-005", "02/01/2015 - 12/03/2017");
                dgvPQ.Rows.Add("09/07/2015", "Colette’s Company", "ATPI 1609-048", "03/01/2015 - 09/05/2017");
                dgvPQ.Rows.Add("07/12/2015", "Joy Luck Club", "ATPI 1607-004", "04/01/2015 - 08/02/2017");*/

            sql.SelectAllPQDGV(dgvPQ); 
            sql.SelectAllPQ(pqList);

        }

        private void PQ_MainScreen_Load(object sender, EventArgs e)
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
                sql.Backup();
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
        {
            RFQ_MainScreen rfqMain = new RFQ_MainScreen();
            this.Hide();
            rfqMain.ShowDialog();
            this.Close();
        }

        private void btnRFQ_MouseEnter(object sender, EventArgs e)
        { btnRFQ.BackgroundImage = Properties.Resources.ButtonHoverRFQ; }

        private void btnRFQ_MouseLeave(object sender, EventArgs e)
        { btnRFQ.BackgroundImage = Properties.Resources.ButtonInactiveRFQ; }

        //----------------------------------
        // PRICE QUOTATION NAVBAR METHODS  |
        //----------------------------------
        private void btnPQ_Click(object sender, EventArgs e)
        { /*Nothing to add here*/ }

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

        //-----------------------------------------
        // CREATE PRICE QUOTATION BUTTON METHODS  |
        //-----------------------------------------
        private void btnCreatePQ_Click(object sender, EventArgs e)
        {
            //this would open the small screen (createfrompqform)
            PQ_CreateFromRFQForm pcf = new PQ_CreateFromRFQForm();
            pcf.ShowDialog();

            /*PQ_CreateForm pf = new PQ_CreateForm();
            if (pf.Cancel == false)
            {
                sql.SelectAllPQ(pqList);
            }*/
            
        }

        private void btnCreatePQ_MouseEnter(object sender, EventArgs e)
        { btnCreatePQ.BackgroundImage = Properties.Resources.ButtonCreatePQHover; }

        private void btnCreatePQ_MouseLeave(object sender, EventArgs e)
        { btnCreatePQ.BackgroundImage = Properties.Resources.ButtonCreatePQ; }

        //---------------------------------------
        // VIEW PRICE QUOTATION BUTTON METHODS  |
        //---------------------------------------
        private void btnViewPQ_Click(object sender, EventArgs e)
        {
            string pqNo = dgvPQ.SelectedRows[0].Cells[2].Value.ToString();
            PQ p = sql.SelectPQDetails(pqNo);

                        //---SET values in forms' labels & DISPLAY the view form
                        PQ_ViewForm pqvf = new PQ_ViewForm();
                        pqvf.PQNoToView = p.PQNo;
                        pqvf.PQDateToView = p.PQDate;
                        pqvf.FromDatetoView = p.PQFromDate;
                        pqvf.ToDatetoView = p.PQToDate;
                        pqvf.PaymentTermsToView = p.PaymentTerms;
                        pqvf.InFavorOfToView = p.InFavorOf;
                        pqvf.DeliveryTermsToView = p.DeliveryTerms;
                        pqvf.CustomerNameToView = dgvPQ.SelectedRows[0].Cells[1].Value.ToString();

                        //Retrieve other Customer Details
                        Customer c = sql.SelectCustomerDetails(p.CustomerID);
                        pqvf.CustomerPersonToView = c.CustomerPerson;
                        pqvf.CustomerNumberToView = c.CustomerNumber;
                        pqvf.CustomerEmailToView = c.CustomerEmail;
                        pqvf.CustomerAddressToView = c.CustomerAddress;

                        //Retrieve Order Line Details
                        //Happens in View Form: at PQ_OrderLine_Load

                        //Open PQ_ViewForm.cs
                        pqvf.ShowDialog();                    
        }


        private void btnViewPQ_MouseEnter(object sender, EventArgs e)
        { btnViewPQ.BackgroundImage = Properties.Resources.ButtonViewPQHover; }

        private void btnViewPQ_MouseLeave(object sender, EventArgs e)
        { btnViewPQ.BackgroundImage = Properties.Resources.ButtonViewPQ; }

        //---------------------------
        // SEARCH AND CLEAR SEARCH  |
        //---------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Search for...";
            cbbFilterBy.SelectedIndex = 0; //Sets the combobox value to "Filter by..."
        }

    }
}
