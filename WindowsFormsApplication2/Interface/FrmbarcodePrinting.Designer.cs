namespace WindowsFormsApplication2
{
    partial class FrmbarcodePrinting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmbarcodePrinting));
            this.cmdprint = new System.Windows.Forms.Button();
            this.cmdupdate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtprate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsrate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmrp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.combatchcode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtitemcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gridmain = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.grpbarcodesettings = new System.Windows.Forms.GroupBox();
            this.cmdupdatebarcode = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtnewbarcode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmddeletebarcode = new System.Windows.Forms.Button();
            this.barCodeCtrl1 = new DSBarCode.BarCodeCtrl();
            this.Picrupee = new System.Windows.Forms.PictureBox();
            this.pnlprintsettings = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.PnlPrintOptions = new System.Windows.Forms.Panel();
            this.cmdadprint = new System.Windows.Forms.Button();
            this.comprint = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtexdate = new System.Windows.Forms.DateTimePicker();
            this.Cmdshow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtmanfactdate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.Chksearch = new System.Windows.Forms.CheckBox();
            this.uscGridshow1 = new WindowsFormsApplication2.UscGridshow();
            this.chkmanexdate = new System.Windows.Forms.CheckBox();
            this.pnlmanexdate = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).BeginInit();
            this.grpbarcodesettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picrupee)).BeginInit();
            this.pnlprintsettings.SuspendLayout();
            this.PnlPrintOptions.SuspendLayout();
            this.pnlmanexdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdprint
            // 
            this.cmdprint.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdprint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdprint.FlatAppearance.BorderSize = 0;
            this.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdprint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdprint.ForeColor = System.Drawing.Color.Black;
            this.cmdprint.Location = new System.Drawing.Point(192, 348);
            this.cmdprint.Name = "cmdprint";
            this.cmdprint.Size = new System.Drawing.Size(106, 41);
            this.cmdprint.TabIndex = 11;
            this.cmdprint.Text = "Print (طباعة)";
            this.cmdprint.UseVisualStyleBackColor = false;
            this.cmdprint.Click += new System.EventHandler(this.cmdprint_Click_1);
            // 
            // cmdupdate
            // 
            this.cmdupdate.BackColor = System.Drawing.Color.YellowGreen;
            this.cmdupdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdupdate.FlatAppearance.BorderSize = 0;
            this.cmdupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdupdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdupdate.ForeColor = System.Drawing.Color.Black;
            this.cmdupdate.Location = new System.Drawing.Point(75, 348);
            this.cmdupdate.Name = "cmdupdate";
            this.cmdupdate.Size = new System.Drawing.Size(107, 41);
            this.cmdupdate.TabIndex = 10;
            this.cmdupdate.Text = "Update(تحديث)";
            this.cmdupdate.UseVisualStyleBackColor = false;
            this.cmdupdate.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(190, 200);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "PRate";
            // 
            // txtprate
            // 
            this.txtprate.BackColor = System.Drawing.Color.White;
            this.txtprate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprate.Location = new System.Drawing.Point(297, 199);
            this.txtprate.Margin = new System.Windows.Forms.Padding(4);
            this.txtprate.Name = "txtprate";
            this.txtprate.Size = new System.Drawing.Size(85, 18);
            this.txtprate.TabIndex = 6;
            this.txtprate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(7, 193);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "SRate";
            // 
            // txtsrate
            // 
            this.txtsrate.BackColor = System.Drawing.Color.White;
            this.txtsrate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsrate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsrate.Location = new System.Drawing.Point(90, 199);
            this.txtsrate.Margin = new System.Windows.Forms.Padding(4);
            this.txtsrate.Name = "txtsrate";
            this.txtsrate.Size = new System.Drawing.Size(89, 18);
            this.txtsrate.TabIndex = 5;
            this.txtsrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(189, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "MRP";
            // 
            // txtmrp
            // 
            this.txtmrp.BackColor = System.Drawing.Color.White;
            this.txtmrp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmrp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmrp.Location = new System.Drawing.Point(297, 165);
            this.txtmrp.Margin = new System.Windows.Forms.Padding(4);
            this.txtmrp.Name = "txtmrp";
            this.txtmrp.Size = new System.Drawing.Size(85, 18);
            this.txtmrp.TabIndex = 4;
            this.txtmrp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Qty(كمية)";
            // 
            // txtqty
            // 
            this.txtqty.BackColor = System.Drawing.Color.White;
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtqty.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(90, 165);
            this.txtqty.Margin = new System.Windows.Forms.Padding(4);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(89, 18);
            this.txtqty.TabIndex = 3;
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            // 
            // combatchcode
            // 
            this.combatchcode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatchcode.FormattingEnabled = true;
            this.combatchcode.Location = new System.Drawing.Point(488, 285);
            this.combatchcode.Name = "combatchcode";
            this.combatchcode.Size = new System.Drawing.Size(243, 22);
            this.combatchcode.TabIndex = 29;
            this.combatchcode.Visible = false;
            this.combatchcode.SelectedIndexChanged += new System.EventHandler(this.combatchcode_SelectedIndexChanged);
            this.combatchcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combatchcode_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Barcode(الباركود)";
            // 
            // txtitemcode
            // 
            this.txtitemcode.BackColor = System.Drawing.Color.White;
            this.txtitemcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtitemcode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemcode.Location = new System.Drawing.Point(139, 56);
            this.txtitemcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.ReadOnly = true;
            this.txtitemcode.Size = new System.Drawing.Size(243, 18);
            this.txtitemcode.TabIndex = 0;
            this.txtitemcode.TextChanged += new System.EventHandler(this.txtitemcode_TextChanged);
            this.txtitemcode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtitemcode_PreviewKeyDown);
            this.txtitemcode.Enter += new System.EventHandler(this.txtitemcode_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Item Code(رمز الصنف)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtitemname
            // 
            this.txtitemname.BackColor = System.Drawing.Color.White;
            this.txtitemname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtitemname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemname.Location = new System.Drawing.Point(141, 86);
            this.txtitemname.Margin = new System.Windows.Forms.Padding(4);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.ReadOnly = true;
            this.txtitemname.Size = new System.Drawing.Size(241, 18);
            this.txtitemname.TabIndex = 1;
            this.txtitemname.TextChanged += new System.EventHandler(this.txtitemname_TextChanged);
            this.txtitemname.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtitemname_PreviewKeyDown_1);
            this.txtitemname.Enter += new System.EventHandler(this.txtitemname_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(2, 86);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Item Name(اسم العنصر)";
            // 
            // gridmain
            // 
            this.gridmain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridmain.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridmain.Location = new System.Drawing.Point(275, 12);
            this.gridmain.Name = "gridmain";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridmain.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridmain.Size = new System.Drawing.Size(33, 31);
            this.gridmain.TabIndex = 13;
            this.gridmain.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(304, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Close(أغلق)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpbarcodesettings
            // 
            this.grpbarcodesettings.Controls.Add(this.cmdupdatebarcode);
            this.grpbarcodesettings.Controls.Add(this.label15);
            this.grpbarcodesettings.Controls.Add(this.txtnewbarcode);
            this.grpbarcodesettings.Controls.Add(this.label16);
            this.grpbarcodesettings.Controls.Add(this.cmddeletebarcode);
            this.grpbarcodesettings.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grpbarcodesettings.Location = new System.Drawing.Point(402, 71);
            this.grpbarcodesettings.Name = "grpbarcodesettings";
            this.grpbarcodesettings.Size = new System.Drawing.Size(416, 135);
            this.grpbarcodesettings.TabIndex = 30;
            this.grpbarcodesettings.TabStop = false;
            this.grpbarcodesettings.Text = "Barcode Settings";
            // 
            // cmdupdatebarcode
            // 
            this.cmdupdatebarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdupdatebarcode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdupdatebarcode.FlatAppearance.BorderSize = 0;
            this.cmdupdatebarcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdupdatebarcode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdupdatebarcode.ForeColor = System.Drawing.Color.Black;
            this.cmdupdatebarcode.Location = new System.Drawing.Point(12, 89);
            this.cmdupdatebarcode.Name = "cmdupdatebarcode";
            this.cmdupdatebarcode.Size = new System.Drawing.Size(180, 28);
            this.cmdupdatebarcode.TabIndex = 0;
            this.cmdupdatebarcode.Text = "Udate Barcode";
            this.cmdupdatebarcode.UseVisualStyleBackColor = false;
            this.cmdupdatebarcode.Click += new System.EventHandler(this.cmdupdatebarcode_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(115, 59);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = ":";
            // 
            // txtnewbarcode
            // 
            this.txtnewbarcode.BackColor = System.Drawing.Color.White;
            this.txtnewbarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnewbarcode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtnewbarcode.Location = new System.Drawing.Point(134, 58);
            this.txtnewbarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtnewbarcode.Name = "txtnewbarcode";
            this.txtnewbarcode.Size = new System.Drawing.Size(211, 18);
            this.txtnewbarcode.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(3, 59);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Updated Barcode";
            // 
            // cmddeletebarcode
            // 
            this.cmddeletebarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmddeletebarcode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmddeletebarcode.FlatAppearance.BorderSize = 0;
            this.cmddeletebarcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmddeletebarcode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmddeletebarcode.ForeColor = System.Drawing.Color.Black;
            this.cmddeletebarcode.Location = new System.Drawing.Point(12, 18);
            this.cmddeletebarcode.Name = "cmddeletebarcode";
            this.cmddeletebarcode.Size = new System.Drawing.Size(427, 28);
            this.cmddeletebarcode.TabIndex = 2;
            this.cmddeletebarcode.Text = "Delete Selected Barcode";
            this.cmddeletebarcode.UseVisualStyleBackColor = false;
            this.cmddeletebarcode.Click += new System.EventHandler(this.cmddeletebarcode_Click);
            // 
            // barCodeCtrl1
            // 
            this.barCodeCtrl1.BarCode = "1234567890";
            this.barCodeCtrl1.BarCodeHeight = 50;
            this.barCodeCtrl1.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.barCodeCtrl1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.barCodeCtrl1.HeaderText = "BarCode Demo";
            this.barCodeCtrl1.LeftMargin = 10;
            this.barCodeCtrl1.Location = new System.Drawing.Point(392, 12);
            this.barCodeCtrl1.Name = "barCodeCtrl1";
            this.barCodeCtrl1.ShowFooter = false;
            this.barCodeCtrl1.ShowHeader = false;
            this.barCodeCtrl1.Size = new System.Drawing.Size(52, 23);
            this.barCodeCtrl1.TabIndex = 31;
            this.barCodeCtrl1.TopMargin = 0;
            this.barCodeCtrl1.VertAlign = DSBarCode.BarCodeCtrl.AlignType.Center;
            this.barCodeCtrl1.Visible = false;
            this.barCodeCtrl1.Weight = DSBarCode.BarCodeCtrl.BarCodeWeight.Small;
            // 
            // Picrupee
            // 
            this.Picrupee.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Rupee;
            this.Picrupee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Picrupee.Location = new System.Drawing.Point(350, 12);
            this.Picrupee.Name = "Picrupee";
            this.Picrupee.Size = new System.Drawing.Size(11, 11);
            this.Picrupee.TabIndex = 134;
            this.Picrupee.TabStop = false;
            this.Picrupee.Visible = false;
            // 
            // pnlprintsettings
            // 
            this.pnlprintsettings.Controls.Add(this.button2);
            this.pnlprintsettings.Controls.Add(this.PnlPrintOptions);
            this.pnlprintsettings.Location = new System.Drawing.Point(476, 45);
            this.pnlprintsettings.Name = "pnlprintsettings";
            this.pnlprintsettings.Size = new System.Drawing.Size(355, 222);
            this.pnlprintsettings.TabIndex = 32;
            this.pnlprintsettings.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(280, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close(أغلق)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PnlPrintOptions
            // 
            this.PnlPrintOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.PnlPrintOptions.Controls.Add(this.cmdadprint);
            this.PnlPrintOptions.ForeColor = System.Drawing.Color.Coral;
            this.PnlPrintOptions.Location = new System.Drawing.Point(50, 36);
            this.PnlPrintOptions.Name = "PnlPrintOptions";
            this.PnlPrintOptions.Size = new System.Drawing.Size(302, 149);
            this.PnlPrintOptions.TabIndex = 0;
            // 
            // cmdadprint
            // 
            this.cmdadprint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdadprint.ForeColor = System.Drawing.Color.Black;
            this.cmdadprint.Location = new System.Drawing.Point(90, 62);
            this.cmdadprint.Name = "cmdadprint";
            this.cmdadprint.Size = new System.Drawing.Size(80, 35);
            this.cmdadprint.TabIndex = 0;
            this.cmdadprint.Text = "Print (طباعة)";
            this.cmdadprint.UseVisualStyleBackColor = true;
            this.cmdadprint.Click += new System.EventHandler(this.cmdadprint_Click);
            // 
            // comprint
            // 
            this.comprint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprint.ForeColor = System.Drawing.Color.Blue;
            this.comprint.FormattingEnabled = true;
            this.comprint.Location = new System.Drawing.Point(202, 316);
            this.comprint.Name = "comprint";
            this.comprint.Size = new System.Drawing.Size(187, 20);
            this.comprint.TabIndex = 9;
            this.comprint.SelectedIndexChanged += new System.EventHandler(this.comprint_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(103, 319);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(83, 13);
            this.label26.TabIndex = 22;
            this.label26.Text = "Print Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Expiry Date";
            // 
            // Dtexdate
            // 
            this.Dtexdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtexdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtexdate.Location = new System.Drawing.Point(104, 29);
            this.Dtexdate.Name = "Dtexdate";
            this.Dtexdate.Size = new System.Drawing.Size(187, 20);
            this.Dtexdate.TabIndex = 7;
            this.Dtexdate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // Cmdshow
            // 
            this.Cmdshow.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmdshow.ForeColor = System.Drawing.Color.Black;
            this.Cmdshow.Location = new System.Drawing.Point(402, 216);
            this.Cmdshow.Name = "Cmdshow";
            this.Cmdshow.Size = new System.Drawing.Size(56, 23);
            this.Cmdshow.TabIndex = 28;
            this.Cmdshow.Text = "Show";
            this.Cmdshow.UseVisualStyleBackColor = true;
            this.Cmdshow.Click += new System.EventHandler(this.Cmdshow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "(معدل المبيعات)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(186, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "(أقصى سعر التجزئة)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(231, 204);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "(سعر الشراء)";
            // 
            // dtmanfactdate
            // 
            this.dtmanfactdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmanfactdate.Location = new System.Drawing.Point(106, 3);
            this.dtmanfactdate.Name = "dtmanfactdate";
            this.dtmanfactdate.Size = new System.Drawing.Size(187, 20);
            this.dtmanfactdate.TabIndex = 8;
            this.dtmanfactdate.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Manf. Date";
            // 
            // txtbarcode
            // 
            this.txtbarcode.BackColor = System.Drawing.Color.White;
            this.txtbarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.Location = new System.Drawing.Point(139, 123);
            this.txtbarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(241, 18);
            this.txtbarcode.TabIndex = 2;
            this.txtbarcode.TextChanged += new System.EventHandler(this.txtbarcode_TextChanged);
            this.txtbarcode.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbarcode_PreviewKeyDown);
            this.txtbarcode.Enter += new System.EventHandler(this.txtbarcode_Enter);
            // 
            // Chksearch
            // 
            this.Chksearch.AutoSize = true;
            this.Chksearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Chksearch.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chksearch.ForeColor = System.Drawing.Color.Black;
            this.Chksearch.Location = new System.Drawing.Point(12, 10);
            this.Chksearch.Name = "Chksearch";
            this.Chksearch.Size = new System.Drawing.Size(101, 17);
            this.Chksearch.TabIndex = 135;
            this.Chksearch.Text = "Search / ( F12 )";
            this.Chksearch.UseVisualStyleBackColor = false;
            this.Chksearch.CheckedChanged += new System.EventHandler(this.Chksearch_CheckedChanged);
            // 
            // uscGridshow1
            // 
            this.uscGridshow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(103)))), ((int)(((byte)(84)))));
            this.uscGridshow1.Location = new System.Drawing.Point(10, 379);
            this.uscGridshow1.Name = "uscGridshow1";
            this.uscGridshow1.Size = new System.Drawing.Size(792, 205);
            this.uscGridshow1.TabIndex = 23;
            this.uscGridshow1.Visible = false;
            this.uscGridshow1.Load += new System.EventHandler(this.uscGridshow1_Load);
            // 
            // chkmanexdate
            // 
            this.chkmanexdate.AutoSize = true;
            this.chkmanexdate.BackColor = System.Drawing.Color.Transparent;
            this.chkmanexdate.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkmanexdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chkmanexdate.Location = new System.Drawing.Point(10, 33);
            this.chkmanexdate.Name = "chkmanexdate";
            this.chkmanexdate.Size = new System.Drawing.Size(152, 16);
            this.chkmanexdate.TabIndex = 162;
            this.chkmanexdate.Text = "Manf & Ex date visible";
            this.chkmanexdate.UseVisualStyleBackColor = false;
            this.chkmanexdate.CheckedChanged += new System.EventHandler(this.chkmanexdate_CheckedChanged);
            // 
            // pnlmanexdate
            // 
            this.pnlmanexdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlmanexdate.Controls.Add(this.Dtexdate);
            this.pnlmanexdate.Controls.Add(this.label1);
            this.pnlmanexdate.Controls.Add(this.label9);
            this.pnlmanexdate.Controls.Add(this.dtmanfactdate);
            this.pnlmanexdate.Location = new System.Drawing.Point(90, 242);
            this.pnlmanexdate.Name = "pnlmanexdate";
            this.pnlmanexdate.Size = new System.Drawing.Size(306, 65);
            this.pnlmanexdate.TabIndex = 163;
            // 
            // FrmbarcodePrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(820, 596);
            this.Controls.Add(this.pnlmanexdate);
            this.Controls.Add(this.chkmanexdate);
            this.Controls.Add(this.Chksearch);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cmdshow);
            this.Controls.Add(this.comprint);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.pnlprintsettings);
            this.Controls.Add(this.uscGridshow1);
            this.Controls.Add(this.grpbarcodesettings);
            this.Controls.Add(this.gridmain);
            this.Controls.Add(this.cmdprint);
            this.Controls.Add(this.cmdupdate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtprate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtsrate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmrp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.combatchcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtitemcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtitemname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Picrupee);
            this.Controls.Add(this.barCodeCtrl1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmbarcodePrinting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Printing";
            this.Load += new System.EventHandler(this.FrmbarcodePrinting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmbarcodePrinting_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridmain)).EndInit();
            this.grpbarcodesettings.ResumeLayout(false);
            this.grpbarcodesettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picrupee)).EndInit();
            this.pnlprintsettings.ResumeLayout(false);
            this.PnlPrintOptions.ResumeLayout(false);
            this.pnlmanexdate.ResumeLayout(false);
            this.pnlmanexdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private DSBarCode.BarCodeCtrl barCodeCtrl1;
        private System.Windows.Forms.PictureBox Picrupee;
        private System.Windows.Forms.Button cmdprint;
        private System.Windows.Forms.Button cmdupdate;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtprate;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtsrate;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtmrp;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.ComboBox combatchcode;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtitemcode;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.Label label10;
        private WindowsFormsApplication2.UscGridshow uscGridshow1;
        private System.Windows.Forms.DataGridView gridmain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpbarcodesettings;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtnewbarcode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button cmddeletebarcode;
        private System.Windows.Forms.Button cmdupdatebarcode;
        private System.Windows.Forms.Panel pnlprintsettings;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel PnlPrintOptions;
        private System.Windows.Forms.Button cmdadprint;
        private System.Windows.Forms.ComboBox comprint;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtexdate;
        private System.Windows.Forms.Button Cmdshow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtmanfactdate;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.CheckBox Chksearch;
        private System.Windows.Forms.CheckBox chkmanexdate;
        private System.Windows.Forms.Panel pnlmanexdate;
    }
}