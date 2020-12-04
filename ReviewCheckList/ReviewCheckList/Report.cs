using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ReviewCheckList
{
    public partial class Report : UserControl
    {
        public Report()
        {
            InitializeComponent();
            txtFolderPath.Text = Properties.Settings.Default.FolderPath;
            ThemeSelect(Properties.Settings.Default.Theme);
            this.BackColor = Color.WhiteSmoke;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            ThemeSelect(Properties.Settings.Default.Theme);
        }

        private void btnFolderBrows_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog selectFolder = new FolderBrowserDialog();
            if (selectFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { txtFolderPath.Text = selectFolder.SelectedPath;
              Properties.Settings.Default.FolderPath = selectFolder.SelectedPath;
            }
            Properties.Settings.Default.Save();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileAsPdf();
            Properties.Settings.Default.IsFileSaved = false;
            Properties.Settings.Default.Save();
        }
        private void SaveFileAsPdf()
        {
            FileInfo fi = new FileInfo($"{txtFolderPath.Text}\\{txtReportName.Text}.pdf");
            if (!File.Exists($"{txtFolderPath.Text}\\{txtReportName.Text}.pdf"))
            {
                List<string> header = MainUI.header;
                List<ItemProperties> lstItems = MainUI.lstItems;
                List<string> items = MainUI.items;
                WriteExcel writeExcel = new WriteExcel();
                writeExcel.Headerproperties(header);
                writeExcel.WriteCell(lstItems, items.Count - 1);
                //writeExcel.Save();
                writeExcel.SaveAs(txtFolderPath.Text, txtReportName.Text);
                writeExcel.Close();
                pcDone.Visible = true;
                btnSave.Enabled = false;
            }
            else
            {
                if (!IsFileLocked(fi))
                {
                    List<string> header = MainUI.header;
                    List<ItemProperties> lstItems = MainUI.lstItems;
                    List<string> items = MainUI.items;
                    WriteExcel writeExcel = new WriteExcel();
                    writeExcel.Headerproperties(header);
                    writeExcel.WriteCell(lstItems, items.Count - 1);
                    //writeExcel.Save();
                    writeExcel.SaveAs(txtFolderPath.Text, txtReportName.Text);
                    writeExcel.Close();
                    pcDone.Visible = true;
                    btnSave.Enabled = false;
                }
                else
                {
                    MessageBox.Show("File may be open in another progam.Please close and try again!");
                }
            }
        }
        private void ThemeSelect(string theme)
        {
            if (theme == "Light")
            {
                ReportThemeLight();
            }
        }
        public void ThemeLight()
        {
            this.BackColor = Color.White;
            lblReportDirectory.ForeColor = Color.Black;
            lblReportName.ForeColor = Color.Black;
            txtFolderPath.ForeColor = Color.Black;
            txtReportName.ForeColor = Color.Black;
            txtFolderPath.BackColor = Color.White;
            txtReportName.BackColor = Color.White;
            btnFolderBrows.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnPrevious.FlatAppearance.BorderColor = Color.White;
        }
        public void ReportThemeLight()
        {
            this.BackColor = Color.White;
            lblReportDirectory.ForeColor = Color.Black;
            lblReportName.ForeColor = Color.Black;
            txtFolderPath.ForeColor = Color.Black;
            txtReportName.ForeColor = Color.Black;
            txtFolderPath.BackColor = Color.White;
            txtReportName.BackColor = Color.White;
            btnRemember.ForeColor = Color.Black;
            btnFolderBrows.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnPrevious.FlatAppearance.BorderColor = Color.White;
            btnPrevious.FlatAppearance.BorderColor = Color.White;
            btnRemember.FlatAppearance.BorderColor = Color.White;
            btnPrevious.FlatAppearance.MouseOverBackColor = Color.FromArgb(181, 181, 181);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(181, 181, 181);
            btnFolderBrows.FlatAppearance.MouseOverBackColor = Color.FromArgb(181, 181, 181);

            btnPrevious.Image = Properties.Resources.Previous_2;
            btnSave.BackgroundImage = Properties.Resources.save2;
        }
        public void ReportThemeDark()
        {
            this.BackColor = Color.FromArgb(35, 36, 38);
            lblReportDirectory.ForeColor = Color.WhiteSmoke;
            lblReportName.ForeColor = Color.WhiteSmoke;
            txtFolderPath.ForeColor = Color.White;
            txtReportName.ForeColor = Color.White;
            btnRemember.ForeColor = Color.White;
            txtFolderPath.BackColor = Color.FromArgb(53, 55, 59);
            txtReportName.BackColor = Color.FromArgb(53, 55, 59);

            btnFolderBrows.FlatAppearance.BorderColor = Color.FromArgb(35, 36, 38);
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(35, 36, 38);
            btnPrevious.FlatAppearance.BorderColor = Color.FromArgb(35, 36, 38);
            btnPrevious.FlatAppearance.BorderColor = Color.FromArgb(35, 36, 38);
            btnRemember.FlatAppearance.BorderColor = Color.FromArgb(35, 36, 38);


            btnFolderBrows.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 63, 66);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 63, 66);
            btnPrevious.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 63, 66);
            btnRemember.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 63, 66);

            btnPrevious.Image = Properties.Resources.Previous_Dark;
            btnSave.BackgroundImage = Properties.Resources.Save_Dark;

        }
        public void FileName()
        {
            List<string> header = MainUI.header;
            if (MainUI.userInput)
            {
                txtReportName.Text = $"{header[2]}_{Properties.Settings.Default.User_Name}";
            }
        }

        private void btnReportPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnSave.Enabled = true;
            pcDone.Visible = false;
        }

        private void txtReportName_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists($"{txtFolderPath.Text}\\{txtReportName.Text}.pdf"))
            { 
                txtReportName.ForeColor = Color.Red;
                lblAvailableError.Visible=true;
            }
            else {
                if (Properties.Settings.Default.Theme == "Light")
                { txtReportName.ForeColor = Color.Black; }
                else { txtReportName.ForeColor = Color.WhiteSmoke; }
                lblAvailableError.Visible = false;
            }
            btnSave.Enabled = true;
            pcDone.Visible = false;
        }

        private void txtFolderPath_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            pcDone.Visible = false;
            if (File.Exists($"{txtFolderPath.Text}\\{txtReportName.Text}.pdf"))
            {
                txtReportName.ForeColor = Color.Red;
                lblAvailableError.Visible = true;
            }
            else
            {
                if (Properties.Settings.Default.Theme == "Light")
                { txtReportName.ForeColor = Color.Black; }
                else { txtReportName.ForeColor = Color.WhiteSmoke; }
                lblAvailableError.Visible = false;
            }
            btnSave.Enabled = true;
            pcDone.Visible = false;
        }

        private void Report_VisibleChanged(object sender, EventArgs e)
        {
            if (File.Exists($"{txtFolderPath.Text}\\{txtReportName.Text}.pdf"))
            {
                txtReportName.ForeColor = Color.Red;
                lblAvailableError.Visible = true;
            }
            else
            {
                if (Properties.Settings.Default.Theme == "Light")
                { txtReportName.ForeColor = Color.Black; }
                else { txtReportName.ForeColor = Color.WhiteSmoke; }
                
                lblAvailableError.Visible = false;
            }
            btnSave.Enabled = true;
            pcDone.Visible = false;
        }
        protected bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                return true;
            }

            return false;
        }
        
        private void btnSaveForLater_Click(object sender, EventArgs e)
        {
            SaveFileAsXml();
            Properties.Settings.Default.IsFileSaved = true;
            Properties.Settings.Default.Save();
        }
        private void SaveFileAsXml()
        {
            FileInfo fi = new FileInfo($"{txtFolderPath.Text}\\{txtReportName.Text}.xml");
            Properties.Settings.Default.SavedFileName = txtReportName.Text;
            Properties.Settings.Default.Save();
            string path = Properties.Settings.Default.FolderPath;
            if (!File.Exists($"{txtFolderPath.Text}\\{txtReportName.Text}.xml"))
            {
                Serializer serializer = new Serializer();
                List<string> header = MainUI.header;
                List<string> items = MainUI.items;
                List<string> info = new List<string>();
                info.AddRange(header);
                info.Add("ITEMS");
                info.AddRange(items);
                serializer.ListSerialize(info, path, txtReportName.Text);
                serializer.Serialize(path, txtReportName.Text);
            }
            else
            {
                if (!IsFileLocked(fi))
                {
                    Serializer serializer = new Serializer();
                    List<string> header = MainUI.header;
                    List<string> items = MainUI.items;
                    List<string> info = new List<string>();
                    info.AddRange(header);
                    info.Add("ITEMS");
                    info.AddRange(items);
                    serializer.ListSerialize(info, path, txtReportName.Text);
                    serializer.Serialize(path, txtReportName.Text);
                }
                else
                {
                    MessageBox.Show("File may be open in another progam.Please close and try again!");
                }
            }
        }
        bool warning = false;
        public void btnSaveWarning()
        {

            List<string> header = MainUI.header;
            int countEmpty = 0;
            for (int i=0;i<=header.Count-1;i++)
            {
                if (header[i].Length == 0) { countEmpty += 1; }
            }
            if (!(MainUI.reviewStatus=="PASSED") && !(MainUI.reviewStatus == "FAILED") || countEmpty>0)
            {
                btnSave.Image = Properties.Resources.iconfinder_weather_48_2682803__1_;
                warning = true;
            }
            else
            {
                btnSave.Image = null;
                warning = false;
            }
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            if(warning)
            {
                tpSaveWarning.Show("Some fields are yet to be completed", btnSave);
            }
            else
            {
                tpSaveWarning.Show("Save report as PDF", btnSave);
            }
            
        }

        private void btnRemember_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Save and start working later", btnRemember);
        }
    }
}