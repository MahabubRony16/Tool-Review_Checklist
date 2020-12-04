using System.Windows.Forms;

namespace ReviewCheckList
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnChecklist = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblTaskId = new System.Windows.Forms.Label();
            this.lblRedmineId = new System.Windows.Forms.Label();
            this.lblDocumentLink = new System.Windows.Forms.Label();
            this.lblItemList = new System.Windows.Forms.Label();
            this.lblTaskOwnerName = new System.Windows.Forms.Label();
            this.lblDocumentLinkError = new System.Windows.Forms.Label();
            this.lblRedmineIdError = new System.Windows.Forms.Label();
            this.lblTaskIdError = new System.Windows.Forms.Label();
            this.txtTaskOwnerName = new System.Windows.Forms.ComboBox();
            this.txtDocumentLink = new System.Windows.Forms.TextBox();
            this.txtRedmineId = new System.Windows.Forms.TextBox();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.txtItemList = new System.Windows.Forms.TextBox();
            this.lblProjectId = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblReviewDate = new System.Windows.Forms.Label();
            this.lblReviewStatus = new System.Windows.Forms.Label();
            this.pnlCheckList = new System.Windows.Forms.Panel();
            this.ucReport = new ReviewCheckList.Report();
            this.lblItems = new System.Windows.Forms.Label();
            this.cmbItemList = new System.Windows.Forms.ComboBox();
            this.lblDocumentIdValue = new System.Windows.Forms.Label();
            this.lblDocumentId = new System.Windows.Forms.Label();
            this.txtOthers = new System.Windows.Forms.TextBox();
            this.cbNA8 = new System.Windows.Forms.CheckBox();
            this.cbNotOK8 = new System.Windows.Forms.CheckBox();
            this.cbOK8 = new System.Windows.Forms.CheckBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbAllOK = new System.Windows.Forms.CheckBox();
            this.lblNA = new System.Windows.Forms.Label();
            this.lblNotOk = new System.Windows.Forms.Label();
            this.lblOk = new System.Windows.Forms.Label();
            this.txtEnCon = new System.Windows.Forms.TextBox();
            this.txtCheckRep = new System.Windows.Forms.TextBox();
            this.txtDrawing = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtLatest = new System.Windows.Forms.TextBox();
            this.txtTransfer = new System.Windows.Forms.TextBox();
            this.txtCS = new System.Windows.Forms.TextBox();
            this.cbNA7 = new System.Windows.Forms.CheckBox();
            this.cbNotOK7 = new System.Windows.Forms.CheckBox();
            this.cbOK7 = new System.Windows.Forms.CheckBox();
            this.cbNA6 = new System.Windows.Forms.CheckBox();
            this.cbNotOK6 = new System.Windows.Forms.CheckBox();
            this.cbOK6 = new System.Windows.Forms.CheckBox();
            this.cbNA5 = new System.Windows.Forms.CheckBox();
            this.cbNotOK5 = new System.Windows.Forms.CheckBox();
            this.cbOK5 = new System.Windows.Forms.CheckBox();
            this.cbNA4 = new System.Windows.Forms.CheckBox();
            this.cbNotOK4 = new System.Windows.Forms.CheckBox();
            this.cbOK4 = new System.Windows.Forms.CheckBox();
            this.cbNA3 = new System.Windows.Forms.CheckBox();
            this.cbNotOK3 = new System.Windows.Forms.CheckBox();
            this.cbOK3 = new System.Windows.Forms.CheckBox();
            this.cbNA2 = new System.Windows.Forms.CheckBox();
            this.cbNotOK2 = new System.Windows.Forms.CheckBox();
            this.cbOK2 = new System.Windows.Forms.CheckBox();
            this.cbNA1 = new System.Windows.Forms.CheckBox();
            this.cbNotOK1 = new System.Windows.Forms.CheckBox();
            this.cbOK1 = new System.Windows.Forms.CheckBox();
            this.lblCheckRepresentation = new System.Windows.Forms.Label();
            this.lblEngineeringConnections = new System.Windows.Forms.Label();
            this.lblDrawing = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblLatest = new System.Windows.Forms.Label();
            this.lblTransferType = new System.Windows.Forms.Label();
            this.lblCollaborativeSpace = new System.Windows.Forms.Label();
            this.lblOthers = new System.Windows.Forms.Label();
            this.lblReviewChecklist = new System.Windows.Forms.Label();
            this.lblServicenowDbdiIssues = new System.Windows.Forms.Label();
            this.lblProjectIdValue = new System.Windows.Forms.Label();
            this.lblReviewStatusValue = new System.Windows.Forms.Label();
            this.lblReviewDateValue = new System.Windows.Forms.Label();
            this.lblProjectNameValue = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUserInput = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCheckList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(93)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.pnlSide);
            this.panel1.Controls.Add(this.btnChecklist);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 411);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnOpenFile.Image = global::ReviewCheckList.Properties.Resources.Folder2;
            this.btnOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFile.Location = new System.Drawing.Point(71, 358);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(33, 33);
            this.btnOpenFile.TabIndex = 8;
            this.btnOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            this.btnOpenFile.MouseHover += new System.EventHandler(this.btnOpenFile_MouseHover);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnReport.Image = global::ReviewCheckList.Properties.Resources.report_small;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(12, 208);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(112, 60);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "      Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserName.Location = new System.Drawing.Point(0, 61);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(124, 15);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::ReviewCheckList.Properties.Resources.user;
            this.pictureBox1.Image = global::ReviewCheckList.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSettings.Image = global::ReviewCheckList.Properties.Resources.settings2;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(16, 358);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(33, 33);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseHover += new System.EventHandler(this.btnSettings_MouseHover);
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.pnlSide.Location = new System.Drawing.Point(0, 88);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(12, 60);
            this.pnlSide.TabIndex = 2;
            // 
            // btnChecklist
            // 
            this.btnChecklist.BackColor = System.Drawing.Color.Transparent;
            this.btnChecklist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChecklist.FlatAppearance.BorderSize = 0;
            this.btnChecklist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnChecklist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            this.btnChecklist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChecklist.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChecklist.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnChecklist.Image = global::ReviewCheckList.Properties.Resources.list__1_;
            this.btnChecklist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChecklist.Location = new System.Drawing.Point(12, 148);
            this.btnChecklist.Name = "btnChecklist";
            this.btnChecklist.Size = new System.Drawing.Size(112, 60);
            this.btnChecklist.TabIndex = 1;
            this.btnChecklist.Text = "      Checklist";
            this.btnChecklist.UseVisualStyleBackColor = false;
            this.btnChecklist.Click += new System.EventHandler(this.btnCheckList_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnHome.Image = global::ReviewCheckList.Properties.Resources.browser__1_;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 88);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 60);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "     Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblTaskId
            // 
            this.lblTaskId.AutoEllipsis = true;
            this.lblTaskId.AutoSize = true;
            this.lblTaskId.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTaskId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblTaskId.Location = new System.Drawing.Point(205, 195);
            this.lblTaskId.Name = "lblTaskId";
            this.lblTaskId.Size = new System.Drawing.Size(64, 19);
            this.lblTaskId.TabIndex = 12;
            this.lblTaskId.Text = "Task ID :";
            // 
            // lblRedmineId
            // 
            this.lblRedmineId.AutoEllipsis = true;
            this.lblRedmineId.AutoSize = true;
            this.lblRedmineId.BackColor = System.Drawing.Color.Transparent;
            this.lblRedmineId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRedmineId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedmineId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblRedmineId.Location = new System.Drawing.Point(174, 234);
            this.lblRedmineId.Name = "lblRedmineId";
            this.lblRedmineId.Size = new System.Drawing.Size(92, 19);
            this.lblRedmineId.TabIndex = 13;
            this.lblRedmineId.Text = "Redmine ID :";
            // 
            // lblDocumentLink
            // 
            this.lblDocumentLink.AutoEllipsis = true;
            this.lblDocumentLink.AutoSize = true;
            this.lblDocumentLink.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumentLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDocumentLink.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentLink.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblDocumentLink.Location = new System.Drawing.Point(150, 273);
            this.lblDocumentLink.Name = "lblDocumentLink";
            this.lblDocumentLink.Size = new System.Drawing.Size(113, 19);
            this.lblDocumentLink.TabIndex = 14;
            this.lblDocumentLink.Text = "Document Link :";
            // 
            // lblItemList
            // 
            this.lblItemList.AutoEllipsis = true;
            this.lblItemList.AutoSize = true;
            this.lblItemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblItemList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemList.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblItemList.Location = new System.Drawing.Point(609, 173);
            this.lblItemList.Name = "lblItemList";
            this.lblItemList.Size = new System.Drawing.Size(65, 19);
            this.lblItemList.TabIndex = 17;
            this.lblItemList.Text = "Item List";
            // 
            // lblTaskOwnerName
            // 
            this.lblTaskOwnerName.AutoEllipsis = true;
            this.lblTaskOwnerName.AutoSize = true;
            this.lblTaskOwnerName.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskOwnerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTaskOwnerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskOwnerName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblTaskOwnerName.Location = new System.Drawing.Point(130, 312);
            this.lblTaskOwnerName.Name = "lblTaskOwnerName";
            this.lblTaskOwnerName.Size = new System.Drawing.Size(135, 19);
            this.lblTaskOwnerName.TabIndex = 15;
            this.lblTaskOwnerName.Text = "Task Owner Name :";
            // 
            // lblDocumentLinkError
            // 
            this.lblDocumentLinkError.AutoSize = true;
            this.lblDocumentLinkError.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentLinkError.ForeColor = System.Drawing.Color.Red;
            this.lblDocumentLinkError.Location = new System.Drawing.Point(475, 274);
            this.lblDocumentLinkError.Name = "lblDocumentLinkError";
            this.lblDocumentLinkError.Size = new System.Drawing.Size(18, 25);
            this.lblDocumentLinkError.TabIndex = 26;
            this.lblDocumentLinkError.Text = "!";
            this.lblDocumentLinkError.Visible = false;
            // 
            // lblRedmineIdError
            // 
            this.lblRedmineIdError.AutoSize = true;
            this.lblRedmineIdError.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedmineIdError.ForeColor = System.Drawing.Color.Red;
            this.lblRedmineIdError.Location = new System.Drawing.Point(474, 232);
            this.lblRedmineIdError.Name = "lblRedmineIdError";
            this.lblRedmineIdError.Size = new System.Drawing.Size(18, 25);
            this.lblRedmineIdError.TabIndex = 25;
            this.lblRedmineIdError.Text = "!";
            this.lblRedmineIdError.Visible = false;
            // 
            // lblTaskIdError
            // 
            this.lblTaskIdError.AutoSize = true;
            this.lblTaskIdError.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskIdError.ForeColor = System.Drawing.Color.Red;
            this.lblTaskIdError.Location = new System.Drawing.Point(474, 194);
            this.lblTaskIdError.Name = "lblTaskIdError";
            this.lblTaskIdError.Size = new System.Drawing.Size(18, 25);
            this.lblTaskIdError.TabIndex = 24;
            this.lblTaskIdError.Text = "!";
            this.lblTaskIdError.Visible = false;
            // 
            // txtTaskOwnerName
            // 
            this.txtTaskOwnerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtTaskOwnerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTaskOwnerName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTaskOwnerName.FormattingEnabled = true;
            this.txtTaskOwnerName.Items.AddRange(new object[] {
            "Gopal Kundu",
            "Shahinur Rahman",
            "Omar Faruq"});
            this.txtTaskOwnerName.Location = new System.Drawing.Point(275, 313);
            this.txtTaskOwnerName.Name = "txtTaskOwnerName";
            this.txtTaskOwnerName.Size = new System.Drawing.Size(199, 21);
            this.txtTaskOwnerName.TabIndex = 22;
            // 
            // txtDocumentLink
            // 
            this.txtDocumentLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtDocumentLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumentLink.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDocumentLink.Location = new System.Drawing.Point(275, 275);
            this.txtDocumentLink.Name = "txtDocumentLink";
            this.txtDocumentLink.Size = new System.Drawing.Size(199, 20);
            this.txtDocumentLink.TabIndex = 21;
            this.txtDocumentLink.LostFocus += new System.EventHandler(this.txtDocumentLink_LostFocus);
            // 
            // txtRedmineId
            // 
            this.txtRedmineId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtRedmineId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRedmineId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRedmineId.Location = new System.Drawing.Point(275, 234);
            this.txtRedmineId.Name = "txtRedmineId";
            this.txtRedmineId.Size = new System.Drawing.Size(199, 20);
            this.txtRedmineId.TabIndex = 20;
            this.txtRedmineId.LostFocus += new System.EventHandler(this.txtRedmineId_LostFocus);
            // 
            // txtTaskId
            // 
            this.txtTaskId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtTaskId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTaskId.Location = new System.Drawing.Point(275, 196);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.Size = new System.Drawing.Size(199, 20);
            this.txtTaskId.TabIndex = 19;
            this.txtTaskId.LostFocus += new System.EventHandler(this.txtTaskId_LostFocus);
            // 
            // txtItemList
            // 
            this.txtItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtItemList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemList.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtItemList.Location = new System.Drawing.Point(543, 195);
            this.txtItemList.Multiline = true;
            this.txtItemList.Name = "txtItemList";
            this.txtItemList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtItemList.Size = new System.Drawing.Size(199, 139);
            this.txtItemList.TabIndex = 27;
            this.txtItemList.TextChanged += new System.EventHandler(this.txtItemList_TextChanged);
            this.txtItemList.Leave += new System.EventHandler(this.txtItemList_LostFocus);
            // 
            // lblProjectId
            // 
            this.lblProjectId.AutoEllipsis = true;
            this.lblProjectId.AutoSize = true;
            this.lblProjectId.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProjectId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblProjectId.Location = new System.Drawing.Point(185, 132);
            this.lblProjectId.Name = "lblProjectId";
            this.lblProjectId.Size = new System.Drawing.Size(84, 19);
            this.lblProjectId.TabIndex = 29;
            this.lblProjectId.Text = "Project ID : ";
            // 
            // lblProject
            // 
            this.lblProject.AutoEllipsis = true;
            this.lblProject.AutoSize = true;
            this.lblProject.BackColor = System.Drawing.Color.Transparent;
            this.lblProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProject.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblProject.Location = new System.Drawing.Point(204, 102);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(66, 19);
            this.lblProject.TabIndex = 30;
            this.lblProject.Text = "Project : ";
            // 
            // lblReviewDate
            // 
            this.lblReviewDate.AutoEllipsis = true;
            this.lblReviewDate.AutoSize = true;
            this.lblReviewDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReviewDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReviewDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewDate.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblReviewDate.Location = new System.Drawing.Point(511, 99);
            this.lblReviewDate.Name = "lblReviewDate";
            this.lblReviewDate.Size = new System.Drawing.Size(99, 19);
            this.lblReviewDate.TabIndex = 31;
            this.lblReviewDate.Text = "Review Date :";
            // 
            // lblReviewStatus
            // 
            this.lblReviewStatus.AutoEllipsis = true;
            this.lblReviewStatus.AutoSize = true;
            this.lblReviewStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblReviewStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReviewStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewStatus.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblReviewStatus.Location = new System.Drawing.Point(500, 129);
            this.lblReviewStatus.Name = "lblReviewStatus";
            this.lblReviewStatus.Size = new System.Drawing.Size(108, 19);
            this.lblReviewStatus.TabIndex = 32;
            this.lblReviewStatus.Text = "Review Status :";
            // 
            // pnlCheckList
            // 
            this.pnlCheckList.Controls.Add(this.ucReport);
            this.pnlCheckList.Controls.Add(this.lblItems);
            this.pnlCheckList.Controls.Add(this.cmbItemList);
            this.pnlCheckList.Controls.Add(this.lblDocumentIdValue);
            this.pnlCheckList.Controls.Add(this.lblDocumentId);
            this.pnlCheckList.Controls.Add(this.txtOthers);
            this.pnlCheckList.Controls.Add(this.cbNA8);
            this.pnlCheckList.Controls.Add(this.cbNotOK8);
            this.pnlCheckList.Controls.Add(this.cbOK8);
            this.pnlCheckList.Controls.Add(this.lblComment);
            this.pnlCheckList.Controls.Add(this.btnPrevious);
            this.pnlCheckList.Controls.Add(this.btnNext);
            this.pnlCheckList.Controls.Add(this.cbAllOK);
            this.pnlCheckList.Controls.Add(this.lblNA);
            this.pnlCheckList.Controls.Add(this.lblNotOk);
            this.pnlCheckList.Controls.Add(this.lblOk);
            this.pnlCheckList.Controls.Add(this.txtEnCon);
            this.pnlCheckList.Controls.Add(this.txtCheckRep);
            this.pnlCheckList.Controls.Add(this.txtDrawing);
            this.pnlCheckList.Controls.Add(this.txtVersion);
            this.pnlCheckList.Controls.Add(this.txtLatest);
            this.pnlCheckList.Controls.Add(this.txtTransfer);
            this.pnlCheckList.Controls.Add(this.txtCS);
            this.pnlCheckList.Controls.Add(this.cbNA7);
            this.pnlCheckList.Controls.Add(this.cbNotOK7);
            this.pnlCheckList.Controls.Add(this.cbOK7);
            this.pnlCheckList.Controls.Add(this.cbNA6);
            this.pnlCheckList.Controls.Add(this.cbNotOK6);
            this.pnlCheckList.Controls.Add(this.cbOK6);
            this.pnlCheckList.Controls.Add(this.cbNA5);
            this.pnlCheckList.Controls.Add(this.cbNotOK5);
            this.pnlCheckList.Controls.Add(this.cbOK5);
            this.pnlCheckList.Controls.Add(this.cbNA4);
            this.pnlCheckList.Controls.Add(this.cbNotOK4);
            this.pnlCheckList.Controls.Add(this.cbOK4);
            this.pnlCheckList.Controls.Add(this.cbNA3);
            this.pnlCheckList.Controls.Add(this.cbNotOK3);
            this.pnlCheckList.Controls.Add(this.cbOK3);
            this.pnlCheckList.Controls.Add(this.cbNA2);
            this.pnlCheckList.Controls.Add(this.cbNotOK2);
            this.pnlCheckList.Controls.Add(this.cbOK2);
            this.pnlCheckList.Controls.Add(this.cbNA1);
            this.pnlCheckList.Controls.Add(this.cbNotOK1);
            this.pnlCheckList.Controls.Add(this.cbOK1);
            this.pnlCheckList.Controls.Add(this.lblCheckRepresentation);
            this.pnlCheckList.Controls.Add(this.lblEngineeringConnections);
            this.pnlCheckList.Controls.Add(this.lblDrawing);
            this.pnlCheckList.Controls.Add(this.lblVersion);
            this.pnlCheckList.Controls.Add(this.lblLatest);
            this.pnlCheckList.Controls.Add(this.lblTransferType);
            this.pnlCheckList.Controls.Add(this.lblCollaborativeSpace);
            this.pnlCheckList.Controls.Add(this.lblOthers);
            this.pnlCheckList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.pnlCheckList.Location = new System.Drawing.Point(124, 79);
            this.pnlCheckList.Name = "pnlCheckList";
            this.pnlCheckList.Size = new System.Drawing.Size(662, 330);
            this.pnlCheckList.TabIndex = 34;
            this.pnlCheckList.Visible = false;
            this.pnlCheckList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCheckList_MouseDown);
            this.pnlCheckList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCheckList_MouseMove);
            // 
            // ucReport
            // 
            this.ucReport.BackColor = System.Drawing.Color.White;
            this.ucReport.ForeColor = System.Drawing.Color.Black;
            this.ucReport.Location = new System.Drawing.Point(1, 0);
            this.ucReport.Name = "ucReport";
            this.ucReport.Size = new System.Drawing.Size(661, 330);
            this.ucReport.TabIndex = 95;
            this.ucReport.VisibleChanged += new System.EventHandler(this.ucReport_VisibleChanged);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.BackColor = System.Drawing.Color.Transparent;
            this.lblItems.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblItems.Location = new System.Drawing.Point(438, 7);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(53, 19);
            this.lblItems.TabIndex = 94;
            this.lblItems.Text = "Items :";
            // 
            // cmbItemList
            // 
            this.cmbItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.cmbItemList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbItemList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemList.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbItemList.FormattingEnabled = true;
            this.cmbItemList.Location = new System.Drawing.Point(492, 7);
            this.cmbItemList.Name = "cmbItemList";
            this.cmbItemList.Size = new System.Drawing.Size(121, 23);
            this.cmbItemList.TabIndex = 93;
            this.cmbItemList.SelectedIndexChanged += new System.EventHandler(this.cmbItemList_SelectedIndexChanged);
            // 
            // lblDocumentIdValue
            // 
            this.lblDocumentIdValue.AutoSize = true;
            this.lblDocumentIdValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumentIdValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentIdValue.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDocumentIdValue.Location = new System.Drawing.Point(117, 11);
            this.lblDocumentIdValue.Name = "lblDocumentIdValue";
            this.lblDocumentIdValue.Size = new System.Drawing.Size(36, 19);
            this.lblDocumentIdValue.TabIndex = 92;
            this.lblDocumentIdValue.Text = "N/A";
            // 
            // lblDocumentId
            // 
            this.lblDocumentId.AutoSize = true;
            this.lblDocumentId.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumentId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblDocumentId.Location = new System.Drawing.Point(10, 11);
            this.lblDocumentId.Name = "lblDocumentId";
            this.lblDocumentId.Size = new System.Drawing.Size(101, 19);
            this.lblDocumentId.TabIndex = 91;
            this.lblDocumentId.Text = "Document ID :";
            // 
            // txtOthers
            // 
            this.txtOthers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtOthers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOthers.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOthers.Location = new System.Drawing.Point(312, 253);
            this.txtOthers.Multiline = true;
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.Size = new System.Drawing.Size(306, 20);
            this.txtOthers.TabIndex = 86;
            // 
            // cbNA8
            // 
            this.cbNA8.AutoSize = true;
            this.cbNA8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNA8.ForeColor = System.Drawing.Color.White;
            this.cbNA8.Location = new System.Drawing.Point(278, 255);
            this.cbNA8.Name = "cbNA8";
            this.cbNA8.Size = new System.Drawing.Size(26, 17);
            this.cbNA8.TabIndex = 90;
            this.cbNA8.Text = " ";
            this.cbNA8.UseVisualStyleBackColor = true;
            this.cbNA8.CheckedChanged += new System.EventHandler(this.cbNA8_CheckedChanged);
            // 
            // cbNotOK8
            // 
            this.cbNotOK8.AutoSize = true;
            this.cbNotOK8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNotOK8.ForeColor = System.Drawing.Color.White;
            this.cbNotOK8.Location = new System.Drawing.Point(247, 255);
            this.cbNotOK8.Name = "cbNotOK8";
            this.cbNotOK8.Size = new System.Drawing.Size(26, 17);
            this.cbNotOK8.TabIndex = 89;
            this.cbNotOK8.Text = " ";
            this.cbNotOK8.UseVisualStyleBackColor = true;
            this.cbNotOK8.CheckedChanged += new System.EventHandler(this.cbNotOK8_CheckedChanged);
            // 
            // cbOK8
            // 
            this.cbOK8.AutoSize = true;
            this.cbOK8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOK8.ForeColor = System.Drawing.Color.White;
            this.cbOK8.Location = new System.Drawing.Point(216, 255);
            this.cbOK8.Name = "cbOK8";
            this.cbOK8.Size = new System.Drawing.Size(26, 17);
            this.cbOK8.TabIndex = 88;
            this.cbOK8.Text = " ";
            this.cbOK8.UseVisualStyleBackColor = true;
            this.cbOK8.CheckedChanged += new System.EventHandler(this.cbOK8_CheckedChanged);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.Color.Transparent;
            this.lblComment.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblComment.Location = new System.Drawing.Point(389, 41);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(136, 15);
            this.lblComment.TabIndex = 87;
            this.lblComment.Text = "Comment(If applicable)\t";
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnPrevious.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Image = global::ReviewCheckList.Properties.Resources.Previous_2;
            this.btnPrevious.Location = new System.Drawing.Point(526, 280);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrevious.Size = new System.Drawing.Size(47, 42);
            this.btnPrevious.TabIndex = 85;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::ReviewCheckList.Properties.Resources.Next_2;
            this.btnNext.Location = new System.Drawing.Point(573, 280);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(47, 42);
            this.btnNext.TabIndex = 84;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbAllOK
            // 
            this.cbAllOK.AutoSize = true;
            this.cbAllOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.cbAllOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAllOK.ForeColor = System.Drawing.Color.White;
            this.cbAllOK.Location = new System.Drawing.Point(216, 291);
            this.cbAllOK.Name = "cbAllOK";
            this.cbAllOK.Size = new System.Drawing.Size(86, 17);
            this.cbAllOK.TabIndex = 83;
            this.cbAllOK.Text = "Check All OK";
            this.cbAllOK.UseVisualStyleBackColor = false;
            this.cbAllOK.CheckedChanged += new System.EventHandler(this.cbAllOK_CheckedChanged);
            // 
            // lblNA
            // 
            this.lblNA.AutoSize = true;
            this.lblNA.BackColor = System.Drawing.Color.Transparent;
            this.lblNA.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNA.Location = new System.Drawing.Point(275, 41);
            this.lblNA.Name = "lblNA";
            this.lblNA.Size = new System.Drawing.Size(27, 13);
            this.lblNA.TabIndex = 82;
            this.lblNA.Text = "N/A";
            // 
            // lblNotOk
            // 
            this.lblNotOk.AutoSize = true;
            this.lblNotOk.BackColor = System.Drawing.Color.Transparent;
            this.lblNotOk.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNotOk.Location = new System.Drawing.Point(233, 41);
            this.lblNotOk.Name = "lblNotOk";
            this.lblNotOk.Size = new System.Drawing.Size(42, 13);
            this.lblNotOk.TabIndex = 81;
            this.lblNotOk.Text = "Not OK";
            // 
            // lblOk
            // 
            this.lblOk.AutoSize = true;
            this.lblOk.BackColor = System.Drawing.Color.Transparent;
            this.lblOk.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblOk.Location = new System.Drawing.Point(211, 41);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(22, 13);
            this.lblOk.TabIndex = 80;
            this.lblOk.Text = "OK";
            // 
            // txtEnCon
            // 
            this.txtEnCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtEnCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnCon.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEnCon.Location = new System.Drawing.Point(312, 197);
            this.txtEnCon.Name = "txtEnCon";
            this.txtEnCon.Size = new System.Drawing.Size(306, 20);
            this.txtEnCon.TabIndex = 79;
            // 
            // txtCheckRep
            // 
            this.txtCheckRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtCheckRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckRep.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCheckRep.Location = new System.Drawing.Point(312, 225);
            this.txtCheckRep.Name = "txtCheckRep";
            this.txtCheckRep.Size = new System.Drawing.Size(306, 20);
            this.txtCheckRep.TabIndex = 78;
            // 
            // txtDrawing
            // 
            this.txtDrawing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDrawing.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDrawing.Location = new System.Drawing.Point(312, 169);
            this.txtDrawing.Name = "txtDrawing";
            this.txtDrawing.Size = new System.Drawing.Size(306, 20);
            this.txtDrawing.TabIndex = 77;
            // 
            // txtVersion
            // 
            this.txtVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVersion.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtVersion.Location = new System.Drawing.Point(312, 142);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(306, 20);
            this.txtVersion.TabIndex = 76;
            // 
            // txtLatest
            // 
            this.txtLatest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtLatest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLatest.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLatest.Location = new System.Drawing.Point(312, 114);
            this.txtLatest.Name = "txtLatest";
            this.txtLatest.Size = new System.Drawing.Size(306, 20);
            this.txtLatest.TabIndex = 75;
            // 
            // txtTransfer
            // 
            this.txtTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransfer.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTransfer.Location = new System.Drawing.Point(312, 87);
            this.txtTransfer.Name = "txtTransfer";
            this.txtTransfer.Size = new System.Drawing.Size(306, 20);
            this.txtTransfer.TabIndex = 74;
            // 
            // txtCS
            // 
            this.txtCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtCS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCS.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCS.Location = new System.Drawing.Point(312, 59);
            this.txtCS.Name = "txtCS";
            this.txtCS.Size = new System.Drawing.Size(306, 20);
            this.txtCS.TabIndex = 73;
            // 
            // cbNA7
            // 
            this.cbNA7.AutoSize = true;
            this.cbNA7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNA7.ForeColor = System.Drawing.Color.White;
            this.cbNA7.Location = new System.Drawing.Point(278, 230);
            this.cbNA7.Name = "cbNA7";
            this.cbNA7.Size = new System.Drawing.Size(26, 17);
            this.cbNA7.TabIndex = 72;
            this.cbNA7.Text = " ";
            this.cbNA7.UseVisualStyleBackColor = true;
            this.cbNA7.CheckedChanged += new System.EventHandler(this.cbNA7_CheckedChanged);
            // 
            // cbNotOK7
            // 
            this.cbNotOK7.AutoSize = true;
            this.cbNotOK7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNotOK7.ForeColor = System.Drawing.Color.White;
            this.cbNotOK7.Location = new System.Drawing.Point(247, 230);
            this.cbNotOK7.Name = "cbNotOK7";
            this.cbNotOK7.Size = new System.Drawing.Size(26, 17);
            this.cbNotOK7.TabIndex = 71;
            this.cbNotOK7.Text = " ";
            this.cbNotOK7.UseVisualStyleBackColor = true;
            this.cbNotOK7.CheckedChanged += new System.EventHandler(this.cbNotOK7_CheckedChanged_1);
            // 
            // cbOK7
            // 
            this.cbOK7.AutoSize = true;
            this.cbOK7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOK7.ForeColor = System.Drawing.Color.White;
            this.cbOK7.Location = new System.Drawing.Point(216, 230);
            this.cbOK7.Name = "cbOK7";
            this.cbOK7.Size = new System.Drawing.Size(26, 17);
            this.cbOK7.TabIndex = 70;
            this.cbOK7.Text = " ";
            this.cbOK7.UseVisualStyleBackColor = true;
            this.cbOK7.CheckedChanged += new System.EventHandler(this.cbOK7_CheckedChanged);
            // 
            // cbNA6
            // 
            this.cbNA6.AutoSize = true;
            this.cbNA6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNA6.ForeColor = System.Drawing.Color.White;
            this.cbNA6.Location = new System.Drawing.Point(278, 202);
            this.cbNA6.Name = "cbNA6";
            this.cbNA6.Size = new System.Drawing.Size(26, 17);
            this.cbNA6.TabIndex = 69;
            this.cbNA6.Text = " ";
            this.cbNA6.UseVisualStyleBackColor = true;
            this.cbNA6.CheckedChanged += new System.EventHandler(this.cbNA6_CheckedChanged);
            // 
            // cbNotOK6
            // 
            this.cbNotOK6.AutoSize = true;
            this.cbNotOK6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNotOK6.ForeColor = System.Drawing.Color.White;
            this.cbNotOK6.Location = new System.Drawing.Point(247, 202);
            this.cbNotOK6.Name = "cbNotOK6";
            this.cbNotOK6.Size = new System.Drawing.Size(26, 17);
            this.cbNotOK6.TabIndex = 68;
            this.cbNotOK6.Text = " ";
            this.cbNotOK6.UseVisualStyleBackColor = true;
            this.cbNotOK6.CheckedChanged += new System.EventHandler(this.cbNotOK6_CheckedChanged);
            // 
            // cbOK6
            // 
            this.cbOK6.AutoSize = true;
            this.cbOK6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOK6.ForeColor = System.Drawing.Color.White;
            this.cbOK6.Location = new System.Drawing.Point(216, 202);
            this.cbOK6.Name = "cbOK6";
            this.cbOK6.Size = new System.Drawing.Size(26, 17);
            this.cbOK6.TabIndex = 67;
            this.cbOK6.Text = " ";
            this.cbOK6.UseVisualStyleBackColor = true;
            this.cbOK6.CheckedChanged += new System.EventHandler(this.cbOK6_CheckedChanged);
            // 
            // cbNA5
            // 
            this.cbNA5.AutoSize = true;
            this.cbNA5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNA5.ForeColor = System.Drawing.Color.White;
            this.cbNA5.Location = new System.Drawing.Point(278, 174);
            this.cbNA5.Name = "cbNA5";
            this.cbNA5.Size = new System.Drawing.Size(26, 17);
            this.cbNA5.TabIndex = 66;
            this.cbNA5.Text = " ";
            this.cbNA5.UseVisualStyleBackColor = true;
            this.cbNA5.CheckedChanged += new System.EventHandler(this.cbNA5_CheckedChanged);
            // 
            // cbNotOK5
            // 
            this.cbNotOK5.AutoSize = true;
            this.cbNotOK5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNotOK5.ForeColor = System.Drawing.Color.White;
            this.cbNotOK5.Location = new System.Drawing.Point(247, 174);
            this.cbNotOK5.Name = "cbNotOK5";
            this.cbNotOK5.Size = new System.Drawing.Size(26, 17);
            this.cbNotOK5.TabIndex = 65;
            this.cbNotOK5.Text = " ";
            this.cbNotOK5.UseVisualStyleBackColor = true;
            this.cbNotOK5.CheckedChanged += new System.EventHandler(this.cbNotOK5_CheckedChanged_1);
            // 
            // cbOK5
            // 
            this.cbOK5.AutoSize = true;
            this.cbOK5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOK5.ForeColor = System.Drawing.Color.White;
            this.cbOK5.Location = new System.Drawing.Point(216, 174);
            this.cbOK5.Name = "cbOK5";
            this.cbOK5.Size = new System.Drawing.Size(26, 17);
            this.cbOK5.TabIndex = 64;
            this.cbOK5.Text = " ";
            this.cbOK5.UseVisualStyleBackColor = true;
            this.cbOK5.CheckedChanged += new System.EventHandler(this.cbOK5_CheckedChanged);
            // 
            // cbNA4
            // 
            this.cbNA4.AutoSize = true;
            this.cbNA4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNA4.ForeColor = System.Drawing.Color.White;
            this.cbNA4.Location = new System.Drawing.Point(278, 146);
            this.cbNA4.Name = "cbNA4";
            this.cbNA4.Size = new System.Drawing.Size(26, 17);
            this.cbNA4.TabIndex = 63;
            this.cbNA4.Text = " ";
            this.cbNA4.UseVisualStyleBackColor = true;
            this.cbNA4.CheckedChanged += new System.EventHandler(this.cbNA4_CheckedChanged);
            // 
            // cbNotOK4
            // 
            this.cbNotOK4.AutoSize = true;
            this.cbNotOK4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNotOK4.ForeColor = System.Drawing.Color.White;
            this.cbNotOK4.Location = new System.Drawing.Point(247, 146);
            this.cbNotOK4.Name = "cbNotOK4";
            this.cbNotOK4.Size = new System.Drawing.Size(26, 17);
            this.cbNotOK4.TabIndex = 62;
            this.cbNotOK4.Text = " ";
            this.cbNotOK4.UseVisualStyleBackColor = true;
            this.cbNotOK4.CheckedChanged += new System.EventHandler(this.cbNotOK4_CheckedChanged);
            // 
            // cbOK4
            // 
            this.cbOK4.AutoSize = true;
            this.cbOK4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOK4.ForeColor = System.Drawing.Color.White;
            this.cbOK4.Location = new System.Drawing.Point(216, 146);
            this.cbOK4.Name = "cbOK4";
            this.cbOK4.Size = new System.Drawing.Size(26, 17);
            this.cbOK4.TabIndex = 61;
            this.cbOK4.Text = " ";
            this.cbOK4.UseVisualStyleBackColor = true;
            this.cbOK4.CheckedChanged += new System.EventHandler(this.cbOK4_CheckedChanged);
            // 
            // cbNA3
            // 
            this.cbNA3.AutoSize = true;
            this.cbNA3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNA3.ForeColor = System.Drawing.Color.White;
            this.cbNA3.Location = new System.Drawing.Point(278, 118);
            this.cbNA3.Name = "cbNA3";
            this.cbNA3.Size = new System.Drawing.Size(26, 17);
            this.cbNA3.TabIndex = 60;
            this.cbNA3.Text = " ";
            this.cbNA3.UseVisualStyleBackColor = true;
            this.cbNA3.CheckedChanged += new System.EventHandler(this.cbNA3_CheckedChanged);
            // 
            // cbNotOK3
            // 
            this.cbNotOK3.AutoSize = true;
            this.cbNotOK3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNotOK3.ForeColor = System.Drawing.Color.White;
            this.cbNotOK3.Location = new System.Drawing.Point(247, 118);
            this.cbNotOK3.Name = "cbNotOK3";
            this.cbNotOK3.Size = new System.Drawing.Size(26, 17);
            this.cbNotOK3.TabIndex = 59;
            this.cbNotOK3.Text = " ";
            this.cbNotOK3.UseVisualStyleBackColor = true;
            this.cbNotOK3.CheckedChanged += new System.EventHandler(this.cbNotOK3_CheckedChanged);
            // 
            // cbOK3
            // 
            this.cbOK3.AutoSize = true;
            this.cbOK3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOK3.ForeColor = System.Drawing.Color.White;
            this.cbOK3.Location = new System.Drawing.Point(216, 118);
            this.cbOK3.Name = "cbOK3";
            this.cbOK3.Size = new System.Drawing.Size(26, 17);
            this.cbOK3.TabIndex = 58;
            this.cbOK3.Text = " ";
            this.cbOK3.UseVisualStyleBackColor = true;
            this.cbOK3.CheckedChanged += new System.EventHandler(this.cbOK3_CheckedChanged);
            // 
            // cbNA2
            // 
            this.cbNA2.AutoSize = true;
            this.cbNA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNA2.ForeColor = System.Drawing.Color.White;
            this.cbNA2.Location = new System.Drawing.Point(278, 90);
            this.cbNA2.Name = "cbNA2";
            this.cbNA2.Size = new System.Drawing.Size(26, 17);
            this.cbNA2.TabIndex = 57;
            this.cbNA2.Text = " ";
            this.cbNA2.UseVisualStyleBackColor = true;
            this.cbNA2.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // cbNotOK2
            // 
            this.cbNotOK2.AutoSize = true;
            this.cbNotOK2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNotOK2.ForeColor = System.Drawing.Color.White;
            this.cbNotOK2.Location = new System.Drawing.Point(247, 90);
            this.cbNotOK2.Name = "cbNotOK2";
            this.cbNotOK2.Size = new System.Drawing.Size(26, 17);
            this.cbNotOK2.TabIndex = 56;
            this.cbNotOK2.Text = " ";
            this.cbNotOK2.UseVisualStyleBackColor = true;
            this.cbNotOK2.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // cbOK2
            // 
            this.cbOK2.AutoSize = true;
            this.cbOK2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOK2.ForeColor = System.Drawing.Color.White;
            this.cbOK2.Location = new System.Drawing.Point(216, 90);
            this.cbOK2.Name = "cbOK2";
            this.cbOK2.Size = new System.Drawing.Size(26, 17);
            this.cbOK2.TabIndex = 55;
            this.cbOK2.Text = " ";
            this.cbOK2.UseVisualStyleBackColor = true;
            this.cbOK2.CheckedChanged += new System.EventHandler(this.cbOK2_CheckedChanged);
            // 
            // cbNA1
            // 
            this.cbNA1.AutoSize = true;
            this.cbNA1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbNA1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbNA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNA1.ForeColor = System.Drawing.Color.White;
            this.cbNA1.Location = new System.Drawing.Point(278, 62);
            this.cbNA1.Name = "cbNA1";
            this.cbNA1.Size = new System.Drawing.Size(26, 17);
            this.cbNA1.TabIndex = 54;
            this.cbNA1.Text = " ";
            this.cbNA1.UseVisualStyleBackColor = true;
            this.cbNA1.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbNotOK1
            // 
            this.cbNotOK1.AutoSize = true;
            this.cbNotOK1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbNotOK1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbNotOK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNotOK1.ForeColor = System.Drawing.Color.White;
            this.cbNotOK1.Location = new System.Drawing.Point(247, 62);
            this.cbNotOK1.Name = "cbNotOK1";
            this.cbNotOK1.Size = new System.Drawing.Size(26, 17);
            this.cbNotOK1.TabIndex = 53;
            this.cbNotOK1.Text = " ";
            this.cbNotOK1.UseVisualStyleBackColor = true;
            this.cbNotOK1.CheckedChanged += new System.EventHandler(this.cbNotOK1_CheckedChanged);
            // 
            // cbOK1
            // 
            this.cbOK1.AutoSize = true;
            this.cbOK1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbOK1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbOK1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cbOK1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.cbOK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOK1.ForeColor = System.Drawing.Color.White;
            this.cbOK1.Location = new System.Drawing.Point(216, 62);
            this.cbOK1.Name = "cbOK1";
            this.cbOK1.Size = new System.Drawing.Size(26, 17);
            this.cbOK1.TabIndex = 52;
            this.cbOK1.Text = " ";
            this.cbOK1.UseVisualStyleBackColor = true;
            this.cbOK1.CheckedChanged += new System.EventHandler(this.cbOK1_CheckedChanged);
            // 
            // lblCheckRepresentation
            // 
            this.lblCheckRepresentation.AutoSize = true;
            this.lblCheckRepresentation.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckRepresentation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckRepresentation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblCheckRepresentation.Location = new System.Drawing.Point(53, 227);
            this.lblCheckRepresentation.Name = "lblCheckRepresentation";
            this.lblCheckRepresentation.Size = new System.Drawing.Size(151, 19);
            this.lblCheckRepresentation.TabIndex = 50;
            this.lblCheckRepresentation.Text = "Check Representation";
            // 
            // lblEngineeringConnections
            // 
            this.lblEngineeringConnections.AutoSize = true;
            this.lblEngineeringConnections.BackColor = System.Drawing.Color.Transparent;
            this.lblEngineeringConnections.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngineeringConnections.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblEngineeringConnections.Location = new System.Drawing.Point(34, 199);
            this.lblEngineeringConnections.Name = "lblEngineeringConnections";
            this.lblEngineeringConnections.Size = new System.Drawing.Size(170, 19);
            this.lblEngineeringConnections.TabIndex = 49;
            this.lblEngineeringConnections.Text = "Engineering Connections";
            // 
            // lblDrawing
            // 
            this.lblDrawing.AutoSize = true;
            this.lblDrawing.BackColor = System.Drawing.Color.Transparent;
            this.lblDrawing.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawing.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblDrawing.Location = new System.Drawing.Point(82, 171);
            this.lblDrawing.Name = "lblDrawing";
            this.lblDrawing.Size = new System.Drawing.Size(122, 19);
            this.lblDrawing.TabIndex = 48;
            this.lblDrawing.Text = "Drawing Opening";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblVersion.Location = new System.Drawing.Point(66, 143);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(138, 19);
            this.lblVersion.TabIndex = 47;
            this.lblVersion.Text = "Version/Revision no";
            // 
            // lblLatest
            // 
            this.lblLatest.AutoSize = true;
            this.lblLatest.BackColor = System.Drawing.Color.Transparent;
            this.lblLatest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatest.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblLatest.Location = new System.Drawing.Point(75, 115);
            this.lblLatest.Name = "lblLatest";
            this.lblLatest.Size = new System.Drawing.Size(129, 19);
            this.lblLatest.TabIndex = 46;
            this.lblLatest.Text = "Latest/Non Latest ";
            // 
            // lblTransferType
            // 
            this.lblTransferType.AutoSize = true;
            this.lblTransferType.BackColor = System.Drawing.Color.Transparent;
            this.lblTransferType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferType.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblTransferType.Location = new System.Drawing.Point(108, 87);
            this.lblTransferType.Name = "lblTransferType";
            this.lblTransferType.Size = new System.Drawing.Size(96, 19);
            this.lblTransferType.TabIndex = 45;
            this.lblTransferType.Text = "Transfer Type";
            // 
            // lblCollaborativeSpace
            // 
            this.lblCollaborativeSpace.AutoSize = true;
            this.lblCollaborativeSpace.BackColor = System.Drawing.Color.Transparent;
            this.lblCollaborativeSpace.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollaborativeSpace.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblCollaborativeSpace.Location = new System.Drawing.Point(46, 59);
            this.lblCollaborativeSpace.Name = "lblCollaborativeSpace";
            this.lblCollaborativeSpace.Size = new System.Drawing.Size(158, 19);
            this.lblCollaborativeSpace.TabIndex = 44;
            this.lblCollaborativeSpace.Text = "V6 Collaborative Space";
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.BackColor = System.Drawing.Color.Transparent;
            this.lblOthers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOthers.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblOthers.Location = new System.Drawing.Point(151, 256);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(53, 19);
            this.lblOthers.TabIndex = 51;
            this.lblOthers.Text = "Others";
            // 
            // lblReviewChecklist
            // 
            this.lblReviewChecklist.AutoSize = true;
            this.lblReviewChecklist.BackColor = System.Drawing.Color.Transparent;
            this.lblReviewChecklist.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewChecklist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(133)))), ((int)(((byte)(168)))));
            this.lblReviewChecklist.Location = new System.Drawing.Point(285, 9);
            this.lblReviewChecklist.Name = "lblReviewChecklist";
            this.lblReviewChecklist.Size = new System.Drawing.Size(307, 43);
            this.lblReviewChecklist.TabIndex = 18;
            this.lblReviewChecklist.Text = "Review Checklist";
            // 
            // lblServicenowDbdiIssues
            // 
            this.lblServicenowDbdiIssues.AutoSize = true;
            this.lblServicenowDbdiIssues.BackColor = System.Drawing.Color.Transparent;
            this.lblServicenowDbdiIssues.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicenowDbdiIssues.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblServicenowDbdiIssues.Location = new System.Drawing.Point(346, 57);
            this.lblServicenowDbdiIssues.Name = "lblServicenowDbdiIssues";
            this.lblServicenowDbdiIssues.Size = new System.Drawing.Size(185, 19);
            this.lblServicenowDbdiIssues.TabIndex = 28;
            this.lblServicenowDbdiIssues.Text = "ServiceNow DBDI Issues";
            // 
            // lblProjectIdValue
            // 
            this.lblProjectIdValue.AutoEllipsis = true;
            this.lblProjectIdValue.AutoSize = true;
            this.lblProjectIdValue.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectIdValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProjectIdValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectIdValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProjectIdValue.Location = new System.Drawing.Point(271, 132);
            this.lblProjectIdValue.Name = "lblProjectIdValue";
            this.lblProjectIdValue.Size = new System.Drawing.Size(36, 19);
            this.lblProjectIdValue.TabIndex = 36;
            this.lblProjectIdValue.Text = "N/A";
            // 
            // lblReviewStatusValue
            // 
            this.lblReviewStatusValue.AutoEllipsis = true;
            this.lblReviewStatusValue.AutoSize = true;
            this.lblReviewStatusValue.BackColor = System.Drawing.Color.Transparent;
            this.lblReviewStatusValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReviewStatusValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewStatusValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblReviewStatusValue.Location = new System.Drawing.Point(610, 130);
            this.lblReviewStatusValue.Name = "lblReviewStatusValue";
            this.lblReviewStatusValue.Size = new System.Drawing.Size(37, 19);
            this.lblReviewStatusValue.TabIndex = 41;
            this.lblReviewStatusValue.Text = "N\\A";
            // 
            // lblReviewDateValue
            // 
            this.lblReviewDateValue.AutoEllipsis = true;
            this.lblReviewDateValue.AutoSize = true;
            this.lblReviewDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblReviewDateValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReviewDateValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewDateValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblReviewDateValue.Location = new System.Drawing.Point(610, 100);
            this.lblReviewDateValue.Name = "lblReviewDateValue";
            this.lblReviewDateValue.Size = new System.Drawing.Size(37, 19);
            this.lblReviewDateValue.TabIndex = 40;
            this.lblReviewDateValue.Text = "N\\A";
            // 
            // lblProjectNameValue
            // 
            this.lblProjectNameValue.AutoEllipsis = true;
            this.lblProjectNameValue.AutoSize = true;
            this.lblProjectNameValue.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectNameValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProjectNameValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectNameValue.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProjectNameValue.Location = new System.Drawing.Point(272, 103);
            this.lblProjectNameValue.Name = "lblProjectNameValue";
            this.lblProjectNameValue.Size = new System.Drawing.Size(36, 19);
            this.lblProjectNameValue.TabIndex = 39;
            this.lblProjectNameValue.Text = "N/A";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::ReviewCheckList.Properties.Resources.minimize__1_;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(707, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 34);
            this.btnMinimize.TabIndex = 44;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(81)))), ((int)(((byte)(70)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::ReviewCheckList.Properties.Resources.CloseMain;
            this.btnClose.Location = new System.Drawing.Point(746, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 34);
            this.btnClose.TabIndex = 43;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUserInput
            // 
            this.btnUserInput.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnUserInput.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnUserInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUserInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInput.Image = global::ReviewCheckList.Properties.Resources.Next_2;
            this.btnUserInput.Location = new System.Drawing.Point(697, 361);
            this.btnUserInput.Name = "btnUserInput";
            this.btnUserInput.Size = new System.Drawing.Size(47, 42);
            this.btnUserInput.TabIndex = 42;
            this.btnUserInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUserInput.UseVisualStyleBackColor = true;
            this.btnUserInput.Click += new System.EventHandler(this.btnUserInput_Click);
            // 
            // lblError
            // 
            this.lblError.AutoEllipsis = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblError.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Image = global::ReviewCheckList.Properties.Resources.error3;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(273, 348);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(178, 19);
            this.lblError.TabIndex = 45;
            this.lblError.Text = "Please check your input!";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblError.Visible = false;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(786, 411);
            this.Controls.Add(this.pnlCheckList);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblReviewStatus);
            this.Controls.Add(this.lblReviewDate);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblProjectId);
            this.Controls.Add(this.lblServicenowDbdiIssues);
            this.Controls.Add(this.txtItemList);
            this.Controls.Add(this.lblDocumentLinkError);
            this.Controls.Add(this.lblRedmineIdError);
            this.Controls.Add(this.lblTaskIdError);
            this.Controls.Add(this.txtTaskOwnerName);
            this.Controls.Add(this.txtDocumentLink);
            this.Controls.Add(this.txtRedmineId);
            this.Controls.Add(this.txtTaskId);
            this.Controls.Add(this.lblReviewChecklist);
            this.Controls.Add(this.lblTaskId);
            this.Controls.Add(this.lblRedmineId);
            this.Controls.Add(this.lblDocumentLink);
            this.Controls.Add(this.lblItemList);
            this.Controls.Add(this.lblTaskOwnerName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblReviewStatusValue);
            this.Controls.Add(this.lblReviewDateValue);
            this.Controls.Add(this.lblProjectNameValue);
            this.Controls.Add(this.lblProjectIdValue);
            this.Controls.Add(this.btnUserInput);
            this.Controls.Add(this.lblError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainUI";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainUI_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainUI_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCheckList.ResumeLayout(false);
            this.pnlCheckList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnChecklist;
        private System.Windows.Forms.Label lblTaskId;
        private System.Windows.Forms.Label lblRedmineId;
        private System.Windows.Forms.Label lblDocumentLink;
        private System.Windows.Forms.Label lblItemList;
        private System.Windows.Forms.Label lblTaskOwnerName;
        private System.Windows.Forms.Label lblDocumentLinkError;
        private System.Windows.Forms.Label lblRedmineIdError;
        private System.Windows.Forms.Label lblTaskIdError;
        private System.Windows.Forms.ComboBox txtTaskOwnerName;
        private System.Windows.Forms.TextBox txtDocumentLink;
        private System.Windows.Forms.TextBox txtRedmineId;
        private System.Windows.Forms.TextBox txtTaskId;
        private System.Windows.Forms.TextBox txtItemList;
        private System.Windows.Forms.Label lblProjectId;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblReviewDate;
        private System.Windows.Forms.Label lblReviewStatus;
        private System.Windows.Forms.Panel pnlCheckList;
        private System.Windows.Forms.Label lblCheckRepresentation;
        private System.Windows.Forms.Label lblEngineeringConnections;
        private System.Windows.Forms.Label lblDrawing;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblLatest;
        private System.Windows.Forms.Label lblTransferType;
        private System.Windows.Forms.Label lblCollaborativeSpace;
        private System.Windows.Forms.Label lblOthers;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtOthers;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckBox cbAllOK;
        private System.Windows.Forms.Label lblNA;
        private System.Windows.Forms.Label lblNotOk;
        private System.Windows.Forms.Label lblOk;
        private System.Windows.Forms.TextBox txtEnCon;
        private System.Windows.Forms.TextBox txtCheckRep;
        private System.Windows.Forms.TextBox txtDrawing;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtLatest;
        private System.Windows.Forms.TextBox txtTransfer;
        private System.Windows.Forms.TextBox txtCS;
        private System.Windows.Forms.CheckBox cbNA7;
        private System.Windows.Forms.CheckBox cbNotOK7;
        private System.Windows.Forms.CheckBox cbOK7;
        private System.Windows.Forms.CheckBox cbNA6;
        private System.Windows.Forms.CheckBox cbNotOK6;
        private System.Windows.Forms.CheckBox cbOK6;
        private System.Windows.Forms.CheckBox cbNA5;
        private System.Windows.Forms.CheckBox cbNotOK5;
        private System.Windows.Forms.CheckBox cbOK5;
        private System.Windows.Forms.CheckBox cbNA4;
        private System.Windows.Forms.CheckBox cbNotOK4;
        private System.Windows.Forms.CheckBox cbOK4;
        private System.Windows.Forms.CheckBox cbNA3;
        private System.Windows.Forms.CheckBox cbNotOK3;
        private System.Windows.Forms.CheckBox cbOK3;
        private System.Windows.Forms.CheckBox cbNA2;
        private System.Windows.Forms.CheckBox cbNotOK2;
        private System.Windows.Forms.CheckBox cbOK2;
        private System.Windows.Forms.CheckBox cbNA1;
        private System.Windows.Forms.CheckBox cbNotOK1;
        private System.Windows.Forms.CheckBox cbOK1;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Label lblReviewChecklist;
        private System.Windows.Forms.Label lblServicenowDbdiIssues;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblProjectIdValue;
        private System.Windows.Forms.Label lblReviewStatusValue;
        private System.Windows.Forms.Label lblReviewDateValue;
        private System.Windows.Forms.Label lblProjectNameValue;
        private System.Windows.Forms.Button btnUserInput;
        private System.Windows.Forms.CheckBox cbNA8;
        private System.Windows.Forms.CheckBox cbNotOK8;
        private System.Windows.Forms.CheckBox cbOK8;
        private System.Windows.Forms.Label lblDocumentIdValue;
        private System.Windows.Forms.Label lblDocumentId;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblError;
        private ComboBox cmbItemList;
        private Label lblItems;
        private Button btnReport;
        private Report ucReport;
        private Button btnOpenFile;
    }
}