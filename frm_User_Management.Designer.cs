namespace Dental_Clinic_Management_System
{
    partial class frm_User_Management
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
            this.tb_Update_User = new System.Windows.Forms.TabControl();
            this.tp_Add_User = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_A_User_Role = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_A_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_A_Password = new System.Windows.Forms.TextBox();
            this.tb_A_Username = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tp_Update_User = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_U_User_Role = new System.Windows.Forms.ComboBox();
            this.cmb_U_Username = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_U_Search = new System.Windows.Forms.Button();
            this.btn_U_Refresh = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_U_New_Password = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_Delete_User = new System.Windows.Forms.TabPage();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.cmb_D_User_Role = new System.Windows.Forms.ComboBox();
            this.cmb_D_Username = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_D_Admin_Password = new System.Windows.Forms.TextBox();
            this.lbl_Admin_Password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Delete_Application_User = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_User_Management = new System.Windows.Forms.Label();
            this.tb_Update_User.SuspendLayout();
            this.tp_Add_User.SuspendLayout();
            this.tp_Update_User.SuspendLayout();
            this.tb_Delete_User.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Update_User
            // 
            this.tb_Update_User.Controls.Add(this.tp_Add_User);
            this.tb_Update_User.Controls.Add(this.tp_Update_User);
            this.tb_Update_User.Controls.Add(this.tb_Delete_User);
            this.tb_Update_User.Location = new System.Drawing.Point(34, 95);
            this.tb_Update_User.Name = "tb_Update_User";
            this.tb_Update_User.SelectedIndex = 0;
            this.tb_Update_User.Size = new System.Drawing.Size(1116, 603);
            this.tb_Update_User.TabIndex = 2;
            this.tb_Update_User.Tag = "";
            // 
            // tp_Add_User
            // 
            this.tp_Add_User.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tp_Add_User.Controls.Add(this.label5);
            this.tp_Add_User.Controls.Add(this.cmb_A_User_Role);
            this.tp_Add_User.Controls.Add(this.label6);
            this.tp_Add_User.Controls.Add(this.btn_A_Refresh);
            this.tp_Add_User.Controls.Add(this.btn_Save);
            this.tp_Add_User.Controls.Add(this.tb_A_Password);
            this.tp_Add_User.Controls.Add(this.tb_A_Username);
            this.tp_Add_User.Controls.Add(this.label17);
            this.tp_Add_User.Controls.Add(this.label9);
            this.tp_Add_User.Location = new System.Drawing.Point(4, 25);
            this.tp_Add_User.Name = "tp_Add_User";
            this.tp_Add_User.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Add_User.Size = new System.Drawing.Size(1108, 574);
            this.tp_Add_User.TabIndex = 0;
            this.tp_Add_User.Text = "Add New User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Cambria", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(315, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(464, 79);
            this.label5.TabIndex = 3;
            this.label5.Text = "Add New User";
            // 
            // cmb_A_User_Role
            // 
            this.cmb_A_User_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_A_User_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_A_User_Role.FormattingEnabled = true;
            this.cmb_A_User_Role.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cmb_A_User_Role.Location = new System.Drawing.Point(703, 165);
            this.cmb_A_User_Role.Name = "cmb_A_User_Role";
            this.cmb_A_User_Role.Size = new System.Drawing.Size(319, 37);
            this.cmb_A_User_Role.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LavenderBlush;
            this.label6.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(163, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 40);
            this.label6.TabIndex = 47;
            this.label6.Text = "User Role";
            // 
            // btn_A_Refresh
            // 
            this.btn_A_Refresh.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_A_Refresh.ForeColor = System.Drawing.Color.Lime;
            this.btn_A_Refresh.Location = new System.Drawing.Point(663, 485);
            this.btn_A_Refresh.Name = "btn_A_Refresh";
            this.btn_A_Refresh.Size = new System.Drawing.Size(179, 59);
            this.btn_A_Refresh.TabIndex = 5;
            this.btn_A_Refresh.Text = "Refresh";
            this.btn_A_Refresh.UseVisualStyleBackColor = true;
            this.btn_A_Refresh.Click += new System.EventHandler(this.btn_A_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Lime;
            this.btn_Save.Location = new System.Drawing.Point(297, 485);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(179, 59);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_A_Password
            // 
            this.tb_A_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_A_Password.Location = new System.Drawing.Point(703, 359);
            this.tb_A_Password.MaxLength = 6;
            this.tb_A_Password.Name = "tb_A_Password";
            this.tb_A_Password.PasswordChar = '*';
            this.tb_A_Password.Size = new System.Drawing.Size(319, 36);
            this.tb_A_Password.TabIndex = 3;
            // 
            // tb_A_Username
            // 
            this.tb_A_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_A_Username.Location = new System.Drawing.Point(703, 261);
            this.tb_A_Username.MaxLength = 10;
            this.tb_A_Username.Name = "tb_A_Username";
            this.tb_A_Username.Size = new System.Drawing.Size(319, 36);
            this.tb_A_Username.TabIndex = 2;
            this.tb_A_Username.TextChanged += new System.EventHandler(this.tb_A_Username_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.LavenderBlush;
            this.label17.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Navy;
            this.label17.Location = new System.Drawing.Point(166, 344);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(168, 40);
            this.label17.TabIndex = 46;
            this.label17.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LavenderBlush;
            this.label9.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(163, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 40);
            this.label9.TabIndex = 45;
            this.label9.Text = "Username";
            // 
            // tp_Update_User
            // 
            this.tp_Update_User.BackColor = System.Drawing.Color.Gainsboro;
            this.tp_Update_User.Controls.Add(this.label10);
            this.tp_Update_User.Controls.Add(this.cmb_U_User_Role);
            this.tp_Update_User.Controls.Add(this.cmb_U_Username);
            this.tp_Update_User.Controls.Add(this.label11);
            this.tp_Update_User.Controls.Add(this.btn_U_Search);
            this.tp_Update_User.Controls.Add(this.btn_U_Refresh);
            this.tp_Update_User.Controls.Add(this.btn_Update);
            this.tp_Update_User.Controls.Add(this.tb_U_New_Password);
            this.tp_Update_User.Controls.Add(this.label13);
            this.tp_Update_User.Controls.Add(this.label15);
            this.tp_Update_User.Location = new System.Drawing.Point(4, 25);
            this.tp_Update_User.Name = "tp_Update_User";
            this.tp_Update_User.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Update_User.Size = new System.Drawing.Size(1108, 574);
            this.tp_Update_User.TabIndex = 1;
            this.tp_Update_User.Text = "Update User";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(243, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(585, 59);
            this.label10.TabIndex = 3;
            this.label10.Text = "Update Application User";
            // 
            // cmb_U_User_Role
            // 
            this.cmb_U_User_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_U_User_Role.FormattingEnabled = true;
            this.cmb_U_User_Role.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cmb_U_User_Role.Location = new System.Drawing.Point(539, 191);
            this.cmb_U_User_Role.Name = "cmb_U_User_Role";
            this.cmb_U_User_Role.Size = new System.Drawing.Size(346, 37);
            this.cmb_U_User_Role.TabIndex = 1;
            this.cmb_U_User_Role.SelectedIndexChanged += new System.EventHandler(this.cmb_U_User_Role_SelectedIndexChanged);
            // 
            // cmb_U_Username
            // 
            this.cmb_U_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_U_Username.FormattingEnabled = true;
            this.cmb_U_Username.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cmb_U_Username.Location = new System.Drawing.Point(539, 288);
            this.cmb_U_Username.Name = "cmb_U_Username";
            this.cmb_U_Username.Size = new System.Drawing.Size(346, 37);
            this.cmb_U_Username.TabIndex = 48;
            this.cmb_U_Username.SelectedIndexChanged += new System.EventHandler(this.cmb_U_Username_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LavenderBlush;
            this.label11.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label11.Location = new System.Drawing.Point(177, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 40);
            this.label11.TabIndex = 55;
            this.label11.Text = "User Role";
            // 
            // btn_U_Search
            // 
            this.btn_U_Search.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_U_Search.ForeColor = System.Drawing.Color.Maroon;
            this.btn_U_Search.Location = new System.Drawing.Point(908, 281);
            this.btn_U_Search.Name = "btn_U_Search";
            this.btn_U_Search.Size = new System.Drawing.Size(179, 44);
            this.btn_U_Search.TabIndex = 5;
            this.btn_U_Search.Text = "Search";
            this.btn_U_Search.UseVisualStyleBackColor = true;
            this.btn_U_Search.Click += new System.EventHandler(this.btn_U_Search_Click);
            // 
            // btn_U_Refresh
            // 
            this.btn_U_Refresh.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_U_Refresh.ForeColor = System.Drawing.Color.Lime;
            this.btn_U_Refresh.Location = new System.Drawing.Point(715, 509);
            this.btn_U_Refresh.Name = "btn_U_Refresh";
            this.btn_U_Refresh.Size = new System.Drawing.Size(179, 59);
            this.btn_U_Refresh.TabIndex = 5;
            this.btn_U_Refresh.Text = "Refresh";
            this.btn_U_Refresh.UseVisualStyleBackColor = true;
            this.btn_U_Refresh.Click += new System.EventHandler(this.btn_U_Refresh_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Lime;
            this.btn_Update.Location = new System.Drawing.Point(270, 509);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(179, 59);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_U_New_Password
            // 
            this.tb_U_New_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_U_New_Password.Location = new System.Drawing.Point(539, 399);
            this.tb_U_New_Password.MaxLength = 6;
            this.tb_U_New_Password.Name = "tb_U_New_Password";
            this.tb_U_New_Password.PasswordChar = '*';
            this.tb_U_New_Password.Size = new System.Drawing.Size(346, 36);
            this.tb_U_New_Password.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LavenderBlush;
            this.label13.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label13.Location = new System.Drawing.Point(177, 395);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(243, 40);
            this.label13.TabIndex = 54;
            this.label13.Text = "New Password";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LavenderBlush;
            this.label15.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label15.Location = new System.Drawing.Point(177, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 40);
            this.label15.TabIndex = 53;
            this.label15.Text = "Username";
            // 
            // tb_Delete_User
            // 
            this.tb_Delete_User.BackColor = System.Drawing.Color.MistyRose;
            this.tb_Delete_User.Controls.Add(this.btn_Refresh);
            this.tb_Delete_User.Controls.Add(this.btn_Search);
            this.tb_Delete_User.Controls.Add(this.btn_Delete);
            this.tb_Delete_User.Controls.Add(this.cmb_D_User_Role);
            this.tb_Delete_User.Controls.Add(this.cmb_D_Username);
            this.tb_Delete_User.Controls.Add(this.label1);
            this.tb_Delete_User.Controls.Add(this.tb_D_Admin_Password);
            this.tb_Delete_User.Controls.Add(this.lbl_Admin_Password);
            this.tb_Delete_User.Controls.Add(this.label3);
            this.tb_Delete_User.Controls.Add(this.lbl_Delete_Application_User);
            this.tb_Delete_User.Location = new System.Drawing.Point(4, 25);
            this.tb_Delete_User.Name = "tb_Delete_User";
            this.tb_Delete_User.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Delete_User.Size = new System.Drawing.Size(1108, 574);
            this.tb_Delete_User.TabIndex = 2;
            this.tb_Delete_User.Text = "Delete User";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.Location = new System.Drawing.Point(645, 493);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(194, 56);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.Coral;
            this.btn_Search.Location = new System.Drawing.Point(908, 287);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(139, 49);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Location = new System.Drawing.Point(216, 493);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(194, 56);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // cmb_D_User_Role
            // 
            this.cmb_D_User_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_D_User_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_D_User_Role.FormattingEnabled = true;
            this.cmb_D_User_Role.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Staff"});
            this.cmb_D_User_Role.Location = new System.Drawing.Point(529, 187);
            this.cmb_D_User_Role.Name = "cmb_D_User_Role";
            this.cmb_D_User_Role.Size = new System.Drawing.Size(346, 37);
            this.cmb_D_User_Role.TabIndex = 1;
            this.cmb_D_User_Role.SelectedIndexChanged += new System.EventHandler(this.cmb_D_User_Role_SelectedIndexChanged);
            // 
            // cmb_D_Username
            // 
            this.cmb_D_Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_D_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_D_Username.FormattingEnabled = true;
            this.cmb_D_Username.Location = new System.Drawing.Point(529, 291);
            this.cmb_D_Username.Name = "cmb_D_Username";
            this.cmb_D_Username.Size = new System.Drawing.Size(346, 37);
            this.cmb_D_Username.TabIndex = 2;
            this.cmb_D_Username.SelectedIndexChanged += new System.EventHandler(this.cmb_D_Username_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(157, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 40);
            this.label1.TabIndex = 61;
            this.label1.Text = "User Role";
            // 
            // tb_D_Admin_Password
            // 
            this.tb_D_Admin_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_D_Admin_Password.Location = new System.Drawing.Point(529, 395);
            this.tb_D_Admin_Password.MaxLength = 6;
            this.tb_D_Admin_Password.Name = "tb_D_Admin_Password";
            this.tb_D_Admin_Password.PasswordChar = '*';
            this.tb_D_Admin_Password.Size = new System.Drawing.Size(346, 36);
            this.tb_D_Admin_Password.TabIndex = 3;
            // 
            // lbl_Admin_Password
            // 
            this.lbl_Admin_Password.AutoSize = true;
            this.lbl_Admin_Password.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbl_Admin_Password.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Admin_Password.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lbl_Admin_Password.Location = new System.Drawing.Point(157, 394);
            this.lbl_Admin_Password.Name = "lbl_Admin_Password";
            this.lbl_Admin_Password.Size = new System.Drawing.Size(175, 40);
            this.lbl_Admin_Password.TabIndex = 60;
            this.lbl_Admin_Password.Text = " Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LavenderBlush;
            this.label3.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(157, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 40);
            this.label3.TabIndex = 59;
            this.label3.Text = "Username";
            // 
            // lbl_Delete_Application_User
            // 
            this.lbl_Delete_Application_User.AutoSize = true;
            this.lbl_Delete_Application_User.BackColor = System.Drawing.Color.White;
            this.lbl_Delete_Application_User.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delete_Application_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Delete_Application_User.Location = new System.Drawing.Point(252, 45);
            this.lbl_Delete_Application_User.Name = "lbl_Delete_Application_User";
            this.lbl_Delete_Application_User.Size = new System.Drawing.Size(579, 59);
            this.lbl_Delete_Application_User.TabIndex = 3;
            this.lbl_Delete_Application_User.Text = "Delete Application User ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_User_Management);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 91);
            this.panel1.TabIndex = 38;
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
            // lbl_User_Management
            // 
            this.lbl_User_Management.AutoSize = true;
            this.lbl_User_Management.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_User_Management.ForeColor = System.Drawing.Color.White;
            this.lbl_User_Management.Location = new System.Drawing.Point(324, 9);
            this.lbl_User_Management.Name = "lbl_User_Management";
            this.lbl_User_Management.Size = new System.Drawing.Size(545, 73);
            this.lbl_User_Management.TabIndex = 0;
            this.lbl_User_Management.Text = "User Management";
            // 
            // frm_User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 705);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_Update_User);
            this.Name = "frm_User_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tb_Update_User.ResumeLayout(false);
            this.tp_Add_User.ResumeLayout(false);
            this.tp_Add_User.PerformLayout();
            this.tp_Update_User.ResumeLayout(false);
            this.tp_Update_User.PerformLayout();
            this.tb_Delete_User.ResumeLayout(false);
            this.tb_Delete_User.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_Update_User;
        private System.Windows.Forms.TabPage tp_Add_User;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_A_User_Role;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_A_Password;
        private System.Windows.Forms.TextBox tb_A_Username;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tp_Update_User;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_U_User_Role;
        private System.Windows.Forms.ComboBox cmb_U_Username;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tb_U_New_Password;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tb_Delete_User;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ComboBox cmb_D_User_Role;
        private System.Windows.Forms.ComboBox cmb_D_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_D_Admin_Password;
        private System.Windows.Forms.Label lbl_Admin_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Delete_Application_User;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_User_Management;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_U_Search;
        private System.Windows.Forms.Button btn_A_Refresh;
        private System.Windows.Forms.Button btn_U_Refresh;
    }
}