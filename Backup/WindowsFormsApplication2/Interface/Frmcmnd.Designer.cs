namespace WindowsFormsApplication2
{
    partial class Frmcmnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcmnd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpasswrd = new System.Windows.Forms.TextBox();
            this.bttnok = new System.Windows.Forms.Button();
            this.cmdclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtuser
            // 
            this.txtuser.ForeColor = System.Drawing.Color.Red;
            this.txtuser.Location = new System.Drawing.Point(97, 23);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(212, 20);
            this.txtuser.TabIndex = 2;
            this.txtuser.UseSystemPasswordChar = true;
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            // 
            // txtpasswrd
            // 
            this.txtpasswrd.ForeColor = System.Drawing.Color.Red;
            this.txtpasswrd.Location = new System.Drawing.Point(97, 52);
            this.txtpasswrd.Name = "txtpasswrd";
            this.txtpasswrd.Size = new System.Drawing.Size(212, 20);
            this.txtpasswrd.TabIndex = 3;
            this.txtpasswrd.UseSystemPasswordChar = true;
            this.txtpasswrd.Leave += new System.EventHandler(this.txtpasswrd_Leave);
            this.txtpasswrd.Enter += new System.EventHandler(this.txtpasswrd_Enter);
            // 
            // bttnok
            // 
            this.bttnok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnok.Location = new System.Drawing.Point(159, 88);
            this.bttnok.Name = "bttnok";
            this.bttnok.Size = new System.Drawing.Size(75, 33);
            this.bttnok.TabIndex = 4;
            this.bttnok.Text = "OK";
            this.bttnok.UseVisualStyleBackColor = false;
            this.bttnok.Click += new System.EventHandler(this.bttnok_Click);
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
            this.cmdclose.Location = new System.Drawing.Point(249, 88);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(60, 34);
            this.cmdclose.TabIndex = 5;
            this.cmdclose.Text = "C&lose";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // Frmcmnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(332, 131);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.bttnok);
            this.Controls.Add(this.txtpasswrd);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Frmcmnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkin User";
            this.Load += new System.EventHandler(this.Frmcmnd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpasswrd;
        private System.Windows.Forms.Button bttnok;
        private System.Windows.Forms.Button cmdclose;
    }
}