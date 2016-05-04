namespace REIC_POMS
{
    partial class RFQ_ViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RFQ_ViewForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabRFQForm = new System.Windows.Forms.TabControl();
            this.tabRequestDetails = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outputSupplierAddress = new System.Windows.Forms.Label();
            this.outputSupplierEmail = new System.Windows.Forms.Label();
            this.outputSupplierNumber = new System.Windows.Forms.Label();
            this.outputSupplierPerson = new System.Windows.Forms.Label();
            this.outputSupplierName = new System.Windows.Forms.Label();
            this.outputCustomerName = new System.Windows.Forms.Label();
            this.outputDeliveryTerms = new System.Windows.Forms.Label();
            this.outputPaymentTerms = new System.Windows.Forms.Label();
            this.outputDateOfRequest = new System.Windows.Forms.Label();
            this.outputRFQNo = new System.Windows.Forms.Label();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.lblSupplierEmail = new System.Windows.Forms.Label();
            this.lblSupplierNumber = new System.Windows.Forms.Label();
            this.lblSupplierPerson = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplierDetails = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            this.lblDeliveryTerms = new System.Windows.Forms.Label();
            this.lblPaymentTerms = new System.Windows.Forms.Label();
            this.lblDateOfRequest = new System.Windows.Forms.Label();
            this.lblRFQNo = new System.Windows.Forms.Label();
            this.lblRequestDetails = new System.Windows.Forms.Label();
            this.tabItemDetails = new System.Windows.Forms.TabPage();
            this.btnGeneratePDF = new System.Windows.Forms.Button();
            this.dgvRFQItems = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRFQItems = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreatePQ = new System.Windows.Forms.Button();
            this.tabRFQForm.SuspendLayout();
            this.tabRequestDetails.SuspendLayout();
            this.tabItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFQItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRFQForm
            // 
            this.tabRFQForm.Controls.Add(this.tabRequestDetails);
            this.tabRFQForm.Controls.Add(this.tabItemDetails);
            this.tabRFQForm.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabRFQForm.Location = new System.Drawing.Point(1, 71);
            this.tabRFQForm.Name = "tabRFQForm";
            this.tabRFQForm.SelectedIndex = 0;
            this.tabRFQForm.Size = new System.Drawing.Size(853, 377);
            this.tabRFQForm.TabIndex = 2;
            // 
            // tabRequestDetails
            // 
            this.tabRequestDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabRequestDetails.Controls.Add(this.panel1);
            this.tabRequestDetails.Controls.Add(this.outputSupplierAddress);
            this.tabRequestDetails.Controls.Add(this.outputSupplierEmail);
            this.tabRequestDetails.Controls.Add(this.outputSupplierNumber);
            this.tabRequestDetails.Controls.Add(this.outputSupplierPerson);
            this.tabRequestDetails.Controls.Add(this.outputSupplierName);
            this.tabRequestDetails.Controls.Add(this.outputCustomerName);
            this.tabRequestDetails.Controls.Add(this.outputDeliveryTerms);
            this.tabRequestDetails.Controls.Add(this.outputPaymentTerms);
            this.tabRequestDetails.Controls.Add(this.outputDateOfRequest);
            this.tabRequestDetails.Controls.Add(this.outputRFQNo);
            this.tabRequestDetails.Controls.Add(this.lblSupplierAddress);
            this.tabRequestDetails.Controls.Add(this.lblSupplierEmail);
            this.tabRequestDetails.Controls.Add(this.lblSupplierNumber);
            this.tabRequestDetails.Controls.Add(this.lblSupplierPerson);
            this.tabRequestDetails.Controls.Add(this.lblSupplierName);
            this.tabRequestDetails.Controls.Add(this.lblSupplierDetails);
            this.tabRequestDetails.Controls.Add(this.lblCustomerName);
            this.tabRequestDetails.Controls.Add(this.lblCustomerDetails);
            this.tabRequestDetails.Controls.Add(this.lblDeliveryTerms);
            this.tabRequestDetails.Controls.Add(this.lblPaymentTerms);
            this.tabRequestDetails.Controls.Add(this.lblDateOfRequest);
            this.tabRequestDetails.Controls.Add(this.lblRFQNo);
            this.tabRequestDetails.Controls.Add(this.lblRequestDetails);
            this.tabRequestDetails.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabRequestDetails.Location = new System.Drawing.Point(4, 28);
            this.tabRequestDetails.Name = "tabRequestDetails";
            this.tabRequestDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequestDetails.Size = new System.Drawing.Size(845, 345);
            this.tabRequestDetails.TabIndex = 0;
            this.tabRequestDetails.Text = "Request Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(337, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 287);
            this.panel1.TabIndex = 74;
            // 
            // outputSupplierAddress
            // 
            this.outputSupplierAddress.AutoSize = true;
            this.outputSupplierAddress.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputSupplierAddress.Location = new System.Drawing.Point(409, 212);
            this.outputSupplierAddress.Name = "outputSupplierAddress";
            this.outputSupplierAddress.Size = new System.Drawing.Size(35, 19);
            this.outputSupplierAddress.TabIndex = 73;
            this.outputSupplierAddress.Text = "Text";
            // 
            // outputSupplierEmail
            // 
            this.outputSupplierEmail.AutoSize = true;
            this.outputSupplierEmail.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputSupplierEmail.Location = new System.Drawing.Point(529, 160);
            this.outputSupplierEmail.Name = "outputSupplierEmail";
            this.outputSupplierEmail.Size = new System.Drawing.Size(35, 19);
            this.outputSupplierEmail.TabIndex = 72;
            this.outputSupplierEmail.Text = "Text";
            // 
            // outputSupplierNumber
            // 
            this.outputSupplierNumber.AutoSize = true;
            this.outputSupplierNumber.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputSupplierNumber.Location = new System.Drawing.Point(529, 130);
            this.outputSupplierNumber.Name = "outputSupplierNumber";
            this.outputSupplierNumber.Size = new System.Drawing.Size(35, 19);
            this.outputSupplierNumber.TabIndex = 71;
            this.outputSupplierNumber.Text = "Text";
            // 
            // outputSupplierPerson
            // 
            this.outputSupplierPerson.AutoSize = true;
            this.outputSupplierPerson.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputSupplierPerson.Location = new System.Drawing.Point(529, 100);
            this.outputSupplierPerson.Name = "outputSupplierPerson";
            this.outputSupplierPerson.Size = new System.Drawing.Size(35, 19);
            this.outputSupplierPerson.TabIndex = 70;
            this.outputSupplierPerson.Text = "Text";
            // 
            // outputSupplierName
            // 
            this.outputSupplierName.AutoSize = true;
            this.outputSupplierName.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputSupplierName.Location = new System.Drawing.Point(529, 69);
            this.outputSupplierName.Name = "outputSupplierName";
            this.outputSupplierName.Size = new System.Drawing.Size(35, 19);
            this.outputSupplierName.TabIndex = 69;
            this.outputSupplierName.Text = "Text";
            // 
            // outputCustomerName
            // 
            this.outputCustomerName.AutoSize = true;
            this.outputCustomerName.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputCustomerName.Location = new System.Drawing.Point(55, 269);
            this.outputCustomerName.Name = "outputCustomerName";
            this.outputCustomerName.Size = new System.Drawing.Size(35, 19);
            this.outputCustomerName.TabIndex = 68;
            this.outputCustomerName.Text = "Text";
            // 
            // outputDeliveryTerms
            // 
            this.outputDeliveryTerms.AutoSize = true;
            this.outputDeliveryTerms.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputDeliveryTerms.Location = new System.Drawing.Point(175, 161);
            this.outputDeliveryTerms.Name = "outputDeliveryTerms";
            this.outputDeliveryTerms.Size = new System.Drawing.Size(35, 19);
            this.outputDeliveryTerms.TabIndex = 66;
            this.outputDeliveryTerms.Text = "Text";
            // 
            // outputPaymentTerms
            // 
            this.outputPaymentTerms.AutoSize = true;
            this.outputPaymentTerms.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputPaymentTerms.Location = new System.Drawing.Point(175, 129);
            this.outputPaymentTerms.Name = "outputPaymentTerms";
            this.outputPaymentTerms.Size = new System.Drawing.Size(35, 19);
            this.outputPaymentTerms.TabIndex = 64;
            this.outputPaymentTerms.Text = "Text";
            // 
            // outputDateOfRequest
            // 
            this.outputDateOfRequest.AutoSize = true;
            this.outputDateOfRequest.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputDateOfRequest.Location = new System.Drawing.Point(175, 99);
            this.outputDateOfRequest.Name = "outputDateOfRequest";
            this.outputDateOfRequest.Size = new System.Drawing.Size(35, 19);
            this.outputDateOfRequest.TabIndex = 63;
            this.outputDateOfRequest.Text = "Text";
            // 
            // outputRFQNo
            // 
            this.outputRFQNo.AutoSize = true;
            this.outputRFQNo.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputRFQNo.Location = new System.Drawing.Point(175, 69);
            this.outputRFQNo.Name = "outputRFQNo";
            this.outputRFQNo.Size = new System.Drawing.Size(35, 19);
            this.outputRFQNo.TabIndex = 62;
            this.outputRFQNo.Text = "Text";
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSupplierAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblSupplierAddress.Location = new System.Drawing.Point(388, 190);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(127, 18);
            this.lblSupplierAddress.TabIndex = 22;
            this.lblSupplierAddress.Text = "COMPANY ADDRESS";
            // 
            // lblSupplierEmail
            // 
            this.lblSupplierEmail.AutoSize = true;
            this.lblSupplierEmail.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSupplierEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblSupplierEmail.Location = new System.Drawing.Point(390, 160);
            this.lblSupplierEmail.Name = "lblSupplierEmail";
            this.lblSupplierEmail.Size = new System.Drawing.Size(111, 18);
            this.lblSupplierEmail.TabIndex = 21;
            this.lblSupplierEmail.Text = "E-MAIL ADDRESS";
            // 
            // lblSupplierNumber
            // 
            this.lblSupplierNumber.AutoSize = true;
            this.lblSupplierNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSupplierNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblSupplierNumber.Location = new System.Drawing.Point(388, 130);
            this.lblSupplierNumber.Name = "lblSupplierNumber";
            this.lblSupplierNumber.Size = new System.Drawing.Size(120, 18);
            this.lblSupplierNumber.TabIndex = 20;
            this.lblSupplierNumber.Text = "CONTACT NUMBER";
            // 
            // lblSupplierPerson
            // 
            this.lblSupplierPerson.AutoSize = true;
            this.lblSupplierPerson.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSupplierPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblSupplierPerson.Location = new System.Drawing.Point(388, 100);
            this.lblSupplierPerson.Name = "lblSupplierPerson";
            this.lblSupplierPerson.Size = new System.Drawing.Size(118, 18);
            this.lblSupplierPerson.TabIndex = 19;
            this.lblSupplierPerson.Text = "CONTACT PERSON";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSupplierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblSupplierName.Location = new System.Drawing.Point(388, 70);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(106, 18);
            this.lblSupplierName.TabIndex = 18;
            this.lblSupplierName.Text = "SUPPLIER NAME";
            // 
            // lblSupplierDetails
            // 
            this.lblSupplierDetails.AutoSize = true;
            this.lblSupplierDetails.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSupplierDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblSupplierDetails.Location = new System.Drawing.Point(381, 23);
            this.lblSupplierDetails.Name = "lblSupplierDetails";
            this.lblSupplierDetails.Size = new System.Drawing.Size(214, 38);
            this.lblSupplierDetails.TabIndex = 17;
            this.lblSupplierDetails.Text = "Supplier Details";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblCustomerName.Location = new System.Drawing.Point(37, 249);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(104, 18);
            this.lblCustomerName.TabIndex = 15;
            this.lblCustomerName.Text = "COMPANY NAME";
            // 
            // lblCustomerDetails
            // 
            this.lblCustomerDetails.AutoSize = true;
            this.lblCustomerDetails.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblCustomerDetails.Location = new System.Drawing.Point(29, 206);
            this.lblCustomerDetails.Name = "lblCustomerDetails";
            this.lblCustomerDetails.Size = new System.Drawing.Size(230, 38);
            this.lblCustomerDetails.TabIndex = 13;
            this.lblCustomerDetails.Text = "Customer Details";
            // 
            // lblDeliveryTerms
            // 
            this.lblDeliveryTerms.AutoSize = true;
            this.lblDeliveryTerms.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeliveryTerms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblDeliveryTerms.Location = new System.Drawing.Point(35, 162);
            this.lblDeliveryTerms.Name = "lblDeliveryTerms";
            this.lblDeliveryTerms.Size = new System.Drawing.Size(112, 18);
            this.lblDeliveryTerms.TabIndex = 5;
            this.lblDeliveryTerms.Text = "DELIVERY TERMS";
            // 
            // lblPaymentTerms
            // 
            this.lblPaymentTerms.AutoSize = true;
            this.lblPaymentTerms.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblPaymentTerms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblPaymentTerms.Location = new System.Drawing.Point(35, 130);
            this.lblPaymentTerms.Name = "lblPaymentTerms";
            this.lblPaymentTerms.Size = new System.Drawing.Size(110, 18);
            this.lblPaymentTerms.TabIndex = 3;
            this.lblPaymentTerms.Text = "PAYMENT TERMS";
            // 
            // lblDateOfRequest
            // 
            this.lblDateOfRequest.AutoSize = true;
            this.lblDateOfRequest.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDateOfRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblDateOfRequest.Location = new System.Drawing.Point(35, 100);
            this.lblDateOfRequest.Name = "lblDateOfRequest";
            this.lblDateOfRequest.Size = new System.Drawing.Size(120, 18);
            this.lblDateOfRequest.TabIndex = 2;
            this.lblDateOfRequest.Text = "DATE OF REQUEST";
            // 
            // lblRFQNo
            // 
            this.lblRFQNo.AutoSize = true;
            this.lblRFQNo.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblRFQNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblRFQNo.Location = new System.Drawing.Point(35, 70);
            this.lblRFQNo.Name = "lblRFQNo";
            this.lblRFQNo.Size = new System.Drawing.Size(57, 18);
            this.lblRFQNo.TabIndex = 1;
            this.lblRFQNo.Text = "RFQ NO.";
            // 
            // lblRequestDetails
            // 
            this.lblRequestDetails.AutoSize = true;
            this.lblRequestDetails.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblRequestDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblRequestDetails.Location = new System.Drawing.Point(26, 23);
            this.lblRequestDetails.Name = "lblRequestDetails";
            this.lblRequestDetails.Size = new System.Drawing.Size(211, 38);
            this.lblRequestDetails.TabIndex = 0;
            this.lblRequestDetails.Text = "Request Details";
            // 
            // tabItemDetails
            // 
            this.tabItemDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabItemDetails.Controls.Add(this.btnGeneratePDF);
            this.tabItemDetails.Controls.Add(this.dgvRFQItems);
            this.tabItemDetails.Controls.Add(this.lblRFQItems);
            this.tabItemDetails.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabItemDetails.Location = new System.Drawing.Point(4, 28);
            this.tabItemDetails.Name = "tabItemDetails";
            this.tabItemDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabItemDetails.Size = new System.Drawing.Size(845, 345);
            this.tabItemDetails.TabIndex = 1;
            this.tabItemDetails.Text = "Item Details";
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeneratePDF.BackgroundImage")));
            this.btnGeneratePDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGeneratePDF.FlatAppearance.BorderSize = 0;
            this.btnGeneratePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratePDF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeneratePDF.Location = new System.Drawing.Point(768, 25);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(40, 40);
            this.btnGeneratePDF.TabIndex = 69;
            this.btnGeneratePDF.UseVisualStyleBackColor = true;
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
            this.Qty});
            this.dgvRFQItems.EnableHeadersVisualStyles = false;
            this.dgvRFQItems.Location = new System.Drawing.Point(33, 71);
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
            this.dgvRFQItems.TabIndex = 68;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ITEM NAME";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 240;
            // 
            // Description
            // 
            this.Description.HeaderText = "DESCRIPTION";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 375;
            // 
            // UOM
            // 
            this.UOM.HeaderText = "UOM";
            this.UOM.Name = "UOM";
            this.UOM.ReadOnly = true;
            this.UOM.Width = 78;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "QTY.";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 80;
            // 
            // lblRFQItems
            // 
            this.lblRFQItems.AutoSize = true;
            this.lblRFQItems.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblRFQItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblRFQItems.Location = new System.Drawing.Point(26, 23);
            this.lblRFQItems.Name = "lblRFQItems";
            this.lblRFQItems.Size = new System.Drawing.Size(466, 38);
            this.lblRFQItems.TabIndex = 64;
            this.lblRFQItems.Text = "Items in Request for Price Quotation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::REIC_POMS.Properties.Resources.BannerRFQView;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 70);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.btnClose.TabIndex = 65;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreatePQ
            // 
            this.btnCreatePQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnCreatePQ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.btnCreatePQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePQ.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCreatePQ.ForeColor = System.Drawing.Color.White;
            this.btnCreatePQ.Location = new System.Drawing.Point(506, 456);
            this.btnCreatePQ.Name = "btnCreatePQ";
            this.btnCreatePQ.Size = new System.Drawing.Size(225, 35);
            this.btnCreatePQ.TabIndex = 64;
            this.btnCreatePQ.Text = "CREATE PRICE QUOTATION";
            this.btnCreatePQ.UseVisualStyleBackColor = false;
            this.btnCreatePQ.Click += new System.EventHandler(this.btnCreatePQ_Click);
            // 
            // RFQ_ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(855, 500);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreatePQ);
            this.Controls.Add(this.tabRFQForm);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RFQ_ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFQ_VIew";
            this.Load += new System.EventHandler(this.RFQ_ViewForm_Load);
            this.tabRFQForm.ResumeLayout(false);
            this.tabRequestDetails.ResumeLayout(false);
            this.tabRequestDetails.PerformLayout();
            this.tabItemDetails.ResumeLayout(false);
            this.tabItemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFQItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRFQForm;
        private System.Windows.Forms.TabPage tabRequestDetails;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label lblSupplierEmail;
        private System.Windows.Forms.Label lblSupplierNumber;
        private System.Windows.Forms.Label lblSupplierPerson;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplierDetails;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerDetails;
        private System.Windows.Forms.Label lblDeliveryTerms;
        private System.Windows.Forms.Label lblPaymentTerms;
        private System.Windows.Forms.Label lblDateOfRequest;
        private System.Windows.Forms.Label lblRFQNo;
        private System.Windows.Forms.Label lblRequestDetails;
        private System.Windows.Forms.TabPage tabItemDetails;
        private System.Windows.Forms.Label lblRFQItems;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvRFQItems;
        private System.Windows.Forms.Button btnGeneratePDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreatePQ;
        private System.Windows.Forms.Label outputSupplierAddress;
        private System.Windows.Forms.Label outputSupplierEmail;
        private System.Windows.Forms.Label outputSupplierNumber;
        private System.Windows.Forms.Label outputSupplierPerson;
        private System.Windows.Forms.Label outputSupplierName;
        private System.Windows.Forms.Label outputCustomerName;
        private System.Windows.Forms.Label outputDeliveryTerms;
        private System.Windows.Forms.Label outputPaymentTerms;
        private System.Windows.Forms.Label outputDateOfRequest;
        private System.Windows.Forms.Label outputRFQNo;
        private System.Windows.Forms.Panel panel1;
    }
}