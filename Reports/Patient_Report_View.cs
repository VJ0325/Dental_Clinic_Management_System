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
    public partial class Patient_View : Form
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

         DataSet4 dt;
         SqlDataAdapter adpt;

        public Patient_View()
        {
            InitializeComponent();
        }

        private void Patient_View_Load(object sender, EventArgs e)
        {
            Con_Open();
            adpt = new SqlDataAdapter("Select * from Patient_Details", Con);
            dt = new DataSet4();
            adpt.Fill(dt);

            Con_Close();
        }
    }
}
