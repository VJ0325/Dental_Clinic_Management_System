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
    public partial class frm_Attend_Patient_Details : Form
    {
        public frm_Attend_Patient_Details()
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

        private void tb_Charges_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Patient_ID.Text = "";
            tb_Address.Text = "";
            tb_Doctor_Name.Text = "";
            tb_First_Name.Text = "";
            tb_Last_Name.Text = "";
          
            tb_Charges.Text = "";
            tb_Contact_No_1.Text = "";
            tb_Contact_No_2.Text = "";
            gb_Blood_Pressure.Text = "";
            gb_Gender.Text = "";
            cmb_Blood_Group.Text = "";
            dtp_Date.ResetText();
            dtp_Appoint_Date.ResetText();          
            rb_Female.Checked = false;
            rb_Male.Checked = false;
            rb_High.Checked = false;
            rb_Normal.Checked = false;
            rb_Low.Checked = false;

            tb_Patient_ID.Focus();
            tb_Patient_ID.Enabled = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            string BP = ""; 
            string Gender = "";
            bool bRet = false;

            if (tb_Patient_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Select * From Patient_Details Where Patient_ID = '" + tb_Patient_ID.Text + "' ";

                SqlDataReader obj = Cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Doctor_Name.Text = obj.GetString(obj.GetOrdinal("Doctor_Name"));
                    tb_Contact_No_1.Text = (obj["Contact_No1"].ToString());
                    tb_Contact_No_2.Text = (obj["Contact_No2"].ToString());
                    tb_Address.Text = obj.GetString(obj.GetOrdinal("Address"));
                    tb_Charges.Text = (obj["Charges"].ToString());
                    dtp_Date.Text = (obj["Date"].ToString());
                    tb_First_Name.Text = (obj["First_Name"].ToString());
                    tb_Last_Name.Text = (obj["Last_Name"].ToString());
                    dtp_DOB.Text = (obj["DOB"].ToString());
                    cmb_Blood_Group.Text = (obj["Blood_Group"].ToString());
                    BP = obj.GetString(obj.GetOrdinal("Blood_Pressure"));
                    Gender = obj.GetString(obj.GetOrdinal("Gender"));
                    
                    bRet = Gender.Contains(rb_Male.Text);
                    if (bRet)
                    {
                        rb_Male.Checked = true;
                    }

                    bRet = Gender.Contains(rb_Female.Text);
                    if (bRet)
                    {
                        rb_Female.Checked = true;
                    }

                    bRet = BP.Contains(rb_Low.Text);
                    if (bRet)
                    {
                        rb_Low.Checked = true;
                    }

                    bRet = BP.Contains(rb_Normal.Text);
                    if (bRet)
                    {
                        rb_Normal.Checked = true;
                    }

                    bRet = BP.Contains(rb_High.Text);
                    if (bRet)
                    {
                        rb_High.Checked = true;
                    }

                    tb_Address.Enabled = false;
                    dtp_DOB.Enabled = false;
                    tb_Charges.Enabled = false;
                    tb_Contact_No_1.Enabled = false;
                    tb_Contact_No_2.Enabled = false;
                    tb_Doctor_Name.Enabled = false;
                    tb_First_Name.Enabled = false;
                    tb_Last_Name.Enabled = false;
                    cmb_Blood_Group.Enabled = false;
                    gb_Blood_Pressure.Enabled = false;
                    gb_Gender.Enabled = false;
                    dtp_Date.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
                tb_Patient_ID.Enabled = true;
                Con_Close();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

                Common_Const.PID = Convert.ToInt32(tb_Patient_ID.Text);
                this.Hide();
                Clear_Controls();

                frm_Prescription Obj = new frm_Prescription();
                Obj.Show();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        } 
    }
}