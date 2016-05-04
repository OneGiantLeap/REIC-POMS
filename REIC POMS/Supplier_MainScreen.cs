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
using System.IO;

namespace REIC_POMS
{
    public partial class Supplier_MainScreen : Form
    {
        ArrayList supplierList;
        private int supplierIDCounter;

        public Supplier_MainScreen()
        {
            InitializeComponent();

            supplierIDCounter = 000000;
            supplierList = new ArrayList();

            /*
            //---STREAM READER
            try
            {
                FileStream fs = new FileStream(@"supplier.txt", FileMode.Open);
                StreamReader readin = new StreamReader(fs);
                while (!readin.EndOfStream)
                {
                    string[] text = readin.ReadLine().Split('|');
                    supplierList.Add(new Supplier(text[0], text[1], text[2], text[3], text[4], text[5])); //Recreate the Supplier
                    dgvSuppliers.Rows.Add(text[1], text[2], text[3]);
                    supplierIDCounter++;
                }
                readin.Close();
                fs.Close();
            }
            catch (Exception e) { }*/

            /*
            //ADJUST DATAGRIDVIEW COLUMN ALIGNMENT
            dgvSuppliers.Columns["PartNo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //Center column header
            dgvSuppliers.Columns["PartNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //Center column contents
            */

            //TEST CODE (For the purpose of customizing the DGV and checking out its appearance)
            /*dgvSuppliers.Rows.Add("Lucid Co.", "Victoria Carpio", "09133933371");
            dgvSuppliers.Rows.Add("Fluora’s Shop", "Marvin Sta. Ana", "09253902271");
            dgvSuppliers.Rows.Add("Cinco Company", "Royce Goden", "09153903125");
            dgvSuppliers.Rows.Add("Mayers Balay", "Angelo Mercado", "09169833371");*/
        }

        private void SuppliersMainScreen_Load(object sender, EventArgs e)
        {
            cbbFilterBy.SelectedIndex = 0; //Sets the default combobox value to "Filter by..."
        }

        //-----------------
        // STREAM WRITER  |
        //-----------------
        private void saveSupplierData()
        {
            try
            {
                FileStream fs = new FileStream(@"supplier.txt", FileMode.Create);
                StreamWriter writeout = new StreamWriter(fs);

                for (int i = 0; i < supplierList.Count; i++)
                {
                    Supplier s = (Supplier)supplierList[i]; //Casting. So that I can retrieve attribute values from this specific Item.
                    writeout.WriteLine(s.SupplierID + "|"
                                     + s.SupplierName + "|"
                                     + s.SupplierPerson + "|"
                                     + s.SupplierNumber + "|"
                                     + s.SupplierEmail + "|"
                                     + s.SupplierAddress);
                }
                writeout.Close();
                fs.Close();
            }
            catch (Exception /*e2*/) { }
        }

        //--------------------------------------
        // MINIMIZE AND CLOSE BUTTONS METHODS  |
        //--------------------------------------

        private void btnMinimize_Click(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Minimized; }

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
        {
            Customer_MainScreen customerMain = new Customer_MainScreen();
            this.Hide();
            customerMain.ShowDialog();
            this.Close(); //Closes the Items Main Screen
        }

        private void btnCustomers_MouseEnter(object sender, EventArgs e)
        { btnCustomers.BackgroundImage = Properties.Resources.ButtonHoverCustomers; }

        private void btnCustomers_MouseLeave(object sender, EventArgs e)
        { btnCustomers.BackgroundImage = Properties.Resources.ButtonInactiveCustomers; }

        //---------------------------
        // SUPPLIER NAVBAR METHODS  |
        //---------------------------
        private void btnSuppliers_Click(object sender, EventArgs e)
        { /*Nothing to add here*/ }

        private void btnSuppliers_MouseEnter(object sender, EventArgs e)
        { /*Nothing to add here*/ }

        private void btnSuppliers_MouseLeave(object sender, EventArgs e)
        { /*Nothing to add here*/ }

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

        //---------------------------
        // ADD ITEM BUTTON METHODS  |
        //---------------------------
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Supplier_AddForm saf = new Supplier_AddForm();
            saf.ShowDialog();

            if (saf.Cancel == false)
            {
                supplierList.Add(new Supplier(
                              supplierIDCounter,
                              saf.SupplierName,
                              saf.SupplierPerson,
                              saf.SupplierNumber,
                              saf.SupplierEmail,
                              saf.SupplierAddress));

                dgvSuppliers.Rows.Add(saf.SupplierName, saf.SupplierPerson, saf.SupplierNumber);
                saveSupplierData(); //Filestream
                supplierIDCounter++;
                return;
            }
            else {
                DialogResult result = MessageBox.Show("Sobra na, masasaktan ka na.", "kaibigan lang talaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void btnAddSupplier_MouseEnter(object sender, EventArgs e)
        { btnAddSupplier.BackgroundImage = Properties.Resources.ButtonAddSupplierHover; }

        private void btnAddSupplier_MouseLeave(object sender, EventArgs e)
        { btnAddSupplier.BackgroundImage = Properties.Resources.ButtonAddSupplier; }

        //---------------------------
        // VIEW ITEM BUTTON METHODS  |
        //---------------------------
        private void btnViewSupplier_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < supplierList.Count; i++)
            {
                if (supplierList[i] != null)
                {
                    Supplier s = (Supplier)supplierList[i];

                    if (s.SupplierName == dgvSuppliers.SelectedRows[0].Cells[0].Value.ToString())
                    {

                        Supplier_ViewForm svf = new Supplier_ViewForm();
                        svf.SupplierNametoView = s.SupplierName;
                        svf.SupplierPersontoView = s.SupplierPerson;
                        svf.SupplierNumbertoView = s.SupplierNumber;
                        svf.SupplierEmailtoView = s.SupplierEmail;
                        svf.SupplierAddresstoView = s.SupplierAddress;
                        svf.ShowDialog();


                        if (svf.Cancel == false)
                        {
                            s.SupplierName = svf.SupplierNametoView;
                            s.SupplierPerson = svf.SupplierPersontoView;
                            s.SupplierNumber = svf.SupplierNumbertoView;
                            s.SupplierEmail = svf.SupplierEmailtoView;
                            s.SupplierAddress = svf.SupplierAddresstoView;
                            dgvSuppliers.SelectedRows[0].Cells[0].Value = svf.SupplierNametoView;
                            dgvSuppliers.SelectedRows[0].Cells[1].Value = svf.SupplierPersontoView;
                            dgvSuppliers.SelectedRows[0].Cells[2].Value = svf.SupplierNumbertoView;

                            saveSupplierData(); //Filestream
                            MessageBox.Show("oh yan updated na yan ah.");
                        }
                    }
                }
            }
        }


        private void btnViewSupplier_MouseEnter(object sender, EventArgs e)
        { btnViewSupplier.BackgroundImage = Properties.Resources.ButtonViewSupplierHover; }

        private void btnViewSupplier_MouseLeave(object sender, EventArgs e)
        { btnViewSupplier.BackgroundImage = Properties.Resources.ButtonViewSupplier; }

        //---------------------------
        // SEARCH AND CLEAR SEARCH  |
        //---------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Insert code that changes "Search for..." to blank when textbox is clicked
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Search for...";
            cbbFilterBy.SelectedIndex = 0; //Sets the combobox value to "Filter by..."
        }

    }
}
