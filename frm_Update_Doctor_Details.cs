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
    public partial class frm_Update_Doctor_Details : Form
    {
        public frm_Update_Doctor_Details()
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
            tb_Doctor_ID.Enabled = true;
            tb_Consultancy_Fee.Text = "";
        }


        private void tb_Doctor_ID_TextChanged(object sender, EventArgs e)
        {
            tb_Doctor_ID.Enabled = true;
            tb_Doctor_ID.Focus();
        }
    
        private void btn_Update_Click(object sender, EventArgs e)
        {

            Con_Open();

            if (tb_Contact_No_1.TextLength < 10)
            {
                MessageBox.Show("Invalid Contact Number", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Contact_No_1.Focus();
            }


            if (tb_Doctor_ID.Text != "" && tb_Doctor_Name.Text != "" && tb_Contact_No_1.Text != "" && tb_Contact_No_2.Text != "" && tb_Aadhar_Card_No.Text != "" &&
                tb_Clinic_Address.Text != "" && dtp_DOB.Text != "" && tb_Email_ID.Text != "" && tb_PAN_No.Text != "" && dtp_Joining_Date.Text != "" && tb_Consultancy_Fee.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Doctor_Details Set Doctor_ID = @D_ID, Doctor_Name = @D_Name, Contact_No1 = @Con_No1, Contact_No2 = @Con_No2, Aadhar_Card_No = @Aadhar_No, Clinic_Address = @Clinic_Add, DOB = @DOB, Date = @Date, Email_ID = @E_ID, PAN_No = @PAN_No Where C_Fees = @C_Fees";
               

                Cmd.Parameters.Add("D_ID", SqlDbType.Int).Value = tb_Doctor_ID.Text;
                Cmd.Parameters.Add("D_Name", SqlDbType.VarChar).Value = tb_Doctor_Name.Text;
                Cmd.Parameters.Add("Con_No1", SqlDbType.Decimal).Value = tb_Contact_No_1.Text;
                Cmd.Parameters.Add("Con_No2", SqlDbType.Decimal).Value = tb_Contact_No_2.Text;
                Cmd.Parameters.Add("Aadhar_No", SqlDbType.NVarChar).Value = tb_Aadhar_Card_No.Text;
                Cmd.Parameters.Add("Clinic_Add", SqlDbType.NVarChar).Value = tb_Clinic_Address.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Joining_Date.Text;
                Cmd.Parameters.Add("E_ID", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
                Cmd.Parameters.Add("PAN_No", SqlDbType.NVarChar).Value = tb_PAN_No.Text;
                Cmd.Parameters.Add("C_Fees", SqlDbType.NVarChar).Value = tb_Consultancy_Fee.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Doctor Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
               
            }
            else
            {
                MessageBox.Show("Fill Complete Details", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Doctor_ID.Text != "")
            {
                Con_Open();

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
                    
                    tb_Doctor_ID.Focus();
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
            frm_Login obj = new frm_Login();

            obj.Show();
            this.Hide();
        }

        private void frm_Update_Doctor_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
