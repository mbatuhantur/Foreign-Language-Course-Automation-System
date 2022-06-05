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

namespace FLCP.UI.Forms
{
    public partial class StudentLoginForm : Form
    {
        Student student = new Student();
        EfStudentDal efStudentDal = new EfStudentDal();
        public StudentLoginForm()
        {
            InitializeComponent();
        }
        
        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBox_id.Text.Trim());
                string PhoneNumber = textBox_phoneNumber.Text.Trim();
                StudentManager studentManager = new StudentManager(efStudentDal);

                bool IsValid = studentManager.LoginControl(ID, PhoneNumber);
                if (IsValid == true)
                {
                    var student = studentManager.GetById(ID);
                    this.Hide();
                    StudentMainForm SMF = new StudentMainForm(student);
                    SMF.Show();
                }

                else
                {
                    MessageBox.Show("INVALID STUDENT");
                }

            }
            catch (Exception )
            {

                MessageBox.Show("Fill in the Blanks");
            }
        }
    }
}
