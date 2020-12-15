
namespace StudentInformationSystem
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.CrystalReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrystalReport
            // 
            this.CrystalReport.ActiveViewIndex = -1;
            this.CrystalReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrystalReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrystalReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrystalReport.Location = new System.Drawing.Point(0, 0);
            this.CrystalReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CrystalReport.Name = "CrystalReport";
            this.CrystalReport.Size = new System.Drawing.Size(1200, 623);
            this.CrystalReport.TabIndex = 0;
            this.CrystalReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CrystalReport.ToolPanelWidth = 300;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.CrystalReport);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReport;
    }
}