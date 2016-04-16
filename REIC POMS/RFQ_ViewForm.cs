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
    public partial class RFQ_ViewForm : Form
    {
        public RFQ_ViewForm()
        {
            InitializeComponent();

            //Change DGV Borderline color to gray instead of black
            dgvRFQItems.GridColor = Color.FromArgb(137, 137, 137);
        }

        //---------------------
        //  SPECIAL VARIABLES |
        //---------------------
        //Insert private bool cancel here

        //-------------------
        //  GETTERS-SETTERS |
        //-------------------
        //Insert public string here

        //-------------------
        //  BUTTON METHODS  |
        //-------------------
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
