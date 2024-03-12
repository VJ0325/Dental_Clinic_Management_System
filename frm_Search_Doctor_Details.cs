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
    public partial class frm_Search_Doctor_Details : Form
    {
        public frm_Search_Doctor_Details()
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
            tb_Doctor_ID.Text = "";

            tb_Doctor_Name.Text = "";
            tb_Contact_No_1.Text = "";
            tb_Contact_No_2.Text = "";
            tb_Aadhar_Card_No.Text = "";
            tb_Clinic_Address.Text = "";
            dtp_DOB.ResetText();
            tb_Email_ID.Text = "";
            tb_PAN_No.Text = "";
            dtp_Joining_Date.Text = "";
            tb_Consultancy_Fee.Text = "";

            tb_Doctor_ID.Enabled = true;
            tb_Doctor_Name.Enabled = false;
            tb_Email_ID.Enabled = false;
            tb_PAN_No.Enabled = false;
            tb_Contact_No_1.Enabled = false;
            tb_Contact_No_2.Enabled = false;
            dtp_DOB.Enabled = false;
            tb_Aadhar_Card_No.Enabled = false;
            dtp_Joining_Date.Enabled = false;
            tb_Consultancy_Fee.Enabled = false;

            tb_Doctor_Name.Focus();
        }


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
 
        private void btn_Search_Click(object sender, EventArgs e)
        {           
            Con_Open();

            if (tb_Doctor_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Select * From Doctor_Details Where Doctor_ID = " + tb_Doctor_ID.Text + " ";

                SqlDataReader obj = Cmd.ExecuteReader();

                if (obj.Read())
                {
                    
                    tb_Doctor_Name.Text = obj.GetString(obj.GetOrdinal("Doctor_Name"));
                    tb_Contact_No_1.Text = (obj["Contact_No1"].ToString());
                    tb_Contact_No_2.Text = (obj["Contact_No2"].ToString());
                    tb_Aadhar_Card_No.Text = (obj["Aadhar_Card_No"].ToString());
                    tb_Clinic_Address.Text = obj.GetString(obj.GetOrdinal("Clinic_Address"));
                    dtp_DOB.Text = (obj["DOB"].ToString());
                    tb_PAN_No.Text = (obj["PAN_No"].ToString());
                    tb_Email_ID.Text = (obj["Email_ID"].ToString());
                    tb_Consultancy_Fee.Text = (obj["C_Fees"].ToString());

                    tb_Doctor_ID.Enabled = true;
                    tb_Doctor_Name.Enabled = false;
                    tb_Email_ID.Enabled = false;
                    tb_PAN_No.Enabled = false;
                    tb_Contact_No_1.Enabled = false;
                    tb_Contact_No_2.Enabled = false;
                    dtp_DOB.Enabled = false;
                    tb_Aadhar_Card_No.Enabled = false;
                    dtp_Joining_Date.Enabled = false;
                    tb_Clinic_Address.Enabled = false;
                    tb_Consultancy_Fee.Enabled = false;

                    tb_Doctor_Name.Focus();
                }

                else
                {
                    MessageBox.Show("Record Not Found");
                    Clear_Controls();
                }
                Con_Close();
            }

        }       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        }
           
    }

