namespace Dental_Clinic_Management_System
{
    partial class frm_View_Doctor_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Other_Details = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_View_Doctor_Details = new System.Windows.Forms.Label();
            this.dgv_Doctor_Details = new System.Windows.Forms.DataGridView();
            this.doctorDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dental_Clinic_Management_System_DBDataSet = new Dental_Clinic_Management_System.Dental_Clinic_Management_System_DBDataSet();
            this.doctor_DetailsTableAdapter = new Dental_Clinic_Management_System.Dental_Clinic_Management_System_DBDataSetTableAdapters.Doctor_DetailsTableAdapter();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aadharCardNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pANNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doctor_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental_Clinic_Management_System_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.btn_Other_Details);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_View_Doctor_Details);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1379, 91);
            this.panel1.TabIndex = 3;
            // 
            // btn_Other_Details
            // 
            this.btn_Other_Details.BackColor = System.Drawing.Color.Crimson;
            this.btn_Other_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Other_Details.ForeColor = System.Drawing.SystemColors.Menu;
            this.btn_Other_Details.Location = new System.Drawing.Point(1076, 32);
            this.btn_Other_Details.Name = "btn_Other_Details";
            this.btn_Other_Details.Size = new System.Drawing.Size(270, 49);
            this.btn_Other_Details.TabIndex = 1;
            this.btn_Other_Details.Text = "Other Details";
            this.btn_Other_Details.UseVisualStyleBackColor = false;
            this.btn_Other_Details.Click += new System.EventHandler(this.btn_Other_Details_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dental_Clinic_Management_System.Properties.Resources._87_875613_go_back_button_png_download_blue_dollar_sign1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_View_Doctor_Details
            // 
            this.lbl_View_Doctor_Details.AutoSize = true;
            this.lbl_View_Doctor_Details.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_View_Doctor_Details.ForeColor = System.Drawing.Color.White;
            this.lbl_View_Doctor_Details.Location = new System.Drawing.Point(367, 8);
            this.lbl_View_Doctor_Details.Name = "lbl_View_Doctor_Details";
            this.lbl_View_Doctor_Details.Size = new System.Drawing.Size(592, 73);
            this.lbl_View_Doctor_Details.TabIndex = 0;
            this.lbl_View_Doctor_Details.Text = "View Doctor Details";
            // 
            // dgv_Doctor_Details
            // 
            this.dgv_Doctor_Details.AllowUserToAddRows = false;
            this.dgv_Doctor_Details.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Doctor_Details.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Doctor_Details.AutoGenerateColumns = false;
            this.dgv_Doctor_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Doctor_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Doctor_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorIDDataGridViewTextBoxColumn,
            this.doctorNameDataGridViewTextBoxColumn,
            this.contactNo1DataGridViewTextBoxColumn,
            this.clinicAddressDataGridViewTextBoxColumn,
            this.aadharCardNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.emailIDDataGridViewTextBoxColumn,
            this.pANNoDataGridViewTextBoxColumn,
            this.cFeesDataGridViewTextBoxColumn});
            this.dgv_Doctor_Details.DataSource = this.doctorDetailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Doctor_Details.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Doctor_Details.Location = new System.Drawing.Point(12, 107);
            this.dgv_Doctor_Details.Name = "dgv_Doctor_Details";
            this.dgv_Doctor_Details.ReadOnly = true;
            this.dgv_Doctor_Details.RowTemplate.Height = 24;
            this.dgv_Doctor_Details.Size = new System.Drawing.Size(1354, 637);
            this.dgv_Doctor_Details.TabIndex = 4;
            // 
            // doctorDetailsBindingSource
            // 
            this.doctorDetailsBindingSource.DataMember = "Doctor_Details";
            this.doctorDetailsBindingSource.DataSource = this.dental_Clinic_Management_System_DBDataSet;
            // 
            // dental_Clinic_Management_System_DBDataSet
            // 
            this.dental_Clinic_Management_System_DBDataSet.DataSetName = "Dental_Clinic_Management_System_DBDataSet";
            this.dental_Clinic_Management_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctor_DetailsTableAdapter
            // 
            this.doctor_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "Doctor_ID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "Doctor_ID";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "Doctor_Name";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "Doctor_Name";
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNo1DataGridViewTextBoxColumn
            // 
            this.contactNo1DataGridViewTextBoxColumn.DataPropertyName = "Contact_No1";
            this.contactNo1DataGridViewTextBoxColumn.HeaderText = "Contact_No1";
            this.contactNo1DataGridViewTextBoxColumn.Name = "contactNo1DataGridViewTextBoxColumn";
            this.contactNo1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clinicAddressDataGridViewTextBoxColumn
            // 
            this.clinicAddressDataGridViewTextBoxColumn.DataPropertyName = "Clinic_Address";
            this.clinicAddressDataGridViewTextBoxColumn.HeaderText = "Clinic_Address";
            this.clinicAddressDataGridViewTextBoxColumn.Name = "clinicAddressDataGridViewTextBoxColumn";
            this.clinicAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aadharCardNoDataGridViewTextBoxColumn
            // 
            this.aadharCardNoDataGridViewTextBoxColumn.DataPropertyName = "Aadhar_Card_No";
            this.aadharCardNoDataGridViewTextBoxColumn.HeaderText = "Aadhar_Card_No";
            this.aadharCardNoDataGridViewTextBoxColumn.Name = "aadharCardNoDataGridViewTextBoxColumn";
            this.aadharCardNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailIDDataGridViewTextBoxColumn
            // 
            this.emailIDDataGridViewTextBoxColumn.DataPropertyName = "Email_ID";
            this.emailIDDataGridViewTextBoxColumn.HeaderText = "Email_ID";
            this.emailIDDataGridViewTextBoxColumn.Name = "emailIDDataGridViewTextBoxColumn";
            this.emailIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pANNoDataGridViewTextBoxColumn
            // 
            this.pANNoDataGridViewTextBoxColumn.DataPropertyName = "PAN_No";
            this.pANNoDataGridViewTextBoxColumn.HeaderText = "PAN_No";
            this.pANNoDataGridViewTextBoxColumn.Name = "pANNoDataGridViewTextBoxColumn";
            this.pANNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cFeesDataGridViewTextBoxColumn
            // 
            this.cFeesDataGridViewTextBoxColumn.DataPropertyName = "C_Fees";
            this.cFeesDataGridViewTextBoxColumn.HeaderText = "C_Fees";
            this.cFeesDataGridViewTextBoxColumn.Name = "cFeesDataGridViewTextBoxColumn";
            this.cFeesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_View_Doctor_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1378, 756);
            this.Controls.Add(this.dgv_Doctor_Details);
            this.Controls.Add(this.panel1);
            this.Name = "frm_View_Doctor_Details";
            this.Text = "View_Doctor_Details";
            this.Load += new System.EventHandler(this.frm_View_Doctor_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doctor_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental_Clinic_Management_System_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_View_Doctor_Details;
        private System.Windows.Forms.DataGridView dgv_Doctor_Details;
        private Dental_Clinic_Management_System_DBDataSet dental_Clinic_Management_System_DBDataSet;
        private System.Windows.Forms.BindingSource doctorDetailsBindingSource;
        private Dental_Clinic_Management_System_DBDataSetTableAdapters.Doctor_DetailsTableAdapter doctor_DetailsTableAdapter;
        private System.Windows.Forms.Button btn_Other_Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aadharCardNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pANNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFeesDataGridViewTextBoxColumn;

    }
}