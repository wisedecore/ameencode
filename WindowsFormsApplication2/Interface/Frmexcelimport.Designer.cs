namespace WindowsFormsApplication2
{
    partial class Frmexcelimport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmexcelimport));
            this.Cmdopenexcel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.transferchk = new System.Windows.Forms.CheckBox();
            this.btnimportserver = new System.Windows.Forms.Button();
            this.combfromdb = new System.Windows.Forms.ComboBox();
            this.comtocompany = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CmdupdateCode = new System.Windows.Forms.Button();
            this.pnlphysicalstock = new System.Windows.Forms.Panel();
            this.chkerasestock = new System.Windows.Forms.CheckBox();
            this.cmdsetphysicalstock = new System.Windows.Forms.Button();
            this.comfield = new System.Windows.Forms.ComboBox();
            this.cmdupdatefield = new System.Windows.Forms.Button();
            this.cmdprate = new System.Windows.Forms.Button();
            this.cmdupdaterate = new System.Windows.Forms.Button();
            this.cmdinsertsuppllier = new System.Windows.Forms.Button();
            this.cmduopbarccode = new System.Windows.Forms.Button();
            this.chkbatchcodeupdate = new System.Windows.Forms.CheckBox();
            this.cmdupdatebarcode = new System.Windows.Forms.Button();
            this.cmdproductupdating = new System.Windows.Forms.Button();
            this.cmdclose = new System.Windows.Forms.Button();
            this.chkincludebatch = new System.Windows.Forms.CheckBox();
            this.pnlleft = new System.Windows.Forms.Panel();
            this.pnlright = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.pnltop = new System.Windows.Forms.Panel();
            this.cmdinsertledger = new System.Windows.Forms.Button();
            this.cmdinsertopstock = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.Cmdinsertproduct = new System.Windows.Forms.Button();
            this.Gridmain = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlphysicalstock.SuspendLayout();
            this.pnlright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridmain)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cmdopenexcel
            // 
            this.Cmdopenexcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmdopenexcel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmdopenexcel.Location = new System.Drawing.Point(23, 12);
            this.Cmdopenexcel.Name = "Cmdopenexcel";
            this.Cmdopenexcel.Size = new System.Drawing.Size(107, 32);
            this.Cmdopenexcel.TabIndex = 0;
            this.Cmdopenexcel.Text = "Open Excel";
            this.Cmdopenexcel.UseVisualStyleBackColor = true;
            this.Cmdopenexcel.Click += new System.EventHandler(this.Cmdopenexcel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(14, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 185);
            this.panel1.TabIndex = 17;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Excel Sheet";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(28, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 32);
            this.button3.TabIndex = 1;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 23);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(135, 121);
            this.treeView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.transferchk);
            this.panel2.Controls.Add(this.btnimportserver);
            this.panel2.Controls.Add(this.combfromdb);
            this.panel2.Controls.Add(this.comtocompany);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.CmdupdateCode);
            this.panel2.Controls.Add(this.pnlphysicalstock);
            this.panel2.Controls.Add(this.comfield);
            this.panel2.Controls.Add(this.cmdupdatefield);
            this.panel2.Controls.Add(this.cmdprate);
            this.panel2.Controls.Add(this.cmdupdaterate);
            this.panel2.Controls.Add(this.cmdinsertsuppllier);
            this.panel2.Controls.Add(this.cmduopbarccode);
            this.panel2.Controls.Add(this.chkbatchcodeupdate);
            this.panel2.Controls.Add(this.cmdupdatebarcode);
            this.panel2.Controls.Add(this.cmdproductupdating);
            this.panel2.Controls.Add(this.cmdclose);
            this.panel2.Controls.Add(this.chkincludebatch);
            this.panel2.Controls.Add(this.pnlleft);
            this.panel2.Controls.Add(this.pnlright);
            this.panel2.Controls.Add(this.pnlbottom);
            this.panel2.Controls.Add(this.pnltop);
            this.panel2.Controls.Add(this.cmdinsertledger);
            this.panel2.Controls.Add(this.cmdinsertopstock);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtFileName);
            this.panel2.Controls.Add(this.Cmdinsertproduct);
            this.panel2.Controls.Add(this.Cmdopenexcel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 247);
            this.panel2.TabIndex = 18;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Honeydew;
            this.button6.Enabled = false;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(847, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 32);
            this.button6.TabIndex = 46;
            this.button6.Text = "Transfer -->Server";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // transferchk
            // 
            this.transferchk.AutoSize = true;
            this.transferchk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferchk.Location = new System.Drawing.Point(808, 19);
            this.transferchk.Name = "transferchk";
            this.transferchk.Size = new System.Drawing.Size(43, 21);
            this.transferchk.TabIndex = 48;
            this.transferchk.Text = "on";
            this.transferchk.UseVisualStyleBackColor = true;
            this.transferchk.CheckedChanged += new System.EventHandler(this.transferchk_CheckedChanged);
            // 
            // btnimportserver
            // 
            this.btnimportserver.BackColor = System.Drawing.Color.GhostWhite;
            this.btnimportserver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnimportserver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimportserver.Location = new System.Drawing.Point(825, 78);
            this.btnimportserver.Name = "btnimportserver";
            this.btnimportserver.Size = new System.Drawing.Size(149, 32);
            this.btnimportserver.TabIndex = 47;
            this.btnimportserver.Text = "Import from Server";
            this.btnimportserver.UseVisualStyleBackColor = false;
            this.btnimportserver.Click += new System.EventHandler(this.btnimportserver_Click);
            // 
            // combfromdb
            // 
            this.combfromdb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.combfromdb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combfromdb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combfromdb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combfromdb.ForeColor = System.Drawing.Color.Black;
            this.combfromdb.FormattingEnabled = true;
            this.combfromdb.Location = new System.Drawing.Point(220, 169);
            this.combfromdb.Name = "combfromdb";
            this.combfromdb.Size = new System.Drawing.Size(190, 25);
            this.combfromdb.TabIndex = 45;
            // 
            // comtocompany
            // 
            this.comtocompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.comtocompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comtocompany.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comtocompany.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comtocompany.ForeColor = System.Drawing.Color.Black;
            this.comtocompany.FormattingEnabled = true;
            this.comtocompany.Location = new System.Drawing.Point(290, 200);
            this.comtocompany.Name = "comtocompany";
            this.comtocompany.Size = new System.Drawing.Size(190, 25);
            this.comtocompany.TabIndex = 44;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(486, 200);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 32);
            this.button5.TabIndex = 43;
            this.button5.Text = "vnosaleconvert";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(416, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 32);
            this.button4.TabIndex = 42;
            this.button4.Text = "Insert opening balance";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(416, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 32);
            this.button2.TabIndex = 41;
            this.button2.Text = "Import From Notepad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CmdupdateCode
            // 
            this.CmdupdateCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdupdateCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdupdateCode.Location = new System.Drawing.Point(290, 128);
            this.CmdupdateCode.Name = "CmdupdateCode";
            this.CmdupdateCode.Size = new System.Drawing.Size(120, 32);
            this.CmdupdateCode.TabIndex = 40;
            this.CmdupdateCode.Text = "Update Itemcode";
            this.CmdupdateCode.UseVisualStyleBackColor = true;
            this.CmdupdateCode.Click += new System.EventHandler(this.CmdupdateCode_Click);
            // 
            // pnlphysicalstock
            // 
            this.pnlphysicalstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlphysicalstock.Controls.Add(this.chkerasestock);
            this.pnlphysicalstock.Controls.Add(this.cmdsetphysicalstock);
            this.pnlphysicalstock.Location = new System.Drawing.Point(660, 128);
            this.pnlphysicalstock.Name = "pnlphysicalstock";
            this.pnlphysicalstock.Size = new System.Drawing.Size(127, 100);
            this.pnlphysicalstock.TabIndex = 39;
            // 
            // chkerasestock
            // 
            this.chkerasestock.AutoSize = true;
            this.chkerasestock.Location = new System.Drawing.Point(10, 55);
            this.chkerasestock.Name = "chkerasestock";
            this.chkerasestock.Size = new System.Drawing.Size(82, 17);
            this.chkerasestock.TabIndex = 39;
            this.chkerasestock.Text = "Erase stock";
            this.chkerasestock.UseVisualStyleBackColor = true;
            // 
            // cmdsetphysicalstock
            // 
            this.cmdsetphysicalstock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdsetphysicalstock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsetphysicalstock.Location = new System.Drawing.Point(10, 17);
            this.cmdsetphysicalstock.Name = "cmdsetphysicalstock";
            this.cmdsetphysicalstock.Size = new System.Drawing.Size(107, 32);
            this.cmdsetphysicalstock.TabIndex = 38;
            this.cmdsetphysicalstock.Text = "Physical stock";
            this.cmdsetphysicalstock.UseVisualStyleBackColor = true;
            this.cmdsetphysicalstock.Click += new System.EventHandler(this.cmdsetphysicalstock_Click);
            // 
            // comfield
            // 
            this.comfield.FormattingEnabled = true;
            this.comfield.Items.AddRange(new object[] {
            "itemcode",
            "itemname",
            "Mrp",
            "Srate",
            "Prate",
            "Cooly",
            "minstock",
            "reorder",
            "maximum",
            "Unit",
            "Vat",
            "cst",
            "purtax",
            "llang"});
            this.comfield.Location = new System.Drawing.Point(553, 96);
            this.comfield.Name = "comfield";
            this.comfield.Size = new System.Drawing.Size(121, 21);
            this.comfield.TabIndex = 37;
            // 
            // cmdupdatefield
            // 
            this.cmdupdatefield.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdupdatefield.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdupdatefield.Location = new System.Drawing.Point(680, 90);
            this.cmdupdatefield.Name = "cmdupdatefield";
            this.cmdupdatefield.Size = new System.Drawing.Size(107, 32);
            this.cmdupdatefield.TabIndex = 36;
            this.cmdupdatefield.Text = "Update field";
            this.cmdupdatefield.UseVisualStyleBackColor = true;
            this.cmdupdatefield.Click += new System.EventHandler(this.cmdupdatefield_Click);
            // 
            // cmdprate
            // 
            this.cmdprate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdprate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdprate.Location = new System.Drawing.Point(416, 90);
            this.cmdprate.Name = "cmdprate";
            this.cmdprate.Size = new System.Drawing.Size(120, 32);
            this.cmdprate.TabIndex = 35;
            this.cmdprate.Text = "Update PRate";
            this.cmdprate.UseVisualStyleBackColor = true;
            this.cmdprate.Click += new System.EventHandler(this.cmdprate_Click);
            // 
            // cmdupdaterate
            // 
            this.cmdupdaterate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdupdaterate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdupdaterate.Location = new System.Drawing.Point(290, 88);
            this.cmdupdaterate.Name = "cmdupdaterate";
            this.cmdupdaterate.Size = new System.Drawing.Size(120, 32);
            this.cmdupdaterate.TabIndex = 34;
            this.cmdupdaterate.Text = "Update SRate";
            this.cmdupdaterate.UseVisualStyleBackColor = true;
            this.cmdupdaterate.Click += new System.EventHandler(this.cmdupdaterate_Click);
            // 
            // cmdinsertsuppllier
            // 
            this.cmdinsertsuppllier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdinsertsuppllier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdinsertsuppllier.Location = new System.Drawing.Point(416, 50);
            this.cmdinsertsuppllier.Name = "cmdinsertsuppllier";
            this.cmdinsertsuppllier.Size = new System.Drawing.Size(110, 32);
            this.cmdinsertsuppllier.TabIndex = 33;
            this.cmdinsertsuppllier.Text = "Insert Supplierr";
            this.cmdinsertsuppllier.UseVisualStyleBackColor = true;
            this.cmdinsertsuppllier.Click += new System.EventHandler(this.cmdinsertsuppllier_Click);
            // 
            // cmduopbarccode
            // 
            this.cmduopbarccode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmduopbarccode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmduopbarccode.Location = new System.Drawing.Point(528, 48);
            this.cmduopbarccode.Name = "cmduopbarccode";
            this.cmduopbarccode.Size = new System.Drawing.Size(219, 32);
            this.cmduopbarccode.TabIndex = 32;
            this.cmduopbarccode.Text = "Update  O.P Barcode";
            this.cmduopbarccode.UseVisualStyleBackColor = true;
            this.cmduopbarccode.Click += new System.EventHandler(this.cmduopbarccode_Click);
            // 
            // chkbatchcodeupdate
            // 
            this.chkbatchcodeupdate.AutoSize = true;
            this.chkbatchcodeupdate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkbatchcodeupdate.Location = new System.Drawing.Point(179, 68);
            this.chkbatchcodeupdate.Name = "chkbatchcodeupdate";
            this.chkbatchcodeupdate.Size = new System.Drawing.Size(80, 21);
            this.chkbatchcodeupdate.TabIndex = 31;
            this.chkbatchcodeupdate.Text = "B.Update";
            this.chkbatchcodeupdate.UseVisualStyleBackColor = true;
            // 
            // cmdupdatebarcode
            // 
            this.cmdupdatebarcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdupdatebarcode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdupdatebarcode.Location = new System.Drawing.Point(290, 50);
            this.cmdupdatebarcode.Name = "cmdupdatebarcode";
            this.cmdupdatebarcode.Size = new System.Drawing.Size(120, 32);
            this.cmdupdatebarcode.TabIndex = 30;
            this.cmdupdatebarcode.Text = "Update Barcode";
            this.cmdupdatebarcode.UseVisualStyleBackColor = true;
            this.cmdupdatebarcode.Click += new System.EventHandler(this.cmdupdatebarcode_Click);
            // 
            // cmdproductupdating
            // 
            this.cmdproductupdating.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdproductupdating.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdproductupdating.Location = new System.Drawing.Point(641, 12);
            this.cmdproductupdating.Name = "cmdproductupdating";
            this.cmdproductupdating.Size = new System.Drawing.Size(146, 32);
            this.cmdproductupdating.TabIndex = 29;
            this.cmdproductupdating.Text = "Update Product";
            this.cmdproductupdating.UseVisualStyleBackColor = true;
            this.cmdproductupdating.Click += new System.EventHandler(this.cmdproductupdating_Click);
            // 
            // cmdclose
            // 
            this.cmdclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.Location = new System.Drawing.Point(997, 3);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(82, 241);
            this.cmdclose.TabIndex = 28;
            this.cmdclose.Text = "Close";
            this.cmdclose.UseVisualStyleBackColor = true;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // chkincludebatch
            // 
            this.chkincludebatch.AutoSize = true;
            this.chkincludebatch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkincludebatch.Location = new System.Drawing.Point(179, 50);
            this.chkincludebatch.Name = "chkincludebatch";
            this.chkincludebatch.Size = new System.Drawing.Size(103, 21);
            this.chkincludebatch.TabIndex = 27;
            this.chkincludebatch.Text = "Include Batch";
            this.chkincludebatch.UseVisualStyleBackColor = true;
            // 
            // pnlleft
            // 
            this.pnlleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.Location = new System.Drawing.Point(0, 3);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(3, 241);
            this.pnlleft.TabIndex = 26;
            // 
            // pnlright
            // 
            this.pnlright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlright.Controls.Add(this.panel6);
            this.pnlright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlright.Location = new System.Drawing.Point(1079, 3);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(3, 241);
            this.pnlright.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(142)))));
            this.panel6.Location = new System.Drawing.Point(-22, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 241);
            this.panel6.TabIndex = 26;
            // 
            // pnlbottom
            // 
            this.pnlbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbottom.Location = new System.Drawing.Point(0, 244);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(1082, 3);
            this.pnlbottom.TabIndex = 24;
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1082, 3);
            this.pnltop.TabIndex = 23;
            // 
            // cmdinsertledger
            // 
            this.cmdinsertledger.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdinsertledger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdinsertledger.Location = new System.Drawing.Point(414, 12);
            this.cmdinsertledger.Name = "cmdinsertledger";
            this.cmdinsertledger.Size = new System.Drawing.Size(110, 32);
            this.cmdinsertledger.TabIndex = 22;
            this.cmdinsertledger.Text = "Insert Ledger";
            this.cmdinsertledger.UseVisualStyleBackColor = true;
            this.cmdinsertledger.Click += new System.EventHandler(this.cmdinsertCustomer_Click);
            // 
            // cmdinsertopstock
            // 
            this.cmdinsertopstock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdinsertopstock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdinsertopstock.Location = new System.Drawing.Point(290, 12);
            this.cmdinsertopstock.Name = "cmdinsertopstock";
            this.cmdinsertopstock.Size = new System.Drawing.Size(120, 32);
            this.cmdinsertopstock.TabIndex = 21;
            this.cmdinsertopstock.Text = "Insert Opening Stock";
            this.cmdinsertopstock.UseVisualStyleBackColor = true;
            this.cmdinsertopstock.Click += new System.EventHandler(this.cmdinsertopstock_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(528, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Insert Product ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(179, 90);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 20);
            this.txtFileName.TabIndex = 19;
            this.txtFileName.Visible = false;
            // 
            // Cmdinsertproduct
            // 
            this.Cmdinsertproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmdinsertproduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmdinsertproduct.Location = new System.Drawing.Point(179, 12);
            this.Cmdinsertproduct.Name = "Cmdinsertproduct";
            this.Cmdinsertproduct.Size = new System.Drawing.Size(107, 32);
            this.Cmdinsertproduct.TabIndex = 18;
            this.Cmdinsertproduct.Text = "Insert Product";
            this.Cmdinsertproduct.UseVisualStyleBackColor = true;
            this.Cmdinsertproduct.Click += new System.EventHandler(this.Cmdinsertproduct_Click);
            // 
            // Gridmain
            // 
            this.Gridmain.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Gridmain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gridmain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Gridmain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Gridmain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gridmain.ColumnHeadersHeight = 25;
            this.Gridmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridmain.DefaultCellStyle = dataGridViewCellStyle2;
            this.Gridmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gridmain.Location = new System.Drawing.Point(0, 247);
            this.Gridmain.Name = "Gridmain";
            this.Gridmain.Size = new System.Drawing.Size(1082, 308);
            this.Gridmain.TabIndex = 21;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 247);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(3, 308);
            this.panel10.TabIndex = 27;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(62)))), ((int)(((byte)(142)))));
            this.panel9.Location = new System.Drawing.Point(-22, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 241);
            this.panel9.TabIndex = 26;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1079, 247);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(3, 308);
            this.panel8.TabIndex = 26;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(3, 552);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1076, 3);
            this.panel11.TabIndex = 28;
            // 
            // Frmexcelimport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 555);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.Gridmain);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Frmexcelimport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmexcelimport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmexcelimport_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlphysicalstock.ResumeLayout(false);
            this.pnlphysicalstock.PerformLayout();
            this.pnlright.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gridmain)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cmdopenexcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cmdinsertproduct;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdinsertopstock;
        private System.Windows.Forms.Button cmdinsertledger;
        private System.Windows.Forms.DataGridView Gridmain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.Panel pnlright;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.CheckBox chkincludebatch;
        private System.Windows.Forms.Button cmdproductupdating;
        private System.Windows.Forms.Button cmdupdatebarcode;
        private System.Windows.Forms.CheckBox chkbatchcodeupdate;
        private System.Windows.Forms.Button cmduopbarccode;
        private System.Windows.Forms.Button cmdinsertsuppllier;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button cmdupdaterate;
        private System.Windows.Forms.Button cmdprate;
        private System.Windows.Forms.ComboBox comfield;
        private System.Windows.Forms.Button cmdupdatefield;
        private System.Windows.Forms.Button cmdsetphysicalstock;
        private System.Windows.Forms.Panel pnlphysicalstock;
        private System.Windows.Forms.CheckBox chkerasestock;
        private System.Windows.Forms.Button CmdupdateCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comtocompany;
        private System.Windows.Forms.ComboBox combfromdb;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnimportserver;
        private System.Windows.Forms.CheckBox transferchk;
    }
}