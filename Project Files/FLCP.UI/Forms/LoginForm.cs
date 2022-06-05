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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

       

        private void button_mentor_Click(object sender, EventArgs e)
        {
            this.Hide();
            MentorLoginForm MLF = new MentorLoginForm();
            MLF.Show();
        }

        private void button_AdminAndOfficier_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLoginForm MLF = new ManagerLoginForm();
            MLF.Show();
        }

        private void button_student_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLoginForm SLF = new StudentLoginForm();
            SLF.Show();
        }
    }
}
