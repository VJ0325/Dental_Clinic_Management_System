using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dental_Clinic_Management_System
{
    public partial class frm_View_Doctor_Details : Form
    {
        public frm_View_Doctor_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Doctor_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dental_Clinic_Management_System_DBDataSet.Doctor_Details' table. You can move, or remove it, as needed.
            this.doctor_DetailsTableAdapter.Fill(this.dental_Clinic_Management_System_DBDataSet.Doctor_Details);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btn_Other_Details_Click(object sender, EventArgs e)
        {
            frm_View_Specialization_Charges obj = new frm_View_Specialization_Charges();
            
            obj.Show();
        }
    }
}
