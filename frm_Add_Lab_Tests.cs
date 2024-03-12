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
    public partial class frm_Add_Lab_Tests : Form
    {
        public frm_Add_Lab_Tests()
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
            tb_Lab_Name.Text = "";
            cmb_Dr_Name.Items.Clear();
            tb_T_Cases.Clear();
            tb_Charges.Clear();
            tb_Description.Clear();
            tb_Duration.Clear();
            cmb_Dr_Name.Text = "";
        }

        void Bind_Combobox()
        {
            Con_Open();

            cmb_Dr_Name.Items.Clear();

            SqlCommand Cmd = new SqlCommand();

            Cmd.CommandText ="Select Distinct(Doctor_Name) from Doctor_Details";

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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Con_Open();


            if (tb_Charges.Text != "" && tb_Lab_Name.Text != "" && tb_L_ID.Text != "" && tb_Duration.Text != "" && cmb_Dr_Name.Text != "" && tb_T_Cases.Text != "" )                

            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Lab_Test_Cases values (@L_ID, @L_Name, @T_Cases, @Charges, @Duration, @Dr, @Descri, @DOB)";

                Cmd.Parameters.Add("@L_ID", SqlDbType.Int).Value = tb_L_ID.Text;
                Cmd.Parameters.Add("@L_Name", SqlDbType.VarChar).Value = tb_Lab_Name.Text;
                Cmd.Parameters.Add("@T_Cases", SqlDbType.NVarChar).Value = tb_T_Cases.Text;                
                Cmd.Parameters.Add("@Charges", SqlDbType.Money).Value = tb_Charges.Text;
                Cmd.Parameters.Add("@Duration", SqlDbType.NVarChar).Value = tb_Duration.Text;
                Cmd.Parameters.Add("@Dr", SqlDbType.NVarChar).Value = cmb_Dr_Name.Text;                
                Cmd.Parameters.Add("@Descri", SqlDbType.NVarChar).Value = tb_Description.Text;
                Cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = dtp_Date.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Lab Tests Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fill Complete Details", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            Con_Close();
        }

        private void frm_Add_Lab_Tests_Load(object sender, EventArgs e)
        {
            Con_Open();

            tb_L_ID.Text = Convert.ToString(Common_Const.LabID);

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select * From Lab_Details Where Lab_ID = @LID ";

            Cmd.Parameters.Add("LID", SqlDbType.Int).Value = Common_Const.LabID;

            SqlDataReader obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Lab_Name.Text = obj.GetString(obj.GetOrdinal("Lab_Name"));
            }

            obj.Dispose();
            Cmd.Dispose();
            Bind_Combobox();

            Con_Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tb_Charges_KeyPress_1(object sender, KeyPressEventArgs e)
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

    }
}
