namespace WindowsFormsApplication2
{
    partial class Frmemployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmemployees));
            this.label15 = new System.Windows.Forms.Label();
            this.TxtEmployeeId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtDateofJoining = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.RadMale = new System.Windows.Forms.RadioButton();
            this.RadFemale = new System.Windows.Forms.RadioButton();
            this.ChkActiveEmployee = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Griddepartment = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlcentre = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.compaymode = new System.Windows.Forms.ComboBox();
            this.TxtCommision = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.TxtSalary = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.TxtEmpCode = new WindowsFormsApplication2.Uscnormaltextbox();
            this.TxtPhone = new WindowsFormsApplication2.Uscnormaltextbox();
            this.TxtPassportNo = new WindowsFormsApplication2.Uscnormaltextbox();
            this.TxtVisaNo = new WindowsFormsApplication2.Uscnormaltextbox();
            this.TxtEmail = new WindowsFormsApplication2.Uscnormaltextbox();
            this.TxtAddress = new WindowsFormsApplication2.Uscnormaltextbox();
            this.TxtMobile = new WindowsFormsApplication2.Uscnormaltextbox();
            this.Txtdepartment = new WindowsFormsApplication2.Uscnormaltextbox();
            this.TxtName = new WindowsFormsApplication2.Uscnormaltextbox();
            ((System.ComponentModel.ISupportInitialize)(this.Griddepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(13, 94);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 19);
            this.label15.TabIndex = 72;
            this.label15.Text = "Department";
            // 
            // TxtEmployeeId
            // 
            this.TxtEmployeeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TxtEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmployeeId.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmployeeId.Location = new System.Drawing.Point(3, 1);
            this.TxtEmployeeId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmployeeId.Name = "TxtEmployeeId";
            this.TxtEmployeeId.ReadOnly = true;
            this.TxtEmployeeId.Size = new System.Drawing.Size(39, 18);
            this.TxtEmployeeId.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 67;
            this.label10.Text = "Emp.Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 66;
            this.label9.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 75;
            this.label1.Text = "Mobile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 77;
            this.label2.Text = "Date of joining";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 79;
            this.label3.Text = "Address";
            // 
            // DtDateofJoining
            // 
            this.DtDateofJoining.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DtDateofJoining.Location = new System.Drawing.Point(122, 236);
            this.DtDateofJoining.Name = "DtDateofJoining";
            this.DtDateofJoining.Size = new System.Drawing.Size(174, 25);
            this.DtDateofJoining.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 19);
            this.label4.TabIndex = 81;
            this.label4.Text = "Sex";
            // 
            // RadMale
            // 
            this.RadMale.AutoSize = true;
            this.RadMale.Checked = true;
            this.RadMale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RadMale.Location = new System.Drawing.Point(106, 68);
            this.RadMale.Name = "RadMale";
            this.RadMale.Size = new System.Drawing.Size(57, 23);
            this.RadMale.TabIndex = 2;
            this.RadMale.TabStop = true;
            this.RadMale.Text = "Male";
            this.RadMale.UseVisualStyleBackColor = true;
            this.RadMale.CheckedChanged += new System.EventHandler(this.RadMale_CheckedChanged);
            // 
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RadFemale.Location = new System.Drawing.Point(169, 68);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(70, 23);
            this.RadFemale.TabIndex = 3;
            this.RadFemale.TabStop = true;
            this.RadFemale.Text = "Female";
            this.RadFemale.UseVisualStyleBackColor = true;
            this.RadFemale.CheckedChanged += new System.EventHandler(this.RadFemale_CheckedChanged);
            // 
            // ChkActiveEmployee
            // 
            this.ChkActiveEmployee.AutoSize = true;
            this.ChkActiveEmployee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ChkActiveEmployee.Location = new System.Drawing.Point(111, 261);
            this.ChkActiveEmployee.Name = "ChkActiveEmployee";
            this.ChkActiveEmployee.Size = new System.Drawing.Size(128, 23);
            this.ChkActiveEmployee.TabIndex = 9;
            this.ChkActiveEmployee.Text = "Active Employee";
            this.ChkActiveEmployee.UseVisualStyleBackColor = true;
            this.ChkActiveEmployee.CheckedChanged += new System.EventHandler(this.ChkActiveEmployee_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 85;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 88;
            this.label6.Text = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(370, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 90;
            this.label7.Text = "Telephone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(370, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 92;
            this.label8.Text = "Passport No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(370, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 19);
            this.label11.TabIndex = 94;
            this.label11.Text = "Visa No";
            // 
            // CmdClose
            // 
            this.CmdClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.CmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdClose.FlatAppearance.BorderSize = 0;
            this.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CmdClose.ForeColor = System.Drawing.Color.Black;
            this.CmdClose.Location = new System.Drawing.Point(375, 345);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(69, 34);
            this.CmdClose.TabIndex = 17;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = false;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.CmdClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdClear.FlatAppearance.BorderSize = 0;
            this.CmdClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CmdClear.ForeColor = System.Drawing.Color.Black;
            this.CmdClear.Location = new System.Drawing.Point(303, 345);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(69, 34);
            this.CmdClear.TabIndex = 16;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = false;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.CmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdSave.FlatAppearance.BorderSize = 0;
            this.CmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CmdSave.ForeColor = System.Drawing.Color.Black;
            this.CmdSave.Location = new System.Drawing.Point(226, 345);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(74, 34);
            this.CmdSave.TabIndex = 15;
            this.CmdSave.Text = "Save(F5)";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(13, 318);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 19);
            this.label12.TabIndex = 100;
            this.label12.Text = "Commission";
            // 
            // Griddepartment
            // 
            this.Griddepartment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Griddepartment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Griddepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Griddepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Griddepartment.ColumnHeadersVisible = false;
            this.Griddepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.Griddepartment.EnableHeadersVisualStyles = false;
            this.Griddepartment.Location = new System.Drawing.Point(426, 123);
            this.Griddepartment.Name = "Griddepartment";
            this.Griddepartment.ReadOnly = true;
            this.Griddepartment.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Griddepartment.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Griddepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Griddepartment.Size = new System.Drawing.Size(211, 218);
            this.Griddepartment.TabIndex = 106;
            this.Griddepartment.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // pnlcentre
            // 
            this.pnlcentre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlcentre.Location = new System.Drawing.Point(338, 31);
            this.pnlcentre.Name = "pnlcentre";
            this.pnlcentre.Size = new System.Drawing.Size(3, 293);
            this.pnlcentre.TabIndex = 109;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(371, 96);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 19);
            this.label13.TabIndex = 111;
            this.label13.Text = "Payment.Mode";
            // 
            // compaymode
            // 
            this.compaymode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.compaymode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compaymode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.compaymode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.compaymode.ForeColor = System.Drawing.Color.Black;
            this.compaymode.FormattingEnabled = true;
            this.compaymode.Items.AddRange(new object[] {
            "Hourly",
            "Dialy",
            "Weekly",
            "Month"});
            this.compaymode.Location = new System.Drawing.Point(480, 92);
            this.compaymode.Name = "compaymode";
            this.compaymode.Size = new System.Drawing.Size(191, 25);
            this.compaymode.TabIndex = 15;
            // 
            // TxtCommision
            // 
            this.TxtCommision.Location = new System.Drawing.Point(111, 315);
            this.TxtCommision.Name = "TxtCommision";
            this.TxtCommision.Size = new System.Drawing.Size(221, 22);
            this.TxtCommision.TabIndex = 11;
            this.TxtCommision.Leave += new System.EventHandler(this.TxtCommision_Leave);
            this.TxtCommision.Enter += new System.EventHandler(this.TxtCommision_Enter);
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(111, 290);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(221, 19);
            this.TxtSalary.TabIndex = 10;
            this.TxtSalary.Leave += new System.EventHandler(this.TxtSalary_Leave);
            this.TxtSalary.Enter += new System.EventHandler(this.TxtSalary_Enter);
            // 
            // TxtEmpCode
            // 
            this.TxtEmpCode.Location = new System.Drawing.Point(103, 18);
            this.TxtEmpCode.Name = "TxtEmpCode";
            this.TxtEmpCode.Size = new System.Drawing.Size(229, 19);
            this.TxtEmpCode.TabIndex = 0;
            this.TxtEmpCode.Load += new System.EventHandler(this.TxtEmpCode_Load);
            this.TxtEmpCode.Leave += new System.EventHandler(this.TxtEmpCode_Leave);
            this.TxtEmpCode.Enter += new System.EventHandler(this.TxtEmpCode_Enter);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(480, 18);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(191, 19);
            this.TxtPhone.TabIndex = 12;
            this.TxtPhone.Leave += new System.EventHandler(this.TxtPhone_Leave);
            this.TxtPhone.Enter += new System.EventHandler(this.TxtPhone_Enter);
            // 
            // TxtPassportNo
            // 
            this.TxtPassportNo.Location = new System.Drawing.Point(480, 43);
            this.TxtPassportNo.Name = "TxtPassportNo";
            this.TxtPassportNo.Size = new System.Drawing.Size(191, 21);
            this.TxtPassportNo.TabIndex = 13;
            this.TxtPassportNo.Leave += new System.EventHandler(this.TxtPassportNo_Leave);
            this.TxtPassportNo.Enter += new System.EventHandler(this.TxtPassportNo_Enter);
            // 
            // TxtVisaNo
            // 
            this.TxtVisaNo.Location = new System.Drawing.Point(480, 70);
            this.TxtVisaNo.Name = "TxtVisaNo";
            this.TxtVisaNo.Size = new System.Drawing.Size(191, 19);
            this.TxtVisaNo.TabIndex = 14;
            this.TxtVisaNo.Leave += new System.EventHandler(this.TxtVisaNo_Leave);
            this.TxtVisaNo.Enter += new System.EventHandler(this.TxtVisaNo_Enter);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(104, 211);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(228, 19);
            this.TxtEmail.TabIndex = 7;
            this.TxtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            this.TxtEmail.Enter += new System.EventHandler(this.TxtEmail_Enter);
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(104, 150);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(228, 55);
            this.TxtAddress.TabIndex = 6;
            this.TxtAddress.Leave += new System.EventHandler(this.TxtAddress_Leave);
            this.TxtAddress.Enter += new System.EventHandler(this.TxtAddress_Enter);
            // 
            // TxtMobile
            // 
            this.TxtMobile.Location = new System.Drawing.Point(103, 122);
            this.TxtMobile.Name = "TxtMobile";
            this.TxtMobile.Size = new System.Drawing.Size(229, 19);
            this.TxtMobile.TabIndex = 5;
            this.TxtMobile.Leave += new System.EventHandler(this.TxtMobile_Leave);
            this.TxtMobile.Enter += new System.EventHandler(this.TxtMobile_Enter);
            // 
            // Txtdepartment
            // 
            this.Txtdepartment.Location = new System.Drawing.Point(103, 92);
            this.Txtdepartment.Name = "Txtdepartment";
            this.Txtdepartment.Size = new System.Drawing.Size(229, 21);
            this.Txtdepartment.TabIndex = 4;
            this.Txtdepartment.TextChanged += new WindowsFormsApplication2.Uscnormaltextbox.DelTextChanged(this.Txtdepartment_TextChanged);
            this.Txtdepartment.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Txtdepartment_PreviewKeyDown);
            this.Txtdepartment.Leave += new System.EventHandler(this.Txtdepartment_Leave);
            this.Txtdepartment.Enter += new System.EventHandler(this.Txtdepartment_Enter);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(104, 43);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(228, 21);
            this.TxtName.TabIndex = 1;
            this.TxtName.Leave += new System.EventHandler(this.TxtName_Leave);
            this.TxtName.Enter += new System.EventHandler(this.TxtName_Enter);
            // 
            // Frmemployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(683, 395);
            this.Controls.Add(this.compaymode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Griddepartment);
            this.Controls.Add(this.TxtCommision);
            this.Controls.Add(this.TxtSalary);
            this.Controls.Add(this.TxtEmpCode);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtPassportNo);
            this.Controls.Add(this.TxtVisaNo);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtMobile);
            this.Controls.Add(this.Txtdepartment);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.pnlcentre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChkActiveEmployee);
            this.Controls.Add(this.RadFemale);
            this.Controls.Add(this.RadMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtDateofJoining);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtEmployeeId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frmemployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Master";
            this.Load += new System.EventHandler(this.Frmemployees_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frmemployees_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmemployees_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Griddepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox TxtEmployeeId;
        public System.Windows.Forms.DateTimePicker DtDateofJoining;
        public System.Windows.Forms.RadioButton RadMale;
        public System.Windows.Forms.RadioButton RadFemale;
        public System.Windows.Forms.CheckBox ChkActiveEmployee;
        private System.Windows.Forms.DataGridView Griddepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel pnlcentre;
        private Uscnormaltextbox TxtName;
        private Uscnormaltextbox Txtdepartment;
        private Uscnormaltextbox TxtMobile;
        private Uscnormaltextbox TxtAddress;
        private Uscnormaltextbox TxtEmail;
        private Uscnormaltextbox TxtVisaNo;
        private Uscnormaltextbox TxtPassportNo;
        private Uscnormaltextbox TxtPhone;
        private Uscnormaltextbox TxtEmpCode;
        private Uscnuemerictextbox TxtSalary;
        private Uscnuemerictextbox TxtCommision;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox compaymode;
    }
}