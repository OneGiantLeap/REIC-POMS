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
        private MySQLDatabaseDriver sql;
        ArrayList itemList;
        ArrayList supplierList;

        public Item_MainScreen()
        {
            InitializeComponent();
            sql = new MySQLDatabaseDriver();
            itemList = new ArrayList();
            supplierList = new ArrayList();
            sql.SelectAllItemsDGV(dgvItems);
            sql.SelectAllItems(itemList);
        }

        private void ItemsMainScreen_Load(object sender, EventArgs e)
        {
            cbbFilterBy.SelectedIndex = 0; //Sets the default combobox value to "Filter by..."
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
           //     sql.Backup();
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
                              iaf.ItemDescription,
                              double.Parse(iaf.SupplierUnitPrice),
                              int.Parse(iaf.Markup),
                              double.Parse(iaf.ReicUnitPrice),
                              int.Parse(iaf.Moq),
                              iaf.Uom,
                              FromDateNoTime,
                              ToDateNoTime,
                              iaf.SupplierIDFK
                              ));

                Item newItem = (Item)itemList[(itemList.Count - 1)]; //Casting
                sql.InsertItem(newItem);
                //---DISPLAY the newly added Item in the Main Screen DGV
                dgvItems.Rows.Add(iaf.PartNumber, iaf.ItemName, iaf.SupplierName);

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
                        ivf.ItemDescriptiontoView = item.ItemDescription;
                        ivf.SupplierUnitPricetoView = (item.SupplierUnitPrice).ToString("0.00");
                        ivf.MarkuptoView = (item.Markup).ToString();
                        ivf.ReicUnitPricetoView = (item.ReicUnitPrice).ToString("0.00");
                        ivf.MoqtoView = (item.Moq).ToString();
                        ivf.UomtoView = item.Uom;
                        ivf.FromDatetoView = item.FromDateNoTime;
                        ivf.ToDatetoView = item.ToDateNoTime;

                        Supplier s = sql.SelectSupplierDetails(item.SupplierID);
                        ivf.SupplierNametoView = s.SupplierName;
                        ivf.SupplierPersontoView = s.SupplierPerson;
                        ivf.SupplierNumbertoView = s.SupplierNumber;
                        ivf.SupplierEmailtoView = s.SupplierEmail;
                        ivf.SupplierAddresstoView = s.SupplierAddress;
                      
                        ivf.ShowDialog();

                        //---UPDATE values of Item
                        if (ivf.Cancel == false)
                        {
                                                      
                            item.PartNumber = ivf.PartNumbertoView;
                            item.ItemName = ivf.ItemNametoView;
                            item.ItemDescription = ivf.ItemDescriptiontoView;
                            item.SupplierUnitPrice = double.Parse(ivf.SupplierUnitPricetoView);
                            item.Markup = double.Parse(ivf.MarkuptoView);
                            item.ReicUnitPrice = double.Parse(ivf.ReicUnitPricetoView);
                            item.Moq = int.Parse(ivf.MoqtoView);
                            item.Uom = ivf.UomtoView;
                            item.FromDateNoTime = ivf.FromDatetoView;// the left wing does the saving in the filestream, the right wing gets input from the edit.
                            item.ToDateNoTime = ivf.ToDatetoView;
                            
                                                                               
                            s.SupplierName = ivf.SupplierNametoView;
                            s.SupplierPerson = ivf.SupplierPersontoView;
                            s.SupplierNumber = ivf.SupplierNumbertoView;
                            s.SupplierEmail = ivf.SupplierEmailtoView;
                            s.SupplierAddress = ivf.SupplierAddresstoView;
                            
                            item.SupplierID = sql.SelectSupplierID(s.SupplierName);

                            //Update DGV values
                            dgvItems.SelectedRows[0].Cells[0].Value = ivf.PartNumbertoView;
                            dgvItems.SelectedRows[0].Cells[1].Value = ivf.ItemNametoView;
                            dgvItems.SelectedRows[0].Cells[2].Value = ivf.SupplierNametoView;
                           
                            sql.UpdateItem(item);

                            
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
            string partNumber = (txtSearch.Text.ToString());
            string filterSearch = cbbFilterBy.Text.ToString();

            if (filterSearch == "Filter by...")
            {
                MessageBox.Show("Choose Filter option", "No Filter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           /* if (inputSearch.Length == 0)
            {
                MessageBox.Show("What do you want to search", "Nothing to Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            if (filterSearch == "Item Name")
            {
                
             //   sql.SearchItems(dgvItems, itemName);
            }
            else if (filterSearch == "Part Number")
            {
                sql.SearchPNItems(dgvItems, partNumber);
            
            }

            
            //Insert code that changes "Search for..." to blank when textbox is clicked
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Search for...";
            cbbFilterBy.SelectedIndex = 0; //Sets the combobox value to "Filter by..."
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string input = (txtSearch.Text.ToString());
            if (input.Length == 0)
            {
                sql.SelectAllItemsDGV(dgvItems);
            }
        }
    }
}
