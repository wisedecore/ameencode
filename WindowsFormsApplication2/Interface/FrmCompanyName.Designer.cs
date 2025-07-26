namespace WindowsFormsApplication2
{
    partial class FrmCompanyName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompanyName));
            this.lblheading = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CmdOk = new System.Windows.Forms.Button();
            this.PrgMain = new System.Windows.Forms.ProgressBar();
            this.chkbakcompany = new System.Windows.Forms.CheckBox();
            this.txtbakpassword = new System.Windows.Forms.TextBox();
            this.TxtFileName = new WindowsFormsApplication2.Uscnormaltextbox();
            this.SuspendLayout();
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.ForeColor = System.Drawing.Color.Black;
            this.lblheading.Location = new System.Drawing.Point(12, 13);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(237, 17);
            this.lblheading.TabIndex = 73;
            this.lblheading.Text = "Enter the Company name then click OK.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(42, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 76;
            this.label9.Text = "Company Name";
            // 
            // CmdOk
            // 
            this.CmdOk.BackColor = System.Drawing.Color.Transparent;
            this.CmdOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdOk.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdOk.FlatAppearance.BorderSize = 0;
            this.CmdOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdOk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdOk.ForeColor = System.Drawing.Color.Black;
            this.CmdOk.Location = new System.Drawing.Point(144, 80);
            this.CmdOk.Name = "CmdOk";
            this.CmdOk.Size = new System.Drawing.Size(83, 34);
            this.CmdOk.TabIndex = 100;
            this.CmdOk.Text = "&OK";
            this.CmdOk.UseVisualStyleBackColor = false;
            this.CmdOk.Click += new System.EventHandler(this.CmdOk_Click);
            // 
            // PrgMain
            // 
            this.PrgMain.Location = new System.Drawing.Point(16, 119);
            this.PrgMain.Name = "PrgMain";
            this.PrgMain.Size = new System.Drawing.Size(413, 23);
            this.PrgMain.Step = 1;
            this.PrgMain.TabIndex = 101;
            // 
            // chkbakcompany
            // 
            this.chkbakcompany.AutoSize = true;
            this.chkbakcompany.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbakcompany.ForeColor = System.Drawing.Color.Black;
            this.chkbakcompany.Location = new System.Drawing.Point(144, 34);
            this.chkbakcompany.Name = "chkbakcompany";
            this.chkbakcompany.Size = new System.Drawing.Size(102, 21);
            this.chkbakcompany.TabIndex = 102;
            this.chkbakcompany.Text = "BakCompany";
            this.chkbakcompany.UseVisualStyleBackColor = true;
            this.chkbakcompany.Visible = false;
            // 
            // txtbakpassword
            // 
            this.txtbakpassword.BackColor = System.Drawing.Color.Gray;
            this.txtbakpassword.Location = new System.Drawing.Point(253, 32);
            this.txtbakpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtbakpassword.Name = "txtbakpassword";
            this.txtbakpassword.Size = new System.Drawing.Size(108, 20);
            this.txtbakpassword.TabIndex = 103;
            this.txtbakpassword.Visible = false;
            // 
            // TxtFileName
            // 
            this.TxtFileName.Location = new System.Drawing.Point(148, 54);
            this.TxtFileName.Name = "TxtFileName";
            this.TxtFileName.Size = new System.Drawing.Size(285, 23);
            this.TxtFileName.TabIndex = 0;
            this.TxtFileName.TextChanged += new WindowsFormsApplication2.Uscnormaltextbox.DelTextChanged(this.TxtFileName_TextChanged);
            this.TxtFileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFileName_KeyPress);
            // 
            // FrmCompanyName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(445, 158);
            this.Controls.Add(this.TxtFileName);
            this.Controls.Add(this.txtbakpassword);
            this.Controls.Add(this.chkbakcompany);
            this.Controls.Add(this.PrgMain);
            this.Controls.Add(this.CmdOk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblheading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmCompanyName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Name";
            this.Load += new System.EventHandler(this.FrmCompanyName_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCompanyName_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CmdOk;
        public System.Windows.Forms.ProgressBar PrgMain;
        private System.Windows.Forms.CheckBox chkbakcompany;
        private System.Windows.Forms.TextBox txtbakpassword;
        private Uscnormaltextbox TxtFileName;
    }
}