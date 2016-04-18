namespace REIC_POMS
{
    partial class Item_AddForm
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
            this.tabItemForm = new System.Windows.Forms.TabControl();
            this.tabItemDetails = new System.Windows.Forms.TabPage();
            this.cbbUOM = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtItemDesc = new System.Windows.Forms.TextBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.nudMOQ = new System.Windows.Forms.NumericUpDown();
            this.txtREICPrice = new System.Windows.Forms.TextBox();
            this.cbbMarkup = new System.Windows.Forms.ComboBox();
            this.nudSuppPrice = new System.Windows.Forms.NumericUpDown();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblValPeriod = new System.Windows.Forms.Label();
            this.lblUOM = new System.Windows.Forms.Label();
            this.lblMOQ = new System.Windows.Forms.Label();
            this.lblREICPrice = new System.Windows.Forms.Label();
            this.lblMarkup = new System.Windows.Forms.Label();
            this.lblSuppPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblPartNumber = new System.Windows.Forms.Label();
            this.lblItemDetails = new System.Windows.Forms.Label();
            this.tabSupplierDetails = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.txtSupplierNumber = new System.Windows.Forms.TextBox();
            this.txtSupplierPerson = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.lblSupplierEmail = new System.Windows.Forms.Label();
            this.lblSupplierNumber = new System.Windows.Forms.Label();
            this.lblSupplierPerson = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplierDetails = new System.Windows.Forms.Label();
            this.imgAddItem = new System.Windows.Forms.PictureBox();
            this.tabItemForm.SuspendLayout();
            this.tabItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMOQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuppPrice)).BeginInit();
            this.tabSupplierDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabItemForm
            // 
            this.tabItemForm.Controls.Add(this.tabItemDetails);
            this.tabItemForm.Controls.Add(this.tabSupplierDetails);
            this.tabItemForm.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabItemForm.Location = new System.Drawing.Point(0, 70);
            this.tabItemForm.Name = "tabItemForm";
            this.tabItemForm.SelectedIndex = 0;
            this.tabItemForm.Size = new System.Drawing.Size(370, 540);
            this.tabItemForm.TabIndex = 0;
            // 
            // tabItemDetails
            // 
            this.tabItemDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.tabItemDetails.Controls.Add(this.cbbUOM);
            this.tabItemDetails.Controls.Add(this.btnNext);
            this.tabItemDetails.Controls.Add(this.txtItemDesc);
            this.tabItemDetails.Controls.Add(this.dtpToDate);
            this.tabItemDetails.Controls.Add(this.dtpFromDate);
            this.tabItemDetails.Controls.Add(this.nudMOQ);
            this.tabItemDetails.Controls.Add(this.txtREICPrice);
            this.tabItemDetails.Controls.Add(this.cbbMarkup);
            this.tabItemDetails.Controls.Add(this.nudSuppPrice);
            this.tabItemDetails.Controls.Add(this.txtItemName);
            this.tabItemDetails.Controls.Add(this.txtPartNumber);
            this.tabItemDetails.Controls.Add(this.lblItemDesc);
            this.tabItemDetails.Controls.Add(this.lblToDate);
            this.tabItemDetails.Controls.Add(this.lblFromDate);
            this.tabItemDetails.Controls.Add(this.lblValPeriod);
            this.tabItemDetails.Controls.Add(this.lblUOM);
            this.tabItemDetails.Controls.Add(this.lblMOQ);
            this.tabItemDetails.Controls.Add(this.lblREICPrice);
            this.tabItemDetails.Controls.Add(this.lblMarkup);
            this.tabItemDetails.Controls.Add(this.lblSuppPrice);
            this.tabItemDetails.Controls.Add(this.lblItemName);
            this.tabItemDetails.Controls.Add(this.lblPartNumber);
            this.tabItemDetails.Controls.Add(this.lblItemDetails);
            this.tabItemDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tabItemDetails.Location = new System.Drawing.Point(4, 28);
            this.tabItemDetails.Name = "tabItemDetails";
            this.tabItemDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabItemDetails.Size = new System.Drawing.Size(362, 508);
            this.tabItemDetails.TabIndex = 0;
            this.tabItemDetails.Text = "Item Details";
            // 
            // cbbUOM
            // 
            this.cbbUOM.FormattingEnabled = true;
            this.cbbUOM.Items.AddRange(new object[] {
            "g",
            "lb",
            "somethings",
            "someth",
            "some"});
            this.cbbUOM.Location = new System.Drawing.Point(277, 245);
            this.cbbUOM.Name = "cbbUOM";
            this.cbbUOM.Size = new System.Drawing.Size(50, 27);
            this.cbbUOM.TabIndex = 22;
            this.cbbUOM.SelectedIndexChanged += new System.EventHandler(this.cbbUOM_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Source Sans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Location = new System.Drawing.Point(237, 462);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 35);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.Location = new System.Drawing.Point(29, 368);
            this.txtItemDesc.Multiline = true;
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.Size = new System.Drawing.Size(298, 74);
            this.txtItemDesc.TabIndex = 20;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "MM/dd/yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(212, 303);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(115, 26);
            this.dtpToDate.TabIndex = 19;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "MM/dd/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(67, 303);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(115, 26);
            this.dtpFromDate.TabIndex = 18;
            // 
            // nudMOQ
            // 
            this.nudMOQ.Location = new System.Drawing.Point(210, 244);
            this.nudMOQ.Name = "nudMOQ";
            this.nudMOQ.Size = new System.Drawing.Size(50, 26);
            this.nudMOQ.TabIndex = 17;
            this.nudMOQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtREICPrice
            // 
            this.txtREICPrice.HideSelection = false;
            this.txtREICPrice.Location = new System.Drawing.Point(29, 245);
            this.txtREICPrice.Name = "txtREICPrice";
            this.txtREICPrice.ReadOnly = true;
            this.txtREICPrice.Size = new System.Drawing.Size(139, 26);
            this.txtREICPrice.TabIndex = 16;
            this.txtREICPrice.TextChanged += new System.EventHandler(this.txtREICPrice_TextChanged);
            // 
            // cbbMarkup
            // 
            this.cbbMarkup.DisplayMember = "0";
            this.cbbMarkup.FormattingEnabled = true;
            this.cbbMarkup.Items.AddRange(new object[] {
            "0",
            "10",
            "15",
            "25",
            "35",
            "50"});
            this.cbbMarkup.Location = new System.Drawing.Point(210, 186);
            this.cbbMarkup.Name = "cbbMarkup";
            this.cbbMarkup.Size = new System.Drawing.Size(50, 27);
            this.cbbMarkup.TabIndex = 15;
            this.cbbMarkup.SelectedIndexChanged += new System.EventHandler(this.cbbMarkup_SelectedIndexChanged);
            // 
            // nudSuppPrice
            // 
            this.nudSuppPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSuppPrice.Location = new System.Drawing.Point(29, 186);
            this.nudSuppPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSuppPrice.Name = "nudSuppPrice";
            this.nudSuppPrice.Size = new System.Drawing.Size(139, 26);
            this.nudSuppPrice.TabIndex = 14;
            this.nudSuppPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSuppPrice.ValueChanged += new System.EventHandler(this.nudSuppPrice_ValueChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(29, 124);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(298, 25);
            this.txtItemName.TabIndex = 13;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(127, 70);
            this.txtPartNumber.MaxLength = 6;
            this.txtPartNumber.Multiline = true;
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(200, 25);
            this.txtPartNumber.TabIndex = 12;
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.AutoSize = true;
            this.lblItemDesc.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblItemDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblItemDesc.Location = new System.Drawing.Point(26, 345);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(124, 18);
            this.lblItemDesc.TabIndex = 11;
            this.lblItemDesc.Text = "ITEM DESCRIPTION";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblToDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblToDate.Location = new System.Drawing.Point(187, 307);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(24, 19);
            this.lblToDate.TabIndex = 10;
            this.lblToDate.Text = "To";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblFromDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblFromDate.Location = new System.Drawing.Point(27, 307);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(41, 19);
            this.lblFromDate.TabIndex = 9;
            this.lblFromDate.Text = "From";
            // 
            // lblValPeriod
            // 
            this.lblValPeriod.AutoSize = true;
            this.lblValPeriod.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblValPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblValPeriod.Location = new System.Drawing.Point(26, 282);
            this.lblValPeriod.Name = "lblValPeriod";
            this.lblValPeriod.Size = new System.Drawing.Size(245, 18);
            this.lblValPeriod.TabIndex = 8;
            this.lblValPeriod.Text = "VALIDITY PERIOD OF SUPPLIER\'S PRICE";
            // 
            // lblUOM
            // 
            this.lblUOM.AutoSize = true;
            this.lblUOM.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblUOM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblUOM.Location = new System.Drawing.Point(277, 223);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(36, 18);
            this.lblUOM.TabIndex = 7;
            this.lblUOM.Text = "UOM";
            // 
            // lblMOQ
            // 
            this.lblMOQ.AutoSize = true;
            this.lblMOQ.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMOQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblMOQ.Location = new System.Drawing.Point(207, 223);
            this.lblMOQ.Name = "lblMOQ";
            this.lblMOQ.Size = new System.Drawing.Size(36, 18);
            this.lblMOQ.TabIndex = 6;
            this.lblMOQ.Text = "MOQ";
            // 
            // lblREICPrice
            // 
            this.lblREICPrice.AutoSize = true;
            this.lblREICPrice.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblREICPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblREICPrice.Location = new System.Drawing.Point(26, 224);
            this.lblREICPrice.Name = "lblREICPrice";
            this.lblREICPrice.Size = new System.Drawing.Size(140, 18);
            this.lblREICPrice.TabIndex = 5;
            this.lblREICPrice.Text = "REIC\'S UNIT PRICE (₱)";
            // 
            // lblMarkup
            // 
            this.lblMarkup.AutoSize = true;
            this.lblMarkup.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMarkup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblMarkup.Location = new System.Drawing.Point(207, 164);
            this.lblMarkup.Name = "lblMarkup";
            this.lblMarkup.Size = new System.Drawing.Size(85, 18);
            this.lblMarkup.TabIndex = 4;
            this.lblMarkup.Text = "MARK-UP(%)";
            // 
            // lblSuppPrice
            // 
            this.lblSuppPrice.AutoSize = true;
            this.lblSuppPrice.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSuppPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblSuppPrice.Location = new System.Drawing.Point(26, 164);
            this.lblSuppPrice.Name = "lblSuppPrice";
            this.lblSuppPrice.Size = new System.Drawing.Size(172, 18);
            this.lblSuppPrice.TabIndex = 3;
            this.lblSuppPrice.Text = "SUPPLIER\'S UNIT PRICE (₱)";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblItemName.Location = new System.Drawing.Point(26, 102);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(76, 18);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "ITEM NAME";
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.AutoSize = true;
            this.lblPartNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPartNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblPartNumber.Location = new System.Drawing.Point(26, 70);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(94, 18);
            this.lblPartNumber.TabIndex = 1;
            this.lblPartNumber.Text = "PART NUMBER";
            // 
            // lblItemDetails
            // 
            this.lblItemDetails.AutoSize = true;
            this.lblItemDetails.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblItemDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.lblItemDetails.Location = new System.Drawing.Point(22, 16);
            this.lblItemDetails.Name = "lblItemDetails";
            this.lblItemDetails.Size = new System.Drawing.Size(166, 38);
            this.lblItemDetails.TabIndex = 0;
            this.lblItemDetails.Text = "Item Details";
            // 
            // tabSupplierDetails
            // 
            this.tabSupplierDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.tabSupplierDetails.Controls.Add(this.btnCancel);
            this.tabSupplierDetails.Controls.Add(this.btnAdd);
            this.tabSupplierDetails.Controls.Add(this.txtSupplierAddress);
            this.tabSupplierDetails.Controls.Add(this.txtSupplierEmail);
            this.tabSupplierDetails.Controls.Add(this.txtSupplierNumber);
            this.tabSupplierDetails.Controls.Add(this.txtSupplierPerson);
            this.tabSupplierDetails.Controls.Add(this.txtSupplierName);
            this.tabSupplierDetails.Controls.Add(this.lblSupplierAddress);
            this.tabSupplierDetails.Controls.Add(this.lblSupplierEmail);
            this.tabSupplierDetails.Controls.Add(this.lblSupplierNumber);
            this.tabSupplierDetails.Controls.Add(this.lblSupplierPerson);
            this.tabSupplierDetails.Controls.Add(this.lblSupplierName);
            this.tabSupplierDetails.Controls.Add(this.lblSupplierDetails);
            this.tabSupplierDetails.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.tabSupplierDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tabSupplierDetails.Location = new System.Drawing.Point(4, 28);
            this.tabSupplierDetails.Name = "tabSupplierDetails";
            this.tabSupplierDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabSupplierDetails.Size = new System.Drawing.Size(362, 508);
            this.tabSupplierDetails.TabIndex = 1;
            this.tabSupplierDetails.Text = "Supplier Details";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Source Sans Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnCancel.Location = new System.Drawing.Point(187, 441);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Source Sans Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.btnAdd.Location = new System.Drawing.Point(29, 441);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtSupplierAddress.Location = new System.Drawing.Point(29, 318);
            this.txtSupplierAddress.Multiline = true;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(298, 75);
            this.txtSupplierAddress.TabIndex = 10;
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtSupplierEmail.Location = new System.Drawing.Point(29, 259);
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.Size = new System.Drawing.Size(298, 26);
            this.txtSupplierEmail.TabIndex = 9;
            // 
            // txtSupplierNumber
            // 
            this.txtSupplierNumber.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtSupplierNumber.Location = new System.Drawing.Point(29, 201);
            this.txtSupplierNumber.Name = "txtSupplierNumber";
            this.txtSupplierNumber.Size = new System.Drawing.Size(298, 26);
            this.txtSupplierNumber.TabIndex = 8;
            // 
            // txtSupplierPerson
            // 
            this.txtSupplierPerson.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtSupplierPerson.Location = new System.Drawing.Point(29, 142);
            this.txtSupplierPerson.Name = "txtSupplierPerson";
            this.txtSupplierPerson.Size = new System.Drawing.Size(298, 26);
            this.txtSupplierPerson.TabIndex = 7;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(29, 84);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(298, 26);
            this.txtSupplierName.TabIndex = 6;
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSupplierAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblSupplierAddress.Location = new System.Drawing.Point(26, 297);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(66, 18);
            this.lblSupplierAddress.TabIndex = 5;
            this.lblSupplierAddress.Text = "ADDRESS";
            // 
            // lblSupplierEmail
            // 
            this.lblSupplierEmail.AutoSize = true;
            this.lblSupplierEmail.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSupplierEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblSupplierEmail.Location = new System.Drawing.Point(26, 238);
            this.lblSupplierEmail.Name = "lblSupplierEmail";
            this.lblSupplierEmail.Size = new System.Drawing.Size(111, 18);
            this.lblSupplierEmail.TabIndex = 4;
            this.lblSupplierEmail.Text = "E-MAIL ADDRESS";
            // 
            // lblSupplierNumber
            // 
            this.lblSupplierNumber.AutoSize = true;
            this.lblSupplierNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSupplierNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblSupplierNumber.Location = new System.Drawing.Point(26, 180);
            this.lblSupplierNumber.Name = "lblSupplierNumber";
            this.lblSupplierNumber.Size = new System.Drawing.Size(120, 18);
            this.lblSupplierNumber.TabIndex = 3;
            this.lblSupplierNumber.Text = "CONTACT NUMBER";
            // 
            // lblSupplierPerson
            // 
            this.lblSupplierPerson.AutoSize = true;
            this.lblSupplierPerson.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSupplierPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblSupplierPerson.Location = new System.Drawing.Point(26, 121);
            this.lblSupplierPerson.Name = "lblSupplierPerson";
            this.lblSupplierPerson.Size = new System.Drawing.Size(118, 18);
            this.lblSupplierPerson.TabIndex = 2;
            this.lblSupplierPerson.Text = "CONTACT PERSON";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSupplierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblSupplierName.Location = new System.Drawing.Point(26, 63);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(106, 18);
            this.lblSupplierName.TabIndex = 1;
            this.lblSupplierName.Text = "SUPPLIER NAME";
            // 
            // lblSupplierDetails
            // 
            this.lblSupplierDetails.AutoSize = true;
            this.lblSupplierDetails.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSupplierDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.lblSupplierDetails.Location = new System.Drawing.Point(22, 16);
            this.lblSupplierDetails.Name = "lblSupplierDetails";
            this.lblSupplierDetails.Size = new System.Drawing.Size(214, 38);
            this.lblSupplierDetails.TabIndex = 0;
            this.lblSupplierDetails.Text = "Supplier Details";
            // 
            // imgAddItem
            // 
            this.imgAddItem.BackgroundImage = global::REIC_POMS.Properties.Resources.BannerItemAdd;
            this.imgAddItem.InitialImage = global::REIC_POMS.Properties.Resources.BannerItemAdd;
            this.imgAddItem.Location = new System.Drawing.Point(0, 0);
            this.imgAddItem.Name = "imgAddItem";
            this.imgAddItem.Size = new System.Drawing.Size(370, 70);
            this.imgAddItem.TabIndex = 1;
            this.imgAddItem.TabStop = false;
            // 
            // Item_AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(370, 610);
            this.Controls.Add(this.imgAddItem);
            this.Controls.Add(this.tabItemForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Item_AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.Item_AddForm_Load);
            this.tabItemForm.ResumeLayout(false);
            this.tabItemDetails.ResumeLayout(false);
            this.tabItemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMOQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuppPrice)).EndInit();
            this.tabSupplierDetails.ResumeLayout(false);
            this.tabSupplierDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabItemForm;
        private System.Windows.Forms.TabPage tabItemDetails;
        private System.Windows.Forms.Label lblItemDetails;
        private System.Windows.Forms.TabPage tabSupplierDetails;
        private System.Windows.Forms.Label lblPartNumber;
        private System.Windows.Forms.Label lblMOQ;
        private System.Windows.Forms.Label lblREICPrice;
        private System.Windows.Forms.Label lblMarkup;
        private System.Windows.Forms.Label lblSuppPrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemDesc;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblValPeriod;
        private System.Windows.Forms.Label lblUOM;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.NumericUpDown nudMOQ;
        private System.Windows.Forms.TextBox txtREICPrice;
        private System.Windows.Forms.ComboBox cbbMarkup;
        private System.Windows.Forms.NumericUpDown nudSuppPrice;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.TextBox txtItemDesc;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.TextBox txtSupplierNumber;
        private System.Windows.Forms.TextBox txtSupplierPerson;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label lblSupplierEmail;
        private System.Windows.Forms.Label lblSupplierNumber;
        private System.Windows.Forms.Label lblSupplierPerson;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplierDetails;
        private System.Windows.Forms.PictureBox imgAddItem;
        private System.Windows.Forms.ComboBox cbbUOM;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}