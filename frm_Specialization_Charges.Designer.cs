namespace Dental_Clinic_Management_System
{
    partial class frm_Specialization_Charges
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
            this.tb_Doctor_ID = new System.Windows.Forms.TextBox();
            this.lbl_Doctor_ID = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Specialization_Details = new System.Windows.Forms.DataGridView();
            this.Specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialization_Charges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_Doctor_Name = new System.Windows.Forms.TextBox();
            this.lbl_Doctor_Name = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Specialization_Charges = new System.Windows.Forms.TextBox();
            this.tb_Specialization = new System.Windows.Forms.TextBox();
            this.lbl_Specialization = new System.Windows.Forms.Label();
            this.lbl_Specialization_Charges = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Add_Specialization = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Specialization_Details)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Doctor_ID
            // 
            this.tb_Doctor_ID.Enabled = false;
            this.tb_Doctor_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Doctor_ID.Location = new System.Drawing.Point(270, 144);
            this.tb_Doctor_ID.MaxLength = 10;
            this.tb_Doctor_ID.Name = "tb_Doctor_ID";
            this.tb_Doctor_ID.Size = new System.Drawing.Size(361, 36);
            this.tb_Doctor_ID.TabIndex = 1;
            // 
            // lbl_Doctor_ID
            // 
            this.lbl_Doctor_ID.AutoSize = true;
            this.lbl_Doctor_ID.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Doctor_ID.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Doctor_ID.ForeColor = System.Drawing.Color.Black;
            this.lbl_Doctor_ID.Location = new System.Drawing.Point(102, 148);
            this.lbl_Doctor_ID.Name = "lbl_Doctor_ID";
            this.lbl_Doctor_ID.Size = new System.Drawing.Size(130, 30);
            this.lbl_Doctor_ID.TabIndex = 9;
            this.lbl_Doctor_ID.Text = "Doctor ID";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Crimson;
            this.btn_Add.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(533, 123);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(178, 48);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_Specialization_Details
            // 
            this.dgv_Specialization_Details.AllowUserToAddRows = false;
            this.dgv_Specialization_Details.AllowUserToDeleteRows = false;
            this.dgv_Specialization_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Specialization_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Specialization_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Specialization,
            this.Specialization_Charges});
            this.dgv_Specialization_Details.Location = new System.Drawing.Point(60, 193);
            this.dgv_Specialization_Details.Name = "dgv_Specialization_Details";
            this.dgv_Specialization_Details.ReadOnly = true;
            this.dgv_Specialization_Details.RowTemplate.Height = 24;
            this.dgv_Specialization_Details.Size = new System.Drawing.Size(1176, 209);
            this.dgv_Specialization_Details.TabIndex = 10;
            // 
            // Specialization
            // 
            this.Specialization.HeaderText = "Specialization";
            this.Specialization.Name = "Specialization";
            this.Specialization.ReadOnly = true;
            // 
            // Specialization_Charges
            // 
            this.Specialization_Charges.HeaderText = "Specialization_Charges";
            this.Specialization_Charges.Name = "Specialization_Charges";
            this.Specialization_Charges.ReadOnly = true;
            // 
            // tb_Doctor_Name
            // 
            this.tb_Doctor_Name.Enabled = false;
            this.tb_Doctor_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Doctor_Name.Location = new System.Drawing.Point(931, 146);
            this.tb_Doctor_Name.MaxLength = 20;
            this.tb_Doctor_Name.Name = "tb_Doctor_Name";
            this.tb_Doctor_Name.Size = new System.Drawing.Size(361, 34);
            this.tb_Doctor_Name.TabIndex = 2;
            // 
            // lbl_Doctor_Name
            // 
            this.lbl_Doctor_Name.AutoSize = true;
            this.lbl_Doctor_Name.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Doctor_Name.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_Doctor_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Doctor_Name.Location = new System.Drawing.Point(707, 149);
            this.lbl_Doctor_Name.Name = "lbl_Doctor_Name";
            this.lbl_Doctor_Name.Size = new System.Drawing.Size(164, 30);
            this.lbl_Doctor_Name.TabIndex = 11;
            this.lbl_Doctor_Name.Text = "Doctor Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.tb_Specialization_Charges);
            this.groupBox2.Controls.Add(this.tb_Specialization);
            this.groupBox2.Controls.Add(this.lbl_Specialization);
            this.groupBox2.Controls.Add(this.lbl_Specialization_Charges);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.dgv_Specialization_Details);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.Location = new System.Drawing.Point(27, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1311, 495);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Specialization Details";
            // 
            // tb_Specialization_Charges
            // 
            this.tb_Specialization_Charges.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Specialization_Charges.Location = new System.Drawing.Point(918, 45);
            this.tb_Specialization_Charges.MaxLength = 10;
            this.tb_Specialization_Charges.Name = "tb_Specialization_Charges";
            this.tb_Specialization_Charges.Size = new System.Drawing.Size(361, 36);
            this.tb_Specialization_Charges.TabIndex = 5;
            this.tb_Specialization_Charges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Specialization_Charges_KeyPress);
            // 
            // tb_Specialization
            // 
            this.tb_Specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Specialization.Location = new System.Drawing.Point(225, 45);
            this.tb_Specialization.MaxLength = 40;
            this.tb_Specialization.Multiline = true;
            this.tb_Specialization.Name = "tb_Specialization";
            this.tb_Specialization.Size = new System.Drawing.Size(379, 63);
            this.tb_Specialization.TabIndex = 4;
            // 
            // lbl_Specialization
            // 
            this.lbl_Specialization.AutoSize = true;
            this.lbl_Specialization.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Specialization.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_Specialization.ForeColor = System.Drawing.Color.Black;
            this.lbl_Specialization.Location = new System.Drawing.Point(31, 49);
            this.lbl_Specialization.Name = "lbl_Specialization";
            this.lbl_Specialization.Size = new System.Drawing.Size(166, 30);
            this.lbl_Specialization.TabIndex = 17;
            this.lbl_Specialization.Text = "Specialization";
            // 
            // lbl_Specialization_Charges
            // 
            this.lbl_Specialization_Charges.AutoSize = true;
            this.lbl_Specialization_Charges.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Specialization_Charges.Font = new System.Drawing.Font("Bell MT", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_Specialization_Charges.ForeColor = System.Drawing.Color.Black;
            this.lbl_Specialization_Charges.Location = new System.Drawing.Point(629, 49);
            this.lbl_Specialization_Charges.Name = "lbl_Specialization_Charges";
            this.lbl_Specialization_Charges.Size = new System.Drawing.Size(262, 30);
            this.lbl_Specialization_Charges.TabIndex = 16;
            this.lbl_Specialization_Charges.Text = "Specialization Charges";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Crimson;
            this.btn_Save.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(533, 409);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(178, 48);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_Add_Specialization);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1379, 91);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dental_Clinic_Management_System.Properties.Resources._87_875613_go_back_button_png_download_blue_dollar_sign1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_Add_Specialization
            // 
            this.lbl_Add_Specialization.AutoSize = true;
            this.lbl_Add_Specialization.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_Add_Specialization.ForeColor = System.Drawing.Color.White;
            this.lbl_Add_Specialization.Location = new System.Drawing.Point(445, 8);
            this.lbl_Add_Specialization.Name = "lbl_Add_Specialization";
            this.lbl_Add_Specialization.Size = new System.Drawing.Size(562, 73);
            this.lbl_Add_Specialization.TabIndex = 0;
            this.lbl_Add_Specialization.Text = "Add Specialization";
            // 
            // frm_Specialization_Charges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1378, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tb_Doctor_Name);
            this.Controls.Add(this.lbl_Doctor_Name);
            this.Controls.Add(this.tb_Doctor_ID);
            this.Controls.Add(this.lbl_Doctor_ID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Specialization_Charges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Specialization Charges";
            this.Load += new System.EventHandler(this.frm_Specialization_Charges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Specialization_Details)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Doctor_ID;
        private System.Windows.Forms.Label lbl_Doctor_ID;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_Specialization_Details;
        private System.Windows.Forms.TextBox tb_Doctor_Name;
        private System.Windows.Forms.Label lbl_Doctor_Name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Specialization;
        private System.Windows.Forms.Label lbl_Specialization_Charges;
        private System.Windows.Forms.TextBox tb_Specialization_Charges;
        private System.Windows.Forms.TextBox tb_Specialization;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Add_Specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialization_Charges;
    }
}