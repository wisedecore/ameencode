namespace WindowsFormsApplication2
{
    partial class Frmareacreate
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
            this.label9 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnote = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtareaname = new WindowsFormsApplication2.Uscnormaltextbox();
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
            this.CmdClear.Location = new System.Drawing.Point(204, 185);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(69, 34);
            this.CmdClear.TabIndex = 3;
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
            this.CmdSave.Location = new System.Drawing.Point(129, 185);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(69, 34);
            this.CmdSave.TabIndex = 2;
            this.CmdSave.Text = "Save(F5)";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(24, 61);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 133;
            this.label9.Text = "Area Name";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(13, 28);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(35, 20);
            this.TxtId.TabIndex = 132;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 135;
            this.label1.Text = "Note";
            // 
            // txtnote
            // 
            this.txtnote.Location = new System.Drawing.Point(144, 87);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(193, 60);
            this.txtnote.TabIndex = 1;
            this.txtnote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnote_KeyDown);
            // 
            // txtareaname
            // 
            this.txtareaname.Location = new System.Drawing.Point(144, 61);
            this.txtareaname.Name = "txtareaname";
            this.txtareaname.Size = new System.Drawing.Size(193, 20);
            this.txtareaname.TabIndex = 0;
            this.txtareaname.Leave += new System.EventHandler(this.txtareaname_Leave);
            // 
            // Frmareacreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(348, 262);
            this.Controls.Add(this.txtnote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.txtareaname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Frmareacreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party Area create";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Frmareacreate_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmareacreate_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmareacreate_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdSave;
        private Uscnormaltextbox txtareaname;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TxtId;
        private Uscnormaltextbox txtnote;
        private System.Windows.Forms.Label label1;

    }
}