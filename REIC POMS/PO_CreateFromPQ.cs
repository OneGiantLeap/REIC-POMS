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
    public partial class PO_CreateFromPQ : Form
    {

        private MySQLDatabaseDriver sql;
        private ArrayList itemList;
        private ArrayList selectedPQList;
        private ArrayList pqOrderLineList;
        private ArrayList pqList;
        private ArrayList poList;
        private int customerIDFK;
        private int supplierIDFK;

        public PO_CreateFromPQ()
        {
            InitializeComponent();

            sql = new MySQLDatabaseDriver();
            pqList = new ArrayList();
            poList = new ArrayList();

            pqOrderLineList = new ArrayList();
            selectedPQList = new ArrayList();
            itemList = new ArrayList();
            sql.PopulatePOFromPQ(dgvPQSelection);
            sql.SelectAllPQ(pqList);
        }
        public bool cancel;

        public bool Cancel
        {
            get { return cancel; }
        }

        /*
        private void btnAddtoSIDR_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvPQSelection.SelectedRows[0]; //Store row number of selected row
            for (int i = 0; i < dgvPQSelected.RowCount; i++) //Loop through dgv of all Selected POs
            {
                //Compares the PO no of the selected POs in dgvPOSelection and the rows of dgvPOSelected
                if (selectedRow.Cells["PONo"].Value == dgvPQSelected.Rows[i].Cells["SelectedPONo"].Value)
                {
                    MessageBox.Show("That Purchase Order has already been added.", "Item Already in PO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //Enables User to interact with the form
                }
            }

            if (dgvPQSelected.Rows.Count > 0)
            {
                if (selectedRow.Cells["Customer"].Value.Equals(dgvPQSelected.Rows[0].Cells["SelectedCustomer"].Value))
                {
                    dgvPQSelected.Rows.Add(selectedRow.Cells["PONo"].Value,
                                         selectedRow.Cells["RequestDate"].Value,
                                         selectedRow.Cells["Supplier"].Value,
                                         selectedRow.Cells["Customer"].Value);
                }
                else
                {
                    MessageBox.Show("That Purchase Order has a different Customer.", "Invalid PO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //Enables User to interact with the form
                }
            }

            else if (dgvPQSelected.Rows.Count == 0)
            {
                dgvPQSelected.Rows.Add(selectedRow.Cells["PONo"].Value,
                    selectedRow.Cells["RequestDate"].Value,
                    selectedRow.Cells["Supplier"].Value,
                    selectedRow.Cells["Customer"].Value);
            }
        }
        */
        private void btnRemovePO_Click(object sender, EventArgs e)
        {
            if (dgvPQSelected.Rows.Count == 0)
            {
                MessageBox.Show("There are no Purchae Orders to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvPQSelected.Rows.RemoveAt(dgvPQSelected.CurrentRow.Index);
        }

        private void btnClearPO_Click(object sender, EventArgs e)
        {
            if (dgvPQSelected.Rows.Count == 0)
            { MessageBox.Show("There are no Purchase Orders to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            dgvPQSelected.Rows.Clear();
        }

        /*   private void btnCreateSIDR_Click(object sender, EventArgs e)
           {
               if (dgvPQSelected.Rows.Count == 0)
               {
                   MessageBox.Show("Please include Purchase Orders.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return;
               }
               this.Close();

               SIDR_CreateForm new_sidr = new SIDR_CreateForm();

               for (int i = 0; i < dgvPQSelected.RowCount; i++)
               {
                   string poNo;
                   DataGridViewRow row = dgvPQSelected.Rows[i];
                   poNo = (row.Cells["SelectedPONo"].Value).ToString();
                   //PO p = sql.SelectPODetails(poNo); //from the PONo taken, get its details
                   //selectedPOList.Add(new PO(p.PONo, p.RequestDate, p.PaymentTerms, p.DeliveryTerms, p.CustomerID, p.SupplierID, p.PONo)); //put in an ArrayList the details taken
                   //new_sidr.PONo = poNo;
                   //originally pf.RFQNo = rfqNo but where did RFQNo come from?

                   string year = DateTime.Now.ToString("yy");
                   string month = DateTime.Now.ToString("MM");
                   //int sidrCount = sql.GetRowCount("po_t", year, month);
                   //string generatedPONo = year + month + "-" + (sidrCount + 1).ToString("D3");
                   //new_sidr.SINo = generatedSINo;

                   //new_sidr.DeliveryTerms = p.DeliveryTerms;

                   //Customer c = sql.SelectCustomerDetails(p.CustomerID); //to retrieve the details of Customer from MySqlDatabaseDriver
                   //new_sidr.CustomerName = c.CustomerName;
                   //new_sidr.CustomerPerson = c.CustomerPerson;
                   //new_sidr.CustomerNumber = c.CustomerNumber;
                   //new_sidr.CustomerEmail = c.CustomerEmail;
                   //new_sidr.CustomerAddress = c.CustomerAddress;



                   new_sidr.ShowDialog();
               }

               if (new_sidr.Cancel == false)
               {
                   //if save button were clicked, this will save the sidr details in arrayList then in the database

                   string SIDRDateNoTime = new_sidr.SIDRDate.ToShortDateString();
                   //poList.Add(new SIDR(new_sidr.SONumber,
                   //                    SIDRDateNoTime,
                   //                    new_sidr.DeliveryTerms,
                   //new_sidr.PONo,
                   //new_sidr.DRNo,
                   //double.Parse(new_sidr.TotalSales),
                   //double.Parse(new_sidr.VATSales),
                   //double.Parse(new_sidr.PercentVAT),
                   //double.Parse(new_sidr.InvoiceTotal),
                   //new_sidr.customerIDFK));
                   //SIDR newSIDR = (SIDR)sidrList[(sidrList.Count - 1)];
                   //sql.InsertSIDR(newSIDR);

                   //SIDR newSIDR = (SIDR)sidrList[(sidrList.Count - 1)];
                   //sql.InsertSIDR(newSIDR);

                   //for (int j = 0; j < new_sidr.SIDROrderLineList.Count; j++)
                   //{
                   //    SIDR_OrderLine sidrol = (SIDR_OrderLine)new_sidr.SIDROrderLineList[j];
                   //    //sql.InsertPOOrderLine(pol);
                   //    MessageBox.Show("OrderLine added to comprehensive list: " + sidrol.SONo + ", " + sidrol.PartNumber + ", " + sidrol.ReicUnitPrice + "," + sidrol.Quantity + "," + sidrol.ItemTotal);
                   //}



               }

           } */

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }

        private void dgvPQSelection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvPQSelection.SelectedRows[0]; //Store row number of selected row
            txtPQNo.Text = selectedRow.Cells["PQNo"].Value.ToString();
        }

        private void btnAddtoPO_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvPQSelection.SelectedRows[0]; //Store row number of selected row
                                                                          /* for (int i = 0; i < dgvPQSelected.RowCount; i++)
                                                                           {

                                                                               if (selectedRow.Cells["PQNo"].Value == dgvPQSelected.Rows[i].Cells["SelectedPQNo"].Value)
                                                                               {
                                                                                   MessageBox.Show("That Price Quotation has already been added.", "Item Already in RFQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                   return; //Enables User to interact with the form
                                                                               }
                                                                           }
                                                                           */
            if (dgvPQSelected.Rows.Count == 0)
            {
                // if (selectedRow.Cells["Customer"].Value.Equals(dgvPQSelected.Rows[0].Cells["SelectedCustomer"].Value))
                //  {
                dgvPQSelected.Rows.Add(selectedRow.Cells["PQNo"].Value,
                                     selectedRow.Cells["PQDate"].Value,
                                     selectedRow.Cells["Customer"].Value,
                                     selectedRow.Cells["ValDate"].Value);
            }
            else
            {
                MessageBox.Show("That Creation from Price Quotation to Purchase Order Exceeded.", "Too much PQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //Enables User to interact with the form
            }

        }

        private void btnRemovePQ_Click(object sender, EventArgs e)
        {
            if (dgvPQSelected.Rows.Count == 0)
            {
                MessageBox.Show("There are no Price Quotation to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvPQSelected.Rows.RemoveAt(dgvPQSelected.CurrentRow.Index);
        }

        private void btnClearPQ_Click(object sender, EventArgs e)
        {
            if (dgvPQSelected.Rows.Count == 0)
            { MessageBox.Show("There are no Price Quotation to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            dgvPQSelected.Rows.Clear();
        }

        private void btnCreatePO_Click(object sender, EventArgs e)
        {
            if (dgvPQSelected.Rows.Count == 0)
            {
                MessageBox.Show("Please include Price Quotation.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();

            PO_CreateForm pof = new PO_CreateForm();


            for (int i = 0; i < dgvPQSelected.RowCount; i++)
            {


                string pqNo;
                DataGridViewRow row = dgvPQSelected.Rows[i];
                pqNo = (row.Cells["SelectedPQNo"].Value).ToString(); //get the PQNo of the pq selected
                PQ p = sql.SelectPQDetails(pqNo); //from the RFQNo taken, get its details
                selectedPQList.Add(new PQ(p.PQNo, p.PQDate, p.PQFromDate, p.PQToDate, p.PaymentTerms, p.DeliveryTerms, p.BillTo, p.ShipTo, p.InFavorOf, p.TotalAmount, p.CustomerID)); //put in an ArrayList the details taken
                pof.PQNo = pqNo;
                PQ_OrderLine pqol = sql.SelectPQOrderLine(pqNo);
                pqOrderLineList.Add(new PQ_OrderLine(pqol.PQNo, pqol.PartNumber, pqol.ReicUnitPrice, pqol.Quantity, pqol.ItemTotal));

                for (int j = 0; j < pqOrderLineList.Count; j++)
                {
                    Item item = sql.SelectItemDetails(pqol.PartNumber);
                    itemList.Add(new Item(item.PartNumber, item.ItemName, item.ItemDescription, item.SupplierUnitPrice, item.Markup, item.ReicUnitPrice, item.Moq, item.Uom, item.FromDateNoTime, item.ToDateNoTime, item.SupplierID));
                    Supplier s = sql.SelectSupplierDetails(item.SupplierID);
                    pof.SupplierName = s.SupplierName;
                    pof.SupplierPerson = s.SupplierPerson;
                    pof.SupplierNumber = s.SupplierNumber;
                    pof.SupplierEmail = s.SupplierEmail;
                    pof.SupplierAddress = s.SupplierAddress;

                    pof.SupplierID = item.SupplierID.ToString();
                    
                    MessageBox.Show("umabot ka dito");
                }
                /*
                string year = DateTime.Now.ToString("yy");
                string month = DateTime.Now.ToString("MM");
                int pqCount = sql.GetRowCount("pq_t", year, month);
                string generatedPONo = year + month + "-" + (pqCount + 1).ToString("D3");
                pof.PONo = generatedPONo;

                pf.PaymentTerms = r.PaymentTerms;
                pf.DeliveryTerms = r.DeliveryTerms;
                */
                Customer c = sql.SelectCustomerDetails(p.CustomerID); //to retrieve the details of Customer from MySqlDatabaseDriver
                pof.CustomerName = c.CustomerName;
                /* pf.CustomerPerson = c.CustomerPerson;
                 pf.CustomerNumber = c.CustomerNumber;
                 pf.CustomerEmail = c.CustomerEmail;
                 pf.CustomerAddress = c.CustomerAddress;*/


                pof.ShowDialog();

                if (pof.Cancel == false)
                {//if save button were clicked, this will save the pq details in arrayList then in the database
                    string OrderDateNoTime = pof.OrderDate.ToShortDateString();
                    string RequiredDateNoTime = pof.RequiredDate.ToShortDateString();
                    
                    poList.Add(new PO(pof.PONo,
                                        OrderDateNoTime,
                                        RequiredDateNoTime,
                                        pof.OrderDesc,
                                        pof.PQNo,
                                        pof.PaymentTerms,
                                        pof.DeliveryTerms,
                                        double.Parse(pof.NetSubTotal),
                                        double.Parse(pof.DeliveryCosts),
                                        double.Parse(pof.OrderTotal),
                                        int.Parse(pof.SupplierID),
                                        pof.CustomerIDFK,
                                        null));


                    PO newPO = (PO)poList[(poList.Count - 1)];
                    sql.InsertPO(newPO);

                    for (int j = 0; j < pof.POOrderLineList.Count; j++)
                    {
                        PO_OrderLine pol = (PO_OrderLine)pof.POOrderLineList[j];
                        sql.InsertPOOrderLine(pol);
                        MessageBox.Show("OrderLine added to comprehensive list: " + pol.PONo + ", " + pol.PartNumber + ", " + pol.SupplierUnitPrice + "," + pol.Quantity + "," + pol.ItemTotal);
                    }
                }
            
                           
            }
        }
        
    }
}

