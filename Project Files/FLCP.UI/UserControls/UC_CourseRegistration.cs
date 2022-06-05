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
    public partial class UC_CourseRegistration : UserControl
    {
        EfCourseRegitrationDal efCourseRegitrationDal = new EfCourseRegitrationDal();
        EfCourseDal efCourseDal = new EfCourseDal();
        EfStudentDal efStudentDal = new EfStudentDal();
        public UC_CourseRegistration()
        {
            InitializeComponent();
        }

        private void GetAllStudents()
        {
            StudentManager studentManager = new StudentManager(efStudentDal);
            comboBox_StudentId.DataSource = studentManager.GetAllStudents();

        }

        private void GetAllCourses()
        {
            CourseManager courseManager = new CourseManager(efCourseDal);
            comboBox_CourseId.DataSource = courseManager.GetAllCourses();
        }

        private void GetAllCourseRegistrations()
        {
            CourseRegistrationManager courseRegistrationManager = new CourseRegistrationManager(efCourseRegitrationDal);
            dataGridView_courseRegistration.DataSource = courseRegistrationManager.GetAllCourseRegistration();
        }
        private void UC_CourseRegistration_Load(object sender, EventArgs e)
        {
            GetAllStudents();
            GetAllCourseRegistrations();
            GetAllCourses();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                CourseRegistrationManager courseRegistrationManager = new CourseRegistrationManager(efCourseRegitrationDal);
                var courseRegistration = new CourseRegistration();
                courseRegistration.CourseId = Convert.ToInt32(comboBox_CourseId.SelectedValue);
                courseRegistration.StudentId = Convert.ToInt32(comboBox_StudentId.SelectedValue);
                courseRegistration.Status = Convert.ToBoolean(comboBox_Statu.SelectedIndex);
                courseRegistrationManager.Insert(courseRegistration);
                MessageBox.Show("Saved Successfully");
                GetAllCourseRegistrations();
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
                CourseRegistrationManager courseRegistrationManager = new CourseRegistrationManager(efCourseRegitrationDal);
                int ID = Convert.ToInt32(textBox_ID.Text.Trim());
                courseRegistrationManager.Delete(ID);
                MessageBox.Show("Deleted Successfully");
                GetAllCourseRegistrations();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            CourseRegistrationManager courseRegistrationManager = new CourseRegistrationManager(efCourseRegitrationDal);
            int ID = Convert.ToInt32(textBox_ID.Text.Trim());
            var updatedCourseRegistration = courseRegistrationManager.GetById(ID);
            updatedCourseRegistration.CourseId = Convert.ToInt32(comboBox_CourseId.SelectedValue);
            updatedCourseRegistration.StudentId = Convert.ToInt32(comboBox_StudentId.SelectedValue);
            updatedCourseRegistration.Status = Convert.ToBoolean(comboBox_Statu.SelectedIndex);
            courseRegistrationManager.Update(updatedCourseRegistration);
            MessageBox.Show("Updated Successfully");
            GetAllCourseRegistrations();

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_courseRegistration_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CourseManager courseManager = new CourseManager(efCourseDal);
                StudentManager studentManager = new StudentManager(efStudentDal);
                textBox_ID.Text = dataGridView_courseRegistration.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                
                foreach (var item in courseManager.GetAllCourses())
                {
                    if (item.Id == (int)dataGridView_courseRegistration.Rows[e.RowIndex].Cells["CourseId"].Value)
                    {
                        comboBox_CourseId.Text = item.CourseCode;

                    }
                }

                foreach (var item in studentManager.GetAllStudents())
                {
                    if (item.Id == (int)dataGridView_courseRegistration.Rows[e.RowIndex].Cells["StudentId"].Value)
                    {
                        comboBox_StudentId.Text = item.Name;

                    }
                }

                comboBox_Statu.SelectedIndex = Convert.ToInt32(dataGridView_courseRegistration.Rows[e.RowIndex].Cells["Status"].Value);



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

        private void button_report_Click(object sender, EventArgs e)
        {
            CreatePDF(dataGridView_courseRegistration, "Course Registrations");
        }
    }
}
