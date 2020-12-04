using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewCheckList
{
    public partial class SettingInformation : Form
    {

        public bool IsOkPressed = false;

        public SettingInformation()
        {
            InitializeComponent();
            ThemeSelect(Properties.Settings.Default.Theme);
            //txtUserName.Text = Properties.Settings.Default.User_Name;
            if (Properties.Settings.Default.Theme == "Light") { cmbTheme.SelectedIndex = 0; }
            else { cmbTheme.SelectedIndex = 1; }
            
        }



        public void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text))
            {
                Properties.Settings.Default.User_Name = txtUserName.Text;
            }
            if (!string.IsNullOrEmpty(txtProjectName.Text))
            {
                Properties.Settings.Default.Project_Name = txtProjectName.Text;
            }
            if (!string.IsNullOrEmpty(txtProjectId.Text))
            {
                Properties.Settings.Default.Project_Id = txtProjectId.Text;
            }
            if (!string.IsNullOrEmpty(cmbTheme.Text))
            {
                Properties.Settings.Default.Theme = cmbTheme.Text;
            }
            Properties.Settings.Default.Save();
            IsOkPressed = true;
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTheme.Text=="Dark")
            {
                Properties.Settings.Default.Theme = "Dark";
                
            }
            else
            {
                Properties.Settings.Default.Theme = "Light";
                
            }
        }

        private void ThemeSelect(string theme)
        {
            if(theme=="Light")
            {
                ThemeLight();
            }
            
        }
        private void ThemeLight()
        {
            this.BackColor = Color.WhiteSmoke;
            lblProjectIdSetting.ForeColor = Color.Black;
            lblProjectNameSetting.ForeColor = Color.Black;
            lblTheme.ForeColor = Color.Black;
            lblUserNameSetting.ForeColor = Color.Black;
            txtProjectId.ForeColor = Color.Black;
            txtProjectName.ForeColor = Color.Black;
            txtUserName.ForeColor = Color.Black;
            cmbTheme.ForeColor = Color.Black;
            txtProjectId.BackColor = Color.White;
            txtProjectName.BackColor = Color.White;
            txtUserName.BackColor = Color.White;
            cmbTheme.BackColor = Color.White;


        }

        private void txtFolderPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblReportDirectory_Click(object sender, EventArgs e)
        {

        }

        private void SettingInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
