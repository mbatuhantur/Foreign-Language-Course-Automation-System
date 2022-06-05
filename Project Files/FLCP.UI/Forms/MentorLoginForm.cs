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
    public partial class MentorLoginForm : Form
    {
        
        EfMentorDal efMentorDal = new EfMentorDal();
        public MentorLoginForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                 
                MentorManager mentorManager = new MentorManager(efMentorDal);
                bool IsValid = mentorManager.LoginControl(Convert.ToInt32(textBox_ID.Text.Trim()),textBox_PhoneNumber.Text.Trim());
                if (IsValid == true)
                {
                    var mentor = mentorManager.GetById(Convert.ToInt32(textBox_ID.Text.Trim()));
                    MentorMainForm MMF = new MentorMainForm(mentor);
                    this.Hide();
                    MMF.Show();
                }

                else
                {
                    MessageBox.Show("INVALID USER");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Fill in the blanks");
            }
        }
    }
}
