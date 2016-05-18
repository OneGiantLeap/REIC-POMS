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
    public partial class PQ_CreateFromRFQForm : Form
    {
        private MySQLDatabaseDriver sql;
        private ArrayList pqList;
        private ArrayList selectedRFQList;
        private ArrayList rfqList;


        public PQ_CreateFromRFQForm()
        {
            InitializeComponent();
            sql = new MySQLDatabaseDriver();
            pqList = new ArrayList();


            rfqList = new ArrayList();
            selectedRFQList = new ArrayList();
            sql.SelectAllRFQDGV(dgvRFQSelection);
            sql.SelectAllRFQ(rfqList);

        }

        public bool cancel;

        public bool Cancel
        {
            get { return cancel; }
        }

        private void dgvRFQSelection_CellClick(object sender, DataGridViewCellEventArgs e)
        { /*When you click on a row of the RFQ Selection DGV, RFQ no should appear in the text*/
            DataGridViewRow selectedRow = dgvRFQSelection.SelectedRows[0]; //Store row number of selected row
            txtRFQNo.Text = selectedRow.Cells["RFQNo"].Value.ToString(); //Set the content of RFQNo textbox to the selected row's rfq
        }

        /* private void btnOk_Click(object sender, EventArgs e)
         {

         } */
       /* private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
        }
        */


        private void btnAddtoQuote_Click(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = dgvRFQSelection.SelectedRows[0]; //Store row number of selected row
            for (int i = 0; i < dgvRFQSelected.RowCount; i++) //Loop through dgv of all Selected RFQs
            {
                //Compares the RFQ no of the selected RFQs in dgvRFQSelection and the rows of dgvRFQSelected
                if (selectedRow.Cells["RFQNo"].Value == dgvRFQSelected.Rows[i].Cells["SelectedRFQNo"].Value)
                {
                    MessageBox.Show("That Request for Price Quotation has already been added.", "Item Already in RFQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //Enables User to interact with the form
                }
            }

            if (dgvRFQSelected.Rows.Count > 0)
            {
                if (selectedRow.Cells["Customer"].Value.Equals(dgvRFQSelected.Rows[0].Cells["SelectedCustomer"].Value))
                {
                    dgvRFQSelected.Rows.Add(selectedRow.Cells["RFQNo"].Value,
                                         selectedRow.Cells["RequestDate"].Value,
                                         selectedRow.Cells["Supplier"].Value,
                                         selectedRow.Cells["Customer"].Value);
                }
                else
                {
                    MessageBox.Show("That Request for Price Quotation has a different Customer.", "Invalid RFQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //Enables User to interact with the form
                }
            }

            else if (dgvRFQSelected.Rows.Count == 0)
            {
                dgvRFQSelected.Rows.Add(selectedRow.Cells["RFQNo"].Value,
                    selectedRow.Cells["RequestDate"].Value,
                    selectedRow.Cells["Supplier"].Value,
                    selectedRow.Cells["Customer"].Value);
            }
        }

        private void btnRemoveRFQ_Click(object sender, EventArgs e)
        {
            if (dgvRFQSelected.Rows.Count == 0)
            {
                MessageBox.Show("There are no Request for Price Quotation to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvRFQSelected.Rows.RemoveAt(dgvRFQSelected.CurrentRow.Index);
        }

        private void btnClearRFQ_Click(object sender, EventArgs e)
        {
            if (dgvRFQSelected.Rows.Count == 0)
            { MessageBox.Show("There are no Request for Price Quotation to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            dgvRFQSelected.Rows.Clear();
        }

        private void btnCreatePQ_Click(object sender, EventArgs e)
        {
            
            if (dgvRFQSelected.Rows.Count == 0)
                {
                    MessageBox.Show("Please include Request for Price Quotation.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            this.Close();

            PQ_CreateForm pf = new PQ_CreateForm();
            

            for (int i = 0; i < dgvRFQSelected.RowCount; i++)
            {
               
               
                    string rfqNo;
                    DataGridViewRow row = dgvRFQSelected.Rows[i];
                    rfqNo = (row.Cells["SelectedRFQNo"].Value).ToString(); //get the RFQNo of the rfq selected
                    RFQ r = sql.SelectRFQDetails(rfqNo); //from the RFQNo taken, get its details
                    selectedRFQList.Add(new RFQ(r.RFQNo, r.RequestDate, r.PaymentTerms, r.DeliveryTerms, r.CustomerID, r.SupplierID, r.PQNo)); //put in an ArrayList the details taken
                    pf.RFQNo = rfqNo;

                    string year = DateTime.Now.ToString("yy");
                    string month = DateTime.Now.ToString("MM");
                    int pqCount = sql.GetRowCount("pq_t", year, month);
                    string generatedPQNo = year + month + "-" + (pqCount + 1).ToString("D3");
                    pf.PQNo = generatedPQNo;

                    pf.PaymentTerms = r.PaymentTerms;
                    pf.DeliveryTerms = r.DeliveryTerms;

                    Customer c = sql.SelectCustomerDetails(r.CustomerID); //to retrieve the details of Customer from MySqlDatabaseDriver
                    pf.CustomerName = c.CustomerName;
                    pf.CustomerPerson = c.CustomerPerson;
                    pf.CustomerNumber = c.CustomerNumber;
                    pf.CustomerEmail = c.CustomerEmail;
                    pf.CustomerAddress = c.CustomerAddress;
                    
                              
               
                pf.ShowDialog();
            }
            
            if (pf.Cancel == false)
            {//if save button were clicked, this will save the pq details in arrayList then in the database
                string FromDateNoTime = pf.FromDate.ToShortDateString();
                string ToDateNoTime = pf.ToDate.ToShortDateString();
                string PQDateNoTime = pf.PQDate.ToShortDateString();
                pqList.Add(new PQ(pf.PQNo,
                                    PQDateNoTime,
                                    FromDateNoTime,
                                    ToDateNoTime,
                                    pf.PaymentTerms,
                                    pf.DeliveryTerms,
                                    pf.BillTo,
                                    pf.ShipTo,
                                    pf.InFavorOf,
                                    double.Parse(pf.TotalAmount),
                                    pf.CustomerIDFK));


                PQ newPQ = (PQ)pqList[(pqList.Count - 1)];
                sql.InsertPQ(newPQ);

                for (int j = 0; j < pf.PQOrderLineList.Count; j++)
                    {
                        PQ_OrderLine pol = (PQ_OrderLine)pf.PQOrderLineList[j];
                        sql.InsertPQOrderLine(pol);
                        MessageBox.Show("OrderLine added to comprehensive list: " + pol.PQNo + ", " + pol.PartNumber + ", " + pol.ReicUnitPrice + "," + pol.Quantity + "," + pol.ItemTotal);
                    }

                //---OPEN THE PQ Printout Print Preview
                if (pf.InFavorOf == "Supplier")
                {
                    PQ_PrintScreen_IFOSupplier pq = new PQ_PrintScreen_IFOSupplier();
                    pq.PQNo = pf.PQNo;
                    pq.FirstTime = false;
                    pq.ShowDialog();
                }
                else
                {
                    PQ_PrintScreen pq = new PQ_PrintScreen();
                    pq.PQNo = pf.PQNo;
                    pq.FirstTime = false;
                    pq.ShowDialog();
                }
            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }
    }
    }

