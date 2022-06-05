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
    public partial class UC_Language : UserControl
    {
        EfLanguageDal efLanguageDal = new EfLanguageDal();
        public UC_Language()
        {
            InitializeComponent();
        }

        private void GetAllLanguages()
        {
            LanguageManager languageManager = new LanguageManager(efLanguageDal);
            dataGridView_Language.DataSource = languageManager.GetAllLanguages();
        }
        private void UC_Language_Load(object sender, EventArgs e)
        {
            GetAllLanguages();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                LanguageManager languageManager = new LanguageManager(efLanguageDal);
                var language = new Language();
                language.Name = textBox_LanguageName.Text.Trim();
                languageManager.Insert(language);
                MessageBox.Show("Saved Successfully");
                GetAllLanguages();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView_Language_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LanguageManager languageManager = new LanguageManager(efLanguageDal);
                textBox_ID.Text = dataGridView_Language.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                textBox_LanguageName.Text = dataGridView_Language.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                LanguageManager languageManager = new LanguageManager(efLanguageDal);
                int ID = Convert.ToInt32(textBox_ID.Text.Trim());
                languageManager.Delete(ID);
                MessageBox.Show("Deleted Successfully");
                GetAllLanguages();
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
                LanguageManager languageManager = new LanguageManager(efLanguageDal);
                int ID = Convert.ToInt32(textBox_ID.Text.Trim());
                var updatedLanguage = languageManager.GetById(ID);
                updatedLanguage.Name = textBox_LanguageName.Text.Trim();
                languageManager.Update(updatedLanguage);
                MessageBox.Show("Updated Successfully");
                GetAllLanguages();
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_ID.Text = "";
            textBox_LanguageName.Text = "";
        }
    }
}
