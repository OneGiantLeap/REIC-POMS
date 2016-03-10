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
    public partial class Item_AddForm : Form
    {
        public Item_AddForm()
        {
            InitializeComponent();
        }

        private void Item_AddForm_Load(object sender, EventArgs e)
        {
        

        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.CustomFormat = "MM/dd/yyyy";
            dtpToDate.CustomFormat = "MM/dd/yyyy";
        }

        private void cbbUOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbUOM.SelectedIndex = 0;
        }
    }
}
