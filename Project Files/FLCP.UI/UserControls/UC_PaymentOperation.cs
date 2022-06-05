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
    public partial class UC_PaymentOperation : UserControl
    {
        EfStudentDal efStudentDal = new EfStudentDal();
        EfCourseDal efCourseDal = new EfCourseDal();
        EfPaymentDal efPaymentDal = new EfPaymentDal();
        public UC_PaymentOperation()
        {
            InitializeComponent();
        }

        private void GellAllPayments()
        {
            PaymentManager paymentManager = new PaymentManager(efPaymentDal);
            dataGridView_payments.DataSource = paymentManager.GetAllPayments();
        }

        private void UC_PaymentOperation_Load(object sender, EventArgs e)
        {
            StudentManager studentManager = new StudentManager(efStudentDal);
            CourseManager courseManager = new CourseManager(efCourseDal);
            comboBox_student.DataSource = studentManager.GetAllStudents();
            comboBox_course.DataSource = courseManager.GetAllCourses();
            GellAllPayments();
            
            
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentManager paymentManager = new PaymentManager(efPaymentDal);
                var payment = new Payment();
                payment.PaymentTitle = textBox_title.Text.Trim();
                payment.PaymentDescription = richTextBox_description.Text.Trim();
                payment.PaymentType = Convert.ToBoolean(comboBox_paymentType.SelectedIndex);
                payment.PaymentStatus = Convert.ToBoolean(comboBox_PaymentStatu.SelectedIndex);
                payment.StudentId = Convert.ToInt32(comboBox_student.SelectedValue);
                payment.CourseId = Convert.ToInt32(comboBox_course.SelectedValue);
                payment.NumberOfInstallments = Convert.ToInt32(textBox_NumberOfInstallments.Text.Trim());
                paymentManager.Insert(payment);
                MessageBox.Show("Saved Successfully");
                ClearAreas();
                GellAllPayments();
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
                PaymentManager paymentManager = new PaymentManager(efPaymentDal);
                int ID = Convert.ToInt32(textBox_Id.Text.Trim());
                paymentManager.Delete(ID);
                MessageBox.Show("Deleted Successfully");
                ClearAreas();
                GellAllPayments();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                PaymentManager paymentManager = new PaymentManager(efPaymentDal);
                int ID = Convert.ToInt32(textBox_Id.Text.Trim());
                var updatedPayment = paymentManager.GetById(ID);
                updatedPayment.PaymentTitle = textBox_title.Text.Trim();
                updatedPayment.PaymentDescription = richTextBox_description.Text.Trim();
                updatedPayment.PaymentType = Convert.ToBoolean(comboBox_paymentType.SelectedIndex);
                updatedPayment.PaymentStatus = Convert.ToBoolean(comboBox_PaymentStatu.SelectedIndex);
                updatedPayment.StudentId = Convert.ToInt32(comboBox_student.SelectedValue);
                updatedPayment.NumberOfInstallments = Convert.ToInt32(textBox_NumberOfInstallments.Text.Trim());
                paymentManager.Update(updatedPayment);
                MessageBox.Show("Updated Successfully");
                ClearAreas();
                GellAllPayments();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView_payments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                StudentManager studentManager = new StudentManager(efStudentDal);
                CourseManager courseManager = new CourseManager(efCourseDal);
                textBox_Id.Text = dataGridView_payments.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                textBox_title.Text = dataGridView_payments.Rows[e.RowIndex].Cells["PaymentTitle"].Value.ToString();
                richTextBox_description.Text = dataGridView_payments.Rows[e.RowIndex].Cells["PaymentDescription"].Value.ToString();
                comboBox_paymentType.SelectedIndex = Convert.ToInt32(dataGridView_payments.Rows[e.RowIndex].Cells["PaymentType"].Value);
                comboBox_PaymentStatu.SelectedIndex = Convert.ToInt32(dataGridView_payments.Rows[e.RowIndex].Cells["PaymentStatus"].Value);
                foreach (var item in studentManager.GetAllStudents())
                {
                    if (item.Id == (int)dataGridView_payments.Rows[e.RowIndex].Cells["StudentId"].Value)
                    {
                        comboBox_student.Text = item.Name;

                    }
                }

                foreach (var item in courseManager.GetAllCourses())
                {
                    if (item.Id == (int)dataGridView_payments.Rows[e.RowIndex].Cells["CourseId"].Value)
                    {
                        comboBox_course.Text = item.CourseCode;

                    }
                }

                textBox_NumberOfInstallments.Text = dataGridView_payments.Rows[e.RowIndex].Cells["NumberOfInstallments"].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ClearAreas()
        {
            textBox_Id.Text = "";
            textBox_title.Text = "";
            richTextBox_description.Text = "";
            comboBox_PaymentStatu.Text = "Select Payment Statu";
            comboBox_paymentType.Text = "Select Payment Type";
            comboBox_student.Text = "Select Student";
            comboBox_course.Text = "Select Course";
            textBox_NumberOfInstallments.Text = "";
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
        private void button_createReport_Click(object sender, EventArgs e)
        {
            CreatePDF(dataGridView_payments, "Payments");
        }
    }
}
