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
    public partial class Item_MainScreen : Form
    {

        ArrayList itemList;

        public Item_MainScreen()
        {
            itemList = new ArrayList();

            InitializeComponent();
            //ADJUST DATAGRIDVIEW COLUMN ALIGNMENT
            dgvItems.Columns["PartNo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //Center column header
            dgvItems.Columns["PartNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; //Center column contents

            //TEST CODE (For the purpose of customizing the DGV and checking out its appearance)
            dgvItems.Rows.Add("000000", "Aluminum Wire Bonders A", "Supplier A");
            dgvItems.Rows.Add("000001", "Vacuum Sealer A", "Supplier A");
            dgvItems.Rows.Add("000002", "Paper Tapes A", "Supplier A");
            dgvItems.Rows.Add("000003", "Mold Press A", "Supplier A");
        }

        private void ItemsMainScreen_Load(object sender, EventArgs e)
        {
            cbbFilterBy.SelectedIndex = 0; //Sets the default combobox value to "Filter by..."
        }

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

        }

        private void btnCustomers_MouseEnter(object sender, EventArgs e)
        {
            btnCustomers.BackgroundImage = Properties.Resources.ButtonHoverCustomers;
        }

        private void btnCustomers_MouseLeave(object sender, EventArgs e)
        {
            btnCustomers.BackgroundImage = Properties.Resources.ButtonInactiveCustomers;
        }

        //----------------------------------------------
        // REQUEST FOR PRICE QUOTATION NAVBAR METHODS  |
        //----------------------------------------------
        private void btnRFQ_Click(object sender, EventArgs e)
        {

        }

        private void btnRFQ_MouseEnter(object sender, EventArgs e)
        {
            btnRFQ.BackgroundImage = Properties.Resources.ButtonHoverRFQ;
        }

        private void btnRFQ_MouseLeave(object sender, EventArgs e)
        {
            btnRFQ.BackgroundImage = Properties.Resources.ButtonInactiveRFQ;
        }

        //----------------------------------
        // PRICE QUOTATION NAVBAR METHODS  |
        //----------------------------------
        private void btnPQ_Click(object sender, EventArgs e)
        {

        }

        private void btnPQ_MouseEnter(object sender, EventArgs e)
        {
            btnPQ.BackgroundImage = Properties.Resources.ButtonHoverPQ;
        }

        private void btnPQ_MouseLeave(object sender, EventArgs e)
        {
            btnPQ.BackgroundImage = Properties.Resources.ButtonInactivePQ;
        }

        //---------------------------------
        // PURCHASE ORDER NAVBAR METHODS  |
        //---------------------------------
        private void btnPO_Click(object sender, EventArgs e)
        {

        }

        private void btnPO_MouseEnter(object sender, EventArgs e)
        {
            btnPO.BackgroundImage = Properties.Resources.ButtonHoverPO;
        }

        private void btnPO_MouseLeave(object sender, EventArgs e)
        {
            btnPO.BackgroundImage = Properties.Resources.ButtonInactivePO;
        }

        //---------------------------------------------------
        // SALES INVOICE & DELIVERY RECEIPT NAVBAR METHODS  |
        //---------------------------------------------------
        private void btnSIDR_Click(object sender, EventArgs e)
        {

        }

        private void btnSIDR_MouseEnter(object sender, EventArgs e)
        {
            btnSIDR.BackgroundImage = Properties.Resources.ButtonHoverSIDR;
        }

        private void btnSIDR_MouseLeave(object sender, EventArgs e)
        {
            btnSIDR.BackgroundImage = Properties.Resources.ButtonInactiveSIDR;
        }

        //-----------------------------------------------------
        // SALES PERFORMANCE REPORT & SUMMARY NAVBAR METHODS  |
        //-----------------------------------------------------
        private void btnSPRS_Click(object sender, EventArgs e)
        {

        }

        private void btnSPRS_MouseEnter(object sender, EventArgs e)
        {
            btnSPRS.BackgroundImage = Properties.Resources.ButtonHoverSPRS;
        }

        private void btnSPRS_MouseLeave(object sender, EventArgs e)
        {
            btnSPRS.BackgroundImage = Properties.Resources.ButtonInactiveSPRS;
        }

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
        {
            btnSignOut.BackgroundImage = Properties.Resources.ButtonHoverSignOut;
        }

        private void btnSignOut_MouseLeave(object sender, EventArgs e)
        {
            btnSignOut.BackgroundImage = Properties.Resources.ButtonInactiveSignOut;
        }

        //---------------------------
        // ADD ITEM BUTTON METHODS  |
        //---------------------------
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Item_AddForm iaf = new Item_AddForm();
            iaf.ShowDialog();
            string FromDateNoTime = iaf.FromDate.ToShortDateString();
            string ToDateNoTime = iaf.ToDate.ToShortDateString();
            
            if (iaf.Cancel == false)
            {
                itemList.Add(new Item(iaf.PartNumber,
                              iaf.ItemName,
                              Double.Parse(iaf.SupplierUnitPrice),
                              int.Parse(iaf.Markup),
                              Double.Parse(iaf.ReicUnitPrice),
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
                    
                    dgvItems.Rows.Add(iaf.PartNumber, iaf.ItemName, iaf.SupplierName);
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

        private void btnAddItem_MouseEnter(object sender, EventArgs e)
        {
            btnAddItem.BackgroundImage = Properties.Resources.ButtonAddItemHover;
        }

        private void btnAddItem_MouseLeave(object sender, EventArgs e)
        {
            btnAddItem.BackgroundImage = Properties.Resources.ButtonAddItem;
        }

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


                        if (ivf.Cancel == false) 
                        {
                            
                            item.PartNumber = ivf.PartNumbertoView;
                            item.ItemName = ivf.ItemNametoView;
                            item.SupplierUnitPrice = double.Parse(ivf.SupplierUnitPricetoView);
                            item.Markup = double.Parse(ivf.MarkuptoView);
                           // itemList[i].ReicUnitPrice = ivf.ReicUnitPricetoView;
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
                            dgvItems.SelectedRows[0].Cells[0].Value = ivf.PartNumbertoView;
                            dgvItems.SelectedRows[0].Cells[1].Value = ivf.ItemNametoView;
                            dgvItems.SelectedRows[0].Cells[2].Value = ivf.SupplierNametoView;
                       
                            MessageBox.Show("oh yan updated na yan ah.");
                            
                        }
                    }
                } 
            } 
        }
    


        private void btnViewItem_MouseEnter(object sender, EventArgs e)
        {
            btnViewItem.BackgroundImage = Properties.Resources.ButtonViewItemHover;
        }

        private void btnViewItem_MouseLeave(object sender, EventArgs e)
        {
            btnViewItem.BackgroundImage = Properties.Resources.ButtonViewItem;
        }

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
