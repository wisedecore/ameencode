namespace WindowsFormsApplication2
{
    partial class Frmselectstocktransfer
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
            this.Dtfrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdclose = new System.Windows.Forms.Button();
            this.CmdShow = new System.Windows.Forms.Button();
            this.Dtto = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tostockarea = new System.Windows.Forms.ComboBox();
            this.lblmodeofpayment = new System.Windows.Forms.Label();
            this.comfromstockarea = new System.Windows.Forms.ComboBox();
            this.Tabmain = new System.Windows.Forms.TabControl();
            this.tabmainSummury = new System.Windows.Forms.TabPage();
            this.tabMainDetail = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tabmain.SuspendLayout();
            this.tabmainSummury.SuspendLayout();
            this.tabMainDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dtfrom
            // 
            this.Dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtfrom.Location = new System.Drawing.Point(384, 221);
            this.Dtfrom.Name = "Dtfrom";
            this.Dtfrom.Size = new System.Drawing.Size(103, 20);
            this.Dtfrom.TabIndex = 198;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(295, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 197;
            this.label3.Text = "From";
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.Transparent;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(407, 273);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 36);
            this.cmdclose.TabIndex = 196;
            this.cmdclose.Text = "C&lose";
            this.cmdclose.UseVisualStyleBackColor = false;
            // 
            // CmdShow
            // 
            this.CmdShow.BackColor = System.Drawing.Color.Transparent;
            this.CmdShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdShow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdShow.ForeColor = System.Drawing.Color.Black;
            this.CmdShow.Location = new System.Drawing.Point(329, 273);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(75, 36);
            this.CmdShow.TabIndex = 195;
            this.CmdShow.Text = "&Show(F6)";
            this.CmdShow.UseVisualStyleBackColor = false;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // Dtto
            // 
            this.Dtto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtto.Location = new System.Drawing.Point(384, 247);
            this.Dtto.Name = "Dtto";
            this.Dtto.Size = new System.Drawing.Size(103, 20);
            this.Dtto.TabIndex = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(295, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 199;
            this.label1.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 204;
            this.label4.Text = "To Stock Area";
            // 
            // Tostockarea
            // 
            this.Tostockarea.FormattingEnabled = true;
            this.Tostockarea.Items.AddRange(new object[] {
            "Purchase",
            "Purchase Return",
            "Purchase Order"});
            this.Tostockarea.Location = new System.Drawing.Point(134, 33);
            this.Tostockarea.Name = "Tostockarea";
            this.Tostockarea.Size = new System.Drawing.Size(182, 21);
            this.Tostockarea.TabIndex = 203;
            // 
            // lblmodeofpayment
            // 
            this.lblmodeofpayment.AutoSize = true;
            this.lblmodeofpayment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodeofpayment.ForeColor = System.Drawing.Color.Black;
            this.lblmodeofpayment.Location = new System.Drawing.Point(20, 6);
            this.lblmodeofpayment.Name = "lblmodeofpayment";
            this.lblmodeofpayment.Size = new System.Drawing.Size(104, 17);
            this.lblmodeofpayment.TabIndex = 202;
            this.lblmodeofpayment.Text = "From Stock Area";
            // 
            // comfromstockarea
            // 
            this.comfromstockarea.FormattingEnabled = true;
            this.comfromstockarea.Items.AddRange(new object[] {
            "All",
            "Cash",
            "Credit"});
            this.comfromstockarea.Location = new System.Drawing.Point(134, 6);
            this.comfromstockarea.Name = "comfromstockarea";
            this.comfromstockarea.Size = new System.Drawing.Size(182, 21);
            this.comfromstockarea.TabIndex = 201;
            // 
            // Tabmain
            // 
            this.Tabmain.Controls.Add(this.tabmainSummury);
            this.Tabmain.Controls.Add(this.tabMainDetail);
            this.Tabmain.Location = new System.Drawing.Point(4, 8);
            this.Tabmain.Name = "Tabmain";
            this.Tabmain.SelectedIndex = 0;
            this.Tabmain.Size = new System.Drawing.Size(487, 207);
            this.Tabmain.TabIndex = 205;
            // 
            // tabmainSummury
            // 
            this.tabmainSummury.Controls.Add(this.Tostockarea);
            this.tabmainSummury.Controls.Add(this.label4);
            this.tabmainSummury.Controls.Add(this.comfromstockarea);
            this.tabmainSummury.Controls.Add(this.lblmodeofpayment);
            this.tabmainSummury.Location = new System.Drawing.Point(4, 22);
            this.tabmainSummury.Name = "tabmainSummury";
            this.tabmainSummury.Padding = new System.Windows.Forms.Padding(3);
            this.tabmainSummury.Size = new System.Drawing.Size(479, 181);
            this.tabmainSummury.TabIndex = 0;
            this.tabmainSummury.Text = "Summury";
            this.tabmainSummury.UseVisualStyleBackColor = true;
            // 
            // tabMainDetail
            // 
            this.tabMainDetail.Controls.Add(this.comboBox1);
            this.tabMainDetail.Controls.Add(this.label2);
            this.tabMainDetail.Location = new System.Drawing.Point(4, 22);
            this.tabMainDetail.Name = "tabMainDetail";
            this.tabMainDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainDetail.Size = new System.Drawing.Size(479, 181);
            this.tabMainDetail.TabIndex = 1;
            this.tabMainDetail.Text = "Detail";
            this.tabMainDetail.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Cash",
            "Credit"});
            this.comboBox1.Location = new System.Drawing.Point(124, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 203;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 204;
            this.label2.Text = "From Stock Area";
            // 
            // Frmselectstocktransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 321);
            this.Controls.Add(this.Tabmain);
            this.Controls.Add(this.Dtto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtfrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.CmdShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frmselectstocktransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Transfer";
            this.Load += new System.EventHandler(this.Frmselectstocktransfer_Load);
            this.Tabmain.ResumeLayout(false);
            this.tabmainSummury.ResumeLayout(false);
            this.tabmainSummury.PerformLayout();
            this.tabMainDetail.ResumeLayout(false);
            this.tabMainDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dtfrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.Button CmdShow;
        private System.Windows.Forms.DateTimePicker Dtto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Tostockarea;
        private System.Windows.Forms.Label lblmodeofpayment;
        private System.Windows.Forms.ComboBox comfromstockarea;
        private System.Windows.Forms.TabControl Tabmain;
        private System.Windows.Forms.TabPage tabmainSummury;
        private System.Windows.Forms.TabPage tabMainDetail;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}