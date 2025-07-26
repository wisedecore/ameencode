namespace WindowsFormsApplication2
{
    partial class frmzatsearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdclear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpmasters = new System.Windows.Forms.GroupBox();
            this.grppatry = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grpitems = new System.Windows.Forms.GroupBox();
            this.Itemcode = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.commasters = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.commode = new System.Windows.Forms.ComboBox();
            this.cmdsearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grptransaction = new System.Windows.Forms.GroupBox();
            this.comvtype = new System.Windows.Forms.ComboBox();
            this.lblvtype = new System.Windows.Forms.Label();
            this.txtvno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.Dtfrom = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Dtto = new System.Windows.Forms.DateTimePicker();
            this.GridMain = new System.Windows.Forms.DataGridView();
            this.txtitemname = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtmobile = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtphoneno = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtaddress = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtemail = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtmrp = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtcategory = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtitemcode = new WindowsFormsApplication2.Uscnormaltextbox();
            this.txtprate = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.txtsrate = new WindowsFormsApplication2.Uscnuemerictextbox();
            this.uscGridshow1 = new WindowsFormsApplication2.UscGridshow();
            this.txtvnofrom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtvnoto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtnaration = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpmasters.SuspendLayout();
            this.grppatry.SuspendLayout();
            this.grpitems.SuspendLayout();
            this.grptransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.GridMain);
            this.panel1.Controls.Add(this.uscGridshow1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 647);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1412, 270);
            this.panel2.TabIndex = 161;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.cmdclear);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.grpmasters);
            this.panel3.Controls.Add(this.commode);
            this.panel3.Controls.Add(this.cmdsearch);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.grptransaction);
            this.panel3.Controls.Add(this.To);
            this.panel3.Controls.Add(this.Dtfrom);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.Dtto);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1236, 247);
            this.panel3.TabIndex = 172;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cmdclear
            // 
            this.cmdclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdclear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdclear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclear.ForeColor = System.Drawing.Color.Black;
            this.cmdclear.Location = new System.Drawing.Point(1158, 155);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(75, 34);
            this.cmdclear.TabIndex = 160;
            this.cmdclear.Text = "&Clear";
            this.cmdclear.UseVisualStyleBackColor = false;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1158, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 180;
            this.button3.Text = "&Refresh";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(37, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 173;
            this.label9.Text = "MODE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1158, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 174;
            this.button1.Text = "&Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // grpmasters
            // 
            this.grpmasters.Controls.Add(this.txtitemname);
            this.grpmasters.Controls.Add(this.grppatry);
            this.grpmasters.Controls.Add(this.grpitems);
            this.grpmasters.Controls.Add(this.label6);
            this.grpmasters.Controls.Add(this.commasters);
            this.grpmasters.Controls.Add(this.label4);
            this.grpmasters.Enabled = false;
            this.grpmasters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpmasters.ForeColor = System.Drawing.Color.White;
            this.grpmasters.Location = new System.Drawing.Point(385, 40);
            this.grpmasters.Name = "grpmasters";
            this.grpmasters.Size = new System.Drawing.Size(767, 155);
            this.grpmasters.TabIndex = 35;
            this.grpmasters.TabStop = false;
            this.grpmasters.Text = "Masters";
            // 
            // grppatry
            // 
            this.grppatry.Controls.Add(this.txtmobile);
            this.grppatry.Controls.Add(this.txtphoneno);
            this.grppatry.Controls.Add(this.txtaddress);
            this.grppatry.Controls.Add(this.txtemail);
            this.grppatry.Controls.Add(this.label15);
            this.grppatry.Controls.Add(this.label13);
            this.grppatry.Controls.Add(this.label7);
            this.grppatry.Controls.Add(this.label12);
            this.grppatry.ForeColor = System.Drawing.Color.White;
            this.grppatry.Location = new System.Drawing.Point(261, 42);
            this.grppatry.Name = "grppatry";
            this.grppatry.Size = new System.Drawing.Size(500, 107);
            this.grppatry.TabIndex = 171;
            this.grppatry.TabStop = false;
            this.grppatry.Text = "Party";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(8, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 168;
            this.label7.Text = "Mobile";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(256, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Phone ";
            // 
            // grpitems
            // 
            this.grpitems.Controls.Add(this.txtmrp);
            this.grpitems.Controls.Add(this.txtcategory);
            this.grpitems.Controls.Add(this.txtitemcode);
            this.grpitems.Controls.Add(this.Itemcode);
            this.grpitems.Controls.Add(this.label11);
            this.grpitems.Controls.Add(this.label10);
            this.grpitems.Controls.Add(this.label2);
            this.grpitems.Controls.Add(this.txtprate);
            this.grpitems.Controls.Add(this.txtsrate);
            this.grpitems.Controls.Add(this.label5);
            this.grpitems.Enabled = false;
            this.grpitems.ForeColor = System.Drawing.Color.White;
            this.grpitems.Location = new System.Drawing.Point(18, 40);
            this.grpitems.Name = "grpitems";
            this.grpitems.Size = new System.Drawing.Size(239, 109);
            this.grpitems.TabIndex = 170;
            this.grpitems.TabStop = false;
            this.grpitems.Text = "Items";
            // 
            // Itemcode
            // 
            this.Itemcode.AutoSize = true;
            this.Itemcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itemcode.Location = new System.Drawing.Point(7, 18);
            this.Itemcode.Name = "Itemcode";
            this.Itemcode.Size = new System.Drawing.Size(66, 16);
            this.Itemcode.TabIndex = 172;
            this.Itemcode.Text = "ItemCode";
            this.Itemcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 171;
            this.label11.Text = "Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(134, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 16);
            this.label10.TabIndex = 170;
            this.label10.Text = "Mrp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 164;
            this.label2.Text = "PRate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 163;
            this.label5.Text = "SRate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(305, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 165;
            this.label6.Text = "Name";
            // 
            // commasters
            // 
            this.commasters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.commasters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.commasters.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commasters.ForeColor = System.Drawing.Color.White;
            this.commasters.FormattingEnabled = true;
            this.commasters.Items.AddRange(new object[] {
            "Items",
            "Item Category",
            "Customer",
            "Supplier",
            "Employee",
            "Agent",
            "Ledger",
            "Ledger Group"});
            this.commasters.Location = new System.Drawing.Point(93, 12);
            this.commasters.Name = "commasters";
            this.commasters.Size = new System.Drawing.Size(206, 25);
            this.commasters.TabIndex = 5;
            this.commasters.TextChanged += new System.EventHandler(this.commasters_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(24, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 161;
            this.label4.Text = "Masters";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // commode
            // 
            this.commode.BackColor = System.Drawing.SystemColors.Highlight;
            this.commode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.commode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commode.ForeColor = System.Drawing.Color.Black;
            this.commode.FormattingEnabled = true;
            this.commode.Items.AddRange(new object[] {
            "Transactions",
            "Masters"});
            this.commode.Location = new System.Drawing.Point(101, 9);
            this.commode.Name = "commode";
            this.commode.Size = new System.Drawing.Size(278, 25);
            this.commode.TabIndex = 1;
            this.commode.SelectedIndexChanged += new System.EventHandler(this.commode_SelectedIndexChanged);
            this.commode.Enter += new System.EventHandler(this.commode_Enter);
            this.commode.TextChanged += new System.EventHandler(this.commode_TextChanged);
            this.commode.Click += new System.EventHandler(this.commode_Click);
            // 
            // cmdsearch
            // 
            this.cmdsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdsearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsearch.ForeColor = System.Drawing.Color.Black;
            this.cmdsearch.Location = new System.Drawing.Point(1158, 42);
            this.cmdsearch.Name = "cmdsearch";
            this.cmdsearch.Size = new System.Drawing.Size(75, 36);
            this.cmdsearch.TabIndex = 159;
            this.cmdsearch.Text = "&Search";
            this.cmdsearch.UseVisualStyleBackColor = false;
            this.cmdsearch.Click += new System.EventHandler(this.cmdsearch_Click);
            this.cmdsearch.Enter += new System.EventHandler(this.cmdsearch_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1158, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 179;
            this.button2.Text = "&New";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grptransaction
            // 
            this.grptransaction.Controls.Add(this.txtnaration);
            this.grptransaction.Controls.Add(this.label17);
            this.grptransaction.Controls.Add(this.txtvnoto);
            this.grptransaction.Controls.Add(this.label16);
            this.grptransaction.Controls.Add(this.txtvnofrom);
            this.grptransaction.Controls.Add(this.label14);
            this.grptransaction.Controls.Add(this.comvtype);
            this.grptransaction.Controls.Add(this.lblvtype);
            this.grptransaction.Controls.Add(this.txtvno);
            this.grptransaction.Controls.Add(this.label1);
            this.grptransaction.Controls.Add(this.txttename);
            this.grptransaction.Controls.Add(this.label3);
            this.grptransaction.Enabled = false;
            this.grptransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grptransaction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grptransaction.Location = new System.Drawing.Point(8, 40);
            this.grptransaction.Name = "grptransaction";
            this.grptransaction.Size = new System.Drawing.Size(371, 176);
            this.grptransaction.TabIndex = 169;
            this.grptransaction.TabStop = false;
            this.grptransaction.Text = "Transactions";
            this.grptransaction.Enter += new System.EventHandler(this.grptransaction_Enter);
            // 
            // comvtype
            // 
            this.comvtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(84)))), ((int)(((byte)(70)))));
            this.comvtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comvtype.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comvtype.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comvtype.ForeColor = System.Drawing.Color.White;
            this.comvtype.FormattingEnabled = true;
            this.comvtype.Items.AddRange(new object[] {
            "Sales",
            "SalesReturn",
            "SalesOrder",
            "Purchase",
            "PurchaseReturn",
            "PurchaseOrder",
            "Receipt",
            "Payment",
            "Journal Receipt",
            "Journal Payment",
            "DebitNote",
            "CreditNote"});
            this.comvtype.Location = new System.Drawing.Point(115, 29);
            this.comvtype.Name = "comvtype";
            this.comvtype.Size = new System.Drawing.Size(249, 25);
            this.comvtype.TabIndex = 2;
            this.comvtype.SelectedIndexChanged += new System.EventHandler(this.comvtype_SelectedIndexChanged);
            // 
            // lblvtype
            // 
            this.lblvtype.AutoSize = true;
            this.lblvtype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblvtype.ForeColor = System.Drawing.Color.White;
            this.lblvtype.Location = new System.Drawing.Point(36, 29);
            this.lblvtype.Name = "lblvtype";
            this.lblvtype.Size = new System.Drawing.Size(45, 19);
            this.lblvtype.TabIndex = 31;
            this.lblvtype.Text = "Vtype";
            // 
            // txtvno
            // 
            this.txtvno.Location = new System.Drawing.Point(115, 60);
            this.txtvno.Name = "txtvno";
            this.txtvno.Size = new System.Drawing.Size(82, 21);
            this.txtvno.TabIndex = 3;
            this.txtvno.TextChanged += new System.EventHandler(this.txtvno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Vno =";
            // 
            // txttename
            // 
            this.txttename.Location = new System.Drawing.Point(115, 115);
            this.txttename.Name = "txttename";
            this.txttename.Size = new System.Drawing.Size(249, 21);
            this.txttename.TabIndex = 4;
            this.txttename.TextChanged += new System.EventHandler(this.txttename_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Party";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.ForeColor = System.Drawing.Color.White;
            this.To.Location = new System.Drawing.Point(742, 15);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(23, 17);
            this.To.TabIndex = 178;
            this.To.Tag = "";
            this.To.Text = "To";
            this.To.Click += new System.EventHandler(this.To_Click);
            // 
            // Dtfrom
            // 
            this.Dtfrom.Location = new System.Drawing.Point(618, 14);
            this.Dtfrom.Name = "Dtfrom";
            this.Dtfrom.Size = new System.Drawing.Size(108, 20);
            this.Dtfrom.TabIndex = 175;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(551, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 177;
            this.label8.Text = "From";
            // 
            // Dtto
            // 
            this.Dtto.Location = new System.Drawing.Point(785, 14);
            this.Dtto.Name = "Dtto";
            this.Dtto.Size = new System.Drawing.Size(110, 20);
            this.Dtto.TabIndex = 176;
            // 
            // GridMain
            // 
            this.GridMain.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GridMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.GridMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.GridMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridMain.ColumnHeadersHeight = 31;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridMain.EnableHeadersVisualStyles = false;
            this.GridMain.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.GridMain.Location = new System.Drawing.Point(3, 226);
            this.GridMain.MultiSelect = false;
            this.GridMain.Name = "GridMain";
            this.GridMain.ReadOnly = true;
            this.GridMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridMain.RowHeadersVisible = false;
            this.GridMain.RowHeadersWidth = 100;
            this.GridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridMain.Size = new System.Drawing.Size(1300, 421);
            this.GridMain.TabIndex = 5;
            this.GridMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMain_CellDoubleClick_1);
            this.GridMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMain_CellContentClick_2);
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(350, 16);
            this.txtitemname.Margin = new System.Windows.Forms.Padding(4);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(242, 20);
            this.txtitemname.TabIndex = 6;
            this.txtitemname.TextChanged += new WindowsFormsApplication2.Uscnormaltextbox.DelTextChanged(this.txtitemname_TextChanged_1);
            // 
            // txtmobile
            // 
            this.txtmobile.Location = new System.Drawing.Point(66, 15);
            this.txtmobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(183, 20);
            this.txtmobile.TabIndex = 12;
            this.txtmobile.TextChanged += new WindowsFormsApplication2.Uscnormaltextbox.DelTextChanged(this.txtmobile_TextChanged_1);
            // 
            // txtphoneno
            // 
            this.txtphoneno.Location = new System.Drawing.Point(301, 15);
            this.txtphoneno.Margin = new System.Windows.Forms.Padding(4);
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(192, 23);
            this.txtphoneno.TabIndex = 15;
            this.txtphoneno.TextChanged += new WindowsFormsApplication2.Uscnuemerictextbox.DelTextChanged(this.txtphoneno_TextChanged);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(66, 66);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(329, 21);
            this.txtaddress.TabIndex = 14;
            this.txtaddress.Load += new System.EventHandler(this.uscnormaltextbox4_Load);
            this.txtaddress.TextChanged += new WindowsFormsApplication2.Uscnormaltextbox.DelTextChanged(this.txtaddress_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(66, 41);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(329, 20);
            this.txtemail.TabIndex = 13;
            this.txtemail.TextChanged += new WindowsFormsApplication2.Uscnormaltextbox.DelTextChanged(this.txtemail_TextChanged);
            // 
            // txtmrp
            // 
            this.txtmrp.Location = new System.Drawing.Point(165, 60);
            this.txtmrp.Margin = new System.Windows.Forms.Padding(4);
            this.txtmrp.Name = "txtmrp";
            this.txtmrp.Size = new System.Drawing.Size(68, 22);
            this.txtmrp.TabIndex = 10;
            this.txtmrp.TextChanged += new WindowsFormsApplication2.Uscnuemerictextbox.DelTextChanged(this.txtmrp_TextChanged);
            // 
            // txtcategory
            // 
            this.txtcategory.Location = new System.Drawing.Point(72, 35);
            this.txtcategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(161, 23);
            this.txtcategory.TabIndex = 8;
            this.txtcategory.TextChanged += new WindowsFormsApplication2.Uscnormaltextbox.DelTextChanged(this.txtcategory_TextChanged);
            // 
            // txtitemcode
            // 
            this.txtitemcode.Location = new System.Drawing.Point(72, 11);
            this.txtitemcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.Size = new System.Drawing.Size(161, 23);
            this.txtitemcode.TabIndex = 7;
            this.txtitemcode.TextChanged += new WindowsFormsApplication2.Uscnormaltextbox.DelTextChanged(this.txtitemcode_TextChanged);
            // 
            // txtprate
            // 
            this.txtprate.Location = new System.Drawing.Point(72, 59);
            this.txtprate.Margin = new System.Windows.Forms.Padding(4);
            this.txtprate.Name = "txtprate";
            this.txtprate.Size = new System.Drawing.Size(57, 22);
            this.txtprate.TabIndex = 9;
            this.txtprate.Load += new System.EventHandler(this.txtprate_Load);
            this.txtprate.TextChanged += new WindowsFormsApplication2.Uscnuemerictextbox.DelTextChanged(this.txtprate_TextChanged);
            // 
            // txtsrate
            // 
            this.txtsrate.Location = new System.Drawing.Point(72, 83);
            this.txtsrate.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.txtsrate.Name = "txtsrate";
            this.txtsrate.Size = new System.Drawing.Size(57, 21);
            this.txtsrate.TabIndex = 11;
            this.txtsrate.TextChanged += new WindowsFormsApplication2.Uscnuemerictextbox.DelTextChanged(this.txtsrate_TextChanged);
            this.txtsrate.Enter += new System.EventHandler(this.txtsrate_Enter);
            // 
            // uscGridshow1
            // 
            this.uscGridshow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.uscGridshow1.Location = new System.Drawing.Point(204, 257);
            this.uscGridshow1.Name = "uscGridshow1";
            this.uscGridshow1.Size = new System.Drawing.Size(792, 216);
            this.uscGridshow1.TabIndex = 4;
            this.uscGridshow1.Visible = false;
            // 
            // txtvnofrom
            // 
            this.txtvnofrom.Location = new System.Drawing.Point(115, 88);
            this.txtvnofrom.Name = "txtvnofrom";
            this.txtvnofrom.Size = new System.Drawing.Size(82, 21);
            this.txtvnofrom.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(36, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 19);
            this.label14.TabIndex = 35;
            this.label14.Text = "Vno (from)";
            // 
            // txtvnoto
            // 
            this.txtvnoto.Location = new System.Drawing.Point(282, 86);
            this.txtvnoto.Name = "txtvnoto";
            this.txtvnoto.Size = new System.Drawing.Size(82, 21);
            this.txtvnoto.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(215, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 19);
            this.label16.TabIndex = 37;
            this.label16.Text = "Vno (To)";
            // 
            // txtnaration
            // 
            this.txtnaration.Location = new System.Drawing.Point(115, 142);
            this.txtnaration.Name = "txtnaration";
            this.txtnaration.Size = new System.Drawing.Size(249, 21);
            this.txtnaration.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(36, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 19);
            this.label17.TabIndex = 39;
            this.label17.Text = "Naration";
            // 
            // frmzatsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 647);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmzatsearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qplex search";
            this.Load += new System.EventHandler(this.frmzatsearch_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmzatsearch_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpmasters.ResumeLayout(false);
            this.grpmasters.PerformLayout();
            this.grppatry.ResumeLayout(false);
            this.grppatry.PerformLayout();
            this.grpitems.ResumeLayout(false);
            this.grpitems.PerformLayout();
            this.grptransaction.ResumeLayout(false);
            this.grptransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WindowsFormsApplication2.UscGridshow uscGridshow1;
        public System.Windows.Forms.DataGridView GridMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpmasters;
        private Uscnormaltextbox txtitemname;
        private System.Windows.Forms.GroupBox grppatry;
        private Uscnormaltextbox txtmobile;
        private Uscnuemerictextbox txtphoneno;
        private Uscnormaltextbox txtaddress;
        private Uscnormaltextbox txtemail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpitems;
        private Uscnuemerictextbox txtmrp;
        private Uscnormaltextbox txtcategory;
        private Uscnormaltextbox txtitemcode;
        private System.Windows.Forms.Label Itemcode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private Uscnuemerictextbox txtprate;
        private Uscnuemerictextbox txtsrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox commasters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox commode;
        private System.Windows.Forms.GroupBox grptransaction;
        private System.Windows.Forms.ComboBox comvtype;
        private System.Windows.Forms.Label lblvtype;
        private System.Windows.Forms.TextBox txtvno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.DateTimePicker Dtfrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Dtto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdsearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtvnoto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtvnofrom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtnaration;
        private System.Windows.Forms.Label label17;
    }
}