namespace WindowsFormsApplication2
{
    partial class Frmmechinetool
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
            this.cmdexportcustomers = new System.Windows.Forms.Button();
            this.Chkcwithclosingbalance = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Cmdexportitems = new System.Windows.Forms.Button();
            this.Grpexport = new System.Windows.Forms.GroupBox();
            this.Grpimport = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Grpexport.SuspendLayout();
            this.Grpimport.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdexportcustomers
            // 
            this.cmdexportcustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.cmdexportcustomers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cmdexportcustomers.FlatAppearance.BorderSize = 0;
            this.cmdexportcustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdexportcustomers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdexportcustomers.ForeColor = System.Drawing.Color.Black;
            this.cmdexportcustomers.Location = new System.Drawing.Point(25, 19);
            this.cmdexportcustomers.Name = "cmdexportcustomers";
            this.cmdexportcustomers.Size = new System.Drawing.Size(142, 30);
            this.cmdexportcustomers.TabIndex = 153;
            this.cmdexportcustomers.Text = "Export Cutomers";
            this.cmdexportcustomers.UseVisualStyleBackColor = false;
            this.cmdexportcustomers.Click += new System.EventHandler(this.cmdexportcustomers_Click);
            // 
            // Chkcwithclosingbalance
            // 
            this.Chkcwithclosingbalance.AutoSize = true;
            this.Chkcwithclosingbalance.Location = new System.Drawing.Point(25, 56);
            this.Chkcwithclosingbalance.Name = "Chkcwithclosingbalance";
            this.Chkcwithclosingbalance.Size = new System.Drawing.Size(126, 17);
            this.Chkcwithclosingbalance.TabIndex = 154;
            this.Chkcwithclosingbalance.Text = "With Closing balance";
            this.Chkcwithclosingbalance.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(223, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 17);
            this.checkBox1.TabIndex = 156;
            this.checkBox1.Text = "With Closing Stock";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Cmdexportitems
            // 
            this.Cmdexportitems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.Cmdexportitems.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cmdexportitems.FlatAppearance.BorderSize = 0;
            this.Cmdexportitems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmdexportitems.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmdexportitems.ForeColor = System.Drawing.Color.Black;
            this.Cmdexportitems.Location = new System.Drawing.Point(223, 19);
            this.Cmdexportitems.Name = "Cmdexportitems";
            this.Cmdexportitems.Size = new System.Drawing.Size(142, 30);
            this.Cmdexportitems.TabIndex = 155;
            this.Cmdexportitems.Text = "Export Items";
            this.Cmdexportitems.UseVisualStyleBackColor = false;
            this.Cmdexportitems.Click += new System.EventHandler(this.Cmdexportitems_Click);
            // 
            // Grpexport
            // 
            this.Grpexport.Controls.Add(this.Cmdexportitems);
            this.Grpexport.Controls.Add(this.cmdexportcustomers);
            this.Grpexport.Controls.Add(this.checkBox1);
            this.Grpexport.Controls.Add(this.Chkcwithclosingbalance);
            this.Grpexport.Location = new System.Drawing.Point(22, 12);
            this.Grpexport.Name = "Grpexport";
            this.Grpexport.Size = new System.Drawing.Size(568, 133);
            this.Grpexport.TabIndex = 158;
            this.Grpexport.TabStop = false;
            this.Grpexport.Text = "Export";
            // 
            // Grpimport
            // 
            this.Grpimport.Controls.Add(this.button2);
            this.Grpimport.Location = new System.Drawing.Point(22, 188);
            this.Grpimport.Name = "Grpimport";
            this.Grpimport.Size = new System.Drawing.Size(568, 133);
            this.Grpimport.TabIndex = 159;
            this.Grpimport.TabStop = false;
            this.Grpimport.Text = "Import";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(25, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 30);
            this.button2.TabIndex = 153;
            this.button2.Text = "Import sales";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Frmmechinetool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 360);
            this.Controls.Add(this.Grpimport);
            this.Controls.Add(this.Grpexport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frmmechinetool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electric Mechinetool";
            this.Load += new System.EventHandler(this.Frmmechinetool_Load);
            this.Grpexport.ResumeLayout(false);
            this.Grpexport.PerformLayout();
            this.Grpimport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdexportcustomers;
        private System.Windows.Forms.CheckBox Chkcwithclosingbalance;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Cmdexportitems;
        private System.Windows.Forms.GroupBox Grpexport;
        private System.Windows.Forms.GroupBox Grpimport;
        private System.Windows.Forms.Button button2;
    }
}