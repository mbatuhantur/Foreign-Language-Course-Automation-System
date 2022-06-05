using FLCP.BusinessLogicLayer.Concrete;
using FLCP.DataAccess.Concrete;
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
    public partial class ManagerLoginForm : Form
    {
        EfUserDal efUserDal = new EfUserDal();
        public ManagerLoginForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                UserManager userManager = new UserManager(efUserDal);
                int ID = Convert.ToInt32(textBox_Id.Text.Trim());
                string PhoneNumber = textBox_phoneNumber.Text.Trim();
                bool IsValid = userManager.LoginControl(ID, PhoneNumber);
                if (IsValid == true)
                {
                    this.Hide();
                    ManagerMainForm MMF = new ManagerMainForm();
                    MMF.Show();
                }

                else
                {
                    MessageBox.Show("ID or Phone Number is Wrong");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Fill in the blanks");
            }

        }
    }
}
