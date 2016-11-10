using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REIC_POMS
{
    public partial class PQ_ViewForm : Form
    {
        private MySQLDatabaseDriver sql;

        public PQ_ViewForm()
        {
            InitializeComponent();
            sql = new MySQLDatabaseDriver();
        }

        private void PQ_ViewForm_Load(object sender, EventArgs e)
        {
            sql.SelectSpecificPQOrderLine(PQNoToView, dgvPQItems); //Has to be placed HERE, not in initialize
        }

        public string PQNoToView
        {
            set { outputPQNo.Text = value; }
            get { return outputPQNo.Text; }
        }

        public string PQDateToView
        {
            set { outputDate.Text = value; }
            get { return outputDate.Text; }
        }

        public string RFQNoToView
        {
            set { outputRFQNo.Text = value; }
            get { return outputRFQNo.Text; }
        }

        public string FromDatetoView
        {
            set { outputFromDate.Text = value; }
            get { return outputFromDate.Text; }
        }

        public string ToDatetoView
        {
            set { outputToDate.Text = value; }
            get { return outputToDate.Text; }
        }


        public string PaymentTermsToView
        {
            set { outputPaymentTerms.Text = value; }
            get { return outputPaymentTerms.Text; }
        }

        public string InFavorOfToView
        {
            set { outputInFavorOf.Text = value; }
            get { return outputInFavorOf.Text; }
        }

        public string DeliveryTermsToView
        {
            set { outputDeliveryTerms.Text = value; }
            get { return outputDeliveryTerms.Text; }
        }

        public string CustomerNameToView
        {
            set { outputCustomerName.Text = value; }
            get { return outputCustomerName.Text; }
        }

        public string CustomerPersonToView
        {
            set { outputContactPerson.Text = value; }
            get { return outputContactPerson.Text; }
        }

        public string CustomerNumberToView
        {
            set { outputContactNumber.Text = value; }
            get { return outputContactNumber.Text; }
        }

        public string CustomerEmailToView
        {
            set { outputCustomerEmail.Text = value; }
            get { return outputCustomerEmail.Text; }
        }

        public string CustomerAddressToView
        {
            set { outputCustomerAddress.Text = value; }
            get { return outputCustomerAddress.Text; }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblDeliveryTerms_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnCreatePO_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        void CalculateTotal()
        {
            double itemTotal = 0;
            double itemPrice;

            for (int i = 0; i < dgvPQItems.Rows.Count; i++)
            {
                {
                    itemPrice = double.Parse(dgvPQItems.Rows[i].Cells["TotalItem"].Value.ToString());
                }
                itemTotal += itemPrice;
            }
            lblAmount.Text = itemTotal.ToString("0.00");
        }

        private void dgvPQItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateTotal();
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            //---OPEN THE PQ Printout Print Preview
            if (InFavorOfToView == "Supplier")
            {
                PQ_PrintScreen_IFOSupplier pq = new PQ_PrintScreen_IFOSupplier();
                pq.PQNo = PQNoToView;
                pq.FirstTime = false;
                pq.ShowDialog();
            }
            else
            { 
                PQ_PrintScreen pq = new PQ_PrintScreen();
                pq.PQNo = PQNoToView;
                pq.FirstTime = false;
                pq.ShowDialog();
            }
        }
    }
}
