using FLCP.BusinessLogicLayer.Concrete;
using FLCP.DataAccess.Concrete;
using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLCP.UI.UserControls
{
    public partial class UC_CoursesOfMentor : UserControl
    {
        Mentor mentor;
        EfCourseDal efCourseDal = new EfCourseDal();
        public UC_CoursesOfMentor(Mentor mentor)
        {
            this.mentor = mentor;
            InitializeComponent();
        }

        private void GetCoursesByMentor()
        {
            CourseManager courseManager = new CourseManager(efCourseDal);
            dataGridView_courses.DataSource = courseManager.GetAllCoursesByMentor(mentor.Id);
        }

        private void UC_CoursesOfMentor_Load(object sender, EventArgs e)
        {
            GetCoursesByMentor();
        }
    }
}
