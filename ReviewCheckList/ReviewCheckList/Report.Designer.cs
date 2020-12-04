namespace ReviewCheckList
{
    partial class Report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtReportName = new System.Windows.Forms.TextBox();
            this.lblReportName = new System.Windows.Forms.Label();
            this.lblReportDirectory = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.lblAvailableError = new System.Windows.Forms.Label();
            this.tpSaveWarning = new System.Windows.Forms.ToolTip(this.components);
            this.btnRemember = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFolderBrows = new System.Windows.Forms.Button();
            this.pcDone = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcDone)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReportName
            // 
            this.txtReportName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtReportName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReportName.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtReportName.Location = new System.Drawing.Point(209, 142);
            this.txtReportName.Name = "txtReportName";
            this.txtReportName.Size = new System.Drawing.Size(310, 20);
            this.txtReportName.TabIndex = 96;
            this.txtReportName.TextChanged += new System.EventHandler(this.txtReportName_TextChanged);
            this.txtReportName.VisibleChanged += new System.EventHandler(this.Report_VisibleChanged);
            // 
            // lblReportName
            // 
            this.lblReportName.AutoSize = true;
            this.lblReportName.BackColor = System.Drawing.Color.Transparent;
            this.lblReportName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblReportName.Location = new System.Drawing.Point(102, 140);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Size = new System.Drawing.Size(106, 19);
            this.lblReportName.TabIndex = 95;
            this.lblReportName.Text = "Report Name : ";
            // 
            // lblReportDirectory
            // 
            this.lblReportDirectory.AutoSize = true;
            this.lblReportDirectory.BackColor = System.Drawing.Color.Transparent;
            this.lblReportDirectory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportDirectory.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblReportDirectory.Location = new System.Drawing.Point(81, 103);
            this.lblReportDirectory.Name = "lblReportDirectory";
            this.lblReportDirectory.Size = new System.Drawing.Size(127, 19);
            this.lblReportDirectory.TabIndex = 94;
            this.lblReportDirectory.Text = "Report Directory : ";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.txtFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolderPath.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtFolderPath.Location = new System.Drawing.Point(209, 103);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(310, 20);
            this.txtFolderPath.TabIndex = 92;
            this.txtFolderPath.TextChanged += new System.EventHandler(this.txtFolderPath_TextChanged);
            // 
            // lblAvailableError
            // 
            this.lblAvailableError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAvailableError.Location = new System.Drawing.Point(209, 167);
            this.lblAvailableError.Name = "lblAvailableError";
            this.lblAvailableError.Size = new System.Drawing.Size(347, 35);
            this.lblAvailableError.TabIndex = 101;
            this.lblAvailableError.Text = "! File is already available with this name in the same directory. Save action wil" +
    "l overwrite the file!";
            // 
            // btnRemember
            // 
            this.btnRemember.BackColor = System.Drawing.Color.Transparent;
            this.btnRemember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemember.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemember.Image = global::ReviewCheckList.Properties.Resources.Lateruse;
            this.btnRemember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemember.Location = new System.Drawing.Point(13, 280);
            this.btnRemember.Name = "btnRemember";
            this.btnRemember.Size = new System.Drawing.Size(92, 36);
            this.btnRemember.TabIndex = 102;
            this.btnRemember.Text = "Remember";
            this.btnRemember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemember.UseVisualStyleBackColor = false;
            this.btnRemember.Click += new System.EventHandler(this.btnSaveForLater_Click);
            this.btnRemember.MouseHover += new System.EventHandler(this.btnRemember_MouseHover);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnPrevious.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Image = global::ReviewCheckList.Properties.Resources.Previous_2;
            this.btnPrevious.Location = new System.Drawing.Point(525, 280);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrevious.Size = new System.Drawing.Size(47, 42);
            this.btnPrevious.TabIndex = 98;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnReportPrevious_Click);
            // 
            // btnFolderBrows
            // 
            this.btnFolderBrows.BackColor = System.Drawing.Color.Transparent;
            this.btnFolderBrows.BackgroundImage = global::ReviewCheckList.Properties.Resources.folder;
            this.btnFolderBrows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFolderBrows.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnFolderBrows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderBrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolderBrows.Location = new System.Drawing.Point(525, 101);
            this.btnFolderBrows.Name = "btnFolderBrows";
            this.btnFolderBrows.Size = new System.Drawing.Size(31, 24);
            this.btnFolderBrows.TabIndex = 93;
            this.btnFolderBrows.UseVisualStyleBackColor = false;
            this.btnFolderBrows.Click += new System.EventHandler(this.btnFolderBrows_Click);
            // 
            // pcDone
            // 
            this.pcDone.BackColor = System.Drawing.Color.Transparent;
            this.pcDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcDone.Enabled = false;
            this.pcDone.Image = global::ReviewCheckList.Properties.Resources.done_3;
            this.pcDone.Location = new System.Drawing.Point(576, 278);
            this.pcDone.Name = "pcDone";
            this.pcDone.Size = new System.Drawing.Size(47, 45);
            this.pcDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcDone.TabIndex = 99;
            this.pcDone.TabStop = false;
            this.pcDone.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::ReviewCheckList.Properties.Resources.save2;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Red;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSave.Location = new System.Drawing.Point(575, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(47, 42);
            this.btnSave.TabIndex = 97;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.btnRemember);
            this.Controls.Add(this.lblAvailableError);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtReportName);
            this.Controls.Add(this.lblReportName);
            this.Controls.Add(this.lblReportDirectory);
            this.Controls.Add(this.btnFolderBrows);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.pcDone);
            this.Controls.Add(this.btnSave);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(661, 327);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcDone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtReportName;
        private System.Windows.Forms.Label lblReportName;
        private System.Windows.Forms.Label lblReportDirectory;
        private System.Windows.Forms.Button btnFolderBrows;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnPrevious;
        public System.Windows.Forms.PictureBox pcDone;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAvailableError;
        private System.Windows.Forms.Button btnRemember;
        private System.Windows.Forms.ToolTip tpSaveWarning;
    }
}
