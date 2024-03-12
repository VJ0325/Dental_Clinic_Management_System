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
    public partial class frm_Prescription : Form
    {
        public frm_Prescription()
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

        private void tb_Patient_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_dr_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Consule_Fees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Treat_Charges_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_G_Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Patient_Name.Clear();
            tb_Patient_ID.Clear();
            tb_Jaw_Teeth_No.Clear();
            tb_dr_Name.Clear();
            
            cb_Braces.Checked = false;
            cb_Bridges_and_Impletns.Checked = false;
            cb_Crowns_and_Caps.Checked = false;
            cb_Dentures.Checked = false;
            cb_Filling_and_Repairs.Checked = false;
            cb_Gun_Surgery.Checked = false;

            tb_Treat_Charges.Text = "0";
            tb_G_Total.Text = "0";
            tb_Consule_Fees.Clear();
            dtp_Date.ResetText();
            dgv_Medication.DataSource = "";
        }

        private void frm_Prescription_Load(object sender, EventArgs e)
        {
            Con_Open();

            tb_Patient_ID.Text = Convert.ToString(Common_Const.PID);

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select * From Patient_Details Where Patient_ID = '" + tb_Patient_ID.Text + "' ";

            SqlDataReader obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_dr_Name.Text = obj.GetString(obj.GetOrdinal("Doctor_Name"));
                tb_Consule_Fees.Text = (obj["Charges"].ToString());
                tb_G_Total.Text = (obj["Charges"].ToString());
                dtp_Date.Text = (obj["Date"].ToString());
                tb_Patient_Name.Text = (obj["First_Name"].ToString()) + " " + (obj["Last_Name"].ToString());
            }

            Con_Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_Medication.Text != "" && tb_Qty.Text != "" && tb_Time.Text != "")
            {
                dgv_Medication.Rows.Add(tb_Medication.Text, tb_Qty.Text, tb_Time.Text);
            }
            else
            {
                MessageBox.Show("First Add Some Medicine Details");
            }

            tb_Qty.Clear();
            tb_Medication.Clear();
            tb_Time.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            string Treatment = "";

            if (cb_Braces.Checked)
            {
                Treatment = cb_Braces.Text + " ";
            }

            if (cb_Bridges_and_Impletns.Checked)
            {
                Treatment += cb_Bridges_and_Impletns.Text + " ";
            }

            if (cb_Crowns_and_Caps.Checked)
            {
                Treatment += cb_Crowns_and_Caps.Text + " ";
            }

            if (cb_Dentures.Checked)
            {
                Treatment += cb_Dentures.Text + " ";
            }

            if (cb_Filling_and_Repairs.Checked)
            {
                Treatment += cb_Filling_and_Repairs.Text + " ";
            }

            if (cb_Gun_Surgery.Checked)
            {
                Treatment += cb_Gun_Surgery.Text + " ";
            }

            if (tb_Patient_Name.Text != "" && dtp_Date.Text != "" && tb_Patient_ID.Text != "" && tb_dr_Name.Text != "" && tb_Consule_Fees.Text != "" && tb_Jaw_Teeth_No.Text != ""
                && tb_Treat_Charges.Text != "" && Treatment != "" && tb_G_Total.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Treatment_Details values ( @PID, @P_Name, @Date, @Dr_Name, @C_Fee, @T_No, @Treat, @T_Charges, @G_Total)";

                Cmd.Parameters.Add("PID", SqlDbType.Int).Value = tb_Patient_ID.Text;
                Cmd.Parameters.Add("P_Name", SqlDbType.VarChar).Value = tb_Patient_Name.Text;
                Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("Dr_Name", SqlDbType.VarChar).Value = tb_dr_Name.Text;
                Cmd.Parameters.Add("C_Fee", SqlDbType.Money).Value = tb_Consule_Fees.Text;
                Cmd.Parameters.Add("T_No", SqlDbType.NVarChar).Value = tb_Jaw_Teeth_No.Text;
                Cmd.Parameters.Add("Treat", SqlDbType.VarChar).Value = Treatment;
                Cmd.Parameters.Add("T_Charges", SqlDbType.Money).Value = tb_Treat_Charges.Text;
                Cmd.Parameters.Add("G_total", SqlDbType.Money).Value = tb_G_Total.Text;

                Cmd.ExecuteNonQuery();

                Cmd.Dispose();

                if (dgv_Medication.Rows.Count > 0)
                {
                    for (int i = 0; i < dgv_Medication.Rows.Count; i++)
                    {
                        SqlCommand Cmd1 = new SqlCommand();

                        Cmd1.Connection = Con;

                        Cmd1.CommandText = "Insert Into Medication_Quantity_Details values (@PTID, @Medication, @Qty, @Time)";

                        Cmd1.Parameters.Add("PTID", SqlDbType.Int).Value = tb_Patient_ID.Text;
                        Cmd1.Parameters.Add("Medication", SqlDbType.VarChar).Value = dgv_Medication.Rows[i].Cells[0].Value;
                        Cmd1.Parameters.Add("Qty", SqlDbType.Int).Value = dgv_Medication.Rows[i].Cells[1].Value;
                        Cmd1.Parameters.Add("Time", SqlDbType.NVarChar).Value = dgv_Medication.Rows[i].Cells[2].Value;

                        Cmd1.ExecuteNonQuery();
                        Cmd1.Dispose();
                    }
                }
                MessageBox.Show("Treatment Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fill Complete Details", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Clear_Controls();

            Con_Close();
        }

        private void tb_Treat_Charges_TextChanged(object sender, EventArgs e)
        {
            double Amount = 0;

            if (tb_Treat_Charges.Text != "" && Convert.ToInt32(tb_Treat_Charges.Text) > 0)
            {
                Amount = Convert.ToDouble(tb_Treat_Charges.Text) + Convert.ToDouble(tb_Consule_Fees.Text);
                tb_G_Total.Text = Convert.ToString(Amount);
            }
            else
            {
                tb_G_Total.Text = tb_Consule_Fees.Text;
            }
        }

        private void cb_Braces_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Braces.Checked)
            {
                if (tb_Treat_Charges.Text != null)
                {

                    tb_Treat_Charges.Text = (Convert.ToInt32(tb_Treat_Charges.Text) + 200).ToString();
                }
            }
            else
            {
                tb_Treat_Charges.Text = (Convert.ToInt32(tb_Treat_Charges.Text) - 200).ToString();
            }
        }

        private void cb_Crowns_and_Caps_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Crowns_and_Caps.Checked)
            {
                if (tb_Treat_Charges.Text != null)
                {
                    tb_Treat_Charges.Text = (Convert.ToInt32(tb_Treat_Charges.Text) + 100).ToString();
                }
            }
            else
            {
                tb_Treat_Charges.Text = (Convert.ToInt32(tb_Treat_Charges.Text) - 100).ToString();
            }
        }


        private void cb_Dentures_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Dentures.Checked)
            {
                if (tb_Treat_Charges.Text != null)
                {

                    tb_Treat_Charges.Text = (Convert.ToInt32(tb_Treat_Charges.Text) + 400).ToString();
                }
                
            }
            else
            {
                tb_Treat_Charges.Text = (Convert.ToInt32(tb_Treat_Charges.Text) - 400).ToString();
            }
        }

        private void cb_Gun_Surgery_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Gun_Surgery.Checked)
            {
                if (tb_Treat_Charges.Text != null)
                {

                    tb_Treat_Charges.Text = (Convert.ToInt32(tb_Treat_Charges.Text) + 700).ToString();
                }
                
            }
            else
            {
                tb_Treat_Charges.Text = (Convert.ToInt32(tb_Treat_Charges.Text) - 700).ToString();
            }
        }

        private void cb_Filling_and_Repairs_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Filling_and_Repairs.Checked)
            {
                if (tb_Treat_Charges.Text != null)
                {

                    tb_Treat_Charges.Text = (Convert.ToInt32(tb_Treat_Charges.Text) + 800).ToString();
                }
                
            }
            else
            {
                tb_Treat_Charges.Text = (Convert.ToInt32(tb_Treat_Charges.Text) - 800).ToString();
            }
        }

        private void cb_Bridges_and_Impletns_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Bridges_and_Impletns.Checked)
            {
                if (tb_Treat_Charges.Text != null)
                {
                    tb_Treat_Charges.Text = (Convert.ToInt32(tb_Treat_Charges.Text) + 500).ToString();
                }
                
            }
            else
            {
                tb_Treat_Charges.Text = (Convert.ToInt32(tb_Treat_Charges.Text) - 500).ToString();
            }
        }  
    }
}