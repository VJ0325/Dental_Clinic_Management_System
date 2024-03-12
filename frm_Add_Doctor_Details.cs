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
    public partial class frm_Add_Doctor_Details : Form
    {
        public frm_Add_Doctor_Details()
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

        int Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            
            Cmd.Connection = Con;

            Cmd.CommandText = "Select Count(*) from Doctor_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.CommandText = "Select Max(Doctor_ID) from Doctor_Details";

                Cmd.Connection = Con;
                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
                Cnt += 1;
            }
            else
            {
                Cnt = 101;
            }

            Con_Close();

            return Cnt;
        }

        void Clear_Controls()
        {
           tb_Doctor_ID.Text = Convert.ToString(Auto_Incr());

            tb_Doctor_Name.Text = "";
            tb_Contact_No_1.Text = "";
            tb_Contact_No_2.Text = "";
            tb_Aadhar_Card_No.Text = "";
            tb_Clinic_Address.Text = "";
            dtp_DOB.ResetText();          
            tb_Email_ID.Text = "";
            tb_PAN_No.Text = "";
            dtp_Date.ResetText();
            tb_Consultancy_Fee.Text = "";

            tb_Doctor_Name.Focus();
        }


        private void frm_Add_Doctor_Details_Load(object sender, EventArgs e)
        {
            tb_Doctor_ID.Text = Auto_Incr().ToString();
            tb_Doctor_ID.Enabled = false;
            Clear_Controls();
        }

        private void tb_Aadhar_Card_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Doctor_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
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

        private void tb_Consultancy_Fee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Contact_No_1.TextLength < 10)
            {
                MessageBox.Show("Invalid Contact Number", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Contact_No_1.Focus();
            }

            if (tb_Contact_No_2.Text == "")
            {
                tb_Contact_No_2.Text = "0";
            }

            else if (tb_Doctor_ID.Text != "" && tb_Doctor_Name.Text != "" && tb_Contact_No_1.Text != "" && tb_Contact_No_2.Text != "" && tb_Aadhar_Card_No.Text != ""
                  && dtp_DOB.Text != "" && dtp_Date.Text != "" && tb_PAN_No.Text != "" && tb_Consultancy_Fee.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Doctor_Details Values (@D_ID, @D_Name, @Con_No1, @Con_No2, @Clinic_Add, @Aadhar_No, @DOB, @Date, @E_ID, @PAN_No, @C_Fees)";

                Cmd.Parameters.Add("D_ID", SqlDbType.Int).Value = tb_Doctor_ID.Text;
                Cmd.Parameters.Add("D_Name", SqlDbType.VarChar).Value = tb_Doctor_Name.Text;
                Cmd.Parameters.Add("Con_No1", SqlDbType.Decimal).Value = tb_Contact_No_1.Text;
                Cmd.Parameters.Add("Con_No2", SqlDbType.Decimal).Value = tb_Contact_No_2.Text;
                Cmd.Parameters.Add("Clinic_Add", SqlDbType.NVarChar).Value = tb_Clinic_Address.Text;
                Cmd.Parameters.Add("Aadhar_No", SqlDbType.NVarChar).Value = tb_Aadhar_Card_No.Text;               
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("E_ID", SqlDbType.NVarChar).Value = tb_Email_ID.Text;                
                Cmd.Parameters.Add("PAN_No", SqlDbType.NVarChar).Value = tb_PAN_No.Text;
                Cmd.Parameters.Add("C_Fees", SqlDbType.Money).Value = tb_Consultancy_Fee.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Doctor Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Common_Const.DrID = Convert.ToInt32(tb_Doctor_ID.Text);

                this.Hide();

                frm_Specialization_Charges Obj = new frm_Specialization_Charges();

                Obj.Show();

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill Complete Details", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
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
