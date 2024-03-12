namespace Dental_Clinic_Management_System
{
    partial class frm_Add_Lab_Details
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
            this.lbl_Add_Lab_Details = new System.Windows.Forms.Label();
            this.gb_Laboratory_Information = new System.Windows.Forms.GroupBox();
            this.tb_O_Name = new System.Windows.Forms.TextBox();
            this.gb_Lab_Info = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Licence_No = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tb_L_No = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Contact_No_1 = new System.Windows.Forms.TextBox();
            this.tb_Contact_No_2 = new System.Windows.Forms.TextBox();
            this.lbl_Contact_No_2 = new System.Windows.Forms.Label();
            this.lbl_Contact_No_1 = new System.Windows.Forms.Label();
            this.tb_Lab_ID = new System.Windows.Forms.TextBox();
            this.lbl_Lab_ID = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Lab_Name = new System.Windows.Forms.TextBox();
            this.lbl_Lab_Address = new System.Windows.Forms.Label();
            this.lbl_Lab_Name = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_Laboratory_Information.SuspendLayout();
            this.gb_Lab_Info.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Add_Lab_Details
            // 
            this.lbl_Add_Lab_Details.AutoSize = true;
            this.lbl_Add_Lab_Details.BackColor = System.Drawing.Color.HotPink;
            this.lbl_Add_Lab_Details.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_Add_Lab_Details.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Add_Lab_Details.Location = new System.Drawing.Point(375, 11);
            this.lbl_Add_Lab_Details.Name = "lbl_Add_Lab_Details";
            this.lbl_Add_Lab_Details.Size = new System.Drawing.Size(479, 73);
            this.lbl_Add_Lab_Details.TabIndex = 0;
            this.lbl_Add_Lab_Details.Text = "Add Lab Details";
            // 
            // gb_Laboratory_Information
            // 
            this.gb_Laboratory_Information.Controls.Add(this.tb_O_Name);
            this.gb_Laboratory_Information.Controls.Add(this.gb_Lab_Info);
            this.gb_Laboratory_Information.Controls.Add(this.btn_Save);
            this.gb_Laboratory_Information.Controls.Add(this.lbl_Licence_No);
            this.gb_Laboratory_Information.Controls.Add(this.btn_Clear);
            this.gb_Laboratory_Information.Controls.Add(this.tb_L_No);
            this.gb_Laboratory_Information.Controls.Add(this.label1);
            this.gb_Laboratory_Information.Controls.Add(this.tb_Contact_No_1);
            this.gb_Laboratory_Information.Controls.Add(this.tb_Contact_No_2);
            this.gb_Laboratory_Information.Controls.Add(this.lbl_Contact_No_2);
            this.gb_Laboratory_Information.Controls.Add(this.lbl_Contact_No_1);
            this.gb_Laboratory_Information.Controls.Add(this.tb_Lab_ID);
            this.gb_Laboratory_Information.Controls.Add(this.lbl_Lab_ID);
            this.gb_Laboratory_Information.Controls.Add(this.tb_Address);
            this.gb_Laboratory_Information.Controls.Add(this.tb_Lab_Name);
            this.gb_Laboratory_Information.Controls.Add(this.lbl_Lab_Address);
            this.gb_Laboratory_Information.Controls.Add(this.lbl_Lab_Name);
            this.gb_Laboratory_Information.Font = new System.Drawing.Font("Arial", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gb_Laboratory_Information.ForeColor = System.Drawing.Color.Black;
            this.gb_Laboratory_Information.Location = new System.Drawing.Point(12, 110);
            this.gb_Laboratory_Information.Name = "gb_Laboratory_Information";
            this.gb_Laboratory_Information.Size = new System.Drawing.Size(1322, 597);
            this.gb_Laboratory_Information.TabIndex = 1;
            this.gb_Laboratory_Information.TabStop = false;
            this.gb_Laboratory_Information.Text = "Laboratory Information";
            // 
            // tb_O_Name
            // 
            this.tb_O_Name.Location = new System.Drawing.Point(865, 36);
            this.tb_O_Name.MaxLength = 20;
            this.tb_O_Name.Name = "tb_O_Name";
            this.tb_O_Name.Size = new System.Drawing.Size(340, 33);
            this.tb_O_Name.TabIndex = 6;
            this.tb_O_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_O_Name_KeyPress);
            // 
            // gb_Lab_Info
            // 
            this.gb_Lab_Info.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gb_Lab_Info.Controls.Add(this.pictureBox1);
            this.gb_Lab_Info.Location = new System.Drawing.Point(670, 197);
            this.gb_Lab_Info.Name = "gb_Lab_Info";
            this.gb_Lab_Info.Size = new System.Drawing.Size(583, 334);
            this.gb_Lab_Info.TabIndex = 10;
            this.gb_Lab_Info.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Crimson;
            this.btn_Save.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(346, 537);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(221, 54);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Licence_No
            // 
            this.lbl_Licence_No.AutoSize = true;
            this.lbl_Licence_No.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Licence_No.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Licence_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Licence_No.Location = new System.Drawing.Point(671, 136);
            this.lbl_Licence_No.Name = "lbl_Licence_No";
            this.lbl_Licence_No.Size = new System.Drawing.Size(122, 26);
            this.lbl_Licence_No.TabIndex = 7;
            this.lbl_Licence_No.Text = "Licence No";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Crimson;
            this.btn_Clear.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(926, 537);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(221, 54);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tb_L_No
            // 
            this.tb_L_No.Location = new System.Drawing.Point(865, 136);
            this.tb_L_No.MaxLength = 20;
            this.tb_L_No.Name = "tb_L_No";
            this.tb_L_No.Size = new System.Drawing.Size(340, 33);
            this.tb_L_No.TabIndex = 7;
            this.tb_L_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_L_No_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(672, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Owner Name";
            // 
            // tb_Contact_No_1
            // 
            this.tb_Contact_No_1.Location = new System.Drawing.Point(219, 384);
            this.tb_Contact_No_1.MaxLength = 10;
            this.tb_Contact_No_1.Name = "tb_Contact_No_1";
            this.tb_Contact_No_1.Size = new System.Drawing.Size(370, 33);
            this.tb_Contact_No_1.TabIndex = 4;
            this.tb_Contact_No_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Contact_No_1_KeyPress);
            // 
            // tb_Contact_No_2
            // 
            this.tb_Contact_No_2.Location = new System.Drawing.Point(218, 484);
            this.tb_Contact_No_2.MaxLength = 10;
            this.tb_Contact_No_2.Name = "tb_Contact_No_2";
            this.tb_Contact_No_2.Size = new System.Drawing.Size(370, 33);
            this.tb_Contact_No_2.TabIndex = 5;
            this.tb_Contact_No_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Contact_No_2_KeyPress);
            // 
            // lbl_Contact_No_2
            // 
            this.lbl_Contact_No_2.AutoSize = true;
            this.lbl_Contact_No_2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Contact_No_2.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contact_No_2.ForeColor = System.Drawing.Color.Black;
            this.lbl_Contact_No_2.Location = new System.Drawing.Point(29, 491);
            this.lbl_Contact_No_2.Name = "lbl_Contact_No_2";
            this.lbl_Contact_No_2.Size = new System.Drawing.Size(140, 26);
            this.lbl_Contact_No_2.TabIndex = 5;
            this.lbl_Contact_No_2.Text = "Contact No.2";
            // 
            // lbl_Contact_No_1
            // 
            this.lbl_Contact_No_1.AutoSize = true;
            this.lbl_Contact_No_1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Contact_No_1.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contact_No_1.ForeColor = System.Drawing.Color.Black;
            this.lbl_Contact_No_1.Location = new System.Drawing.Point(30, 391);
            this.lbl_Contact_No_1.Name = "lbl_Contact_No_1";
            this.lbl_Contact_No_1.Size = new System.Drawing.Size(140, 26);
            this.lbl_Contact_No_1.TabIndex = 4;
            this.lbl_Contact_No_1.Text = "Contact No.1";
            // 
            // tb_Lab_ID
            // 
            this.tb_Lab_ID.Location = new System.Drawing.Point(219, 36);
            this.tb_Lab_ID.MaxLength = 10;
            this.tb_Lab_ID.Name = "tb_Lab_ID";
            this.tb_Lab_ID.Size = new System.Drawing.Size(370, 33);
            this.tb_Lab_ID.TabIndex = 1;
            // 
            // lbl_Lab_ID
            // 
            this.lbl_Lab_ID.AutoSize = true;
            this.lbl_Lab_ID.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Lab_ID.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lab_ID.ForeColor = System.Drawing.Color.Black;
            this.lbl_Lab_ID.Location = new System.Drawing.Point(25, 43);
            this.lbl_Lab_ID.Name = "lbl_Lab_ID";
            this.lbl_Lab_ID.Size = new System.Drawing.Size(81, 26);
            this.lbl_Lab_ID.TabIndex = 1;
            this.lbl_Lab_ID.Text = "Lab ID";
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(219, 238);
            this.tb_Address.MaxLength = 200;
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(370, 86);
            this.tb_Address.TabIndex = 3;
            // 
            // tb_Lab_Name
            // 
            this.tb_Lab_Name.Location = new System.Drawing.Point(218, 136);
            this.tb_Lab_Name.MaxLength = 30;
            this.tb_Lab_Name.Name = "tb_Lab_Name";
            this.tb_Lab_Name.Size = new System.Drawing.Size(370, 33);
            this.tb_Lab_Name.TabIndex = 2;
            // 
            // lbl_Lab_Address
            // 
            this.lbl_Lab_Address.AutoSize = true;
            this.lbl_Lab_Address.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Lab_Address.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lab_Address.ForeColor = System.Drawing.Color.Black;
            this.lbl_Lab_Address.Location = new System.Drawing.Point(24, 242);
            this.lbl_Lab_Address.Name = "lbl_Lab_Address";
            this.lbl_Lab_Address.Size = new System.Drawing.Size(132, 26);
            this.lbl_Lab_Address.TabIndex = 3;
            this.lbl_Lab_Address.Text = "Lab Address";
            // 
            // lbl_Lab_Name
            // 
            this.lbl_Lab_Name.AutoSize = true;
            this.lbl_Lab_Name.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Lab_Name.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lab_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Lab_Name.Location = new System.Drawing.Point(24, 136);
            this.lbl_Lab_Name.Name = "lbl_Lab_Name";
            this.lbl_Lab_Name.Size = new System.Drawing.Size(112, 26);
            this.lbl_Lab_Name.TabIndex = 2;
            this.lbl_Lab_Name.Text = "Lab Name";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.HotPink;
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Controls.Add(this.lbl_Add_Lab_Details);
            this.panel.Location = new System.Drawing.Point(1, -2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1376, 95);
            this.panel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dental_Clinic_Management_System.Properties.Resources._87_875613_go_back_button_png_download_blue_dollar_sign1;
            this.pictureBox2.Location = new System.Drawing.Point(11, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dental_Clinic_Management_System.Properties.Resources.istockphoto_1269563704_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(577, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Add_Lab_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1378, 756);
            this.ControlBox = false;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.gb_Laboratory_Information);
            this.Name = "frm_Add_Lab_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Lab Details";
            this.Load += new System.EventHandler(this.frm_Add_Lab_Details_Load);
            this.gb_Laboratory_Information.ResumeLayout(false);
            this.gb_Laboratory_Information.PerformLayout();
            this.gb_Lab_Info.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_Lab_Details;
        private System.Windows.Forms.GroupBox gb_Laboratory_Information;
        private System.Windows.Forms.TextBox tb_L_No;
        private System.Windows.Forms.Label lbl_Licence_No;
        private System.Windows.Forms.TextBox tb_Lab_ID;
        private System.Windows.Forms.Label lbl_Lab_ID;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Lab_Name;
        private System.Windows.Forms.Label lbl_Lab_Address;
        private System.Windows.Forms.Label lbl_Lab_Name;
        private System.Windows.Forms.TextBox tb_Contact_No_1;
        private System.Windows.Forms.TextBox tb_Contact_No_2;
        private System.Windows.Forms.Label lbl_Contact_No_2;
        private System.Windows.Forms.Label lbl_Contact_No_1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox tb_O_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gb_Lab_Info;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}