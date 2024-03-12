namespace Dental_Clinic_Management_System
{
    partial class frm_Add_Lab_Tests
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_L_ID = new System.Windows.Forms.TextBox();
            this.lbl_Lab_ID = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_View_Lab_Details = new System.Windows.Forms.Label();
            this.gb_Lab = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Lab_Name = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_Dr_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.lbl_dr_Name = new System.Windows.Forms.Label();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.tb_Duration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Charges = new System.Windows.Forms.TextBox();
            this.tb_T_Cases = new System.Windows.Forms.TextBox();
            this.lbl_Charges = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_Lab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Crimson;
            this.btn_Add.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(257, 690);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(124, 54);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_L_ID
            // 
            this.tb_L_ID.Enabled = false;
            this.tb_L_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_L_ID.Location = new System.Drawing.Point(216, 60);
            this.tb_L_ID.MaxLength = 20;
            this.tb_L_ID.Name = "tb_L_ID";
            this.tb_L_ID.Size = new System.Drawing.Size(240, 38);
            this.tb_L_ID.TabIndex = 1;
            // 
            // lbl_Lab_ID
            // 
            this.lbl_Lab_ID.AutoSize = true;
            this.lbl_Lab_ID.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Lab_ID.Font = new System.Drawing.Font("Bell MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lab_ID.ForeColor = System.Drawing.Color.Black;
            this.lbl_Lab_ID.Location = new System.Drawing.Point(45, 67);
            this.lbl_Lab_ID.Name = "lbl_Lab_ID";
            this.lbl_Lab_ID.Size = new System.Drawing.Size(97, 31);
            this.lbl_Lab_ID.TabIndex = 1;
            this.lbl_Lab_ID.Text = "Lab ID";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.HotPink;
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.lbl_View_Lab_Details);
            this.panel.Location = new System.Drawing.Point(1, 1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1376, 86);
            this.panel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dental_Clinic_Management_System.Properties.Resources._87_875613_go_back_button_png_download_blue_dollar_sign1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_View_Lab_Details
            // 
            this.lbl_View_Lab_Details.AutoSize = true;
            this.lbl_View_Lab_Details.BackColor = System.Drawing.Color.HotPink;
            this.lbl_View_Lab_Details.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_View_Lab_Details.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_View_Lab_Details.Location = new System.Drawing.Point(402, 8);
            this.lbl_View_Lab_Details.Name = "lbl_View_Lab_Details";
            this.lbl_View_Lab_Details.Size = new System.Drawing.Size(418, 73);
            this.lbl_View_Lab_Details.TabIndex = 0;
            this.lbl_View_Lab_Details.Text = "Add Lab Tests";
            // 
            // gb_Lab
            // 
            this.gb_Lab.BackColor = System.Drawing.Color.Beige;
            this.gb_Lab.Controls.Add(this.label1);
            this.gb_Lab.Controls.Add(this.lbl_Lab_ID);
            this.gb_Lab.Controls.Add(this.tb_Lab_Name);
            this.gb_Lab.Controls.Add(this.tb_L_ID);
            this.gb_Lab.Font = new System.Drawing.Font("Arial", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gb_Lab.ForeColor = System.Drawing.Color.Black;
            this.gb_Lab.Location = new System.Drawing.Point(25, 171);
            this.gb_Lab.Name = "gb_Lab";
            this.gb_Lab.Size = new System.Drawing.Size(1328, 154);
            this.gb_Lab.TabIndex = 5;
            this.gb_Lab.TabStop = false;
            this.gb_Lab.Text = "Lab ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("Bell MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(689, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lab Name";
            // 
            // tb_Lab_Name
            // 
            this.tb_Lab_Name.Enabled = false;
            this.tb_Lab_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Lab_Name.Location = new System.Drawing.Point(890, 67);
            this.tb_Lab_Name.MaxLength = 30;
            this.tb_Lab_Name.Multiline = true;
            this.tb_Lab_Name.Name = "tb_Lab_Name";
            this.tb_Lab_Name.Size = new System.Drawing.Size(369, 35);
            this.tb_Lab_Name.TabIndex = 2;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Crimson;
            this.btn_Clear.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(991, 690);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(124, 54);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Date.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Date.Location = new System.Drawing.Point(784, 119);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(65, 29);
            this.lbl_Date.TabIndex = 11;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(915, 114);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(369, 34);
            this.dtp_Date.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Beige;
            this.groupBox2.Controls.Add(this.cmb_Dr_Name);
            this.groupBox2.Controls.Add(this.lbl_Description);
            this.groupBox2.Controls.Add(this.tb_Description);
            this.groupBox2.Controls.Add(this.lbl_dr_Name);
            this.groupBox2.Controls.Add(this.lbl_Duration);
            this.groupBox2.Controls.Add(this.tb_Duration);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_Charges);
            this.groupBox2.Controls.Add(this.tb_T_Cases);
            this.groupBox2.Controls.Add(this.lbl_Charges);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(25, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1328, 334);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lab Cases";
            // 
            // cmb_Dr_Name
            // 
            this.cmb_Dr_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Dr_Name.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic);
            this.cmb_Dr_Name.FormattingEnabled = true;
            this.cmb_Dr_Name.Location = new System.Drawing.Point(582, 47);
            this.cmb_Dr_Name.Name = "cmb_Dr_Name";
            this.cmb_Dr_Name.Size = new System.Drawing.Size(373, 36);
            this.cmb_Dr_Name.TabIndex = 3;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Description.Font = new System.Drawing.Font("Bell MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.ForeColor = System.Drawing.Color.Black;
            this.lbl_Description.Location = new System.Drawing.Point(689, 215);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(154, 31);
            this.lbl_Description.TabIndex = 15;
            this.lbl_Description.Text = "Description";
            // 
            // tb_Description
            // 
            this.tb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(890, 211);
            this.tb_Description.MaxLength = 20;
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(369, 92);
            this.tb_Description.TabIndex = 7;
            // 
            // lbl_dr_Name
            // 
            this.lbl_dr_Name.AutoSize = true;
            this.lbl_dr_Name.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_dr_Name.Font = new System.Drawing.Font("Bell MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dr_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_dr_Name.Location = new System.Drawing.Point(378, 49);
            this.lbl_dr_Name.Name = "lbl_dr_Name";
            this.lbl_dr_Name.Size = new System.Drawing.Size(178, 31);
            this.lbl_dr_Name.TabIndex = 13;
            this.lbl_dr_Name.Text = "Select Doctor";
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Duration.Font = new System.Drawing.Font("Bell MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duration.ForeColor = System.Drawing.Color.Black;
            this.lbl_Duration.Location = new System.Drawing.Point(45, 215);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(122, 31);
            this.lbl_Duration.TabIndex = 14;
            this.lbl_Duration.Text = "Duration";
            // 
            // tb_Duration
            // 
            this.tb_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Duration.Location = new System.Drawing.Point(249, 211);
            this.tb_Duration.MaxLength = 20;
            this.tb_Duration.Name = "tb_Duration";
            this.tb_Duration.Size = new System.Drawing.Size(373, 38);
            this.tb_Duration.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Font = new System.Drawing.Font("Bell MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Test Cases";
            // 
            // tb_Charges
            // 
            this.tb_Charges.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Charges.Location = new System.Drawing.Point(890, 119);
            this.tb_Charges.MaxLength = 10;
            this.tb_Charges.Name = "tb_Charges";
            this.tb_Charges.Size = new System.Drawing.Size(369, 38);
            this.tb_Charges.TabIndex = 5;
            this.tb_Charges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Charges_KeyPress_1);
            // 
            // tb_T_Cases
            // 
            this.tb_T_Cases.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_T_Cases.Location = new System.Drawing.Point(249, 119);
            this.tb_T_Cases.MaxLength = 20;
            this.tb_T_Cases.Name = "tb_T_Cases";
            this.tb_T_Cases.Size = new System.Drawing.Size(373, 38);
            this.tb_T_Cases.TabIndex = 4;
            // 
            // lbl_Charges
            // 
            this.lbl_Charges.AutoSize = true;
            this.lbl_Charges.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Charges.Font = new System.Drawing.Font("Bell MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Charges.ForeColor = System.Drawing.Color.Black;
            this.lbl_Charges.Location = new System.Drawing.Point(689, 125);
            this.lbl_Charges.Name = "lbl_Charges";
            this.lbl_Charges.Size = new System.Drawing.Size(110, 31);
            this.lbl_Charges.TabIndex = 10;
            this.lbl_Charges.Text = "Charges";
            // 
            // frm_Add_Lab_Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1378, 756);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_Lab);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.btn_Add);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Lab_Tests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Test Cases";
            this.Load += new System.EventHandler(this.frm_Add_Lab_Tests_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_Lab.ResumeLayout(false);
            this.gb_Lab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_L_ID;
        private System.Windows.Forms.Label lbl_Lab_ID;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lbl_View_Lab_Details;
        private System.Windows.Forms.GroupBox gb_Lab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Lab_Name;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_Dr_Name;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Label lbl_dr_Name;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.TextBox tb_Duration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Charges;
        private System.Windows.Forms.TextBox tb_T_Cases;
        private System.Windows.Forms.Label lbl_Charges;
    }
}