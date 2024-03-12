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
    public partial class frm_Add_Lab_Details : Form
    {
        public frm_Add_Lab_Details()
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

            Cmd.CommandText = "Select Count(*) from Lab_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.CommandText = "Select Max(Lab_ID) from Lab_Details";
                Cmd.Connection = Con;
                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
                Cnt += 1;
            }
            else
            {
                Cnt = 1;
            }

            Con_Close();

            return Cnt;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_controls();
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

        private void tb_L_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_O_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void frm_Add_Lab_Details_Load(object sender, EventArgs e)
        {
            tb_Lab_ID.Text = Auto_Incr().ToString();
            tb_Lab_ID.Enabled = false;
           
        }

        void Clear_controls()
        {
            tb_Lab_ID.Text = Convert.ToString(Auto_Incr());

            tb_Lab_Name.Text = "";
            tb_Address.Text = "";
            tb_L_No.Text = "";
            tb_Contact_No_1.Text = "";
            tb_Contact_No_2.Text = "";
            tb_O_Name.Text = "";

            tb_Lab_Name.Focus();
            tb_Lab_ID.Enabled = false;
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

            if (tb_L_No.Text == "")
            {
                tb_L_No.Text = "0";
            }

            if (tb_Lab_ID.Text != "" && tb_Lab_Name.Text != "" && tb_Address.Text != "" && tb_Contact_No_1.Text != "" && tb_Contact_No_2.Text != "" && tb_O_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Lab_Details values(@L_ID, @L_Name, @Add,  @Con_No1, @Con_No2, @Owner, @Licence_No)";

                Cmd.Parameters.Add("@L_ID", SqlDbType.Int).Value = tb_Lab_ID.Text;
                Cmd.Parameters.Add("@L_Name", SqlDbType.VarChar).Value = tb_Lab_Name.Text;
                Cmd.Parameters.Add("@Add", SqlDbType.NVarChar).Value = tb_Address.Text;                
                Cmd.Parameters.Add("@Con_No1", SqlDbType.Decimal).Value = tb_Contact_No_1.Text;
                Cmd.Parameters.Add("@Con_No2", SqlDbType.Decimal).Value = tb_Contact_No_2.Text;
                Cmd.Parameters.Add("@Owner", SqlDbType.VarChar).Value = tb_O_Name.Text;
                Cmd.Parameters.Add("@Licence_No", SqlDbType.Int).Value = tb_L_No.Text;

                Cmd.ExecuteNonQuery();
                
                MessageBox.Show("Lab Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Common_Const.LabID = Convert.ToInt32(tb_Lab_ID.Text);

                this.Hide();
                frm_Add_Lab_Tests Obj = new frm_Add_Lab_Tests();
                Obj.Show();

                Clear_controls();
                tb_Lab_ID.Enabled = false;
            }
            else
            {
                MessageBox.Show("Fill Complete Details", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                Con_Close();

            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        }
    }

