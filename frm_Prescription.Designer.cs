namespace Dental_Clinic_Management_System
{
    partial class frm_Prescription
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_Treatment = new System.Windows.Forms.GroupBox();
            this.tb_Treat_Charges = new System.Windows.Forms.TextBox();
            this.lbl_Treatment_Charges = new System.Windows.Forms.Label();
            this.gb_Treat = new System.Windows.Forms.GroupBox();
            this.cb_Braces = new System.Windows.Forms.CheckBox();
            this.cb_Crowns_and_Caps = new System.Windows.Forms.CheckBox();
            this.cb_Bridges_and_Impletns = new System.Windows.Forms.CheckBox();
            this.cb_Dentures = new System.Windows.Forms.CheckBox();
            this.cb_Gun_Surgery = new System.Windows.Forms.CheckBox();
            this.cb_Filling_and_Repairs = new System.Windows.Forms.CheckBox();
            this.lbl_Treatment = new System.Windows.Forms.Label();
            this.tb_Jaw_Teeth_No = new System.Windows.Forms.TextBox();
            this.lbl_Jaw_Teeth_No = new System.Windows.Forms.Label();
            this.gb_Patient_Details = new System.Windows.Forms.GroupBox();
            this.tb_Consule_Fees = new System.Windows.Forms.TextBox();
            this.lbl_Consule_Fees = new System.Windows.Forms.Label();
            this.tb_dr_Name = new System.Windows.Forms.TextBox();
            this.lbl_Doctor_Name = new System.Windows.Forms.Label();
            this.tb_Patient_ID = new System.Windows.Forms.TextBox();
            this.lbl_Patient_ID = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Patient_Name = new System.Windows.Forms.TextBox();
            this.lbl_Patient_Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Priscription = new System.Windows.Forms.Label();
            this.tb_G_Total = new System.Windows.Forms.TextBox();
            this.lbl_Grand_Total = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Medication = new System.Windows.Forms.TextBox();
            this.lbl_Medication = new System.Windows.Forms.Label();
            this.dgv_Medication = new System.Windows.Forms.DataGridView();
            this.tb_Qty = new System.Windows.Forms.TextBox();
            this.gb_Medication = new System.Windows.Forms.GroupBox();
            this.lbl_Qty = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Medication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_Time = new System.Windows.Forms.TextBox();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Treatment.SuspendLayout();
            this.gb_Treat.SuspendLayout();
            this.gb_Patient_Details.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medication)).BeginInit();
            this.gb_Medication.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Treatment
            // 
            this.gb_Treatment.BackColor = System.Drawing.Color.NavajoWhite;
            this.gb_Treatment.Controls.Add(this.tb_Treat_Charges);
            this.gb_Treatment.Controls.Add(this.lbl_Treatment_Charges);
            this.gb_Treatment.Controls.Add(this.gb_Treat);
            this.gb_Treatment.Controls.Add(this.lbl_Treatment);
            this.gb_Treatment.Controls.Add(this.tb_Jaw_Teeth_No);
            this.gb_Treatment.Controls.Add(this.lbl_Jaw_Teeth_No);
            this.gb_Treatment.Font = new System.Drawing.Font("Arial", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gb_Treatment.Location = new System.Drawing.Point(22, 294);
            this.gb_Treatment.Name = "gb_Treatment";
            this.gb_Treatment.Size = new System.Drawing.Size(1390, 269);
            this.gb_Treatment.TabIndex = 19;
            this.gb_Treatment.TabStop = false;
            this.gb_Treatment.Text = "Treatment";
            // 
            // tb_Treat_Charges
            // 
            this.tb_Treat_Charges.Location = new System.Drawing.Point(1128, 54);
            this.tb_Treat_Charges.MaxLength = 5;
            this.tb_Treat_Charges.Name = "tb_Treat_Charges";
            this.tb_Treat_Charges.Size = new System.Drawing.Size(208, 33);
            this.tb_Treat_Charges.TabIndex = 13;
            this.tb_Treat_Charges.Text = "0";
            this.tb_Treat_Charges.TextChanged += new System.EventHandler(this.tb_Treat_Charges_TextChanged);
            this.tb_Treat_Charges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Treat_Charges_KeyPress);
            // 
            // lbl_Treatment_Charges
            // 
            this.lbl_Treatment_Charges.AutoSize = true;
            this.lbl_Treatment_Charges.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Treatment_Charges.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Treatment_Charges.ForeColor = System.Drawing.Color.Black;
            this.lbl_Treatment_Charges.Location = new System.Drawing.Point(908, 54);
            this.lbl_Treatment_Charges.Name = "lbl_Treatment_Charges";
            this.lbl_Treatment_Charges.Size = new System.Drawing.Size(202, 26);
            this.lbl_Treatment_Charges.TabIndex = 10;
            this.lbl_Treatment_Charges.Text = "Treatment Charges";
            // 
            // gb_Treat
            // 
            this.gb_Treat.BackColor = System.Drawing.Color.White;
            this.gb_Treat.Controls.Add(this.cb_Braces);
            this.gb_Treat.Controls.Add(this.cb_Crowns_and_Caps);
            this.gb_Treat.Controls.Add(this.cb_Bridges_and_Impletns);
            this.gb_Treat.Controls.Add(this.cb_Dentures);
            this.gb_Treat.Controls.Add(this.cb_Gun_Surgery);
            this.gb_Treat.Controls.Add(this.cb_Filling_and_Repairs);
            this.gb_Treat.Location = new System.Drawing.Point(596, 20);
            this.gb_Treat.Name = "gb_Treat";
            this.gb_Treat.Size = new System.Drawing.Size(306, 239);
            this.gb_Treat.TabIndex = 9;
            this.gb_Treat.TabStop = false;
            // 
            // cb_Braces
            // 
            this.cb_Braces.AutoSize = true;
            this.cb_Braces.Location = new System.Drawing.Point(19, 20);
            this.cb_Braces.Name = "cb_Braces";
            this.cb_Braces.Size = new System.Drawing.Size(106, 29);
            this.cb_Braces.TabIndex = 7;
            this.cb_Braces.Text = "Braces";
            this.cb_Braces.UseVisualStyleBackColor = true;
            this.cb_Braces.CheckedChanged += new System.EventHandler(this.cb_Braces_CheckedChanged);
            // 
            // cb_Crowns_and_Caps
            // 
            this.cb_Crowns_and_Caps.AutoSize = true;
            this.cb_Crowns_and_Caps.Location = new System.Drawing.Point(19, 55);
            this.cb_Crowns_and_Caps.Name = "cb_Crowns_and_Caps";
            this.cb_Crowns_and_Caps.Size = new System.Drawing.Size(217, 29);
            this.cb_Crowns_and_Caps.TabIndex = 8;
            this.cb_Crowns_and_Caps.Text = "Crowns and Caps";
            this.cb_Crowns_and_Caps.UseVisualStyleBackColor = true;
            this.cb_Crowns_and_Caps.CheckedChanged += new System.EventHandler(this.cb_Crowns_and_Caps_CheckedChanged);
            // 
            // cb_Bridges_and_Impletns
            // 
            this.cb_Bridges_and_Impletns.AutoSize = true;
            this.cb_Bridges_and_Impletns.Location = new System.Drawing.Point(19, 90);
            this.cb_Bridges_and_Impletns.Name = "cb_Bridges_and_Impletns";
            this.cb_Bridges_and_Impletns.Size = new System.Drawing.Size(254, 29);
            this.cb_Bridges_and_Impletns.TabIndex = 9;
            this.cb_Bridges_and_Impletns.Text = "Bridges and Impletns";
            this.cb_Bridges_and_Impletns.UseVisualStyleBackColor = true;
            this.cb_Bridges_and_Impletns.CheckedChanged += new System.EventHandler(this.cb_Bridges_and_Impletns_CheckedChanged);
            // 
            // cb_Dentures
            // 
            this.cb_Dentures.AutoSize = true;
            this.cb_Dentures.Location = new System.Drawing.Point(19, 125);
            this.cb_Dentures.Name = "cb_Dentures";
            this.cb_Dentures.Size = new System.Drawing.Size(129, 29);
            this.cb_Dentures.TabIndex = 10;
            this.cb_Dentures.Text = "Dentures";
            this.cb_Dentures.UseVisualStyleBackColor = true;
            this.cb_Dentures.CheckedChanged += new System.EventHandler(this.cb_Dentures_CheckedChanged);
            // 
            // cb_Gun_Surgery
            // 
            this.cb_Gun_Surgery.AutoSize = true;
            this.cb_Gun_Surgery.Location = new System.Drawing.Point(19, 160);
            this.cb_Gun_Surgery.Name = "cb_Gun_Surgery";
            this.cb_Gun_Surgery.Size = new System.Drawing.Size(166, 29);
            this.cb_Gun_Surgery.TabIndex = 11;
            this.cb_Gun_Surgery.Text = "Gun Surgery";
            this.cb_Gun_Surgery.UseVisualStyleBackColor = true;
            this.cb_Gun_Surgery.CheckedChanged += new System.EventHandler(this.cb_Gun_Surgery_CheckedChanged);
            // 
            // cb_Filling_and_Repairs
            // 
            this.cb_Filling_and_Repairs.AutoSize = true;
            this.cb_Filling_and_Repairs.Location = new System.Drawing.Point(19, 195);
            this.cb_Filling_and_Repairs.Name = "cb_Filling_and_Repairs";
            this.cb_Filling_and_Repairs.Size = new System.Drawing.Size(227, 29);
            this.cb_Filling_and_Repairs.TabIndex = 12;
            this.cb_Filling_and_Repairs.Text = "Filling and Repairs";
            this.cb_Filling_and_Repairs.UseVisualStyleBackColor = true;
            this.cb_Filling_and_Repairs.CheckedChanged += new System.EventHandler(this.cb_Filling_and_Repairs_CheckedChanged);
            // 
            // lbl_Treatment
            // 
            this.lbl_Treatment.AutoSize = true;
            this.lbl_Treatment.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Treatment.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Treatment.ForeColor = System.Drawing.Color.Black;
            this.lbl_Treatment.Location = new System.Drawing.Point(457, 47);
            this.lbl_Treatment.Name = "lbl_Treatment";
            this.lbl_Treatment.Size = new System.Drawing.Size(117, 26);
            this.lbl_Treatment.TabIndex = 8;
            this.lbl_Treatment.Text = "Treatment";
            // 
            // tb_Jaw_Teeth_No
            // 
            this.tb_Jaw_Teeth_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Jaw_Teeth_No.Location = new System.Drawing.Point(173, 40);
            this.tb_Jaw_Teeth_No.MaxLength = 30;
            this.tb_Jaw_Teeth_No.Multiline = true;
            this.tb_Jaw_Teeth_No.Name = "tb_Jaw_Teeth_No";
            this.tb_Jaw_Teeth_No.Size = new System.Drawing.Size(254, 190);
            this.tb_Jaw_Teeth_No.TabIndex = 6;
            // 
            // lbl_Jaw_Teeth_No
            // 
            this.lbl_Jaw_Teeth_No.AutoSize = true;
            this.lbl_Jaw_Teeth_No.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Jaw_Teeth_No.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jaw_Teeth_No.ForeColor = System.Drawing.Color.Black;
            this.lbl_Jaw_Teeth_No.Location = new System.Drawing.Point(6, 54);
            this.lbl_Jaw_Teeth_No.Name = "lbl_Jaw_Teeth_No";
            this.lbl_Jaw_Teeth_No.Size = new System.Drawing.Size(149, 26);
            this.lbl_Jaw_Teeth_No.TabIndex = 6;
            this.lbl_Jaw_Teeth_No.Text = "Jaw Teeth No";
            // 
            // gb_Patient_Details
            // 
            this.gb_Patient_Details.BackColor = System.Drawing.Color.MistyRose;
            this.gb_Patient_Details.Controls.Add(this.tb_Consule_Fees);
            this.gb_Patient_Details.Controls.Add(this.lbl_Consule_Fees);
            this.gb_Patient_Details.Controls.Add(this.tb_dr_Name);
            this.gb_Patient_Details.Controls.Add(this.lbl_Doctor_Name);
            this.gb_Patient_Details.Controls.Add(this.tb_Patient_ID);
            this.gb_Patient_Details.Controls.Add(this.lbl_Patient_ID);
            this.gb_Patient_Details.Font = new System.Drawing.Font("Arial", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gb_Patient_Details.Location = new System.Drawing.Point(22, 141);
            this.gb_Patient_Details.Name = "gb_Patient_Details";
            this.gb_Patient_Details.Size = new System.Drawing.Size(1390, 147);
            this.gb_Patient_Details.TabIndex = 17;
            this.gb_Patient_Details.TabStop = false;
            this.gb_Patient_Details.Text = "Patient Details";
            // 
            // tb_Consule_Fees
            // 
            this.tb_Consule_Fees.Enabled = false;
            this.tb_Consule_Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Consule_Fees.Location = new System.Drawing.Point(899, 88);
            this.tb_Consule_Fees.MaxLength = 10;
            this.tb_Consule_Fees.Name = "tb_Consule_Fees";
            this.tb_Consule_Fees.Size = new System.Drawing.Size(312, 36);
            this.tb_Consule_Fees.TabIndex = 5;
            this.tb_Consule_Fees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Consule_Fees_KeyPress);
            // 
            // lbl_Consule_Fees
            // 
            this.lbl_Consule_Fees.AutoSize = true;
            this.lbl_Consule_Fees.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Consule_Fees.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Consule_Fees.ForeColor = System.Drawing.Color.Black;
            this.lbl_Consule_Fees.Location = new System.Drawing.Point(671, 95);
            this.lbl_Consule_Fees.Name = "lbl_Consule_Fees";
            this.lbl_Consule_Fees.Size = new System.Drawing.Size(182, 26);
            this.lbl_Consule_Fees.TabIndex = 6;
            this.lbl_Consule_Fees.Text = "Consultancy Fees";
            // 
            // tb_dr_Name
            // 
            this.tb_dr_Name.Enabled = false;
            this.tb_dr_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dr_Name.Location = new System.Drawing.Point(275, 95);
            this.tb_dr_Name.MaxLength = 20;
            this.tb_dr_Name.Name = "tb_dr_Name";
            this.tb_dr_Name.Size = new System.Drawing.Size(312, 36);
            this.tb_dr_Name.TabIndex = 4;
            this.tb_dr_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_dr_Name_KeyPress);
            // 
            // lbl_Doctor_Name
            // 
            this.lbl_Doctor_Name.AutoSize = true;
            this.lbl_Doctor_Name.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Doctor_Name.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Doctor_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Doctor_Name.Location = new System.Drawing.Point(90, 95);
            this.lbl_Doctor_Name.Name = "lbl_Doctor_Name";
            this.lbl_Doctor_Name.Size = new System.Drawing.Size(143, 26);
            this.lbl_Doctor_Name.TabIndex = 4;
            this.lbl_Doctor_Name.Text = "Doctor Name";
            // 
            // tb_Patient_ID
            // 
            this.tb_Patient_ID.Enabled = false;
            this.tb_Patient_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Patient_ID.Location = new System.Drawing.Point(515, 38);
            this.tb_Patient_ID.MaxLength = 10;
            this.tb_Patient_ID.Name = "tb_Patient_ID";
            this.tb_Patient_ID.Size = new System.Drawing.Size(312, 36);
            this.tb_Patient_ID.TabIndex = 3;
            this.tb_Patient_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Patient_ID_KeyPress);
            // 
            // lbl_Patient_ID
            // 
            this.lbl_Patient_ID.AutoSize = true;
            this.lbl_Patient_ID.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Patient_ID.Font = new System.Drawing.Font("Bell MT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Patient_ID.ForeColor = System.Drawing.Color.Black;
            this.lbl_Patient_ID.Location = new System.Drawing.Point(383, 41);
            this.lbl_Patient_ID.Name = "lbl_Patient_ID";
            this.lbl_Patient_ID.Size = new System.Drawing.Size(115, 26);
            this.lbl_Patient_ID.TabIndex = 2;
            this.lbl_Patient_ID.Text = "Patient ID";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(968, 99);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(347, 34);
            this.dtp_Date.TabIndex = 2;
            // 
            // tb_Patient_Name
            // 
            this.tb_Patient_Name.Enabled = false;
            this.tb_Patient_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Patient_Name.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tb_Patient_Name.Location = new System.Drawing.Point(318, 99);
            this.tb_Patient_Name.MaxLength = 20;
            this.tb_Patient_Name.Name = "tb_Patient_Name";
            this.tb_Patient_Name.Size = new System.Drawing.Size(445, 36);
            this.tb_Patient_Name.TabIndex = 1;
            // 
            // lbl_Patient_Name
            // 
            this.lbl_Patient_Name.AutoSize = true;
            this.lbl_Patient_Name.BackColor = System.Drawing.Color.Snow;
            this.lbl_Patient_Name.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Patient_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Patient_Name.Location = new System.Drawing.Point(92, 99);
            this.lbl_Patient_Name.Name = "lbl_Patient_Name";
            this.lbl_Patient_Name.Size = new System.Drawing.Size(195, 34);
            this.lbl_Patient_Name.TabIndex = 18;
            this.lbl_Patient_Name.Text = "Patient Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_Priscription);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 91);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dental_Clinic_Management_System.Properties.Resources._87_875613_go_back_button_png_download_blue_dollar_sign1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_Priscription
            // 
            this.lbl_Priscription.AutoSize = true;
            this.lbl_Priscription.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_Priscription.ForeColor = System.Drawing.Color.White;
            this.lbl_Priscription.Location = new System.Drawing.Point(454, 8);
            this.lbl_Priscription.Name = "lbl_Priscription";
            this.lbl_Priscription.Size = new System.Drawing.Size(384, 73);
            this.lbl_Priscription.TabIndex = 0;
            this.lbl_Priscription.Text = "Prescription";
            // 
            // tb_G_Total
            // 
            this.tb_G_Total.Enabled = false;
            this.tb_G_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_G_Total.Location = new System.Drawing.Point(1241, 55);
            this.tb_G_Total.MaxLength = 10;
            this.tb_G_Total.Name = "tb_G_Total";
            this.tb_G_Total.Size = new System.Drawing.Size(141, 36);
            this.tb_G_Total.TabIndex = 17;
            this.tb_G_Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_G_Total_KeyPress);
            // 
            // lbl_Grand_Total
            // 
            this.lbl_Grand_Total.AutoSize = true;
            this.lbl_Grand_Total.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Grand_Total.Font = new System.Drawing.Font("Bell MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Grand_Total.ForeColor = System.Drawing.Color.Black;
            this.lbl_Grand_Total.Location = new System.Drawing.Point(1219, 21);
            this.lbl_Grand_Total.Name = "lbl_Grand_Total";
            this.lbl_Grand_Total.Size = new System.Drawing.Size(163, 31);
            this.lbl_Grand_Total.TabIndex = 24;
            this.lbl_Grand_Total.Text = "Grand Total";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Red;
            this.btn_Add.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(1105, 7);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(108, 53);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Medication
            // 
            this.tb_Medication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Medication.Location = new System.Drawing.Point(285, 16);
            this.tb_Medication.MaxLength = 80;
            this.tb_Medication.Name = "tb_Medication";
            this.tb_Medication.Size = new System.Drawing.Size(269, 36);
            this.tb_Medication.TabIndex = 14;
            // 
            // lbl_Medication
            // 
            this.lbl_Medication.AutoSize = true;
            this.lbl_Medication.BackColor = System.Drawing.Color.SeaShell;
            this.lbl_Medication.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Medication.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbl_Medication.Location = new System.Drawing.Point(0, 14);
            this.lbl_Medication.Name = "lbl_Medication";
            this.lbl_Medication.Size = new System.Drawing.Size(286, 40);
            this.lbl_Medication.TabIndex = 26;
            this.lbl_Medication.Text = "Medication/Doses";
            // 
            // dgv_Medication
            // 
            this.dgv_Medication.AllowUserToAddRows = false;
            this.dgv_Medication.AllowUserToDeleteRows = false;
            this.dgv_Medication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Medication.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Medication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Medication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medication,
            this.Quantity,
            this.Time});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Medication.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Medication.Location = new System.Drawing.Point(10, 71);
            this.dgv_Medication.Name = "dgv_Medication";
            this.dgv_Medication.ReadOnly = true;
            this.dgv_Medication.RowHeadersVisible = false;
            this.dgv_Medication.RowTemplate.Height = 24;
            this.dgv_Medication.Size = new System.Drawing.Size(1211, 94);
            this.dgv_Medication.TabIndex = 29;
            // 
            // tb_Qty
            // 
            this.tb_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Qty.Location = new System.Drawing.Point(697, 16);
            this.tb_Qty.MaxLength = 3;
            this.tb_Qty.Name = "tb_Qty";
            this.tb_Qty.Size = new System.Drawing.Size(71, 36);
            this.tb_Qty.TabIndex = 15;
            this.tb_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Qty_KeyPress);
            // 
            // gb_Medication
            // 
            this.gb_Medication.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_Medication.Controls.Add(this.tb_Time);
            this.gb_Medication.Controls.Add(this.lbl_Time);
            this.gb_Medication.Controls.Add(this.tb_Qty);
            this.gb_Medication.Controls.Add(this.tb_G_Total);
            this.gb_Medication.Controls.Add(this.tb_Medication);
            this.gb_Medication.Controls.Add(this.lbl_Grand_Total);
            this.gb_Medication.Controls.Add(this.lbl_Qty);
            this.gb_Medication.Controls.Add(this.dgv_Medication);
            this.gb_Medication.Controls.Add(this.btn_Save);
            this.gb_Medication.Controls.Add(this.lbl_Medication);
            this.gb_Medication.Controls.Add(this.btn_Add);
            this.gb_Medication.Location = new System.Drawing.Point(12, 569);
            this.gb_Medication.Name = "gb_Medication";
            this.gb_Medication.Size = new System.Drawing.Size(1400, 171);
            this.gb_Medication.TabIndex = 31;
            this.gb_Medication.TabStop = false;
            // 
            // lbl_Qty
            // 
            this.lbl_Qty.AutoSize = true;
            this.lbl_Qty.BackColor = System.Drawing.Color.SeaShell;
            this.lbl_Qty.Font = new System.Drawing.Font("Sitka Small", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qty.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbl_Qty.Location = new System.Drawing.Point(560, 14);
            this.lbl_Qty.Name = "lbl_Qty";
            this.lbl_Qty.Size = new System.Drawing.Size(131, 36);
            this.lbl_Qty.TabIndex = 30;
            this.lbl_Qty.Text = "Quantity";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Crimson;
            this.btn_Save.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(1241, 112);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(141, 53);
            this.btn_Save.TabIndex = 18;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Medication
            // 
            this.Medication.HeaderText = "Medication/Doses";
            this.Medication.Name = "Medication";
            this.Medication.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // tb_Time
            // 
            this.tb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Time.Location = new System.Drawing.Point(868, 16);
            this.tb_Time.MaxLength = 15;
            this.tb_Time.Name = "tb_Time";
            this.tb_Time.Size = new System.Drawing.Size(231, 36);
            this.tb_Time.TabIndex = 17;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.BackColor = System.Drawing.Color.SeaShell;
            this.lbl_Time.Font = new System.Drawing.Font("Sitka Small", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbl_Time.Location = new System.Drawing.Point(780, 14);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(82, 36);
            this.lbl_Time.TabIndex = 32;
            this.lbl_Time.Text = "Time";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // frm_Prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1424, 752);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Medication);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gb_Treatment);
            this.Controls.Add(this.gb_Patient_Details);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.tb_Patient_Name);
            this.Controls.Add(this.lbl_Patient_Name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Prescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm Prescription";
            this.Load += new System.EventHandler(this.frm_Prescription_Load);
            this.gb_Treatment.ResumeLayout(false);
            this.gb_Treatment.PerformLayout();
            this.gb_Treat.ResumeLayout(false);
            this.gb_Treat.PerformLayout();
            this.gb_Patient_Details.ResumeLayout(false);
            this.gb_Patient_Details.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Medication)).EndInit();
            this.gb_Medication.ResumeLayout(false);
            this.gb_Medication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Treatment;
        private System.Windows.Forms.TextBox tb_Treat_Charges;
        private System.Windows.Forms.Label lbl_Treatment_Charges;
        private System.Windows.Forms.GroupBox gb_Treat;
        private System.Windows.Forms.CheckBox cb_Braces;
        private System.Windows.Forms.CheckBox cb_Crowns_and_Caps;
        private System.Windows.Forms.CheckBox cb_Bridges_and_Impletns;
        private System.Windows.Forms.CheckBox cb_Dentures;
        private System.Windows.Forms.CheckBox cb_Gun_Surgery;
        private System.Windows.Forms.CheckBox cb_Filling_and_Repairs;
        private System.Windows.Forms.Label lbl_Treatment;
        private System.Windows.Forms.TextBox tb_Jaw_Teeth_No;
        private System.Windows.Forms.Label lbl_Jaw_Teeth_No;
        private System.Windows.Forms.GroupBox gb_Patient_Details;
        private System.Windows.Forms.TextBox tb_Consule_Fees;
        private System.Windows.Forms.Label lbl_Consule_Fees;
        private System.Windows.Forms.TextBox tb_dr_Name;
        private System.Windows.Forms.Label lbl_Doctor_Name;
        private System.Windows.Forms.TextBox tb_Patient_ID;
        private System.Windows.Forms.Label lbl_Patient_ID;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox tb_Patient_Name;
        private System.Windows.Forms.Label lbl_Patient_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Priscription;
        private System.Windows.Forms.TextBox tb_G_Total;
        private System.Windows.Forms.Label lbl_Grand_Total;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_Medication;
        private System.Windows.Forms.Label lbl_Medication;
        private System.Windows.Forms.DataGridView dgv_Medication;
        private System.Windows.Forms.TextBox tb_Qty;
        private System.Windows.Forms.GroupBox gb_Medication;
        private System.Windows.Forms.Label lbl_Qty;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medication;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.TextBox tb_Time;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}