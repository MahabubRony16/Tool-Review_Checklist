using ReviewCheckList.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace ReviewCheckList
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            ThemeSelect(Properties.Settings.Default.Theme);
            lblUserName.Text = Properties.Settings.Default.User_Name;
            lblProjectNameValue.Text = Properties.Settings.Default.Project_Name;
            lblProjectIdValue.Text = Properties.Settings.Default.Project_Id;
            lblReviewDateValue.Text = DateTime.Today.ToShortDateString();
            btnUserInput.Enabled = false;
            if (Properties.Settings.Default.IsFileSaved)
            { OpenSavedFile(); }
            ucReport.Hide();
        }
        //Main UI input
        public string taskId = "";
        private string redmineId = "";
        private string documentLink = "";
        private string taskOwnerName = "";
        //private string reviewedBy = "";
        //
        public static bool userInput=false;
        int itemNumber = 0;
        public static bool isFileSaved = false;
        public static string reviewStatus = "";
        
        public static List<string> items = new List<string>();
        public static List<string> header = new List<string>();
        public static List<ItemProperties> lstItems = new List<ItemProperties>();

        
        

        private void btnUserInput_Click(object sender, EventArgs e)
        {
            //----------------CONTROL ITEM LIST INPUT---------------------
            if (txtItemList.Text.Length !=0)
            {
                List<string> itemList = new List<string>();
                itemList = txtItemList.Text.Replace("\r", "").Split('\n').ToList();
                int addedItem = 0;
                int totalItem = 0;
                for (int m = 0; m < itemList.Count; m++)
                {
                    if (!items.Contains(itemList[m]))
                    {
                        items.Add(itemList[m]);
                        cmbItemList.Items.Add(itemList[m]);
                        
                        addedItem += 1;
                    }
                    totalItem += 1;
                }
                for (int it=totalItem-addedItem;it<=totalItem;it++)
                {
                    EmptyItemProp(it);
                }
            }
            //------------------CHECK LIST VISIBILITY---------------------
            ucReport.Hide();
            pnlCheckList.Visible = true;
            pnlCheckList.Enabled = true;
            pnlSide.Top = btnChecklist.Top;
            pnlSide.Height = btnChecklist.Height;
            lblDocumentIdValue.Text = items[itemNumber];
            //-----------------TICKET INFORMATION TO LIST-----------------
            if (!userInput)
            {
                header.Add(Properties.Settings.Default.Project_Id);
                header.Add(Properties.Settings.Default.Project_Name);
                header.Add(txtTaskId.Text.ToUpper());
                header.Add(txtDocumentLink.Text);
                header.Add(txtTaskOwnerName.Text);
                header.Add(txtRedmineId.Text);
                header.Add("N/A");
                header.Add(lblReviewDateValue.Text);
                header.Add("");
                header.Add(Properties.Settings.Default.User_Name);
            }
            else
            {
                header[0] = Properties.Settings.Default.Project_Id;
                header[1] = Properties.Settings.Default.Project_Name;
                header[2] = txtTaskId.Text.ToUpper();
                header[3] = txtDocumentLink.Text;
                header[4] = txtTaskOwnerName.Text;
                header[5] = txtRedmineId.Text;
                header[6] = "N/A";
                header[7] = lblReviewDateValue.Text;
                header[8] = "";
                header[9] = Properties.Settings.Default.User_Name;

            }
            userInput = true;
            ucReport.FileName();
            OutputItemProp(itemNumber);
            btnOpenFile.Enabled = false;
        }
        //-----------------HOME TAB---------------
        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlCheckList.Visible = false;
            pnlSide.Top = btnHome.Top;
            pnlSide.Height = btnHome.Height;
            if (userInput)
            {
                OutputItemProp(itemNumber);
                InputItemProp(itemNumber);
                ReviewStatusValue();
            }

        }
        //-----------------CHECKLIST TAB---------------
        private void btnCheckList_Click(object sender, EventArgs e)
        {
            ucReport.Hide();
            pnlCheckList.Show();
            pnlCheckList.BringToFront();
            pnlSide.Top = btnChecklist.Top;
            pnlSide.Height = btnChecklist.Height;
            if (userInput == false)
            {
                pnlCheckList.Enabled = false;
            }
            else
            {
                pnlCheckList.Enabled = true;
                OutputItemProp(itemNumber);
                lblDocumentIdValue.Text = items[itemNumber];
            }
            
        }
        //-----------------------REPORT TAB--------------------------
        private void btnReport_Click(object sender, EventArgs e)
        {
            pnlSide.Top = btnReport.Top;
            pnlSide.Height = btnReport.Height;
            pnlCheckList.Show();
            ucReport.Show();
            ucReport.BringToFront();
            //pnlCheckList.Hide();


            if (userInput == false)
            {
                ucReport.Enabled = false;
                pnlCheckList.Enabled = false;
            }
            else
            {
                ucReport.Enabled = true;
                OutputItemProp(itemNumber);
                InputItemProp(itemNumber);
                
                ReviewStatusValue();
                header[8] = lblReviewStatusValue.Text;
            }
            ucReport.pcDone.Hide();
            ucReport.FileName();
            ucReport.btnSave.Enabled = true;
            ucReport.btnSaveWarning();
        }

        //-------------------------NEXT BUTTON--------------------------
        private void btnNext_Click(object sender, EventArgs e)
        {
            InputItemProp(itemNumber);
            itemNumber++;
            if (itemNumber == items.Count)
            {
                itemNumber = itemNumber - 1;
                pnlSide.Top = btnReport.Top;
                pnlSide.Height = btnReport.Height;
                pnlCheckList.Show();
                ucReport.Show();
                ucReport.BringToFront();
                ucReport.Enabled = true;
                ReviewStatusValue();
                header[8] = lblReviewStatusValue.Text;
                ucReport.btnSaveWarning();
            }
            else if (itemNumber == items.Count - 1)
            {
                CheckBoxClear();
                lblDocumentIdValue.Text = items[itemNumber];
                OutputItemProp(itemNumber);
            }
            else
            {
                CheckBoxClear();
                lblDocumentIdValue.Text = items[itemNumber];
                OutputItemProp(itemNumber);
            }
            btnPrevious.Enabled = true;
            ucReport.pcDone.Hide();
            ucReport.btnSave.Enabled = true;
            cmbItemList.SelectedIndex = itemNumber;
        }
        //-------------------------PREVIOUS BUTTON--------------------------
        private void btnPrevious_Click(object sender, EventArgs e)
        {

            if (itemNumber > 0)
            {
                InputItemProp(itemNumber);
                itemNumber = itemNumber - 1;
                CheckBoxClear();
                lblDocumentIdValue.Text = items[itemNumber];
                OutputItemProp(itemNumber);
                pnlSide.Top = btnChecklist.Top;
                pnlSide.Height = btnChecklist.Height;
            }
            else
            {
                InputItemProp(itemNumber);
                lblDocumentIdValue.Text = items[itemNumber];
                OutputItemProp(itemNumber);
                pnlCheckList.Visible = false;
                pnlSide.Top = btnHome.Top;
                pnlSide.Height = btnHome.Height;
            }

            btnNext.Enabled = true;
            ReviewStatusValue();
            cmbItemList.SelectedIndex = itemNumber;
        }

        public bool IsOk()
        {
            

            if (cbNotOK1.Checked || cbNotOK2.Checked || cbNotOK3.Checked || cbNotOK4.Checked || cbNotOK5.Checked || cbNotOK6.Checked || cbNotOK8.Checked || cbNotOK8.Checked)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        //---------------------CHECKBOXES------------------------
        private void cbAllOK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllOK.Checked)
            {
                //CheckBoxClear();
                AllOKCheckBoxClear();
                cbOK1.Checked = cbOK2.Checked = cbOK3.Checked = cbOK4.Checked = cbOK5.Checked = cbOK6.Checked = cbOK7.Checked = cbOK8.Checked = true;
                //cbAllOK.Checked = true;
            }
            else
            {
                //AllOKCheckBoxClear();
                cbAllOK.Checked = false;
            }
        }
        //---------------------CHECKBOX_OK------------------------------
        private void cbOK1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOK1.Checked)
            {cbNotOK1.Enabled = false; cbNA1.Enabled = false; }
            else { cbNotOK1.Enabled = true; cbNA1.Enabled = true; cbAllOK.Checked = false; }
        }
        private void cbOK2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOK2.Checked)
            { cbNotOK2.Enabled = false; cbNA2.Enabled = false; }
            else { cbNotOK2.Enabled = true; cbNA2.Enabled = true; cbAllOK.Checked = false; }
        }
        private void cbOK4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOK4.Checked)
            { cbNotOK4.Enabled = false; cbNA4.Enabled = false; }
            else { cbNotOK4.Enabled = true; cbNA4.Enabled = true; cbAllOK.Checked = false; }

        }
        private void cbOK3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOK3.Checked)
            { cbNotOK3.Enabled = false; cbNA3.Enabled = false; }
            else { cbNotOK3.Enabled = true; cbNA3.Enabled = true; cbAllOK.Checked = false; }

        }
        private void cbOK5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOK5.Checked)
            { cbNotOK5.Enabled = false; cbNA5.Enabled = false; }
            else { cbNotOK5.Enabled = true; cbNA5.Enabled = true; cbAllOK.Checked = false; }
        }
        private void cbOK6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOK6.Checked)
            { cbNotOK6.Enabled = false; cbNA6.Enabled = false; }
            else { cbNotOK6.Enabled = true; cbNA6.Enabled = true; cbAllOK.Checked = false; }
        }
        private void cbOK7_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOK7.Checked)
            { cbNotOK7.Enabled = false; cbNA7.Enabled = false; }
            else { cbNotOK7.Enabled = true; cbNA7.Enabled = true; cbAllOK.Checked = false; }
        }
        private void cbOK8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOK8.Checked)
            { cbNotOK8.Enabled = false; cbNA8.Enabled = false; }
            else { cbNotOK8.Enabled = true; cbNA8.Enabled = true; cbAllOK.Checked = false; }
        }
        //---------------------CHECKBOX_NOTOK------------------------------
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNotOK2.Checked)
            { cbOK2.Enabled = false; cbNA2.Enabled = false; }
            else { cbOK2.Enabled = true; cbNA2.Enabled = true; }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNA2.Checked)
            { cbOK2.Enabled = false; cbNotOK2.Enabled = false; }
            else { cbOK2.Enabled = true; cbNotOK2.Enabled = true; }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNA1.Checked)
            { cbOK1.Enabled = false; cbNotOK1.Enabled = false; }
            else { cbOK1.Enabled = true; cbNotOK1.Enabled = true; }
        }
        private void cbNotOK1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNotOK1.Checked)
            { cbOK1.Enabled = false; cbNA1.Enabled = false; }
            else { cbOK1.Enabled = true; cbNA1.Enabled = true; }
        }
        private void cbNotOK7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbNotOK7.Checked)
            { cbOK7.Enabled = false; cbNA7.Enabled = false; }
            else { cbOK7.Enabled = true; cbNA7.Enabled = true; }
        }
        private void cbNotOK3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNotOK3.Checked)
            { cbOK3.Enabled = false; cbNA3.Enabled = false; }
            else { cbOK3.Enabled = true; cbNA3.Enabled = true; }
        }
        private void cbNotOK4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNotOK4.Checked)
            { cbOK4.Enabled = false; cbNA4.Enabled = false; }
            else { cbOK4.Enabled = true; cbNA4.Enabled = true; }

        }
        private void cbNotOK5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbNotOK5.Checked)
            { cbOK5.Enabled = false; cbNA5.Enabled = false; }
            else { cbOK5.Enabled = true; cbNA5.Enabled = true; }
        }
        private void cbNotOK6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNotOK6.Checked)
            { cbOK6.Enabled = false; cbNA6.Enabled = false; }
            else { cbOK6.Enabled = true; cbNA6.Enabled = true; }
        }
        private void cbNotOK8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNotOK8.Checked)
            { cbOK8.Enabled = false; cbNA8.Enabled = false; }
            else { cbOK8.Enabled = true; cbNA8.Enabled = true; }
        }
        //---------------------CHECKBOX_NA------------------------------
        private void cbNA3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNA3.Checked)
            { cbOK3.Enabled = false; cbNotOK3.Enabled = false; }
            else { cbOK3.Enabled = true; cbNotOK3.Enabled = true; }
        }
        private void cbNA4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNA4.Checked)
            { cbOK4.Enabled = false; cbNotOK4.Enabled = false; }
            else { cbOK4.Enabled = true; cbNotOK4.Enabled = true; }
        }
        private void cbNA5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNA5.Checked)
            { cbOK5.Enabled = false; cbNotOK5.Enabled = false; }
            else { cbOK5.Enabled = true; cbNotOK5.Enabled = true; }
        }
        private void cbNA6_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNA6.Checked)
            { cbOK6.Enabled = false; cbNotOK6.Enabled = false; }
            else { cbOK6.Enabled = true; cbNotOK6.Enabled = true; }
        }
        private void cbNA7_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNA7.Checked)
            { cbOK7.Enabled = false; cbNotOK7.Enabled = false; }
            else { cbOK7.Enabled = true; cbNotOK7.Enabled = true; }
        }
        private void cbNA8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNA8.Checked)
            { cbOK8.Enabled = false; cbNotOK8.Enabled = false; }
            else { cbOK8.Enabled = true; cbNotOK8.Enabled = true; }
        }

        //---------------------SETTINGS------------------------------
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingInformation settingInformation = new SettingInformation();
            settingInformation.ShowDialog();
            if (settingInformation.IsOkPressed)
            {
                lblUserName.Text = Properties.Settings.Default.User_Name;
            }
            if (settingInformation.IsOkPressed)
            {
                lblProjectNameValue.Text = Properties.Settings.Default.Project_Name;
            }
            if (settingInformation.IsOkPressed)
            {
                lblProjectIdValue.Text = Properties.Settings.Default.Project_Id;
            }
            ThemeSelect(Properties.Settings.Default.Theme);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void CheckBoxCheck(string status, CheckBox cbOK, CheckBox cbKO, CheckBox cbNA)
        {
            //string status = "";
            if (status == "OK")
            {
                cbOK.Checked = true;
                cbKO.Enabled = false;
                cbNA.Enabled = false;
            }
            else if (status == "Not OK")
            {
                cbOK.Enabled = false;
                cbKO.Checked = true;
                cbNA.Enabled = false;
            }
            else if (status == "Not Applicable")
            {
                cbOK.Enabled = false;
                cbKO.Enabled = false;
                cbNA.Checked = true;
            }
            else
            {
                cbOK.Enabled = true;
                cbKO.Enabled = true;
                cbNA.Enabled = true;
            }
        }
        public string CheckBoxStatus(CheckBox cbOK, CheckBox cbKO, CheckBox cbNA)
        {
            if (cbOK.Checked == true)
            {
                return "OK";
            }
            else if (cbKO.Checked == true)
            {
                return "Not OK";
            }
            else if (cbNA.Checked == true)
            {
                return "Not Applicable";
            }
            else
            {
                return "";
            }
        }
        public void CheckBoxClear()
        {
            //OK
            cbOK1.Checked = cbOK2.Checked = cbOK3.Checked = cbOK4.Checked = cbOK5.Checked = cbOK6.Checked = cbOK7.Checked = cbOK8.Checked = false;

            cbOK1.Enabled = cbOK2.Enabled = cbOK3.Enabled = cbOK4.Enabled = cbOK5.Enabled = cbOK6.Enabled = cbOK7.Enabled = cbOK8.Enabled = true;
            //Not OK
            cbNotOK1.Checked = cbNotOK2.Checked = cbNotOK3.Checked = cbNotOK4.Checked = cbNotOK5.Checked = cbNotOK6.Checked = cbNotOK7.Checked = cbNotOK8.Checked = false;

            cbNotOK1.Enabled = cbNotOK2.Enabled = cbNotOK3.Enabled = cbNotOK4.Enabled = cbNotOK5.Enabled = cbNotOK6.Enabled = cbNotOK7.Enabled = cbNotOK8.Enabled = true;
            //Not Available
            cbNA1.Checked = cbNA2.Checked = cbNA3.Checked = cbNA4.Checked = cbNA5.Checked = cbNA6.Checked = cbNA7.Checked = cbNA8.Checked = false;

            cbNA1.Enabled = cbNA2.Enabled = cbNA3.Enabled = cbNA4.Enabled = cbNA5.Enabled = cbNA6.Enabled = cbNA7.Enabled = cbNA8.Enabled = true;

            //cbAllOK.Checked = false;
        }
        public void AllOKCheckBoxClear()
        {
            //cbOK1.Checked = cbOK2.Checked = cbOK3.Checked = cbOK4.Checked = cbOK5.Checked = cbOK6.Checked = cbOK7.Checked = cbOK8.Checked = false;

            //cbOK1.Enabled = cbOK2.Enabled = cbOK3.Enabled = cbOK4.Enabled = cbOK5.Enabled = cbOK6.Enabled = cbOK7.Enabled = cbOK8.Enabled = true;

            //Not OK
            cbNotOK1.Checked = cbNotOK2.Checked = cbNotOK3.Checked = cbNotOK4.Checked = cbNotOK5.Checked = cbNotOK6.Checked = cbNotOK7.Checked = cbNotOK8.Checked = false;

            //cbNotOK1.Enabled = cbNotOK2.Enabled = cbNotOK3.Enabled = cbNotOK4.Enabled = cbNotOK5.Enabled = cbNotOK6.Enabled = cbNotOK7.Enabled = cbNotOK8.Enabled = true;
            //Not Available
            cbNA1.Checked = cbNA2.Checked = cbNA3.Checked = cbNA4.Checked = cbNA5.Checked = cbNA6.Checked = cbNA7.Checked = cbNA8.Checked = false;

            //cbNA1.Enabled = cbNA2.Enabled = cbNA3.Enabled = cbNA4.Enabled = cbNA5.Enabled = cbNA6.Enabled = cbNA7.Enabled = cbNA8.Enabled = true;

            //cbAllOK.Checked = false;
        }
        public void ClearText()
        {
            txtCS.Text = string.Empty;
            txtTransfer.Text = string.Empty;
            txtLatest.Text = string.Empty;
            txtVersion.Text = string.Empty;
            txtDrawing.Text = string.Empty;
            txtEnCon.Text = string.Empty;
            txtCheckRep.Text = string.Empty;
            txtOthers.Text = string.Empty;
        }
        private void txtItemList_TextChanged(object sender, EventArgs e)
        {
            btnUserInput.Enabled = true;
        }
        private void txtItemList_LostFocus(object sender, EventArgs e)
        {
            //MessageBox.Show("Hey");
            if (String.IsNullOrEmpty(txtItemList.Text))
            {
                btnUserInput.Enabled = false;
                //MessageBox.Show("Hey");
            }
            else
            {
                btnUserInput.Enabled = true;
            }

        }
        InputValidity InputValidity = new InputValidity();
        private void txtTaskId_LostFocus(object sender, EventArgs e)
        {

            if (InputValidity.IsTaskIdValid(txtTaskId.Text))
            {   taskId = txtTaskId.Text;
                lblTaskIdError.Visible = false;
            }
            else 
            {
                lblTaskIdError.Visible = true;
            }
            ErrorMessageVisible();
        }
        
        private void txtRedmineId_LostFocus(object sender, EventArgs e)
        {
            if (InputValidity.IsRedmineIdValid(txtRedmineId.Text))
            {
                redmineId = txtRedmineId.Text;
                lblRedmineIdError.Visible = false;
                //txtRedmineId.BackColor = Color.FromArgb(53, 55, 59);
            }
            else
            {
                //txtRedmineId.BackColor = Color.FromArgb(59, 49, 49);
                lblRedmineIdError.Visible = true;
            }
            ErrorMessageVisible();

        }
        private void txtDocumentLink_LostFocus(object sender, EventArgs e)
        {
            if (InputValidity.IsDocumentlinkValid(txtDocumentLink.Text))
            {
                documentLink = txtDocumentLink.Text;
                lblDocumentLinkError.Visible = false;
                //txtDocumentLink.BackColor = Color.FromArgb(53, 55, 59);
            }
            else
            {
                //txtDocumentLink.BackColor = Color.FromArgb(59, 49, 49);
                lblDocumentLinkError.Visible = true;
            }
            ErrorMessageVisible();

        }
        private void ErrorMessageVisible()
        {
            if (lblDocumentLinkError.Visible || lblTaskIdError.Visible || lblRedmineIdError.Visible)
            {
                lblError.Visible = true;
            }
            else
            {
                lblError.Visible = false;
            }
        }

        //NEW CODE
        
        public void InputItemProp(int i)
        {
            lstItems.Add(new ItemProperties());
            lstItems[i].DocumentId = items[i];
            lstItems[i].CollaborativeSpace = txtCS.Text;
            lstItems[i].TransferType = txtTransfer.Text;
            lstItems[i].Latest = txtLatest.Text;
            lstItems[i].Version = txtVersion.Text;
            lstItems[i].DrawingOpening = txtDrawing.Text;
            lstItems[i].EngineeringConnections = txtEnCon.Text;
            lstItems[i].CheckRepresentation = txtCheckRep.Text;
            lstItems[i].Other = txtOthers.Text;
            lstItems[i].CbCollaborativeSpace = CheckBoxStatus(cbOK1, cbNotOK1, cbNA1);
            lstItems[i].CbTransferType = CheckBoxStatus(cbOK2, cbNotOK2, cbNA2);
            lstItems[i].CbLatest = CheckBoxStatus(cbOK3, cbNotOK3, cbNA3);
            lstItems[i].CbVersion = CheckBoxStatus(cbOK4, cbNotOK4, cbNA4);
            lstItems[i].CbDrawingOpening = CheckBoxStatus(cbOK5, cbNotOK5, cbNA5);
            lstItems[i].CbEngineeringConnectionst = CheckBoxStatus(cbOK6, cbNotOK6, cbNA6);
            lstItems[i].CbCheckRepresentation = CheckBoxStatus(cbOK7, cbNotOK7, cbNA7);
            lstItems[i].CbOther = CheckBoxStatus(cbOK8, cbNotOK8, cbNA8);
        }
        public void OutputItemProp(int i)
        {
            lstItems.Add(new ItemProperties());
            //lblDocumentIdValue.Text = lstItems[i].DocumentId;
            txtCS.Text = lstItems[i].CollaborativeSpace;
            txtTransfer.Text = lstItems[i].TransferType;
            txtLatest.Text = lstItems[i].Latest;
            txtVersion.Text = lstItems[i].Version;
            txtDrawing.Text = lstItems[i].DrawingOpening;
            txtEnCon.Text = lstItems[i].EngineeringConnections;
            txtCheckRep.Text = lstItems[i].CheckRepresentation;
            txtOthers.Text = lstItems[i].Other;
            CheckBoxCheck(lstItems[i].CbCollaborativeSpace, cbOK1, cbNotOK1, cbNA1);
            CheckBoxCheck(lstItems[i].CbTransferType, cbOK2, cbNotOK2, cbNA2);
            CheckBoxCheck(lstItems[i].CbLatest, cbOK3, cbNotOK3, cbNA3);
            CheckBoxCheck(lstItems[i].CbVersion, cbOK4, cbNotOK4, cbNA4);
            CheckBoxCheck(lstItems[i].CbDrawingOpening, cbOK5, cbNotOK5, cbNA5);
            CheckBoxCheck(lstItems[i].CbEngineeringConnectionst, cbOK6, cbNotOK6, cbNA6);
            CheckBoxCheck(lstItems[i].CbCheckRepresentation, cbOK7, cbNotOK7, cbNA7);
            CheckBoxCheck(lstItems[i].CbOther, cbOK8, cbNotOK8, cbNA8);
        }
        public void EmptyItemProp(int i)
        {
            lstItems.Add(new ItemProperties());
            lstItems[i].DocumentId = "";
            lstItems[i].CollaborativeSpace = "";
            lstItems[i].TransferType = "";
            lstItems[i].Latest = "";
            lstItems[i].Version = "";
            lstItems[i].DrawingOpening = "";
            lstItems[i].EngineeringConnections = "";
            lstItems[i].CheckRepresentation = "";
            lstItems[i].Other = "";
            lstItems[i].CbCollaborativeSpace = "";
            lstItems[i].CbTransferType = "";
            lstItems[i].CbLatest = "";
            lstItems[i].CbVersion = "";
            lstItems[i].CbDrawingOpening = "";
            lstItems[i].CbEngineeringConnectionst = "";
            lstItems[i].CbCheckRepresentation = "";
            lstItems[i].CbOther = "";
        }



        private void ReviewStatusValue()
        {
            int count = 0;
            int notOKCount = 0;
            for(int j=0;j<=(items.Count-1);j++)
            {
                if (lstItems[j].CbCollaborativeSpace == "" || lstItems[j].CbTransferType == "" || lstItems[j].CbLatest == "" || lstItems[j].CbVersion == "" || lstItems[j].CbDrawingOpening == "" || lstItems[j].CbEngineeringConnectionst == "" || lstItems[j].CbCheckRepresentation == "" || lstItems[j].CbOther == "")
                { 
                    count= count+1; 
                }
                else if(lstItems[j].CbCollaborativeSpace == "Not OK" || lstItems[j].CbTransferType == "Not OK" || lstItems[j].CbLatest == "Not OK" || lstItems[j].CbVersion == "Not OK" || lstItems[j].CbDrawingOpening == "Not OK" || lstItems[j].CbEngineeringConnectionst == "Not OK" || lstItems[j].CbCheckRepresentation == "Not OK" || lstItems[j].CbOther == "Not OK")
                { notOKCount = notOKCount + 1; }
            }
            if (count>0)
            { lblReviewStatusValue.Text = "WIP";
              lblReviewStatusValue.ForeColor = Color.Orange;
            }
            else if (notOKCount>0)
            { lblReviewStatusValue.Text = "FAILED";
              lblReviewStatusValue.ForeColor = Color.Red;
            }
            else
            { lblReviewStatusValue.Text = "PASSED";
              lblReviewStatusValue.ForeColor = Color.Green;
            }
            reviewStatus = lblReviewStatusValue.Text;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ReviewStatusValue();
        //}

        
        Point lastpointMain;
        Point lastPointSidePanel;
        Point lastPositionChecklistPanel;
        private void MainUI_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                this.Left += e.X - lastpointMain.X;
                this.Top += e.Y - lastpointMain.Y;
            }
        }

        private void MainUI_MouseDown(object sender, MouseEventArgs e)
        {
            lastpointMain = new Point(e.X, e.Y);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPointSidePanel.X;
                this.Top += e.Y - lastPointSidePanel.Y;
            }
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointSidePanel= new Point(e.X, e.Y);
        }

        private void pnlCheckList_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPositionChecklistPanel.X;
                this.Top += e.Y - lastPositionChecklistPanel.Y;
            }
        }

        private void pnlCheckList_MouseDown(object sender, MouseEventArgs e)
        {
            lastPositionChecklistPanel= new Point(e.X, e.Y);
        }
        private void ThemeSelect(string theme)
        {
            if(theme=="Light")
            {
                ThemeLight();
            }
            else
            {
                ThemeDark();
            }
        }
        private void ThemeLight()
        {
            //Label Fore Color
            lblCollaborativeSpace.ForeColor = lblDocumentId.ForeColor = lblDocumentIdValue.ForeColor = lblCheckRepresentation.ForeColor = lblDocumentLink.ForeColor = lblDrawing.ForeColor = lblEngineeringConnections.ForeColor = lblItemList.ForeColor = lblLatest.ForeColor = lblOthers.ForeColor = lblProject.ForeColor = lblProjectId.ForeColor = lblProjectIdValue.ForeColor = lblProjectNameValue.ForeColor = lblRedmineId.ForeColor = lblReviewDate.ForeColor = lblReviewDateValue.ForeColor = lblReviewStatus.ForeColor = lblTaskOwnerName.ForeColor = lblTransferType.ForeColor = lblVersion.ForeColor = lblServicenowDbdiIssues.ForeColor = lblOk.ForeColor = lblNotOk.ForeColor = lblNA.ForeColor = lblComment.ForeColor = lblTaskId.ForeColor = cbAllOK.ForeColor = Color.Black;
            //Label Back Color
            this.BackColor = Color.FromArgb(255, 255, 255);
            btnClose.FlatAppearance.BorderColor = btnMinimize.FlatAppearance.BorderColor = btnNext.FlatAppearance.BorderColor = btnPrevious.FlatAppearance.BorderColor = btnUserInput.FlatAppearance.BorderColor = Color.White;
            btnNext.FlatAppearance.MouseOverBackColor = btnPrevious.FlatAppearance.MouseOverBackColor = btnUserInput.FlatAppearance.MouseOverBackColor = Color.FromArgb(181, 181, 181);
            // TextBox Fore Color
            txtCheckRep.ForeColor = txtCS.ForeColor = txtDrawing.ForeColor = txtDocumentLink.ForeColor = txtEnCon.ForeColor = txtItemList.ForeColor = txtLatest.ForeColor = txtOthers.ForeColor = txtRedmineId.ForeColor = txtTaskId.ForeColor = txtTaskOwnerName.ForeColor = txtTransfer.ForeColor = txtVersion.ForeColor = lblItems.ForeColor = cmbItemList.ForeColor = Color.Black;
            //TextBox Back Color
            txtCheckRep.BackColor = txtCS.BackColor = txtDrawing.BackColor = txtDocumentLink.BackColor = txtEnCon.BackColor = txtItemList.BackColor = txtLatest.BackColor = txtOthers.BackColor = txtRedmineId.BackColor = txtTaskId.BackColor = txtTaskOwnerName.BackColor = txtTransfer.BackColor = txtVersion.BackColor = cmbItemList.BackColor = Color.White;
            //CheckBox Fore Color
            cbOK1.ForeColor = cbOK2.ForeColor = cbOK3.ForeColor = cbOK4.ForeColor = cbOK5.ForeColor = cbOK6.ForeColor = cbOK7.ForeColor = cbOK8.ForeColor = Color.Black;
            cbNotOK1.ForeColor = cbNotOK2.ForeColor = cbNotOK3.ForeColor = cbNotOK4.ForeColor = cbNotOK5.ForeColor = cbNotOK6.ForeColor = cbNotOK7.ForeColor = cbNotOK8.ForeColor = Color.Black;
            cbNA1.ForeColor = cbNA2.ForeColor = cbNA3.ForeColor = cbNA4.ForeColor = cbNA5.ForeColor = cbNA6.ForeColor = cbNA7.ForeColor = cbNA8.ForeColor = cbAllOK.ForeColor = Color.Black;
            cbAllOK.BackColor = Color.WhiteSmoke;
            //Side Panel
            panel1.BackColor = Color.FromArgb(0, 146, 224);
            //pnlSide.BackColor = Color.WhiteSmoke;
            lblReviewChecklist.ForeColor = Color.FromArgb(0, 146, 224);
            //btnHome.BackColor = Color.FromArgb(0, 118, 181);
            //btnChecklist.BackColor = Color.FromArgb(0, 146, 224);
            btnSettings.BackColor = Color.FromArgb(0, 146, 224);
            btnHome.FlatAppearance.MouseOverBackColor = btnChecklist.FlatAppearance.MouseOverBackColor = btnSettings.FlatAppearance.MouseOverBackColor = btnReport.FlatAppearance.MouseOverBackColor = btnOpenFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 166, 255);
            ucReport.ReportThemeLight();

            btnUserInput.Image = btnNext.Image = Properties.Resources.Next_2;
            btnPrevious.Image = Properties.Resources.Previous_2;

        }
        private void ThemeDark()
        {
            //Label Fore Color
            lblCollaborativeSpace.ForeColor = lblDocumentId.ForeColor = lblDocumentIdValue.ForeColor = lblCheckRepresentation.ForeColor = lblDocumentLink.ForeColor = lblDrawing.ForeColor = lblEngineeringConnections.ForeColor = lblItemList.ForeColor = lblLatest.ForeColor = lblOthers.ForeColor = lblProject.ForeColor = lblProjectId.ForeColor = lblProjectIdValue.ForeColor = lblProjectNameValue.ForeColor = lblRedmineId.ForeColor = lblReviewDate.ForeColor = lblReviewDateValue.ForeColor = lblReviewStatus.ForeColor = lblTaskOwnerName.ForeColor = lblTransferType.ForeColor = lblVersion.ForeColor = lblServicenowDbdiIssues.ForeColor = lblOk.ForeColor = lblNA.ForeColor = lblComment.ForeColor = lblTaskId.ForeColor = cbAllOK.ForeColor = lblNotOk.ForeColor= Color.WhiteSmoke;
            //Label Back Color
            this.BackColor = ucReport.BackColor= btnClose.FlatAppearance.BorderColor = btnMinimize.FlatAppearance.BorderColor = btnNext.FlatAppearance.BorderColor = btnPrevious.FlatAppearance.BorderColor = btnUserInput.FlatAppearance.BorderColor = Color.FromArgb(35, 36, 38);
            btnNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 63, 66);
            btnPrevious.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 63, 66);
            btnUserInput.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 63, 66);
            // TextBos Fore Color
            txtCheckRep.ForeColor = txtCS.ForeColor = txtDrawing.ForeColor = txtDocumentLink.ForeColor = txtEnCon.ForeColor = txtItemList.ForeColor = txtLatest.ForeColor = txtOthers.ForeColor = txtRedmineId.ForeColor = txtTaskId.ForeColor = txtTaskOwnerName.ForeColor = txtTransfer.ForeColor = txtVersion.ForeColor = lblItems.ForeColor = cmbItemList.ForeColor = Color.White;
            //TextBox Back Color
            txtCheckRep.BackColor = txtCS.BackColor = txtDrawing.BackColor = txtDocumentLink.BackColor = txtEnCon.BackColor = txtItemList.BackColor = txtLatest.BackColor = txtOthers.BackColor = txtRedmineId.BackColor = txtTaskId.BackColor = txtTaskOwnerName.BackColor = txtTransfer.BackColor = txtVersion.BackColor = cmbItemList.BackColor = Color.FromArgb(53, 55, 59);
            cbAllOK.BackColor = Color.FromArgb(35, 36, 38);
            //CheckBox Fore Color
            cbOK1.ForeColor = cbOK2.ForeColor = cbOK3.ForeColor = cbOK4.ForeColor = cbOK5.ForeColor = cbOK6.ForeColor = cbOK7.ForeColor = cbOK8.ForeColor = cbNotOK1.ForeColor = cbNotOK2.ForeColor = cbNotOK3.ForeColor = cbNotOK4.ForeColor = cbNotOK5.ForeColor = cbNotOK6.ForeColor = cbNotOK7.ForeColor = cbNotOK8.ForeColor = cbNA1.ForeColor = cbNA2.ForeColor = cbNA3.ForeColor = cbNA4.ForeColor = cbNA5.ForeColor = cbNA6.ForeColor = cbNA7.ForeColor = cbNA8.ForeColor = cbAllOK.ForeColor = Color.White;
            //Side Panel
            panel1.BackColor = Color.FromArgb(5, 133, 168);
            btnSettings.BackColor = Color.FromArgb(5, 133, 168);
            lblReviewChecklist.ForeColor = Color.FromArgb(5, 133, 168);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 93, 117);
            btnChecklist.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 93, 117);
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 93, 117);
            btnOpenFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 93, 117);
            btnReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 93, 117);
            ucReport.ReportThemeDark();
            //Button Image
            btnUserInput.Image =btnNext.Image= Properties.Resources.Next_Dark;
            btnPrevious.Image = Properties.Resources.Previous_Dark;
        }

        private void cmbItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckBoxClear();
            lblDocumentIdValue.Text = items[cmbItemList.SelectedIndex];
            itemNumber = cmbItemList.SelectedIndex;
            OutputItemProp(itemNumber);
            btnNext.Enabled = true;
        }
        

        public List<string> Header()
        {
            return header;
        }

        private void btnSaveForLater_Click(object sender, EventArgs e)
        {

        }
        

        public void OpenSavedFile()
        {
            SavedFileOpen savedFileOpen = new SavedFileOpen();
            savedFileOpen.Message($"File Name: {Properties.Settings.Default.SavedFileName}", "Continue last session?");
            savedFileOpen.ShowDialog();
            string path = Properties.Settings.Default.FolderPath;
            string fileName = Properties.Settings.Default.SavedFileName;

            if (savedFileOpen.isOkPressed)
            {
                try
                {
                    Serializer serializer = new Serializer();
                    serializer.ListDeSerialize(path, fileName);
                    serializer.DeSerialize(path,fileName);
                    btnUserInput.Enabled = true;
                    for (int item = 0; item <= items.Count - 1; item++)
                    {
                        cmbItemList.Items.Add(items[item]);
                    }
                    txtTaskId.Text = header[2];
                    txtDocumentLink.Text = header[3];
                    txtTaskOwnerName.Text = header[4];
                    txtRedmineId.Text = header[5];
                    if (header[4] == "Gopal Kundu") { txtTaskOwnerName.SelectedItem = 0; }
                    else if (header[4] == "Shahinur Rahman") { txtTaskOwnerName.SelectedItem = 1; }
                    else { txtTaskOwnerName.SelectedItem = 2; }
                    string itemlist = string.Join("\r\n", items);
                    txtItemList.Text = itemlist;
                    userInput = true;
                    btnOpenFile.Enabled = false;
                }
                catch
                { MessageBox.Show("Saved file may be corrupted!"); }
                
            }

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {

                InitialDirectory = @"D:\",
                Title = "Browse xml file",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "xml",
                Filter = "xml files (*.xml)|*.xml",
                FilterIndex = 2,
                RestoreDirectory = true,
                //ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string openFilePath = openFileDialog1.FileName;
                string path = Path.GetDirectoryName(openFilePath);
                string fileName = openFileDialog1.SafeFileName.Replace(".xml","");
                //MessageBox.Show($"{path} and the file name is: {openFileDialog1.SafeFileName}");
                try
                {
                    Serializer serializer = new Serializer();
                    serializer.ListDeSerialize(path, fileName);
                    serializer.DeSerialize(path, fileName);
                    btnUserInput.Enabled = true;
                    for (int item = 0; item <= items.Count - 1; item++)
                    {
                        cmbItemList.Items.Add(items[item]);
                    }
                    txtTaskId.Text = header[2];
                    txtDocumentLink.Text = header[3];
                    txtTaskOwnerName.Text = header[4];
                    txtRedmineId.Text = header[5];
                    if (header[4] == "Gopal Kundu") { txtTaskOwnerName.SelectedItem = 0; }
                    else if (header[4] == "Shahinur Rahman") { txtTaskOwnerName.SelectedItem = 1; }
                    else { txtTaskOwnerName.SelectedItem = 2; }
                    string itemlist = string.Join("\r\n", items);
                    txtItemList.Text = itemlist;
                    userInput = true;
                    btnOpenFile.Enabled = false;
                }
                catch
                { MessageBox.Show("Saved file may be corrupted!"); }
            }
            

        }

        private void btnOpenFile_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Open previously saved file", btnOpenFile);
        }

        private void btnSettings_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Settings", btnSettings);
        }

        private void ucReport_VisibleChanged(object sender, EventArgs e)
        {
            if(ucReport.Visible==false)
            {
                pnlSide.Top = btnChecklist.Top;
                pnlSide.Height = btnChecklist.Height;
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            items.Clear();
            header.Clear();
            lstItems.Clear();
            //btnUserInput.Enabled = false;
            pnlCheckList.Enabled = false;
            ucReport.Enabled = false;
            txtTaskId.Text = "";
            txtRedmineId.Text = "";
            txtDocumentLink.Text = "";
            txtItemList.Text = "";
        }

    }
    }
