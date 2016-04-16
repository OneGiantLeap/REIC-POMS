namespace REIC_POMS
{
    partial class Customer_ViewForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTinNumber = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCustomerNumber = new System.Windows.Forms.Label();
            this.lblCustomerPerson = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.imgUpdateCustomer = new System.Windows.Forms.PictureBox();
            this.outputBusinessName = new System.Windows.Forms.Label();
            this.outputTinNumber = new System.Windows.Forms.Label();
            this.outputCustomerPerson = new System.Windows.Forms.Label();
            this.outputCustomerNumber = new System.Windows.Forms.Label();
            this.outputCustomerEmail = new System.Windows.Forms.Label();
            this.outputAccountNumber = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.outputCustomerAddress = new System.Windows.Forms.TextBox();
            this.outputCustomerName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpdateCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Source Sans Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnClose.Location = new System.Drawing.Point(201, 477);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 35);
            this.btnClose.TabIndex = 60;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(58)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Source Sans Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.btnUpdate.Location = new System.Drawing.Point(28, 477);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 35);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTinNumber
            // 
            this.lblTinNumber.AutoSize = true;
            this.lblTinNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTinNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblTinNumber.Location = new System.Drawing.Point(25, 136);
            this.lblTinNumber.Name = "lblTinNumber";
            this.lblTinNumber.Size = new System.Drawing.Size(84, 18);
            this.lblTinNumber.TabIndex = 57;
            this.lblTinNumber.Text = "TIN NUMBER";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblBusinessName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblBusinessName.Location = new System.Drawing.Point(25, 100);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(111, 18);
            this.lblBusinessName.TabIndex = 55;
            this.lblBusinessName.Text = "BUSINESS STYLE";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(25, 368);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(66, 18);
            this.lblCustomerAddress.TabIndex = 49;
            this.lblCustomerAddress.Text = "ADDRESS";
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(25, 333);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(111, 18);
            this.lblCustomerEmail.TabIndex = 48;
            this.lblCustomerEmail.Text = "E-MAIL ADDRESS";
            // 
            // lblCustomerNumber
            // 
            this.lblCustomerNumber.AutoSize = true;
            this.lblCustomerNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerNumber.Location = new System.Drawing.Point(25, 263);
            this.lblCustomerNumber.Name = "lblCustomerNumber";
            this.lblCustomerNumber.Size = new System.Drawing.Size(120, 18);
            this.lblCustomerNumber.TabIndex = 47;
            this.lblCustomerNumber.Text = "CONTACT NUMBER";
            // 
            // lblCustomerPerson
            // 
            this.lblCustomerPerson.AutoSize = true;
            this.lblCustomerPerson.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerPerson.Location = new System.Drawing.Point(25, 226);
            this.lblCustomerPerson.Name = "lblCustomerPerson";
            this.lblCustomerPerson.Size = new System.Drawing.Size(118, 18);
            this.lblCustomerPerson.TabIndex = 46;
            this.lblCustomerPerson.Text = "CONTACT PERSON";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(25, 173);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(104, 18);
            this.lblCustomerName.TabIndex = 45;
            this.lblCustomerName.Text = "COMPANY NAME";
            // 
            // imgUpdateCustomer
            // 
            this.imgUpdateCustomer.BackgroundImage = global::REIC_POMS.Properties.Resources.BannerCustomerView;
            this.imgUpdateCustomer.Location = new System.Drawing.Point(0, 0);
            this.imgUpdateCustomer.Name = "imgUpdateCustomer";
            this.imgUpdateCustomer.Size = new System.Drawing.Size(385, 71);
            this.imgUpdateCustomer.TabIndex = 44;
            this.imgUpdateCustomer.TabStop = false;
            // 
            // outputBusinessName
            // 
            this.outputBusinessName.AutoSize = true;
            this.outputBusinessName.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputBusinessName.Location = new System.Drawing.Point(162, 99);
            this.outputBusinessName.Name = "outputBusinessName";
            this.outputBusinessName.Size = new System.Drawing.Size(35, 19);
            this.outputBusinessName.TabIndex = 61;
            this.outputBusinessName.Text = "Text";
            // 
            // outputTinNumber
            // 
            this.outputTinNumber.AutoSize = true;
            this.outputTinNumber.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputTinNumber.Location = new System.Drawing.Point(162, 135);
            this.outputTinNumber.Name = "outputTinNumber";
            this.outputTinNumber.Size = new System.Drawing.Size(35, 19);
            this.outputTinNumber.TabIndex = 62;
            this.outputTinNumber.Text = "Text";
            // 
            // outputCustomerPerson
            // 
            this.outputCustomerPerson.AutoSize = true;
            this.outputCustomerPerson.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputCustomerPerson.Location = new System.Drawing.Point(162, 226);
            this.outputCustomerPerson.Name = "outputCustomerPerson";
            this.outputCustomerPerson.Size = new System.Drawing.Size(35, 19);
            this.outputCustomerPerson.TabIndex = 64;
            this.outputCustomerPerson.Text = "Text";
            // 
            // outputCustomerNumber
            // 
            this.outputCustomerNumber.AutoSize = true;
            this.outputCustomerNumber.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputCustomerNumber.Location = new System.Drawing.Point(162, 262);
            this.outputCustomerNumber.Name = "outputCustomerNumber";
            this.outputCustomerNumber.Size = new System.Drawing.Size(35, 19);
            this.outputCustomerNumber.TabIndex = 65;
            this.outputCustomerNumber.Text = "Text";
            // 
            // outputCustomerEmail
            // 
            this.outputCustomerEmail.AutoSize = true;
            this.outputCustomerEmail.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputCustomerEmail.Location = new System.Drawing.Point(162, 332);
            this.outputCustomerEmail.Name = "outputCustomerEmail";
            this.outputCustomerEmail.Size = new System.Drawing.Size(35, 19);
            this.outputCustomerEmail.TabIndex = 66;
            this.outputCustomerEmail.Text = "Text";
            // 
            // outputAccountNumber
            // 
            this.outputAccountNumber.AutoSize = true;
            this.outputAccountNumber.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputAccountNumber.Location = new System.Drawing.Point(162, 297);
            this.outputAccountNumber.Name = "outputAccountNumber";
            this.outputAccountNumber.Size = new System.Drawing.Size(35, 19);
            this.outputAccountNumber.TabIndex = 69;
            this.outputAccountNumber.Text = "Text";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(25, 298);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(122, 18);
            this.lblAccountNumber.TabIndex = 68;
            this.lblAccountNumber.Text = "ACCOUNT NUMBER";
            // 
            // outputCustomerAddress
            // 
            this.outputCustomerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.outputCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputCustomerAddress.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputCustomerAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.outputCustomerAddress.Location = new System.Drawing.Point(53, 390);
            this.outputCustomerAddress.MaxLength = 150;
            this.outputCustomerAddress.Multiline = true;
            this.outputCustomerAddress.Name = "outputCustomerAddress";
            this.outputCustomerAddress.ReadOnly = true;
            this.outputCustomerAddress.Size = new System.Drawing.Size(302, 75);
            this.outputCustomerAddress.TabIndex = 70;
            this.outputCustomerAddress.Text = "Magic TextBox";
            // 
            // outputCustomerName
            // 
            this.outputCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.outputCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputCustomerName.Font = new System.Drawing.Font("Source Sans Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.outputCustomerName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.outputCustomerName.Location = new System.Drawing.Point(166, 173);
            this.outputCustomerName.MaxLength = 150;
            this.outputCustomerName.Multiline = true;
            this.outputCustomerName.Name = "outputCustomerName";
            this.outputCustomerName.ReadOnly = true;
            this.outputCustomerName.Size = new System.Drawing.Size(207, 39);
            this.outputCustomerName.TabIndex = 71;
            this.outputCustomerName.Text = "Magic TextBox";
            // 
            // Customer_ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(385, 526);
            this.Controls.Add(this.outputCustomerName);
            this.Controls.Add(this.outputCustomerAddress);
            this.Controls.Add(this.outputAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.outputCustomerEmail);
            this.Controls.Add(this.outputCustomerNumber);
            this.Controls.Add(this.outputCustomerPerson);
            this.Controls.Add(this.outputTinNumber);
            this.Controls.Add(this.outputBusinessName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblTinNumber);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.lblCustomerEmail);
            this.Controls.Add(this.lblCustomerNumber);
            this.Controls.Add(this.lblCustomerPerson);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.imgUpdateCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_ViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.imgUpdateCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTinNumber;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCustomerNumber;
        private System.Windows.Forms.Label lblCustomerPerson;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.PictureBox imgUpdateCustomer;
        private System.Windows.Forms.Label outputBusinessName;
        private System.Windows.Forms.Label outputTinNumber;
        private System.Windows.Forms.Label outputCustomerPerson;
        private System.Windows.Forms.Label outputCustomerNumber;
        private System.Windows.Forms.Label outputCustomerEmail;
        private System.Windows.Forms.Label outputAccountNumber;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox outputCustomerAddress;
        private System.Windows.Forms.TextBox outputCustomerName;
    }
}