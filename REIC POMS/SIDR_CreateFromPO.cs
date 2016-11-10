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
    public partial class SIDR_CreateFromPO : Form
    {
        //private MySQLDatabaseDriver sql;
        private ArrayList sidrList;
        private ArrayList selectedPOList;
        private ArrayList poList;
        private int customerIDFK;

        public SIDR_CreateFromPO()
        {
            InitializeComponent();
        }
        public bool cancel;

        public bool Cancel
        {
            get { return cancel; }
        }

        private void btnAddtoSIDR_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvPOSelection.SelectedRows[0]; //Store row number of selected row
            for (int i = 0; i < dgvPOSelected.RowCount; i++) //Loop through dgv of all Selected POs
            {
                //Compares the PO no of the selected POs in dgvPOSelection and the rows of dgvPOSelected
                if (selectedRow.Cells["PONo"].Value == dgvPOSelected.Rows[i].Cells["SelectedPONo"].Value)
                {
                    MessageBox.Show("That Purchase Order has already been added.", "Item Already in PO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; //Enables User to interact with the form
                }
            }

            if (dgvPOSelected.Rows.Count > 0)
            {
                if (selectedRow.Cells["Customer"].Value.Equals(dgvPOSelected.Rows[0].Cells["SelectedCustomer"].Value))
                {
                    dgvPOSelected.Rows.Add(selectedRow.Cells["PONo"].Value,
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

            else if (dgvPOSelected.Rows.Count == 0)
            {
                dgvPOSelected.Rows.Add(selectedRow.Cells["PONo"].Value,
                    selectedRow.Cells["RequestDate"].Value,
                    selectedRow.Cells["Supplier"].Value,
                    selectedRow.Cells["Customer"].Value);
            }
        }

        private void btnRemovePO_Click(object sender, EventArgs e)
        {
            if (dgvPOSelected.Rows.Count == 0)
            {
                MessageBox.Show("There are no Purchae Orders to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvPOSelected.Rows.RemoveAt(dgvPOSelected.CurrentRow.Index);
        }

        private void btnClearPO_Click(object sender, EventArgs e)
        {
            if (dgvPOSelected.Rows.Count == 0)
            { MessageBox.Show("There are no Purchase Orders to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            dgvPOSelected.Rows.Clear();
        }

        private void btnCreateSIDR_Click(object sender, EventArgs e)
        {
            if (dgvPOSelected.Rows.Count == 0)
            {
                MessageBox.Show("Please include Purchase Orders.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();

            SIDR_CreateForm new_sidr = new SIDR_CreateForm();

            for (int i = 0; i < dgvPOSelected.RowCount; i++)
            {
                string poNo;
                DataGridViewRow row = dgvPOSelected.Rows[i];
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

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }

        private void lblItemTotal_Click(object sender, EventArgs e)
        {
                    }

        private void SIDR_CreateFromPO_Load(object sender, EventArgs e)
        {

        }
    }
}
