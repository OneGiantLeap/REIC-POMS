namespace REIC_POMS
{
    partial class PQ_CreateFromRFQForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvRFQSelection = new System.Windows.Forms.DataGridView();
            this.RFQNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpItemSelected = new System.Windows.Forms.GroupBox();
            this.btnAddtoQuote = new System.Windows.Forms.Button();
            this.lblRFQSelected = new System.Windows.Forms.Label();
            this.lblIRFQNumber = new System.Windows.Forms.Label();
            this.txtRFQNo = new System.Windows.Forms.TextBox();
            this.dgvRFQSelected = new System.Windows.Forms.DataGridView();
            this.SelectedRFQNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelectedRFQ = new System.Windows.Forms.Label();
            this.btnClearRFQ = new System.Windows.Forms.Button();
            this.btnRemoveRFQ = new System.Windows.Forms.Button();
            this.btnCreatePQ = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFQSelection)).BeginInit();
            this.grpItemSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFQSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::REIC_POMS.Properties.Resources.BannerPQQuickCreate;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 43);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvRFQSelection
            // 
            this.dgvRFQSelection.AllowUserToAddRows = false;
            this.dgvRFQSelection.AllowUserToDeleteRows = false;
            this.dgvRFQSelection.AllowUserToResizeColumns = false;
            this.dgvRFQSelection.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRFQSelection.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRFQSelection.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.dgvRFQSelection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRFQSelection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRFQSelection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRFQSelection.ColumnHeadersHeight = 24;
            this.dgvRFQSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRFQSelection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RFQNo,
            this.RequestDate,
            this.Supplier,
            this.Customer});
            this.dgvRFQSelection.EnableHeadersVisualStyles = false;
            this.dgvRFQSelection.Location = new System.Drawing.Point(26, 102);
            this.dgvRFQSelection.MultiSelect = false;
            this.dgvRFQSelection.Name = "dgvRFQSelection";
            this.dgvRFQSelection.ReadOnly = true;
            this.dgvRFQSelection.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRFQSelection.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRFQSelection.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRFQSelection.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRFQSelection.RowTemplate.Height = 24;
            this.dgvRFQSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRFQSelection.ShowCellErrors = false;
            this.dgvRFQSelection.Size = new System.Drawing.Size(584, 179);
            this.dgvRFQSelection.TabIndex = 24;
            this.dgvRFQSelection.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRFQSelection_CellClick);
            // 
            // RFQNo
            // 
            this.RFQNo.HeaderText = "RFQ NO.";
            this.RFQNo.Name = "RFQNo";
            this.RFQNo.ReadOnly = true;
            this.RFQNo.Width = 115;
            // 
            // RequestDate
            // 
            this.RequestDate.HeaderText = "REQUEST DATE";
            this.RequestDate.Name = "RequestDate";
            this.RequestDate.ReadOnly = true;
            this.RequestDate.Width = 110;
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "SUPPLIER";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            this.Supplier.Width = 210;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "CUSTOMER";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Width = 210;
            // 
            // grpItemSelected
            // 
            this.grpItemSelected.Controls.Add(this.btnAddtoQuote);
            this.grpItemSelected.Controls.Add(this.lblRFQSelected);
            this.grpItemSelected.Controls.Add(this.lblIRFQNumber);
            this.grpItemSelected.Controls.Add(this.txtRFQNo);
            this.grpItemSelected.Location = new System.Drawing.Point(631, 102);
            this.grpItemSelected.Name = "grpItemSelected";
            this.grpItemSelected.Size = new System.Drawing.Size(212, 193);
            this.grpItemSelected.TabIndex = 74;
            this.grpItemSelected.TabStop = false;
            // 
            // btnAddtoQuote
            // 
            this.btnAddtoQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnAddtoQuote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.btnAddtoQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtoQuote.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAddtoQuote.ForeColor = System.Drawing.Color.White;
            this.btnAddtoQuote.Location = new System.Drawing.Point(35, 106);
            this.btnAddtoQuote.Name = "btnAddtoQuote";
            this.btnAddtoQuote.Size = new System.Drawing.Size(149, 26);
            this.btnAddtoQuote.TabIndex = 62;
            this.btnAddtoQuote.Text = "ADD TO PRICE QUOTE";
            this.btnAddtoQuote.UseVisualStyleBackColor = false;
            this.btnAddtoQuote.Click += new System.EventHandler(this.btnAddtoQuote_Click);
            // 
            // lblRFQSelected
            // 
            this.lblRFQSelected.AutoSize = true;
            this.lblRFQSelected.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRFQSelected.Font = new System.Drawing.Font("Source Sans Pro", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblRFQSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblRFQSelected.Location = new System.Drawing.Point(10, 0);
            this.lblRFQSelected.Name = "lblRFQSelected";
            this.lblRFQSelected.Size = new System.Drawing.Size(151, 31);
            this.lblRFQSelected.TabIndex = 68;
            this.lblRFQSelected.Text = "RFQ Selected";
            // 
            // lblIRFQNumber
            // 
            this.lblIRFQNumber.AutoSize = true;
            this.lblIRFQNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIRFQNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblIRFQNumber.Location = new System.Drawing.Point(13, 38);
            this.lblIRFQNumber.Name = "lblIRFQNumber";
            this.lblIRFQNumber.Size = new System.Drawing.Size(87, 18);
            this.lblIRFQNumber.TabIndex = 2;
            this.lblIRFQNumber.Text = "RFQ NUMBER";
            // 
            // txtRFQNo
            // 
            this.txtRFQNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txtRFQNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRFQNo.Enabled = false;
            this.txtRFQNo.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtRFQNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRFQNo.Location = new System.Drawing.Point(16, 59);
            this.txtRFQNo.Name = "txtRFQNo";
            this.txtRFQNo.Size = new System.Drawing.Size(175, 26);
            this.txtRFQNo.TabIndex = 70;
            // 
            // dgvRFQSelected
            // 
            this.dgvRFQSelected.AllowUserToAddRows = false;
            this.dgvRFQSelected.AllowUserToDeleteRows = false;
            this.dgvRFQSelected.AllowUserToResizeColumns = false;
            this.dgvRFQSelected.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRFQSelected.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRFQSelected.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.dgvRFQSelected.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRFQSelected.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRFQSelected.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRFQSelected.ColumnHeadersHeight = 24;
            this.dgvRFQSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRFQSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectedRFQNo,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.SelectedCustomer});
            this.dgvRFQSelected.EnableHeadersVisualStyles = false;
            this.dgvRFQSelected.Location = new System.Drawing.Point(27, 346);
            this.dgvRFQSelected.MultiSelect = false;
            this.dgvRFQSelected.Name = "dgvRFQSelected";
            this.dgvRFQSelected.ReadOnly = true;
            this.dgvRFQSelected.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRFQSelected.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRFQSelected.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRFQSelected.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRFQSelected.RowTemplate.Height = 24;
            this.dgvRFQSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRFQSelected.ShowCellErrors = false;
            this.dgvRFQSelected.Size = new System.Drawing.Size(584, 179);
            this.dgvRFQSelected.TabIndex = 75;
            // 
            // SelectedRFQNo
            // 
            this.SelectedRFQNo.HeaderText = "RFQ NO.";
            this.SelectedRFQNo.Name = "SelectedRFQNo";
            this.SelectedRFQNo.ReadOnly = true;
            this.SelectedRFQNo.Width = 115;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "REQUEST DATE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "SUPPLIER";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 210;
            // 
            // SelectedCustomer
            // 
            this.SelectedCustomer.HeaderText = "CUSTOMER";
            this.SelectedCustomer.Name = "SelectedCustomer";
            this.SelectedCustomer.ReadOnly = true;
            this.SelectedCustomer.Width = 210;
            // 
            // lblSelectedRFQ
            // 
            this.lblSelectedRFQ.AutoSize = true;
            this.lblSelectedRFQ.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSelectedRFQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblSelectedRFQ.Location = new System.Drawing.Point(30, 299);
            this.lblSelectedRFQ.Name = "lblSelectedRFQ";
            this.lblSelectedRFQ.Size = new System.Drawing.Size(476, 38);
            this.lblSelectedRFQ.TabIndex = 76;
            this.lblSelectedRFQ.Text = "Request for Price Quotation Selected";
            // 
            // btnClearRFQ
            // 
            this.btnClearRFQ.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonClearAllItems;
            this.btnClearRFQ.FlatAppearance.BorderSize = 0;
            this.btnClearRFQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRFQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnClearRFQ.Location = new System.Drawing.Point(746, 355);
            this.btnClearRFQ.Name = "btnClearRFQ";
            this.btnClearRFQ.Size = new System.Drawing.Size(60, 67);
            this.btnClearRFQ.TabIndex = 78;
            this.btnClearRFQ.UseVisualStyleBackColor = true;
            this.btnClearRFQ.Click += new System.EventHandler(this.btnClearRFQ_Click);
            // 
            // btnRemoveRFQ
            // 
            this.btnRemoveRFQ.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonRemoveItems;
            this.btnRemoveRFQ.FlatAppearance.BorderSize = 0;
            this.btnRemoveRFQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRFQ.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoveRFQ.Location = new System.Drawing.Point(666, 355);
            this.btnRemoveRFQ.Name = "btnRemoveRFQ";
            this.btnRemoveRFQ.Size = new System.Drawing.Size(60, 67);
            this.btnRemoveRFQ.TabIndex = 77;
            this.btnRemoveRFQ.UseVisualStyleBackColor = true;
            this.btnRemoveRFQ.Click += new System.EventHandler(this.btnRemoveRFQ_Click);
            // 
            // btnCreatePQ
            // 
            this.btnCreatePQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnCreatePQ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.btnCreatePQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePQ.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCreatePQ.ForeColor = System.Drawing.Color.White;
            this.btnCreatePQ.Location = new System.Drawing.Point(631, 447);
            this.btnCreatePQ.Name = "btnCreatePQ";
            this.btnCreatePQ.Size = new System.Drawing.Size(196, 35);
            this.btnCreatePQ.TabIndex = 79;
            this.btnCreatePQ.Text = "CREATE PRICE QUOTATION";
            this.btnCreatePQ.UseVisualStyleBackColor = false;
            this.btnCreatePQ.Click += new System.EventHandler(this.btnCreatePQ_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnCancel.Location = new System.Drawing.Point(678, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 35);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // PQ_CreateFromRFQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(855, 600);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreatePQ);
            this.Controls.Add(this.btnClearRFQ);
            this.Controls.Add(this.btnRemoveRFQ);
            this.Controls.Add(this.lblSelectedRFQ);
            this.Controls.Add(this.dgvRFQSelected);
            this.Controls.Add(this.grpItemSelected);
            this.Controls.Add(this.dgvRFQSelection);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PQ_CreateFromRFQForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PQ_CreateFromRFQForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFQSelection)).EndInit();
            this.grpItemSelected.ResumeLayout(false);
            this.grpItemSelected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFQSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvRFQSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFQNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.GroupBox grpItemSelected;
        private System.Windows.Forms.Button btnAddtoQuote;
        private System.Windows.Forms.Label lblRFQSelected;
        private System.Windows.Forms.Label lblIRFQNumber;
        private System.Windows.Forms.TextBox txtRFQNo;
        private System.Windows.Forms.DataGridView dgvRFQSelected;
        private System.Windows.Forms.Label lblSelectedRFQ;
        private System.Windows.Forms.Button btnClearRFQ;
        private System.Windows.Forms.Button btnRemoveRFQ;
        private System.Windows.Forms.Button btnCreatePQ;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedRFQNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedCustomer;
    }
}