namespace WindowsFormsApplication2
{
    partial class FrmAgentCreate
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAgentCode = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtAgentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCommission = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtArea = new System.Windows.Forms.TextBox();
            this.ChkAccountsInclude = new System.Windows.Forms.CheckBox();
            this.cmdclose = new System.Windows.Forms.Button();
            this.cmdclear = new System.Windows.Forms.Button();
            this.cmdsave = new System.Windows.Forms.Button();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(274, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 224);
            this.panel4.TabIndex = 69;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(274, 10);
            this.panel5.TabIndex = 68;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(10, 234);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(274, 10);
            this.panel6.TabIndex = 67;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 244);
            this.panel7.TabIndex = 66;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(91, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 17);
            this.label21.TabIndex = 72;
            this.label21.Text = "Agent Create";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label20.Location = new System.Drawing.Point(25, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(238, 13);
            this.label20.TabIndex = 73;
            this.label20.Text = "-----------------------------------------------------------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 97;
            this.label1.Text = "Agent Code";
            // 
            // TxtAgentCode
            // 
            this.TxtAgentCode.Location = new System.Drawing.Point(142, 73);
            this.TxtAgentCode.Name = "TxtAgentCode";
            this.TxtAgentCode.Size = new System.Drawing.Size(121, 20);
            this.TxtAgentCode.TabIndex = 96;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(13, 45);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(86, 17);
            this.LblName.TabIndex = 95;
            this.LblName.Text = "Agent Name";
            // 
            // TxtAgentName
            // 
            this.TxtAgentName.Location = new System.Drawing.Point(142, 45);
            this.TxtAgentName.Name = "TxtAgentName";
            this.TxtAgentName.Size = new System.Drawing.Size(121, 20);
            this.TxtAgentName.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 101;
            this.label2.Text = "Commission";
            // 
            // TxtCommission
            // 
            this.TxtCommission.Location = new System.Drawing.Point(142, 127);
            this.TxtCommission.Name = "TxtCommission";
            this.TxtCommission.Size = new System.Drawing.Size(121, 20);
            this.TxtCommission.TabIndex = 100;
            this.TxtCommission.Tag = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 99;
            this.label3.Text = "Area";
            // 
            // TxtArea
            // 
            this.TxtArea.Location = new System.Drawing.Point(142, 99);
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.Size = new System.Drawing.Size(121, 20);
            this.TxtArea.TabIndex = 98;
            // 
            // ChkAccountsInclude
            // 
            this.ChkAccountsInclude.AutoSize = true;
            this.ChkAccountsInclude.ForeColor = System.Drawing.Color.White;
            this.ChkAccountsInclude.Location = new System.Drawing.Point(16, 161);
            this.ChkAccountsInclude.Name = "ChkAccountsInclude";
            this.ChkAccountsInclude.Size = new System.Drawing.Size(106, 17);
            this.ChkAccountsInclude.TabIndex = 102;
            this.ChkAccountsInclude.Text = "Post in Accounts";
            this.ChkAccountsInclude.UseVisualStyleBackColor = true;
            this.ChkAccountsInclude.CheckedChanged += new System.EventHandler(this.ChkAccountsInclude_CheckedChanged);
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.Silver;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(185, 187);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 36);
            this.cmdclose.TabIndex = 111;
            this.cmdclose.Text = "C&lose";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.BackColor = System.Drawing.Color.Silver;
            this.cmdclear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclear.ForeColor = System.Drawing.Color.Black;
            this.cmdclear.Location = new System.Drawing.Point(107, 187);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(75, 36);
            this.cmdclear.TabIndex = 110;
            this.cmdclear.Text = "&Clear";
            this.cmdclear.UseVisualStyleBackColor = false;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // cmdsave
            // 
            this.cmdsave.BackColor = System.Drawing.Color.Silver;
            this.cmdsave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsave.ForeColor = System.Drawing.Color.Black;
            this.cmdsave.Location = new System.Drawing.Point(30, 187);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(75, 36);
            this.cmdsave.TabIndex = 109;
            this.cmdsave.Text = "&Save";
            this.cmdsave.UseVisualStyleBackColor = false;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(27, 12);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(58, 20);
            this.Txtid.TabIndex = 112;
            // 
            // FrmAgentCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(284, 244);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.cmdclear);
            this.Controls.Add(this.cmdsave);
            this.Controls.Add(this.ChkAccountsInclude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCommission);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAgentCode);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtAgentName);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmAgentCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgentCreate";
            this.Load += new System.EventHandler(this.FrmAgentCreate_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmAgentCreate_KeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FrmAgentCreate_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAgentCode;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtAgentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCommission;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtArea;
        private System.Windows.Forms.CheckBox ChkAccountsInclude;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Button cmdsave;
        private System.Windows.Forms.TextBox Txtid;
    }
}