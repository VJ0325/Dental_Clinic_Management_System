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
    public partial class frm_Update_Employee_Details : Form
    {
        public frm_Update_Employee_Details()
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
                }
                else
                {
                    MessageBox.Show("Invalid Employee ID", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear_Controls();
                }

                Con_Close();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
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

            else if (tb_Employee_ID.Text != "" && tb_Employee_Name.Text != "" && tb_Experience.Text != "" && tb_Address.Text != "" && tb_Contact_No_1.Text != "" &&
                tb_Contact_No_2.Text != "" && tb_Salary.Text != "" && dtp_DOB.Text != "" && tb_Education.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Employee_Details Set Employee_ID = @Emp_ID, Employee_Name = @Emp_Name, Address = @Add, Education = @Education, Contact_No1 = @Con_No1, Contact_No2 = @Con_No2, Experience = @Exp, Joining_Date =  @DOB where Salary = @Sal";

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

                MessageBox.Show("Employee Details Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void frm_Update_Employee_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        }
    }

