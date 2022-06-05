using FLCP.Entity.Model;
using FLCP.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLCP.UI.Forms
{
    public partial class StudentMainForm : Form
    {
        Student student;
        UC_CoursesOfStudent SC;
        UC_PaymentsOfStudent PS;
        UC_CourseRequestsOfStudent CRS;
        public StudentMainForm(Student student)
        {
            this.student = student;
            SC = new UC_CoursesOfStudent(student);
            PS = new UC_PaymentsOfStudent(student);
            CRS = new UC_CourseRequestsOfStudent(student);
            InitializeComponent();
            

            Controls.Add(SC);
            Controls.Add(PS);
            Controls.Add(CRS);

            SC.Location = panel_UserControlArea.Location;
            PS.Location = panel_UserControlArea.Location;
            CRS.Location = panel_UserControlArea.Location;
        }


        private void MovePanel(Control Btn)
        {
            panel_slide.Height = Btn.Height;
            panel_slide.Top = Btn.Top;
        }


        private void button_CourseRequests_Click(object sender, EventArgs e)
        {
            MovePanel(button_CourseRequests);
            CRS.Show();
            CRS.BringToFront();
            PS.Hide();
            SC.Hide();
        }

        private void button_payments_Click(object sender, EventArgs e)
        {
            MovePanel(button_payments);
            PS.Show();
            PS.BringToFront();
            CRS.Hide();
            SC.Hide();
        }

        private void button_Courses_Click(object sender, EventArgs e)
        {
            MovePanel(button_Courses);
            SC.Show();
            SC.BringToFront();

            CRS.Hide();
            PS.Hide();
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            CRS.Show();
            CRS.BringToFront();
        }
    }
}
