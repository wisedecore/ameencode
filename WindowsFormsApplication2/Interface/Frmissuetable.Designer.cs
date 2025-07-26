namespace WindowsFormsApplication2
{
    partial class Frmissuetable
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtvno = new System.Windows.Forms.TextBox();
            this.dtissuedate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.cmdclose = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.comemployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtremarks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttvno = new System.Windows.Forms.TextBox();
            this.cmdforward = new System.Windows.Forms.Button();
            this.cmdback = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmddelete = new System.Windows.Forms.Button();
            this.linkissueproduct = new System.Windows.Forms.LinkLabel();
            this.linksetproduct = new System.Windows.Forms.LinkLabel();
            this.clnslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uscGridshow2 = new WindowsFormsApplication2.UscGridshow();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(99, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 16);
            this.label8.TabIndex = 120;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(30, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 19);
            this.label9.TabIndex = 119;
            this.label9.Text = "Vno";
            // 
            // txtvno
            // 
            this.txtvno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.txtvno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtvno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtvno.ForeColor = System.Drawing.Color.White;
            this.txtvno.Location = new System.Drawing.Point(159, 22);
            this.txtvno.Margin = new System.Windows.Forms.Padding(4);
            this.txtvno.Name = "txtvno";
            this.txtvno.ReadOnly = true;
            this.txtvno.Size = new System.Drawing.Size(60, 18);
            this.txtvno.TabIndex = 0;
            // 
            // dtissuedate
            // 
            this.dtissuedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtissuedate.Location = new System.Drawing.Point(401, 21);
            this.dtissuedate.Name = "dtissuedate";
            this.dtissuedate.Size = new System.Drawing.Size(127, 20);
            this.dtissuedate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(342, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 123;
            this.label1.Text = "Date";
            // 
            // gridmain
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridmain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridmain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.gridmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnslno,
            this.clnbatch,
            this.clnitem,
            this.clnqty,
            this.clnrate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.Location = new System.Drawing.Point(23, 76);
            this.gridmain.MultiSelect = false;
            this.gridmain.Name = "gridmain";
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
            this.gridmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridmain.Size = new System.Drawing.Size(886, 388);
            this.gridmain.TabIndex = 4;
            this.gridmain.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellLeave);
            this.gridmain.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridmain_EditingControlShowing);
            this.gridmain.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellEnter);
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.Transparent;
            this.cmdclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatAppearance.BorderSize = 0;
            this.cmdclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(833, 470);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(69, 34);
            this.cmdclose.TabIndex = 126;
            this.cmdclose.Text = "&Close";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.BackColor = System.Drawing.Color.Transparent;
            this.CmdSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdSave.FlatAppearance.BorderSize = 0;
            this.CmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Location = new System.Drawing.Point(617, 470);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(69, 34);
            this.CmdSave.TabIndex = 125;
            this.CmdSave.Text = "&Save(F5)";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // comemployee
            // 
            this.comemployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.comemployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comemployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comemployee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comemployee.ForeColor = System.Drawing.Color.White;
            this.comemployee.FormattingEnabled = true;
            this.comemployee.Items.AddRange(new object[] {
            "None",
            "VAT",
            "CST",
            "Tax on MRP"});
            this.comemployee.Location = new System.Drawing.Point(139, 49);
            this.comemployee.Name = "comemployee";
            this.comemployee.Size = new System.Drawing.Size(190, 25);
            this.comemployee.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(99, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 129;
            this.label2.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 128;
            this.label4.Text = "Employee";
            // 
            // txtremarks
            // 
            this.txtremarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.txtremarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtremarks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtremarks.ForeColor = System.Drawing.Color.White;
            this.txtremarks.Location = new System.Drawing.Point(401, 52);
            this.txtremarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(127, 18);
            this.txtremarks.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(342, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 131;
            this.label5.Text = "Remark";
            // 
            // txttvno
            // 
            this.txttvno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txttvno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttvno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txttvno.ForeColor = System.Drawing.Color.Black;
            this.txttvno.Location = new System.Drawing.Point(50, 1);
            this.txttvno.Margin = new System.Windows.Forms.Padding(4);
            this.txttvno.Name = "txttvno";
            this.txttvno.Size = new System.Drawing.Size(60, 18);
            this.txttvno.TabIndex = 132;
            this.txttvno.Visible = false;
            // 
            // cmdforward
            // 
            this.cmdforward.Location = new System.Drawing.Point(218, 20);
            this.cmdforward.Name = "cmdforward";
            this.cmdforward.Size = new System.Drawing.Size(20, 23);
            this.cmdforward.TabIndex = 135;
            this.cmdforward.Text = ">";
            this.cmdforward.UseVisualStyleBackColor = true;
            this.cmdforward.Click += new System.EventHandler(this.cmdforward_Click);
            // 
            // cmdback
            // 
            this.cmdback.Location = new System.Drawing.Point(139, 20);
            this.cmdback.Name = "cmdback";
            this.cmdback.Size = new System.Drawing.Size(20, 23);
            this.cmdback.TabIndex = 134;
            this.cmdback.Text = "<";
            this.cmdback.UseVisualStyleBackColor = true;
            this.cmdback.Click += new System.EventHandler(this.cmdback_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(761, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 34);
            this.button2.TabIndex = 137;
            this.button2.Text = "&Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmddelete
            // 
            this.cmddelete.BackColor = System.Drawing.Color.Transparent;
            this.cmddelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmddelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmddelete.FlatAppearance.BorderSize = 0;
            this.cmddelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmddelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmddelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmddelete.ForeColor = System.Drawing.Color.Black;
            this.cmddelete.Location = new System.Drawing.Point(689, 470);
            this.cmddelete.Name = "cmddelete";
            this.cmddelete.Size = new System.Drawing.Size(69, 34);
            this.cmddelete.TabIndex = 136;
            this.cmddelete.Text = "&Delete";
            this.cmddelete.UseVisualStyleBackColor = false;
            this.cmddelete.Click += new System.EventHandler(this.cmddelete_Click);
            // 
            // linkissueproduct
            // 
            this.linkissueproduct.AutoSize = true;
            this.linkissueproduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkissueproduct.Location = new System.Drawing.Point(808, 41);
            this.linkissueproduct.Name = "linkissueproduct";
            this.linkissueproduct.Size = new System.Drawing.Size(99, 15);
            this.linkissueproduct.TabIndex = 176;
            this.linkissueproduct.TabStop = true;
            this.linkissueproduct.Text = "Received Product";
            this.linkissueproduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkissueproduct_LinkClicked);
            // 
            // linksetproduct
            // 
            this.linksetproduct.AutoSize = true;
            this.linksetproduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksetproduct.Location = new System.Drawing.Point(808, 24);
            this.linksetproduct.Name = "linksetproduct";
            this.linksetproduct.Size = new System.Drawing.Size(68, 15);
            this.linksetproduct.TabIndex = 175;
            this.linksetproduct.TabStop = true;
            this.linksetproduct.Text = "Set Product";
            this.linksetproduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linksetproduct_LinkClicked);
            // 
            // clnslno
            // 
            this.clnslno.FillWeight = 44.4918F;
            this.clnslno.HeaderText = "Sl";
            this.clnslno.Name = "clnslno";
            // 
            // clnbatch
            // 
            this.clnbatch.HeaderText = "Barcode";
            this.clnbatch.Name = "clnbatch";
            this.clnbatch.Visible = false;
            // 
            // clnitem
            // 
            this.clnitem.FillWeight = 136.0507F;
            this.clnitem.HeaderText = "Item";
            this.clnitem.Name = "clnitem";
            // 
            // clnqty
            // 
            this.clnqty.FillWeight = 71.01132F;
            this.clnqty.HeaderText = "Qty";
            this.clnqty.Name = "clnqty";
            // 
            // clnrate
            // 
            this.clnrate.FillWeight = 121.5426F;
            this.clnrate.HeaderText = "Rate";
            this.clnrate.Name = "clnrate";
            // 
            // uscGridshow2
            // 
            this.uscGridshow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.uscGridshow2.Location = new System.Drawing.Point(102, 136);
            this.uscGridshow2.Name = "uscGridshow2";
            this.uscGridshow2.Size = new System.Drawing.Size(792, 216);
            this.uscGridshow2.TabIndex = 178;
            this.uscGridshow2.Visible = false;
            // 
            // Frmissuetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(954, 516);
            this.Controls.Add(this.uscGridshow2);
            this.Controls.Add(this.linkissueproduct);
            this.Controls.Add(this.linksetproduct);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmddelete);
            this.Controls.Add(this.cmdforward);
            this.Controls.Add(this.cmdback);
            this.Controls.Add(this.txttvno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtremarks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comemployee);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.gridmain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtissuedate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtvno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmissuetable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Items";
            this.Load += new System.EventHandler(this.Frmissuetable_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Frmissuetable_PreviewKeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmissuetable_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtvno;
        private System.Windows.Forms.DateTimePicker dtissuedate;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView gridmain;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.ComboBox comemployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtremarks;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txttvno;
        private System.Windows.Forms.Button cmdforward;
        private System.Windows.Forms.Button cmdback;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmddelete;
        private System.Windows.Forms.LinkLabel linkissueproduct;
        private System.Windows.Forms.LinkLabel linksetproduct;
        private WindowsFormsApplication2.UscGridshow uscGridshow2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnrate;
    }
}