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


      
        public int max;
        
        public int current;
        public bool cancel;
        public bool filledOut;
       

        public Item_AddForm()
        {
            InitializeComponent();
           
          //  txtREICPrice.Text = (nudSuppPrice.Value.ToString());
            current = 0;
            max = 1;
        
        }

        private void Item_AddForm_Load(object sender, EventArgs e)
        {
            cbbUOM.SelectedIndex = 0;
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
            cbbUOM.SelectedIndex= 0;
        }
        /*
        we use DateTime, para we could compare two dates if FromDate is earlier than ToDate through DateTime.Compare 
        pero if we could think of ways pa how to compare this as a String, we could just put it as "dtpFromDate.Value.ToString()"
        */
        public string PartNumber { get { return txtPartNumber.Text; } }
        public string ItemName { get { return txtItemName.Text; } }
        public string SupplierUnitPrice { get { return nudSuppPrice.Value.ToString(); }  }
        public string Markup { get { return cbbMarkup.Text; } }
        public string ReicUnitPrice { get { return txtREICPrice.Text; } }
        public string Moq { get { return nudMOQ.Value.ToString(); } }
        public string Uom { get { return cbbUOM.Text; } }
        public DateTime FromDate { get { return dtpFromDate.Value; } } 
        public DateTime ToDate { get { return dtpToDate.Value; } } 
        public string ItemDescription { get { return txtItemDesc.Text; } }
        public string SupplierName { get { return txtSupplierName.Text; } }
        public string SupplierPerson { get { return txtSupplierPerson.Text; } }
        public string SupplierNumber { get { return txtSupplierNumber.Text; } }
        public string SupplierEmail { get { return txtSupplierEmail.Text; } }
        public string SupplierAddress { get { return txtSupplierAddress.Text; } }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
                        do
                        {
                         int dateResult = DateTime.Compare(FromDate, ToDate);
                             if (
                                 (PartNumber.Length == 0) ||
                                 (ItemName.Length == 0) ||
                                 (SupplierUnitPrice.Length == 0) ||
                                 (Markup.Length == 0) ||
                                 (ReicUnitPrice.Length == 0) ||
                                 (Moq.Length == 0) ||
                                 (Uom.Length == 0) ||
                                 (ItemDescription.Length == 0) ||
                                 (SupplierName.Length == 0) ||
                                 (SupplierPerson.Length == 0) ||
                                 (SupplierNumber.Length == 0) ||
                                 (SupplierEmail.Length == 0) ||
                                 (SupplierAddress.Length == 0)
                                )
               {

                    DialogResult result = MessageBox.Show("All fields are required to be filled out.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        return;
                    }
                }
                else if (dateResult > 0)
                {
                    DialogResult result = MessageBox.Show("dont be stupid, fromDate later than toDate, ano yan joke!.", "Bawal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        return;
                    }
                }

                else { filledOut = true; }
                        
                     } while (filledOut == false);

            cancel = false;
            this.Close();
        }

        public bool Cancel
        { 
            get { return cancel; }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabItemForm.SelectedTab = tabSupplierDetails;
        }

        private void nudSuppPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateAndUpdateUI();
        }

        private void cbbMarkup_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateAndUpdateUI();
        }

        void CalculateAndUpdateUI()
        {
            /*  double d = default(double);

              foreach (Control c in this.Controls)
              {
                  if (c is TextBox)
                  {
                      if (c.Name != "txtTotal" && string.IsNullOrEmpty(c.Text) == false)
                      {
                          d += Convert.ToDouble(c.Text);
                      }
                  }
              }*/

            if ((SupplierUnitPrice.Length != 0) || (Markup.Length != 0))
            {

                double cash, mup, reicPrice;
                cash = 0;
                reicPrice = 0;
                mup = 0;

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        if (string.IsNullOrEmpty(c.Text) == false)
                        {
                            double profit = (cash * (mup / 100));
                             reicPrice = cash + profit;
                        }
                    }
                }
                /*  
                   if (double.TryParse(nudSuppPrice.Text, out cash)|| double.TryParse(cbbMarkup.Text, out mup))
                   {

   ;                    txtREICPrice.Text = (cash + profit).ToString();
                   }

               }
               else
               {
                   txtREICPrice.Clear();
               }*/
                txtREICPrice.Text = reicPrice.ToString();
            }
        }

        private void txtREICPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateAndUpdateUI();
        }
    }
}
