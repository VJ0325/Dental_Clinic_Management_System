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
    public partial class frm_Search_Lab_Test : Form
    {
        public frm_Search_Lab_Test()
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
            tb_L_ID.Clear();
            tb_Lab_Name.Clear();
            tb_Charges.Clear();
            tb_Description.Clear();
            tb_T_Cases.Clear();
            tb_Duration.Clear();
            tb_D_Name.Clear();
            dtp_Date.ResetText();

            tb_L_ID.Focus();


        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            Con_Open();

            if (tb_L_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Select * From Lab_Test_Cases Where Lab_ID = " + tb_L_ID.Text + " ";

                SqlDataReader obj = Cmd.ExecuteReader();

                if (obj.Read())
                {

                    tb_Lab_Name.Text = obj.GetString(obj.GetOrdinal("Lab_Name"));
                    tb_T_Cases.Text = obj.GetString(obj.GetOrdinal("Test_Cases"));
                    tb_Charges.Text = (obj["Charges"].ToString());
                    tb_Duration.Text = obj.GetString(obj.GetOrdinal("Duration"));
                    tb_D_Name.Text = obj.GetString(obj.GetOrdinal("Doctor_Name"));
                    tb_Description.Text = obj.GetString(obj.GetOrdinal("Description"));
                    dtp_Date.Text = (obj["Date"].ToString());   

                }
                else
                {
                    MessageBox.Show("Record Not Found");
                    Clear_Controls();
                }
                Con_Close();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
