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
    public partial class Crystal_View : Form
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

        DataSet1 dt;
        SqlDataAdapter adpt;
        public Crystal_View()
        {
            InitializeComponent();
        }

        private void Crystal_View_Load(object sender, EventArgs e)
        {
            Con_Open();
            adpt = new SqlDataAdapter("Select * from Doctor_Details", Con);
            dt = new DataSet1();
            adpt.Fill(dt);

            Con_Close();
            
        }

    }
}
