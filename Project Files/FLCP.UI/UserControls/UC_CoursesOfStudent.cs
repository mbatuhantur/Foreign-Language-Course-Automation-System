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
    public partial class UC_CoursesOfStudent : UserControl
    {
        Student student;
        EfCourseRegitrationDal efCourseRegitrationDal = new EfCourseRegitrationDal();
        public UC_CoursesOfStudent(Student student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void UC_CoursesOfStudent_Load(object sender, EventArgs e)
        {
            CourseRegistrationManager courseRegistrationManager = new CourseRegistrationManager(efCourseRegitrationDal);
            dataGridView_courses.DataSource = courseRegistrationManager.GetCoursesByStudentId(student.Id);
        }
    }
}
