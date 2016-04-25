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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PQ_ViewForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabItemDetails = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.lblCustomerPerson = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            this.lblDeliveryTerms = new System.Windows.Forms.Label();
            this.lblInFavorOf = new System.Windows.Forms.Label();
            this.lblPaymentTerms = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveGeneratePDF = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblPQItems = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreatePO = new System.Windows.Forms.Button();
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
            this.TabPage1.Controls.Add(this.panel1);
            this.TabPage1.Controls.Add(this.label21);
            this.TabPage1.Controls.Add(this.label19);
            this.TabPage1.Controls.Add(this.label20);
            this.TabPage1.Controls.Add(this.label17);
            this.TabPage1.Controls.Add(this.label18);
            this.TabPage1.Controls.Add(this.label16);
            this.TabPage1.Controls.Add(this.label15);
            this.TabPage1.Controls.Add(this.label14);
            this.TabPage1.Controls.Add(this.label13);
            this.TabPage1.Controls.Add(this.label12);
            this.TabPage1.Controls.Add(this.label11);
            this.TabPage1.Controls.Add(this.label10);
            this.TabPage1.Controls.Add(this.label9);
            this.TabPage1.Controls.Add(this.lblCustomerAddress);
            this.TabPage1.Controls.Add(this.lblCustomerEmail);
            this.TabPage1.Controls.Add(this.lblCustomerNumber);
            this.TabPage1.Controls.Add(this.lblCustomerPerson);
            this.TabPage1.Controls.Add(this.lblCustomerName);
            this.TabPage1.Controls.Add(this.lblCustomerDetails);
            this.TabPage1.Controls.Add(this.lblDeliveryTerms);
            this.TabPage1.Controls.Add(this.lblInFavorOf);
            this.TabPage1.Controls.Add(this.lblPaymentTerms);
            this.TabPage1.Controls.Add(this.lblToDate);
            this.TabPage1.Controls.Add(this.lblFromDate);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.lblRFQNumber);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(374, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 287);
            this.panel1.TabIndex = 75;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(223, 173);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 19);
            this.label21.TabIndex = 40;
            this.label21.Text = "11/05/2017";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(223, 125);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 19);
            this.label19.TabIndex = 39;
            this.label19.Text = "2327";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(426, 222);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 19);
            this.label20.TabIndex = 38;
            this.label20.Text = "Text";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(542, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 19);
            this.label17.TabIndex = 37;
            this.label17.Text = "abc_co@yahoo.com";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(542, 131);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 19);
            this.label18.TabIndex = 36;
            this.label18.Text = "0915555634";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(542, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 19);
            this.label16.TabIndex = 35;
            this.label16.Text = "Victoria Carpio";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(542, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 19);
            this.label15.TabIndex = 34;
            this.label15.Text = "ABC COMPANY";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(222, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 19);
            this.label14.TabIndex = 33;
            this.label14.Text = "CIF";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 18);
            this.label13.TabIndex = 32;
            this.label13.Text = "QUOTATION (MMDDYYYY)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(223, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 19);
            this.label12.TabIndex = 31;
            this.label12.Text = "01/01/2015 to";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(193, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 18);
            this.label11.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(222, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 29;
            this.label10.Text = "11/20/2015";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(223, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "2327";
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
            this.lblDeliveryTerms.Location = new System.Drawing.Point(35, 278);
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
            this.lblInFavorOf.Location = new System.Drawing.Point(35, 245);
            this.lblInFavorOf.Name = "lblInFavorOf";
            this.lblInFavorOf.Size = new System.Drawing.Size(82, 18);
            this.lblInFavorOf.TabIndex = 8;
            this.lblInFavorOf.Text = "IN FAVOR OF";
            // 
            // lblPaymentTerms
            // 
            this.lblPaymentTerms.AutoSize = true;
            this.lblPaymentTerms.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPaymentTerms.Location = new System.Drawing.Point(35, 213);
            this.lblPaymentTerms.Name = "lblPaymentTerms";
            this.lblPaymentTerms.Size = new System.Drawing.Size(110, 18);
            this.lblPaymentTerms.TabIndex = 7;
            this.lblPaymentTerms.Text = "PAYMENT TERMS";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(223, 245);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(82, 19);
            this.lblToDate.TabIndex = 6;
            this.lblToDate.Text = "CUSTOMER";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(223, 213);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(37, 19);
            this.lblFromDate.TabIndex = 5;
            this.lblFromDate.Text = "COD";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(35, 158);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(131, 18);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "VALIDITY PERIOD OF";
            // 
            // lblRFQNumber
            // 
            this.lblRFQNumber.AutoSize = true;
            this.lblRFQNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblRFQNumber.Location = new System.Drawing.Point(35, 125);
            this.lblRFQNumber.Name = "lblRFQNumber";
            this.lblRFQNumber.Size = new System.Drawing.Size(57, 18);
            this.lblRFQNumber.TabIndex = 3;
            this.lblRFQNumber.Text = "RFQ NO.";
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
            this.TabPage2.Controls.Add(this.dgvRFQItems);
            this.TabPage2.Controls.Add(this.btnGeneratePDF);
            this.TabPage2.Controls.Add(this.btnCancel);
            this.TabPage2.Controls.Add(this.btnSaveGeneratePDF);
            this.TabPage2.Controls.Add(this.lblTotalAmount);
            this.TabPage2.Controls.Add(this.lblPQItems);
            this.TabPage2.Location = new System.Drawing.Point(4, 28);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(849, 345);
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRFQItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRFQItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.dgvRFQItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRFQItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRFQItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRFQItems.RowsDefaultCellStyle = dataGridViewCellStyle6;
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
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(594, 284);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(207, 38);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "TOTAL 7,408.50";
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
            this.btnCreatePO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnCreatePO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.btnCreatePO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePO.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCreatePO.ForeColor = System.Drawing.Color.White;
            this.btnCreatePO.Location = new System.Drawing.Point(508, 456);
            this.btnCreatePO.Name = "btnCreatePO";
            this.btnCreatePO.Size = new System.Drawing.Size(225, 35);
            this.btnCreatePO.TabIndex = 67;
            this.btnCreatePO.Text = "CREATE PURCHASE ORDER";
            this.btnCreatePO.UseVisualStyleBackColor = false;
            this.btnCreatePO.Click += new System.EventHandler(this.btnCreatePO_Click);
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
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label lblCustomerAddress;
        internal System.Windows.Forms.Label lblCustomerEmail;
        internal System.Windows.Forms.Label lblCustomerNumber;
        internal System.Windows.Forms.Label lblCustomerPerson;
        internal System.Windows.Forms.Label lblCustomerName;
        internal System.Windows.Forms.Label lblCustomerDetails;
        internal System.Windows.Forms.Label lblDeliveryTerms;
        internal System.Windows.Forms.Label lblInFavorOf;
        internal System.Windows.Forms.Label lblPaymentTerms;
        internal System.Windows.Forms.Label lblToDate;
        internal System.Windows.Forms.Label lblFromDate;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label lblRFQNumber;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label lblPQNumber;
        internal System.Windows.Forms.Label lblQuotationDetails;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Label lblTotalAmount;
        internal System.Windows.Forms.Label lblPQItems;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSaveGeneratePDF;
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
    }
}