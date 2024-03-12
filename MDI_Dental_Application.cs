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
    public partial class MDI_Dental_Application : Form
    {
        //private int ImageNumber = 1;
        public MDI_Dental_Application()
        {
            InitializeComponent();
        }

        int Count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           if (Count < 7)
            {
                pictureBox1.Image = imageList1.Images[Count];
                Count++;
            }
            else
            { 
                Count = 0;
            }
        }

        private void Slider()
        {
            //if (ImageNumber == 7)
            ////{
            //    ImageNumber = 1;
            //}
            //pictureBox1.ImageLocation = string.Format(@"D:\Project\Dental_Clinic_Management_System\Dental_Clinic_Management_System\bin\Debug\Images", ImageNumber);
            //ImageNumber++;
        }
     
        private void addDoctorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            frm_Add_Doctor_Details obj = new frm_Add_Doctor_Details();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void updateDoctorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            frm_Update_Doctor_Details obj = new frm_Update_Doctor_Details();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void searchDoctorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            frm_Search_Doctor_Details obj = new frm_Search_Doctor_Details();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void viewDoctorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            frm_View_Doctor_Details obj = new frm_View_Doctor_Details();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void addEmloyeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            frm_Add_Employee_Details obj = new frm_Add_Employee_Details();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            frm_Update_Employee_Details obj = new frm_Update_Employee_Details();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void searchEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            frm_Search_Employee_Details obj = new frm_Search_Employee_Details();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void viewEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            frm_View_Employee_Details obj = new frm_View_Employee_Details();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }
       
        private void attendAppointmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            frm_Attend_Patient_Details obj = new frm_Attend_Patient_Details();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void addLabDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            frm_Add_Lab_Details obj = new frm_Add_Lab_Details();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }
 
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = new DialogResult();

            Res = MessageBox.Show("Are you Sure??", "Loggin Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Res == DialogResult.Yes)
            {
                Common_Const.URole = 0;
                Common_Const.Uname = "";

                reportToolStripMenuItem.Visible = false;

                this.Close();
            }
        }

        private void MDI_Dental_Application_Load(object sender, EventArgs e)
        {           
            lbl_Logged_In_User_Name.Text = "Welcome" + " " + Common_Const.Uname;

            if (Common_Const.URole == 1)
            {
                patientToolStripMenuItem.Visible = true;
                doctorToolStripMenuItem.Visible = true;
                employeeToolStripMenuItem.Visible = true;
                labToolStripMenuItem.Visible = true;
                userManagementToolStripMenuItem.Visible = true;
                reportToolStripMenuItem.Visible = true;
            }

            else if (Common_Const.URole == 2)
            {
                patientToolStripMenuItem.Visible = true;
                doctorToolStripMenuItem.Visible = true;
                employeeToolStripMenuItem.Visible = true;
                labToolStripMenuItem.Visible = true;
                userManagementToolStripMenuItem.Visible = true;
                reportToolStripMenuItem.Visible = false;
            }

            else if (Common_Const.URole == 3)
            {
                patientToolStripMenuItem.Visible = true;
                doctorToolStripMenuItem.Visible = true;
                employeeToolStripMenuItem.Visible = true;
                labToolStripMenuItem.Visible = true;
                userManagementToolStripMenuItem.Visible = false;
                reportToolStripMenuItem.Visible = false;
            }
            else 
            {
                patientToolStripMenuItem.Visible = true;
                doctorToolStripMenuItem.Visible = true;
                employeeToolStripMenuItem.Visible = true;
                labToolStripMenuItem.Visible = false;
                userManagementToolStripMenuItem.Visible = false;
                reportToolStripMenuItem.Visible = false;
            }
            
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();

            frm_Add_Patient obj = new frm_Add_Patient();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            pictureBox1.Visible = false;
            
            obj.Show();
        }

        private void searchLabTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();

            frm_Search_Lab_Test obj = new frm_Search_Lab_Test();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void viewLabDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();

            frm_View_Lab_Details obj = new frm_View_Lab_Details();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();

            frm_User_Management obj = new frm_User_Management();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void patientReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();

            Patient_View obj = new Patient_View();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void doctorReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();

            Crystal_View obj = new Crystal_View();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void labReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();

            Lab_Details_Report obj = new Lab_Details_Report();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void treatmentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();

            Treatment_Report obj = new Treatment_Report();
            
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }

        private void medicationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();

            Medication_Crystal_Report obj = new Medication_Crystal_Report();

            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void lbl_Logged_In_User_Name_Click(object sender, EventArgs e)
        {

        }


    }
}
