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
    }
}
