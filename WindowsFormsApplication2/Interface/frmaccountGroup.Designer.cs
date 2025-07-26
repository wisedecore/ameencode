namespace WindowsFormsApplication2
{
    partial class frmaccountGroup
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
            this.ComUnder = new System.Windows.Forms.ComboBox();
            this.Cmdclose = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtGroupName = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComUnder
            // 
            this.ComUnder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComUnder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComUnder.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComUnder.FormattingEnabled = true;
            this.ComUnder.Location = new System.Drawing.Point(154, 57);
            this.ComUnder.Name = "ComUnder";
            this.ComUnder.Size = new System.Drawing.Size(216, 21);
            this.ComUnder.TabIndex = 73;
            this.ComUnder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComUnder_KeyPress);
            // 
            // Cmdclose
            // 
            this.Cmdclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cmdclose.FlatAppearance.BorderSize = 0;
            this.Cmdclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmdclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmdclose.ForeColor = System.Drawing.Color.Black;
            this.Cmdclose.Location = new System.Drawing.Point(229, 93);
            this.Cmdclose.Name = "Cmdclose";
            this.Cmdclose.Size = new System.Drawing.Size(69, 34);
            this.Cmdclose.TabIndex = 72;
            this.Cmdclose.Text = "C&lose";
            this.Cmdclose.UseVisualStyleBackColor = false;
            this.Cmdclose.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdSave.FlatAppearance.BorderSize = 0;
            this.CmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Location = new System.Drawing.Point(154, 93);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(69, 34);
            this.CmdSave.TabIndex = 71;
            this.CmdSave.Text = "Save(F5)";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 70;
            this.label2.Text = "Under";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 69;
            this.label1.Text = "Group Name";
            // 
            // TxtGroupName
            // 
            this.TxtGroupName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGroupName.Location = new System.Drawing.Point(154, 25);
            this.TxtGroupName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtGroupName.Name = "TxtGroupName";
            this.TxtGroupName.Size = new System.Drawing.Size(216, 22);
            this.TxtGroupName.TabIndex = 68;
            this.TxtGroupName.Text = "sfdsdsdasds";
            this.TxtGroupName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGroupName_KeyPress);
            this.TxtGroupName.Enter += new System.EventHandler(this.TxtGroupName_Enter);
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(12, 97);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(51, 20);
            this.TxtId.TabIndex = 74;
            this.TxtId.Visible = false;
            // 
            // frmaccountGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(387, 166);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.ComUnder);
            this.Controls.Add(this.Cmdclose);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtGroupName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmaccountGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledger Group";
            this.Load += new System.EventHandler(this.frmaccountGroup_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmaccountGroup_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmaccountGroup_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cmdclose;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtGroupName;
        public System.Windows.Forms.ComboBox ComUnder;
        public System.Windows.Forms.TextBox TxtId;
    }
}