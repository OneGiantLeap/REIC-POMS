using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization; //Added for timeparsing
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REIC_POMS
{
    public partial class SPR_MainScreen : Form
    {   
        //ATTRIBUTES
        private MySQLDatabaseDriver sql;

        public SPR_MainScreen()
        {
            InitializeComponent();
            sql = new MySQLDatabaseDriver();

            cbbFromMonth.SelectedIndex = 0; //"Select Month"
            txtToMonth.Text = DateTime.Now.ToString("MMMM"); //Format shows full month name
            txtToYear.Text = DateTime.Now.Year.ToString();

            //---ADJUST DATAGRIDVIEW APPEARANCE
            //REQUESTS FOR PRICE QUOTATION
            dgvRFQStatus.Columns["RequestDate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRFQStatus.Columns["RFQNo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvRFQStatus.Columns["RFQNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRFQStatus.Columns["RequestDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //PRICE QUOTATIONS
            dgvPQStatus.Columns["Date"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPQStatus.Columns["PQNo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPQStatus.Columns["ValidityPeriod"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPQStatus.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPQStatus.Columns["PQNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPQStatus.Columns["ValidityPeriod"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //PURCHASE ORDERS
            dgvPOStatus.Columns["POOrderDate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPOStatus.Columns["PODeliveryDate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPOStatus.Columns["PONo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPOStatus.Columns["POOrderDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPOStatus.Columns["PODeliveryDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPOStatus.Columns["PONo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            {
                sql.Backup();
                Close(); //Exit the program
            }
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
            this.Hide(); //Added to actually close the Main Screen instead of it being open in the background
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
        { /*Nothing to add here*/ }

        private void btnSPRS_MouseEnter(object sender, EventArgs e)
        { /*Nothing to add here*/ }

        private void btnSPRS_MouseLeave(object sender, EventArgs e)
        { /*Nothing to add here*/ }

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

        //--------------------------------------------------------
        // SALES TAB METHODS - FORM ELEMENTS, TO DATE GENERATION |
        //--------------------------------------------------------
        private void radMonthly_CheckedChanged(object sender, EventArgs e)
        {
            cbbFromMonth.Enabled = true;
            nupFromYear.Enabled = true;
            cbbFromMonth.SelectedIndex = 0; //"Select Month"
            nupFromYear.Text = DateTime.Now.Year.ToString(); //Can't set a NumericUpDown to "YYYY" (Would've liked that)
        }

        private void radAnnually_CheckedChanged(object sender, EventArgs e)
        {
            cbbFromMonth.Enabled = true;
            nupFromYear.Enabled = true;
            cbbFromMonth.SelectedIndex = 0; //"Select Month"
            txtToMonth.Text = DateTime.Now.ToString("MMMM");
            txtToYear.Text = DateTime.Now.Year.ToString();
        }

        private void cbbFromMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateToDate("cbbFromMonth");
        }

        private void nupFromYear_ValueChanged(object sender, EventArgs e)
        {
            GenerateToDate("nupFromYear");
        }

        /// <summary>
        /// Automatically sets the To Date values when the From Date has been chosen.
        /// NOTE: Monthly Sales need adjustment of both To Month and To Year.
        /// Annual Sales just need adjustment of To Month. There should be a minimum of 3 years for the Annual Sales range.
        /// </summary>
        /// <param name="controlType">What form element was changed? cbbFromMonth or nupFromYear?</param>
        private void GenerateToDate(string controlType)
        {
            if (cbbFromMonth.SelectedIndex != 0) //"Select Month" is NOT selected in the options
            {
                //Get From Date values
                int fromMonth = DateTime.ParseExact(cbbFromMonth.Text, "MMMM", CultureInfo.InvariantCulture).Month;
                int fromYear;
                bool isFromYearInteger = int.TryParse(nupFromYear.Text, out fromYear);
                if (isFromYearInteger == false)
                {
                    MessageBox.Show("From Year must be an integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime fromDate = new DateTime(fromYear, fromMonth, 1); //Just placed the "1" day to complete the parameters (just need Year and Month, really).

                //Generate To Date
                DateTime toDate = fromDate.AddMonths(11);

                //Set To Month value
                txtToMonth.Text = toDate.ToString("MMMM");

                //Set To Year value (For Monthly Sales; Annual Sales don't need to adjust To Year)
                if (radMonthly.Checked == true)
                {
                    if (controlType == "cbbFromMonth")
                    {
                        txtToYear.Text = toDate.ToString("yyyy");
                    }
                    else if (controlType == "nupFromYear") //Have to account for user clicks on the NumericUpDown
                    {
                        if (cbbFromMonth.Text == "January")
                        {
                            txtToYear.Text = nupFromYear.Value.ToString();
                        }
                        else
                        {
                            txtToYear.Text = (nupFromYear.Value + 1).ToString();
                        }
                    }
                }
            }
            else //"Select Month"
            {
                txtToMonth.Text = "N/A";
                txtToYear.Text = "N/A";
            }
        }



        private void btnShowGraph_Click(object sender, EventArgs e)
        {
            if (cbbFromMonth.Text == "Select Month")
            {
                MessageBox.Show("Please select a month for the From Month field.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //----------------
            // MONTHLY SALES |
            //----------------
            if (radMonthly.Checked == true)
            {
                //Display relevant visuals and clear contents
                graphAnnually.Hide();
                dgvAnnualSales.Hide();
                graphMonthly.Series["Sales"].Points.Clear();
                dgvMonthlySales_Left.Rows.Clear();
                dgvMonthlySales_Right.Rows.Clear();

                //Select Statement
                int fromMonth = DateTime.ParseExact(cbbFromMonth.Text, "MMMM", CultureInfo.InvariantCulture).Month;
                int fromYear = int.Parse(nupFromYear.Value.ToString());
                DateTime fromDate = new DateTime(fromYear, fromMonth, 1);
                double[] monthlySales = new double[12]; //Values filled by SQL
                sql.SelectMonthlySales(fromDate, monthlySales);

                //Display results
                for (int i = 0; i < 12; i++)
                {
                    DateTime dateToCheck = fromDate.AddMonths(i);
                    string monthXValue = dateToCheck.ToString("MMMM");
                    graphMonthly.Series["Sales"].Points.AddXY(monthXValue, monthlySales[i]);

                    if (i < 6)
                    {
                        dgvMonthlySales_Left.Rows.Add(monthXValue, monthlySales[i]);
                    }
                    else
                    {
                        dgvMonthlySales_Right.Rows.Add(monthXValue, monthlySales[i]);
                    }
                }
                graphMonthly.Show();
                dgvMonthlySales_Left.Show();
                dgvMonthlySales_Right.Show();
            }

            //---------------
            // ANNUAL SALES |
            //---------------
            if (radAnnually.Checked == true)
            {
                //Validation for date range (Already accounts for non-January-to-December fiscal years)
                int fromMonth = DateTime.ParseExact(cbbFromMonth.Text, "MMMM", CultureInfo.InvariantCulture).Month;
                int fromYear = int.Parse(nupFromYear.Text);
                int toMonth = DateTime.ParseExact(txtToMonth.Text, "MMMM", CultureInfo.InvariantCulture).Month;
                int toYear = int.Parse(txtToYear.Text);
                DateTime fromDate = new DateTime(fromYear, fromMonth, 1);
                DateTime toDate = new DateTime(toYear, toMonth, 1).AddMonths(1).AddDays(-1); //Set Day value as last day of the month

                //Reference: http://stackoverflow.com/questions/4127363/date-difference-in-years-c-sharp
                TimeSpan span = toDate - fromDate;
                DateTime zeroTime = new DateTime(1, 1, 1); //For calculating the date difference in years
                int range = (zeroTime + span).Year - 1;
                if (range < 3)
                {
                    MessageBox.Show("Annual Sales reports cover at least 3 years worth of sales. Please adjust your dates.", "Date Range Too Short", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Display relevant visuals and clear contents
                graphMonthly.Hide();
                dgvMonthlySales_Left.Hide();
                dgvMonthlySales_Right.Hide();
                graphAnnually.Series["Sales"].Points.Clear();
                dgvAnnualSales.Rows.Clear();

                //Select Statement
                double[] annualSales = new double[range];
                sql.SelectAnnualSales(fromDate, toDate, range, annualSales);

                //Display results
                for (int i = 0; i < range; i++)
                {
                    DateTime dateToCheck = fromDate.AddYears(i);
                    string yearXValue = dateToCheck.ToString("yyyy");
                    graphAnnually.Series["Sales"].Points.AddXY(yearXValue, annualSales[i]);
                    dgvAnnualSales.Rows.Add(yearXValue, annualSales[i]);
                }

                graphAnnually.Show();
                dgvAnnualSales.Show();
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (cbbFromMonth.Text == "Select Month")
            {
                MessageBox.Show("Please select a month.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (radMonthly.Checked == true)
            {
                //SPR_MonthlySales_PrintScreen ms = new SPR_MonthlySales_PrintScreen();
                //ms.ShowDialog();
            }

            if (radAnnually.Checked == true)
            {
                //SPR_AnnualSales_PrintScreen as = new SPR_AnnualSales_PrintScreen();
                //as.ShowDialog();
            }
        }

        //--------------------------
        // STATUS: RFQ TAB METHODS |
        //--------------------------
        private void radPendingRFQ_CheckedChanged(object sender, EventArgs e)
        {
            dgvRFQStatus.Rows.Clear();
            sql.SelectPendingRFQ(dgvRFQStatus);
        }

        private void radCompletedRFQ_CheckedChanged(object sender, EventArgs e)
        {
            dgvRFQStatus.Rows.Clear();
            sql.SelectCompletedRFQ(dgvRFQStatus);
        }

        private void radAllRFQ_CheckedChanged(object sender, EventArgs e)
        {
            dgvRFQStatus.Rows.Clear();
            sql.SelectAllRFQSPR(dgvRFQStatus);
        }

        private void btnGenerateReportRFQ_Click(object sender, EventArgs e)
        {
            if ((radPendingRFQ.Checked == false) && (radCompletedRFQ.Checked == false) && (radAllRFQ.Checked == false))
            {
                MessageBox.Show("Please select if you want to view pending, completed, or all requests for price quotation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radPendingRFQ.Checked == true)
            {
                SPR_RFQPending_PrintScreen rfqp = new SPR_RFQPending_PrintScreen();
                rfqp.ShowDialog();
            }
            if (radCompletedRFQ.Checked == true)
            {
                SPR_RFQCompleted_PrintScreen rfqc = new SPR_RFQCompleted_PrintScreen();
                rfqc.ShowDialog();
            }
            if (radAllRFQ.Checked == true)
            {
                SPR_RFQAll_PrintScreen rfq = new SPR_RFQAll_PrintScreen();
                rfq.ShowDialog();
            }
        }

        //-------------------------
        // STATUS: PQ TAB METHODS |
        //-------------------------
        private void radPendingPQ_CheckedChanged(object sender, EventArgs e)
        {
            dgvPQStatus.Rows.Clear();
            sql.SelectPendingPQ(dgvPQStatus);
        }

        private void radCompletedPQ_CheckedChanged(object sender, EventArgs e)
        {
            dgvPQStatus.Rows.Clear();
            sql.SelectCompletedPQ(dgvPQStatus);
        }

        private void radAllPQ_CheckedChanged(object sender, EventArgs e)
        {
            dgvPQStatus.Rows.Clear();
            sql.SelectAllPQSPR(dgvPQStatus);
        }


        private void btnGenerateReportPQ_Click(object sender, EventArgs e)
        {
            if ((radPendingPQ.Checked == false) && (radCompletedPQ.Checked == false) && (radAllPQ.Checked == false))
            {
                MessageBox.Show("Please select if you want to view pending, completed, or all price quotations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radPendingPQ.Checked == true)
            {
                SPR_PQPending_PrintScreen pqp = new SPR_PQPending_PrintScreen();
                pqp.ShowDialog();
            }
            if (radCompletedPQ.Checked == true)
            {
                SPR_PQCompleted_PrintScreen pqc = new SPR_PQCompleted_PrintScreen();
                pqc.ShowDialog();
            }
            if (radAllPQ.Checked == true)
            {
                SPR_PQAll_PrintScreen pq = new SPR_PQAll_PrintScreen();
                pq.ShowDialog();
            }
        }

        //-------------------------
        // STATUS: PO TAB METHODS |
        //-------------------------
        private void radPendingPO_CheckedChanged(object sender, EventArgs e)
        {
            dgvPOStatus.Rows.Clear();
            sql.SelectPendingPO(dgvPOStatus);
        }

        private void radCompletedPO_CheckedChanged(object sender, EventArgs e)
        {
            dgvPOStatus.Rows.Clear();
            sql.SelectCompletedPO(dgvPOStatus);
        }

        private void radAllPO_CheckedChanged(object sender, EventArgs e)
        {
            dgvPOStatus.Rows.Clear();
            sql.SelectAllPOSPR(dgvPOStatus);
        }

        private void btnGenerateReportPO_Click(object sender, EventArgs e)
        {
            if ((radPendingPO.Checked == false) && (radCompletedPO.Checked == false) && (radAllPO.Checked == false))
            {
                MessageBox.Show("Please select if you want to view pending, completed, or all purchase orders.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radPendingPO.Checked == true)
            {
                SPR_POPending_PrintScreen pop = new SPR_POPending_PrintScreen();
                pop.ShowDialog();
            }
            if (radCompletedPO.Checked == true)
            {
                SPR_POCompleted_PrintScreen poc = new SPR_POCompleted_PrintScreen();
                poc.ShowDialog();
            }
            if (radAllPO.Checked == true)
            {
                SPR_POAll_PrintScreen po = new SPR_POAll_PrintScreen();
                po.ShowDialog();
            }
        }
    }
}
