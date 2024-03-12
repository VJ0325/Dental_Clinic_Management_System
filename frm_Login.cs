using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dental_Clinic_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Dental_Clinic_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }


        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_Username.Focus();

            cmb_U_Role.SelectedIndex = -1;
        }

        private void tb_Username_TextChanged_1(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged_1(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count (*) from Login_Details where Username = @Uname And Password = @Pwd And User_Role = @URole";

            Cmd.Parameters.Add("Uname", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;
            Cmd.Parameters.Add("URole", SqlDbType.NVarChar).Value = cmb_U_Role.Text;

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                Common_Const.Uname = tb_Username.Text;

                if (cmb_U_Role.Text == "Admin")
                {
                    Common_Const.URole = 1;
                }

                if (cmb_U_Role.Text == "Manager")
                {
                    Common_Const.URole = 2;
                }

                if (cmb_U_Role.Text == "Staff")
                {
                    Common_Const.URole = 3;
                }

                if (cmb_U_Role.Text == "Cashier")
                {
                    Common_Const.URole = 4;
                }

                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MDI_Dental_Application obj = new MDI_Dental_Application();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tb_Username.Clear();

            tb_Password.Clear();
            tb_Username.Focus();
            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

            Con_Close();
            
        }


        }

       
    }


