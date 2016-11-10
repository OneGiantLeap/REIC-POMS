namespace REIC_POMS
{
    partial class SIDR_ViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIDR_ViewForm));
            this.tabSIDRForm = new System.Windows.Forms.TabControl();
            this.tabRequestDetails = new System.Windows.Forms.TabPage();
            this.outputDRNumber = new System.Windows.Forms.Label();
            this.outputSINumber = new System.Windows.Forms.Label();
            this.outputPONumber = new System.Windows.Forms.Label();
            this.outputDeliveryTerms = new System.Windows.Forms.Label();
            this.outputSONo = new System.Windows.Forms.Label();
            this.outputDate = new System.Windows.Forms.Label();
            this.outputTINNumber = new System.Windows.Forms.Label();
            this.outputBusinessName = new System.Windows.Forms.Label();
            this.outputCustomerAddress = new System.Windows.Forms.TextBox();
            this.outputCustomerEmail = new System.Windows.Forms.Label();
            this.outputContactNumber = new System.Windows.Forms.Label();
            this.outputContactPerson = new System.Windows.Forms.Label();
            this.outputCustomerName = new System.Windows.Forms.Label();
            this.lblDRNumber = new System.Windows.Forms.Label();
            this.lblSINumber = new System.Windows.Forms.Label();
            this.lblPONumber = new System.Windows.Forms.Label();
            this.lblTerms = new System.Windows.Forms.Label();
            this.lblSONumber = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTinNumber = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.lblCustomerPerson = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblSoldDeliveredTo = new System.Windows.Forms.Label();
            this.tabItemDetails = new System.Windows.Forms.TabPage();
            this.outputAddVATSale = new System.Windows.Forms.Label();
            this.outputVATZeroRatedSale = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputVATSale = new System.Windows.Forms.Label();
            this.outputTotalAmountDue = new System.Windows.Forms.Label();
            this.outputTotal = new System.Windows.Forms.Label();
            this.outputLessVAT = new System.Windows.Forms.Label();
            this.outputTotalSales = new System.Windows.Forms.Label();
            this.outputAmount = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblAddTwelveVATSale = new System.Windows.Forms.Label();
            this.lblVATZeroRatedSale = new System.Windows.Forms.Label();
            this.lblVATExemptSale = new System.Windows.Forms.Label();
            this.lblVATSale = new System.Windows.Forms.Label();
            this.lblTotalAmountDue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblLessVAT = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.dgvSIDRItems = new System.Windows.Forms.DataGridView();
            this.RFQItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFQDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFQUOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblItemsTotalAmount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGeneratePDF = new System.Windows.Forms.PictureBox();
            this.tabSIDRForm.SuspendLayout();
            this.tabRequestDetails.SuspendLayout();
            this.tabItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSIDRItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeneratePDF)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSIDRForm
            // 
            this.tabSIDRForm.Controls.Add(this.tabRequestDetails);
            this.tabSIDRForm.Controls.Add(this.tabItemDetails);
            this.tabSIDRForm.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSIDRForm.Location = new System.Drawing.Point(1, 71);
            this.tabSIDRForm.Name = "tabSIDRForm";
            this.tabSIDRForm.SelectedIndex = 0;
            this.tabSIDRForm.Size = new System.Drawing.Size(853, 470);
            this.tabSIDRForm.TabIndex = 1;
            // 
            // tabRequestDetails
            // 
            this.tabRequestDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabRequestDetails.Controls.Add(this.outputDRNumber);
            this.tabRequestDetails.Controls.Add(this.outputSINumber);
            this.tabRequestDetails.Controls.Add(this.outputPONumber);
            this.tabRequestDetails.Controls.Add(this.outputDeliveryTerms);
            this.tabRequestDetails.Controls.Add(this.outputSONo);
            this.tabRequestDetails.Controls.Add(this.outputDate);
            this.tabRequestDetails.Controls.Add(this.outputTINNumber);
            this.tabRequestDetails.Controls.Add(this.outputBusinessName);
            this.tabRequestDetails.Controls.Add(this.outputCustomerAddress);
            this.tabRequestDetails.Controls.Add(this.outputCustomerEmail);
            this.tabRequestDetails.Controls.Add(this.outputContactNumber);
            this.tabRequestDetails.Controls.Add(this.outputContactPerson);
            this.tabRequestDetails.Controls.Add(this.outputCustomerName);
            this.tabRequestDetails.Controls.Add(this.lblDRNumber);
            this.tabRequestDetails.Controls.Add(this.lblSINumber);
            this.tabRequestDetails.Controls.Add(this.lblPONumber);
            this.tabRequestDetails.Controls.Add(this.lblTerms);
            this.tabRequestDetails.Controls.Add(this.lblSONumber);
            this.tabRequestDetails.Controls.Add(this.lblDate);
            this.tabRequestDetails.Controls.Add(this.label1);
            this.tabRequestDetails.Controls.Add(this.panel1);
            this.tabRequestDetails.Controls.Add(this.lblTinNumber);
            this.tabRequestDetails.Controls.Add(this.lblCustomerAddress);
            this.tabRequestDetails.Controls.Add(this.lblCustomerEmail);
            this.tabRequestDetails.Controls.Add(this.lblBusinessName);
            this.tabRequestDetails.Controls.Add(this.lblCustomerNumber);
            this.tabRequestDetails.Controls.Add(this.lblCustomerPerson);
            this.tabRequestDetails.Controls.Add(this.lblCustomerName);
            this.tabRequestDetails.Controls.Add(this.lblSoldDeliveredTo);
            this.tabRequestDetails.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabRequestDetails.Location = new System.Drawing.Point(4, 28);
            this.tabRequestDetails.Name = "tabRequestDetails";
            this.tabRequestDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequestDetails.Size = new System.Drawing.Size(845, 438);
            this.tabRequestDetails.TabIndex = 0;
            this.tabRequestDetails.Text = "Sales Invoice & Delivery Receipt Details";
            // 
            // outputDRNumber
            // 
            this.outputDRNumber.AutoSize = true;
            this.outputDRNumber.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputDRNumber.Location = new System.Drawing.Point(664, 274);
            this.outputDRNumber.Name = "outputDRNumber";
            this.outputDRNumber.Size = new System.Drawing.Size(37, 19);
            this.outputDRNumber.TabIndex = 85;
            this.outputDRNumber.Text = "2327";
            // 
            // outputSINumber
            // 
            this.outputSINumber.AutoSize = true;
            this.outputSINumber.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputSINumber.Location = new System.Drawing.Point(664, 232);
            this.outputSINumber.Name = "outputSINumber";
            this.outputSINumber.Size = new System.Drawing.Size(37, 19);
            this.outputSINumber.TabIndex = 84;
            this.outputSINumber.Text = "2327";
            // 
            // outputPONumber
            // 
            this.outputPONumber.AutoSize = true;
            this.outputPONumber.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputPONumber.Location = new System.Drawing.Point(664, 192);
            this.outputPONumber.Name = "outputPONumber";
            this.outputPONumber.Size = new System.Drawing.Size(37, 19);
            this.outputPONumber.TabIndex = 83;
            this.outputPONumber.Text = "2327";
            // 
            // outputDeliveryTerms
            // 
            this.outputDeliveryTerms.AutoSize = true;
            this.outputDeliveryTerms.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputDeliveryTerms.Location = new System.Drawing.Point(664, 153);
            this.outputDeliveryTerms.Name = "outputDeliveryTerms";
            this.outputDeliveryTerms.Size = new System.Drawing.Size(29, 19);
            this.outputDeliveryTerms.TabIndex = 82;
            this.outputDeliveryTerms.Text = "CIF";
            // 
            // outputSONo
            // 
            this.outputSONo.AutoSize = true;
            this.outputSONo.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputSONo.Location = new System.Drawing.Point(664, 113);
            this.outputSONo.Name = "outputSONo";
            this.outputSONo.Size = new System.Drawing.Size(37, 19);
            this.outputSONo.TabIndex = 81;
            this.outputSONo.Text = "2327";
            // 
            // outputDate
            // 
            this.outputDate.AutoSize = true;
            this.outputDate.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputDate.Location = new System.Drawing.Point(664, 77);
            this.outputDate.Name = "outputDate";
            this.outputDate.Size = new System.Drawing.Size(75, 19);
            this.outputDate.TabIndex = 80;
            this.outputDate.Text = "11/20/2015";
            // 
            // outputTINNumber
            // 
            this.outputTINNumber.AutoSize = true;
            this.outputTINNumber.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputTINNumber.Location = new System.Drawing.Point(233, 363);
            this.outputTINNumber.Name = "outputTINNumber";
            this.outputTINNumber.Size = new System.Drawing.Size(108, 19);
            this.outputTINNumber.TabIndex = 79;
            this.outputTINNumber.Text = "353-766-854-000";
            // 
            // outputBusinessName
            // 
            this.outputBusinessName.AutoSize = true;
            this.outputBusinessName.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputBusinessName.Location = new System.Drawing.Point(233, 329);
            this.outputBusinessName.Name = "outputBusinessName";
            this.outputBusinessName.Size = new System.Drawing.Size(90, 19);
            this.outputBusinessName.TabIndex = 78;
            this.outputBusinessName.Text = "Construction";
            // 
            // outputCustomerAddress
            // 
            this.outputCustomerAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputCustomerAddress.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputCustomerAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.outputCustomerAddress.Location = new System.Drawing.Point(61, 258);
            this.outputCustomerAddress.MaxLength = 150;
            this.outputCustomerAddress.Multiline = true;
            this.outputCustomerAddress.Name = "outputCustomerAddress";
            this.outputCustomerAddress.ReadOnly = true;
            this.outputCustomerAddress.Size = new System.Drawing.Size(322, 64);
            this.outputCustomerAddress.TabIndex = 77;
            this.outputCustomerAddress.Text = "Magic TextBox";
            // 
            // outputCustomerEmail
            // 
            this.outputCustomerEmail.AutoSize = true;
            this.outputCustomerEmail.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputCustomerEmail.Location = new System.Drawing.Point(233, 192);
            this.outputCustomerEmail.Name = "outputCustomerEmail";
            this.outputCustomerEmail.Size = new System.Drawing.Size(138, 19);
            this.outputCustomerEmail.TabIndex = 50;
            this.outputCustomerEmail.Text = "abc_co@yahoo.com";
            // 
            // outputContactNumber
            // 
            this.outputContactNumber.AutoSize = true;
            this.outputContactNumber.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputContactNumber.Location = new System.Drawing.Point(233, 153);
            this.outputContactNumber.Name = "outputContactNumber";
            this.outputContactNumber.Size = new System.Drawing.Size(79, 19);
            this.outputContactNumber.TabIndex = 49;
            this.outputContactNumber.Text = "0915555634";
            // 
            // outputContactPerson
            // 
            this.outputContactPerson.AutoSize = true;
            this.outputContactPerson.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputContactPerson.Location = new System.Drawing.Point(233, 113);
            this.outputContactPerson.Name = "outputContactPerson";
            this.outputContactPerson.Size = new System.Drawing.Size(103, 19);
            this.outputContactPerson.TabIndex = 48;
            this.outputContactPerson.Text = "Victoria Carpio";
            // 
            // outputCustomerName
            // 
            this.outputCustomerName.AutoSize = true;
            this.outputCustomerName.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputCustomerName.Location = new System.Drawing.Point(233, 77);
            this.outputCustomerName.Name = "outputCustomerName";
            this.outputCustomerName.Size = new System.Drawing.Size(101, 19);
            this.outputCustomerName.TabIndex = 47;
            this.outputCustomerName.Text = "ABC COMPANY";
            // 
            // lblDRNumber
            // 
            this.lblDRNumber.AutoSize = true;
            this.lblDRNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDRNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblDRNumber.Location = new System.Drawing.Point(497, 275);
            this.lblDRNumber.Name = "lblDRNumber";
            this.lblDRNumber.Size = new System.Drawing.Size(147, 18);
            this.lblDRNumber.TabIndex = 45;
            this.lblDRNumber.Text = "DELIVERY RECEIPT NO.";
            // 
            // lblSINumber
            // 
            this.lblSINumber.AutoSize = true;
            this.lblSINumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSINumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblSINumber.Location = new System.Drawing.Point(497, 233);
            this.lblSINumber.Name = "lblSINumber";
            this.lblSINumber.Size = new System.Drawing.Size(125, 18);
            this.lblSINumber.TabIndex = 44;
            this.lblSINumber.Text = "SALES INVOICE NO.";
            // 
            // lblPONumber
            // 
            this.lblPONumber.AutoSize = true;
            this.lblPONumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPONumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblPONumber.Location = new System.Drawing.Point(497, 193);
            this.lblPONumber.Name = "lblPONumber";
            this.lblPONumber.Size = new System.Drawing.Size(144, 18);
            this.lblPONumber.TabIndex = 43;
            this.lblPONumber.Text = "PURCHASE ORDER NO.";
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTerms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblTerms.Location = new System.Drawing.Point(497, 153);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(50, 18);
            this.lblTerms.TabIndex = 42;
            this.lblTerms.Text = "TERMS";
            // 
            // lblSONumber
            // 
            this.lblSONumber.AutoSize = true;
            this.lblSONumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSONumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblSONumber.Location = new System.Drawing.Point(497, 114);
            this.lblSONumber.Name = "lblSONumber";
            this.lblSONumber.Size = new System.Drawing.Size(117, 18);
            this.lblSONumber.TabIndex = 41;
            this.lblSONumber.Text = "SALES ORDER NO.";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblDate.Location = new System.Drawing.Point(497, 78);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 18);
            this.lblDate.TabIndex = 40;
            this.lblDate.Text = "DATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(493, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 38);
            this.label1.TabIndex = 39;
            this.label1.Text = "Date && Reference Nos.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(471, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 356);
            this.panel1.TabIndex = 31;
            // 
            // lblTinNumber
            // 
            this.lblTinNumber.AutoSize = true;
            this.lblTinNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTinNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblTinNumber.Location = new System.Drawing.Point(32, 364);
            this.lblTinNumber.Name = "lblTinNumber";
            this.lblTinNumber.Size = new System.Drawing.Size(84, 18);
            this.lblTinNumber.TabIndex = 15;
            this.lblTinNumber.Text = "TIN NUMBER";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblCustomerAddress.Location = new System.Drawing.Point(32, 233);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(127, 18);
            this.lblCustomerAddress.TabIndex = 6;
            this.lblCustomerAddress.Text = "COMPANY ADDRESS";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblCustomerEmail.Location = new System.Drawing.Point(32, 193);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(106, 18);
            this.lblCustomerEmail.TabIndex = 5;
            this.lblCustomerEmail.Text = "EMAIL ADDRESS";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBusinessName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblBusinessName.Location = new System.Drawing.Point(32, 329);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(151, 18);
            this.lblBusinessName.TabIndex = 4;
            this.lblBusinessName.Text = "BUSINESS NAME/STYLE";
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.AutoSize = true;
            this.lblCustomerNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblCustomerNumber.Location = new System.Drawing.Point(32, 153);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Size = new System.Drawing.Size(120, 18);
            this.lblCustomerNumber.TabIndex = 3;
            this.lblCustomerNumber.Text = "CONTACT NUMBER";
            // 
            // lblCustomerPerson
            // 
            this.lblCustomerPerson.AutoSize = true;
            this.lblCustomerPerson.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblCustomerPerson.Location = new System.Drawing.Point(32, 114);
            this.lblCustomerPerson.Name = "lblCustomerPerson";
            this.lblCustomerPerson.Size = new System.Drawing.Size(118, 18);
            this.lblCustomerPerson.TabIndex = 2;
            this.lblCustomerPerson.Text = "CONTACT PERSON";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblCustomerName.Location = new System.Drawing.Point(32, 78);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(104, 18);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "COMPANY NAME";
            // 
            // lblSoldDeliveredTo
            // 
            this.lblSoldDeliveredTo.AutoSize = true;
            this.lblSoldDeliveredTo.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSoldDeliveredTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblSoldDeliveredTo.Location = new System.Drawing.Point(26, 23);
            this.lblSoldDeliveredTo.Name = "lblSoldDeliveredTo";
            this.lblSoldDeliveredTo.Size = new System.Drawing.Size(240, 38);
            this.lblSoldDeliveredTo.TabIndex = 0;
            this.lblSoldDeliveredTo.Text = "Sold/Delivered To";
            // 
            // tabItemDetails
            // 
            this.tabItemDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabItemDetails.Controls.Add(this.btnGeneratePDF);
            this.tabItemDetails.Controls.Add(this.outputAddVATSale);
            this.tabItemDetails.Controls.Add(this.outputVATZeroRatedSale);
            this.tabItemDetails.Controls.Add(this.label2);
            this.tabItemDetails.Controls.Add(this.outputVATSale);
            this.tabItemDetails.Controls.Add(this.outputTotalAmountDue);
            this.tabItemDetails.Controls.Add(this.outputTotal);
            this.tabItemDetails.Controls.Add(this.outputLessVAT);
            this.tabItemDetails.Controls.Add(this.outputTotalSales);
            this.tabItemDetails.Controls.Add(this.outputAmount);
            this.tabItemDetails.Controls.Add(this.lblGrandTotal);
            this.tabItemDetails.Controls.Add(this.lblAddTwelveVATSale);
            this.tabItemDetails.Controls.Add(this.lblVATZeroRatedSale);
            this.tabItemDetails.Controls.Add(this.lblVATExemptSale);
            this.tabItemDetails.Controls.Add(this.lblVATSale);
            this.tabItemDetails.Controls.Add(this.lblTotalAmountDue);
            this.tabItemDetails.Controls.Add(this.lblTotal);
            this.tabItemDetails.Controls.Add(this.lblLessVAT);
            this.tabItemDetails.Controls.Add(this.lblTotalSales);
            this.tabItemDetails.Controls.Add(this.dgvSIDRItems);
            this.tabItemDetails.Controls.Add(this.lblItemsTotalAmount);
            this.tabItemDetails.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabItemDetails.Location = new System.Drawing.Point(4, 28);
            this.tabItemDetails.Name = "tabItemDetails";
            this.tabItemDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabItemDetails.Size = new System.Drawing.Size(845, 438);
            this.tabItemDetails.TabIndex = 1;
            this.tabItemDetails.Text = "Item & Total Amount Details";
            // 
            // outputAddVATSale
            // 
            this.outputAddVATSale.AutoSize = true;
            this.outputAddVATSale.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputAddVATSale.Location = new System.Drawing.Point(582, 326);
            this.outputAddVATSale.Name = "outputAddVATSale";
            this.outputAddVATSale.Size = new System.Drawing.Size(59, 19);
            this.outputAddVATSale.TabIndex = 93;
            this.outputAddVATSale.Text = "5,250.00";
            // 
            // outputVATZeroRatedSale
            // 
            this.outputVATZeroRatedSale.AutoSize = true;
            this.outputVATZeroRatedSale.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputVATZeroRatedSale.Location = new System.Drawing.Point(582, 295);
            this.outputVATZeroRatedSale.Name = "outputVATZeroRatedSale";
            this.outputVATZeroRatedSale.Size = new System.Drawing.Size(59, 19);
            this.outputVATZeroRatedSale.TabIndex = 92;
            this.outputVATZeroRatedSale.Text = "5,250.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(582, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 91;
            this.label2.Text = "5,250.00";
            // 
            // outputVATSale
            // 
            this.outputVATSale.AutoSize = true;
            this.outputVATSale.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputVATSale.Location = new System.Drawing.Point(582, 228);
            this.outputVATSale.Name = "outputVATSale";
            this.outputVATSale.Size = new System.Drawing.Size(48, 19);
            this.outputVATSale.TabIndex = 90;
            this.outputVATSale.Text = "630.00";
            // 
            // outputTotalAmountDue
            // 
            this.outputTotalAmountDue.AutoSize = true;
            this.outputTotalAmountDue.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputTotalAmountDue.Location = new System.Drawing.Point(274, 326);
            this.outputTotalAmountDue.Name = "outputTotalAmountDue";
            this.outputTotalAmountDue.Size = new System.Drawing.Size(59, 19);
            this.outputTotalAmountDue.TabIndex = 89;
            this.outputTotalAmountDue.Text = "5,250.00";
            // 
            // outputTotal
            // 
            this.outputTotal.AutoSize = true;
            this.outputTotal.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputTotal.Location = new System.Drawing.Point(274, 296);
            this.outputTotal.Name = "outputTotal";
            this.outputTotal.Size = new System.Drawing.Size(59, 19);
            this.outputTotal.TabIndex = 88;
            this.outputTotal.Text = "5,250.00";
            // 
            // outputLessVAT
            // 
            this.outputLessVAT.AutoSize = true;
            this.outputLessVAT.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputLessVAT.Location = new System.Drawing.Point(274, 264);
            this.outputLessVAT.Name = "outputLessVAT";
            this.outputLessVAT.Size = new System.Drawing.Size(59, 19);
            this.outputLessVAT.TabIndex = 87;
            this.outputLessVAT.Text = "5,250.00";
            // 
            // outputTotalSales
            // 
            this.outputTotalSales.AutoSize = true;
            this.outputTotalSales.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputTotalSales.Location = new System.Drawing.Point(274, 228);
            this.outputTotalSales.Name = "outputTotalSales";
            this.outputTotalSales.Size = new System.Drawing.Size(59, 19);
            this.outputTotalSales.TabIndex = 86;
            this.outputTotalSales.Text = "5,250.00";
            // 
            // outputAmount
            // 
            this.outputAmount.AutoSize = true;
            this.outputAmount.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.outputAmount.Location = new System.Drawing.Point(684, 311);
            this.outputAmount.Name = "outputAmount";
            this.outputAmount.Size = new System.Drawing.Size(121, 38);
            this.outputAmount.TabIndex = 82;
            this.outputAmount.Text = "5,250.00";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblGrandTotal.Location = new System.Drawing.Point(699, 273);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(97, 38);
            this.lblGrandTotal.TabIndex = 81;
            this.lblGrandTotal.Text = "TOTAL";
            // 
            // lblAddTwelveVATSale
            // 
            this.lblAddTwelveVATSale.AutoSize = true;
            this.lblAddTwelveVATSale.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAddTwelveVATSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblAddTwelveVATSale.Location = new System.Drawing.Point(436, 325);
            this.lblAddTwelveVATSale.Name = "lblAddTwelveVATSale";
            this.lblAddTwelveVATSale.Size = new System.Drawing.Size(123, 18);
            this.lblAddTwelveVATSale.TabIndex = 72;
            this.lblAddTwelveVATSale.Text = "ADD 12% VAT SALE";
            // 
            // lblVATZeroRatedSale
            // 
            this.lblVATZeroRatedSale.AutoSize = true;
            this.lblVATZeroRatedSale.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVATZeroRatedSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblVATZeroRatedSale.Location = new System.Drawing.Point(415, 293);
            this.lblVATZeroRatedSale.Name = "lblVATZeroRatedSale";
            this.lblVATZeroRatedSale.Size = new System.Drawing.Size(144, 18);
            this.lblVATZeroRatedSale.TabIndex = 71;
            this.lblVATZeroRatedSale.Text = "VAT ZERO RATED SALE";
            // 
            // lblVATExemptSale
            // 
            this.lblVATExemptSale.AutoSize = true;
            this.lblVATExemptSale.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVATExemptSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblVATExemptSale.Location = new System.Drawing.Point(441, 261);
            this.lblVATExemptSale.Name = "lblVATExemptSale";
            this.lblVATExemptSale.Size = new System.Drawing.Size(118, 18);
            this.lblVATExemptSale.TabIndex = 70;
            this.lblVATExemptSale.Text = "VAT EXEMPT SALE";
            // 
            // lblVATSale
            // 
            this.lblVATSale.AutoSize = true;
            this.lblVATSale.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVATSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblVATSale.Location = new System.Drawing.Point(494, 229);
            this.lblVATSale.Name = "lblVATSale";
            this.lblVATSale.Size = new System.Drawing.Size(65, 18);
            this.lblVATSale.TabIndex = 69;
            this.lblVATSale.Text = "VAT SALE";
            // 
            // lblTotalAmountDue
            // 
            this.lblTotalAmountDue.AutoSize = true;
            this.lblTotalAmountDue.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalAmountDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblTotalAmountDue.Location = new System.Drawing.Point(116, 325);
            this.lblTotalAmountDue.Name = "lblTotalAmountDue";
            this.lblTotalAmountDue.Size = new System.Drawing.Size(132, 18);
            this.lblTotalAmountDue.TabIndex = 68;
            this.lblTotalAmountDue.Text = "TOTAL AMOUNT DUE";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblTotal.Location = new System.Drawing.Point(201, 296);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 18);
            this.lblTotal.TabIndex = 67;
            this.lblTotal.Text = "TOTAL";
            // 
            // lblLessVAT
            // 
            this.lblLessVAT.AutoSize = true;
            this.lblLessVAT.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLessVAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblLessVAT.Location = new System.Drawing.Point(179, 265);
            this.lblLessVAT.Name = "lblLessVAT";
            this.lblLessVAT.Size = new System.Drawing.Size(69, 18);
            this.lblLessVAT.TabIndex = 66;
            this.lblLessVAT.Text = "LESS: VAT";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblTotalSales.Location = new System.Drawing.Point(159, 229);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(89, 18);
            this.lblTotalSales.TabIndex = 65;
            this.lblTotalSales.Text = "TOTAL SALES";
            // 
            // dgvSIDRItems
            // 
            this.dgvSIDRItems.AllowUserToAddRows = false;
            this.dgvSIDRItems.AllowUserToDeleteRows = false;
            this.dgvSIDRItems.AllowUserToResizeColumns = false;
            this.dgvSIDRItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSIDRItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSIDRItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.dgvSIDRItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSIDRItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSIDRItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSIDRItems.ColumnHeadersHeight = 24;
            this.dgvSIDRItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSIDRItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RFQItemName,
            this.RFQDescription,
            this.RFQUOM,
            this.Column1,
            this.Qty,
            this.Column2});
            this.dgvSIDRItems.EnableHeadersVisualStyles = false;
            this.dgvSIDRItems.Location = new System.Drawing.Point(33, 74);
            this.dgvSIDRItems.MultiSelect = false;
            this.dgvSIDRItems.Name = "dgvSIDRItems";
            this.dgvSIDRItems.ReadOnly = true;
            this.dgvSIDRItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSIDRItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSIDRItems.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSIDRItems.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSIDRItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSIDRItems.Size = new System.Drawing.Size(772, 140);
            this.dgvSIDRItems.TabIndex = 23;
            // 
            // RFQItemName
            // 
            this.RFQItemName.HeaderText = "ITEM NAME";
            this.RFQItemName.Name = "RFQItemName";
            this.RFQItemName.ReadOnly = true;
            this.RFQItemName.Width = 150;
            // 
            // RFQDescription
            // 
            this.RFQDescription.HeaderText = "DESCRIPTION";
            this.RFQDescription.Name = "RFQDescription";
            this.RFQDescription.ReadOnly = true;
            this.RFQDescription.Width = 260;
            // 
            // RFQUOM
            // 
            this.RFQUOM.HeaderText = "UOM";
            this.RFQUOM.Name = "RFQUOM";
            this.RFQUOM.ReadOnly = true;
            this.RFQUOM.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "UNIT PRICE";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "QTY.";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ITEM TOTAL";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // lblItemsTotalAmount
            // 
            this.lblItemsTotalAmount.AutoSize = true;
            this.lblItemsTotalAmount.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblItemsTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblItemsTotalAmount.Location = new System.Drawing.Point(26, 23);
            this.lblItemsTotalAmount.Name = "lblItemsTotalAmount";
            this.lblItemsTotalAmount.Size = new System.Drawing.Size(285, 38);
            this.lblItemsTotalAmount.TabIndex = 64;
            this.lblItemsTotalAmount.Text = "Items && Total Amount";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(505, 553);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(225, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE AND GENERATE PDF";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnCancel.Location = new System.Drawing.Point(738, 553);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 35);
            this.btnCancel.TabIndex = 61;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 70);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonPDF;
            this.btnGeneratePDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneratePDF.Location = new System.Drawing.Point(765, 21);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(40, 40);
            this.btnGeneratePDF.TabIndex = 94;
            this.btnGeneratePDF.TabStop = false;
            this.btnGeneratePDF.MouseEnter += new System.EventHandler(this.btnGeneratePDF_MouseEnter);
            this.btnGeneratePDF.MouseLeave += new System.EventHandler(this.btnGeneratePDF_MouseLeave);
            // 
            // SIDR_ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(855, 600);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabSIDRForm);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SIDR_ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFQCreateForm";
            this.tabSIDRForm.ResumeLayout(false);
            this.tabRequestDetails.ResumeLayout(false);
            this.tabRequestDetails.PerformLayout();
            this.tabItemDetails.ResumeLayout(false);
            this.tabItemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSIDRItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeneratePDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabSIDRForm;
        private System.Windows.Forms.TabPage tabRequestDetails;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.Label lblCustomerPerson;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblSoldDeliveredTo;
        private System.Windows.Forms.TabPage tabItemDetails;
        private System.Windows.Forms.Label lblTinNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvSIDRItems;
        private System.Windows.Forms.Label lblItemsTotalAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDRNumber;
        private System.Windows.Forms.Label lblSINumber;
        private System.Windows.Forms.Label lblPONumber;
        private System.Windows.Forms.Label lblTerms;
        private System.Windows.Forms.Label lblSONumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFQItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFQDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFQUOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lblAddTwelveVATSale;
        private System.Windows.Forms.Label lblVATZeroRatedSale;
        private System.Windows.Forms.Label lblVATExemptSale;
        private System.Windows.Forms.Label lblVATSale;
        private System.Windows.Forms.Label lblTotalAmountDue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblLessVAT;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblGrandTotal;
        internal System.Windows.Forms.Label outputDRNumber;
        internal System.Windows.Forms.Label outputSINumber;
        internal System.Windows.Forms.Label outputPONumber;
        internal System.Windows.Forms.Label outputDeliveryTerms;
        internal System.Windows.Forms.Label outputSONo;
        internal System.Windows.Forms.Label outputDate;
        internal System.Windows.Forms.Label outputTINNumber;
        internal System.Windows.Forms.Label outputBusinessName;
        private System.Windows.Forms.TextBox outputCustomerAddress;
        internal System.Windows.Forms.Label outputCustomerEmail;
        internal System.Windows.Forms.Label outputContactNumber;
        internal System.Windows.Forms.Label outputContactPerson;
        internal System.Windows.Forms.Label outputCustomerName;
        internal System.Windows.Forms.Label outputAmount;
        internal System.Windows.Forms.Label outputAddVATSale;
        internal System.Windows.Forms.Label outputVATZeroRatedSale;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label outputVATSale;
        internal System.Windows.Forms.Label outputTotalAmountDue;
        internal System.Windows.Forms.Label outputTotal;
        internal System.Windows.Forms.Label outputLessVAT;
        internal System.Windows.Forms.Label outputTotalSales;
        private System.Windows.Forms.PictureBox btnGeneratePDF;
    }
}