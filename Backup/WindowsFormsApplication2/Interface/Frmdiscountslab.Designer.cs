namespace WindowsFormsApplication2
{
    partial class Frmdiscountslab
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
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcst = new System.Windows.Forms.Label();
            this.lblvatper = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.txttoamount = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtfromamount = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtdiscountperc = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.Txtdiscountname = new WindowsFormsApplication2.Uscnormaltextbox();
            this.SuspendLayout();
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
            this.CmdClear.Location = new System.Drawing.Point(187, 176);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(69, 34);
            this.CmdClear.TabIndex = 131;
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
            this.CmdSave.Location = new System.Drawing.Point(112, 176);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(69, 34);
            this.CmdSave.TabIndex = 130;
            this.CmdSave.Text = "Save(F5)";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(9, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 136;
            this.label1.Text = "To amount";
            // 
            // lblcst
            // 
            this.lblcst.AutoSize = true;
            this.lblcst.BackColor = System.Drawing.Color.Transparent;
            this.lblcst.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblcst.ForeColor = System.Drawing.Color.Black;
            this.lblcst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblcst.Location = new System.Drawing.Point(9, 91);
            this.lblcst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcst.Name = "lblcst";
            this.lblcst.Size = new System.Drawing.Size(86, 17);
            this.lblcst.TabIndex = 135;
            this.lblcst.Text = "From amount";
            // 
            // lblvatper
            // 
            this.lblvatper.AutoSize = true;
            this.lblvatper.BackColor = System.Drawing.Color.Transparent;
            this.lblvatper.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblvatper.ForeColor = System.Drawing.Color.Black;
            this.lblvatper.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblvatper.Location = new System.Drawing.Point(7, 63);
            this.lblvatper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvatper.Name = "lblvatper";
            this.lblvatper.Size = new System.Drawing.Size(86, 19);
            this.lblvatper.TabIndex = 134;
            this.lblvatper.Text = "Discount (%)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(7, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 133;
            this.label9.Text = "Discount Name";
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(14, 4);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(35, 20);
            this.TxtId.TabIndex = 132;
            // 
            // txttoamount
            // 
            this.txttoamount.Location = new System.Drawing.Point(127, 119);
            this.txttoamount.Name = "txttoamount";
            this.txttoamount.Size = new System.Drawing.Size(158, 22);
            this.txttoamount.TabIndex = 129;
            // 
            // txtfromamount
            // 
            this.txtfromamount.Location = new System.Drawing.Point(127, 91);
            this.txtfromamount.Name = "txtfromamount";
            this.txtfromamount.Size = new System.Drawing.Size(158, 22);
            this.txtfromamount.TabIndex = 128;
            // 
            // txtdiscountperc
            // 
            this.txtdiscountperc.Location = new System.Drawing.Point(127, 63);
            this.txtdiscountperc.Name = "txtdiscountperc";
            this.txtdiscountperc.Size = new System.Drawing.Size(40, 22);
            this.txtdiscountperc.TabIndex = 127;
            // 
            // Txtdiscountname
            // 
            this.Txtdiscountname.Location = new System.Drawing.Point(127, 37);
            this.Txtdiscountname.Name = "Txtdiscountname";
            this.Txtdiscountname.Size = new System.Drawing.Size(193, 20);
            this.Txtdiscountname.TabIndex = 126;
            // 
            // Frmdiscountslab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(321, 223);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.txttoamount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfromamount);
            this.Controls.Add(this.txtdiscountperc);
            this.Controls.Add(this.lblcst);
            this.Controls.Add(this.lblvatper);
            this.Controls.Add(this.Txtdiscountname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frmdiscountslab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discount slab create";
            this.Load += new System.EventHandler(this.Frmdiscountslab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdSave;
        private Uscnuemerictextbox txttoamount;
        private System.Windows.Forms.Label label1;
        private Uscnuemerictextbox txtfromamount;
        private Uscnuemerictextbox txtdiscountperc;
        private System.Windows.Forms.Label lblcst;
        private System.Windows.Forms.Label lblvatper;
        private Uscnormaltextbox Txtdiscountname;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TxtId;
    }
}