namespace WindowsFormsApplication2
{
    partial class Frmsetmainproduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.comitem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdSave = new System.Windows.Forms.Button();
            this.cmdclose = new System.Windows.Forms.Button();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.clnslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnprate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmrate = new System.Windows.Forms.TextBox();
            this.cmdback = new System.Windows.Forms.Button();
            this.cmdforward = new System.Windows.Forms.Button();
            this.cmddelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkreceived = new System.Windows.Forms.LinkLabel();
            this.linkissue = new System.Windows.Forms.LinkLabel();
            this.lblbarcode = new System.Windows.Forms.Label();
            this.lblbarcodedot = new System.Windows.Forms.Label();
            this.combarcode = new System.Windows.Forms.ComboBox();
            this.uscGridshow2 = new WindowsFormsApplication2.UscGridshow();
            this.txtfinishproduct = new System.Windows.Forms.TextBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.gridmaintwo = new System.Windows.Forms.DataGridView();
            this.clnname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnbarid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmaintwo)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(121, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 16);
            this.label8.TabIndex = 110;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 109;
            this.label9.Text = "Id";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtid.ForeColor = System.Drawing.Color.Black;
            this.txtid.Location = new System.Drawing.Point(155, 29);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(38, 18);
            this.txtid.TabIndex = 0;
            this.txtid.Text = "ss\\";
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // comitem
            // 
            this.comitem.BackColor = System.Drawing.Color.White;
            this.comitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comitem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comitem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comitem.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.comitem.FormattingEnabled = true;
            this.comitem.Items.AddRange(new object[] {
            "None",
            "VAT",
            "CST",
            "Tax on MRP"});
            this.comitem.Location = new System.Drawing.Point(857, 9);
            this.comitem.Name = "comitem";
            this.comitem.Size = new System.Drawing.Size(22, 25);
            this.comitem.TabIndex = 1;
            this.comitem.Visible = false;
            this.comitem.SelectedIndexChanged += new System.EventHandler(this.comitem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(121, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 16);
            this.label1.TabIndex = 112;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 113;
            this.label2.Text = "Finished Product";
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
            this.CmdSave.Location = new System.Drawing.Point(602, 508);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(69, 34);
            this.CmdSave.TabIndex = 115;
            this.CmdSave.Text = "Save(F5)";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
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
            this.cmdclose.Location = new System.Drawing.Point(815, 508);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(69, 34);
            this.cmdclose.TabIndex = 116;
            this.cmdclose.Text = "Close";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // gridmain
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridmain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridmain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridmain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.gridmain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridmain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridmain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridmain.ColumnHeadersHeight = 31;
            this.gridmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnslno,
            this.clnbatch,
            this.clnitemname,
            this.ClnItemCode,
            this.clnqty,
            this.clnprate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.Location = new System.Drawing.Point(-2, 112);
            this.gridmain.MultiSelect = false;
            this.gridmain.Name = "gridmain";
            this.gridmain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridmain.RowHeadersVisible = false;
            this.gridmain.RowHeadersWidth = 100;
            this.gridmain.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.gridmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridmain.Size = new System.Drawing.Size(891, 390);
            this.gridmain.TabIndex = 3;
            this.gridmain.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellLeave);
            this.gridmain.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridmain_EditingControlShowing);
            this.gridmain.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellEnter);
            // 
            // clnslno
            // 
            this.clnslno.FillWeight = 40.60914F;
            this.clnslno.HeaderText = "Sl";
            this.clnslno.Name = "clnslno";
            // 
            // clnbatch
            // 
            this.clnbatch.HeaderText = "Batch";
            this.clnbatch.Name = "clnbatch";
            this.clnbatch.Visible = false;
            // 
            // clnitemname
            // 
            this.clnitemname.FillWeight = 158.8129F;
            this.clnitemname.HeaderText = "Item Name";
            this.clnitemname.Name = "clnitemname";
            // 
            // ClnItemCode
            // 
            this.ClnItemCode.HeaderText = "Column1";
            this.ClnItemCode.Name = "ClnItemCode";
            this.ClnItemCode.Visible = false;
            // 
            // clnqty
            // 
            this.clnqty.FillWeight = 91.85612F;
            this.clnqty.HeaderText = "Qty";
            this.clnqty.Name = "clnqty";
            // 
            // clnprate
            // 
            this.clnprate.FillWeight = 108.7218F;
            this.clnprate.HeaderText = "Rate";
            this.clnprate.Name = "clnprate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(507, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 16);
            this.label4.TabIndex = 122;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(405, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 121;
            this.label5.Text = "Labour Charge";
            // 
            // txtmrate
            // 
            this.txtmrate.BackColor = System.Drawing.Color.White;
            this.txtmrate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmrate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmrate.ForeColor = System.Drawing.Color.Black;
            this.txtmrate.Location = new System.Drawing.Point(528, 57);
            this.txtmrate.Margin = new System.Windows.Forms.Padding(4);
            this.txtmrate.Name = "txtmrate";
            this.txtmrate.Size = new System.Drawing.Size(97, 18);
            this.txtmrate.TabIndex = 2;
            this.txtmrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmrate_KeyPress);
            // 
            // cmdback
            // 
            this.cmdback.Location = new System.Drawing.Point(134, 27);
            this.cmdback.Name = "cmdback";
            this.cmdback.Size = new System.Drawing.Size(20, 23);
            this.cmdback.TabIndex = 123;
            this.cmdback.Text = "<";
            this.cmdback.UseVisualStyleBackColor = true;
            this.cmdback.Click += new System.EventHandler(this.cmdback_Click);
            // 
            // cmdforward
            // 
            this.cmdforward.Location = new System.Drawing.Point(193, 27);
            this.cmdforward.Name = "cmdforward";
            this.cmdforward.Size = new System.Drawing.Size(20, 23);
            this.cmdforward.TabIndex = 124;
            this.cmdforward.Text = ">";
            this.cmdforward.UseVisualStyleBackColor = true;
            this.cmdforward.Click += new System.EventHandler(this.cmdforward_Click);
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
            this.cmddelete.Location = new System.Drawing.Point(673, 508);
            this.cmddelete.Name = "cmddelete";
            this.cmddelete.Size = new System.Drawing.Size(69, 34);
            this.cmddelete.TabIndex = 125;
            this.cmddelete.Text = "Delete";
            this.cmddelete.UseVisualStyleBackColor = false;
            this.cmddelete.Click += new System.EventHandler(this.cmddelete_Click);
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
            this.button2.Location = new System.Drawing.Point(743, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 34);
            this.button2.TabIndex = 126;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkreceived
            // 
            this.linkreceived.AutoSize = true;
            this.linkreceived.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkreceived.Location = new System.Drawing.Point(780, 54);
            this.linkreceived.Name = "linkreceived";
            this.linkreceived.Size = new System.Drawing.Size(99, 15);
            this.linkreceived.TabIndex = 178;
            this.linkreceived.TabStop = true;
            this.linkreceived.Text = "Received Product";
            this.linkreceived.Visible = false;
            this.linkreceived.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkreceived_LinkClicked);
            // 
            // linkissue
            // 
            this.linkissue.AutoSize = true;
            this.linkissue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkissue.Location = new System.Drawing.Point(780, 37);
            this.linkissue.Name = "linkissue";
            this.linkissue.Size = new System.Drawing.Size(78, 15);
            this.linkissue.TabIndex = 177;
            this.linkissue.TabStop = true;
            this.linkissue.Text = "Issue Product";
            this.linkissue.Visible = false;
            this.linkissue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linksetproduct_LinkClicked);
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.BackColor = System.Drawing.Color.Transparent;
            this.lblbarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarcode.ForeColor = System.Drawing.Color.Black;
            this.lblbarcode.Location = new System.Drawing.Point(6, 84);
            this.lblbarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(57, 17);
            this.lblbarcode.TabIndex = 182;
            this.lblbarcode.Text = "Barcode";
            this.lblbarcode.Visible = false;
            // 
            // lblbarcodedot
            // 
            this.lblbarcodedot.AutoSize = true;
            this.lblbarcodedot.BackColor = System.Drawing.Color.Transparent;
            this.lblbarcodedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarcodedot.ForeColor = System.Drawing.Color.Black;
            this.lblbarcodedot.Location = new System.Drawing.Point(121, 85);
            this.lblbarcodedot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbarcodedot.Name = "lblbarcodedot";
            this.lblbarcodedot.Size = new System.Drawing.Size(11, 16);
            this.lblbarcodedot.TabIndex = 181;
            this.lblbarcodedot.Text = ":";
            this.lblbarcodedot.Visible = false;
            // 
            // combarcode
            // 
            this.combarcode.BackColor = System.Drawing.Color.White;
            this.combarcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combarcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combarcode.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.combarcode.FormattingEnabled = true;
            this.combarcode.Items.AddRange(new object[] {
            "None",
            "VAT",
            "CST",
            "Tax on MRP"});
            this.combarcode.Location = new System.Drawing.Point(857, 12);
            this.combarcode.Name = "combarcode";
            this.combarcode.Size = new System.Drawing.Size(22, 25);
            this.combarcode.TabIndex = 180;
            this.combarcode.Visible = false;
            // 
            // uscGridshow2
            // 
            this.uscGridshow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.uscGridshow2.Location = new System.Drawing.Point(97, 136);
            this.uscGridshow2.Name = "uscGridshow2";
            this.uscGridshow2.Size = new System.Drawing.Size(792, 216);
            this.uscGridshow2.TabIndex = 179;
            this.uscGridshow2.Visible = false;
            // 
            // txtfinishproduct
            // 
            this.txtfinishproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfinishproduct.Location = new System.Drawing.Point(134, 56);
            this.txtfinishproduct.Name = "txtfinishproduct";
            this.txtfinishproduct.Size = new System.Drawing.Size(264, 22);
            this.txtfinishproduct.TabIndex = 183;
            this.txtfinishproduct.TextChanged += new System.EventHandler(this.txtfinishproduct_TextChanged);
            this.txtfinishproduct.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtfinishproduct_PreviewKeyDown);
            // 
            // txtbarcode
            // 
            this.txtbarcode.Enabled = false;
            this.txtbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.Location = new System.Drawing.Point(134, 86);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(264, 22);
            this.txtbarcode.TabIndex = 184;
            // 
            // gridmaintwo
            // 
            this.gridmaintwo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmaintwo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridmaintwo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridmaintwo.ColumnHeadersVisible = false;
            this.gridmaintwo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnname,
            this.clnbarid});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmaintwo.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridmaintwo.EnableHeadersVisualStyles = false;
            this.gridmaintwo.GridColor = System.Drawing.Color.Fuchsia;
            this.gridmaintwo.Location = new System.Drawing.Point(134, 77);
            this.gridmaintwo.Name = "gridmaintwo";
            this.gridmaintwo.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmaintwo.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridmaintwo.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.gridmaintwo.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridmaintwo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridmaintwo.Size = new System.Drawing.Size(456, 108);
            this.gridmaintwo.TabIndex = 281;
            this.gridmaintwo.Visible = false;
            // 
            // clnname
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(221)))), ((int)(((byte)(204)))));
            this.clnname.DefaultCellStyle = dataGridViewCellStyle6;
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
            // Frmsetmainproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(888, 554);
            this.Controls.Add(this.gridmaintwo);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.txtfinishproduct);
            this.Controls.Add(this.lblbarcode);
            this.Controls.Add(this.lblbarcodedot);
            this.Controls.Add(this.combarcode);
            this.Controls.Add(this.uscGridshow2);
            this.Controls.Add(this.linkreceived);
            this.Controls.Add(this.linkissue);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmddelete);
            this.Controls.Add(this.cmdforward);
            this.Controls.Add(this.cmdback);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmrate);
            this.Controls.Add(this.gridmain);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comitem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Frmsetmainproduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Mainproduct";
            this.Load += new System.EventHandler(this.Frmsetmainproduct_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Frmsetmainproduct_PreviewKeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmsetmainproduct_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridmaintwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox comitem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button cmdclose;
        public System.Windows.Forms.DataGridView gridmain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtmrate;
        private System.Windows.Forms.Button cmdback;
        private System.Windows.Forms.Button cmdforward;
        private System.Windows.Forms.Button cmddelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkreceived;
        private System.Windows.Forms.LinkLabel linkissue;
        private WindowsFormsApplication2.UscGridshow uscGridshow2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnitemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnprate;
        private System.Windows.Forms.Label lblbarcode;
        private System.Windows.Forms.Label lblbarcodedot;
        private System.Windows.Forms.ComboBox combarcode;
        private System.Windows.Forms.TextBox txtfinishproduct;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.DataGridView gridmaintwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnbarid;
    }
}