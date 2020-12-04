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
    public partial class SavedFileOpen : Form
    {
        public SavedFileOpen()
        {
            InitializeComponent();
            Theme();
        }
        public bool isOkPressed = false;

        private void btnYes_Click(object sender, EventArgs e)
        {
            isOkPressed = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Theme()
        {
            if(Properties.Settings.Default.Theme=="Light")
            {
                this.BackColor = Color.White;
                lblFileName.ForeColor = Color.Black;
                lblTop.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.FromArgb(35, 36, 38);
                lblFileName.ForeColor = Color.WhiteSmoke;
                lblTop.ForeColor = Color.WhiteSmoke;
            }
        }
        public void Message(string mssg, string topMssg)
        {
            lblTop.Text = topMssg;
            lblFileName.Text = mssg;
        }
    }
}
