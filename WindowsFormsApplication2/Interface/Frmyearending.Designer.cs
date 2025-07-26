namespace WindowsFormsApplication2
{
    partial class Frmyearending
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
            this.pnlottom = new System.Windows.Forms.Panel();
            this.cmdcancel = new System.Windows.Forms.Button();
            this.cmdok = new System.Windows.Forms.Button();
            this.tbmain = new System.Windows.Forms.TabControl();
            this.tbgeneral = new System.Windows.Forms.TabPage();
            this.CHKSTOKTRANSFER = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNextyr = new System.Windows.Forms.DateTimePicker();
            this.chkremoveminusstock = new System.Windows.Forms.CheckBox();
            this.txtwarning = new System.Windows.Forms.TextBox();
            this.lblyearendason = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.txtcompanyname = new System.Windows.Forms.TextBox();
            this.tbmasters = new System.Windows.Forms.TabPage();
            this.tbaccounts = new System.Windows.Forms.TabPage();
            this.chkVOUCHER = new System.Windows.Forms.CheckBox();
            this.pnlottom.SuspendLayout();
            this.tbmain.SuspendLayout();
            this.tbgeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlottom
            // 
            this.pnlottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.pnlottom.Controls.Add(this.cmdcancel);
            this.pnlottom.Controls.Add(this.cmdok);
            this.pnlottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlottom.Location = new System.Drawing.Point(0, 293);
            this.pnlottom.Name = "pnlottom";
            this.pnlottom.Size = new System.Drawing.Size(494, 49);
            this.pnlottom.TabIndex = 0;
            // 
            // cmdcancel
            // 
            this.cmdcancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdcancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdcancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcancel.ForeColor = System.Drawing.Color.Black;
            this.cmdcancel.Location = new System.Drawing.Point(248, 6);
            this.cmdcancel.Name = "cmdcancel";
            this.cmdcancel.Size = new System.Drawing.Size(75, 36);
            this.cmdcancel.TabIndex = 32;
            this.cmdcancel.Text = "Cancel";
            this.cmdcancel.UseVisualStyleBackColor = false;
            // 
            // cmdok
            // 
            this.cmdok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdok.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdok.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdok.ForeColor = System.Drawing.Color.Black;
            this.cmdok.Location = new System.Drawing.Point(170, 6);
            this.cmdok.Name = "cmdok";
            this.cmdok.Size = new System.Drawing.Size(75, 36);
            this.cmdok.TabIndex = 31;
            this.cmdok.Text = "Ok";
            this.cmdok.UseVisualStyleBackColor = false;
            this.cmdok.Click += new System.EventHandler(this.cmdok_Click);
            // 
            // tbmain
            // 
            this.tbmain.Controls.Add(this.tbgeneral);
            this.tbmain.Controls.Add(this.tbmasters);
            this.tbmain.Controls.Add(this.tbaccounts);
            this.tbmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbmain.Location = new System.Drawing.Point(0, 0);
            this.tbmain.Name = "tbmain";
            this.tbmain.SelectedIndex = 0;
            this.tbmain.Size = new System.Drawing.Size(494, 293);
            this.tbmain.TabIndex = 1;
            // 
            // tbgeneral
            // 
            this.tbgeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.tbgeneral.Controls.Add(this.chkVOUCHER);
            this.tbgeneral.Controls.Add(this.CHKSTOKTRANSFER);
            this.tbgeneral.Controls.Add(this.label1);
            this.tbgeneral.Controls.Add(this.dtNextyr);
            this.tbgeneral.Controls.Add(this.chkremoveminusstock);
            this.tbgeneral.Controls.Add(this.txtwarning);
            this.tbgeneral.Controls.Add(this.lblyearendason);
            this.tbgeneral.Controls.Add(this.label68);
            this.tbgeneral.Controls.Add(this.txtcompanyname);
            this.tbgeneral.Location = new System.Drawing.Point(4, 22);
            this.tbgeneral.Name = "tbgeneral";
            this.tbgeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tbgeneral.Size = new System.Drawing.Size(486, 267);
            this.tbgeneral.TabIndex = 0;
            this.tbgeneral.Text = "General";
            // 
            // CHKSTOKTRANSFER
            // 
            this.CHKSTOKTRANSFER.AutoSize = true;
            this.CHKSTOKTRANSFER.Checked = true;
            this.CHKSTOKTRANSFER.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHKSTOKTRANSFER.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKSTOKTRANSFER.ForeColor = System.Drawing.Color.Blue;
            this.CHKSTOKTRANSFER.Location = new System.Drawing.Point(10, 135);
            this.CHKSTOKTRANSFER.Name = "CHKSTOKTRANSFER";
            this.CHKSTOKTRANSFER.Size = new System.Drawing.Size(143, 18);
            this.CHKSTOKTRANSFER.TabIndex = 34;
            this.CHKSTOKTRANSFER.Text = "Allow Stock transfer";
            this.CHKSTOKTRANSFER.UseVisualStyleBackColor = true;
            this.CHKSTOKTRANSFER.CheckedChanged += new System.EventHandler(this.CHKSTOKTRANSFER_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(148, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 14);
            this.label1.TabIndex = 33;
            this.label1.Text = "Next Financial year start";
            // 
            // dtNextyr
            // 
            this.dtNextyr.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNextyr.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtNextyr.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtNextyr.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtNextyr.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtNextyr.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtNextyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNextyr.Location = new System.Drawing.Point(307, 43);
            this.dtNextyr.Name = "dtNextyr";
            this.dtNextyr.Size = new System.Drawing.Size(155, 21);
            this.dtNextyr.TabIndex = 32;
            // 
            // chkremoveminusstock
            // 
            this.chkremoveminusstock.AutoSize = true;
            this.chkremoveminusstock.Checked = true;
            this.chkremoveminusstock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkremoveminusstock.Enabled = false;
            this.chkremoveminusstock.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkremoveminusstock.ForeColor = System.Drawing.Color.Blue;
            this.chkremoveminusstock.Location = new System.Drawing.Point(9, 159);
            this.chkremoveminusstock.Name = "chkremoveminusstock";
            this.chkremoveminusstock.Size = new System.Drawing.Size(146, 18);
            this.chkremoveminusstock.TabIndex = 31;
            this.chkremoveminusstock.Text = "Remove minus Stock";
            this.chkremoveminusstock.UseVisualStyleBackColor = true;
            this.chkremoveminusstock.CheckedChanged += new System.EventHandler(this.chkremoveminusstock_CheckedChanged);
            // 
            // txtwarning
            // 
            this.txtwarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txtwarning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtwarning.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwarning.ForeColor = System.Drawing.Color.Red;
            this.txtwarning.Location = new System.Drawing.Point(3, 69);
            this.txtwarning.Multiline = true;
            this.txtwarning.Name = "txtwarning";
            this.txtwarning.Size = new System.Drawing.Size(461, 60);
            this.txtwarning.TabIndex = 30;
            this.txtwarning.Text = "You can use the current company\r\n as usual,after running the year end Routine.\r\nc" +
                "ompany";
            // 
            // lblyearendason
            // 
            this.lblyearendason.AutoSize = true;
            this.lblyearendason.BackColor = System.Drawing.Color.Transparent;
            this.lblyearendason.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyearendason.ForeColor = System.Drawing.Color.Black;
            this.lblyearendason.Location = new System.Drawing.Point(8, 36);
            this.lblyearendason.Name = "lblyearendason";
            this.lblyearendason.Size = new System.Drawing.Size(100, 16);
            this.lblyearendason.TabIndex = 29;
            this.lblyearendason.Text = "Year End as on";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.Color.Transparent;
            this.label68.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.Color.Black;
            this.label68.Location = new System.Drawing.Point(6, 17);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(136, 16);
            this.label68.TabIndex = 28;
            this.label68.Text = "New Company Name";
            // 
            // txtcompanyname
            // 
            this.txtcompanyname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompanyname.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtcompanyname.Location = new System.Drawing.Point(151, 17);
            this.txtcompanyname.Name = "txtcompanyname";
            this.txtcompanyname.Size = new System.Drawing.Size(313, 25);
            this.txtcompanyname.TabIndex = 27;
            this.txtcompanyname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcompanyname_KeyPress);
            // 
            // tbmasters
            // 
            this.tbmasters.Location = new System.Drawing.Point(4, 22);
            this.tbmasters.Name = "tbmasters";
            this.tbmasters.Padding = new System.Windows.Forms.Padding(3);
            this.tbmasters.Size = new System.Drawing.Size(486, 187);
            this.tbmasters.TabIndex = 1;
            this.tbmasters.Text = "Masters";
            this.tbmasters.UseVisualStyleBackColor = true;
            // 
            // tbaccounts
            // 
            this.tbaccounts.Location = new System.Drawing.Point(4, 22);
            this.tbaccounts.Name = "tbaccounts";
            this.tbaccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tbaccounts.Size = new System.Drawing.Size(486, 187);
            this.tbaccounts.TabIndex = 2;
            this.tbaccounts.Text = "Accounts";
            this.tbaccounts.UseVisualStyleBackColor = true;
            // 
            // chkVOUCHER
            // 
            this.chkVOUCHER.AutoSize = true;
            this.chkVOUCHER.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.chkVOUCHER.ForeColor = System.Drawing.Color.Blue;
            this.chkVOUCHER.Location = new System.Drawing.Point(9, 183);
            this.chkVOUCHER.Name = "chkVOUCHER";
            this.chkVOUCHER.Size = new System.Drawing.Size(107, 18);
            this.chkVOUCHER.TabIndex = 35;
            this.chkVOUCHER.Text = "Vno start on 1";
            this.chkVOUCHER.UseVisualStyleBackColor = true;
            // 
            // Frmyearending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(494, 342);
            this.Controls.Add(this.tbmain);
            this.Controls.Add(this.pnlottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frmyearending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Year Ending";
            this.Load += new System.EventHandler(this.Frmyearending_Load);
            this.pnlottom.ResumeLayout(false);
            this.tbmain.ResumeLayout(false);
            this.tbgeneral.ResumeLayout(false);
            this.tbgeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlottom;
        private System.Windows.Forms.Button cmdcancel;
        private System.Windows.Forms.Button cmdok;
        private System.Windows.Forms.TabControl tbmain;
        private System.Windows.Forms.TabPage tbgeneral;
        private System.Windows.Forms.TabPage tbmasters;
        private System.Windows.Forms.TabPage tbaccounts;
        private System.Windows.Forms.Label lblyearendason;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox txtcompanyname;
        private System.Windows.Forms.TextBox txtwarning;
        private System.Windows.Forms.CheckBox chkremoveminusstock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNextyr;
        private System.Windows.Forms.CheckBox CHKSTOKTRANSFER;
        private System.Windows.Forms.CheckBox chkVOUCHER;
    }
}