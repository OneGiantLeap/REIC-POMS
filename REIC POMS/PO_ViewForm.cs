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
    public partial class PO_ViewForm : Form
    {
        public PO_ViewForm()
        {
            InitializeComponent();
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

        }

        private void lblCustomerAddress_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //------------------------
        //  OTHER FORM ELEMENTS  |
        //------------------------
        private void btnGeneratePDF_MouseEnter(object sender, EventArgs e)
        { btnGeneratePDF.BackgroundImage = Properties.Resources.ButtonPDFHover; }

        private void btnGeneratePDF_MouseLeave(object sender, EventArgs e)
        { btnGeneratePDF.BackgroundImage = Properties.Resources.ButtonPDF; }

        private void btnCreateSIDR_MouseEnter(object sender, EventArgs e)
        { btnCreateSIDR.BackgroundImage = Properties.Resources.ButtonCreateSIDRFromViewPOHover; }

        private void btnCreateSIDR_MouseLeave(object sender, EventArgs e)
        { btnCreateSIDR.BackgroundImage = Properties.Resources.ButtonCreateSIDRFromViewPO; }
    }
}
