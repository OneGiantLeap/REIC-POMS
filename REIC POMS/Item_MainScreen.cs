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
using System.Collections; //Enables ArrayList

namespace REIC_POMS
{
    public partial class Item_MainScreen : Form
    {
        ArrayList itemList;

        public Item_MainScreen()
        {
            InitializeComponent();
            itemList = new ArrayList();

            //---STREAM READER
            try
            {
                FileStream fs = new FileStream(@"item.txt", FileMode.Open);
                StreamReader readin = new StreamReader(fs);
                while (!readin.EndOfStream)
                {
                    string[] text = readin.ReadLine().Split('|');
                    dgvItems.Rows.Add(text[0], text[1], text[10]); //Place Item at DGV
                    itemList.Add(new Item(text[0], text[1], double.Parse(text[2]), double.Parse(text[3]), double.Parse(text[4]),
                                          int.Parse(text[5]), text[6], text[7], text[8], text[9],
                                          text[10], text[11], text[12], text[13], text[14])); //Recreate the Item
                    //MessageBox.Show("Item data added.");
                }
                readin.Close();
                fs.Close();
            }
            catch (Exception /*e*/) { }

            /* //TEST CODE (For the purpose of customizing the DGV and checking out its appearance)
            dgvItems.Rows.Add("000000", "Aluminum Wire Bonders A", "Supplier A");
            dgvItems.Rows.Add("000001", "Vacuum Sealer A", "Supplier A");
            dgvItems.Rows.Add("000002", "Paper Tapes A", "Supplier A");
            dgvItems.Rows.Add("000003", "Mold Press A", "Supplier A"); */
        }

        private void ItemsMainScreen_Load(object sender, EventArgs e)
        {
            cbbFilterBy.SelectedIndex = 0; //Sets the default combobox value to "Filter by..."
        }

        //-----------------
        // STREAM WRITER  |
        //-----------------
        private void saveItemData()
        {
            try
            {
                FileStream fs = new FileStream(@"item.txt", FileMode.Create);
                StreamWriter writeout = new StreamWriter(fs);

                for (int i = 0; i < itemList.Count; i++)
                {
                    Item item = (Item)itemList[i]; //Casting. So that I can retrieve attribute values from this specific Customer.
                    writeout.WriteLine(item.PartNumber + "|"
                                   + item.ItemName + "|"
                                   + item.SupplierUnitPrice + "|"
                                   + item.Markup + "|"
                                   + item.ReicUnitPrice + "|"
                                   + item.Moq + "|"
                                   + item.Uom + "|"
                                   + item.FromDateNoTime + "|"
                                   + item.ToDateNoTime + "|"
                                   + item.ItemDescription + "|"
                                   + item.SupplierName + "|"
                                   + item.SupplierPerson + "|"
                                   + item.SupplierNumber + "|"
                                   + item.SupplierEmail + "|"
                                   + item.SupplierAddress);
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
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Item_AddForm iaf = new Item_AddForm();
            iaf.ShowDialog();
            string FromDateNoTime = iaf.FromDate.ToShortDateString();
            string ToDateNoTime = iaf.ToDate.ToShortDateString();

            if (iaf.Cancel == false) //Meaning, will add the Item. If Cancel is true, nothing happens.
            {
                //---ADD the new Item to the ArrayList
                itemList.Add(new Item(iaf.PartNumber,
                              iaf.ItemName,
                              double.Parse(iaf.SupplierUnitPrice),
                              int.Parse(iaf.Markup),
                              double.Parse(iaf.ReicUnitPrice),
                              int.Parse(iaf.Moq),
                              iaf.Uom,
                              FromDateNoTime,
                              ToDateNoTime,
                              iaf.ItemDescription,
                              iaf.SupplierName,
                              iaf.SupplierPerson,
                              iaf.SupplierNumber,
                              iaf.SupplierEmail,
                              iaf.SupplierAddress));

                //---DISPLAY the newly added Item in the Main Screen DGV
                dgvItems.Rows.Add(iaf.PartNumber, iaf.ItemName, iaf.SupplierName);

                //Streamwriter
                saveItemData();
            }
        }

        private void btnAddItem_MouseEnter(object sender, EventArgs e)
        { btnAddItem.BackgroundImage = Properties.Resources.ButtonAddItemHover; }

        private void btnAddItem_MouseLeave(object sender, EventArgs e)
        { btnAddItem.BackgroundImage = Properties.Resources.ButtonAddItem; }

        //---------------------------
        // VIEW ITEM BUTTON METHODS  |
        //---------------------------
        private void btnViewItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i] != null)
                {
                    Item item = (Item)itemList[i];

                    if (item.PartNumber == dgvItems.SelectedRows[0].Cells[0].Value.ToString())
                    {
                        //---DISPLAY the view form
                        Item_ViewForm ivf = new Item_ViewForm();
                        ivf.PartNumbertoView = item.PartNumber;
                        ivf.ItemNametoView = item.ItemName;
                        ivf.SupplierUnitPricetoView = (item.SupplierUnitPrice).ToString();
                        ivf.MarkuptoView = (item.Markup).ToString();
                        ivf.ReicUnitPricetoView = (item.ReicUnitPrice).ToString();
                        ivf.MoqtoView = (item.Moq).ToString();
                        ivf.UomtoView = item.Uom;
                        ivf.FromDatetoView = item.FromDateNoTime;
                        ivf.ToDatetoView = item.ToDateNoTime;
                        ivf.ItemDescriptiontoView = item.ItemDescription;
                        ivf.SupplierNametoView = item.SupplierName;
                        ivf.SupplierPersontoView = item.SupplierPerson;
                        ivf.SupplierNumbertoView = item.SupplierNumber;
                        ivf.SupplierEmailtoView = item.SupplierEmail;
                        ivf.SupplierAddresstoView = item.SupplierAddress;

                        ivf.ShowDialog();

                        //---UPDATE values of Item
                        if (ivf.Cancel == false)
                        {
                            item.PartNumber = ivf.PartNumbertoView;
                            item.ItemName = ivf.ItemNametoView;
                            item.SupplierUnitPrice = double.Parse(ivf.SupplierUnitPricetoView);
                            item.Markup = double.Parse(ivf.MarkuptoView);
                            //item.ReicUnitPrice = ivf.ReicUnitPricetoView;
                            item.Moq = int.Parse(ivf.MoqtoView);
                            item.Uom = ivf.UomtoView;
                            item.FromDateNoTime = ivf.FromDatetoView;
                            item.ToDateNoTime = ivf.ToDatetoView;
                            item.ItemDescription = ivf.ItemDescriptiontoView;
                            item.SupplierName = ivf.SupplierNametoView;
                            item.SupplierPerson = ivf.SupplierPersontoView;
                            item.SupplierNumber = ivf.SupplierNumbertoView;
                            item.SupplierEmail = ivf.SupplierEmailtoView;
                            item.SupplierAddress = ivf.SupplierAddresstoView;

                            //Update DGV values
                            dgvItems.SelectedRows[0].Cells[0].Value = ivf.PartNumbertoView;
                            dgvItems.SelectedRows[0].Cells[1].Value = ivf.ItemNametoView;
                            dgvItems.SelectedRows[0].Cells[2].Value = ivf.SupplierNametoView;

                            //Filestream
                            saveItemData();

                            //---MESSAGEBOX FOR DEBUG PURPOSES
                            MessageBox.Show("oh yan updated na yan ah.");
                        }
                    }
                }
            }
        } //End of private void=

        private void btnViewItem_MouseEnter(object sender, EventArgs e)
        { btnViewItem.BackgroundImage = Properties.Resources.ButtonViewItemHover; }

        private void btnViewItem_MouseLeave(object sender, EventArgs e)
        { btnViewItem.BackgroundImage = Properties.Resources.ButtonViewItem; }

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
