namespace REIC_POMS
{
    partial class PO_CreateFromPQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PO_CreateFromPQ));
            this.dgvPQSelection = new System.Windows.Forms.DataGridView();
            this.PQNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PQDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpItemSelected = new System.Windows.Forms.GroupBox();
            this.btnAddtoPO = new System.Windows.Forms.Button();
            this.lblPQSelected = new System.Windows.Forms.Label();
            this.lblPQNumber = new System.Windows.Forms.Label();
            this.txtPQNo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreatePO = new System.Windows.Forms.Button();
            this.lblSelectedPQ = new System.Windows.Forms.Label();
            this.dgvPQSelected = new System.Windows.Forms.DataGridView();
            this.SelectedPQNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedPQDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedValDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearPQ = new System.Windows.Forms.Button();
            this.btnRemovePQ = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPQSelection)).BeginInit();
            this.grpItemSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPQSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPQSelection
            // 
            this.dgvPQSelection.AllowUserToAddRows = false;
            this.dgvPQSelection.AllowUserToDeleteRows = false;
            this.dgvPQSelection.AllowUserToResizeColumns = false;
            this.dgvPQSelection.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPQSelection.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPQSelection.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.dgvPQSelection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPQSelection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPQSelection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPQSelection.ColumnHeadersHeight = 24;
            this.dgvPQSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPQSelection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PQNo,
            this.PQDate,
            this.Customer,
            this.ValDate});
            this.dgvPQSelection.EnableHeadersVisualStyles = false;
            this.dgvPQSelection.Location = new System.Drawing.Point(26, 102);
            this.dgvPQSelection.MultiSelect = false;
            this.dgvPQSelection.Name = "dgvPQSelection";
            this.dgvPQSelection.ReadOnly = true;
            this.dgvPQSelection.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPQSelection.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPQSelection.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPQSelection.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPQSelection.RowTemplate.Height = 24;
            this.dgvPQSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPQSelection.ShowCellErrors = false;
            this.dgvPQSelection.Size = new System.Drawing.Size(584, 179);
            this.dgvPQSelection.TabIndex = 25;
            this.dgvPQSelection.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPQSelection_CellClick);
            // 
            // PQNo
            // 
            this.PQNo.HeaderText = "PQ NO.";
            this.PQNo.Name = "PQNo";
            this.PQNo.ReadOnly = true;
            this.PQNo.Width = 115;
            // 
            // PQDate
            // 
            this.PQDate.HeaderText = "PQ DATE";
            this.PQDate.Name = "PQDate";
            this.PQDate.ReadOnly = true;
            this.PQDate.Width = 110;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "CUSTOMER";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Width = 210;
            // 
            // ValDate
            // 
            this.ValDate.HeaderText = "VALIDITY DATE";
            this.ValDate.Name = "ValDate";
            this.ValDate.ReadOnly = true;
            this.ValDate.Width = 210;
            // 
            // grpItemSelected
            // 
            this.grpItemSelected.Controls.Add(this.btnAddtoPO);
            this.grpItemSelected.Controls.Add(this.lblPQSelected);
            this.grpItemSelected.Controls.Add(this.lblPQNumber);
            this.grpItemSelected.Controls.Add(this.txtPQNo);
            this.grpItemSelected.Location = new System.Drawing.Point(631, 102);
            this.grpItemSelected.Name = "grpItemSelected";
            this.grpItemSelected.Size = new System.Drawing.Size(212, 193);
            this.grpItemSelected.TabIndex = 75;
            this.grpItemSelected.TabStop = false;
            // 
            // btnAddtoPO
            // 
            this.btnAddtoPO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnAddtoPO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.btnAddtoPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtoPO.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddtoPO.ForeColor = System.Drawing.Color.White;
            this.btnAddtoPO.Location = new System.Drawing.Point(35, 114);
            this.btnAddtoPO.Name = "btnAddtoPO";
            this.btnAddtoPO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddtoPO.Size = new System.Drawing.Size(149, 26);
            this.btnAddtoPO.TabIndex = 87;
            this.btnAddtoPO.Text = "ADD TO PURCHASE ORDER";
            this.btnAddtoPO.UseVisualStyleBackColor = false;
            this.btnAddtoPO.Click += new System.EventHandler(this.btnAddtoPO_Click);
            // 
            // lblPQSelected
            // 
            this.lblPQSelected.AutoSize = true;
            this.lblPQSelected.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPQSelected.Font = new System.Drawing.Font("Source Sans Pro", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPQSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblPQSelected.Location = new System.Drawing.Point(10, 0);
            this.lblPQSelected.Name = "lblPQSelected";
            this.lblPQSelected.Size = new System.Drawing.Size(138, 31);
            this.lblPQSelected.TabIndex = 68;
            this.lblPQSelected.Text = "PQ Selected";
            // 
            // lblPQNumber
            // 
            this.lblPQNumber.AutoSize = true;
            this.lblPQNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPQNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblPQNumber.Location = new System.Drawing.Point(13, 38);
            this.lblPQNumber.Name = "lblPQNumber";
            this.lblPQNumber.Size = new System.Drawing.Size(80, 18);
            this.lblPQNumber.TabIndex = 2;
            this.lblPQNumber.Text = "PQ NUMBER";
            // 
            // txtPQNo
            // 
            this.txtPQNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txtPQNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPQNo.Enabled = false;
            this.txtPQNo.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtPQNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPQNo.Location = new System.Drawing.Point(16, 59);
            this.txtPQNo.Name = "txtPQNo";
            this.txtPQNo.Size = new System.Drawing.Size(175, 26);
            this.txtPQNo.TabIndex = 70;
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
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreatePO
            // 
            this.btnCreatePO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnCreatePO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.btnCreatePO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePO.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCreatePO.ForeColor = System.Drawing.Color.White;
            this.btnCreatePO.Location = new System.Drawing.Point(631, 447);
            this.btnCreatePO.Name = "btnCreatePO";
            this.btnCreatePO.Size = new System.Drawing.Size(196, 35);
            this.btnCreatePO.TabIndex = 85;
            this.btnCreatePO.Text = "CREATE PURCHASE ORDER";
            this.btnCreatePO.UseVisualStyleBackColor = false;
            this.btnCreatePO.Click += new System.EventHandler(this.btnCreatePO_Click);
            // 
            // lblSelectedPQ
            // 
            this.lblSelectedPQ.AutoSize = true;
            this.lblSelectedPQ.Font = new System.Drawing.Font("Source Sans Pro", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSelectedPQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(63)))), ((int)(((byte)(1)))));
            this.lblSelectedPQ.Location = new System.Drawing.Point(30, 299);
            this.lblSelectedPQ.Name = "lblSelectedPQ";
            this.lblSelectedPQ.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSelectedPQ.Size = new System.Drawing.Size(339, 38);
            this.lblSelectedPQ.TabIndex = 82;
            this.lblSelectedPQ.Text = "Price Quotations Selected";
            // 
            // dgvPQSelected
            // 
            this.dgvPQSelected.AllowUserToAddRows = false;
            this.dgvPQSelected.AllowUserToDeleteRows = false;
            this.dgvPQSelected.AllowUserToResizeColumns = false;
            this.dgvPQSelected.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPQSelected.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPQSelected.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.dgvPQSelected.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPQSelected.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPQSelected.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPQSelected.ColumnHeadersHeight = 24;
            this.dgvPQSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPQSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectedPQNo,
            this.SelectedPQDate,
            this.SelectedCustomer,
            this.SelectedValDate});
            this.dgvPQSelected.EnableHeadersVisualStyles = false;
            this.dgvPQSelected.Location = new System.Drawing.Point(27, 346);
            this.dgvPQSelected.MultiSelect = false;
            this.dgvPQSelected.Name = "dgvPQSelected";
            this.dgvPQSelected.ReadOnly = true;
            this.dgvPQSelected.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPQSelected.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPQSelected.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPQSelected.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPQSelected.RowTemplate.Height = 24;
            this.dgvPQSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPQSelected.ShowCellErrors = false;
            this.dgvPQSelected.Size = new System.Drawing.Size(584, 179);
            this.dgvPQSelected.TabIndex = 81;
            // 
            // SelectedPQNo
            // 
            this.SelectedPQNo.HeaderText = "PQ NO.";
            this.SelectedPQNo.Name = "SelectedPQNo";
            this.SelectedPQNo.ReadOnly = true;
            this.SelectedPQNo.Width = 115;
            // 
            // SelectedPQDate
            // 
            this.SelectedPQDate.HeaderText = "PQ DATE";
            this.SelectedPQDate.Name = "SelectedPQDate";
            this.SelectedPQDate.ReadOnly = true;
            this.SelectedPQDate.Width = 110;
            // 
            // SelectedCustomer
            // 
            this.SelectedCustomer.HeaderText = "CUSTOMER";
            this.SelectedCustomer.Name = "SelectedCustomer";
            this.SelectedCustomer.ReadOnly = true;
            this.SelectedCustomer.Width = 210;
            // 
            // SelectedValDate
            // 
            this.SelectedValDate.HeaderText = "VALIDITY DATE";
            this.SelectedValDate.Name = "SelectedValDate";
            this.SelectedValDate.ReadOnly = true;
            this.SelectedValDate.Width = 210;
            // 
            // btnClearPQ
            // 
            this.btnClearPQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearPQ.BackgroundImage")));
            this.btnClearPQ.FlatAppearance.BorderSize = 0;
            this.btnClearPQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnClearPQ.Location = new System.Drawing.Point(746, 355);
            this.btnClearPQ.Name = "btnClearPQ";
            this.btnClearPQ.Size = new System.Drawing.Size(60, 67);
            this.btnClearPQ.TabIndex = 84;
            this.btnClearPQ.UseVisualStyleBackColor = true;
            this.btnClearPQ.Click += new System.EventHandler(this.btnClearPQ_Click);
            // 
            // btnRemovePQ
            // 
            this.btnRemovePQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemovePQ.BackgroundImage")));
            this.btnRemovePQ.FlatAppearance.BorderSize = 0;
            this.btnRemovePQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePQ.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemovePQ.Location = new System.Drawing.Point(666, 355);
            this.btnRemovePQ.Name = "btnRemovePQ";
            this.btnRemovePQ.Size = new System.Drawing.Size(60, 67);
            this.btnRemovePQ.TabIndex = 83;
            this.btnRemovePQ.UseVisualStyleBackColor = true;
            this.btnRemovePQ.Click += new System.EventHandler(this.btnRemovePQ_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 81);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PO_CreateFromPQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(839, 561);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreatePO);
            this.Controls.Add(this.btnClearPQ);
            this.Controls.Add(this.btnRemovePQ);
            this.Controls.Add(this.lblSelectedPQ);
            this.Controls.Add(this.dgvPQSelected);
            this.Controls.Add(this.grpItemSelected);
            this.Controls.Add(this.dgvPQSelection);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PO_CreateFromPQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIDR_CreateFromPQForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPQSelection)).EndInit();
            this.grpItemSelected.ResumeLayout(false);
            this.grpItemSelected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPQSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPQSelection;
        private System.Windows.Forms.GroupBox grpItemSelected;
        private System.Windows.Forms.Label lblPQSelected;
        private System.Windows.Forms.Label lblPQNumber;
        private System.Windows.Forms.TextBox txtPQNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreatePO;
        private System.Windows.Forms.Button btnClearPQ;
        private System.Windows.Forms.Button btnRemovePQ;
        private System.Windows.Forms.Label lblSelectedPQ;
        private System.Windows.Forms.DataGridView dgvPQSelected;
        private System.Windows.Forms.Button btnAddtoPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedPQNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedPQDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedValDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PQNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PQDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValDate;
    }
}