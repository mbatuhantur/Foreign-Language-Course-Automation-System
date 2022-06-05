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
    public partial class UC_WorkingDay : UserControl
    {
        EfWorkingDayDal efWorkingDayDal = new EfWorkingDayDal();
        public UC_WorkingDay()
        {
            InitializeComponent();
        }

        private void GetAllWorkingDays()
        {
            WorkingDayManager workingDayManager = new WorkingDayManager(efWorkingDayDal);
            dataGridView_workingDay.DataSource = workingDayManager.GetAllWorkingDays();
        }

        private void UC_WorkingDay_Load(object sender, EventArgs e)
        {
            GetAllWorkingDays();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                WorkingDayManager workingDayManager = new WorkingDayManager(efWorkingDayDal);
                var workingDay = new WorkingDay();
                workingDay.DayName = textBox_dayName.Text.Trim();
                workingDayManager.Insert(workingDay);
                MessageBox.Show("Successfully Saved");
                GetAllWorkingDays();
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
                WorkingDayManager workingDayManager = new WorkingDayManager(efWorkingDayDal);
                int ID = Convert.ToInt32(textBox_Id.Text.Trim());
                workingDayManager.Delete(ID);
                GetAllWorkingDays();
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

                WorkingDayManager workingDayManager = new WorkingDayManager(efWorkingDayDal);
                int ID = Convert.ToInt32(textBox_Id.Text.Trim());
                var updatedWorkingDay = workingDayManager.GetById(ID);
                updatedWorkingDay.DayName = textBox_dayName.Text.Trim();
                workingDayManager.Update(updatedWorkingDay);
                MessageBox.Show("Updated Successfully");
                GetAllWorkingDays();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView_workingDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_Id.Text = dataGridView_workingDay.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                textBox_dayName.Text = dataGridView_workingDay.Rows[e.RowIndex].Cells["DayName"].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
