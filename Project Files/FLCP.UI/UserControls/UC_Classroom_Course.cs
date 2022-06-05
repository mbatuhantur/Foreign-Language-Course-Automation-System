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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace FLCP.UI.UserControls
{
    public partial class UC_Classroom_Course : UserControl
    {
        EfBranchDal efBranchDal = new EfBranchDal();
        EfMentorDal efMentorDal = new EfMentorDal();
        EfLanguageDal efLanguageDal = new EfLanguageDal();
        EfClassroomDal efClassroomDal = new EfClassroomDal();
        EfCourseDal efCourseDal = new EfCourseDal();
        public UC_Classroom_Course()
        {
            InitializeComponent();
        }

        private void FillComboboxClassrooms()
        {
            ClassroomManager classroomManager = new ClassroomManager(efClassroomDal);
            comboBox_Classroom.DataSource = classroomManager.GetAllClassrooms();
        }

        private void FillComboboxLanguages()
        {
            LanguageManager languageManager = new LanguageManager(efLanguageDal);
            comboBox_Langauge.DataSource = languageManager.GetAllLanguages();
        }

        private void FillComboboxMentors()
        {
            MentorManager mentorManager = new MentorManager(efMentorDal);
            comboBox_Lecturer.DataSource = mentorManager.GetAllMentors();
        }

        private void FillComboboxBrancshes()
        {
            BranchManager branchManager = new BranchManager(efBranchDal);
            comboBox_BranchId.DataSource = branchManager.GetAllBranches();

        }

        
        private void GetAllClassrooms()
        {
            ClassroomManager classroomManager = new ClassroomManager(efClassroomDal);
            dataGridView_classroom.DataSource = classroomManager.GetAllClassrooms();
        }

        private void GetAllCourses()
        {
            CourseManager courseManager = new CourseManager(efCourseDal);
            dataGridView_course.DataSource = courseManager.GetAll();
        }

        private void UC_Classroom_Course_Load(object sender, EventArgs e)
        {
           
            FillComboboxBrancshes();
            FillComboboxMentors();
            FillComboboxLanguages();
            FillComboboxClassrooms();
            GetAllCourses();
            GetAllClassrooms();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton_classroom.Checked == true)
                {
                    int ID = Convert.ToInt32(textBox_ClassroomId.Text.Trim());
                    ClassroomManager classroomManager = new ClassroomManager(efClassroomDal);
                    var updatedClassroom = classroomManager.GetById(ID);
                    updatedClassroom.ClassroomName = textBox_ClassroomName.Text.Trim();
                    updatedClassroom.BranchId = Convert.ToInt32(comboBox_BranchId.SelectedValue);
                    classroomManager.Update(updatedClassroom);
                    MessageBox.Show("Classroom Updated Successfully");
                    GetAllClassrooms();

                }

                else if (radioButton_course.Checked == true)
                {
                    int ID = Convert.ToInt32(textBox_CourseID.Text.Trim());
                    CourseManager courseManager = new CourseManager(efCourseDal);
                    var updatedCourse = courseManager.GetById(ID);
                    updatedCourse.CourseCode = textBox_CourseCode.Text.Trim();
                    updatedCourse.CourseCredit = Convert.ToInt32(textBox_CourseCredit.Text.Trim());
                    updatedCourse.MentorId = Convert.ToInt32(comboBox_Lecturer.SelectedValue);
                    updatedCourse.LanguageId = Convert.ToInt32(comboBox_Langauge.SelectedValue);
                    updatedCourse.ClassroomId = Convert.ToInt32(comboBox_Classroom.SelectedValue);
                    updatedCourse.CoursePrice = Convert.ToDecimal(textBox_price.Text.Trim());
                    courseManager.Update(updatedCourse);
                    MessageBox.Show("Course Updated Successfully");
                    GetAllCourses();
                }

                else
                {
                    MessageBox.Show("Please Click Radio Button");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton_classroom.Checked == true)
                {
                    ClassroomManager classroomManager = new ClassroomManager(efClassroomDal);
                    var classroom = new Classroom();
                    classroom.ClassroomName = textBox_ClassroomName.Text.Trim();
                    classroom.BranchId = Convert.ToInt32(comboBox_BranchId.SelectedValue);
                    classroomManager.Insert(classroom);
                    MessageBox.Show("Classroom Saved Successfully");
                    GetAllClassrooms();
                }

                else if (radioButton_course.Checked == true)
                {
                    CourseManager courseManager = new CourseManager(efCourseDal);
                    var course = new Course();
                    course.CourseCode = textBox_CourseCode.Text.Trim();
                    course.CourseCredit = Convert.ToInt32(textBox_CourseCredit.Text.Trim());
                    course.MentorId = Convert.ToInt32(comboBox_Lecturer.SelectedValue);
                    course.LanguageId = Convert.ToInt32(comboBox_Langauge.SelectedValue);
                    course.ClassroomId = Convert.ToInt32(comboBox_Classroom.SelectedValue);
                    course.CoursePrice = Convert.ToDecimal(textBox_price.Text.Trim());
                    courseManager.Insert(course);
                    GetAllCourses();
                    MessageBox.Show("Course Saved Successfully");
                }

                else
                {
                    MessageBox.Show("Please Click Radio Button");
                }
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
                if (radioButton_classroom.Checked == true)
                {
                    ClassroomManager classroomManager = new ClassroomManager(efClassroomDal);
                    int ID = Convert.ToInt32(textBox_ClassroomId.Text.Trim());
                    classroomManager.Delete(ID);
                    MessageBox.Show("Classroom Deleted Successfully");
                    GetAllClassrooms();
                }

                else if (radioButton_course.Checked == true)
                {
                    CourseManager courseManager = new CourseManager(efCourseDal);
                    int ID = Convert.ToInt32(textBox_CourseID.Text.Trim());
                    courseManager.Delete(ID);
                    MessageBox.Show("Course Deleted Successfully");
                    GetAllCourses();
                }

                else
                {
                    MessageBox.Show("Please Click Radio Button");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("You cannot delete operation");
            }
        }

        private void dataGridView_classroom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BranchManager branchManager = new BranchManager(efBranchDal);
                textBox_ClassroomId.Text = dataGridView_classroom.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                textBox_ClassroomName.Text = dataGridView_classroom.Rows[e.RowIndex].Cells["ClassroomName"].Value.ToString();
                
                foreach (var item in branchManager.GetAllBranches())
                {
                    if (item.Id == (int)dataGridView_classroom.Rows[e.RowIndex].Cells["BranchId"].Value)
                    {
                        comboBox_BranchId.Text = item.BranchName;

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView_course_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MentorManager mentorManager = new MentorManager(efMentorDal);
                LanguageManager languageManager = new LanguageManager(efLanguageDal);
                ClassroomManager classroomManager = new ClassroomManager(efClassroomDal);
                textBox_CourseID.Text = dataGridView_course.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                textBox_CourseCode.Text = dataGridView_course.Rows[e.RowIndex].Cells["CourseCode"].Value.ToString();
                textBox_CourseCredit.Text = dataGridView_course.Rows[e.RowIndex].Cells["CourseCredit"].Value.ToString();
                foreach (var item in mentorManager.GetAllMentors())
                {
                    if (item.Id == (int)dataGridView_course.Rows[e.RowIndex].Cells["MentorId"].Value)
                    {
                        comboBox_Lecturer.Text = item.Name;

                    }
                }

                foreach (var item in languageManager.GetAllLanguages())
                {
                    if (item.Id == (int)dataGridView_course.Rows[e.RowIndex].Cells["LanguageId"].Value)
                    {
                        comboBox_Langauge.Text = item.Name;

                    }
                }

                foreach (var item in classroomManager.GetAllClassrooms())
                {
                    if (item.Id == (int)dataGridView_course.Rows[e.RowIndex].Cells["ClassroomId"].Value)
                    {
                        comboBox_Classroom.Text = item.ClassroomName;

                    }
                }
                textBox_price.Text = dataGridView_course.Rows[e.RowIndex].Cells["CoursePrice"].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CreatePDF(DataGridView Dgw, string Filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(Dgw.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            //ADD HEADER
            foreach (DataGridViewColumn column in Dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfPTable.AddCell(cell);

            }

            //ADD datarow

            foreach (DataGridViewRow row in Dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }

            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = Filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfPTable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        private void button_createReportCourse_Click(object sender, EventArgs e)
        {
            CreatePDF(dataGridView_course, "Courses");
        }
    }
}
