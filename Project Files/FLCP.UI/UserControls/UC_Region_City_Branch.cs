using FLCP.BusinessLogicLayer.Concrete;
using FLCP.DataAccess.Concrete;
using FLCP.Entitiy.DTOs;
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
    public partial class UC_Region_City_Branch : UserControl
    {
        EfRegionDal efRegionDal = new EfRegionDal();
        EfBranchDal efBranchDal = new EfBranchDal();
        EfCityDal efCityDal = new EfCityDal();
        public UC_Region_City_Branch()
        {
            InitializeComponent();
        }
        
        private void GetAllCity()
        {
            CityManager cityManager = new CityManager(efCityDal);
            dataGridView_city.DataSource = cityManager.GetAllCities();
        }

        private void GetAllRegion()
        {
            RegionManager regionManager = new RegionManager(efRegionDal);
            dataGridView_Region.DataSource = regionManager.GetAllRegions();
        }

        private void GetAllBranch()
        {
            BranchManager branchManager = new BranchManager(efBranchDal);
            dataGridView_branch.DataSource = branchManager.GetAllBranches();

        }

        private void FillTheCombobox()
        {
            CityManager cityManager = new CityManager(efCityDal);
            comboBox_CityIdFK.DataSource = cityManager.GetAllCities();
            RegionManager regionManager = new RegionManager(efRegionDal);
            comboBox_RegionIdFK.DataSource = regionManager.GetAllRegions();
        }

        private void UC_Region_City_Branch_Load(object sender, EventArgs e)
        {

            FillTheCombobox();
            GetAllBranch();
            GetAllRegion();
            GetAllCity();

        }

       

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton_Branch.Checked == true)
                {
                    var branch = new Branch();
                    branch.BranchName = textBox_branchName.Text.Trim();
                    branch.BranchPhone = textBox_branchPhone.Text.Trim();
                    branch.BranchAdress = richTextBox_Address.Text.Trim();
                    branch.CityId = Convert.ToInt32(comboBox_CityIdFK.SelectedValue);
                    BranchManager branchManager = new BranchManager(efBranchDal);
                    branchManager.Insert(branch);
                    MessageBox.Show("Successfully Saved");
                    GetAllBranch();
                }

                else if (radioButton_City.Checked == true)
                {
                    var city = new City();
                    city.CirtyName = textBox_CityName.Text.Trim();
                    city.RegionId = Convert.ToInt32(comboBox_RegionIdFK.SelectedValue);
                    CityManager cityManager = new CityManager(efCityDal);
                    cityManager.Insert(city);
                    MessageBox.Show("Successfully Saved");
                    GetAllCity();
                }

                else if (radioButton_Region.Checked == true)
                {
                    var region = new Entity.Model.Region();
                    region.RegionName = textBox_RegionName.Text.Trim();
                    RegionManager regionManager = new RegionManager(efRegionDal);
                    regionManager.Insert(region);
                    MessageBox.Show("Successfully Saved");
                    GetAllRegion();
                }

                else
                {
                    MessageBox.Show("Please Click Radio Button");
                }
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
                if (radioButton_Branch.Checked == true)
                {
                    int ID = Convert.ToInt32(textBox_BranchId.Text.Trim());
                    BranchManager branchManager = new BranchManager(efBranchDal);
                    var updatedBrach = branchManager.GetById(ID);
                    updatedBrach.BranchName = textBox_branchName.Text.Trim();
                    updatedBrach.BranchPhone = textBox_branchPhone.Text.Trim();
                    updatedBrach.BranchAdress = richTextBox_Address.Text.Trim();
                    updatedBrach.CityId = Convert.ToInt32(comboBox_CityIdFK.SelectedValue);
                    branchManager.Update(updatedBrach);
                    MessageBox.Show("Branch Successfully Updated");
                    GetAllBranch();
                }

                else if (radioButton_City.Checked == true)
                {
                    int ID = Convert.ToInt32(textBox_CityId.Text.Trim());
                    CityManager cityManager = new CityManager(efCityDal);
                    var updatedCity = cityManager.GetById(ID);
                    updatedCity.CirtyName = textBox_CityName.Text.Trim();
                    updatedCity.RegionId = Convert.ToInt32(comboBox_RegionIdFK.SelectedValue);
                    cityManager.Update(updatedCity);
                    MessageBox.Show("City Successfully Updated");
                    GetAllCity();
                }

                else if (radioButton_Region.Checked == true)
                {
                    int ID = Convert.ToInt32(textBox_RegionID.Text.Trim());
                    RegionManager regionManager = new RegionManager(efRegionDal);
                    var updatedRegion = regionManager.GetById(ID);
                    updatedRegion.RegionName = textBox_RegionName.Text.Trim();
                    regionManager.Update(updatedRegion);
                    MessageBox.Show("Region Successfully Updated");
                    GetAllRegion();
                }

                else
                {
                    MessageBox.Show("Please Click Radio Button");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView_Region_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_RegionID.Text = dataGridView_Region.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                textBox_RegionName.Text = dataGridView_Region.Rows[e.RowIndex].Cells["RegionName"].Value.ToString();
                


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("DO NOT CLICK THE HEADER OF THIS TABLE");

            }
        }

        private void dataGridView_city_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RegionManager regionManager = new RegionManager(efRegionDal);
                textBox_CityId.Text = dataGridView_city.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                textBox_CityName.Text = dataGridView_city.Rows[e.RowIndex].Cells["CirtyName"].Value.ToString();

                foreach (var item in regionManager.GetAllRegions())
                {
                    if (item.Id == (int)dataGridView_city.Rows[e.RowIndex].Cells["RegionId"].Value)
                    {
                        comboBox_RegionIdFK.Text = item.RegionName;

                    }
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("DO NOT CLICK THE HEADER OF THIS TABLE");

            }
        }

        private void dataGridView_branch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CityManager cityManager = new CityManager(efCityDal);
                textBox_BranchId.Text = dataGridView_branch.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                textBox_branchName.Text = dataGridView_branch.Rows[e.RowIndex].Cells["BranchName"].Value.ToString();
                textBox_branchPhone.Text = dataGridView_branch.Rows[e.RowIndex].Cells["BranchPhone"].Value.ToString();
                richTextBox_Address.Text = dataGridView_branch.Rows[e.RowIndex].Cells["BranchAdress"].Value.ToString();
                foreach (var item in cityManager.GetAllCities())
                {
                    if (item.Id == (int)dataGridView_branch.Rows[e.RowIndex].Cells["CityId"].Value)
                    {
                        comboBox_CityIdFK.Text = item.CirtyName;

                    }
                }
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
                if (radioButton_Branch.Checked == true)
                {
                    int ID = Convert.ToInt32(textBox_BranchId.Text.Trim());
                    BranchManager branchManager = new BranchManager(efBranchDal);
                    branchManager.Delete(ID);
                    MessageBox.Show("Branch Deleted Successfully");
                    GetAllBranch();
                }

                else if (radioButton_City.Checked == true)
                {
                    int ID = Convert.ToInt32(textBox_CityId.Text.Trim());
                    CityManager cityManager = new CityManager(efCityDal);
                    cityManager.Delete(ID);
                    MessageBox.Show("City Deleted Successfully");
                    GetAllCity();
                }

                else if (radioButton_Region.Checked == true)
                {
                    int ID = Convert.ToInt32(textBox_RegionID.Text.Trim());
                    RegionManager regionManager = new RegionManager(efRegionDal);
                    regionManager.Delete(ID);
                    MessageBox.Show("Region Deleted Successfully");
                    GetAllCity();
                }

                else
                {
                    MessageBox.Show("Please Click Radio Button");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("You cannot do delete operation");
            }
        }

        
        private void button_Clear_Click(object sender, EventArgs e)
        {
            if (radioButton_Branch.Checked == true)
            {
                textBox_BranchId.Text = "";
                textBox_branchName.Text = "";
                textBox_branchPhone.Text = "";
                richTextBox_Address.Text = "";
                comboBox_CityIdFK.SelectedIndex = 0;
            }

            else if (radioButton_City.Checked == true)
            {
                textBox_CityId.Text = "";
                textBox_CityName.Text = "";
                comboBox_RegionIdFK.SelectedIndex = 0;
            }

            else if (radioButton_Region.Checked == true)
            {
                textBox_RegionID.Text = "";
                textBox_RegionName.Text = "";
            }

            else
            {
                MessageBox.Show("Please Click Radio Button");
            }
        }
    }
}
