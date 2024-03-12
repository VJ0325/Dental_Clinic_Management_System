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
    public partial class frm_Add_Patient : Form
    {
        public frm_Add_Patient()
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

            Cmd.CommandText = "Select Count(Patient_ID) from Patient_Details";

            Cmd.Connection = Con;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.CommandText = "Select Max(Patient_ID) from Patient_Details";
                Cmd.Connection = Con;
                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
                Cnt += 1;
            }
            else
            {
                Cnt = 1001;
            }

            Con_Close();

            return Cnt;
        }

        void Clear_Controls()
        {
            tb_Patient_ID.Text = Convert.ToString(Auto_Incr());
            tb_Address.Text = "";
            cmb_Dr_Name.Text = "";
            tb_First_Name.Text = "";
            tb_Last_Name.Text = "";
            dtp_DOB.ResetText();
            tb_Charges.Text = "";
            tb_Contact_No_1.Text = "";
            tb_Contact_No_2.Text = "";
            gb_Blood_Pressure.Text = "";
            rb_Female.Checked = false;
            rb_Male.Checked = false;
            rb_High.Checked = false;
            rb_Normal.Checked = false;
            rb_Low.Checked = false;
            cmb_Blood_Group.Text = "";
            cmb_Dr_Name.Text = "";
            dtp_Date.ResetText();
            dtp_Appoint_Date.ResetText();

            tb_Patient_ID.Focus();
            tb_Patient_ID.Enabled = false;
            
        }

        void Bind_Combobox()
        {
            Con_Open();

            cmb_Dr_Name.Items.Clear();

            SqlCommand Cmd = new SqlCommand();

            Cmd.CommandText = "Select Distinct(Doctor_Name) from Doctor_Details";

            Cmd.Connection = Con;

            SqlDataReader obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Dr_Name.Items.Add(obj.GetString(obj.GetOrdinal("Doctor_Name")));
            }

            obj.Dispose();
            Cmd.Dispose();

            Con_Close();
        }

        private void frm_Add_Appointment_Load(object sender, EventArgs e)
        {
            tb_Patient_ID.Text = Auto_Incr().ToString();
            tb_Patient_ID.Enabled = false;
            Bind_Combobox();
            Clear_Controls();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_Controls();
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

        private void cmb_Dr_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            string BP = "";
            string Gender = "";

            if (rb_Male.Checked)
            {
                Gender = rb_Male.Text;
            }
            else if (rb_Female.Checked)
            {
                Gender = rb_Female.Text;
            }

            if (rb_Low.Checked)
            {
                BP = rb_Low.Text;
            }
            else if (rb_High.Checked)
            {
                BP = rb_High.Text;
            }
            else if (rb_Normal.Checked)
            {
                BP = rb_Normal.Text;
            }

            if (tb_Contact_No_1.TextLength < 10)
            {
                MessageBox.Show("Invalid Contact Number", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Contact_No_1.Focus();
            }

            if (tb_Contact_No_2.Text == "")
            {
                tb_Contact_No_2.Text = "0";
            }

            if (tb_Address.Text == "")
            {
                tb_Address.Text = "";
            }

            else if (tb_First_Name.Text != "" && tb_Last_Name.Text != "" && tb_Patient_ID.Text != "" && cmb_Dr_Name.Text != "" && tb_Contact_No_1.Text != "" && tb_Charges.Text != "" && dtp_Appoint_Date.Text != "" 
                && dtp_Date.Text != "" && cmb_Blood_Group.Text != "" && dtp_DOB.Text != "" && Gender != "")
            {
                SqlCommand Cmd = new SqlCommand();
                
                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Patient_Details (Patient_ID, Doctor_Name, Date, First_Name, Last_Name, Address, Contact_No1, Contact_No2, DOB, Gender, Blood_Group, Appointment_Date, Blood_Pressure, Charges) values (@PID, @Dr_Name, @Date, @F_Name, @L_Name, @Add, @Con_No1, @Con_No2, @DOB, @Gender, @B_Grp, @Appoint_D, @BP, @Charges)";

                Cmd.Parameters.Add("@PID", SqlDbType.Int).Value = tb_Patient_ID.Text;
                Cmd.Parameters.Add("@Dr_Name", SqlDbType.VarChar).Value = cmb_Dr_Name.Text;
                Cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("@F_Name", SqlDbType.VarChar).Value = tb_First_Name.Text;
                Cmd.Parameters.Add("@L_Name", SqlDbType.VarChar).Value = tb_Last_Name.Text;
                Cmd.Parameters.Add("@Add", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("@Con_No1", SqlDbType.Decimal).Value = tb_Contact_No_1.Text;
                Cmd.Parameters.Add("@Con_No2", SqlDbType.Decimal).Value = tb_Contact_No_2.Text;
                Cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
                Cmd.Parameters.Add("@B_Grp", SqlDbType.NVarChar).Value = cmb_Blood_Group.Text;
                Cmd.Parameters.Add("@Appoint_D", SqlDbType.Date).Value = dtp_Appoint_Date.Text;              
                Cmd.Parameters.Add("@BP", SqlDbType.VarChar).Value = BP;
                Cmd.Parameters.Add("@Charges", SqlDbType.Money).Value = tb_Charges.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Patient Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill Complete Details", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            Con_Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            panel1.Show();
        }

        
    }
}