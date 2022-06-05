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
    public partial class UC_CourseRequestsOfStudent : UserControl
    {
        Student student;
        EfCourseRequestDal efCourseRequestDal = new EfCourseRequestDal();
        public UC_CourseRequestsOfStudent(Student student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void GetAllCourseRequests()
        {
            CourseRequestManager courseRequestManager = new CourseRequestManager(efCourseRequestDal);
            dataGridView_courseRequests.DataSource = courseRequestManager.GetCourseRequestByStudentId(student.Id);
        }


        private void UC_CourseRequestsOfStudent_Load(object sender, EventArgs e)
        {
            GetAllCourseRequests();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                CourseRequestManager courseRequestManager = new CourseRequestManager(efCourseRequestDal);
                CourseRequest courseRequest = new CourseRequest();
                courseRequest.CourseRequestTitle = textBox_title.Text.Trim();
                courseRequest.CourseRequestDescription = richTextBox_descripton.Text.Trim();
                courseRequest.StudentId = student.Id;
                courseRequestManager.Insert(courseRequest);
                MessageBox.Show("Saved Successfully");
                GetAllCourseRequests();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                CourseRequestManager courseRequestManager = new CourseRequestManager(efCourseRequestDal);
                int ID = Convert.ToInt32(textBox_id.Text.Trim());
                courseRequestManager.Delete(ID);
                MessageBox.Show("Deleted Successfully");
                GetAllCourseRequests();
                ClearAreas();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView_courseRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_id.Text = dataGridView_courseRequests.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                textBox_title.Text = dataGridView_courseRequests.Rows[e.RowIndex].Cells["CourseRequestTitle"].Value.ToString();
                richTextBox_descripton.Text = dataGridView_courseRequests.Rows[e.RowIndex].Cells["CourseRequestDescription"].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Don't Click Header of the Table");
            }
        }

        private void ClearAreas()
        {
            textBox_id.Text = "";
            textBox_title.Text = "";
            richTextBox_descripton.Text = "";
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            ClearAreas();
        }
    }
}
