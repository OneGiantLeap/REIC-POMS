namespace REIC_POMS
{
    partial class RFQ_MainScreen
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
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblAllRFQs = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.cbbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblActions = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRFQ = new System.Windows.Forms.DataGridView();
            this.RFQNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnSPRS = new System.Windows.Forms.Button();
            this.btnSIDR = new System.Windows.Forms.Button();
            this.btnPO = new System.Windows.Forms.Button();
            this.btnPQ = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnRFQ = new System.Windows.Forms.Button();
            this.imgREICLogo = new System.Windows.Forms.PictureBox();
            this.imgREICBall = new System.Windows.Forms.PictureBox();
            this.btnViewRFQ = new System.Windows.Forms.PictureBox();
            this.btnCreateRFQ = new System.Windows.Forms.PictureBox();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgREICLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgREICBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewRFQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateRFQ)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Source Sans Pro", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.btnMinimize.Location = new System.Drawing.Point(944, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Source Sans Pro", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.btnExit.Location = new System.Drawing.Point(984, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "✖";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Source Sans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(876, 368);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 30);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(876, 266);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 50);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.Text = "Search for...";
            // 
            // lblAllRFQs
            // 
            this.lblAllRFQs.AutoSize = true;
            this.lblAllRFQs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.lblAllRFQs.Font = new System.Drawing.Font("Source Sans Pro", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblAllRFQs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.lblAllRFQs.Location = new System.Drawing.Point(30, 3);
            this.lblAllRFQs.Name = "lblAllRFQs";
            this.lblAllRFQs.Size = new System.Drawing.Size(602, 44);
            this.lblAllRFQs.TabIndex = 13;
            this.lblAllRFQs.Text = "ALL REQUESTS FOR PRICE QUOTATIONS";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.White;
            this.btnClearSearch.FlatAppearance.BorderSize = 0;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.Font = new System.Drawing.Font("Source Sans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnClearSearch.ForeColor = System.Drawing.Color.Black;
            this.btnClearSearch.Location = new System.Drawing.Point(876, 410);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(130, 30);
            this.btnClearSearch.TabIndex = 14;
            this.btnClearSearch.Text = "CLEAR SEARCH";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // cbbFilterBy
            // 
            this.cbbFilterBy.BackColor = System.Drawing.SystemColors.Window;
            this.cbbFilterBy.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFilterBy.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cbbFilterBy.FormattingEnabled = true;
            this.cbbFilterBy.Items.AddRange(new object[] {
            "Filter by...",
            "Item Name",
            "Part Number"});
            this.cbbFilterBy.Location = new System.Drawing.Point(876, 330);
            this.cbbFilterBy.Name = "cbbFilterBy";
            this.cbbFilterBy.Size = new System.Drawing.Size(130, 26);
            this.cbbFilterBy.TabIndex = 15;
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Font = new System.Drawing.Font("Source Sans Pro Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.lblActions.Location = new System.Drawing.Point(869, 58);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(106, 38);
            this.lblActions.TabIndex = 16;
            this.lblActions.Text = "Actions";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Source Sans Pro Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.lblSearch.Location = new System.Drawing.Point(869, 213);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(101, 38);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.lblAllRFQs);
            this.panel1.Location = new System.Drawing.Point(211, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 54);
            this.panel1.TabIndex = 20;
            // 
            // dgvRFQ
            // 
            this.dgvRFQ.AllowUserToAddRows = false;
            this.dgvRFQ.AllowUserToDeleteRows = false;
            this.dgvRFQ.AllowUserToResizeColumns = false;
            this.dgvRFQ.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRFQ.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRFQ.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.dgvRFQ.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRFQ.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRFQ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRFQ.ColumnHeadersHeight = 24;
            this.dgvRFQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRFQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RFQNo,
            this.RequestDate,
            this.Supplier,
            this.Customer});
            this.dgvRFQ.EnableHeadersVisualStyles = false;
            this.dgvRFQ.Location = new System.Drawing.Point(211, 55);
            this.dgvRFQ.MultiSelect = false;
            this.dgvRFQ.Name = "dgvRFQ";
            this.dgvRFQ.ReadOnly = true;
            this.dgvRFQ.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRFQ.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRFQ.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRFQ.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRFQ.RowTemplate.Height = 24;
            this.dgvRFQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRFQ.ShowCellErrors = false;
            this.dgvRFQ.Size = new System.Drawing.Size(644, 693);
            this.dgvRFQ.TabIndex = 23;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.panel2.Location = new System.Drawing.Point(211, 747);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 20);
            this.panel2.TabIndex = 32;
            // 
            // btnItems
            // 
            this.btnItems.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonInactiveItems;
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.btnItems.Location = new System.Drawing.Point(-2, 190);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(213, 48);
            this.btnItems.TabIndex = 40;
            this.btnItems.TabStop = false;
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            this.btnItems.MouseEnter += new System.EventHandler(this.btnItems_MouseEnter);
            this.btnItems.MouseLeave += new System.EventHandler(this.btnItems_MouseLeave);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonInactiveSignOut;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Location = new System.Drawing.Point(-2, 573);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(213, 48);
            this.btnSignOut.TabIndex = 39;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            this.btnSignOut.MouseEnter += new System.EventHandler(this.btnSignOut_MouseEnter);
            this.btnSignOut.MouseLeave += new System.EventHandler(this.btnSignOut_MouseLeave);
            // 
            // btnSPRS
            // 
            this.btnSPRS.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonInactiveSPRS;
            this.btnSPRS.FlatAppearance.BorderSize = 0;
            this.btnSPRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSPRS.Location = new System.Drawing.Point(-2, 525);
            this.btnSPRS.Name = "btnSPRS";
            this.btnSPRS.Size = new System.Drawing.Size(213, 48);
            this.btnSPRS.TabIndex = 38;
            this.btnSPRS.UseVisualStyleBackColor = true;
            this.btnSPRS.Click += new System.EventHandler(this.btnSPRS_Click);
            this.btnSPRS.MouseEnter += new System.EventHandler(this.btnSPRS_MouseEnter);
            this.btnSPRS.MouseLeave += new System.EventHandler(this.btnSPRS_MouseLeave);
            // 
            // btnSIDR
            // 
            this.btnSIDR.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonInactiveSIDR;
            this.btnSIDR.FlatAppearance.BorderSize = 0;
            this.btnSIDR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSIDR.Location = new System.Drawing.Point(-2, 477);
            this.btnSIDR.Name = "btnSIDR";
            this.btnSIDR.Size = new System.Drawing.Size(213, 48);
            this.btnSIDR.TabIndex = 37;
            this.btnSIDR.UseVisualStyleBackColor = true;
            this.btnSIDR.Click += new System.EventHandler(this.btnSIDR_Click);
            this.btnSIDR.MouseEnter += new System.EventHandler(this.btnSIDR_MouseEnter);
            this.btnSIDR.MouseLeave += new System.EventHandler(this.btnSIDR_MouseLeave);
            // 
            // btnPO
            // 
            this.btnPO.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonInactivePO;
            this.btnPO.FlatAppearance.BorderSize = 0;
            this.btnPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPO.Location = new System.Drawing.Point(-2, 429);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(213, 48);
            this.btnPO.TabIndex = 36;
            this.btnPO.UseVisualStyleBackColor = true;
            this.btnPO.Click += new System.EventHandler(this.btnPO_Click);
            this.btnPO.MouseEnter += new System.EventHandler(this.btnPO_MouseEnter);
            this.btnPO.MouseLeave += new System.EventHandler(this.btnPO_MouseLeave);
            // 
            // btnPQ
            // 
            this.btnPQ.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonInactivePQ;
            this.btnPQ.FlatAppearance.BorderSize = 0;
            this.btnPQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPQ.Location = new System.Drawing.Point(-2, 381);
            this.btnPQ.Name = "btnPQ";
            this.btnPQ.Size = new System.Drawing.Size(213, 48);
            this.btnPQ.TabIndex = 35;
            this.btnPQ.UseVisualStyleBackColor = true;
            this.btnPQ.Click += new System.EventHandler(this.btnPQ_Click);
            this.btnPQ.MouseEnter += new System.EventHandler(this.btnPQ_MouseEnter);
            this.btnPQ.MouseLeave += new System.EventHandler(this.btnPQ_MouseLeave);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonInactiveCustomers;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Source Sans Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.btnCustomers.Location = new System.Drawing.Point(-2, 237);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(213, 48);
            this.btnCustomers.TabIndex = 34;
            this.btnCustomers.TabStop = false;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            this.btnCustomers.MouseEnter += new System.EventHandler(this.btnCustomers_MouseEnter);
            this.btnCustomers.MouseLeave += new System.EventHandler(this.btnCustomers_MouseLeave);
            // 
            // btnRFQ
            // 
            this.btnRFQ.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonActiveRFQ;
            this.btnRFQ.FlatAppearance.BorderSize = 0;
            this.btnRFQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRFQ.Location = new System.Drawing.Point(-2, 333);
            this.btnRFQ.Name = "btnRFQ";
            this.btnRFQ.Size = new System.Drawing.Size(213, 48);
            this.btnRFQ.TabIndex = 33;
            this.btnRFQ.UseVisualStyleBackColor = true;
            this.btnRFQ.Click += new System.EventHandler(this.btnRFQ_Click);
            this.btnRFQ.MouseEnter += new System.EventHandler(this.btnRFQ_MouseEnter);
            this.btnRFQ.MouseLeave += new System.EventHandler(this.btnRFQ_MouseLeave);
            // 
            // imgREICLogo
            // 
            this.imgREICLogo.Image = global::REIC_POMS.Properties.Resources.LogoREICInitials;
            this.imgREICLogo.Location = new System.Drawing.Point(21, 120);
            this.imgREICLogo.Name = "imgREICLogo";
            this.imgREICLogo.Size = new System.Drawing.Size(165, 55);
            this.imgREICLogo.TabIndex = 22;
            this.imgREICLogo.TabStop = false;
            // 
            // imgREICBall
            // 
            this.imgREICBall.Image = global::REIC_POMS.Properties.Resources.LogoROMMA;
            this.imgREICBall.Location = new System.Drawing.Point(57, 17);
            this.imgREICBall.Name = "imgREICBall";
            this.imgREICBall.Size = new System.Drawing.Size(95, 97);
            this.imgREICBall.TabIndex = 21;
            this.imgREICBall.TabStop = false;
            // 
            // btnViewRFQ
            // 
            this.btnViewRFQ.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonViewRFQ;
            this.btnViewRFQ.Location = new System.Drawing.Point(946, 99);
            this.btnViewRFQ.Name = "btnViewRFQ";
            this.btnViewRFQ.Size = new System.Drawing.Size(60, 98);
            this.btnViewRFQ.TabIndex = 19;
            this.btnViewRFQ.TabStop = false;
            this.btnViewRFQ.Click += new System.EventHandler(this.btnViewRFQ_Click);
            this.btnViewRFQ.MouseEnter += new System.EventHandler(this.btnViewRFQ_MouseEnter);
            this.btnViewRFQ.MouseLeave += new System.EventHandler(this.btnViewRFQ_MouseLeave);
            // 
            // btnCreateRFQ
            // 
            this.btnCreateRFQ.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonCreateRFQ;
            this.btnCreateRFQ.Location = new System.Drawing.Point(876, 99);
            this.btnCreateRFQ.Name = "btnCreateRFQ";
            this.btnCreateRFQ.Size = new System.Drawing.Size(60, 98);
            this.btnCreateRFQ.TabIndex = 18;
            this.btnCreateRFQ.TabStop = false;
            this.btnCreateRFQ.Click += new System.EventHandler(this.btnCreateRFQ_Click);
            this.btnCreateRFQ.MouseEnter += new System.EventHandler(this.btnCreateRFQ_MouseEnter);
            this.btnCreateRFQ.MouseLeave += new System.EventHandler(this.btnCreateRFQ_MouseLeave);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackgroundImage = global::REIC_POMS.Properties.Resources.ButtonInactiveSuppliers;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Location = new System.Drawing.Point(-2, 285);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(213, 48);
            this.btnSuppliers.TabIndex = 42;
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            this.btnSuppliers.MouseEnter += new System.EventHandler(this.btnSuppliers_MouseEnter);
            this.btnSuppliers.MouseLeave += new System.EventHandler(this.btnSuppliers_MouseLeave);
            // 
            // RFQ_MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.dgvRFQ);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnSPRS);
            this.Controls.Add(this.btnSIDR);
            this.Controls.Add(this.btnPO);
            this.Controls.Add(this.btnPQ);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnRFQ);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.imgREICLogo);
            this.Controls.Add(this.imgREICBall);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnViewRFQ);
            this.Controls.Add(this.btnCreateRFQ);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.cbbFilterBy);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RFQ_MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.RFQ_MainScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRFQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgREICLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgREICBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewRFQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateRFQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblAllRFQs;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.ComboBox cbbFilterBy;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox btnCreateRFQ;
        private System.Windows.Forms.PictureBox btnViewRFQ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgREICBall;
        private System.Windows.Forms.PictureBox imgREICLogo;
        private System.Windows.Forms.DataGridView dgvRFQ;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRFQ;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnPQ;
        private System.Windows.Forms.Button btnPO;
        private System.Windows.Forms.Button btnSIDR;
        private System.Windows.Forms.Button btnSPRS;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFQNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
    }
}