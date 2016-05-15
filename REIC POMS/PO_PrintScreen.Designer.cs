namespace REIC_POMS
{
    partial class PO_PrintScreen
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
            this.CrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.POPrintout1 = new REIC_POMS.POPrintout();
            this.SuspendLayout();
            // 
            // CrystalReportViewer
            // 
            this.CrystalReportViewer.ActiveViewIndex = 0;
            this.CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrystalReportViewer.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.CrystalReportViewer.Name = "CrystalReportViewer";
            this.CrystalReportViewer.ReportSource = this.POPrintout1;
            this.CrystalReportViewer.ShowGroupTreeButton = false;
            this.CrystalReportViewer.ShowLogo = false;
            this.CrystalReportViewer.ShowParameterPanelButton = false;
            this.CrystalReportViewer.Size = new System.Drawing.Size(701, 529);
            this.CrystalReportViewer.TabIndex = 0;
            this.CrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // PO_PrintScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 529);
            this.Controls.Add(this.CrystalReportViewer);
            this.Font = new System.Drawing.Font("Source Sans Pro", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "PO_PrintScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Preview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PO_PrintScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewer;
        private POPrintout POPrintout1;
    }
}