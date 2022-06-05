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
    public partial class UC_Lecturer : UserControl
    {
        EfMentorDal efMentorDal = new EfMentorDal();
        EfLanguageDal efLanguageDal = new EfLanguageDal();
        EfBranchDal efBranchDal = new EfBranchDal();
        EfWorkingDayDal efWorkingDayDal = new EfWorkingDayDal();
        EfMentorWorkingDayDal efMentorWorkingDayDal = new EfMentorWorkingDayDal();
        public UC_Lecturer()
        {
            InitializeComponent();
        }

        private void GetAllMentors()
        {
            MentorManager mentorManager = new MentorManager(efMentorDal);
            dataGridView_lecturer.DataSource = mentorManager.GetAllMentors();
        }

        private void GetAllMentorWithWorkingDays()
        {
            MentorWorkingDayManager mentorWorkingDaymanager = new MentorWorkingDayManager(efMentorWorkingDayDal);
            dataGridView_mentor_workingDay.DataSource = mentorWorkingDaymanager.GetAll();
        }

        private void UC_Lecturer_Load(object sender, EventArgs e)
        {
            MentorManager mentorManager = new MentorManager(efMentorDal);
            LanguageManager languageManager = new LanguageManager(efLanguageDal);
            BranchManager branchManager = new BranchManager(efBranchDal);
            WorkingDayManager workingDayManager = new WorkingDayManager(efWorkingDayDal);
            GetAllMentorWithWorkingDays();
            GetAllMentors();
            comboBox_Language.DataSource = languageManager.GetAllLanguages();
            comboBox_Branch.DataSource = branchManager.GetAllBranches();

            comboBox_LecturerId.DataSource = mentorManager.GetAllMentors();
            comboBox_WorkingDay.DataSource = workingDayManager.GetAllWorkingDays();
            
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                MentorManager mentorManager = new MentorManager(efMentorDal);
                var mentor = new Mentor();
                mentor.LanguageId = Convert.ToInt32(comboBox_Language.SelectedValue);
                mentor.BranchId = Convert.ToInt32(comboBox_Branch.SelectedValue);
                mentor.Name = textBox_Name.Text.Trim();
                mentor.Surname = textBox_Surname.Text.Trim();
                mentor.Gender = Convert.ToInt32(comboBox_Gender.SelectedIndex);
                mentor.BirthDate = Convert.ToDateTime(dateTimePicker_BirthDate.Value.ToString("dd-MM-yyyy"));
                mentor.PhoneNumber = textBox_Phone.Text.Trim();
                mentor.Address = richTextBox_address.Text.Trim();
                mentorManager.Insert(mentor);
                MessageBox.Show("Saved Successfully");
                GetAllMentors();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView_lecturer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LanguageManager languageManager = new LanguageManager(efLanguageDal);
                BranchManager branchManager = new BranchManager(efBranchDal);
                textBox_LecturerId.Text = dataGridView_lecturer.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                
                foreach (var item in languageManager.GetAllLanguages())
                {
                    if (item.Id == (int)dataGridView_lecturer.Rows[e.RowIndex].Cells["LanguageId"].Value)
                    {
                        comboBox_Language.Text = item.Name;

                    }
                }

                foreach (var item in branchManager.GetAllBranches())
                {
                    if (item.Id == (int)dataGridView_lecturer.Rows[e.RowIndex].Cells["BranchId"].Value)
                    {
                        comboBox_Branch.Text = item.BranchName;

                    }
                }

                textBox_Name.Text = dataGridView_lecturer.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                textBox_Surname.Text = dataGridView_lecturer.Rows[e.RowIndex].Cells["Surname"].Value.ToString();
                comboBox_Gender.SelectedIndex = Convert.ToInt32(dataGridView_lecturer.Rows[e.RowIndex].Cells["Gender"].Value);
                dateTimePicker_BirthDate.Value = Convert.ToDateTime(dataGridView_lecturer.Rows[e.RowIndex].Cells["BirthDate"].Value);
                textBox_Phone.Text = dataGridView_lecturer.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                richTextBox_address.Text = dataGridView_lecturer.Rows[e.RowIndex].Cells["Address"].Value.ToString();



            }
            catch (Exception)
            {

                MessageBox.Show("Don't Click Header of the Table");
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                MentorManager mentorManager = new MentorManager(efMentorDal);
                int ID = Convert.ToInt32(textBox_LecturerId.Text.Trim());
                mentorManager.Delete(ID);
                MessageBox.Show("Deleted Successfully");
                GetAllMentors();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                MentorManager mentorManager = new MentorManager(efMentorDal);
                int ID = Convert.ToInt32(textBox_LecturerId.Text.Trim());
                var updatedMentor = mentorManager.GetById(ID);
                updatedMentor.LanguageId = Convert.ToInt32(comboBox_Language.SelectedValue);
                updatedMentor.BranchId = Convert.ToInt32(comboBox_Branch.SelectedValue);
                updatedMentor.Name = textBox_Name.Text.Trim();
                updatedMentor.Surname = textBox_Surname.Text.Trim();
                updatedMentor.Gender = Convert.ToInt32(comboBox_Gender.SelectedIndex);
                updatedMentor.BirthDate = Convert.ToDateTime(dateTimePicker_BirthDate.Value.ToString("dd-MM-yyyy"));
                updatedMentor.PhoneNumber = textBox_Phone.Text.Trim();
                updatedMentor.Address = richTextBox_address.Text.Trim();
                mentorManager.Update(updatedMentor);
                MessageBox.Show("Updated Successfully");
                GetAllMentors();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void ClearAreas()
        {
            textBox_LecturerId.Text = "";
            textBox_Name.Text = "";
            textBox_Surname.Text = "";
            textBox_Phone.Text = "";
            comboBox_Branch.Text = "Select Branch";
            comboBox_Gender.Text = "Select Gender";
            comboBox_Language.Text = "Select Language";
            textBox_Phone.Text = "";
            richTextBox_address.Text = "";
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearAreas();
        }

        private void button_saveLecturerWorkingDay_Click(object sender, EventArgs e)
        {
            try
            {
                MentorWorkingDayManager mentorWorkingDaymanager = new MentorWorkingDayManager(efMentorWorkingDayDal);
                var mentorWorkingDay = new MentorWorkingDay();
                mentorWorkingDay.MentorId = Convert.ToInt32(comboBox_LecturerId.SelectedValue);
                mentorWorkingDay.WorkingDayId = Convert.ToInt32(comboBox_WorkingDay.SelectedValue);
                mentorWorkingDaymanager.Insert(mentorWorkingDay);
                MessageBox.Show("Saved Successfully");
                GetAllMentorWithWorkingDays();

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

        private void button_cretaePDF_Click(object sender, EventArgs e)
        {
            CreatePDF(dataGridView_lecturer, "Lecturers");
        }
    }
}
