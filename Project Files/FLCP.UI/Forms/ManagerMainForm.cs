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
    public partial class ManagerMainForm : Form
    {
        UC_Classroom_Course uC_Classroom_Course;
        UC_CourseRegistration uC_CourseRegistration;
        UC_Language uC_Language;
        UC_Lecturer uC_Lecturer;
        UC_PaymentOperation uC_PaymentOperation;
        UC_Region_City_Branch uC_Region_City_Branch;
        UC_Students uC_Students;
        UC_WorkingDay uC_WorkingDay;
        UC_CourseRequest uC_CourseRequest;
        
        public ManagerMainForm()
        {
            uC_Classroom_Course = new UC_Classroom_Course();
            uC_CourseRegistration = new UC_CourseRegistration();
            uC_Language = new UC_Language();
            uC_Lecturer = new UC_Lecturer();
            uC_PaymentOperation = new UC_PaymentOperation();
            uC_Region_City_Branch = new UC_Region_City_Branch();
            uC_Students = new UC_Students();
            uC_WorkingDay = new UC_WorkingDay();
            uC_CourseRequest = new UC_CourseRequest();

            InitializeComponent();

            Controls.Add(uC_Classroom_Course);
            Controls.Add(uC_CourseRegistration);
            Controls.Add(uC_Language);
            Controls.Add(uC_Lecturer);
            Controls.Add(uC_PaymentOperation);
            Controls.Add(uC_Region_City_Branch);
            Controls.Add(uC_Students);
            Controls.Add(uC_WorkingDay);
            Controls.Add(uC_CourseRequest);

            uC_Classroom_Course.Location = panel_USER_CONTROL_AREA.Location;
            uC_CourseRegistration.Location = panel_USER_CONTROL_AREA.Location;
            uC_Language.Location = panel_USER_CONTROL_AREA.Location;
            uC_Lecturer.Location = panel_USER_CONTROL_AREA.Location;
            uC_PaymentOperation.Location = panel_USER_CONTROL_AREA.Location;
            uC_Region_City_Branch.Location = panel_USER_CONTROL_AREA.Location;
            uC_Students.Location = panel_USER_CONTROL_AREA.Location;
            uC_WorkingDay.Location = panel_USER_CONTROL_AREA.Location;
            uC_CourseRequest.Location = panel_USER_CONTROL_AREA.Location;

        }

        private void MovePanel(Control Btn)
        {
            panel_slide.Height = Btn.Height;
            panel_slide.Top = Btn.Top;
        }

        private void ManagerMainForm_Load(object sender, EventArgs e)
        {
            uC_Region_City_Branch.Show();
            uC_Region_City_Branch.BringToFront();
        }

        private void button_City_Branch_Region_Click(object sender, EventArgs e)
        {
            MovePanel(button_City_Branch_Region);
            uC_Region_City_Branch.Show();
            uC_Region_City_Branch.BringToFront();

            uC_Classroom_Course.Hide();
            uC_CourseRegistration.Hide();
            uC_Language.Hide();
            uC_Lecturer.Hide();
            uC_PaymentOperation.Hide();
            uC_Students.Hide();
            uC_WorkingDay.Hide();
            uC_CourseRequest.Hide();
        }

        private void button_Classroom_Course_Click(object sender, EventArgs e)
        {
            MovePanel(button_Classroom_Course);
            uC_Classroom_Course.Show();
            uC_Classroom_Course.BringToFront();

            uC_Region_City_Branch.Hide();
            uC_CourseRegistration.Hide();
            uC_Language.Hide();
            uC_Lecturer.Hide();
            uC_PaymentOperation.Hide();
            uC_Students.Hide();
            uC_WorkingDay.Hide();
            uC_CourseRequest.Hide();

        }

        private void button_CourseRegistration_Click(object sender, EventArgs e)
        {
            MovePanel(button_CourseRegistration);
            uC_CourseRegistration.Show();
            uC_CourseRegistration.BringToFront();

            uC_Region_City_Branch.Hide();
            uC_Classroom_Course.Hide();
            uC_Language.Hide();
            uC_Lecturer.Hide();
            uC_PaymentOperation.Hide();
            uC_Students.Hide();
            uC_WorkingDay.Hide();
            uC_CourseRequest.Hide();
        }

        private void button_Language_Click(object sender, EventArgs e)
        {
            MovePanel(button_Language);
            uC_Language.Show();
            uC_Language.BringToFront();

            uC_Region_City_Branch.Hide();
            uC_Classroom_Course.Hide();
            uC_CourseRegistration.Hide();
            uC_Lecturer.Hide();
            uC_PaymentOperation.Hide();
            uC_Students.Hide();
            uC_WorkingDay.Hide();
            uC_CourseRequest.Hide();
        }

        private void button_Lecturer_Click(object sender, EventArgs e)
        {
            MovePanel(button_Lecturer);
            uC_Lecturer.Show();
            uC_Lecturer.BringToFront();

            uC_Region_City_Branch.Hide();
            uC_Classroom_Course.Hide();
            uC_CourseRegistration.Hide();
            uC_Language.Hide();
            uC_PaymentOperation.Hide();
            uC_Students.Hide();
            uC_WorkingDay.Hide();
            uC_CourseRequest.Hide();
        }

        private void button_WorkingDay_Click(object sender, EventArgs e)
        {
            MovePanel(button_WorkingDay);
            uC_WorkingDay.Show();
            uC_WorkingDay.BringToFront();

            uC_Region_City_Branch.Hide();
            uC_Classroom_Course.Hide();
            uC_CourseRegistration.Hide();
            uC_Language.Hide();
            uC_PaymentOperation.Hide();
            uC_Students.Hide();
            uC_Lecturer.Hide();
            uC_CourseRequest.Hide();
        }

        private void button_Student_Click(object sender, EventArgs e)
        {
            MovePanel(button_Student);
            uC_Students.Show();
            uC_Students.BringToFront();

            uC_Region_City_Branch.Hide();
            uC_Classroom_Course.Hide();
            uC_CourseRegistration.Hide();
            uC_Language.Hide();
            uC_PaymentOperation.Hide();
            uC_WorkingDay.Hide();
            uC_Lecturer.Hide();
            uC_CourseRequest.Hide();
        }

        private void button_Payment_Click(object sender, EventArgs e)
        {
            MovePanel(button_Payment);
            uC_PaymentOperation.Show();
            uC_PaymentOperation.BringToFront();

            uC_Region_City_Branch.Hide();
            uC_Classroom_Course.Hide();
            uC_CourseRegistration.Hide();
            uC_Language.Hide();
            uC_Students.Hide();
            uC_WorkingDay.Hide();
            uC_Lecturer.Hide();
            uC_CourseRequest.Hide();
        }

        private void button_CourseRequest_Click(object sender, EventArgs e)
        {
            MovePanel(button_CourseRequest);
            uC_CourseRequest.Show();
            uC_CourseRequest.BringToFront();

            uC_Region_City_Branch.Hide();
            uC_Classroom_Course.Hide();
            uC_CourseRegistration.Hide();
            uC_Language.Hide();
            uC_Students.Hide();
            uC_WorkingDay.Hide();
            uC_Lecturer.Hide();
            uC_PaymentOperation.Hide();
        }
    }
}
