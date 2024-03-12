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
    public partial class frm_View_Specialization_Charges : Form
    {
        public frm_View_Specialization_Charges()
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

        void Bind_Grid(string Query)
        {
            Con_Open();

            dgv_Specialization.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_Specialization.DataSource = dt;

            Con_Close();
        }

        private void frm_View_Specialization_Charges_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dental_Clinic_Management_System_DBDataSet4.Specialization_Details' table. You can move, or remove it, as needed.
            this.specialization_DetailsTableAdapter.Fill(this.dental_Clinic_Management_System_DBDataSet4.Specialization_Details);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Bind_Grid("Select * from Specialization_Details where Doctor_ID = " + tb_Doctor_ID.Text + "");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tb_Doctor_ID_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
