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
    public partial class UC_WorkingDaysOfMentor : UserControl
    {
        Mentor mentor;
        EfMentorWorkingDayDal mentorWorkingDayDal = new EfMentorWorkingDayDal(); 
        public UC_WorkingDaysOfMentor(Mentor mentor)
        {
            this.mentor = mentor;
            InitializeComponent();
        }

        private void GetWorkingDays()
        {
            MentorWorkingDayManager workingDayManager = new MentorWorkingDayManager(mentorWorkingDayDal);
            dataGridView_workingday.DataSource = workingDayManager.GetDaysByMentor(mentor.Id);
        }
        private void UC_WorkingDaysOfMentor_Load(object sender, EventArgs e)
        {
            GetWorkingDays();
        }
    }
}
