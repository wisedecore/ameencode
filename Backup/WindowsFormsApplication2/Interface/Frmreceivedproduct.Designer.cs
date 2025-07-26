namespace WindowsFormsApplication2
{
    partial class Frmreceivedproduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Commainproduct = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtreceivedid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.txtmainqty = new System.Windows.Forms.TextBox();
            this.cmdclose = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtemployee = new System.Windows.Forms.TextBox();
            this.txtissueid = new System.Windows.Forms.TextBox();
            this.pnlCentre = new System.Windows.Forms.Panel();
            this.txtissuedate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtremarks = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Dtrecdate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.Gridlist = new System.Windows.Forms.DataGridView();
            this.clnissueid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnissuedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnemployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbvno = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtamounttodebited = new System.Windows.Forms.TextBox();
            this.txtidgeneralledger = new System.Windows.Forms.TextBox();
            this.cmdforward = new System.Windows.Forms.Button();
            this.cmdback = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cmddelete = new System.Windows.Forms.Button();
            this.linksetproduct = new System.Windows.Forms.LinkLabel();
            this.linkissueproduct = new System.Windows.Forms.LinkLabel();
            this.label21 = new System.Windows.Forms.Label();
            this.clnslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnbatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnitem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridlist)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(180, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 132;
            this.label2.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(62, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 131;
            this.label4.Text = "Finished Product";
            // 
            // Commainproduct
            // 
            this.Commainproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.Commainproduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Commainproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Commainproduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Commainproduct.ForeColor = System.Drawing.Color.White;
            this.Commainproduct.FormattingEnabled = true;
            this.Commainproduct.Items.AddRange(new object[] {
            "None",
            "VAT",
            "CST",
            "Tax on MRP"});
            this.Commainproduct.Location = new System.Drawing.Point(227, 74);
            this.Commainproduct.Name = "Commainproduct";
            this.Commainproduct.Size = new System.Drawing.Size(175, 25);
            this.Commainproduct.TabIndex = 2;
            this.Commainproduct.SelectedIndexChanged += new System.EventHandler(this.Commainproduct_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(180, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 16);
            this.label8.TabIndex = 135;
            this.label8.Text = ":";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(62, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 19);
            this.label9.TabIndex = 134;
            this.label9.Text = "Id";
            // 
            // txtreceivedid
            // 
            this.txtreceivedid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.txtreceivedid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtreceivedid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtreceivedid.ForeColor = System.Drawing.Color.White;
            this.txtreceivedid.Location = new System.Drawing.Point(248, 23);
            this.txtreceivedid.Margin = new System.Windows.Forms.Padding(4);
            this.txtreceivedid.Name = "txtreceivedid";
            this.txtreceivedid.ReadOnly = true;
            this.txtreceivedid.Size = new System.Drawing.Size(51, 25);
            this.txtreceivedid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(571, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 16);
            this.label1.TabIndex = 138;
            this.label1.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(501, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 137;
            this.label3.Text = "Select";
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtsearch.ForeColor = System.Drawing.Color.Black;
            this.txtsearch.Location = new System.Drawing.Point(588, 55);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(180, 18);
            this.txtsearch.TabIndex = 5;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // gridmain
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
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
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.Location = new System.Drawing.Point(13, 178);
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
            this.gridmain.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gridmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridmain.Size = new System.Drawing.Size(460, 331);
            this.gridmain.TabIndex = 139;
            // 
            // txtmainqty
            // 
            this.txtmainqty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.txtmainqty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmainqty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtmainqty.ForeColor = System.Drawing.Color.White;
            this.txtmainqty.Location = new System.Drawing.Point(227, 102);
            this.txtmainqty.Margin = new System.Windows.Forms.Padding(4);
            this.txtmainqty.Name = "txtmainqty";
            this.txtmainqty.Size = new System.Drawing.Size(175, 18);
            this.txtmainqty.TabIndex = 3;
            this.txtmainqty.TextChanged += new System.EventHandler(this.txtmainqty_TextChanged);
            this.txtmainqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmainqty_KeyPress);
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
            this.cmdclose.Location = new System.Drawing.Point(404, 515);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(69, 34);
            this.cmdclose.TabIndex = 9;
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
            this.CmdSave.Location = new System.Drawing.Point(193, 515);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(69, 34);
            this.CmdSave.TabIndex = 6;
            this.CmdSave.Text = "&Save(F5)";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(570, 481);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 16);
            this.label6.TabIndex = 149;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(496, 482);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 148;
            this.label7.Text = "Employee";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(570, 429);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 16);
            this.label10.TabIndex = 147;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(496, 430);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 19);
            this.label11.TabIndex = 146;
            this.label11.Text = "Issue Id";
            // 
            // txtemployee
            // 
            this.txtemployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txtemployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemployee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtemployee.ForeColor = System.Drawing.Color.Black;
            this.txtemployee.Location = new System.Drawing.Point(598, 483);
            this.txtemployee.Margin = new System.Windows.Forms.Padding(4);
            this.txtemployee.Name = "txtemployee";
            this.txtemployee.Size = new System.Drawing.Size(123, 18);
            this.txtemployee.TabIndex = 151;
            // 
            // txtissueid
            // 
            this.txtissueid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txtissueid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtissueid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtissueid.ForeColor = System.Drawing.Color.Black;
            this.txtissueid.Location = new System.Drawing.Point(598, 428);
            this.txtissueid.Margin = new System.Windows.Forms.Padding(4);
            this.txtissueid.Name = "txtissueid";
            this.txtissueid.Size = new System.Drawing.Size(123, 18);
            this.txtissueid.TabIndex = 150;
            // 
            // pnlCentre
            // 
            this.pnlCentre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlCentre.Location = new System.Drawing.Point(481, 11);
            this.pnlCentre.Name = "pnlCentre";
            this.pnlCentre.Size = new System.Drawing.Size(3, 525);
            this.pnlCentre.TabIndex = 152;
            // 
            // txtissuedate
            // 
            this.txtissuedate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txtissuedate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtissuedate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtissuedate.ForeColor = System.Drawing.Color.Black;
            this.txtissuedate.Location = new System.Drawing.Point(598, 457);
            this.txtissuedate.Margin = new System.Windows.Forms.Padding(4);
            this.txtissuedate.Name = "txtissuedate";
            this.txtissuedate.Size = new System.Drawing.Size(123, 18);
            this.txtissuedate.TabIndex = 155;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(570, 455);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 16);
            this.label12.TabIndex = 154;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(496, 456);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 19);
            this.label13.TabIndex = 153;
            this.label13.Text = "Issue Date";
            // 
            // txtremarks
            // 
            this.txtremarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txtremarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtremarks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtremarks.ForeColor = System.Drawing.Color.Black;
            this.txtremarks.Location = new System.Drawing.Point(598, 507);
            this.txtremarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(123, 18);
            this.txtremarks.TabIndex = 156;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(570, 506);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 16);
            this.label14.TabIndex = 158;
            this.label14.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(496, 507);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 19);
            this.label15.TabIndex = 157;
            this.label15.Text = "Remarks";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(62, 53);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 19);
            this.label16.TabIndex = 160;
            this.label16.Text = "Date";
            // 
            // Dtrecdate
            // 
            this.Dtrecdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtrecdate.Location = new System.Drawing.Point(227, 53);
            this.Dtrecdate.Name = "Dtrecdate";
            this.Dtrecdate.Size = new System.Drawing.Size(175, 20);
            this.Dtrecdate.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(180, 54);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 16);
            this.label17.TabIndex = 161;
            this.label17.Text = ":";
            // 
            // Gridlist
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Gridlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Gridlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gridlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Gridlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gridlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Gridlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Gridlist.ColumnHeadersHeight = 31;
            this.Gridlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnissueid,
            this.clnissuedate,
            this.clnemployee});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridlist.DefaultCellStyle = dataGridViewCellStyle7;
            this.Gridlist.EnableHeadersVisualStyles = false;
            this.Gridlist.Location = new System.Drawing.Point(500, 102);
            this.Gridlist.MultiSelect = false;
            this.Gridlist.Name = "Gridlist";
            this.Gridlist.ReadOnly = true;
            this.Gridlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Gridlist.RowHeadersVisible = false;
            this.Gridlist.RowHeadersWidth = 100;
            this.Gridlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gridlist.Size = new System.Drawing.Size(460, 319);
            this.Gridlist.TabIndex = 162;
            this.Gridlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridlist_CellDoubleClick);
            // 
            // clnissueid
            // 
            this.clnissueid.FillWeight = 40.60914F;
            this.clnissueid.HeaderText = "Issue Id";
            this.clnissueid.Name = "clnissueid";
            this.clnissueid.ReadOnly = true;
            // 
            // clnissuedate
            // 
            this.clnissuedate.HeaderText = "Date";
            this.clnissuedate.Name = "clnissuedate";
            this.clnissuedate.ReadOnly = true;
            // 
            // clnemployee
            // 
            this.clnemployee.HeaderText = "Employee";
            this.clnemployee.Name = "clnemployee";
            this.clnemployee.ReadOnly = true;
            // 
            // txtbvno
            // 
            this.txtbvno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txtbvno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbvno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtbvno.ForeColor = System.Drawing.Color.White;
            this.txtbvno.Location = new System.Drawing.Point(66, 29);
            this.txtbvno.Margin = new System.Windows.Forms.Padding(4);
            this.txtbvno.Name = "txtbvno";
            this.txtbvno.Size = new System.Drawing.Size(60, 18);
            this.txtbvno.TabIndex = 163;
            this.txtbvno.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(180, 125);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 16);
            this.label18.TabIndex = 166;
            this.label18.Text = ":";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(62, 124);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 19);
            this.label19.TabIndex = 165;
            this.label19.Text = "Labour Charge";
            // 
            // txtamounttodebited
            // 
            this.txtamounttodebited.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.txtamounttodebited.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtamounttodebited.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtamounttodebited.ForeColor = System.Drawing.Color.White;
            this.txtamounttodebited.Location = new System.Drawing.Point(227, 125);
            this.txtamounttodebited.Margin = new System.Windows.Forms.Padding(4);
            this.txtamounttodebited.Name = "txtamounttodebited";
            this.txtamounttodebited.Size = new System.Drawing.Size(176, 18);
            this.txtamounttodebited.TabIndex = 4;
            this.txtamounttodebited.TextChanged += new System.EventHandler(this.txtamounttodebited_TextChanged);
            this.txtamounttodebited.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamounttodebited_KeyPress);
            // 
            // txtidgeneralledger
            // 
            this.txtidgeneralledger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.txtidgeneralledger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidgeneralledger.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtidgeneralledger.ForeColor = System.Drawing.Color.White;
            this.txtidgeneralledger.Location = new System.Drawing.Point(66, 10);
            this.txtidgeneralledger.Margin = new System.Windows.Forms.Padding(4);
            this.txtidgeneralledger.Name = "txtidgeneralledger";
            this.txtidgeneralledger.Size = new System.Drawing.Size(60, 18);
            this.txtidgeneralledger.TabIndex = 167;
            this.txtidgeneralledger.Visible = false;
            // 
            // cmdforward
            // 
            this.cmdforward.ForeColor = System.Drawing.Color.Black;
            this.cmdforward.Location = new System.Drawing.Point(299, 21);
            this.cmdforward.Name = "cmdforward";
            this.cmdforward.Size = new System.Drawing.Size(20, 29);
            this.cmdforward.TabIndex = 169;
            this.cmdforward.Text = ">";
            this.cmdforward.UseVisualStyleBackColor = true;
            this.cmdforward.Click += new System.EventHandler(this.cmdforward_Click);
            // 
            // cmdback
            // 
            this.cmdback.ForeColor = System.Drawing.Color.Black;
            this.cmdback.Location = new System.Drawing.Point(227, 21);
            this.cmdback.Name = "cmdback";
            this.cmdback.Size = new System.Drawing.Size(20, 29);
            this.cmdback.TabIndex = 168;
            this.cmdback.Text = "<";
            this.cmdback.UseVisualStyleBackColor = true;
            this.cmdback.Click += new System.EventHandler(this.cmdback_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(62, 101);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 19);
            this.label20.TabIndex = 170;
            this.label20.Text = "Qty";
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
            this.button2.Location = new System.Drawing.Point(334, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 34);
            this.button2.TabIndex = 8;
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
            this.cmddelete.Location = new System.Drawing.Point(264, 515);
            this.cmddelete.Name = "cmddelete";
            this.cmddelete.Size = new System.Drawing.Size(69, 34);
            this.cmddelete.TabIndex = 7;
            this.cmddelete.Text = "&Delete";
            this.cmddelete.UseVisualStyleBackColor = false;
            this.cmddelete.Click += new System.EventHandler(this.cmddelete_Click);
            // 
            // linksetproduct
            // 
            this.linksetproduct.AutoSize = true;
            this.linksetproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksetproduct.Location = new System.Drawing.Point(888, 34);
            this.linksetproduct.Name = "linksetproduct";
            this.linksetproduct.Size = new System.Drawing.Size(70, 15);
            this.linksetproduct.TabIndex = 173;
            this.linksetproduct.TabStop = true;
            this.linksetproduct.Text = "Set Product";
            this.linksetproduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linksetproduct_LinkClicked);
            // 
            // linkissueproduct
            // 
            this.linkissueproduct.AutoSize = true;
            this.linkissueproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkissueproduct.Location = new System.Drawing.Point(888, 51);
            this.linkissueproduct.Name = "linkissueproduct";
            this.linkissueproduct.Size = new System.Drawing.Size(81, 15);
            this.linkissueproduct.TabIndex = 174;
            this.linkissueproduct.TabStop = true;
            this.linkissueproduct.Text = "Issue Product";
            this.linkissueproduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkissueproduct_LinkClicked);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(180, 102);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 16);
            this.label21.TabIndex = 132;
            this.label21.Text = ":";
            // 
            // clnslno
            // 
            this.clnslno.FillWeight = 37.12202F;
            this.clnslno.HeaderText = "Sl";
            this.clnslno.Name = "clnslno";
            // 
            // clnbatch
            // 
            this.clnbatch.FillWeight = 91.41297F;
            this.clnbatch.HeaderText = "Batch";
            this.clnbatch.Name = "clnbatch";
            this.clnbatch.Visible = false;
            // 
            // clnitem
            // 
            this.clnitem.FillWeight = 145.1756F;
            this.clnitem.HeaderText = "Item";
            this.clnitem.Name = "clnitem";
            // 
            // clnqty
            // 
            this.clnqty.FillWeight = 50F;
            this.clnqty.HeaderText = "Qty";
            this.clnqty.Name = "clnqty";
            // 
            // clnrate
            // 
            this.clnrate.FillWeight = 99.38583F;
            this.clnrate.HeaderText = "Rate";
            this.clnrate.Name = "clnrate";
            // 
            // Frmreceivedproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1025, 552);
            this.Controls.Add(this.linkissueproduct);
            this.Controls.Add(this.linksetproduct);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmddelete);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cmdforward);
            this.Controls.Add(this.cmdback);
            this.Controls.Add(this.txtidgeneralledger);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtamounttodebited);
            this.Controls.Add(this.txtbvno);
            this.Controls.Add(this.Gridlist);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Dtrecdate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtremarks);
            this.Controls.Add(this.txtissuedate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pnlCentre);
            this.Controls.Add(this.txtemployee);
            this.Controls.Add(this.txtissueid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.txtmainqty);
            this.Controls.Add(this.gridmain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtreceivedid);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Commainproduct);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Frmreceivedproduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Received Product";
            this.Load += new System.EventHandler(this.Frmreceivedproduct_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Frmreceivedproduct_PreviewKeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmreceivedproduct_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Commainproduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtreceivedid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtsearch;
        public System.Windows.Forms.DataGridView gridmain;
        public System.Windows.Forms.TextBox txtmainqty;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtemployee;
        public System.Windows.Forms.TextBox txtissueid;
        private System.Windows.Forms.Panel pnlCentre;
        public System.Windows.Forms.TextBox txtissuedate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtremarks;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker Dtrecdate;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.DataGridView Gridlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnissueid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnissuedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnemployee;
        public System.Windows.Forms.TextBox txtbvno;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtamounttodebited;
        public System.Windows.Forms.TextBox txtidgeneralledger;
        private System.Windows.Forms.Button cmdforward;
        private System.Windows.Forms.Button cmdback;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmddelete;
        private System.Windows.Forms.LinkLabel linksetproduct;
        private System.Windows.Forms.LinkLabel linkissueproduct;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnbatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnrate;
    }
}