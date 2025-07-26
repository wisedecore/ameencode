namespace WindowsFormsApplication2
{
    partial class Selectzatpandl
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
            this.label5 = new System.Windows.Forms.Label();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdShow = new System.Windows.Forms.Button();
            this.cmdclose = new System.Windows.Forms.Button();
            this.grpselection = new System.Windows.Forms.GroupBox();
            this.raddetail = new System.Windows.Forms.RadioButton();
            this.radsummery = new System.Windows.Forms.RadioButton();
            this.Raddatewise = new System.Windows.Forms.RadioButton();
            this.grpselection.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dtfrom
            // 
            this.Dtfrom.CustomFormat = "dd/MM/yyyy";
            this.Dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtfrom.Location = new System.Drawing.Point(107, 14);
            this.Dtfrom.Name = "Dtfrom";
            this.Dtfrom.Size = new System.Drawing.Size(156, 20);
            this.Dtfrom.TabIndex = 137;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(76, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 136;
            this.label5.Text = "To";
            // 
            // DtTo
            // 
            this.DtTo.CustomFormat = "dd/MM/yyyy";
            this.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtTo.Location = new System.Drawing.Point(107, 40);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(156, 20);
            this.DtTo.TabIndex = 135;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(60, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 134;
            this.label3.Text = "From";
            // 
            // CmdShow
            // 
            this.CmdShow.BackColor = System.Drawing.Color.Transparent;
            this.CmdShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdShow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdShow.ForeColor = System.Drawing.Color.Black;
            this.CmdShow.Location = new System.Drawing.Point(107, 106);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(75, 36);
            this.CmdShow.TabIndex = 138;
            this.CmdShow.Text = "&Show(F6)";
            this.CmdShow.UseVisualStyleBackColor = false;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // cmdclose
            // 
            this.cmdclose.BackColor = System.Drawing.Color.Transparent;
            this.cmdclose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdclose.ForeColor = System.Drawing.Color.Black;
            this.cmdclose.Location = new System.Drawing.Point(188, 106);
            this.cmdclose.Name = "cmdclose";
            this.cmdclose.Size = new System.Drawing.Size(75, 36);
            this.cmdclose.TabIndex = 139;
            this.cmdclose.Text = "C&lose";
            this.cmdclose.UseVisualStyleBackColor = false;
            this.cmdclose.Click += new System.EventHandler(this.cmdclose_Click);
            // 
            // grpselection
            // 
            this.grpselection.Controls.Add(this.Raddatewise);
            this.grpselection.Controls.Add(this.raddetail);
            this.grpselection.Controls.Add(this.radsummery);
            this.grpselection.Location = new System.Drawing.Point(47, 57);
            this.grpselection.Name = "grpselection";
            this.grpselection.Size = new System.Drawing.Size(247, 40);
            this.grpselection.TabIndex = 182;
            this.grpselection.TabStop = false;
            // 
            // raddetail
            // 
            this.raddetail.AutoSize = true;
            this.raddetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddetail.ForeColor = System.Drawing.Color.Black;
            this.raddetail.Location = new System.Drawing.Point(93, 13);
            this.raddetail.Name = "raddetail";
            this.raddetail.Size = new System.Drawing.Size(59, 21);
            this.raddetail.TabIndex = 127;
            this.raddetail.Text = "Detail";
            this.raddetail.UseVisualStyleBackColor = true;
            // 
            // radsummery
            // 
            this.radsummery.AutoSize = true;
            this.radsummery.Checked = true;
            this.radsummery.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radsummery.ForeColor = System.Drawing.Color.Black;
            this.radsummery.Location = new System.Drawing.Point(7, 10);
            this.radsummery.Name = "radsummery";
            this.radsummery.Size = new System.Drawing.Size(80, 21);
            this.radsummery.TabIndex = 126;
            this.radsummery.TabStop = true;
            this.radsummery.Text = "Summary";
            this.radsummery.UseVisualStyleBackColor = true;
            // 
            // Raddatewise
            // 
            this.Raddatewise.AutoSize = true;
            this.Raddatewise.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raddatewise.ForeColor = System.Drawing.Color.Black;
            this.Raddatewise.Location = new System.Drawing.Point(169, 13);
            this.Raddatewise.Name = "Raddatewise";
            this.Raddatewise.Size = new System.Drawing.Size(53, 21);
            this.Raddatewise.TabIndex = 128;
            this.Raddatewise.Text = "Date";
            this.Raddatewise.UseVisualStyleBackColor = true;
            // 
            // Selectzatpandl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(312, 160);
            this.Controls.Add(this.grpselection);
            this.Controls.Add(this.cmdclose);
            this.Controls.Add(this.CmdShow);
            this.Controls.Add(this.Dtfrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtTo);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Selectzatpandl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qplex profit and Loss";
            this.Load += new System.EventHandler(this.Selectzatpandl_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Selectzatpandl_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Selectzatpandl_KeyUp);
            this.grpselection.ResumeLayout(false);
            this.grpselection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dtfrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CmdShow;
        private System.Windows.Forms.Button cmdclose;
        private System.Windows.Forms.GroupBox grpselection;
        private System.Windows.Forms.RadioButton raddetail;
        private System.Windows.Forms.RadioButton radsummery;
        private System.Windows.Forms.RadioButton Raddatewise;
    }
}