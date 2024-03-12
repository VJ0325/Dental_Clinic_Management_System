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
    public partial class frm_User_Management : Form
    {
        public frm_User_Management()
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

        void Clear_Controls()
        {
            cmb_A_User_Role.Text = "";
            tb_A_Username.Clear();
            tb_A_Password.Clear();
            cmb_A_User_Role.SelectedIndex = -1;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (cmb_A_User_Role.Text != "" && tb_A_Username.Text != "" && tb_A_Password.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Login_Details values (@URole, @UName, @Pass)";

                Cmd.Parameters.Add("URole", SqlDbType.NVarChar).Value = cmb_A_User_Role.Text;
                Cmd.Parameters.Add("UName", SqlDbType.NVarChar).Value = tb_A_Username.Text;
                Cmd.Parameters.Add("Pass", SqlDbType.NVarChar).Value = tb_A_Password.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All The Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();

        }

        private void btn_A_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void cmb_U_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            cmb_U_Username.Items.Clear();

            SqlCommand Cmd = new SqlCommand("Select Distinct(Username) from Login_Details where User_Role = '" + cmb_U_User_Role.Text + "'", Con);

            SqlDataReader Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cmb_U_Username.Items.Add(Obj.GetString(Obj.GetOrdinal("Username")));
            }

            Obj.Dispose();
            Cmd.Dispose();

            Con_Close();
            cmb_U_Username.Enabled = true;
        }

        private void btn_U_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (cmb_U_User_Role.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;

                Cmd.CommandText = "Select * from Login_Details where Username = Username";
                Cmd.Parameters.Add("Username", SqlDbType.NVarChar).Value = cmb_U_Username.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_U_New_Password.Text = (Dr["Password"].ToString());
                }
                else
                {
                    MessageBox.Show("Invalid Username", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_U_Username.Text = "";
                    cmb_U_Username.Focus();
                }
                Con_Close();
                cmb_U_User_Role.Enabled = true;
                cmb_U_Username.Enabled = true;
            }
        }

        private void tb_U_Username_TextChanged(object sender, EventArgs e)
        {
            tb_U_New_Password.Enabled = true;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_D_User_Role.Text = "";
            cmb_D_Username.Items.Clear();
            cmb_D_Username.SelectedIndex = -1;
            tb_D_Admin_Password.Enabled = true;
            tb_D_Admin_Password.Clear();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (cmb_U_User_Role.Text != "" && cmb_U_Username.Text != "" && cmb_U_Username.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Update Login_Details Set Password = '" + tb_U_New_Password.Text + "' where Username = '" + cmb_U_Username.Text + "' ", Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmb_U_User_Role.SelectedIndex = -1;
                cmb_U_User_Role.Items.Clear();
                cmb_U_Username.Text = "";
                tb_U_New_Password.Clear();              
            }
            else
            {
                MessageBox.Show("First Fill All The Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }

        private void btn_U_Refresh_Click(object sender, EventArgs e)
        {
            cmb_U_User_Role.Text = "";
            cmb_U_Username.Items.Clear();
            cmb_U_Username.Text = "";
            tb_U_New_Password.Clear();
            cmb_U_User_Role.Enabled = true;
            cmb_U_User_Role.SelectedIndex = -1;
            
        }

        private void cmb_U_Username_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_U_New_Password.Enabled = true;
        }

        private void tb_A_Username_TextChanged(object sender, EventArgs e)
        {
            tb_U_New_Password.Enabled = true;
        }

        private void cmb_D_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

            Con_Open();

            cmb_D_Username.Items.Clear();

            SqlCommand Cmd = new SqlCommand("Select Distinct(Username) from Login_Details where User_Role = '" + cmb_D_User_Role.Text + "'", Con);

            SqlDataReader Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cmb_D_Username.Items.Add(Obj.GetString(Obj.GetOrdinal("Username")));
            }

            Obj.Dispose();
            Cmd.Dispose();

            Con_Close();

            cmb_D_Username.Enabled = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
           Con_Open();

            if (cmb_D_User_Role.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * from Login_Details where Username = @Username";
                Cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = cmb_D_Username.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_D_Admin_Password.Text = (Dr["Password"].ToString());
                }
                else
                {
                    MessageBox.Show("Invalid Username", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_D_Username.Text = "";
                    cmb_D_Username.Focus();
                }
                Con_Close();
                cmb_D_User_Role.Enabled = true;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (cmb_D_User_Role.Text != "" && cmb_D_Username.Text != "" && tb_D_Admin_Password.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Delete Login_Details where Username = @Username";

                Cmd.Connection = Con;

                Cmd.Parameters.Add("URole", SqlDbType.NVarChar).Value = cmb_D_User_Role.Text;
                Cmd.Parameters.Add("Username", SqlDbType.NVarChar).Value = cmb_D_Username.Text;
                Cmd.Parameters.Add("Pass", SqlDbType.NVarChar).Value = tb_D_Admin_Password.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted This Record Permantly", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Refresh.PerformClick();
            }
            else
            {
                MessageBox.Show("First Search Valid Username", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }

        private void cmb_D_Username_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_D_Admin_Password.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
