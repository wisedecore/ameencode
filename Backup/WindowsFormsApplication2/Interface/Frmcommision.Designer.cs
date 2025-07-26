namespace WindowsFormsApplication2
{
    partial class Frmcommision
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
            this.label9 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.lblcst = new System.Windows.Forms.Label();
            this.lblvatper = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.txttoamount = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtfromamount = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtcommisionperc = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtcommisionname = new WindowsFormsApplication2.Uscnormaltextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.Comcommisionfor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 70;
            this.label9.Text = "Commision Name";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(5, 22);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(35, 20);
            this.TxtId.TabIndex = 69;
            // 
            // lblcst
            // 
            this.lblcst.AutoSize = true;
            this.lblcst.BackColor = System.Drawing.Color.Transparent;
            this.lblcst.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblcst.ForeColor = System.Drawing.Color.Black;
            this.lblcst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblcst.Location = new System.Drawing.Point(16, 124);
            this.lblcst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcst.Name = "lblcst";
            this.lblcst.Size = new System.Drawing.Size(86, 17);
            this.lblcst.TabIndex = 120;
            this.lblcst.Text = "From amount";
            // 
            // lblvatper
            // 
            this.lblvatper.AutoSize = true;
            this.lblvatper.BackColor = System.Drawing.Color.Transparent;
            this.lblvatper.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblvatper.ForeColor = System.Drawing.Color.Black;
            this.lblvatper.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblvatper.Location = new System.Drawing.Point(14, 96);
            this.lblvatper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvatper.Name = "lblvatper";
            this.lblvatper.Size = new System.Drawing.Size(101, 19);
            this.lblvatper.TabIndex = 119;
            this.lblvatper.Text = "Commision (%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 122;
            this.label1.Text = "To amount";
            // 
            // CmdClear
            // 
            this.CmdClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.CmdClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdClear.FlatAppearance.BorderSize = 0;
            this.CmdClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdClear.ForeColor = System.Drawing.Color.Black;
            this.CmdClear.Location = new System.Drawing.Point(194, 194);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(69, 34);
            this.CmdClear.TabIndex = 5;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = false;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.CmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdSave.FlatAppearance.BorderSize = 0;
            this.CmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Location = new System.Drawing.Point(119, 194);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(69, 34);
            this.CmdSave.TabIndex = 4;
            this.CmdSave.Text = "Save(F5)";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // txttoamount
            // 
            this.txttoamount.Location = new System.Drawing.Point(134, 152);
            this.txttoamount.Name = "txttoamount";
            this.txttoamount.Size = new System.Drawing.Size(158, 22);
            this.txttoamount.TabIndex = 3;
            this.txttoamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttoamount_KeyDown);
            // 
            // txtfromamount
            // 
            this.txtfromamount.Location = new System.Drawing.Point(134, 124);
            this.txtfromamount.Name = "txtfromamount";
            this.txtfromamount.Size = new System.Drawing.Size(158, 22);
            this.txtfromamount.TabIndex = 2;
            // 
            // txtcommisionperc
            // 
            this.txtcommisionperc.Location = new System.Drawing.Point(134, 96);
            this.txtcommisionperc.Name = "txtcommisionperc";
            this.txtcommisionperc.Size = new System.Drawing.Size(40, 22);
            this.txtcommisionperc.TabIndex = 1;
            // 
            // txtcommisionname
            // 
            this.txtcommisionname.Location = new System.Drawing.Point(134, 70);
            this.txtcommisionname.Name = "txtcommisionname";
            this.txtcommisionname.Size = new System.Drawing.Size(193, 20);
            this.txtcommisionname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 124;
            this.label2.Text = "Commision for";
            // 
            // Comcommisionfor
            // 
            this.Comcommisionfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Comcommisionfor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Comcommisionfor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comcommisionfor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Comcommisionfor.ForeColor = System.Drawing.Color.Black;
            this.Comcommisionfor.FormattingEnabled = true;
            this.Comcommisionfor.Items.AddRange(new object[] {
            "Employees",
            "Agent"});
            this.Comcommisionfor.Location = new System.Drawing.Point(134, 39);
            this.Comcommisionfor.Name = "Comcommisionfor";
            this.Comcommisionfor.Size = new System.Drawing.Size(193, 25);
            this.Comcommisionfor.TabIndex = 125;
            // 
            // Frmcommision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(332, 267);
            this.Controls.Add(this.Comcommisionfor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.txttoamount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfromamount);
            this.Controls.Add(this.txtcommisionperc);
            this.Controls.Add(this.lblcst);
            this.Controls.Add(this.lblvatper);
            this.Controls.Add(this.txtcommisionname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Frmcommision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commision slabs";
            this.Load += new System.EventHandler(this.Frmcommision_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmcommision_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmcommision_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Uscnormaltextbox txtcommisionname;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TxtId;
        private Uscnuemerictextbox txtfromamount;
        private Uscnuemerictextbox txtcommisionperc;
        private System.Windows.Forms.Label lblcst;
        private System.Windows.Forms.Label lblvatper;
        private Uscnuemerictextbox txttoamount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Comcommisionfor;
    }
}