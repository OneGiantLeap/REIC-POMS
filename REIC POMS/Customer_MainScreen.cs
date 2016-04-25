using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Enables Filestream  (Debug purposes, since no MySQL yet)
using System.Collections; //Enables use of ArrayList

namespace REIC_POMS
{
    public partial class Customer_MainScreen : Form
    {
        //ATTRIBUTES
        private ArrayList customerList;
        private int customerIDCounter; //Will be used for customer ID

        //CONSTRUCTOR
        public Customer_MainScreen()
        {
            InitializeComponent();
            customerIDCounter = 000000;
            customerList = new ArrayList();

            //---STREAM READER
            try
            {
                FileStream fs = new FileStream(@"customer.txt", FileMode.Open);
                StreamReader readin = new StreamReader(fs);
                while (!readin.EndOfStream)
                {
                    string[] text = readin.ReadLine().Split('|');
                    dgvCustomers.Rows.Add(text[3], text[4], text[5], text[7]); //Place Customer at DGV
                    customerList.Add(new Customer(text[0], text[1], text[2], text[3], text[4], text[5], text[6], text[7], text[8])); //Recreate the Customer
                    customerIDCounter++;
                    //MessageBox.Show("Customer data added.");
                }
                readin.Close();
                fs.Close();
            }
            catch (Exception /*e*/) { }

            //---TEST CODE (For the purpose of customizing the DGV and checking out its appearance)
            /* Commented out, since we already have the actual logic already. These placeholders are still here just in case.
            dgvCustomers.Rows.Add("Samsung", "Ken Maliksi", "09181234567", "ken.maliksi@obf.ateneo.edu");
            dgvCustomers.Rows.Add("Sony", "Gayle Chua", "09334645170", "gayle.t.chua@obf.ateneo.edu");
            dgvCustomers.Rows.Add("Aliens", "Meg Villa", "09991234567", "margarita.villa@obf.ateneo.edu");
            dgvCustomers.Rows.Add("Apple", "Jem Tan", "09781234567", "chrissa.jem@tan.info");
            dgvCustomers.Rows.Add("NBA", "Ish Almario", "09556874521", "ish.is.the.name@nba.com");
            */
        }

        //-----------------
        // STREAM WRITER  |
        //-----------------
        private void saveCustomerData()
        {
            try
            {
                FileStream fs = new FileStream(@"customer.txt", FileMode.Create);
                StreamWriter writeout = new StreamWriter(fs);
                
                for (int i = 0; i < customerList.Count; i++)
                {
                    Customer c = (Customer)customerList[i]; //Casting. So that I can retrieve attribute values from this specific Customer.
                    writeout.WriteLine(c.CustomerID.ToString() + "|"
                                   + c.BusinessName + "|"
                                   + c.TinNumber + "|"
                                   + c.CustomerName + "|"
                                   + c.CustomerPerson + "|"
                                   + c.CustomerNumber + "|"
                                   + c.AccountNumber + "|"
                                   + c.CustomerEmail + "|"
                                   + c.CustomerAddress);
                }
                writeout.Close();
                fs.Close();
            }
            catch (Exception /*e2*/) { }
        }

        private void ItemsMainScreen_Load(object sender, EventArgs e)
        { /*Don't know what this is for*/ }

        //--------------------------------------
        // MINIMIZE AND CLOSE BUTTONS METHODS  |
        //--------------------------------------
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //TEST CODE
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
        { /*Nothing needed to add*/ }

        private void btnCustomers_MouseEnter(object sender, EventArgs e)
        { /*Nothing needed to add*/ }

        private void btnCustomers_MouseLeave(object sender, EventArgs e)
        { /*Nothing needed to add*/ }

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

        //-------------------------------
        // ADD CUSTOMER BUTTON METHODS  |
        //-------------------------------
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer_AddForm caf = new Customer_AddForm();
            caf.ShowDialog(); //Validation happens at Customer_AddForm.cs

            if (caf.Cancel == false) //Meaning, will add the Customer. If Cancel is true, nothing happens.
            {
                //---ADD the new Customer to the ArrayList
                customerList.Add(new Customer(customerIDCounter.ToString("D6"),
                                              caf.BusinessName,
                                              caf.FullTinNumber,
                                              caf.CustomerName,
                                              caf.CustomerPerson,
                                              caf.CustomerNumber,
                                              caf.AccountNumber,
                                              caf.CustomerEmail,
                                              caf.CustomerAddress));

                //---DISPLAY the newly added Customer in the Main Screen DGV
                dgvCustomers.Rows.Add(caf.CustomerName, caf.CustomerPerson, caf.CustomerNumber, caf.CustomerEmail);

                //---MESSAGEBOX FOR DEBUG PURPOSES
                MessageBox.Show("CREATE " + customerIDCounter.ToString("D6") + ", " + caf.BusinessName + ", " + caf.FullTinNumber + ", " + caf.CustomerName
                                + ", " + caf.CustomerPerson + ", " + caf.CustomerNumber + ", " + caf.CustomerEmail + ", " + caf.CustomerAddress
                                + "Inserted to Array " + (customerList.Count - 1));
                    
                //Increments & Saving
                //current++;
                customerIDCounter++; //I haven't figured out how to add padded zeros   
                saveCustomerData(); //Streamwriter
            }
        }

        private void btnAddCustomer_MouseEnter(object sender, EventArgs e)
        { btnAddCustomer.BackgroundImage = Properties.Resources.ButtonAddCustomerHover; }

        private void btnAddCustomer_MouseLeave(object sender, EventArgs e)
        { btnAddCustomer.BackgroundImage = Properties.Resources.ButtonAddCustomer; }

        //--------------------------------
        // VIEW CUSTOMER BUTTON METHODS  |
        //--------------------------------
        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            /*---CODING NOTES (What happens)
                 1. SEARCH for the selected Customer's attribute values.
                 2. After finding the Customer in the array, DISPLAY View Form displaying the Customer's data.
                 3. User can now access the Customer View Form.
                        3.1 If Update Button was clicked, instantiate and open Update Form.
                            3.1.1 If Update button was clicked, updated values will be passed from Update Form -> View Form.
                            3.1.2 If Close button was clicked, nothing happens.
                        3.2 If Close Button was clicked, nothing happens.
                 4. If the Customer was UPDATED, obtain the updated data from the View Form
                    and update this specific Customer's attributes + DGV row values. */

            //---SEARCH for the other values of Customer View Form
            for (int i = 0; i < customerList.Count; i++) //Finding the Customer in the array
            {
                if (customerList[i] != null)
                {
                    Customer c = (Customer)customerList[i]; //Casting. So I can retrieve values from this specific Customer.

                    if (c.CustomerName == dgvCustomers.SelectedRows[0].Cells[0].Value.ToString()) //If Customer Names match
                    {
                        //---DISPLAY the view form
                        Customer_ViewForm cvf = new Customer_ViewForm();
                        cvf.BNameToView = c.BusinessName;
                        cvf.TinToView = c.TinNumber;
                        cvf.NameToView = c.CustomerName;
                        cvf.PersonToView = c.CustomerPerson;
                        cvf.NumberToView = c.CustomerNumber;
                        cvf.AcctNumberToView = c.AccountNumber;
                        cvf.EmailToView = c.CustomerEmail;
                        cvf.AddressToView = c.CustomerAddress;

                        cvf.ShowDialog(); //Opens Customer_ViewForm.cs

                        //---UPDATE values of Customer
                        if (cvf.Cancel == false) //If cancel is true, nothing happens.
                        {
                            //Update Customer's attributes (The updated values coming from View Form)
                            c.BusinessName = cvf.BNameToView;
                            c.TinNumber = cvf.TinToView;
                            c.CustomerName = cvf.NameToView;
                            c.CustomerPerson = cvf.PersonToView;
                            c.CustomerNumber = cvf.NumberToView;
                            c.AccountNumber = cvf.AcctNumberToView;
                            c.CustomerEmail = cvf.EmailToView;
                            c.CustomerAddress = cvf.AddressToView;

                            //Update DGV values
                            dgvCustomers.SelectedRows[0].Cells[0].Value = cvf.NameToView;
                            dgvCustomers.SelectedRows[0].Cells[1].Value = cvf.PersonToView;
                            dgvCustomers.SelectedRows[0].Cells[2].Value = cvf.NumberToView;
                            dgvCustomers.SelectedRows[0].Cells[3].Value = cvf.EmailToView;

                            saveCustomerData(); //Filestream. To replace with MySQL in the future.

                            //---MESSAGEBOX FOR DEBUG PURPOSES
                            MessageBox.Show("UPDATE FREAKING SUCCESSFUL. BOO YEAH.");
                        }
                        //---MESSAGEBOX FOR DEBUG PURPOSES
                        //if (cvf.Cancel == true) { MessageBox.Show("No update was done. K BOSS."); } }

                    }
                } //End of if (customersList[i] != null)
            } //End of for-loop 
        }

        private void btnViewCustomer_MouseEnter(object sender, EventArgs e)
        { btnViewCustomer.BackgroundImage = Properties.Resources.ButtonViewCustomerHover; }

        private void btnViewCustomer_MouseLeave(object sender, EventArgs e)
        { btnViewCustomer.BackgroundImage = Properties.Resources.ButtonViewCustomer; }

        //---------------------------
        // SEARCH AND CLEAR SEARCH  |
        //---------------------------
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Insert code that changes "Search for..." to blank when textbox is clicked
        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
            //MYSQL
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Search for...";
            dgvSearch.Visible = false;
            dgvCustomers.Visible = true;
        }
    }
}
