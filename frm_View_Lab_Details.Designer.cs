namespace Dental_Clinic_Management_System
{
    partial class frm_View_Lab_Details
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
            this.dgv_Lab_Details = new System.Windows.Forms.DataGridView();
            this.labIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dental_Clinic_Management_System_DBDataSet2 = new Dental_Clinic_Management_System.Dental_Clinic_Management_System_DBDataSet2();
            this.lab_DetailsTableAdapter = new Dental_Clinic_Management_System.Dental_Clinic_Management_System_DBDataSet2TableAdapters.Lab_DetailsTableAdapter();
            this.panel = new System.Windows.Forms.Panel();
            this.lbl_View_Lab_Details = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lab_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental_Clinic_Management_System_DBDataSet2)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Lab_Details
            // 
            this.dgv_Lab_Details.AllowUserToAddRows = false;
            this.dgv_Lab_Details.AllowUserToDeleteRows = false;
            this.dgv_Lab_Details.AutoGenerateColumns = false;
            this.dgv_Lab_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Lab_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lab_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.labIDDataGridViewTextBoxColumn,
            this.labNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactNo1DataGridViewTextBoxColumn,
            this.contactNo2DataGridViewTextBoxColumn,
            this.ownerNameDataGridViewTextBoxColumn,
            this.licenceNoDataGridViewTextBoxColumn});
            this.dgv_Lab_Details.DataSource = this.labDetailsBindingSource;
            this.dgv_Lab_Details.Location = new System.Drawing.Point(34, 131);
            this.dgv_Lab_Details.Name = "dgv_Lab_Details";
            this.dgv_Lab_Details.ReadOnly = true;
            this.dgv_Lab_Details.RowTemplate.Height = 24;
            this.dgv_Lab_Details.Size = new System.Drawing.Size(1285, 556);
            this.dgv_Lab_Details.TabIndex = 0;
            // 
            // labIDDataGridViewTextBoxColumn
            // 
            this.labIDDataGridViewTextBoxColumn.DataPropertyName = "Lab_ID";
            this.labIDDataGridViewTextBoxColumn.HeaderText = "Lab_ID";
            this.labIDDataGridViewTextBoxColumn.Name = "labIDDataGridViewTextBoxColumn";
            this.labIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // labNameDataGridViewTextBoxColumn
            // 
            this.labNameDataGridViewTextBoxColumn.DataPropertyName = "Lab_Name";
            this.labNameDataGridViewTextBoxColumn.HeaderText = "Lab_Name";
            this.labNameDataGridViewTextBoxColumn.Name = "labNameDataGridViewTextBoxColumn";
            this.labNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNo1DataGridViewTextBoxColumn
            // 
            this.contactNo1DataGridViewTextBoxColumn.DataPropertyName = "Contact_No1";
            this.contactNo1DataGridViewTextBoxColumn.HeaderText = "Contact_No1";
            this.contactNo1DataGridViewTextBoxColumn.Name = "contactNo1DataGridViewTextBoxColumn";
            this.contactNo1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNo2DataGridViewTextBoxColumn
            // 
            this.contactNo2DataGridViewTextBoxColumn.DataPropertyName = "Contact_No2";
            this.contactNo2DataGridViewTextBoxColumn.HeaderText = "Contact_No2";
            this.contactNo2DataGridViewTextBoxColumn.Name = "contactNo2DataGridViewTextBoxColumn";
            this.contactNo2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerNameDataGridViewTextBoxColumn
            // 
            this.ownerNameDataGridViewTextBoxColumn.DataPropertyName = "Owner_Name";
            this.ownerNameDataGridViewTextBoxColumn.HeaderText = "Owner_Name";
            this.ownerNameDataGridViewTextBoxColumn.Name = "ownerNameDataGridViewTextBoxColumn";
            this.ownerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // licenceNoDataGridViewTextBoxColumn
            // 
            this.licenceNoDataGridViewTextBoxColumn.DataPropertyName = "Licence_No";
            this.licenceNoDataGridViewTextBoxColumn.HeaderText = "Licence_No";
            this.licenceNoDataGridViewTextBoxColumn.Name = "licenceNoDataGridViewTextBoxColumn";
            this.licenceNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // labDetailsBindingSource
            // 
            this.labDetailsBindingSource.DataMember = "Lab_Details";
            this.labDetailsBindingSource.DataSource = this.dental_Clinic_Management_System_DBDataSet2;
            // 
            // dental_Clinic_Management_System_DBDataSet2
            // 
            this.dental_Clinic_Management_System_DBDataSet2.DataSetName = "Dental_Clinic_Management_System_DBDataSet2";
            this.dental_Clinic_Management_System_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lab_DetailsTableAdapter
            // 
            this.lab_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.HotPink;
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.lbl_View_Lab_Details);
            this.panel.Location = new System.Drawing.Point(2, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1376, 95);
            this.panel.TabIndex = 3;
            // 
            // lbl_View_Lab_Details
            // 
            this.lbl_View_Lab_Details.AutoSize = true;
            this.lbl_View_Lab_Details.BackColor = System.Drawing.Color.HotPink;
            this.lbl_View_Lab_Details.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_View_Lab_Details.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_View_Lab_Details.Location = new System.Drawing.Point(375, 11);
            this.lbl_View_Lab_Details.Name = "lbl_View_Lab_Details";
            this.lbl_View_Lab_Details.Size = new System.Drawing.Size(502, 73);
            this.lbl_View_Lab_Details.TabIndex = 0;
            this.lbl_View_Lab_Details.Text = "View Lab Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dental_Clinic_Management_System.Properties.Resources._87_875613_go_back_button_png_download_blue_dollar_sign1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_View_Lab_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1378, 756);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dgv_Lab_Details);
            this.Name = "frm_View_Lab_Details";
            this.Text = "View Lab Details";
            this.Load += new System.EventHandler(this.frm_View_Lab_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lab_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental_Clinic_Management_System_DBDataSet2)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Lab_Details;
        private Dental_Clinic_Management_System_DBDataSet2 dental_Clinic_Management_System_DBDataSet2;
        private System.Windows.Forms.BindingSource labDetailsBindingSource;
        private Dental_Clinic_Management_System_DBDataSet2TableAdapters.Lab_DetailsTableAdapter lab_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn labIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNo2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbl_View_Lab_Details;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}