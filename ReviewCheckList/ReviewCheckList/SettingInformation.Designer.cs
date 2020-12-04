namespace ReviewCheckList
{
    partial class SettingInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingInformation));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserNameSetting = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblProjectNameSetting = new System.Windows.Forms.Label();
            this.txtProjectId = new System.Windows.Forms.TextBox();
            this.lblProjectIdSetting = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtUserName.Location = new System.Drawing.Point(157, 39);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(252, 20);
            this.txtUserName.TabIndex = 75;
            // 
            // lblUserNameSetting
            // 
            this.lblUserNameSetting.AutoSize = true;
            this.lblUserNameSetting.BackColor = System.Drawing.Color.Transparent;
            this.lblUserNameSetting.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameSetting.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblUserNameSetting.Location = new System.Drawing.Point(62, 38);
            this.lblUserNameSetting.Name = "lblUserNameSetting";
            this.lblUserNameSetting.Size = new System.Drawing.Size(93, 19);
            this.lblUserNameSetting.TabIndex = 74;
            this.lblUserNameSetting.Text = "User Name : ";
            // 
            // txtProjectName
            // 
            this.txtProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProjectName.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtProjectName.Location = new System.Drawing.Point(157, 70);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(252, 20);
            this.txtProjectName.TabIndex = 77;
            // 
            // lblProjectNameSetting
            // 
            this.lblProjectNameSetting.AutoSize = true;
            this.lblProjectNameSetting.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectNameSetting.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectNameSetting.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblProjectNameSetting.Location = new System.Drawing.Point(47, 69);
            this.lblProjectNameSetting.Name = "lblProjectNameSetting";
            this.lblProjectNameSetting.Size = new System.Drawing.Size(108, 19);
            this.lblProjectNameSetting.TabIndex = 76;
            this.lblProjectNameSetting.Text = "Project Name : ";
            // 
            // txtProjectId
            // 
            this.txtProjectId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtProjectId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProjectId.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtProjectId.Location = new System.Drawing.Point(157, 101);
            this.txtProjectId.Name = "txtProjectId";
            this.txtProjectId.Size = new System.Drawing.Size(252, 20);
            this.txtProjectId.TabIndex = 79;
            // 
            // lblProjectIdSetting
            // 
            this.lblProjectIdSetting.AutoSize = true;
            this.lblProjectIdSetting.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectIdSetting.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectIdSetting.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblProjectIdSetting.Location = new System.Drawing.Point(71, 100);
            this.lblProjectIdSetting.Name = "lblProjectIdSetting";
            this.lblProjectIdSetting.Size = new System.Drawing.Size(84, 19);
            this.lblProjectIdSetting.TabIndex = 78;
            this.lblProjectIdSetting.Text = "Project ID : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(330, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 28);
            this.button1.TabIndex = 80;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbTheme
            // 
            this.cmbTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.cmbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTheme.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTheme.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.cmbTheme.Location = new System.Drawing.Point(156, 149);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(90, 23);
            this.cmbTheme.TabIndex = 86;
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.cmbTheme_SelectedIndexChanged);
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.BackColor = System.Drawing.Color.Transparent;
            this.lblTheme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblTheme.Location = new System.Drawing.Point(88, 151);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(63, 19);
            this.lblTheme.TabIndex = 87;
            this.lblTheme.Text = "Theme :";
            // 
            // SettingInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(469, 207);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.cmbTheme);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProjectId);
            this.Controls.Add(this.lblProjectIdSetting);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lblProjectNameSetting);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserNameSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserNameSetting;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lblProjectNameSetting;
        private System.Windows.Forms.TextBox txtProjectId;
        private System.Windows.Forms.Label lblProjectIdSetting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.Label lblTheme;
    }
}