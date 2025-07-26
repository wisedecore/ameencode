namespace WindowsFormsApplication2
{
    partial class frmdeletecomp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdeletecomp));
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.GridCheck = new System.Windows.Forms.DataGridView();
            this.clnchk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clntext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnaddress1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clntelephoneno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnweb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnacccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdClose
            // 
            this.CmdClose.BackColor = System.Drawing.Color.Transparent;
            this.CmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdClose.FlatAppearance.BorderSize = 0;
            this.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdClose.ForeColor = System.Drawing.Color.Black;
            this.CmdClose.Location = new System.Drawing.Point(816, 316);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(69, 34);
            this.CmdClose.TabIndex = 51;
            this.CmdClose.Text = "&Close";
            this.CmdClose.UseVisualStyleBackColor = false;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.BackColor = System.Drawing.Color.Transparent;
            this.CmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdDelete.FlatAppearance.BorderSize = 0;
            this.CmdDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDelete.ForeColor = System.Drawing.Color.Black;
            this.CmdDelete.Location = new System.Drawing.Point(741, 316);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(69, 34);
            this.CmdDelete.TabIndex = 50;
            this.CmdDelete.Text = "&Delete";
            this.CmdDelete.UseVisualStyleBackColor = false;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // GridCheck
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.GridCheck.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridCheck.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCheck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnchk,
            this.clntext,
            this.clnaddress1,
            this.clntelephoneno,
            this.clnemail,
            this.clnweb,
            this.clnacccount});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCheck.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridCheck.GridColor = System.Drawing.Color.Silver;
            this.GridCheck.Location = new System.Drawing.Point(0, 0);
            this.GridCheck.Name = "GridCheck";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCheck.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridCheck.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.GridCheck.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.GridCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCheck.Size = new System.Drawing.Size(888, 302);
            this.GridCheck.TabIndex = 56;
            this.GridCheck.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCheck_CellContentClick);
            // 
            // clnchk
            // 
            this.clnchk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clnchk.FalseValue = "0";
            this.clnchk.HeaderText = "";
            this.clnchk.Name = "clnchk";
            this.clnchk.TrueValue = "1";
            this.clnchk.Width = 50;
            // 
            // clntext
            // 
            this.clntext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clntext.HeaderText = "Company";
            this.clntext.Name = "clntext";
            this.clntext.Width = 185;
            // 
            // clnaddress1
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clnaddress1.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnaddress1.HeaderText = "Address";
            this.clnaddress1.Name = "clnaddress1";
            this.clnaddress1.Width = 150;
            // 
            // clntelephoneno
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clntelephoneno.DefaultCellStyle = dataGridViewCellStyle4;
            this.clntelephoneno.HeaderText = "Mobile";
            this.clntelephoneno.Name = "clntelephoneno";
            // 
            // clnemail
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clnemail.DefaultCellStyle = dataGridViewCellStyle5;
            this.clnemail.HeaderText = "Email";
            this.clnemail.Name = "clnemail";
            this.clnemail.Width = 150;
            // 
            // clnweb
            // 
            this.clnweb.HeaderText = "Website";
            this.clnweb.Name = "clnweb";
            // 
            // clnacccount
            // 
            this.clnacccount.HeaderText = "Account";
            this.clnacccount.Name = "clnacccount";
            this.clnacccount.Width = 150;
            // 
            // frmdeletecomp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(888, 362);
            this.Controls.Add(this.GridCheck);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmdeletecomp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Company";
            this.Load += new System.EventHandler(this.frmdeletecomp_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmdeletecomp_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.GridCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.DataGridView GridCheck;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnchk;
        private System.Windows.Forms.DataGridViewTextBoxColumn clntext;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnaddress1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clntelephoneno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnweb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnacccount;
    }
}