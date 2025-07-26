namespace WindowsFormsApplication2
{
    partial class Frmcommandwindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcommandwindow));
            this.Richmain = new System.Windows.Forms.RichTextBox();
            this.cmdexecute = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CMDnegetivestockremove = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtvalidatnfrom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdsetvali = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtvalidtnto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CMDUPDATELASTSRATE = new System.Windows.Forms.Button();
            this.chkvalidity = new System.Windows.Forms.CheckBox();
            this.chknickname = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmd_set_Vno = new System.Windows.Forms.Button();
            this.txtPiVno = new System.Windows.Forms.TextBox();
            this.txtSiVno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Chkenableencriptqrcode = new System.Windows.Forms.CheckBox();
            this.chksaleedit = new System.Windows.Forms.CheckBox();
            this.chkdeletesales = new System.Windows.Forms.CheckBox();
            this.Chkenableregistrationdetails = new System.Windows.Forms.CheckBox();
            this.Chkenablecustomerid = new System.Windows.Forms.CheckBox();
            this.Chksenableprinterselection = new System.Windows.Forms.CheckBox();
            this.CmdtoolData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Chkincludebatch = new System.Windows.Forms.CheckBox();
            this.DtFrom = new System.Windows.Forms.DateTimePicker();
            this.cmdcleartransaction = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlright = new System.Windows.Forms.Panel();
            this.pnlleft = new System.Windows.Forms.Panel();
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.pnltop = new System.Windows.Forms.Panel();
            this.Gridmain = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridmain)).BeginInit();
            this.SuspendLayout();
            // 
            // Richmain
            // 
            this.Richmain.Dock = System.Windows.Forms.DockStyle.Top;
            this.Richmain.Location = new System.Drawing.Point(0, 0);
            this.Richmain.Name = "Richmain";
            this.Richmain.Size = new System.Drawing.Size(1221, 118);
            this.Richmain.TabIndex = 90;
            this.Richmain.Text = "";
            // 
            // cmdexecute
            // 
            this.cmdexecute.BackColor = System.Drawing.Color.ForestGreen;
            this.cmdexecute.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdexecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdexecute.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdexecute.ForeColor = System.Drawing.Color.White;
            this.cmdexecute.Location = new System.Drawing.Point(181, 5);
            this.cmdexecute.Name = "cmdexecute";
            this.cmdexecute.Size = new System.Drawing.Size(131, 36);
            this.cmdexecute.TabIndex = 91;
            this.cmdexecute.Text = "Execute query";
            this.cmdexecute.UseVisualStyleBackColor = false;
            this.cmdexecute.Click += new System.EventHandler(this.cmdexecute_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.CMDnegetivestockremove);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.CMDUPDATELASTSRATE);
            this.panel1.Controls.Add(this.chkvalidity);
            this.panel1.Controls.Add(this.chknickname);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Chkenableencriptqrcode);
            this.panel1.Controls.Add(this.chksaleedit);
            this.panel1.Controls.Add(this.chkdeletesales);
            this.panel1.Controls.Add(this.Chkenableregistrationdetails);
            this.panel1.Controls.Add(this.Chkenablecustomerid);
            this.panel1.Controls.Add(this.Chksenableprinterselection);
            this.panel1.Controls.Add(this.CmdtoolData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DtTo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.Chkincludebatch);
            this.panel1.Controls.Add(this.DtFrom);
            this.panel1.Controls.Add(this.cmdcleartransaction);
            this.panel1.Controls.Add(this.cmdexecute);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 137);
            this.panel1.TabIndex = 93;
            // 
            // CMDnegetivestockremove
            // 
            this.CMDnegetivestockremove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CMDnegetivestockremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMDnegetivestockremove.Location = new System.Drawing.Point(899, 52);
            this.CMDnegetivestockremove.Name = "CMDnegetivestockremove";
            this.CMDnegetivestockremove.Size = new System.Drawing.Size(152, 27);
            this.CMDnegetivestockremove.TabIndex = 191;
            this.CMDnegetivestockremove.Text = "Remove -ve stock";
            this.CMDnegetivestockremove.UseVisualStyleBackColor = false;
            this.CMDnegetivestockremove.Click += new System.EventHandler(this.CMDnegetivestockremove_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(246)))), ((int)(((byte)(44)))));
            this.panel3.Controls.Add(this.txtvalidatnfrom);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cmdsetvali);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtvalidtnto);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(738, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 73);
            this.panel3.TabIndex = 190;
            // 
            // txtvalidatnfrom
            // 
            this.txtvalidatnfrom.Location = new System.Drawing.Point(49, 23);
            this.txtvalidatnfrom.Name = "txtvalidatnfrom";
            this.txtvalidatnfrom.Size = new System.Drawing.Size(100, 22);
            this.txtvalidatnfrom.TabIndex = 186;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(3, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 183;
            this.label8.Text = "Validation";
            // 
            // cmdsetvali
            // 
            this.cmdsetvali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdsetvali.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdsetvali.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsetvali.Location = new System.Drawing.Point(78, 1);
            this.cmdsetvali.Name = "cmdsetvali";
            this.cmdsetvali.Size = new System.Drawing.Size(66, 21);
            this.cmdsetvali.TabIndex = 188;
            this.cmdsetvali.Text = "Set";
            this.cmdsetvali.UseVisualStyleBackColor = false;
            this.cmdsetvali.Click += new System.EventHandler(this.cmdsetvali_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(3, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 14);
            this.label7.TabIndex = 184;
            this.label7.Text = "From :";
            // 
            // txtvalidtnto
            // 
            this.txtvalidtnto.Location = new System.Drawing.Point(49, 44);
            this.txtvalidtnto.Name = "txtvalidtnto";
            this.txtvalidtnto.Size = new System.Drawing.Size(100, 22);
            this.txtvalidtnto.TabIndex = 187;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(3, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 14);
            this.label6.TabIndex = 185;
            this.label6.Text = "To:";
            // 
            // CMDUPDATELASTSRATE
            // 
            this.CMDUPDATELASTSRATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CMDUPDATELASTSRATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMDUPDATELASTSRATE.Location = new System.Drawing.Point(338, 2);
            this.CMDUPDATELASTSRATE.Name = "CMDUPDATELASTSRATE";
            this.CMDUPDATELASTSRATE.Size = new System.Drawing.Size(66, 46);
            this.CMDUPDATELASTSRATE.TabIndex = 189;
            this.CMDUPDATELASTSRATE.Text = "Update last Srate";
            this.CMDUPDATELASTSRATE.UseVisualStyleBackColor = false;
            this.CMDUPDATELASTSRATE.Click += new System.EventHandler(this.CMDUPDATELASTSRATE_Click);
            // 
            // chkvalidity
            // 
            this.chkvalidity.AutoSize = true;
            this.chkvalidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chkvalidity.Location = new System.Drawing.Point(338, 114);
            this.chkvalidity.Name = "chkvalidity";
            this.chkvalidity.Size = new System.Drawing.Size(87, 17);
            this.chkvalidity.TabIndex = 174;
            this.chkvalidity.Text = "Validity Edit";
            this.chkvalidity.UseVisualStyleBackColor = false;
            this.chkvalidity.CheckedChanged += new System.EventHandler(this.chkvalidity_CheckedChanged);
            // 
            // chknickname
            // 
            this.chknickname.AutoSize = true;
            this.chknickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chknickname.Location = new System.Drawing.Point(338, 94);
            this.chknickname.Name = "chknickname";
            this.chknickname.Size = new System.Drawing.Size(101, 17);
            this.chknickname.TabIndex = 173;
            this.chknickname.Text = "Nickname Edit";
            this.chknickname.UseVisualStyleBackColor = false;
            this.chknickname.CheckedChanged += new System.EventHandler(this.chknickname_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(246)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.cmd_set_Vno);
            this.panel2.Controls.Add(this.txtPiVno);
            this.panel2.Controls.Add(this.txtSiVno);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(502, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 78);
            this.panel2.TabIndex = 172;
            // 
            // cmd_set_Vno
            // 
            this.cmd_set_Vno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmd_set_Vno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_set_Vno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmd_set_Vno.Location = new System.Drawing.Point(181, 22);
            this.cmd_set_Vno.Name = "cmd_set_Vno";
            this.cmd_set_Vno.Size = new System.Drawing.Size(44, 47);
            this.cmd_set_Vno.TabIndex = 5;
            this.cmd_set_Vno.Text = "Set Vno";
            this.cmd_set_Vno.UseVisualStyleBackColor = false;
            this.cmd_set_Vno.Click += new System.EventHandler(this.cmd_set_Vno_Click);
            // 
            // txtPiVno
            // 
            this.txtPiVno.Location = new System.Drawing.Point(86, 47);
            this.txtPiVno.Name = "txtPiVno";
            this.txtPiVno.Size = new System.Drawing.Size(89, 22);
            this.txtPiVno.TabIndex = 4;
            // 
            // txtSiVno
            // 
            this.txtSiVno.Location = new System.Drawing.Point(86, 22);
            this.txtSiVno.Name = "txtSiVno";
            this.txtSiVno.Size = new System.Drawing.Size(89, 22);
            this.txtSiVno.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "PI Vno Start :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "SI Vno Start :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Default VNO Start";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Chkenableencriptqrcode
            // 
            this.Chkenableencriptqrcode.AutoSize = true;
            this.Chkenableencriptqrcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Chkenableencriptqrcode.Checked = true;
            this.Chkenableencriptqrcode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chkenableencriptqrcode.Location = new System.Drawing.Point(199, 115);
            this.Chkenableencriptqrcode.Name = "Chkenableencriptqrcode";
            this.Chkenableencriptqrcode.Size = new System.Drawing.Size(140, 17);
            this.Chkenableencriptqrcode.TabIndex = 171;
            this.Chkenableencriptqrcode.Text = "Enable Encript Qrcode";
            this.Chkenableencriptqrcode.UseVisualStyleBackColor = false;
            this.Chkenableencriptqrcode.CheckedChanged += new System.EventHandler(this.Chkenableencriptqrcode_CheckedChanged);
            // 
            // chksaleedit
            // 
            this.chksaleedit.AutoSize = true;
            this.chksaleedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chksaleedit.Checked = true;
            this.chksaleedit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chksaleedit.Location = new System.Drawing.Point(199, 92);
            this.chksaleedit.Name = "chksaleedit";
            this.chksaleedit.Size = new System.Drawing.Size(105, 17);
            this.chksaleedit.TabIndex = 170;
            this.chksaleedit.Text = "Enable SaleEdit";
            this.chksaleedit.UseVisualStyleBackColor = false;
            this.chksaleedit.CheckedChanged += new System.EventHandler(this.chksaleedit_CheckedChanged);
            // 
            // chkdeletesales
            // 
            this.chkdeletesales.AutoSize = true;
            this.chkdeletesales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chkdeletesales.Checked = true;
            this.chkdeletesales.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkdeletesales.Location = new System.Drawing.Point(200, 69);
            this.chkdeletesales.Name = "chkdeletesales";
            this.chkdeletesales.Size = new System.Drawing.Size(118, 17);
            this.chkdeletesales.TabIndex = 169;
            this.chkdeletesales.Text = "Enable SaleDelete";
            this.chkdeletesales.UseVisualStyleBackColor = false;
            this.chkdeletesales.CheckedChanged += new System.EventHandler(this.chkdeletesales_CheckedChanged);
            // 
            // Chkenableregistrationdetails
            // 
            this.Chkenableregistrationdetails.AutoSize = true;
            this.Chkenableregistrationdetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Chkenableregistrationdetails.Checked = true;
            this.Chkenableregistrationdetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chkenableregistrationdetails.Location = new System.Drawing.Point(19, 115);
            this.Chkenableregistrationdetails.Name = "Chkenableregistrationdetails";
            this.Chkenableregistrationdetails.Size = new System.Drawing.Size(164, 17);
            this.Chkenableregistrationdetails.TabIndex = 168;
            this.Chkenableregistrationdetails.Text = "Enable Registration details";
            this.Chkenableregistrationdetails.UseVisualStyleBackColor = false;
            this.Chkenableregistrationdetails.CheckedChanged += new System.EventHandler(this.Chkenableregistrationdetails_CheckedChanged);
            // 
            // Chkenablecustomerid
            // 
            this.Chkenablecustomerid.AutoSize = true;
            this.Chkenablecustomerid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Chkenablecustomerid.Checked = true;
            this.Chkenablecustomerid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chkenablecustomerid.Location = new System.Drawing.Point(19, 92);
            this.Chkenablecustomerid.Name = "Chkenablecustomerid";
            this.Chkenablecustomerid.Size = new System.Drawing.Size(180, 17);
            this.Chkenablecustomerid.TabIndex = 167;
            this.Chkenablecustomerid.Text = "Enable Customer Id  and Area";
            this.Chkenablecustomerid.UseVisualStyleBackColor = false;
            this.Chkenablecustomerid.CheckedChanged += new System.EventHandler(this.Chkenablecustomerid_CheckedChanged);
            // 
            // Chksenableprinterselection
            // 
            this.Chksenableprinterselection.AutoSize = true;
            this.Chksenableprinterselection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Chksenableprinterselection.Checked = true;
            this.Chksenableprinterselection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chksenableprinterselection.Location = new System.Drawing.Point(19, 69);
            this.Chksenableprinterselection.Name = "Chksenableprinterselection";
            this.Chksenableprinterselection.Size = new System.Drawing.Size(189, 17);
            this.Chksenableprinterselection.TabIndex = 166;
            this.Chksenableprinterselection.Text = "Enable Printer selection in sales";
            this.Chksenableprinterselection.UseVisualStyleBackColor = false;
            this.Chksenableprinterselection.CheckedChanged += new System.EventHandler(this.Chksenableprinterselection_CheckedChanged);
            // 
            // CmdtoolData
            // 
            this.CmdtoolData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CmdtoolData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdtoolData.Location = new System.Drawing.Point(982, 0);
            this.CmdtoolData.Name = "CmdtoolData";
            this.CmdtoolData.Size = new System.Drawing.Size(69, 46);
            this.CmdtoolData.TabIndex = 165;
            this.CmdtoolData.Text = "Tool Data";
            this.CmdtoolData.UseVisualStyleBackColor = false;
            this.CmdtoolData.Click += new System.EventHandler(this.CmdtoolData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(801, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 164;
            this.label1.Text = "To";
            // 
            // DtTo
            // 
            this.DtTo.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtTo.Location = new System.Drawing.Point(829, 16);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(147, 22);
            this.DtTo.TabIndex = 162;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(583, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 163;
            this.label3.Text = "From";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(502, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 103;
            this.button3.Text = "Excel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Chkincludebatch
            // 
            this.Chkincludebatch.AutoSize = true;
            this.Chkincludebatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Chkincludebatch.Location = new System.Drawing.Point(338, 74);
            this.Chkincludebatch.Name = "Chkincludebatch";
            this.Chkincludebatch.Size = new System.Drawing.Size(96, 17);
            this.Chkincludebatch.TabIndex = 102;
            this.Chkincludebatch.Text = "Include Batch";
            this.Chkincludebatch.UseVisualStyleBackColor = false;
            // 
            // DtFrom
            // 
            this.DtFrom.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.DtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtFrom.Location = new System.Drawing.Point(627, 16);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.Size = new System.Drawing.Size(151, 22);
            this.DtFrom.TabIndex = 161;
            // 
            // cmdcleartransaction
            // 
            this.cmdcleartransaction.BackColor = System.Drawing.Color.Salmon;
            this.cmdcleartransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdcleartransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdcleartransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcleartransaction.ForeColor = System.Drawing.Color.Black;
            this.cmdcleartransaction.Location = new System.Drawing.Point(19, 5);
            this.cmdcleartransaction.Name = "cmdcleartransaction";
            this.cmdcleartransaction.Size = new System.Drawing.Size(129, 36);
            this.cmdcleartransaction.TabIndex = 92;
            this.cmdcleartransaction.Text = "Clear Transaction";
            this.cmdcleartransaction.UseVisualStyleBackColor = false;
            this.cmdcleartransaction.Click += new System.EventHandler(this.cmdcleartransaction_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 477);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 36);
            this.textBox1.TabIndex = 95;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 96;
            this.button1.Text = "RfreshDB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(19, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 33);
            this.button2.TabIndex = 97;
            this.button2.Text = "Refresh DB";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlright
            // 
            this.pnlright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlright.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlright.Location = new System.Drawing.Point(0, 255);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(3, 261);
            this.pnlright.TabIndex = 98;
            // 
            // pnlleft
            // 
            this.pnlleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlleft.Location = new System.Drawing.Point(1218, 255);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(3, 261);
            this.pnlleft.TabIndex = 99;
            // 
            // pnlbottom
            // 
            this.pnlbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbottom.Location = new System.Drawing.Point(3, 513);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(1215, 3);
            this.pnlbottom.TabIndex = 100;
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(3, 255);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1215, 3);
            this.pnltop.TabIndex = 101;
            // 
            // Gridmain
            // 
            this.Gridmain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Gridmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gridmain.Location = new System.Drawing.Point(3, 258);
            this.Gridmain.Name = "Gridmain";
            this.Gridmain.Size = new System.Drawing.Size(1215, 255);
            this.Gridmain.TabIndex = 102;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.ForestGreen;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1078, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 36);
            this.button4.TabIndex = 192;
            this.button4.Text = "Ex queryServer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Salmon;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(1078, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 36);
            this.button5.TabIndex = 193;
            this.button5.Text = "Clear Trn Server";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Frmcommandwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1221, 516);
            this.Controls.Add(this.Gridmain);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.pnlbottom);
            this.Controls.Add(this.pnlleft);
            this.Controls.Add(this.pnlright);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Richmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frmcommandwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command Window";
            this.Load += new System.EventHandler(this.Frmcommandwindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmcommandwindow_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridmain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Richmain;
        private System.Windows.Forms.Button cmdexecute;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdcleartransaction;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlright;
        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.CheckBox Chkincludebatch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CmdtoolData;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker DtTo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker DtFrom;
        private System.Windows.Forms.CheckBox Chksenableprinterselection;
        private System.Windows.Forms.DataGridView Gridmain;
        private System.Windows.Forms.CheckBox Chkenablecustomerid;
        private System.Windows.Forms.CheckBox Chkenableregistrationdetails;
        private System.Windows.Forms.CheckBox chkdeletesales;
        private System.Windows.Forms.CheckBox chksaleedit;
        private System.Windows.Forms.CheckBox Chkenableencriptqrcode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmd_set_Vno;
        private System.Windows.Forms.TextBox txtPiVno;
        private System.Windows.Forms.TextBox txtSiVno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkvalidity;
        private System.Windows.Forms.CheckBox chknickname;
        private System.Windows.Forms.Button cmdsetvali;
        private System.Windows.Forms.TextBox txtvalidtnto;
        private System.Windows.Forms.TextBox txtvalidatnfrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CMDUPDATELASTSRATE;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button CMDnegetivestockremove;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}