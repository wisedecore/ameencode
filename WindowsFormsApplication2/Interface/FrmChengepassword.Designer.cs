namespace WindowsFormsApplication2
{
    partial class FrmChengepassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdchange = new System.Windows.Forms.Button();
            this.cmdclose = new System.Windows.Forms.Button();
            this.comuser = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtconfirmpassword = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtnewpassword = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtoldpassword = new WindowsFormsApplication2.Uscnormaltextbox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(18, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Old Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Confirm Password";
            // 
            // cmdchange
            // 
            this.cmdchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdchange.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdchange.FlatAppearance.BorderSize = 0;
            this.cmdchange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdchange.ForeColor = System.Drawing.Color.Black;
            this.cmdchange.Location = new System.Drawing.Point(142, 122);
            this.cmdchange.Name = "cmdchange";
            this.cmdchange.Size = new System.Drawing.Size(89, 34);
            this.cmdchange.TabIndex = 35;
            this.cmdchange.Text = "Change(F5)";
            this.cmdchange.UseVisualStyleBackColor = false;
            this.cmdchange.Click += new System.EventHandler(this.cmdchange_Click);
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatAppearance.BorderSize = 0;
            this.cmdclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(237, 122);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(56, 34);
            this.cmdclose.TabIndex = 36;
            this.cmdclose.Text = "C&lose";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // comuser
            // 
            this.comuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comuser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comuser.FormattingEnabled = true;
            this.comuser.Items.AddRange(new object[] {
            "CASH",
            "CREDIT",
            "CARD"});
            this.comuser.Location = new System.Drawing.Point(142, 14);
            this.comuser.Name = "comuser";
            this.comuser.Size = new System.Drawing.Size(155, 21);
            this.comuser.TabIndex = 1;
            this.comuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comuser_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "User";
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Location = new System.Drawing.Point(143, 94);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(154, 26);
            this.txtconfirmpassword.TabIndex = 4;
            this.txtconfirmpassword.Leave += new System.EventHandler(this.txtconfirmpassword_Leave);
            this.txtconfirmpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtconfirmpassword_KeyPress);
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(142, 65);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(155, 27);
            this.txtnewpassword.TabIndex = 3;
            this.txtnewpassword.Leave += new System.EventHandler(this.txtnewpassword_Leave);
            this.txtnewpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnewpassword_KeyPress);
            // 
            // txtoldpassword
            // 
            this.txtoldpassword.Location = new System.Drawing.Point(142, 39);
            this.txtoldpassword.Name = "txtoldpassword";
            this.txtoldpassword.Size = new System.Drawing.Size(155, 25);
            this.txtoldpassword.TabIndex = 2;
            this.txtoldpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtoldpassword_KeyPress);
            // 
            // FrmChengepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(320, 171);
            this.Controls.Add(this.txtconfirmpassword);
        
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.txtoldpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comuser);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.cmdchange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmChengepassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.FrmChengepassword_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmChengepassword_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmChengepassword_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdchange;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.ComboBox comuser;
        private System.Windows.Forms.Label label3;
        private Uscnormaltextbox txtoldpassword;
        private Uscnormaltextbox txtnewpassword;
        private Uscnormaltextbox txtconfirmpassword;

    }
}