namespace Dental_Clinic_Management_System
{
    partial class frm_Add_Doctor_Details
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
            this.lbl_Add_Doctor_Details = new System.Windows.Forms.Label();
            this.gb_Doctor_Details = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tb_Consultancy_Fee = new System.Windows.Forms.TextBox();
            this.tb_PAN_No = new System.Windows.Forms.TextBox();
            this.tb_Email_ID = new System.Windows.Forms.TextBox();
            this.tb_Doctor_ID = new System.Windows.Forms.TextBox();
            this.lbl_Doctor_ID = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Clinic_Address = new System.Windows.Forms.TextBox();
            this.tb_Contact_No_1 = new System.Windows.Forms.TextBox();
            this.tb_Contact_No_2 = new System.Windows.Forms.TextBox();
            this.tb_Aadhar_Card_No = new System.Windows.Forms.TextBox();
            this.tb_Doctor_Name = new System.Windows.Forms.TextBox();
            this.lbl_Consultancy_Fee = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_PAN_No = new System.Windows.Forms.Label();
            this.lbl_Email_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Clinic_Address = new System.Windows.Forms.Label();
            this.lbl_Aadhar_Card_No = new System.Windows.Forms.Label();
            this.lbl_Contact_No_1 = new System.Windows.Forms.Label();
            this.lbl_Doctor_Name = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_Doctor_Details.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Add_Doctor_Details
            // 
            this.lbl_Add_Doctor_Details.AutoSize = true;
            this.lbl_Add_Doctor_Details.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_Add_Doctor_Details.ForeColor = System.Drawing.Color.White;
            this.lbl_Add_Doctor_Details.Location = new System.Drawing.Point(367, 8);
            this.lbl_Add_Doctor_Details.Name = "lbl_Add_Doctor_Details";
            this.lbl_Add_Doctor_Details.Size = new System.Drawing.Size(569, 73);
            this.lbl_Add_Doctor_Details.TabIndex = 0;
            this.lbl_Add_Doctor_Details.Text = "Add Doctor Details";
            // 
            // gb_Doctor_Details
            // 
            this.gb_Doctor_Details.BackColor = System.Drawing.Color.Cornsilk;
            this.gb_Doctor_Details.Controls.Add(this.btn_Save);
            this.gb_Doctor_Details.Controls.Add(this.btn_Clear);
            this.gb_Doctor_Details.Controls.Add(this.tb_Consultancy_Fee);
            this.gb_Doctor_Details.Controls.Add(this.tb_PAN_No);
            this.gb_Doctor_Details.Controls.Add(this.tb_Email_ID);
            this.gb_Doctor_Details.Controls.Add(this.tb_Doctor_ID);
            this.gb_Doctor_Details.Controls.Add(this.lbl_Doctor_ID);
            this.gb_Doctor_Details.Controls.Add(this.dtp_DOB);
            this.gb_Doctor_Details.Controls.Add(this.tb_Clinic_Address);
            this.gb_Doctor_Details.Controls.Add(this.tb_Contact_No_1);
            this.gb_Doctor_Details.Controls.Add(this.tb_Contact_No_2);
            this.gb_Doctor_Details.Controls.Add(this.tb_Aadhar_Card_No);
            this.gb_Doctor_Details.Controls.Add(this.tb_Doctor_Name);
            this.gb_Doctor_Details.Controls.Add(this.lbl_Consultancy_Fee);
            this.gb_Doctor_Details.Controls.Add(this.lbl_DOB);
            this.gb_Doctor_Details.Controls.Add(this.lbl_PAN_No);
            this.gb_Doctor_Details.Controls.Add(this.lbl_Email_ID);
            this.gb_Doctor_Details.Controls.Add(this.label1);
            this.gb_Doctor_Details.Controls.Add(this.lbl_Clinic_Address);
            this.gb_Doctor_Details.Controls.Add(this.lbl_Aadhar_Card_No);
            this.gb_Doctor_Details.Controls.Add(this.lbl_Contact_No_1);
            this.gb_Doctor_Details.Controls.Add(this.lbl_Doctor_Name);
            this.gb_Doctor_Details.Font = new System.Drawing.Font("Arial", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Doctor_Details.ForeColor = System.Drawing.Color.Black;
            this.gb_Doctor_Details.Location = new System.Drawing.Point(27, 147);
            this.gb_Doctor_Details.Name = "gb_Doctor_Details";
            this.gb_Doctor_Details.Size = new System.Drawing.Size(1322, 584);
            this.gb_Doctor_Details.TabIndex = 1;
            this.gb_Doctor_Details.TabStop = false;
            this.gb_Doctor_Details.Text = " Doctor Details";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Crimson;
            this.btn_Save.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(368, 492);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(124, 54);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Crimson;
            this.btn_Clear.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(783, 492);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(124, 54);
            this.btn_Clear.TabIndex = 14;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tb_Consultancy_Fee
            // 
            this.tb_Consultancy_Fee.Location = new System.Drawing.Point(924, 432);
            this.tb_Consultancy_Fee.MaxLength = 10;
            this.tb_Consultancy_Fee.Name = "tb_Consultancy_Fee";
            this.tb_Consultancy_Fee.Size = new System.Drawing.Size(317, 33);
            this.tb_Consultancy_Fee.TabIndex = 12;
            this.tb_Consultancy_Fee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Consultancy_Fee_KeyPress);
            // 
            // tb_PAN_No
            // 
            this.tb_PAN_No.Location = new System.Drawing.Point(922, 344);
            this.tb_PAN_No.MaxLength = 10;
            this.tb_PAN_No.Name = "tb_PAN_No";
            this.tb_PAN_No.Size = new System.Drawing.Size(317, 33);
            this.tb_PAN_No.TabIndex = 11;
            // 
            // tb_Email_ID
            // 
            this.tb_Email_ID.Location = new System.Drawing.Point(924, 257);
            this.tb_Email_ID.MaxLength = 50;
            this.tb_Email_ID.Name = "tb_Email_ID";
            this.tb_Email_ID.Size = new System.Drawing.Size(317, 33);
            this.tb_Email_ID.TabIndex = 10;
            // 
            // tb_Doctor_ID
            // 
            this.tb_Doctor_ID.Location = new System.Drawing.Point(285, 55);
            this.tb_Doctor_ID.MaxLength = 10;
            this.tb_Doctor_ID.Name = "tb_Doctor_ID";
            this.tb_Doctor_ID.Size = new System.Drawing.Size(304, 33);
            this.tb_Doctor_ID.TabIndex = 2;
            this.tb_Doctor_ID.Text = "1";
            this.tb_Doctor_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Doctor_ID_KeyPress);
            // 
            // lbl_Doctor_ID
            // 
            this.lbl_Doctor_ID.AutoSize = true;
            this.lbl_Doctor_ID.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Doctor_ID.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Doctor_ID.ForeColor = System.Drawing.Color.Black;
            this.lbl_Doctor_ID.Location = new System.Drawing.Point(76, 55);
            this.lbl_Doctor_ID.Name = "lbl_Doctor_ID";
            this.lbl_Doctor_ID.Size = new System.Drawing.Size(112, 26);
            this.lbl_Doctor_ID.TabIndex = 7;
            this.lbl_Doctor_ID.Text = "Doctor ID";
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Location = new System.Drawing.Point(923, 172);
            this.dtp_DOB.MaxDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(318, 33);
            this.dtp_DOB.TabIndex = 8;
            this.dtp_DOB.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // tb_Clinic_Address
            // 
            this.tb_Clinic_Address.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Clinic_Address.Location = new System.Drawing.Point(923, 47);
            this.tb_Clinic_Address.MaxLength = 200;
            this.tb_Clinic_Address.Multiline = true;
            this.tb_Clinic_Address.Name = "tb_Clinic_Address";
            this.tb_Clinic_Address.Size = new System.Drawing.Size(317, 90);
            this.tb_Clinic_Address.TabIndex = 7;
            // 
            // tb_Contact_No_1
            // 
            this.tb_Contact_No_1.Location = new System.Drawing.Point(285, 257);
            this.tb_Contact_No_1.MaxLength = 10;
            this.tb_Contact_No_1.Name = "tb_Contact_No_1";
            this.tb_Contact_No_1.Size = new System.Drawing.Size(304, 33);
            this.tb_Contact_No_1.TabIndex = 4;
            this.tb_Contact_No_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Contact_No_1_KeyPress);
            // 
            // tb_Contact_No_2
            // 
            this.tb_Contact_No_2.Location = new System.Drawing.Point(285, 348);
            this.tb_Contact_No_2.MaxLength = 10;
            this.tb_Contact_No_2.Name = "tb_Contact_No_2";
            this.tb_Contact_No_2.Size = new System.Drawing.Size(304, 33);
            this.tb_Contact_No_2.TabIndex = 4;
            this.tb_Contact_No_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Contact_No_2_KeyPress);
            // 
            // tb_Aadhar_Card_No
            // 
            this.tb_Aadhar_Card_No.Location = new System.Drawing.Point(285, 434);
            this.tb_Aadhar_Card_No.MaxLength = 12;
            this.tb_Aadhar_Card_No.Name = "tb_Aadhar_Card_No";
            this.tb_Aadhar_Card_No.Size = new System.Drawing.Size(304, 33);
            this.tb_Aadhar_Card_No.TabIndex = 5;
            this.tb_Aadhar_Card_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Aadhar_Card_No_KeyPress);
            // 
            // tb_Doctor_Name
            // 
            this.tb_Doctor_Name.Location = new System.Drawing.Point(285, 167);
            this.tb_Doctor_Name.MaxLength = 20;
            this.tb_Doctor_Name.Name = "tb_Doctor_Name";
            this.tb_Doctor_Name.Size = new System.Drawing.Size(304, 33);
            this.tb_Doctor_Name.TabIndex = 3;
            // 
            // lbl_Consultancy_Fee
            // 
            this.lbl_Consultancy_Fee.AutoSize = true;
            this.lbl_Consultancy_Fee.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Consultancy_Fee.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Consultancy_Fee.ForeColor = System.Drawing.Color.Black;
            this.lbl_Consultancy_Fee.Location = new System.Drawing.Point(672, 443);
            this.lbl_Consultancy_Fee.Name = "lbl_Consultancy_Fee";
            this.lbl_Consultancy_Fee.Size = new System.Drawing.Size(173, 26);
            this.lbl_Consultancy_Fee.TabIndex = 4;
            this.lbl_Consultancy_Fee.Text = "Consultancy Fee";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_DOB.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Black;
            this.lbl_DOB.Location = new System.Drawing.Point(672, 177);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(60, 26);
            this.lbl_DOB.TabIndex = 2;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_PAN_No
            // 
            this.lbl_PAN_No.AutoSize = true;
            this.lbl_PAN_No.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_PAN_No.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PAN_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_PAN_No.Location = new System.Drawing.Point(670, 355);
            this.lbl_PAN_No.Name = "lbl_PAN_No";
            this.lbl_PAN_No.Size = new System.Drawing.Size(146, 26);
            this.lbl_PAN_No.TabIndex = 4;
            this.lbl_PAN_No.Text = "PAN Card No";
            // 
            // lbl_Email_ID
            // 
            this.lbl_Email_ID.AutoSize = true;
            this.lbl_Email_ID.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Email_ID.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_ID.ForeColor = System.Drawing.Color.Black;
            this.lbl_Email_ID.Location = new System.Drawing.Point(672, 268);
            this.lbl_Email_ID.Name = "lbl_Email_ID";
            this.lbl_Email_ID.Size = new System.Drawing.Size(101, 26);
            this.lbl_Email_ID.TabIndex = 4;
            this.lbl_Email_ID.Text = "Email ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(76, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contact No.2";
            // 
            // lbl_Clinic_Address
            // 
            this.lbl_Clinic_Address.AutoSize = true;
            this.lbl_Clinic_Address.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Clinic_Address.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clinic_Address.ForeColor = System.Drawing.Color.Black;
            this.lbl_Clinic_Address.Location = new System.Drawing.Point(672, 55);
            this.lbl_Clinic_Address.Name = "lbl_Clinic_Address";
            this.lbl_Clinic_Address.Size = new System.Drawing.Size(153, 26);
            this.lbl_Clinic_Address.TabIndex = 6;
            this.lbl_Clinic_Address.Text = "Clinic Address";
            // 
            // lbl_Aadhar_Card_No
            // 
            this.lbl_Aadhar_Card_No.AutoSize = true;
            this.lbl_Aadhar_Card_No.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Aadhar_Card_No.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aadhar_Card_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Aadhar_Card_No.Location = new System.Drawing.Point(76, 439);
            this.lbl_Aadhar_Card_No.Name = "lbl_Aadhar_Card_No";
            this.lbl_Aadhar_Card_No.Size = new System.Drawing.Size(170, 26);
            this.lbl_Aadhar_Card_No.TabIndex = 5;
            this.lbl_Aadhar_Card_No.Text = "Aadhar Card No";
            // 
            // lbl_Contact_No_1
            // 
            this.lbl_Contact_No_1.AutoSize = true;
            this.lbl_Contact_No_1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Contact_No_1.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contact_No_1.ForeColor = System.Drawing.Color.Black;
            this.lbl_Contact_No_1.Location = new System.Drawing.Point(76, 260);
            this.lbl_Contact_No_1.Name = "lbl_Contact_No_1";
            this.lbl_Contact_No_1.Size = new System.Drawing.Size(140, 26);
            this.lbl_Contact_No_1.TabIndex = 4;
            this.lbl_Contact_No_1.Text = "Contact No.1";
            // 
            // lbl_Doctor_Name
            // 
            this.lbl_Doctor_Name.AutoSize = true;
            this.lbl_Doctor_Name.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Doctor_Name.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Doctor_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Doctor_Name.Location = new System.Drawing.Point(73, 172);
            this.lbl_Doctor_Name.Name = "lbl_Doctor_Name";
            this.lbl_Doctor_Name.Size = new System.Drawing.Size(143, 26);
            this.lbl_Doctor_Name.TabIndex = 3;
            this.lbl_Doctor_Name.Text = "Doctor Name";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Date.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.Black;
            this.lbl_Date.Location = new System.Drawing.Point(848, 104);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(59, 26);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "Date";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Arial", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dtp_Date.Location = new System.Drawing.Point(978, 98);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(318, 33);
            this.dtp_Date.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_Add_Doctor_Details);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1379, 91);
            this.panel1.TabIndex = 2;
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
            // frm_Add_Doctor_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1378, 722);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.gb_Doctor_Details);
            this.Controls.Add(this.dtp_Date);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Doctor_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Doctor Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_Doctor_Details_Load);
            this.gb_Doctor_Details.ResumeLayout(false);
            this.gb_Doctor_Details.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_Doctor_Details;
        private System.Windows.Forms.GroupBox gb_Doctor_Details;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Email_ID;
        private System.Windows.Forms.Label lbl_Clinic_Address;
        private System.Windows.Forms.Label lbl_Aadhar_Card_No;
        private System.Windows.Forms.Label lbl_Contact_No_1;
        private System.Windows.Forms.Label lbl_Doctor_Name;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.TextBox tb_Clinic_Address;
        private System.Windows.Forms.TextBox tb_Doctor_Name;
        private System.Windows.Forms.TextBox tb_Contact_No_1;
        private System.Windows.Forms.TextBox tb_Aadhar_Card_No;
        private System.Windows.Forms.TextBox tb_Doctor_ID;
        private System.Windows.Forms.Label lbl_Doctor_ID;
        private System.Windows.Forms.TextBox tb_Email_ID;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_Contact_No_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_PAN_No;
        private System.Windows.Forms.Label lbl_PAN_No;
        private System.Windows.Forms.TextBox tb_Consultancy_Fee;
        private System.Windows.Forms.Label lbl_Consultancy_Fee;
    }
}