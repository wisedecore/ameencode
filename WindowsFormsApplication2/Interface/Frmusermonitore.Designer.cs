namespace WindowsFormsApplication2
{
    partial class Frmusermonitore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmusermonitore));
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlleft = new System.Windows.Forms.Panel();
            this.chkallform = new System.Windows.Forms.CheckBox();
            this.chkallaction = new System.Windows.Forms.CheckBox();
            this.chkalluser = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkallcomputername = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comsystemname = new System.Windows.Forms.ComboBox();
            this.dtto = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtfrom = new System.Windows.Forms.DateTimePicker();
            this.comuser = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comform = new System.Windows.Forms.ComboBox();
            this.comaction = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlright = new System.Windows.Forms.Panel();
            this.cmdshow = new System.Windows.Forms.Button();
            this.cmdexporttoexcel = new System.Windows.Forms.Button();
            this.cmdclose = new System.Windows.Forms.Button();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            this.pnlleft.SuspendLayout();
            this.pnlright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.panel5.Controls.Add(this.pnlleft);
            this.panel5.Controls.Add(this.pnlright);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1142, 83);
            this.panel5.TabIndex = 70;
            // 
            // pnlleft
            // 
            this.pnlleft.Controls.Add(this.chkallform);
            this.pnlleft.Controls.Add(this.chkallaction);
            this.pnlleft.Controls.Add(this.chkalluser);
            this.pnlleft.Controls.Add(this.label1);
            this.pnlleft.Controls.Add(this.chkallcomputername);
            this.pnlleft.Controls.Add(this.label4);
            this.pnlleft.Controls.Add(this.comsystemname);
            this.pnlleft.Controls.Add(this.dtto);
            this.pnlleft.Controls.Add(this.label2);
            this.pnlleft.Controls.Add(this.Dtfrom);
            this.pnlleft.Controls.Add(this.comuser);
            this.pnlleft.Controls.Add(this.label6);
            this.pnlleft.Controls.Add(this.label3);
            this.pnlleft.Controls.Add(this.comform);
            this.pnlleft.Controls.Add(this.comaction);
            this.pnlleft.Controls.Add(this.label5);
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.Location = new System.Drawing.Point(0, 0);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(732, 83);
            this.pnlleft.TabIndex = 74;
            // 
            // chkallform
            // 
            this.chkallform.AutoSize = true;
            this.chkallform.Checked = true;
            this.chkallform.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkallform.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkallform.ForeColor = System.Drawing.Color.White;
            this.chkallform.Location = new System.Drawing.Point(377, 46);
            this.chkallform.Name = "chkallform";
            this.chkallform.Size = new System.Drawing.Size(41, 21);
            this.chkallform.TabIndex = 171;
            this.chkallform.Text = "All";
            this.chkallform.UseVisualStyleBackColor = true;
            // 
            // chkallaction
            // 
            this.chkallaction.AutoSize = true;
            this.chkallaction.Checked = true;
            this.chkallaction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkallaction.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkallaction.ForeColor = System.Drawing.Color.White;
            this.chkallaction.Location = new System.Drawing.Point(253, 47);
            this.chkallaction.Name = "chkallaction";
            this.chkallaction.Size = new System.Drawing.Size(41, 21);
            this.chkallaction.TabIndex = 170;
            this.chkallaction.Text = "All";
            this.chkallaction.UseVisualStyleBackColor = true;
            // 
            // chkalluser
            // 
            this.chkalluser.AutoSize = true;
            this.chkalluser.Checked = true;
            this.chkalluser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkalluser.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkalluser.ForeColor = System.Drawing.Color.White;
            this.chkalluser.Location = new System.Drawing.Point(129, 46);
            this.chkalluser.Name = "chkalluser";
            this.chkalluser.Size = new System.Drawing.Size(41, 21);
            this.chkalluser.TabIndex = 169;
            this.chkalluser.Text = "All";
            this.chkalluser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "System Name";
            // 
            // chkallcomputername
            // 
            this.chkallcomputername.AutoSize = true;
            this.chkallcomputername.Checked = true;
            this.chkallcomputername.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkallcomputername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkallcomputername.ForeColor = System.Drawing.Color.White;
            this.chkallcomputername.Location = new System.Drawing.Point(5, 47);
            this.chkallcomputername.Name = "chkallcomputername";
            this.chkallcomputername.Size = new System.Drawing.Size(41, 21);
            this.chkallcomputername.TabIndex = 168;
            this.chkallcomputername.Text = "All";
            this.chkallcomputername.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(547, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "From";
            // 
            // comsystemname
            // 
            this.comsystemname.FormattingEnabled = true;
            this.comsystemname.Location = new System.Drawing.Point(4, 25);
            this.comsystemname.Name = "comsystemname";
            this.comsystemname.Size = new System.Drawing.Size(121, 21);
            this.comsystemname.TabIndex = 13;
            // 
            // dtto
            // 
            this.dtto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtto.Location = new System.Drawing.Point(602, 35);
            this.dtto.Name = "dtto";
            this.dtto.Size = new System.Drawing.Size(115, 20);
            this.dtto.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(130, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "User";
            // 
            // Dtfrom
            // 
            this.Dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtfrom.Location = new System.Drawing.Point(602, 13);
            this.Dtfrom.Name = "Dtfrom";
            this.Dtfrom.Size = new System.Drawing.Size(115, 20);
            this.Dtfrom.TabIndex = 21;
            // 
            // comuser
            // 
            this.comuser.FormattingEnabled = true;
            this.comuser.Location = new System.Drawing.Point(129, 25);
            this.comuser.Name = "comuser";
            this.comuser.Size = new System.Drawing.Size(121, 21);
            this.comuser.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(547, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(254, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Action";
            // 
            // comform
            // 
            this.comform.FormattingEnabled = true;
            this.comform.Items.AddRange(new object[] {
            "Sales",
            "Purchase",
            "Receipt",
            "Payment",
            "Sales return",
            "Purchase return"});
            this.comform.Location = new System.Drawing.Point(377, 25);
            this.comform.Name = "comform";
            this.comform.Size = new System.Drawing.Size(121, 21);
            this.comform.TabIndex = 19;
            // 
            // comaction
            // 
            this.comaction.FormattingEnabled = true;
            this.comaction.Items.AddRange(new object[] {
            "New",
            "Update",
            "Delete"});
            this.comaction.Location = new System.Drawing.Point(253, 25);
            this.comaction.Name = "comaction";
            this.comaction.Size = new System.Drawing.Size(121, 21);
            this.comaction.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(377, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Form";
            // 
            // pnlright
            // 
            this.pnlright.Controls.Add(this.cmdshow);
            this.pnlright.Controls.Add(this.cmdexporttoexcel);
            this.pnlright.Controls.Add(this.cmdclose);
            this.pnlright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlright.Location = new System.Drawing.Point(745, 0);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(397, 83);
            this.pnlright.TabIndex = 73;
            // 
            // cmdshow
            // 
            this.cmdshow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdshow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdshow.ForeColor = System.Drawing.Color.Black;
            this.cmdshow.Location = new System.Drawing.Point(127, 42);
            this.cmdshow.Name = "cmdshow";
            this.cmdshow.Size = new System.Drawing.Size(75, 38);
            this.cmdshow.TabIndex = 73;
            this.cmdshow.Text = "Show";
            this.cmdshow.UseVisualStyleBackColor = false;
            this.cmdshow.Click += new System.EventHandler(this.cmdshow_Click);
            // 
            // cmdexporttoexcel
            // 
            this.cmdexporttoexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdexporttoexcel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdexporttoexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdexporttoexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdexporttoexcel.ForeColor = System.Drawing.Color.Black;
            this.cmdexporttoexcel.Location = new System.Drawing.Point(205, 42);
            this.cmdexporttoexcel.Name = "cmdexporttoexcel";
            this.cmdexporttoexcel.Size = new System.Drawing.Size(113, 38);
            this.cmdexporttoexcel.TabIndex = 74;
            this.cmdexporttoexcel.Text = "Export to Excel";
            this.cmdexporttoexcel.UseVisualStyleBackColor = false;
            this.cmdexporttoexcel.Click += new System.EventHandler(this.cmdexporttoexcel_Click);
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(320, 42);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 38);
            this.cmdclose.TabIndex = 74;
            this.cmdclose.Text = "Close";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // gridmain
            // 
            this.gridmain.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridmain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridmain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.gridmain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridmain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridmain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridmain.ColumnHeadersHeight = 31;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.Location = new System.Drawing.Point(0, 83);
            this.gridmain.MultiSelect = false;
            this.gridmain.Name = "gridmain";
            this.gridmain.ReadOnly = true;
            this.gridmain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridmain.RowHeadersVisible = false;
            this.gridmain.RowHeadersWidth = 100;
            this.gridmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridmain.Size = new System.Drawing.Size(1142, 336);
            this.gridmain.TabIndex = 71;
            // 
            // Frmusermonitore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 419);
            this.Controls.Add(this.gridmain);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmusermonitore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Monitore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmusermonitore_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmusermonitore_KeyPress);
            this.panel5.ResumeLayout(false);
            this.pnlleft.ResumeLayout(false);
            this.pnlleft.PerformLayout();
            this.pnlright.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button cmdexporttoexcel;
        private System.Windows.Forms.Button cmdshow;
        public System.Windows.Forms.DataGridView gridmain;
        private System.Windows.Forms.Panel pnlright;
        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.CheckBox chkallform;
        private System.Windows.Forms.CheckBox chkallaction;
        private System.Windows.Forms.CheckBox chkalluser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkallcomputername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comsystemname;
        private System.Windows.Forms.DateTimePicker dtto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtfrom;
        private System.Windows.Forms.ComboBox comuser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comform;
        private System.Windows.Forms.ComboBox comaction;
        private System.Windows.Forms.Label label5;
    }
}