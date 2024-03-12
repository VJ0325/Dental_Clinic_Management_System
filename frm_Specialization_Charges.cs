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
    public partial class frm_Specialization_Charges : Form
    {
        public frm_Specialization_Charges()
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

        private void tb_Specialization_Charges_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_Specialization.Text != "" && tb_Specialization_Charges.Text != "")
            {
                dgv_Specialization_Details.Rows.Add(tb_Specialization.Text, tb_Specialization_Charges.Text);
            }
            else
            {
                MessageBox.Show("First Add Specialization Details");
            }

            tb_Specialization.Clear();
            tb_Specialization_Charges.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Doctor_ID.Text != "" && tb_Doctor_Name.Text != "")
            {
                if (dgv_Specialization_Details.Rows.Count > 0)
                {
                    for (int i = 0; i < dgv_Specialization_Details.Rows.Count; i++)
                    {
                        SqlCommand Cmd = new SqlCommand();

                        Cmd.Connection = Con;
                        Cmd.CommandText = "Insert Into Specialization_Details values(@DID, @S, @S_Charges)";

                        Cmd.Parameters.Add("DID", SqlDbType.Int).Value = tb_Doctor_ID.Text;
                        Cmd.Parameters.Add("S", SqlDbType.NVarChar).Value = dgv_Specialization_Details.Rows[i].Cells[0].Value;
                        Cmd.Parameters.Add("S_Charges", SqlDbType.Money).Value = dgv_Specialization_Details.Rows[i].Cells[1].Value;

                        Cmd.ExecuteNonQuery();
                        Cmd.Dispose();
                    }

                }
                MessageBox.Show("Specialization And Charges Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
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

        private void frm_Specialization_Charges_Load(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select * From Doctor_Details Where Doctor_ID = @DID ";

            Cmd.Parameters.Add("DID", SqlDbType.Int).Value = Common_Const.DrID;

            SqlDataReader obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Doctor_ID.Text = Convert.ToString(Common_Const.DrID);
                tb_Doctor_Name.Text = obj.GetString(obj.GetOrdinal("Doctor_Name"));
            }


            tb_Doctor_ID.Enabled = false;

            Con_Close();
        }

       

       
    }
}
