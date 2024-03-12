namespace Dental_Clinic_Management_System
{
    partial class MDI_Dental_Application
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Dental_Application));
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Logged_In_User_Name = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendPatientDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoctorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDoctorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDoctorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDoctorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmloyeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLabDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchLabTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLabDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treatmentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Logout.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Logout.Location = new System.Drawing.Point(1243, 0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(143, 40);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Logged_In_User_Name
            // 
            this.lbl_Logged_In_User_Name.AutoSize = true;
            this.lbl_Logged_In_User_Name.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_In_User_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Logged_In_User_Name.Location = new System.Drawing.Point(864, 1);
            this.lbl_Logged_In_User_Name.Name = "lbl_Logged_In_User_Name";
            this.lbl_Logged_In_User_Name.Size = new System.Drawing.Size(287, 33);
            this.lbl_Logged_In_User_Name.TabIndex = 3;
            this.lbl_Logged_In_User_Name.Text = "Logged In User Name";
            this.lbl_Logged_In_User_Name.Click += new System.EventHandler(this.lbl_Logged_In_User_Name_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatientToolStripMenuItem,
            this.attendPatientDetailsToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(107, 36);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // addPatientToolStripMenuItem
            // 
            this.addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            this.addPatientToolStripMenuItem.Size = new System.Drawing.Size(255, 36);
            this.addPatientToolStripMenuItem.Text = "Add Patient";
            this.addPatientToolStripMenuItem.Click += new System.EventHandler(this.addPatientToolStripMenuItem_Click);
            // 
            // attendPatientDetailsToolStripMenuItem
            // 
            this.attendPatientDetailsToolStripMenuItem.Name = "attendPatientDetailsToolStripMenuItem";
            this.attendPatientDetailsToolStripMenuItem.Size = new System.Drawing.Size(255, 36);
            this.attendPatientDetailsToolStripMenuItem.Text = "Attend Patient";
            this.attendPatientDetailsToolStripMenuItem.Click += new System.EventHandler(this.attendAppointmentDetailsToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDoctorDetailsToolStripMenuItem,
            this.updateDoctorDetailsToolStripMenuItem,
            this.searchDoctorDetailsToolStripMenuItem,
            this.viewDoctorDetailsToolStripMenuItem});
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.doctorToolStripMenuItem.Text = "Doctor";
            // 
            // addDoctorDetailsToolStripMenuItem
            // 
            this.addDoctorDetailsToolStripMenuItem.Name = "addDoctorDetailsToolStripMenuItem";
            this.addDoctorDetailsToolStripMenuItem.Size = new System.Drawing.Size(343, 36);
            this.addDoctorDetailsToolStripMenuItem.Text = "Add Doctor Details";
            this.addDoctorDetailsToolStripMenuItem.Click += new System.EventHandler(this.addDoctorDetailsToolStripMenuItem_Click);
            // 
            // updateDoctorDetailsToolStripMenuItem
            // 
            this.updateDoctorDetailsToolStripMenuItem.Name = "updateDoctorDetailsToolStripMenuItem";
            this.updateDoctorDetailsToolStripMenuItem.Size = new System.Drawing.Size(343, 36);
            this.updateDoctorDetailsToolStripMenuItem.Text = "Update Doctor Details";
            this.updateDoctorDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDoctorDetailsToolStripMenuItem_Click);
            // 
            // searchDoctorDetailsToolStripMenuItem
            // 
            this.searchDoctorDetailsToolStripMenuItem.Name = "searchDoctorDetailsToolStripMenuItem";
            this.searchDoctorDetailsToolStripMenuItem.Size = new System.Drawing.Size(343, 36);
            this.searchDoctorDetailsToolStripMenuItem.Text = "Search Doctor Details";
            this.searchDoctorDetailsToolStripMenuItem.Click += new System.EventHandler(this.searchDoctorDetailsToolStripMenuItem_Click);
            // 
            // viewDoctorDetailsToolStripMenuItem
            // 
            this.viewDoctorDetailsToolStripMenuItem.Name = "viewDoctorDetailsToolStripMenuItem";
            this.viewDoctorDetailsToolStripMenuItem.Size = new System.Drawing.Size(343, 36);
            this.viewDoctorDetailsToolStripMenuItem.Text = "View Doctor Details";
            this.viewDoctorDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewDoctorDetailsToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmloyeeDetailsToolStripMenuItem,
            this.updateEmployeeToolStripMenuItem,
            this.searchEmployeeDetailsToolStripMenuItem,
            this.viewEmployeeDetailsToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmloyeeDetailsToolStripMenuItem
            // 
            this.addEmloyeeDetailsToolStripMenuItem.Name = "addEmloyeeDetailsToolStripMenuItem";
            this.addEmloyeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(375, 36);
            this.addEmloyeeDetailsToolStripMenuItem.Text = "Add Emloyee Details";
            this.addEmloyeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.addEmloyeeDetailsToolStripMenuItem_Click);
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(375, 36);
            this.updateEmployeeToolStripMenuItem.Text = "Update Employee Details";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeToolStripMenuItem_Click);
            // 
            // searchEmployeeDetailsToolStripMenuItem
            // 
            this.searchEmployeeDetailsToolStripMenuItem.Name = "searchEmployeeDetailsToolStripMenuItem";
            this.searchEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(375, 36);
            this.searchEmployeeDetailsToolStripMenuItem.Text = "Search Employee Details";
            this.searchEmployeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.searchEmployeeDetailsToolStripMenuItem_Click);
            // 
            // viewEmployeeDetailsToolStripMenuItem
            // 
            this.viewEmployeeDetailsToolStripMenuItem.Name = "viewEmployeeDetailsToolStripMenuItem";
            this.viewEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(375, 36);
            this.viewEmployeeDetailsToolStripMenuItem.Text = "View Employee Details";
            this.viewEmployeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeeDetailsToolStripMenuItem_Click);
            // 
            // labToolStripMenuItem
            // 
            this.labToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLabDetailsToolStripMenuItem,
            this.searchLabTestToolStripMenuItem,
            this.viewLabDetailsToolStripMenuItem});
            this.labToolStripMenuItem.Name = "labToolStripMenuItem";
            this.labToolStripMenuItem.Size = new System.Drawing.Size(67, 36);
            this.labToolStripMenuItem.Text = "Lab";
            // 
            // addLabDetailsToolStripMenuItem
            // 
            this.addLabDetailsToolStripMenuItem.Name = "addLabDetailsToolStripMenuItem";
            this.addLabDetailsToolStripMenuItem.Size = new System.Drawing.Size(277, 36);
            this.addLabDetailsToolStripMenuItem.Text = "Add Lab Details";
            this.addLabDetailsToolStripMenuItem.Click += new System.EventHandler(this.addLabDetailsToolStripMenuItem_Click);
            // 
            // searchLabTestToolStripMenuItem
            // 
            this.searchLabTestToolStripMenuItem.Name = "searchLabTestToolStripMenuItem";
            this.searchLabTestToolStripMenuItem.Size = new System.Drawing.Size(277, 36);
            this.searchLabTestToolStripMenuItem.Text = "Search Lab Test";
            this.searchLabTestToolStripMenuItem.Click += new System.EventHandler(this.searchLabTestToolStripMenuItem_Click);
            // 
            // viewLabDetailsToolStripMenuItem
            // 
            this.viewLabDetailsToolStripMenuItem.Name = "viewLabDetailsToolStripMenuItem";
            this.viewLabDetailsToolStripMenuItem.Size = new System.Drawing.Size(277, 36);
            this.viewLabDetailsToolStripMenuItem.Text = "View Lab Details";
            this.viewLabDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewLabDetailsToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsersToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(236, 36);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // UsersToolStripMenuItem
            // 
            this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            this.UsersToolStripMenuItem.Size = new System.Drawing.Size(152, 36);
            this.UsersToolStripMenuItem.Text = "Users";
            this.UsersToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientReportToolStripMenuItem,
            this.doctorReportToolStripMenuItem,
            this.labReportToolStripMenuItem,
            this.treatmentReportToolStripMenuItem,
            this.medicationReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(105, 36);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // patientReportToolStripMenuItem
            // 
            this.patientReportToolStripMenuItem.Name = "patientReportToolStripMenuItem";
            this.patientReportToolStripMenuItem.Size = new System.Drawing.Size(304, 36);
            this.patientReportToolStripMenuItem.Text = "Patient Report";
            this.patientReportToolStripMenuItem.Click += new System.EventHandler(this.patientReportToolStripMenuItem_Click);
            // 
            // doctorReportToolStripMenuItem
            // 
            this.doctorReportToolStripMenuItem.Name = "doctorReportToolStripMenuItem";
            this.doctorReportToolStripMenuItem.Size = new System.Drawing.Size(304, 36);
            this.doctorReportToolStripMenuItem.Text = "Doctor Report";
            this.doctorReportToolStripMenuItem.Click += new System.EventHandler(this.doctorReportToolStripMenuItem_Click);
            // 
            // labReportToolStripMenuItem
            // 
            this.labReportToolStripMenuItem.Name = "labReportToolStripMenuItem";
            this.labReportToolStripMenuItem.Size = new System.Drawing.Size(304, 36);
            this.labReportToolStripMenuItem.Text = "Lab Report";
            this.labReportToolStripMenuItem.Click += new System.EventHandler(this.labReportToolStripMenuItem_Click);
            // 
            // treatmentReportToolStripMenuItem
            // 
            this.treatmentReportToolStripMenuItem.Name = "treatmentReportToolStripMenuItem";
            this.treatmentReportToolStripMenuItem.Size = new System.Drawing.Size(304, 36);
            this.treatmentReportToolStripMenuItem.Text = "Treatment Report";
            this.treatmentReportToolStripMenuItem.Click += new System.EventHandler(this.treatmentReportToolStripMenuItem_Click);
            // 
            // medicationReportToolStripMenuItem
            // 
            this.medicationReportToolStripMenuItem.Name = "medicationReportToolStripMenuItem";
            this.medicationReportToolStripMenuItem.Size = new System.Drawing.Size(304, 36);
            this.medicationReportToolStripMenuItem.Text = "Medication Report";
            this.medicationReportToolStripMenuItem.Click += new System.EventHandler(this.medicationReportToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.labToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1386, 40);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "41664052-doctor-with-medical-background.jpg");
            this.imageList1.Images.SetKeyName(1, "abc-awards-sks-bottling.jpg");
            this.imageList1.Images.SetKeyName(2, "abt.jpg");
            this.imageList1.Images.SetKeyName(3, "Dental_Care.JPG");
            this.imageList1.Images.SetKeyName(4, "vector-seamless-medical-symbol-on-red-background-with-capsules_zJZZa_ju_thumb.jpg" +
        "");
            this.imageList1.Images.SetKeyName(5, "dental-services-oral-health.jpg");
            this.imageList1.Images.SetKeyName(6, "dentistry.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1386, 811);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 811);
            this.panel1.TabIndex = 7;
            // 
            // MDI_Dental_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1386, 811);
            this.Controls.Add(this.lbl_Logged_In_User_Name);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDI_Dental_Application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI Dental Application";
            this.Load += new System.EventHandler(this.MDI_Dental_Application_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Logged_In_User_Name;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendPatientDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDoctorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDoctorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDoctorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDoctorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmloyeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLabDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchLabTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLabDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labReportToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem treatmentReportToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem medicationReportToolStripMenuItem;
    }
}



