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
    public partial class frm_Search_Employee_Details : Form
    {
        public frm_Search_Employee_Details()
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

            tb_Employee_ID.Text = "";
            tb_Employee_Name.Text = "";
            dtp_DOB.ResetText();
            tb_Address.Text = "";
            tb_Contact_No_1.Text = "";
            tb_Contact_No_2.Text = "";
            tb_Experience.Text = "";
            tb_Salary.Text = "";
            tb_Education.Text = "";
            tb_Employee_ID.Enabled = true;
            tb_Employee_Name.Enabled = false;
            dtp_DOB.Enabled = false;
            tb_Address.Enabled = false;
            tb_Contact_No_1.Enabled = false;
            tb_Contact_No_2.Enabled = false;
            tb_Experience.Enabled = false;
            tb_Salary.Enabled = false;
            tb_Education.Enabled = false;


            tb_Employee_ID.Focus();

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Employee_ID.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * from Employee_Details where Employee_ID = " + tb_Employee_ID.Text + " ";

                var obj = Cmd.ExecuteReader();


                if (obj.Read())
                {
                    tb_Employee_Name.Text = obj.GetString(obj.GetOrdinal("Employee_Name"));
                    dtp_DOB.Text = (obj["Joining_Date"].ToString());
                    tb_Contact_No_1.Text = (obj["Contact_No1"].ToString());
                    tb_Contact_No_2.Text = (obj["Contact_No2"].ToString());
                    tb_Education.Text = obj.GetString(obj.GetOrdinal("Education"));
                    tb_Experience.Text = obj.GetString(obj.GetOrdinal("Experience"));
                    tb_Salary.Text = (obj["Salary"].ToString());
                    tb_Address.Text = obj.GetString(obj.GetOrdinal("Address"));

                    tb_Employee_ID.Enabled = true;
                    tb_Employee_Name.Enabled = false;
                    dtp_DOB.Enabled = false;
                    tb_Address.Enabled = false;
                    tb_Contact_No_1.Enabled = false;
                    tb_Contact_No_2.Enabled = false;
                    tb_Experience.Enabled = false;
                    tb_Salary.Enabled = false;
                    tb_Education.Enabled = false;


                }
                else
                {
                    MessageBox.Show("Invalid Employee ID", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear_Controls();
                }


                Con_Close();
            }
        }

        private void tb_Contact_No_1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Contact_No_2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();

            obj.Show();
            this.Hide();
        }
    }
}
