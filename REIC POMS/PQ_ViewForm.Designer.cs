namespace REIC_POMS
{
    partial class PQ_ViewForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabItemDetails = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.outputCustomerAddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outputToDate = new System.Windows.Forms.Label();
            this.outputCustomerEmail = new System.Windows.Forms.Label();
            this.outputContactNumber = new System.Windows.Forms.Label();
            this.outputContactPerson = new System.Windows.Forms.Label();
            this.outputCustomerName = new System.Windows.Forms.Label();
            this.outputDeliveryTerms = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.outputFromDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.outputDate = new System.Windows.Forms.Label();
            this.outputPQNo = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.lblCustomerPerson = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            this.lblDeliveryTerms = new System.Windows.Forms.Label();
            this.lblInFavorOf = new System.Windows.Forms.Label();
            this.lblPaymentTerms = new System.Windows.Forms.Label();
            this.outputInFavorOf = new System.Windows.Forms.Label();
            this.outputPaymentTerms = new System.Windows.Forms.Label();
            this.lblValPeriod = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPQNumber = new System.Windows.Forms.Label();
            this.lblQuotationDetails = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.lblAmount = new System.Windows.Forms.Label();
            this.dgvPQItems = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveGeneratePDF = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPQItems = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreatePO = new System.Windows.Forms.PictureBox();
            this.btnGeneratePDF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabItemDetails.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPQItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreatePO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeneratePDF)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::REIC_POMS.Properties.Resources.BannerPQView;
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
            this.tabItemDetails.Size = new System.Drawing.Size(857, 377);
            this.tabItemDetails.TabIndex = 4;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.label1);
            this.TabPage1.Controls.Add(this.outputCustomerAddress);
            this.TabPage1.Controls.Add(this.panel1);
            this.TabPage1.Controls.Add(this.outputToDate);
            this.TabPage1.Controls.Add(this.outputCustomerEmail);
            this.TabPage1.Controls.Add(this.outputContactNumber);
            this.TabPage1.Controls.Add(this.outputContactPerson);
            this.TabPage1.Controls.Add(this.outputCustomerName);
            this.TabPage1.Controls.Add(this.outputDeliveryTerms);
            this.TabPage1.Controls.Add(this.label13);
            this.TabPage1.Controls.Add(this.outputFromDate);
            this.TabPage1.Controls.Add(this.label11);
            this.TabPage1.Controls.Add(this.outputDate);
            this.TabPage1.Controls.Add(this.outputPQNo);
            this.TabPage1.Controls.Add(this.lblCustomerAddress);
            this.TabPage1.Controls.Add(this.lblCustomerEmail);
            this.TabPage1.Controls.Add(this.lblCustomerNumber);
            this.TabPage1.Controls.Add(this.lblCustomerPerson);
            this.TabPage1.Controls.Add(this.lblCustomerName);
            this.TabPage1.Controls.Add(this.lblCustomerDetails);
            this.TabPage1.Controls.Add(this.lblDeliveryTerms);
            this.TabPage1.Controls.Add(this.lblInFavorOf);
            this.TabPage1.Controls.Add(this.lblPaymentTerms);
            this.TabPage1.Controls.Add(this.outputInFavorOf);
            this.TabPage1.Controls.Add(this.outputPaymentTerms);
            this.TabPage1.Controls.Add(this.lblValPeriod);
            this.TabPage1.Controls.Add(this.lblDate);
            this.TabPage1.Controls.Add(this.lblPQNumber);
            this.TabPage1.Controls.Add(this.lblQuotationDetails);
            this.TabPage1.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TabPage1.Location = new System.Drawing.Point(4, 28);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(849, 345);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Quotation & Customer Details";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 77;
            this.label1.Text = "to";
            // 
            // outputCustomerAddress
            // 
            this.outputCustomerAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputCustomerAddress.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputCustomerAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.outputCustomerAddress.Location = new System.Drawing.Point(429, 223);
            this.outputCustomerAddress.MaxLength = 150;
            this.outputCustomerAddress.Multiline = true;
            this.outputCustomerAddress.Name = "outputCustomerAddress";
            this.outputCustomerAddress.ReadOnly = true;
            this.outputCustomerAddress.Size = new System.Drawing.Size(322, 64);
            this.outputCustomerAddress.TabIndex = 76;
            this.outputCustomerAddress.Text = "Magic TextBox";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(374, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 287);
            this.panel1.TabIndex = 75;
            // 
            // outputToDate
            // 
            this.outputToDate.AutoSize = true;
            this.outputToDate.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputToDate.Location = new System.Drawing.Point(223, 149);
            this.outputToDate.Name = "outputToDate";
            this.outputToDate.Size = new System.Drawing.Size(75, 19);
            this.outputToDate.TabIndex = 40;
            this.outputToDate.Text = "11/05/2017";
            // 
            // outputCustomerEmail
            // 
            this.outputCustomerEmail.AutoSize = true;
            this.outputCustomerEmail.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputCustomerEmail.Location = new System.Drawing.Point(542, 164);
            this.outputCustomerEmail.Name = "outputCustomerEmail";
            this.outputCustomerEmail.Size = new System.Drawing.Size(138, 19);
            this.outputCustomerEmail.TabIndex = 37;
            this.outputCustomerEmail.Text = "abc_co@yahoo.com";
            // 
            // outputContactNumber
            // 
            this.outputContactNumber.AutoSize = true;
            this.outputContactNumber.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputContactNumber.Location = new System.Drawing.Point(542, 131);
            this.outputContactNumber.Name = "outputContactNumber";
            this.outputContactNumber.Size = new System.Drawing.Size(79, 19);
            this.outputContactNumber.TabIndex = 36;
            this.outputContactNumber.Text = "0915555634";
            // 
            // outputContactPerson
            // 
            this.outputContactPerson.AutoSize = true;
            this.outputContactPerson.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputContactPerson.Location = new System.Drawing.Point(542, 101);
            this.outputContactPerson.Name = "outputContactPerson";
            this.outputContactPerson.Size = new System.Drawing.Size(103, 19);
            this.outputContactPerson.TabIndex = 35;
            this.outputContactPerson.Text = "Victoria Carpio";
            // 
            // outputCustomerName
            // 
            this.outputCustomerName.AutoSize = true;
            this.outputCustomerName.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputCustomerName.Location = new System.Drawing.Point(542, 71);
            this.outputCustomerName.Name = "outputCustomerName";
            this.outputCustomerName.Size = new System.Drawing.Size(101, 19);
            this.outputCustomerName.TabIndex = 34;
            this.outputCustomerName.Text = "ABC COMPANY";
            // 
            // outputDeliveryTerms
            // 
            this.outputDeliveryTerms.AutoSize = true;
            this.outputDeliveryTerms.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputDeliveryTerms.Location = new System.Drawing.Point(222, 253);
            this.outputDeliveryTerms.Name = "outputDeliveryTerms";
            this.outputDeliveryTerms.Size = new System.Drawing.Size(29, 19);
            this.outputDeliveryTerms.TabIndex = 33;
            this.outputDeliveryTerms.Text = "CIF";
            this.outputDeliveryTerms.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 18);
            this.label13.TabIndex = 32;
            this.label13.Text = "QUOTATION (MMDDYYYY)";
            // 
            // outputFromDate
            // 
            this.outputFromDate.AutoSize = true;
            this.outputFromDate.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputFromDate.Location = new System.Drawing.Point(223, 134);
            this.outputFromDate.Name = "outputFromDate";
            this.outputFromDate.Size = new System.Drawing.Size(75, 19);
            this.outputFromDate.TabIndex = 31;
            this.outputFromDate.Text = "01/01/2015";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(193, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 18);
            this.label11.TabIndex = 30;
            // 
            // outputDate
            // 
            this.outputDate.AutoSize = true;
            this.outputDate.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputDate.Location = new System.Drawing.Point(222, 100);
            this.outputDate.Name = "outputDate";
            this.outputDate.Size = new System.Drawing.Size(75, 19);
            this.outputDate.TabIndex = 29;
            this.outputDate.Text = "11/20/2015";
            // 
            // outputPQNo
            // 
            this.outputPQNo.AutoSize = true;
            this.outputPQNo.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputPQNo.Location = new System.Drawing.Point(223, 70);
            this.outputPQNo.Name = "outputPQNo";
            this.outputPQNo.Size = new System.Drawing.Size(37, 19);
            this.outputPQNo.TabIndex = 28;
            this.outputPQNo.Text = "2327";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(409, 202);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(66, 18);
            this.lblCustomerAddress.TabIndex = 26;
            this.lblCustomerAddress.Text = "ADDRESS";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(409, 165);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(111, 18);
            this.lblCustomerEmail.TabIndex = 24;
            this.lblCustomerEmail.Text = "E-MAIL ADDRESS";
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.AutoSize = true;
            this.lblCustomerNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerNumber.Location = new System.Drawing.Point(409, 132);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Size = new System.Drawing.Size(120, 18);
            this.lblCustomerNumber.TabIndex = 22;
            this.lblCustomerNumber.Text = "CONTACT NUMBER";
            // 
            // lblCustomerPerson
            // 
            this.lblCustomerPerson.AutoSize = true;
            this.lblCustomerPerson.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerPerson.Location = new System.Drawing.Point(408, 101);
            this.lblCustomerPerson.Name = "lblCustomerPerson";
            this.lblCustomerPerson.Size = new System.Drawing.Size(118, 18);
            this.lblCustomerPerson.TabIndex = 20;
            this.lblCustomerPerson.Text = "CONTACT PERSON";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(408, 71);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(104, 18);
            this.lblCustomerName.TabIndex = 19;
            this.lblCustomerName.Text = "COMPANY NAME";
            // 
            // lblCustomerDetails
            // 
            this.lblCustomerDetails.AutoSize = true;
            this.lblCustomerDetails.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblCustomerDetails.Location = new System.Drawing.Point(404, 23);
            this.lblCustomerDetails.Name = "lblCustomerDetails";
            this.lblCustomerDetails.Size = new System.Drawing.Size(230, 38);
            this.lblCustomerDetails.TabIndex = 18;
            this.lblCustomerDetails.Text = "Customer Details";
            // 
            // lblDeliveryTerms
            // 
            this.lblDeliveryTerms.AutoSize = true;
            this.lblDeliveryTerms.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDeliveryTerms.Location = new System.Drawing.Point(35, 254);
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
            this.lblInFavorOf.Location = new System.Drawing.Point(35, 221);
            this.lblInFavorOf.Name = "lblInFavorOf";
            this.lblInFavorOf.Size = new System.Drawing.Size(82, 18);
            this.lblInFavorOf.TabIndex = 8;
            this.lblInFavorOf.Text = "IN FAVOR OF";
            // 
            // lblPaymentTerms
            // 
            this.lblPaymentTerms.AutoSize = true;
            this.lblPaymentTerms.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPaymentTerms.Location = new System.Drawing.Point(35, 189);
            this.lblPaymentTerms.Name = "lblPaymentTerms";
            this.lblPaymentTerms.Size = new System.Drawing.Size(110, 18);
            this.lblPaymentTerms.TabIndex = 7;
            this.lblPaymentTerms.Text = "PAYMENT TERMS";
            // 
            // outputInFavorOf
            // 
            this.outputInFavorOf.AutoSize = true;
            this.outputInFavorOf.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputInFavorOf.Location = new System.Drawing.Point(223, 221);
            this.outputInFavorOf.Name = "outputInFavorOf";
            this.outputInFavorOf.Size = new System.Drawing.Size(82, 19);
            this.outputInFavorOf.TabIndex = 6;
            this.outputInFavorOf.Text = "CUSTOMER";
            // 
            // outputPaymentTerms
            // 
            this.outputPaymentTerms.AutoSize = true;
            this.outputPaymentTerms.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputPaymentTerms.Location = new System.Drawing.Point(223, 189);
            this.outputPaymentTerms.Name = "outputPaymentTerms";
            this.outputPaymentTerms.Size = new System.Drawing.Size(37, 19);
            this.outputPaymentTerms.TabIndex = 5;
            this.outputPaymentTerms.Text = "COD";
            // 
            // lblValPeriod
            // 
            this.lblValPeriod.AutoSize = true;
            this.lblValPeriod.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblValPeriod.Location = new System.Drawing.Point(35, 134);
            this.lblValPeriod.Name = "lblValPeriod";
            this.lblValPeriod.Size = new System.Drawing.Size(131, 18);
            this.lblValPeriod.TabIndex = 4;
            this.lblValPeriod.Text = "VALIDITY PERIOD OF";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(35, 100);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "DATE";
            // 
            // lblPQNumber
            // 
            this.lblPQNumber.AutoSize = true;
            this.lblPQNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPQNumber.Location = new System.Drawing.Point(35, 70);
            this.lblPQNumber.Name = "lblPQNumber";
            this.lblPQNumber.Size = new System.Drawing.Size(143, 18);
            this.lblPQNumber.TabIndex = 1;
            this.lblPQNumber.Text = "PRICE QUOTATION NO.";
            // 
            // lblQuotationDetails
            // 
            this.lblQuotationDetails.AutoSize = true;
            this.lblQuotationDetails.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblQuotationDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblQuotationDetails.Location = new System.Drawing.Point(26, 23);
            this.lblQuotationDetails.Name = "lblQuotationDetails";
            this.lblQuotationDetails.Size = new System.Drawing.Size(233, 38);
            this.lblQuotationDetails.TabIndex = 0;
            this.lblQuotationDetails.Text = "Quotation Details";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.btnGeneratePDF);
            this.TabPage2.Controls.Add(this.lblAmount);
            this.TabPage2.Controls.Add(this.dgvPQItems);
            this.TabPage2.Controls.Add(this.btnCancel);
            this.TabPage2.Controls.Add(this.btnSaveGeneratePDF);
            this.TabPage2.Controls.Add(this.lblTotal);
            this.TabPage2.Controls.Add(this.lblPQItems);
            this.TabPage2.Location = new System.Drawing.Point(4, 28);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(849, 345);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Item Details";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblAmount.Location = new System.Drawing.Point(689, 284);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(121, 38);
            this.lblAmount.TabIndex = 70;
            this.lblAmount.Text = "6,699.99";
            this.lblAmount.TextChanged += new System.EventHandler(this.lblAmount_TextChanged);
            // 
            // dgvPQItems
            // 
            this.dgvPQItems.AllowUserToAddRows = false;
            this.dgvPQItems.AllowUserToDeleteRows = false;
            this.dgvPQItems.AllowUserToResizeColumns = false;
            this.dgvPQItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPQItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPQItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.dgvPQItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPQItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPQItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPQItems.ColumnHeadersHeight = 24;
            this.dgvPQItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPQItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Description,
            this.UOM,
            this.Column1,
            this.Qty,
            this.TotalItem});
            this.dgvPQItems.EnableHeadersVisualStyles = false;
            this.dgvPQItems.Location = new System.Drawing.Point(35, 63);
            this.dgvPQItems.MultiSelect = false;
            this.dgvPQItems.Name = "dgvPQItems";
            this.dgvPQItems.ReadOnly = true;
            this.dgvPQItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPQItems.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPQItems.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPQItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPQItems.Size = new System.Drawing.Size(775, 218);
            this.dgvPQItems.TabIndex = 69;
            this.dgvPQItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPQItems_RowsAdded);
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
            // TotalItem
            // 
            this.TotalItem.HeaderText = "ITEM TOTAL";
            this.TotalItem.Name = "TotalItem";
            this.TotalItem.ReadOnly = true;
            this.TotalItem.Width = 95;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(703, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSaveGeneratePDF
            // 
            this.btnSaveGeneratePDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnSaveGeneratePDF.FlatAppearance.BorderSize = 0;
            this.btnSaveGeneratePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveGeneratePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGeneratePDF.Location = new System.Drawing.Point(525, 374);
            this.btnSaveGeneratePDF.Name = "btnSaveGeneratePDF";
            this.btnSaveGeneratePDF.Size = new System.Drawing.Size(172, 23);
            this.btnSaveGeneratePDF.TabIndex = 43;
            this.btnSaveGeneratePDF.Text = "CREATE PURCHASE ORDER";
            this.btnSaveGeneratePDF.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblTotal.Location = new System.Drawing.Point(518, 284);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(104, 38);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "TOTAL:";
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
            this.btnClose.Location = new System.Drawing.Point(739, 456);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 35);
            this.btnClose.TabIndex = 66;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreatePO
            // 
            this.btnCreatePO.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonCreatePOFromViewPQ;
            this.btnCreatePO.Location = new System.Drawing.Point(483, 456);
            this.btnCreatePO.Name = "btnCreatePO";
            this.btnCreatePO.Size = new System.Drawing.Size(250, 35);
            this.btnCreatePO.TabIndex = 71;
            this.btnCreatePO.TabStop = false;
            this.btnCreatePO.MouseEnter += new System.EventHandler(this.btnCreatePO_MouseEnter);
            this.btnCreatePO.MouseLeave += new System.EventHandler(this.btnCreatePO_MouseLeave);
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonPDF;
            this.btnGeneratePDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneratePDF.Location = new System.Drawing.Point(761, 18);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(40, 40);
            this.btnGeneratePDF.TabIndex = 72;
            this.btnGeneratePDF.TabStop = false;
            this.btnGeneratePDF.MouseEnter += new System.EventHandler(this.btnGeneratePDF_MouseEnter);
            this.btnGeneratePDF.MouseLeave += new System.EventHandler(this.btnGeneratePDF_MouseLeave);
            // 
            // PQ_ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(855, 500);
            this.Controls.Add(this.btnCreatePO);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabItemDetails);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PQ_ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PQ_ViewForm";
            this.Load += new System.EventHandler(this.PQ_ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabItemDetails.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPQItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreatePO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeneratePDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TabControl tabItemDetails;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Label outputCustomerEmail;
        internal System.Windows.Forms.Label outputContactNumber;
        internal System.Windows.Forms.Label outputContactPerson;
        internal System.Windows.Forms.Label outputCustomerName;
        internal System.Windows.Forms.Label outputDeliveryTerms;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label outputFromDate;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label outputDate;
        internal System.Windows.Forms.Label outputPQNo;
        internal System.Windows.Forms.Label lblCustomerAddress;
        internal System.Windows.Forms.Label lblCustomerEmail;
        internal System.Windows.Forms.Label lblCustomerNumber;
        internal System.Windows.Forms.Label lblCustomerPerson;
        internal System.Windows.Forms.Label lblCustomerName;
        internal System.Windows.Forms.Label lblCustomerDetails;
        internal System.Windows.Forms.Label lblDeliveryTerms;
        internal System.Windows.Forms.Label lblInFavorOf;
        internal System.Windows.Forms.Label lblPaymentTerms;
        internal System.Windows.Forms.Label outputInFavorOf;
        internal System.Windows.Forms.Label outputPaymentTerms;
        internal System.Windows.Forms.Label lblValPeriod;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label lblPQNumber;
        internal System.Windows.Forms.Label lblQuotationDetails;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label lblPQItems;
        internal System.Windows.Forms.Label outputToDate;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSaveGeneratePDF;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPQItems;
        private System.Windows.Forms.TextBox outputCustomerAddress;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalItem;
        private System.Windows.Forms.PictureBox btnCreatePO;
        private System.Windows.Forms.PictureBox btnGeneratePDF;
    }
}