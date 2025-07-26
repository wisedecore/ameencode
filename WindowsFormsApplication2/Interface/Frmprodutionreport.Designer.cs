namespace WindowsFormsApplication2
{
    partial class Frmprodutionreport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmprodutionreport));
            this.CmdClear = new System.Windows.Forms.Button();
            this.cmdshow = new System.Windows.Forms.Button();
            this.dtdatefrom = new System.Windows.Forms.DateTimePicker();
            this.dtdateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gridmain = new System.Windows.Forms.DataGridView();
            this.clnname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnbarid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtitemwise = new System.Windows.Forms.TextBox();
            this.TXTBATCH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkbcodewise = new System.Windows.Forms.CheckBox();
            this.CHKvnowise = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpkdto = new System.Windows.Forms.DateTimePicker();
            this.dtpkdfrom = new System.Windows.Forms.DateTimePicker();
            this.chkpkddate = new System.Windows.Forms.CheckBox();
            this.Txtbarcode = new WindowsFormsApplication2.Uscnormaltextbox();
            this.TXTvno = new WindowsFormsApplication2.Uscnuemerictextbox();
            ((System.ComponentModel.ISupportInitialize)(this.Gridmain)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdClear
            // 
            this.CmdClear.BackColor = System.Drawing.Color.Moccasin;
            this.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CmdClear.Location = new System.Drawing.Point(231, 315);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(87, 40);
            this.CmdClear.TabIndex = 39;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = false;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // cmdshow
            // 
            this.cmdshow.BackColor = System.Drawing.Color.Moccasin;
            this.cmdshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmdshow.Location = new System.Drawing.Point(325, 315);
            this.cmdshow.Name = "cmdshow";
            this.cmdshow.Size = new System.Drawing.Size(87, 40);
            this.cmdshow.TabIndex = 40;
            this.cmdshow.Text = "Show";
            this.cmdshow.UseVisualStyleBackColor = false;
            this.cmdshow.Click += new System.EventHandler(this.cmdshow_Click);
            // 
            // dtdatefrom
            // 
            this.dtdatefrom.CalendarFont = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdatefrom.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dtdatefrom.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdatefrom.Location = new System.Drawing.Point(68, 22);
            this.dtdatefrom.Name = "dtdatefrom";
            this.dtdatefrom.Size = new System.Drawing.Size(154, 25);
            this.dtdatefrom.TabIndex = 41;
            // 
            // dtdateTo
            // 
            this.dtdateTo.CalendarFont = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtdateTo.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dtdateTo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdateTo.Location = new System.Drawing.Point(308, 25);
            this.dtdateTo.Name = "dtdateTo";
            this.dtdateTo.Size = new System.Drawing.Size(158, 25);
            this.dtdateTo.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 43;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9F);
            this.label2.Location = new System.Drawing.Point(269, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 14);
            this.label2.TabIndex = 44;
            this.label2.Text = "To";
            // 
            // Gridmain
            // 
            this.Gridmain.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gridmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridmain.ColumnHeadersVisible = false;
            this.Gridmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnname,
            this.clnbarid});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridmain.DefaultCellStyle = dataGridViewCellStyle3;
            this.Gridmain.EnableHeadersVisualStyles = false;
            this.Gridmain.GridColor = System.Drawing.Color.Fuchsia;
            this.Gridmain.Location = new System.Drawing.Point(10, 191);
            this.Gridmain.Name = "Gridmain";
            this.Gridmain.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridmain.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Gridmain.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Gridmain.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Gridmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gridmain.Size = new System.Drawing.Size(456, 138);
            this.Gridmain.TabIndex = 280;
            this.Gridmain.Visible = false;
            this.Gridmain.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Gridmain_PreviewKeyDown);
            // 
            // clnname
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(204)))));
            this.clnname.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnname.HeaderText = "Name";
            this.clnname.Name = "clnname";
            this.clnname.ReadOnly = true;
            this.clnname.Width = 250;
            // 
            // clnbarid
            // 
            this.clnbarid.HeaderText = "Bcode";
            this.clnbarid.Name = "clnbarid";
            this.clnbarid.ReadOnly = true;
            this.clnbarid.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9F);
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 281;
            this.label3.Text = "Barcode";
            // 
            // txtitemwise
            // 
            this.txtitemwise.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemwise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtitemwise.Location = new System.Drawing.Point(68, 210);
            this.txtitemwise.Name = "txtitemwise";
            this.txtitemwise.Size = new System.Drawing.Size(397, 23);
            this.txtitemwise.TabIndex = 282;
            this.txtitemwise.TextChanged += new System.EventHandler(this.txtitemwise_TextChanged);
            this.txtitemwise.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtitemwise_PreviewKeyDown);
            // 
            // TXTBATCH
            // 
            this.TXTBATCH.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBATCH.ForeColor = System.Drawing.Color.DarkMagenta;
            this.TXTBATCH.Location = new System.Drawing.Point(68, 165);
            this.TXTBATCH.Name = "TXTBATCH";
            this.TXTBATCH.Size = new System.Drawing.Size(397, 25);
            this.TXTBATCH.TabIndex = 283;
            this.TXTBATCH.TextChanged += new System.EventHandler(this.TXTBATCH_TextChanged);
            this.TXTBATCH.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TXTBATCH_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 284;
            this.label4.Text = "Item";
            // 
            // chkbcodewise
            // 
            this.chkbcodewise.AutoSize = true;
            this.chkbcodewise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkbcodewise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbcodewise.ForeColor = System.Drawing.Color.Fuchsia;
            this.chkbcodewise.Location = new System.Drawing.Point(368, 133);
            this.chkbcodewise.Name = "chkbcodewise";
            this.chkbcodewise.Size = new System.Drawing.Size(105, 17);
            this.chkbcodewise.TabIndex = 285;
            this.chkbcodewise.Text = "Barcode Wise";
            this.chkbcodewise.UseVisualStyleBackColor = true;
            this.chkbcodewise.CheckedChanged += new System.EventHandler(this.chkbcodewise_CheckedChanged);
            // 
            // CHKvnowise
            // 
            this.CHKvnowise.AutoSize = true;
            this.CHKvnowise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CHKvnowise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKvnowise.ForeColor = System.Drawing.Color.Fuchsia;
            this.CHKvnowise.Location = new System.Drawing.Point(363, 255);
            this.CHKvnowise.Name = "CHKvnowise";
            this.CHKvnowise.Size = new System.Drawing.Size(77, 17);
            this.CHKvnowise.TabIndex = 286;
            this.CHKvnowise.Text = "Vno wise";
            this.CHKvnowise.UseVisualStyleBackColor = true;
            this.CHKvnowise.CheckedChanged += new System.EventHandler(this.CHKvnowise_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 287;
            this.label5.Text = "VNO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Orchid;
            this.label6.Location = new System.Drawing.Point(7, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 289;
            this.label6.Text = "Bill Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orchid;
            this.label7.Location = new System.Drawing.Point(36, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 290;
            this.label7.Text = "Packed Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 9F);
            this.label8.Location = new System.Drawing.Point(269, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 14);
            this.label8.TabIndex = 294;
            this.label8.Text = "To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 14);
            this.label9.TabIndex = 293;
            this.label9.Text = "From";
            // 
            // dtpkdto
            // 
            this.dtpkdto.CalendarFont = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpkdto.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dtpkdto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkdto.Location = new System.Drawing.Point(308, 91);
            this.dtpkdto.Name = "dtpkdto";
            this.dtpkdto.Size = new System.Drawing.Size(158, 25);
            this.dtpkdto.TabIndex = 292;
            // 
            // dtpkdfrom
            // 
            this.dtpkdfrom.CalendarFont = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkdfrom.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dtpkdfrom.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkdfrom.Location = new System.Drawing.Point(68, 88);
            this.dtpkdfrom.Name = "dtpkdfrom";
            this.dtpkdfrom.Size = new System.Drawing.Size(154, 25);
            this.dtpkdfrom.TabIndex = 291;
            // 
            // chkpkddate
            // 
            this.chkpkddate.AutoSize = true;
            this.chkpkddate.BackColor = System.Drawing.Color.White;
            this.chkpkddate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkpkddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpkddate.ForeColor = System.Drawing.Color.Fuchsia;
            this.chkpkddate.Location = new System.Drawing.Point(15, 68);
            this.chkpkddate.Name = "chkpkddate";
            this.chkpkddate.Size = new System.Drawing.Size(15, 14);
            this.chkpkddate.TabIndex = 295;
            this.chkpkddate.UseVisualStyleBackColor = false;
            // 
            // Txtbarcode
            // 
            this.Txtbarcode.BackColor = System.Drawing.Color.White;
            this.Txtbarcode.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbarcode.ForeColor = System.Drawing.Color.Purple;
            this.Txtbarcode.Location = new System.Drawing.Point(455, 419);
            this.Txtbarcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txtbarcode.Name = "Txtbarcode";
            this.Txtbarcode.Size = new System.Drawing.Size(10, 33);
            this.Txtbarcode.TabIndex = 279;
            this.Txtbarcode.Visible = false;
            this.Txtbarcode.TextChanged += new WindowsFormsApplication2.Uscnormaltextbox.DelTextChanged(this.Txtbarcode_TextChanged);
            this.Txtbarcode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txtbarcode_PreviewKeyDown);
            // 
            // TXTvno
            // 
            this.TXTvno.Enabled = false;
            this.TXTvno.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTvno.Location = new System.Drawing.Point(68, 245);
            this.TXTvno.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXTvno.Name = "TXTvno";
            this.TXTvno.Size = new System.Drawing.Size(212, 32);
            this.TXTvno.TabIndex = 288;
            // 
            // Frmprodutionreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(478, 368);
            this.Controls.Add(this.chkpkddate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpkdto);
            this.Controls.Add(this.dtpkdfrom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkbcodewise);
            this.Controls.Add(this.TXTBATCH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Gridmain);
            this.Controls.Add(this.Txtbarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtdateTo);
            this.Controls.Add(this.dtdatefrom);
            this.Controls.Add(this.cmdshow);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.txtitemwise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTvno);
            this.Controls.Add(this.CHKvnowise);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frmprodutionreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmprodutionreport";
            this.Load += new System.EventHandler(this.Frmprodutionreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gridmain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button cmdshow;
        private System.Windows.Forms.DateTimePicker dtdatefrom;
        private System.Windows.Forms.DateTimePicker dtdateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Gridmain;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnbarid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtitemwise;
        private System.Windows.Forms.TextBox TXTBATCH;
        private Uscnormaltextbox Txtbarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkbcodewise;
        private System.Windows.Forms.CheckBox CHKvnowise;
        private System.Windows.Forms.Label label5;
        private Uscnuemerictextbox TXTvno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpkdto;
        private System.Windows.Forms.DateTimePicker dtpkdfrom;
        private System.Windows.Forms.CheckBox chkpkddate;
    }
}