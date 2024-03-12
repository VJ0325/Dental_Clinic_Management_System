namespace Dental_Clinic_Management_System
{
    partial class frm_View_Specialization_Charges
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Doctor_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Specialization = new System.Windows.Forms.DataGridView();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dental_Clinic_Management_System_DBDataSet4 = new Dental_Clinic_Management_System.Dental_Clinic_Management_System_DBDataSet4();
            this.specialization_DetailsTableAdapter = new Dental_Clinic_Management_System.Dental_Clinic_Management_System_DBDataSet4TableAdapters.Specialization_DetailsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_View_Specialization = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Specialization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental_Clinic_Management_System_DBDataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Crimson;
            this.btn_Search.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(785, 118);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(175, 48);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Doctor_ID
            // 
            this.tb_Doctor_ID.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Doctor_ID.Location = new System.Drawing.Point(299, 129);
            this.tb_Doctor_ID.MaxLength = 10;
            this.tb_Doctor_ID.Name = "tb_Doctor_ID";
            this.tb_Doctor_ID.Size = new System.Drawing.Size(404, 38);
            this.tb_Doctor_ID.TabIndex = 8;
            this.tb_Doctor_ID.TextChanged += new System.EventHandler(this.tb_Doctor_ID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Doctor ID";
            // 
            // dgv_Specialization
            // 
            this.dgv_Specialization.AllowUserToAddRows = false;
            this.dgv_Specialization.AllowUserToDeleteRows = false;
            this.dgv_Specialization.AutoGenerateColumns = false;
            this.dgv_Specialization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Specialization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Specialization.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorIDDataGridViewTextBoxColumn,
            this.specializationDataGridViewTextBoxColumn,
            this.sChargesDataGridViewTextBoxColumn});
            this.dgv_Specialization.DataSource = this.specializationDetailsBindingSource;
            this.dgv_Specialization.Location = new System.Drawing.Point(58, 197);
            this.dgv_Specialization.Name = "dgv_Specialization";
            this.dgv_Specialization.ReadOnly = true;
            this.dgv_Specialization.RowTemplate.Height = 24;
            this.dgv_Specialization.Size = new System.Drawing.Size(918, 463);
            this.dgv_Specialization.TabIndex = 11;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "Doctor_ID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "Doctor_ID";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "Specialization";
            this.specializationDataGridViewTextBoxColumn.HeaderText = "Specialization";
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            this.specializationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sChargesDataGridViewTextBoxColumn
            // 
            this.sChargesDataGridViewTextBoxColumn.DataPropertyName = "S_Charges";
            this.sChargesDataGridViewTextBoxColumn.HeaderText = "S_Charges";
            this.sChargesDataGridViewTextBoxColumn.Name = "sChargesDataGridViewTextBoxColumn";
            this.sChargesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specializationDetailsBindingSource
            // 
            this.specializationDetailsBindingSource.DataMember = "Specialization_Details";
            this.specializationDetailsBindingSource.DataSource = this.dental_Clinic_Management_System_DBDataSet4;
            // 
            // dental_Clinic_Management_System_DBDataSet4
            // 
            this.dental_Clinic_Management_System_DBDataSet4.DataSetName = "Dental_Clinic_Management_System_DBDataSet4";
            this.dental_Clinic_Management_System_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialization_DetailsTableAdapter
            // 
            this.specialization_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.lbl_View_Specialization);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 91);
            this.panel1.TabIndex = 16;
            // 
            // lbl_View_Specialization
            // 
            this.lbl_View_Specialization.AutoSize = true;
            this.lbl_View_Specialization.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_View_Specialization.ForeColor = System.Drawing.Color.White;
            this.lbl_View_Specialization.Location = new System.Drawing.Point(238, 8);
            this.lbl_View_Specialization.Name = "lbl_View_Specialization";
            this.lbl_View_Specialization.Size = new System.Drawing.Size(585, 73);
            this.lbl_View_Specialization.TabIndex = 0;
            this.lbl_View_Specialization.Text = "View Specialization";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dental_Clinic_Management_System.Properties.Resources.IMG_20220117_165844;
            this.pictureBox1.Location = new System.Drawing.Point(944, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_View_Specialization_Charges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 681);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Specialization);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Doctor_ID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Specialization_Charges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Specialization Charges";
            this.Load += new System.EventHandler(this.frm_View_Specialization_Charges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Specialization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental_Clinic_Management_System_DBDataSet4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Doctor_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Specialization;
        private Dental_Clinic_Management_System_DBDataSet4 dental_Clinic_Management_System_DBDataSet4;
        private System.Windows.Forms.BindingSource specializationDetailsBindingSource;
        private Dental_Clinic_Management_System_DBDataSet4TableAdapters.Specialization_DetailsTableAdapter specialization_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChargesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_View_Specialization;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}