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
    public partial class frm_View_Lab_Details : Form
    {
        public frm_View_Lab_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Lab_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dental_Clinic_Management_System_DBDataSet2.Lab_Details' table. You can move, or remove it, as needed.
            this.lab_DetailsTableAdapter.Fill(this.dental_Clinic_Management_System_DBDataSet2.Lab_Details);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
