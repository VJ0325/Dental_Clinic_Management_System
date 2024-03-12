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
    public partial class Lab_Details_Report : Form
    {

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

        DataSet3 dt;
        SqlDataAdapter adpt;

        public Lab_Details_Report()
        {
            InitializeComponent();
        }

        private void Lab_Details_Report_Load(object sender, EventArgs e)
        {
            Con_Open();
            adpt = new SqlDataAdapter("Select * from Lab_Details", Con);
            dt = new DataSet3();
            adpt.Fill(dt);

            Con_Close();
        }
    }
}
