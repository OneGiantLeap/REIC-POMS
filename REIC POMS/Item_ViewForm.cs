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
    public partial class Item_ViewForm : Form
    {
        public Item_ViewForm()
        {
            InitializeComponent();
        }
        public bool cancel;

        public string PartNumbertoView
        {
            set { outputPartNumber.Text = value; }
            get { return outputPartNumber.Text; }
        }

        public string ItemNametoView
        {
            set { outputItemName.Text = value; }
            get { return outputItemName.Text; }
        }

        public string SupplierUnitPricetoView
        {
            set { outputSuppPrice.Text = value; }
            get { return outputSuppPrice.Text; }
        }

        public string MarkuptoView
        {
            set { outputMarkup.Text = value; }
            get { return outputMarkup.Text; }
        }

        public string ReicUnitPricetoView
        {
            set { outputREICPrice.Text = value; }
            get { return outputREICPrice.Text; }
        }

        public string MoqtoView
        {
            set { outputMOQ.Text = value; }
            get { return outputMOQ.Text; }
        }

        public string UomtoView
        {
            set { outputUOM.Text = value; }
            get { return outputUOM.Text; }
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

        public string ItemDescriptiontoView
        {
            set { outputItemDesc.Text = value; }
            get { return outputItemDesc.Text; }
        }

        public string SupplierNametoView
        {
            set { outputSupplierName.Text = value; }
            get { return outputSupplierName.Text; }
        }

        public string SupplierPersontoView
        {
            set { outputSupplierPerson.Text = value; }
            get { return outputSupplierPerson.Text; }
        }

        public string SupplierNumbertoView
        {
            set { outputSupplierNumber.Text = value; }
            get { return outputSupplierNumber.Text; }
        }

        public string SupplierEmailtoView
        {
            set { outputSupplierEmail.Text = value; }
            get { return outputSupplierEmail.Text; }
        }

        public string SupplierAddresstoView
        {
            set { outputSupplierAddress.Text = value; }
            get { return outputSupplierAddress.Text; }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }

        private void Item_ViewForm_Load(object sender, EventArgs e)
        {

        }

        public bool Cancel
        {
            get { return cancel; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Item_UpdateForm iuf = new Item_UpdateForm();


            iuf.PartNumbertoEdit = PartNumbertoView;
            iuf.ItemNametoEdit = ItemNametoView;
            iuf.SupplierUnitPricetoEdit = SupplierUnitPricetoView;
            iuf.MarkuptoEdit = MarkuptoView;
            iuf.ReicUnitPricetoEdit = ReicUnitPricetoView;
            iuf.MoqtoEdit = MoqtoView;
            iuf.UomtoEdit = UomtoView;
            iuf.FromDatetoEdit = FromDatetoView;
            iuf.ToDatetoEdit = ToDatetoView;
            iuf.ItemDescriptiontoEdit = ItemDescriptiontoView;
            iuf.SupplierNametoEdit = SupplierNametoView;
            iuf.SupplierPersontoEdit = SupplierPersontoView;
            iuf.SupplierNumbertoEdit = SupplierNumbertoView;
            iuf.SupplierEmailtoEdit = SupplierEmailtoView;
            iuf.SupplierAddresstoEdit = SupplierAddresstoView;
            this.Hide();
            iuf.ShowDialog();

            if (iuf.Cancel == false)
            {
                PartNumbertoView = iuf.PartNumbertoEdit;
                ItemNametoView = iuf.ItemNametoEdit;
                SupplierUnitPricetoView = iuf.SupplierUnitPricetoEdit;
                MarkuptoView = iuf.MarkuptoEdit;
                ReicUnitPricetoView = iuf.ReicUnitPricetoEdit;
                MoqtoView = iuf.MoqtoEdit;
                UomtoView = iuf.UomtoEdit;
                FromDatetoView = iuf.FromDatetoEdit;
                ToDatetoView = iuf.ToDatetoEdit;
                ItemDescriptiontoView = iuf.ItemDescriptiontoEdit;
                SupplierNametoView = iuf.SupplierNametoEdit;
                SupplierPersontoView = iuf.SupplierPersontoEdit;
                SupplierNumbertoView = iuf.SupplierNumbertoEdit;
                SupplierEmailtoView = iuf.SupplierEmailtoEdit;
                SupplierAddresstoView = iuf.SupplierAddresstoEdit;
                cancel = false;
            }
            else
            { cancel = true; }
            this.Close();


        }
    }
}
