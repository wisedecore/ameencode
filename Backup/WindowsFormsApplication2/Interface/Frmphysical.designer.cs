namespace WindowsFormsApplication2
{
    partial class Frmphysical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmphysical));
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblvno = new System.Windows.Forms.Label();
            this.txtvno = new System.Windows.Forms.TextBox();
            this.cmdsave = new System.Windows.Forms.Button();
            this.cmddelete = new System.Windows.Forms.Button();
            this.cmdrefresh = new System.Windows.Forms.Button();
            this.cmdclose = new System.Windows.Forms.Button();
            this.cmdfirst = new System.Windows.Forms.Button();
            this.cmdback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Chksearchingmode = new System.Windows.Forms.CheckBox();
            this.Cmdfillautomatic = new System.Windows.Forms.Button();
            this.cmdreset = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GridBatchlist = new System.Windows.Forms.DataGridView();
            this.uscGridshow2 = new WindowsFormsApplication2.UscGridshow();
            this.GridMain = new System.Windows.Forms.DataGridView();
            this.clnslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnqtyhand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnactual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnprate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnsrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnmrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBatchlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dtdate
            // 
            this.dtdate.Location = new System.Drawing.Point(333, 6);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(95, 20);
            this.dtdate.TabIndex = 1;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.Location = new System.Drawing.Point(252, 9);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(64, 13);
            this.lbldate.TabIndex = 7;
            this.lbldate.Text = "Date (تاريخ)";
            // 
            // lblvno
            // 
            this.lblvno.AutoSize = true;
            this.lblvno.ForeColor = System.Drawing.Color.White;
            this.lblvno.Location = new System.Drawing.Point(27, 8);
            this.lblvno.Name = "lblvno";
            this.lblvno.Size = new System.Drawing.Size(86, 13);
            this.lblvno.TabIndex = 6;
            this.lblvno.Text = "Vno (رقم الفوترة)";
            // 
            // txtvno
            // 
            this.txtvno.Location = new System.Drawing.Point(146, 7);
            this.txtvno.Name = "txtvno";
            this.txtvno.ReadOnly = true;
            this.txtvno.Size = new System.Drawing.Size(55, 20);
            this.txtvno.TabIndex = 0;
            // 
            // cmdsave
            // 
            this.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdsave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdsave.Location = new System.Drawing.Point(12, 3);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(101, 41);
            this.cmdsave.TabIndex = 0;
            this.cmdsave.Text = "Save (حفظ)";
            this.cmdsave.UseVisualStyleBackColor = true;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // cmddelete
            // 
            this.cmddelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmddelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmddelete.Location = new System.Drawing.Point(119, 3);
            this.cmddelete.Name = "cmddelete";
            this.cmddelete.Size = new System.Drawing.Size(106, 41);
            this.cmddelete.TabIndex = 1;
            this.cmddelete.Text = "Delete (حذف)";
            this.cmddelete.UseVisualStyleBackColor = true;
            this.cmddelete.Click += new System.EventHandler(this.cmddelete_Click);
            // 
            // cmdrefresh
            // 
            this.cmdrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdrefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdrefresh.Location = new System.Drawing.Point(231, 3);
            this.cmdrefresh.Name = "cmdrefresh";
            this.cmdrefresh.Size = new System.Drawing.Size(107, 41);
            this.cmdrefresh.TabIndex = 2;
            this.cmdrefresh.Text = "Clear (واضح)";
            this.cmdrefresh.UseVisualStyleBackColor = true;
            this.cmdrefresh.Click += new System.EventHandler(this.cmdrefresh_Click);
            // 
            // cmdclose
            // 
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdclose.Location = new System.Drawing.Point(344, 3);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(100, 41);
            this.cmdclose.TabIndex = 3;
            this.cmdclose.Text = "Close (قريب)";
            this.cmdclose.UseVisualStyleBackColor = true;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // cmdfirst
            // 
            this.cmdfirst.Location = new System.Drawing.Point(121, 5);
            this.cmdfirst.Name = "cmdfirst";
            this.cmdfirst.Size = new System.Drawing.Size(26, 23);
            this.cmdfirst.TabIndex = 115;
            this.cmdfirst.Text = "<";
            this.cmdfirst.UseVisualStyleBackColor = true;
            this.cmdfirst.Click += new System.EventHandler(this.cmdfirst_Click);
            // 
            // cmdback
            // 
            this.cmdback.Location = new System.Drawing.Point(200, 5);
            this.cmdback.Name = "cmdback";
            this.cmdback.Size = new System.Drawing.Size(25, 23);
            this.cmdback.TabIndex = 116;
            this.cmdback.Text = ">";
            this.cmdback.UseVisualStyleBackColor = true;
            this.cmdback.Click += new System.EventHandler(this.cmdback_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.cmdsave);
            this.panel1.Controls.Add(this.cmddelete);
            this.panel1.Controls.Add(this.cmdrefresh);
            this.panel1.Controls.Add(this.cmdclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 47);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.Chksearchingmode);
            this.panel2.Controls.Add(this.Cmdfillautomatic);
            this.panel2.Controls.Add(this.cmdreset);
            this.panel2.Controls.Add(this.dtdate);
            this.panel2.Controls.Add(this.txtvno);
            this.panel2.Controls.Add(this.lblvno);
            this.panel2.Controls.Add(this.lbldate);
            this.panel2.Controls.Add(this.cmdfirst);
            this.panel2.Controls.Add(this.cmdback);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1242, 50);
            this.panel2.TabIndex = 0;
            // 
            // Chksearchingmode
            // 
            this.Chksearchingmode.AutoSize = true;
            this.Chksearchingmode.Checked = true;
            this.Chksearchingmode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chksearchingmode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chksearchingmode.ForeColor = System.Drawing.Color.Yellow;
            this.Chksearchingmode.Location = new System.Drawing.Point(645, 10);
            this.Chksearchingmode.Name = "Chksearchingmode";
            this.Chksearchingmode.Size = new System.Drawing.Size(119, 19);
            this.Chksearchingmode.TabIndex = 119;
            this.Chksearchingmode.Text = "Searching mode";
            this.Chksearchingmode.UseVisualStyleBackColor = true;
            this.Chksearchingmode.CheckedChanged += new System.EventHandler(this.Chksearchingmode_CheckedChanged);
            // 
            // Cmdfillautomatic
            // 
            this.Cmdfillautomatic.Location = new System.Drawing.Point(998, 8);
            this.Cmdfillautomatic.Name = "Cmdfillautomatic";
            this.Cmdfillautomatic.Size = new System.Drawing.Size(113, 23);
            this.Cmdfillautomatic.TabIndex = 118;
            this.Cmdfillautomatic.Text = "Fill Automatic";
            this.Cmdfillautomatic.UseVisualStyleBackColor = true;
            this.Cmdfillautomatic.Visible = false;
            this.Cmdfillautomatic.Click += new System.EventHandler(this.Cmdfillautomatic_Click);
            // 
            // cmdreset
            // 
            this.cmdreset.Location = new System.Drawing.Point(1117, 8);
            this.cmdreset.Name = "cmdreset";
            this.cmdreset.Size = new System.Drawing.Size(113, 23);
            this.cmdreset.TabIndex = 117;
            this.cmdreset.Text = "Reset With Actual";
            this.cmdreset.UseVisualStyleBackColor = true;
            this.cmdreset.Visible = false;
            this.cmdreset.Click += new System.EventHandler(this.cmdreset_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.panel3.Controls.Add(this.GridBatchlist);
            this.panel3.Controls.Add(this.uscGridshow2);
            this.panel3.Controls.Add(this.GridMain);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1242, 550);
            this.panel3.TabIndex = 123;
            // 
            // GridBatchlist
            // 
            this.GridBatchlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBatchlist.ColumnHeadersVisible = false;
            this.GridBatchlist.Location = new System.Drawing.Point(402, 105);
            this.GridBatchlist.Name = "GridBatchlist";
            this.GridBatchlist.RowHeadersVisible = false;
            this.GridBatchlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridBatchlist.Size = new System.Drawing.Size(205, 150);
            this.GridBatchlist.TabIndex = 123;
            this.GridBatchlist.Visible = false;
            // 
            // uscGridshow2
            // 
            this.uscGridshow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.uscGridshow2.Location = new System.Drawing.Point(91, 72);
            this.uscGridshow2.Name = "uscGridshow2";
            this.uscGridshow2.Size = new System.Drawing.Size(951, 431);
            this.uscGridshow2.TabIndex = 122;
            this.uscGridshow2.Visible = false;
            // 
            // GridMain
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GridMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.GridMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.GridMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridMain.ColumnHeadersHeight = 30;
            this.GridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnslno,
            this.clnitemcode,
            this.clnitemname,
            this.clnbatch,
            this.clnqtyhand,
            this.clnactual,
            this.clnqty,
            this.clnprate,
            this.clnsrate,
            this.clnmrp,
            this.clnamount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridMain.EnableHeadersVisualStyles = false;
            this.GridMain.GridColor = System.Drawing.Color.White;
            this.GridMain.Location = new System.Drawing.Point(0, 0);
            this.GridMain.MultiSelect = false;
            this.GridMain.Name = "GridMain";
            this.GridMain.RowHeadersVisible = false;
            this.GridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridMain.Size = new System.Drawing.Size(1242, 550);
            this.GridMain.TabIndex = 0;
            this.GridMain.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMain_CellLeave);
            this.GridMain.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.GridMain_EditingControlShowing);
            this.GridMain.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMain_CellEnter);
            // 
            // clnslno
            // 
            this.clnslno.FillWeight = 25F;
            this.clnslno.HeaderText = "Slno (رقم سري)";
            this.clnslno.Name = "clnslno";
            // 
            // clnitemcode
            // 
            this.clnitemcode.FillWeight = 150F;
            this.clnitemcode.HeaderText = "Itemcode(رمز الصنف)";
            this.clnitemcode.Name = "clnitemcode";
            // 
            // clnitemname
            // 
            this.clnitemname.FillWeight = 150F;
            this.clnitemname.HeaderText = "Item Name(اسم العنصر)";
            this.clnitemname.Name = "clnitemname";
            this.clnitemname.ReadOnly = true;
            // 
            // clnbatch
            // 
            this.clnbatch.HeaderText = "Barcode(الباركود)";
            this.clnbatch.Name = "clnbatch";
            // 
            // clnqtyhand
            // 
            this.clnqtyhand.FillWeight = 40F;
            this.clnqtyhand.HeaderText = "Qty In Hand (الكمية فى اليد)";
            this.clnqtyhand.Name = "clnqtyhand";
            this.clnqtyhand.ReadOnly = true;
            // 
            // clnactual
            // 
            this.clnactual.FillWeight = 40F;
            this.clnactual.HeaderText = "Actual (فعلي)";
            this.clnactual.Name = "clnactual";
            // 
            // clnqty
            // 
            this.clnqty.FillWeight = 40F;
            this.clnqty.HeaderText = "Qty(الكمية)";
            this.clnqty.Name = "clnqty";
            this.clnqty.ReadOnly = true;
            // 
            // clnprate
            // 
            this.clnprate.FillWeight = 50F;
            this.clnprate.HeaderText = "Prate (سعر الشراء)";
            this.clnprate.Name = "clnprate";
            this.clnprate.Visible = false;
            // 
            // clnsrate
            // 
            this.clnsrate.FillWeight = 30F;
            this.clnsrate.HeaderText = "Column1";
            this.clnsrate.Name = "clnsrate";
            this.clnsrate.Visible = false;
            // 
            // clnmrp
            // 
            this.clnmrp.FillWeight = 50F;
            this.clnmrp.HeaderText = "M R P";
            this.clnmrp.Name = "clnmrp";
            this.clnmrp.Visible = false;
            // 
            // clnamount
            // 
            this.clnamount.FillWeight = 70F;
            this.clnamount.HeaderText = "Amount (كمية)";
            this.clnamount.Name = "clnamount";
            this.clnamount.ReadOnly = true;
            // 
            // Frmphysical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1242, 647);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frmphysical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Physical Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmphysical_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmphysical_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Frmphysical_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Frmphysical_PreviewKeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmphysical_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridBatchlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblvno;
        private System.Windows.Forms.TextBox txtvno;
        private System.Windows.Forms.Button cmdsave;
        private System.Windows.Forms.Button cmddelete;
        private System.Windows.Forms.Button cmdrefresh;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button cmdfirst;
        private System.Windows.Forms.Button cmdback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView GridBatchlist;
        private UscGridshow uscGridshow2;
        private System.Windows.Forms.DataGridView GridMain;
        private System.Windows.Forms.Button cmdreset;
        private System.Windows.Forms.Button Cmdfillautomatic;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnitemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnitemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnqtyhand;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnactual;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnprate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnsrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnmrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnamount;
        private System.Windows.Forms.CheckBox Chksearchingmode;
    }
}