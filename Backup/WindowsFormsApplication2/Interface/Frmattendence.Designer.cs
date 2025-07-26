namespace WindowsFormsApplication2
{
    partial class Frmattendence
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnltop = new System.Windows.Forms.Panel();
            this.cmdrefresh = new System.Windows.Forms.Button();
            this.chkmarkovertime = new System.Windows.Forms.CheckBox();
            this.chkmark = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdForward = new System.Windows.Forms.Button();
            this.CmdBack = new System.Windows.Forms.Button();
            this.txtvno = new System.Windows.Forms.TextBox();
            this.lblemployee = new System.Windows.Forms.Label();
            this.comodeofpayment = new System.Windows.Forms.ComboBox();
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltotalsalary = new System.Windows.Forms.Label();
            this.lbltotalattendence = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltotalextra = new System.Windows.Forms.Label();
            this.lbloverdutyno = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pnlright = new System.Windows.Forms.Panel();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbltotalextra2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdclose = new System.Windows.Forms.Button();
            this.cmddelete = new System.Windows.Forms.Button();
            this.cmdclear = new System.Windows.Forms.Button();
            this.cmdsave = new System.Windows.Forms.Button();
            this.pnlcenter = new System.Windows.Forms.Panel();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.clnslno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnempcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnempname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnmobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clndepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnmark = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnsalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnmarkover = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clnexsalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnextra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnnote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clntotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnltop.SuspendLayout();
            this.pnlbottom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnlright.SuspendLayout();
            this.pnlcenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.pnltop.Controls.Add(this.cmdrefresh);
            this.pnltop.Controls.Add(this.chkmarkovertime);
            this.pnltop.Controls.Add(this.chkmark);
            this.pnltop.Controls.Add(this.label2);
            this.pnltop.Controls.Add(this.dtdate);
            this.pnltop.Controls.Add(this.label1);
            this.pnltop.Controls.Add(this.CmdForward);
            this.pnltop.Controls.Add(this.CmdBack);
            this.pnltop.Controls.Add(this.txtvno);
            this.pnltop.Controls.Add(this.lblemployee);
            this.pnltop.Controls.Add(this.comodeofpayment);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(842, 72);
            this.pnltop.TabIndex = 0;
            // 
            // cmdrefresh
            // 
            this.cmdrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdrefresh.Location = new System.Drawing.Point(611, 4);
            this.cmdrefresh.Name = "cmdrefresh";
            this.cmdrefresh.Size = new System.Drawing.Size(75, 37);
            this.cmdrefresh.TabIndex = 1011;
            this.cmdrefresh.Text = "Refresh";
            this.cmdrefresh.UseVisualStyleBackColor = true;
            this.cmdrefresh.Click += new System.EventHandler(this.cmdrefresh_Click);
            // 
            // chkmarkovertime
            // 
            this.chkmarkovertime.AutoSize = true;
            this.chkmarkovertime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkmarkovertime.Location = new System.Drawing.Point(695, 21);
            this.chkmarkovertime.Name = "chkmarkovertime";
            this.chkmarkovertime.Size = new System.Drawing.Size(108, 17);
            this.chkmarkovertime.TabIndex = 1010;
            this.chkmarkovertime.Text = "All(Marking Extra)";
            this.chkmarkovertime.UseVisualStyleBackColor = true;
            this.chkmarkovertime.CheckedChanged += new System.EventHandler(this.chkmarkovertime_CheckedChanged);
            // 
            // chkmark
            // 
            this.chkmark.AutoSize = true;
            this.chkmark.Checked = true;
            this.chkmark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkmark.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkmark.Location = new System.Drawing.Point(695, 6);
            this.chkmark.Name = "chkmark";
            this.chkmark.Size = new System.Drawing.Size(138, 17);
            this.chkmark.TabIndex = 1009;
            this.chkmark.Text = "All(Marking attendence)";
            this.chkmark.UseVisualStyleBackColor = true;
            this.chkmark.CheckedChanged += new System.EventHandler(this.chkmark_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(678, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1008;
            this.label2.Text = "Date";
            // 
            // dtdate
            // 
            this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdate.Location = new System.Drawing.Point(722, 42);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(108, 20);
            this.dtdate.TabIndex = 1007;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1003;
            this.label1.Text = "Vno";
            // 
            // CmdForward
            // 
            this.CmdForward.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmdForward.Location = new System.Drawing.Point(170, 15);
            this.CmdForward.Name = "CmdForward";
            this.CmdForward.Size = new System.Drawing.Size(23, 23);
            this.CmdForward.TabIndex = 1006;
            this.CmdForward.TabStop = false;
            this.CmdForward.Text = ">";
            this.CmdForward.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdForward.UseVisualStyleBackColor = true;
            this.CmdForward.Click += new System.EventHandler(this.CmdForward_Click);
            // 
            // CmdBack
            // 
            this.CmdBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmdBack.Location = new System.Drawing.Point(149, 15);
            this.CmdBack.Name = "CmdBack";
            this.CmdBack.Size = new System.Drawing.Size(23, 23);
            this.CmdBack.TabIndex = 1005;
            this.CmdBack.TabStop = false;
            this.CmdBack.Text = "<";
            this.CmdBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CmdBack.UseVisualStyleBackColor = true;
            this.CmdBack.Click += new System.EventHandler(this.CmdBack_Click);
            // 
            // txtvno
            // 
            this.txtvno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.txtvno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtvno.ForeColor = System.Drawing.Color.White;
            this.txtvno.Location = new System.Drawing.Point(199, 14);
            this.txtvno.Name = "txtvno";
            this.txtvno.ReadOnly = true;
            this.txtvno.Size = new System.Drawing.Size(72, 25);
            this.txtvno.TabIndex = 1002;
            // 
            // lblemployee
            // 
            this.lblemployee.AutoSize = true;
            this.lblemployee.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemployee.ForeColor = System.Drawing.Color.White;
            this.lblemployee.Location = new System.Drawing.Point(12, 49);
            this.lblemployee.Name = "lblemployee";
            this.lblemployee.Size = new System.Drawing.Size(70, 13);
            this.lblemployee.TabIndex = 27;
            this.lblemployee.Text = "Select mode";
            // 
            // comodeofpayment
            // 
            this.comodeofpayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.comodeofpayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comodeofpayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comodeofpayment.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.comodeofpayment.ForeColor = System.Drawing.Color.White;
            this.comodeofpayment.FormattingEnabled = true;
            this.comodeofpayment.Items.AddRange(new object[] {
            "All",
            "Hourly",
            "Dialy",
            "Weekly",
            "Month"});
            this.comodeofpayment.Location = new System.Drawing.Point(150, 45);
            this.comodeofpayment.Name = "comodeofpayment";
            this.comodeofpayment.Size = new System.Drawing.Size(154, 21);
            this.comodeofpayment.TabIndex = 26;
            this.comodeofpayment.SelectedIndexChanged += new System.EventHandler(this.Comemployee_SelectedIndexChanged);
            // 
            // pnlbottom
            // 
            this.pnlbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.pnlbottom.Controls.Add(this.panel2);
            this.pnlbottom.Controls.Add(this.panel1);
            this.pnlbottom.Controls.Add(this.Pnlright);
            this.pnlbottom.Controls.Add(this.cmdclose);
            this.pnlbottom.Controls.Add(this.cmddelete);
            this.pnlbottom.Controls.Add(this.cmdclear);
            this.pnlbottom.Controls.Add(this.cmdsave);
            this.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbottom.Location = new System.Drawing.Point(0, 439);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(842, 47);
            this.pnlbottom.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbltotalsalary);
            this.panel2.Controls.Add(this.lbltotalattendence);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(306, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 47);
            this.panel2.TabIndex = 11;
            // 
            // lbltotalsalary
            // 
            this.lbltotalsalary.AutoSize = true;
            this.lbltotalsalary.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbltotalsalary.ForeColor = System.Drawing.Color.Red;
            this.lbltotalsalary.Location = new System.Drawing.Point(121, 26);
            this.lbltotalsalary.Name = "lbltotalsalary";
            this.lbltotalsalary.Size = new System.Drawing.Size(28, 13);
            this.lbltotalsalary.TabIndex = 1007;
            this.lbltotalsalary.Text = "0.00";
            // 
            // lbltotalattendence
            // 
            this.lbltotalattendence.AutoSize = true;
            this.lbltotalattendence.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbltotalattendence.ForeColor = System.Drawing.Color.Red;
            this.lbltotalattendence.Location = new System.Drawing.Point(121, 6);
            this.lbltotalattendence.Name = "lbltotalattendence";
            this.lbltotalattendence.Size = new System.Drawing.Size(28, 13);
            this.lbltotalattendence.TabIndex = 1006;
            this.lbltotalattendence.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 1005;
            this.label5.Text = "Total salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 1004;
            this.label8.Text = "Total attendence";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbltotalextra);
            this.panel1.Controls.Add(this.lbloverdutyno);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(454, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 47);
            this.panel1.TabIndex = 10;
            // 
            // lbltotalextra
            // 
            this.lbltotalextra.AutoSize = true;
            this.lbltotalextra.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbltotalextra.ForeColor = System.Drawing.Color.Red;
            this.lbltotalextra.Location = new System.Drawing.Point(111, 26);
            this.lbltotalextra.Name = "lbltotalextra";
            this.lbltotalextra.Size = new System.Drawing.Size(28, 13);
            this.lbltotalextra.TabIndex = 1008;
            this.lbltotalextra.Text = "0.00";
            // 
            // lbloverdutyno
            // 
            this.lbloverdutyno.AutoSize = true;
            this.lbloverdutyno.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbloverdutyno.ForeColor = System.Drawing.Color.Red;
            this.lbloverdutyno.Location = new System.Drawing.Point(111, 6);
            this.lbloverdutyno.Name = "lbloverdutyno";
            this.lbloverdutyno.Size = new System.Drawing.Size(28, 13);
            this.lbloverdutyno.TabIndex = 1007;
            this.lbloverdutyno.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 1005;
            this.label7.Text = "Total extra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 1004;
            this.label6.Text = "Over duty(No)";
            // 
            // Pnlright
            // 
            this.Pnlright.Controls.Add(this.lbltotal);
            this.Pnlright.Controls.Add(this.lbltotalextra2);
            this.Pnlright.Controls.Add(this.label4);
            this.Pnlright.Controls.Add(this.label3);
            this.Pnlright.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnlright.Location = new System.Drawing.Point(648, 0);
            this.Pnlright.Name = "Pnlright";
            this.Pnlright.Size = new System.Drawing.Size(194, 47);
            this.Pnlright.TabIndex = 9;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbltotal.ForeColor = System.Drawing.Color.Red;
            this.lbltotal.Location = new System.Drawing.Point(78, 23);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(37, 19);
            this.lbltotal.TabIndex = 1008;
            this.lbltotal.Text = "0.00";
            // 
            // lbltotalextra2
            // 
            this.lbltotalextra2.AutoSize = true;
            this.lbltotalextra2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbltotalextra2.ForeColor = System.Drawing.Color.Red;
            this.lbltotalextra2.Location = new System.Drawing.Point(78, 6);
            this.lbltotalextra2.Name = "lbltotalextra2";
            this.lbltotalextra2.Size = new System.Drawing.Size(28, 13);
            this.lbltotalextra2.TabIndex = 1007;
            this.lbltotalextra2.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1005;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1004;
            this.label3.Text = "Total extra2";
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdclose.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatAppearance.BorderSize = 0;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(225, 0);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 47);
            this.cmdclose.TabIndex = 8;
            this.cmdclose.Text = "Close";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // cmddelete
            // 
            this.cmddelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmddelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmddelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmddelete.FlatAppearance.BorderSize = 0;
            this.cmddelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmddelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmddelete.ForeColor = System.Drawing.Color.Black;
            this.cmddelete.Location = new System.Drawing.Point(150, 0);
            this.cmddelete.Name = "cmddelete";
            this.cmddelete.Size = new System.Drawing.Size(75, 47);
            this.cmddelete.TabIndex = 7;
            this.cmddelete.Text = "Delete";
            this.cmddelete.UseVisualStyleBackColor = false;
            this.cmddelete.Click += new System.EventHandler(this.cmddelete_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdclear.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdclear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclear.FlatAppearance.BorderSize = 0;
            this.cmdclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdclear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclear.ForeColor = System.Drawing.Color.Black;
            this.cmdclear.Location = new System.Drawing.Point(75, 0);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(75, 47);
            this.cmdclear.TabIndex = 6;
            this.cmdclear.Text = "Clear";
            this.cmdclear.UseVisualStyleBackColor = false;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // cmdsave
            // 
            this.cmdsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdsave.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdsave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdsave.FlatAppearance.BorderSize = 0;
            this.cmdsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdsave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsave.ForeColor = System.Drawing.Color.Black;
            this.cmdsave.Location = new System.Drawing.Point(0, 0);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(75, 47);
            this.cmdsave.TabIndex = 5;
            this.cmdsave.Text = "Save(F5)";
            this.cmdsave.UseVisualStyleBackColor = false;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // pnlcenter
            // 
            this.pnlcenter.Controls.Add(this.gridmain);
            this.pnlcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcenter.Location = new System.Drawing.Point(0, 72);
            this.pnlcenter.Name = "pnlcenter";
            this.pnlcenter.Size = new System.Drawing.Size(842, 367);
            this.pnlcenter.TabIndex = 2;
            // 
            // gridmain
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridmain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridmain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridmain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.gridmain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridmain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridmain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridmain.ColumnHeadersHeight = 31;
            this.gridmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnslno,
            this.clnempcode,
            this.clnempname,
            this.clnmobile,
            this.clndepartment,
            this.clnmark,
            this.clnsalary,
            this.clnmarkover,
            this.clnexsalary,
            this.clnextra2,
            this.clnnote,
            this.clntotal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridmain.EnableHeadersVisualStyles = false;
            this.gridmain.Location = new System.Drawing.Point(0, 0);
            this.gridmain.MultiSelect = false;
            this.gridmain.Name = "gridmain";
            this.gridmain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridmain.RowHeadersVisible = false;
            this.gridmain.RowHeadersWidth = 100;
            this.gridmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridmain.ShowRowErrors = false;
            this.gridmain.Size = new System.Drawing.Size(842, 367);
            this.gridmain.TabIndex = 2;
            this.gridmain.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellValueChanged);
            this.gridmain.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridmain_EditingControlShowing);
            this.gridmain.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridmain_DataError);
            this.gridmain.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmain_CellEnter);
            // 
            // clnslno
            // 
            this.clnslno.FillWeight = 36.6824F;
            this.clnslno.HeaderText = "Slno";
            this.clnslno.Name = "clnslno";
            this.clnslno.ReadOnly = true;
            // 
            // clnempcode
            // 
            this.clnempcode.FillWeight = 140.1275F;
            this.clnempcode.HeaderText = "Emp.Code";
            this.clnempcode.Name = "clnempcode";
            this.clnempcode.ReadOnly = true;
            // 
            // clnempname
            // 
            this.clnempname.FillWeight = 140.1275F;
            this.clnempname.HeaderText = "Name";
            this.clnempname.Name = "clnempname";
            this.clnempname.ReadOnly = true;
            this.clnempname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clnmobile
            // 
            this.clnmobile.FillWeight = 93.41834F;
            this.clnmobile.HeaderText = "Mobile";
            this.clnmobile.Name = "clnmobile";
            // 
            // clndepartment
            // 
            this.clndepartment.HeaderText = "Department";
            this.clndepartment.Name = "clndepartment";
            // 
            // clnmark
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnmark.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnmark.FalseValue = "0";
            this.clnmark.FillWeight = 65.39285F;
            this.clnmark.HeaderText = "Mark(Atte)";
            this.clnmark.IndeterminateValue = "";
            this.clnmark.Name = "clnmark";
            this.clnmark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnmark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnmark.TrueValue = "1";
            // 
            // clnsalary
            // 
            dataGridViewCellStyle4.NullValue = "0.00";
            this.clnsalary.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnsalary.FillWeight = 65.39285F;
            this.clnsalary.HeaderText = "Salary";
            this.clnsalary.Name = "clnsalary";
            // 
            // clnmarkover
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clnmarkover.DefaultCellStyle = dataGridViewCellStyle5;
            this.clnmarkover.FalseValue = "0";
            this.clnmarkover.HeaderText = "Mark(OV Duty)";
            this.clnmarkover.Name = "clnmarkover";
            this.clnmarkover.TrueValue = "1";
            // 
            // clnexsalary
            // 
            dataGridViewCellStyle6.NullValue = "0.00";
            this.clnexsalary.DefaultCellStyle = dataGridViewCellStyle6;
            this.clnexsalary.HeaderText = "Extra";
            this.clnexsalary.Name = "clnexsalary";
            // 
            // clnextra2
            // 
            dataGridViewCellStyle7.NullValue = "0.00";
            this.clnextra2.DefaultCellStyle = dataGridViewCellStyle7;
            this.clnextra2.HeaderText = "Extra2";
            this.clnextra2.Name = "clnextra2";
            // 
            // clnnote
            // 
            this.clnnote.FillWeight = 112.102F;
            this.clnnote.HeaderText = "Note";
            this.clnnote.Name = "clnnote";
            this.clnnote.ReadOnly = true;
            // 
            // clntotal
            // 
            this.clntotal.HeaderText = "Total";
            this.clntotal.Name = "clntotal";
            this.clntotal.ReadOnly = true;
            // 
            // Frmattendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 486);
            this.Controls.Add(this.pnlcenter);
            this.Controls.Add(this.pnlbottom);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Frmattendence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendence sheet";
            this.Load += new System.EventHandler(this.Frmattendence_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmattendence_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmattendence_KeyDown);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlbottom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pnlright.ResumeLayout(false);
            this.Pnlright.PerformLayout();
            this.pnlcenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Panel pnlcenter;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button cmddelete;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Button cmdsave;
        private System.Windows.Forms.Label lblemployee;
        private System.Windows.Forms.ComboBox comodeofpayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdForward;
        private System.Windows.Forms.Button CmdBack;
        public System.Windows.Forms.TextBox txtvno;
        public System.Windows.Forms.DataGridView gridmain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.CheckBox chkmark;
        private System.Windows.Forms.CheckBox chkmarkovertime;
        private System.Windows.Forms.Panel Pnlright;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbltotalsalary;
        private System.Windows.Forms.Label lbltotalattendence;
        private System.Windows.Forms.Label lbltotalextra;
        private System.Windows.Forms.Label lbloverdutyno;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbltotalextra2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdrefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnslno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnempcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnempname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnmobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clndepartment;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnmark;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnsalary;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnmarkover;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnexsalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnextra2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnnote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clntotal;
    }
}