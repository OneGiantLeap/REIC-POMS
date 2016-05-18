namespace REIC_POMS
{
    partial class PO_ViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PO_ViewForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabItemDetails = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuote = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblContactPerson = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblPONo = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.lblCustomerPerson = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            this.lblDeliveryTerms = new System.Windows.Forms.Label();
            this.lblInFavorOf = new System.Windows.Forms.Label();
            this.lblPaymentTerms = new System.Windows.Forms.Label();
            this.lblFavor = new System.Windows.Forms.Label();
            this.lblTerms = new System.Windows.Forms.Label();
            this.lblRFQNumber = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPQNumber = new System.Windows.Forms.Label();
            this.lblQuotationDetails = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRFQItems = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGeneratePDF = new System.Windows.Forms.PictureBox();
            this.lblPQItems = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreatePO = new System.Windows.Forms.Button();
            this.lblRequiredDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOrderDesc = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabItemDetails.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFQItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeneratePDF)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::REIC_POMS.Properties.Resources.BannerPQView;
            //this.pictureBox1.Image = global::REIC_POMS.Properties.Resources.BannerPOView;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(855, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabItemDetails
            // 
            this.tabItemDetails.Controls.Add(this.TabPage1);
            this.tabItemDetails.Controls.Add(this.TabPage2);
            this.tabItemDetails.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabItemDetails.Location = new System.Drawing.Point(0, 72);
            this.tabItemDetails.Name = "tabItemDetails";
            this.tabItemDetails.SelectedIndex = 0;
            this.tabItemDetails.Size = new System.Drawing.Size(857, 434);
            this.tabItemDetails.TabIndex = 4;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.lblCompany);
            this.TabPage1.Controls.Add(this.label7);
            this.TabPage1.Controls.Add(this.label5);
            this.TabPage1.Controls.Add(this.txtAddress);
            this.TabPage1.Controls.Add(this.lblOrderDesc);
            this.TabPage1.Controls.Add(this.label4);
            this.TabPage1.Controls.Add(this.label3);
            this.TabPage1.Controls.Add(this.lblRequiredDate);
            this.TabPage1.Controls.Add(this.label2);
            this.TabPage1.Controls.Add(this.panel1);
            this.TabPage1.Controls.Add(this.lblQuote);
            this.TabPage1.Controls.Add(this.lblEmail);
            this.TabPage1.Controls.Add(this.lblContactNumber);
            this.TabPage1.Controls.Add(this.lblContactPerson);
            this.TabPage1.Controls.Add(this.lblSupplier);
            this.TabPage1.Controls.Add(this.lblDelivery);
            this.TabPage1.Controls.Add(this.lblOrderDate);
            this.TabPage1.Controls.Add(this.lblPONo);
            this.TabPage1.Controls.Add(this.lblCustomerAddress);
            this.TabPage1.Controls.Add(this.lblCustomerEmail);
            this.TabPage1.Controls.Add(this.lblCustomerNumber);
            this.TabPage1.Controls.Add(this.lblCustomerPerson);
            this.TabPage1.Controls.Add(this.lblCustomerName);
            this.TabPage1.Controls.Add(this.lblCustomerDetails);
            this.TabPage1.Controls.Add(this.lblDeliveryTerms);
            this.TabPage1.Controls.Add(this.lblInFavorOf);
            this.TabPage1.Controls.Add(this.lblPaymentTerms);
            this.TabPage1.Controls.Add(this.lblFavor);
            this.TabPage1.Controls.Add(this.lblTerms);
            this.TabPage1.Controls.Add(this.lblRFQNumber);
            this.TabPage1.Controls.Add(this.lblDate);
            this.TabPage1.Controls.Add(this.lblPQNumber);
            this.TabPage1.Controls.Add(this.lblQuotationDetails);
            this.TabPage1.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TabPage1.Location = new System.Drawing.Point(4, 28);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(849, 402);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Order & Supplier Details";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(374, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 287);
            this.panel1.TabIndex = 75;
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblQuote.Location = new System.Drawing.Point(223, 256);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(37, 19);
            this.lblQuote.TabIndex = 39;
            this.lblQuote.Text = "2327";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(545, 156);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(138, 19);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "abc_co@yahoo.com";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(542, 124);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(79, 19);
            this.lblContactNumber.TabIndex = 36;
            this.lblContactNumber.Text = "0915555634";
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.AutoSize = true;
            this.lblContactPerson.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblContactPerson.Location = new System.Drawing.Point(542, 94);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(103, 19);
            this.lblContactPerson.TabIndex = 35;
            this.lblContactPerson.Text = "Victoria Carpio";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(542, 64);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(80, 19);
            this.lblSupplier.TabIndex = 34;
            this.lblSupplier.Text = "Company X";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDelivery.Location = new System.Drawing.Point(222, 350);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(29, 19);
            this.lblDelivery.TabIndex = 33;
            this.lblDelivery.Text = "CIF";
            this.lblDelivery.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(223, 98);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(75, 19);
            this.lblOrderDate.TabIndex = 29;
            this.lblOrderDate.Text = "11/20/2015";
            // 
            // lblPONo
            // 
            this.lblPONo.AutoSize = true;
            this.lblPONo.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPONo.Location = new System.Drawing.Point(223, 69);
            this.lblPONo.Name = "lblPONo";
            this.lblPONo.Size = new System.Drawing.Size(37, 19);
            this.lblPONo.TabIndex = 28;
            this.lblPONo.Text = "2327";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(413, 185);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(127, 18);
            this.lblCustomerAddress.TabIndex = 26;
            this.lblCustomerAddress.Text = "COMPANY ADDRESS";
            this.lblCustomerAddress.Click += new System.EventHandler(this.lblCustomerAddress_Click);
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(412, 157);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(111, 18);
            this.lblCustomerEmail.TabIndex = 24;
            this.lblCustomerEmail.Text = "E-MAIL ADDRESS";
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.AutoSize = true;
            this.lblCustomerNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerNumber.Location = new System.Drawing.Point(409, 125);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Size = new System.Drawing.Size(120, 18);
            this.lblCustomerNumber.TabIndex = 22;
            this.lblCustomerNumber.Text = "CONTACT NUMBER";
            // 
            // lblCustomerPerson
            // 
            this.lblCustomerPerson.AutoSize = true;
            this.lblCustomerPerson.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerPerson.Location = new System.Drawing.Point(408, 94);
            this.lblCustomerPerson.Name = "lblCustomerPerson";
            this.lblCustomerPerson.Size = new System.Drawing.Size(118, 18);
            this.lblCustomerPerson.TabIndex = 20;
            this.lblCustomerPerson.Text = "CONTACT PERSON";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(408, 64);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(106, 18);
            this.lblCustomerName.TabIndex = 19;
            this.lblCustomerName.Text = "SUPPLIER NAME";
            // 
            // lblCustomerDetails
            // 
            this.lblCustomerDetails.AutoSize = true;
            this.lblCustomerDetails.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblCustomerDetails.Location = new System.Drawing.Point(404, 13);
            this.lblCustomerDetails.Name = "lblCustomerDetails";
            this.lblCustomerDetails.Size = new System.Drawing.Size(214, 38);
            this.lblCustomerDetails.TabIndex = 18;
            this.lblCustomerDetails.Text = "Supplier Details";
            // 
            // lblDeliveryTerms
            // 
            this.lblDeliveryTerms.AutoSize = true;
            this.lblDeliveryTerms.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDeliveryTerms.Location = new System.Drawing.Point(35, 352);
            this.lblDeliveryTerms.Name = "lblDeliveryTerms";
            this.lblDeliveryTerms.Size = new System.Drawing.Size(112, 18);
            this.lblDeliveryTerms.TabIndex = 9;
            this.lblDeliveryTerms.Text = "DELIVERY TERMS";
            this.lblDeliveryTerms.Click += new System.EventHandler(this.lblDeliveryTerms_Click);
            // 
            // lblInFavorOf
            // 
            this.lblInFavorOf.AutoSize = true;
            this.lblInFavorOf.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblInFavorOf.Location = new System.Drawing.Point(35, 319);
            this.lblInFavorOf.Name = "lblInFavorOf";
            this.lblInFavorOf.Size = new System.Drawing.Size(82, 18);
            this.lblInFavorOf.TabIndex = 8;
            this.lblInFavorOf.Text = "IN FAVOR OF";
            // 
            // lblPaymentTerms
            // 
            this.lblPaymentTerms.AutoSize = true;
            this.lblPaymentTerms.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPaymentTerms.Location = new System.Drawing.Point(35, 287);
            this.lblPaymentTerms.Name = "lblPaymentTerms";
            this.lblPaymentTerms.Size = new System.Drawing.Size(110, 18);
            this.lblPaymentTerms.TabIndex = 7;
            this.lblPaymentTerms.Text = "PAYMENT TERMS";
            // 
            // lblFavor
            // 
            this.lblFavor.AutoSize = true;
            this.lblFavor.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblFavor.Location = new System.Drawing.Point(223, 318);
            this.lblFavor.Name = "lblFavor";
            this.lblFavor.Size = new System.Drawing.Size(82, 19);
            this.lblFavor.TabIndex = 6;
            this.lblFavor.Text = "CUSTOMER";
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTerms.Location = new System.Drawing.Point(223, 286);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(37, 19);
            this.lblTerms.TabIndex = 5;
            this.lblTerms.Text = "COD";
            // 
            // lblRFQNumber
            // 
            this.lblRFQNumber.AutoSize = true;
            this.lblRFQNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblRFQNumber.Location = new System.Drawing.Point(35, 254);
            this.lblRFQNumber.Name = "lblRFQNumber";
            this.lblRFQNumber.Size = new System.Drawing.Size(76, 18);
            this.lblRFQNumber.TabIndex = 3;
            this.lblRFQNumber.Text = "QUOTE NO.";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(36, 98);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(85, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "ORDER DATE";
            // 
            // lblPQNumber
            // 
            this.lblPQNumber.AutoSize = true;
            this.lblPQNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPQNumber.Location = new System.Drawing.Point(35, 69);
            this.lblPQNumber.Name = "lblPQNumber";
            this.lblPQNumber.Size = new System.Drawing.Size(144, 18);
            this.lblPQNumber.TabIndex = 1;
            this.lblPQNumber.Text = "PURCHASE ORDER NO.";
            // 
            // lblQuotationDetails
            // 
            this.lblQuotationDetails.AutoSize = true;
            this.lblQuotationDetails.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblQuotationDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblQuotationDetails.Location = new System.Drawing.Point(26, 15);
            this.lblQuotationDetails.Name = "lblQuotationDetails";
            this.lblQuotationDetails.Size = new System.Drawing.Size(180, 38);
            this.lblQuotationDetails.TabIndex = 0;
            this.lblQuotationDetails.Text = "Order Details";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.label20);
            this.TabPage2.Controls.Add(this.label13);
            this.TabPage2.Controls.Add(this.label12);
            this.TabPage2.Controls.Add(this.label8);
            this.TabPage2.Controls.Add(this.label11);
            this.TabPage2.Controls.Add(this.lblTotalAmount);
            this.TabPage2.Controls.Add(this.dgvRFQItems);
            this.TabPage2.Controls.Add(this.btnGeneratePDF);
            this.TabPage2.Controls.Add(this.lblPQItems);
            this.TabPage2.Location = new System.Drawing.Point(4, 28);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(849, 402);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Item Details";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRFQItems
            // 
            this.dgvRFQItems.AllowUserToAddRows = false;
            this.dgvRFQItems.AllowUserToDeleteRows = false;
            this.dgvRFQItems.AllowUserToResizeColumns = false;
            this.dgvRFQItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRFQItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRFQItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.dgvRFQItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRFQItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRFQItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRFQItems.ColumnHeadersHeight = 24;
            this.dgvRFQItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRFQItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Description,
            this.UOM,
            this.Column1,
            this.Qty,
            this.Column2});
            this.dgvRFQItems.EnableHeadersVisualStyles = false;
            this.dgvRFQItems.Location = new System.Drawing.Point(35, 63);
            this.dgvRFQItems.MultiSelect = false;
            this.dgvRFQItems.Name = "dgvRFQItems";
            this.dgvRFQItems.ReadOnly = true;
            this.dgvRFQItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRFQItems.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRFQItems.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRFQItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRFQItems.Size = new System.Drawing.Size(775, 218);
            this.dgvRFQItems.TabIndex = 69;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ITEM NAME";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 235;
            // 
            // Description
            // 
            this.Description.HeaderText = "DESCRIPTION";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 248;
            // 
            // UOM
            // 
            this.UOM.HeaderText = "UOM";
            this.UOM.Name = "UOM";
            this.UOM.ReadOnly = true;
            this.UOM.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "UNIT PRICE";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 95;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "QTY.";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ITEM TOTAL";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 95;
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneratePDF.Image")));
            this.btnGeneratePDF.Location = new System.Drawing.Point(761, 18);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(40, 40);
            this.btnGeneratePDF.TabIndex = 16;
            this.btnGeneratePDF.TabStop = false;
            // 
            // lblPQItems
            // 
            this.lblPQItems.AutoSize = true;
            this.lblPQItems.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPQItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblPQItems.Location = new System.Drawing.Point(28, 18);
            this.lblPQItems.Name = "lblPQItems";
            this.lblPQItems.Size = new System.Drawing.Size(316, 38);
            this.lblPQItems.TabIndex = 2;
            this.lblPQItems.Text = "Items in Price Quotation";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnClose.Location = new System.Drawing.Point(739, 522);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 35);
            this.btnClose.TabIndex = 66;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreatePO
            // 
            this.btnCreatePO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnCreatePO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.btnCreatePO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePO.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCreatePO.ForeColor = System.Drawing.Color.White;
            this.btnCreatePO.Location = new System.Drawing.Point(508, 522);
            this.btnCreatePO.Name = "btnCreatePO";
            this.btnCreatePO.Size = new System.Drawing.Size(225, 35);
            this.btnCreatePO.TabIndex = 67;
            this.btnCreatePO.Text = "CREATE SI \\ DR";
            this.btnCreatePO.UseVisualStyleBackColor = false;
            this.btnCreatePO.Click += new System.EventHandler(this.btnCreatePO_Click);
            // 
            // lblRequiredDate
            // 
            this.lblRequiredDate.AutoSize = true;
            this.lblRequiredDate.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblRequiredDate.Location = new System.Drawing.Point(223, 130);
            this.lblRequiredDate.Name = "lblRequiredDate";
            this.lblRequiredDate.Size = new System.Drawing.Size(75, 19);
            this.lblRequiredDate.TabIndex = 77;
            this.lblRequiredDate.Text = "11/29/2015";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 76;
            this.label2.Text = "REQUIRED DELIVERY DATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "ORDER DESCRIPTION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 79;
            // 
            // lblOrderDesc
            // 
            this.lblOrderDesc.BackColor = System.Drawing.Color.White;
            this.lblOrderDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblOrderDesc.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblOrderDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOrderDesc.Location = new System.Drawing.Point(65, 183);
            this.lblOrderDesc.MaxLength = 150;
            this.lblOrderDesc.Multiline = true;
            this.lblOrderDesc.Name = "lblOrderDesc";
            this.lblOrderDesc.ReadOnly = true;
            this.lblOrderDesc.Size = new System.Drawing.Size(284, 69);
            this.lblOrderDesc.TabIndex = 80;
            this.lblOrderDesc.Text = "Lorem ipsum dolor sit  amet, consectetur adipiscing elit. Vestibulum tincidunt ni" +
    "cl a ligula ultricies gravida.";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.Location = new System.Drawing.Point(436, 206);
            this.txtAddress.MaxLength = 150;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(226, 69);
            this.txtAddress.TabIndex = 81;
            this.txtAddress.Text = "12 Quezon Avenue corner P. Tuazon Street, Brgy. Lourdes, Quezon City, Philippines" +
    "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.label5.Location = new System.Drawing.Point(404, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 38);
            this.label5.TabIndex = 82;
            this.label5.Text = "Customer Details";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(545, 348);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(101, 19);
            this.lblCompany.TabIndex = 84;
            this.lblCompany.Text = "ABC COMPANY";
            this.lblCompany.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(411, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 83;
            this.label7.Text = "COMPANY NAME";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label8.Location = new System.Drawing.Point(634, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 83;
            this.label8.Text = "Delivery Costs";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label11.Location = new System.Drawing.Point(591, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 19);
            this.label11.TabIndex = 82;
            this.label11.Text = "Net: Item(s) Subtotal";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(635, 370);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(98, 19);
            this.lblTotalAmount.TabIndex = 81;
            this.lblTotalAmount.Text = "ORDER TOTAL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label12.Location = new System.Drawing.Point(742, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 19);
            this.label12.TabIndex = 84;
            this.label12.Text = "7, 408.50";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label13.Location = new System.Drawing.Point(757, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 19);
            this.label13.TabIndex = 85;
            this.label13.Text = "500.00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label20.Location = new System.Drawing.Point(742, 370);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 19);
            this.label20.TabIndex = 86;
            this.label20.Text = "7, 908.50";
            // 
            // PO_ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(855, 575);
            this.Controls.Add(this.btnCreatePO);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabItemDetails);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PO_ViewForm";
            this.Text = "PQ_ViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabItemDetails.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFQItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeneratePDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TabControl tabItemDetails;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Label lblEmail;
        internal System.Windows.Forms.Label lblContactNumber;
        internal System.Windows.Forms.Label lblContactPerson;
        internal System.Windows.Forms.Label lblSupplier;
        internal System.Windows.Forms.Label lblDelivery;
        internal System.Windows.Forms.Label lblOrderDate;
        internal System.Windows.Forms.Label lblPONo;
        internal System.Windows.Forms.Label lblCustomerAddress;
        internal System.Windows.Forms.Label lblCustomerEmail;
        internal System.Windows.Forms.Label lblCustomerNumber;
        internal System.Windows.Forms.Label lblCustomerPerson;
        internal System.Windows.Forms.Label lblCustomerName;
        internal System.Windows.Forms.Label lblCustomerDetails;
        internal System.Windows.Forms.Label lblDeliveryTerms;
        internal System.Windows.Forms.Label lblInFavorOf;
        internal System.Windows.Forms.Label lblPaymentTerms;
        internal System.Windows.Forms.Label lblFavor;
        internal System.Windows.Forms.Label lblTerms;
        internal System.Windows.Forms.Label lblRFQNumber;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label lblPQNumber;
        internal System.Windows.Forms.Label lblQuotationDetails;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Label lblPQItems;
        internal System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.PictureBox btnGeneratePDF;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRFQItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnCreatePO;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lblRequiredDate;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox lblOrderDesc;
        internal System.Windows.Forms.Label lblCompany;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label lblTotalAmount;
    }
}