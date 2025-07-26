namespace WindowsFormsApplication2
{
    partial class Frmcreatesizes
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
            this.label2 = new System.Windows.Forms.Label();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Txtsizename = new WindowsFormsApplication2.Uscnormaltextbox();
            this.Txtremarks = new WindowsFormsApplication2.Uscnormaltextbox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 19);
            this.label9.TabIndex = 150;
            this.label9.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 152;
            this.label2.Text = "Remarks";
            // 
            // CmdClose
            // 
            this.CmdClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.CmdClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdClose.FlatAppearance.BorderSize = 0;
            this.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdClose.ForeColor = System.Drawing.Color.Black;
            this.CmdClose.Location = new System.Drawing.Point(220, 106);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(69, 34);
            this.CmdClose.TabIndex = 155;
            this.CmdClose.Text = "C&lose";
            this.CmdClose.UseVisualStyleBackColor = false;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.CmdClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdClear.FlatAppearance.BorderSize = 0;
            this.CmdClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdClear.ForeColor = System.Drawing.Color.Black;
            this.CmdClear.Location = new System.Drawing.Point(148, 106);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(69, 34);
            this.CmdClear.TabIndex = 154;
            this.CmdClear.Text = "&Clear";
            this.CmdClear.UseVisualStyleBackColor = false;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.CmdSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdSave.FlatAppearance.BorderSize = 0;
            this.CmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Location = new System.Drawing.Point(77, 106);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(69, 34);
            this.CmdSave.TabIndex = 153;
            this.CmdSave.Text = "&Save(F5)";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.Location = new System.Drawing.Point(24, 0);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(29, 18);
            this.txtid.TabIndex = 156;
            // 
            // Txtsizename
            // 
            this.Txtsizename.Location = new System.Drawing.Point(128, 16);
            this.Txtsizename.Name = "Txtsizename";
            this.Txtsizename.Size = new System.Drawing.Size(158, 22);
            this.Txtsizename.TabIndex = 0;
            // 
            // Txtremarks
            // 
            this.Txtremarks.Location = new System.Drawing.Point(128, 45);
            this.Txtremarks.Name = "Txtremarks";
            this.Txtremarks.Size = new System.Drawing.Size(158, 55);
            this.Txtremarks.TabIndex = 158;
            // 
            // Frmcreatesizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(336, 158);
            this.Controls.Add(this.Txtremarks);
            this.Controls.Add(this.Txtsizename);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmcreatesizes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create sizes";
            this.Load += new System.EventHandler(this.Frmcreatesizes_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmcreatesizes_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdSave;
        public System.Windows.Forms.TextBox txtid;
        private Uscnormaltextbox Txtsizename;
        private Uscnormaltextbox Txtremarks;
    }
}