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
    public partial class UC_Students : UserControl
    {
        EfStudentDal efStudentDal = new EfStudentDal();
        EfBranchDal efBranchDal = new EfBranchDal();
        public UC_Students()
        {
            InitializeComponent();
        }

        private void GetAllStudents()
        {
            StudentManager studentManager = new StudentManager(efStudentDal);

            dataGridView_students.DataSource = studentManager.GetAllStudents();
        }
        private void UC_Students_Load(object sender, EventArgs e)
        {
            BranchManager branchManager = new BranchManager(efBranchDal);
            GetAllStudents();
            comboBox_branchId.DataSource = branchManager.GetAllBranches();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                StudentManager studentManager = new StudentManager(efStudentDal);
                var student = new Student();
                student.BranchId = Convert.ToInt32(comboBox_branchId.SelectedValue);
                student.Name = textBox_name.Text.Trim();
                student.Surname = textBox_surname.Text.Trim();
                student.Gender = Convert.ToInt32(comboBox_gender.SelectedIndex);
                student.BirthDate = Convert.ToDateTime(dateTimePicker_student.Value.ToString("dd-MM-yyyy"));
                student.PhoneNumber = textBox_phoneNumber.Text.Trim();
                student.Address = richTextBox_address.Text.Trim();
                studentManager.Insert(student);
                MessageBox.Show("Saved Successfully");
                GetAllStudents();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView_students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BranchManager branchManager = new BranchManager(efBranchDal);
                textBox_id.Text = dataGridView_students.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                foreach (var item in branchManager.GetAllBranches())
                {
                    if (item.Id == (int)dataGridView_students.Rows[e.RowIndex].Cells["BranchId"].Value)
                    {
                        comboBox_branchId.Text = item.BranchName;

                    }
                }

                textBox_name.Text = dataGridView_students.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                textBox_surname.Text = dataGridView_students.Rows[e.RowIndex].Cells["Surname"].Value.ToString();
                comboBox_gender.SelectedIndex = Convert.ToInt32(dataGridView_students.Rows[e.RowIndex].Cells["Gender"].Value);
                dateTimePicker_student.Value = Convert.ToDateTime(dataGridView_students.Rows[e.RowIndex].Cells["BirthDate"].Value);
                textBox_phoneNumber.Text = dataGridView_students.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                richTextBox_address.Text = dataGridView_students.Rows[e.RowIndex].Cells["Address"].Value.ToString();
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
                StudentManager studentManager = new StudentManager(efStudentDal);
                int ID = Convert.ToInt32(textBox_id.Text.Trim());
                studentManager.Delete(ID);
                MessageBox.Show("Deleted Successfully");
                GetAllStudents();
            }
            catch (Exception)
            {

                MessageBox.Show("This Recored Can't Delete");
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                StudentManager studentManager = new StudentManager(efStudentDal);
                int ID = Convert.ToInt32(textBox_id.Text.Trim());
                var updatedStudent = studentManager.GetById(ID);
                updatedStudent.BranchId = Convert.ToInt32(comboBox_branchId.SelectedValue);
                updatedStudent.Name = textBox_name.Text.Trim();
                updatedStudent.Surname = textBox_surname.Text.Trim();
                updatedStudent.Gender = Convert.ToInt32(comboBox_gender.SelectedIndex);
                updatedStudent.BirthDate = Convert.ToDateTime(dateTimePicker_student.Value.ToString("dd-MM-yyyy"));
                updatedStudent.PhoneNumber = textBox_phoneNumber.Text.Trim();
                updatedStudent.Address = richTextBox_address.Text.Trim();
                studentManager.Update(updatedStudent);
                MessageBox.Show("Updated Successfully");
                GetAllStudents();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ClearAreas()
        {
            textBox_id.Text = "";
            textBox_name.Text = "";
            textBox_surname.Text = "";
            textBox_phoneNumber.Text = "";
            comboBox_branchId.Text = "Select Branch";
            comboBox_gender.Text = "Select Gender";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            ClearAreas();
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

        private void button_createPdf_Click(object sender, EventArgs e)
        {
            CreatePDF(dataGridView_students, "Students");
        }
    }
}
