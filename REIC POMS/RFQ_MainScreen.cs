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
        /*---CODING NOTES/REALIZATIONS/ENIGMAS
            [ ] Have an Arraylist implementation
            [ ] Autogeneration of RFQ number is tricky, especially if you'll follow the "ATPI YYMM-###" format.
            [ ] Your Reference # and Our Reference # (if we push with it; or even just the single RFQ No. formatting) will give us HELL.
            [ ] How will you insert the RFQ's Items into the RFQ Class?
            [ ] Database-wise, how will we save the RFQ data?
                > For example, in Item class has SupplierID as the foreign key.
                > But in the forms, Supplier name/person/number/etc. details are also present.
                > Do we just save the Item details plus that lone SupplierID?
                    - If yes, then we'll have to do some searching (maybe?) to retrieve the selected Supplier's ID.
                      Furthermore, we can also reduce the getters in some of the forms?
        */

        //ATTRIBUTES
        private ArrayList rfqList;
        private int current;  //Came from Customer Main Screen. Don't know if we'll need this for RFQ.

        //CONSTRUCTOR
        public RFQ_MainScreen()
        {
            InitializeComponent();
            current = 0;
            rfqList = new ArrayList();

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
                    dgvRFQ.Rows.Add(text[3], text[4], text[5], text[7]); //Place Customer at DGV
                    rfqList.Add(new Customer(text[0], text[1], text[2], text[3], text[4], text[5], text[6], text[7], text[8])); //Recreate the Customer
                    //current++; *Came from Customer Main Screen. Don't know if we'll need this for RFQ.
                    //MessageBox.Show("RFQ data added.");
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
        {/* DID NOT ENABLE, DUE TO RFQITEMS. How do you even.
            try
            {
                FileStream fs = new FileStream(@"rfq.txt", FileMode.Create);
                StreamWriter writeout = new StreamWriter(fs);

                for (int i = 0; i < rfqList.Count; i++)
                {
                    RFQ c = (RFQ)rfqList[i]; //Casting. So that I can retrieve attribute values from this specific RFQ.
                    writeout.WriteLine(c.RFQNo.ToString() + "|"
                                   + c.RequestDate + "|"
                                   + c.PaymentTerms + "|"
                                   + c.AccountNumber + "|"
                                   + c.DeliveryTerms + "|"
                                   + c.InFavorOf + "|"
                                   + c.CustomerName + "|"
                                   + c.SupplierName + "|"
                                   + c.SupplierPerson + "|"
                                   + c.SupplierNumber + "|"
                                   + c.SupplierEmail + "|"
                                   + c.SupplierAddress + "|"
                                   + c.RFQItems + "|");
                }

                writeout.Close();
                fs.Close();
            }
            catch (Exception e2) { }*/
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
            this.Hide(); //Added to actually close the Main Screen instead of it being open in the background
            itemsMain.ShowDialog();
            this.Close(); //Closes the Customer Main Screen
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
            /*Supplier_MainScreen supplierMain = new Supplier_MainScreen();
            this.Hide();
            customerMain.ShowDialog();
            this.Close(); */
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
            crfq.ShowDialog(); //Validation happens at RFQ_CreateForm.cs

            if (crfq.Cancel == false) //Meaning, will create the RFQ. If Cancel is true, nothing happens.
            {
                //---ADD the new Request for Price Quotation to the ArrayList
                rfqList.Add(new RFQ(crfq.RFQNo, //THIS SHOULD BE SPECIALLY CUSTOMIZED with the correct RFQ No. format (Good luck)
                                    crfq.RequestDate,
                                    crfq.PaymentTerms,
                                    crfq.AccountNumber.ToString(),
                                    crfq.DeliveryTerms,
                                    crfq.InFavorOf,
                                    crfq.CustomerName,
                                    crfq.SupplierName,
                                    crfq.SupplierPerson,
                                    crfq.SupplierNumber,
                                    crfq.SupplierEmail,
                                    crfq.SupplierAddress/*,
                                    crfq.RFQItems*/));

                /*Saw an article, but wasn't able to finish reading it. This code snippet is interesting.
                    What if the RFQ's item collection is another ArrayList, and then we insert that to the RFQ ArrayList?
                    Next challenge would be passing the RFQ items' data from the Create Form.

                    ArrayList<String[]> list2 = new ArrayList<String[]>();

                    list2.add(new String[] { "0", "0" });
                    list2.add(new String[] { "0", "1" });
                    list2.add(new String[] { "1", "0" });
                    list2.add(new String[] { "1", "1" }); */

                //---DISPLAY the newly created RFQ in the Main Screen DGV
                dgvRFQ.Rows.Add(crfq.RFQNo, crfq.RequestDate, crfq.SupplierName, crfq.CustomerName);

                //---MESSAGEBOX FOR DEBUG PURPOSES
                MessageBox.Show("RFQ CREATED: " + crfq.RFQNo + ", " + crfq.RequestDate + ", " + crfq.PaymentTerms + ", " + crfq.AccountNumber
                                + ", " + crfq.DeliveryTerms + ", " + crfq.InFavorOf + ", " + crfq.CustomerName + ", " + crfq.SupplierName
                                + ", " + crfq.SupplierPerson + ", " + crfq.SupplierNumber + ", " + crfq.SupplierEmail + ", " + crfq.SupplierAddress
                                + "With "/* + crfq.RFQItems.Length*/ + ". Inserted to Array [" + current + " ]");

                //Increments & Saving
                //current++; *Came from Customer Main Screen. Don't know if we'll need this for RFQ.
                //saveRFQData(); I DON'T KNOW HOW TO SAVE AN ARRAY INSIDE AN ARRAYLIST AND PULL THE ARRAY'S VALUES OUT.
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
