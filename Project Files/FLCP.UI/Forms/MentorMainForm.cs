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
    public partial class MentorMainForm : Form
    {
        Mentor mentor;
        UC_CoursesOfMentor UCCM;
        UC_WorkingDaysOfMentor UMWD;
        public MentorMainForm(Mentor mentor)
        {
            this.mentor = mentor;
            UCCM = new UC_CoursesOfMentor(mentor);
            UMWD = new UC_WorkingDaysOfMentor(mentor);
            InitializeComponent();
            Controls.Add(UCCM);
            Controls.Add(UMWD);
            UCCM.Location = panel_user_control_area.Location;
            UMWD.Location = panel_user_control_area.Location;
        }

        private void MentorMainForm_Load(object sender, EventArgs e)
        {
            MovePanel(button_courses);
            UCCM.Show();
            UCCM.BringToFront();
        }

        private void MovePanel(Control Btn)
        {
            panel_slide.Height = Btn.Height;
            panel_slide.Top = Btn.Top;
        }

        private void button_courses_Click(object sender, EventArgs e)
        {
            MovePanel(button_courses);
            UCCM.Show();
            UCCM.BringToFront();

            UMWD.Hide();
        }

        private void button_workingDays_Click(object sender, EventArgs e)
        {
            MovePanel(button_workingDays);
            UMWD.Show();
            UMWD.BringToFront();

            UCCM.Hide();
        }
    }
}
