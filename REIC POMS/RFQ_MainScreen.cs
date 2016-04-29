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
        private ArrayList rfqList; //All RFQs
        private ArrayList rfqOrderLineList; //All RFQ Order Lines
        private int counter; //For RFQ No.

        //CONSTRUCTOR
        public RFQ_MainScreen()
        {
            InitializeComponent();
            rfqList = new ArrayList();
            rfqOrderLineList = new ArrayList();
            counter = 0;

            //---ADJUST DATAGRIDVIEW COLUMN ALIGNMENT
                //Center column headings
                    dgvRFQ.Columns["RequestDate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvRFQ.Columns["RFQNo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //Center column cell contents
                    dgvRFQ.Columns["RFQNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvRFQ.Columns["RequestDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //---TEST CODE (For the purpose of customizing the DGV and checking out its appearance)
                dgvRFQ.Rows.Add("ATPI 1609-016", "09/30/2015", "Lucid Co.", "Fat Shaolin Jaidete Kiosk");
                dgvRFQ.Rows.Add("ATPI 1608-025", "08/22/2015", "Mabelle Co.", "Balay Dako");
                dgvRFQ.Rows.Add("ATPI 1612-042", "12/24/2015", "Lights Co.", "Lumen Homes");
                dgvRFQ.Rows.Add("ATPI 1601-002", "01/30/2015", "Home Co.", "Waffle Time");

            //---STREAM READER
            try
            {
                FileStream fs = new FileStream(@"rfq.txt", FileMode.Open);
                StreamReader readin = new StreamReader(fs);
                while (!readin.EndOfStream)
                {
                    string[] text = readin.ReadLine().Split('|');
                    dgvRFQ.Rows.Add(text[3], text[4], text[5], text[7]); //Place RFQ at DGV
                    rfqList.Add(new RFQ(text[0], text[1], text[2], text[3], text[4], int.Parse(text[5]), int.Parse(text[6]))); //Recreate the RFQ
                    counter++;    
                }
                readin.Close();
                fs.Close();
            }
            catch (Exception /*e*/) { }

            try
            {
                FileStream fs = new FileStream(@"rfq_order_line.txt", FileMode.Open);
                StreamReader readin = new StreamReader(fs);
                while (!readin.EndOfStream)
                {
                    string[] text = readin.ReadLine().Split('|');
                    rfqOrderLineList.Add(new RFQ_OrderLine(text[0], text[1], int.Parse(text[2]))); //Recreate the RFQ Order Line
                }
                readin.Close();
                fs.Close();
            }
            catch (Exception /*e*/) { }
        }

        //-----------------
        // STREAM WRITER  |
        //-----------------
        private void saveRFQData()
        {
            try
            {
                FileStream fs = new FileStream(@"rfq.txt", FileMode.Create);
                StreamWriter writeout = new StreamWriter(fs);
                for (int i = 0; i < rfqList.Count; i++)
                {
                    RFQ r = (RFQ)rfqList[i]; //Casting. So that I can retrieve attribute values from this specific RFQ.
                    writeout.WriteLine(r.RFQNo.ToString() + "|"
                                     + r.RequestDate + "|"
                                     + r.PaymentTerms + "|"
                                     + r.AccountNumber + "|"
                                     + r.DeliveryTerms + "|"
                                     + r.CustomerID + "|"
                                     + r.SupplierID);
                }
                writeout.Close();
                fs.Close();
            }
            catch (Exception /*e2*/) { }
        }

        private void saveRFQOrderLineData()
        {
            try
            {
                FileStream fs = new FileStream(@"rfq_order_line.txt", FileMode.Create);
                StreamWriter writeout = new StreamWriter(fs);
                for (int i = 0; i < rfqOrderLineList.Count; i++)
                {
                    RFQ_OrderLine rol = (RFQ_OrderLine)rfqOrderLineList[i]; //Casting. So that I can retrieve attribute values from this specific RFQ.
                    writeout.WriteLine(rol.RFQNo.ToString() + "|"
                                     + rol.PartNumber + "|"
                                     + rol.Quantity);
                }
                writeout.Close();
                fs.Close();
            }
            catch (Exception /*e2*/) { }
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
            /*SPR_MainScreen sprMain = new SPR_MainScreen();
            this.Hide();
            sprMain.ShowDialog();
            this.Close();*/
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
            crfq.RFQNo = counter.ToString();
            crfq.ShowDialog(); //Validation happens at RFQ_CreateForm.cs
                        
            if (crfq.Cancel == false) //Meaning, will create the RFQ. If Cancel is true, nothing happens.
            {
                //---ADD the new Request for Price Quotation to the ArrayList
                rfqList.Add(new RFQ(crfq.RFQNo,
                                    crfq.RequestDate,
                                    crfq.PaymentTerms,
                                    crfq.AccountNumber,
                                    crfq.DeliveryTerms,
                                    crfq.CustomerIDFK,
                                    crfq.SupplierIDFK));
                
                for (int i = 0; i < crfq.RFQOrderLineList.Count; i++)
                {
                    RFQ_OrderLine rol = (RFQ_OrderLine)crfq.RFQOrderLineList[i];
                    rfqOrderLineList.Add(new RFQ_OrderLine(rol.RFQNo,
                                                           rol.PartNumber,
                                                           rol.Quantity));
                    MessageBox.Show("Orderline added to comprehensive list: " + rol.RFQNo + ", " + rol.PartNumber + ", " + rol.Quantity);
                }

                //---DISPLAY the newly created RFQ in the Main Screen DGV
                dgvRFQ.Rows.Add(crfq.RFQNo, crfq.RequestDate, crfq.SupplierName, crfq.CustomerName);

                //---INSERT in database
                //INSERT SQL STATEMENT

                //---MESSAGEBOX FOR DEBUG PURPOSES
                MessageBox.Show("RFQ CREATED: " + crfq.RFQNo + ", " + crfq.RequestDate + ", " + crfq.PaymentTerms + ", " + crfq.AccountNumber
                                + ", " + crfq.DeliveryTerms + ", " + "Customer " + crfq.CustomerIDFK + ", " + "Supplier " + crfq.SupplierIDFK + ", "
                                + "With " + crfq.RFQOrderLineList.Count + " Orderlines. Inserted to ArrayList index [" + (rfqList.Count - 1) + " ]");

                //Increments & Saving
                //current++; *Came from Customer Main Screen. Don't know if we'll need this for RFQ.
                saveRFQData();
                saveRFQOrderLineData();
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
                        //---DISPLAY the view form
                        RFQ_ViewForm rfqvf = new RFQ_ViewForm();
                        rfqvf.RFQNoToView = r.RFQNo;
                        rfqvf.RequestDateToView = r.RequestDate;
                        rfqvf.PaymentTermsToView = r.PaymentTerms;
                        rfqvf.AccountNumberToView = r.AccountNumber;
                        rfqvf.DeliveryTermsToView = r.DeliveryTerms;

                        //---Extracting details from Customer ID
                        //SQL: Search in database. Retrieve name of Customer ID
                        //rfqvf.CustomerNameToView = r.CustomerID;

                        //---Extracting details from Supplier ID
                        //rfqvf.SupplierNameToView = r.SupplierID;

                        rfqvf.ShowDialog(); //Opens RFQ_ViewForm.cs
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
