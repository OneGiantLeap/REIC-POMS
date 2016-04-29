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
    public partial class PQ_CreateFromRFQForm : Form
    {
        public PQ_CreateFromRFQForm()
        {
            InitializeComponent();
        }
        public bool cancel;

        public bool Cancel
        {
            get { return cancel; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            PQ_CreateForm pf = new PQ_CreateForm();
            pf.ShowDialog();
            cancel = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
        }
    }
}
