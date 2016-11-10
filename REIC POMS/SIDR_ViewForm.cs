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
    public partial class SIDR_ViewForm : Form
    {
        //private MySQLDatabaseDriver sql;

        public SIDR_ViewForm()
        {
            //InitializeComponent();
            ////Change DGV Borderline color to gray instead of black
            //dgvItemSelection.GridColor = Color.FromArgb(137, 137, 137);
            //dgvSIDRItems.GridColor = Color.FromArgb(137, 137, 137);

            ////Set default Combo Box values
            //cbbFilterBy.SelectedIndex = 0; //"Filter by..."
            //cbbPaymentTerms.SelectedIndex = 0; //"Select"
            //cbbCustomerName.SelectedIndex = 0; // "Select"
            //cbbInFavorOf.SelectedIndex = 0; //"Select"

            //// Set the Format type and the CustomFormat string
            //dtpDateOfRequest.Format = DateTimePickerFormat.Custom;
            //dtpDateOfRequest.CustomFormat = "MM/dd/yyyy";

            //sql = new MySQLDatabaseDriver();
        }

        private void PQ_ViewForm_Load(object sender, EventArgs e)
        {
            //sql.SelectSpecificPQOrderLine(SIDRNoToView, dgvSIDRItems); //Has to be placed HERE, not in initialize
        }

        public string SINoToView
        {
            set { outputSINumber.Text = value; }
            get { return outputSINumber.Text; }
        }

        public string PQDateToView
        {
            set { outputDate.Text = value; }
            get { return outputDate.Text; }
        }

        public string PONoToView
        {
            set { outputPONumber.Text = value; }
            get { return outputPONumber.Text; }
        }

        public string DateView
        {
            set { outputDate.Text = value; }
            get { return outputDate.Text; }
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


        private void lblAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        void CalculateTotal()
        {
            double itemTotal = 0;
            double itemPrice;

            for (int i = 0; i < dgvSIDRItems.Rows.Count; i++)
            {
                {
                    itemPrice = double.Parse(dgvSIDRItems.Rows[i].Cells["TotalItem"].Value.ToString());
                }
                itemTotal += itemPrice;
            }
            outputAmount.Text = itemTotal.ToString("0.00");
        }

        private void dgvPQItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateTotal();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ADD LOGIC HERE
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            //ADD LOGIC HERE
        }

        //------------------------
        //  OTHER FORM ELEMENTS  |
        //------------------------
        private void btnGeneratePDF_MouseEnter(object sender, EventArgs e)
        { btnGeneratePDF.BackgroundImage = Properties.Resources.ButtonPDFHover; }

        private void btnGeneratePDF_MouseLeave(object sender, EventArgs e)
        { btnGeneratePDF.BackgroundImage = Properties.Resources.ButtonPDF; }
    }
}
