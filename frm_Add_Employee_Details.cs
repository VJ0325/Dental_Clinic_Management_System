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
    public partial class frm_Add_Employee_Details : Form
    {
        public frm_Add_Employee_Details()
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

            Cmd.CommandText = "Select Count(*) from Employee_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.CommandText = "Select Max(Employee_ID) from Employee_Details";
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

        void Clear_controls()
        {
            tb_Employee_ID.Text = Convert.ToString(Auto_Incr());

            tb_Employee_Name.Text = "";
            dtp_DOB.ResetText();
            tb_Address.Text = "";
            tb_Contact_No_1.Text = "";
            tb_Contact_No_2.Text = "";
            tb_Experience.Text = "";
            tb_Salary.Text = "";
            tb_Education.Text = "";

            tb_Employee_ID.Focus();
            tb_Employee_ID.Enabled = false;

        }

        private void tb_Employee_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Employee_Name_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Salary_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frm_Add_Employee_Details_Load(object sender, EventArgs e)
        {
            tb_Employee_ID.Text = Auto_Incr().ToString();
            tb_Employee_ID.Enabled = false;
        }

        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            Clear_controls();
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

            if (tb_Address.Text == "")
            {
                tb_Address.Text = "";
            }

            if (tb_Experience.Text == "")
            {
                tb_Experience.Text = "";
            }

            else if (tb_Employee_ID.Text != "" && tb_Employee_Name.Text != ""  && tb_Address.Text != "" && tb_Contact_No_1.Text != "" 
              && tb_Salary.Text != "" && dtp_DOB.Text != "" && tb_Education.Text != "")

            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Employee_Details (Employee_ID, Employee_Name, Address, Education, Contact_No1, Contact_No2, Experience, Joining_Date, Salary) values (@Emp_ID, @Emp_Name, @Add, @Education, @Con_No1, @Con_No2, @Exp, @DOB, @Sal)";

                Cmd.Parameters.Add("@Emp_ID", SqlDbType.Int).Value = tb_Employee_ID.Text;
                Cmd.Parameters.Add("@Emp_Name", SqlDbType.VarChar).Value = tb_Employee_Name.Text;
                Cmd.Parameters.Add("@Add", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("@Education", SqlDbType.NVarChar).Value = tb_Education.Text;
                Cmd.Parameters.Add("@Con_No1", SqlDbType.Decimal).Value = tb_Contact_No_1.Text;
                Cmd.Parameters.Add("@Con_No2", SqlDbType.Decimal).Value = tb_Contact_No_2.Text;
                Cmd.Parameters.Add("@Exp", SqlDbType.NVarChar).Value = tb_Experience.Text;
                Cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("@Sal", SqlDbType.Money).Value = tb_Salary.Text;

                Cmd.ExecuteNonQuery();

                
                MessageBox.Show("Employee Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_controls();
               
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
        }

        }
    }

