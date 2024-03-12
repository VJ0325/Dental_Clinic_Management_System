namespace Dental_Clinic_Management_System
{
    partial class Crystal_View
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
            this.Lab_crystal_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Doctor_Report1 = new Dental_Clinic_Management_System.Reports.Doctor_Report();
            this.SuspendLayout();
            // 
            // Lab_crystal_Report
            // 
            this.Lab_crystal_Report.ActiveViewIndex = 0;
            this.Lab_crystal_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lab_crystal_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lab_crystal_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lab_crystal_Report.Location = new System.Drawing.Point(0, 0);
            this.Lab_crystal_Report.Name = "Lab_crystal_Report";
            this.Lab_crystal_Report.ReportSource = this.Doctor_Report1;
            this.Lab_crystal_Report.Size = new System.Drawing.Size(1504, 688);
            this.Lab_crystal_Report.TabIndex = 2;
            this.Lab_crystal_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Crystal_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 688);
            this.Controls.Add(this.Lab_crystal_Report);
            this.Name = "Crystal_View";
            this.Text = "Crystal_View";
            this.Load += new System.EventHandler(this.Crystal_View_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Lab_crystal_Report;
        private Reports.Doctor_Report Doctor_Report1;
       // private CrystalReport1 CrystalReport11;
    }
}