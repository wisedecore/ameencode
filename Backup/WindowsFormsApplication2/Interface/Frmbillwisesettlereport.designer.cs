namespace WindowsFormsApplication2
{
    partial class Frmbillwisesettlereport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmbillwisesettlereport));
            this.label1 = new System.Windows.Forms.Label();
            this.txtcusctomer = new System.Windows.Forms.TextBox();
            this.uscitemshowsimple2 = new WindowsFormsApplication2.Uscitemshowsimple();
            this.CmdShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Party";
            // 
            // txtcusctomer
            // 
            this.txtcusctomer.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusctomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtcusctomer.Location = new System.Drawing.Point(2, 17);
            this.txtcusctomer.Name = "txtcusctomer";
            this.txtcusctomer.Size = new System.Drawing.Size(324, 25);
            this.txtcusctomer.TabIndex = 1;
            this.txtcusctomer.TextChanged += new System.EventHandler(this.txtcusctomer_TextChanged);
            this.txtcusctomer.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtcusctomer_PreviewKeyDown);
            // 
            // uscitemshowsimple2
            // 
            this.uscitemshowsimple2.BackColor = System.Drawing.Color.LavenderBlush;
            this.uscitemshowsimple2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uscitemshowsimple2.ForeColor = System.Drawing.Color.Black;
            this.uscitemshowsimple2.Location = new System.Drawing.Point(2, 46);
            this.uscitemshowsimple2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uscitemshowsimple2.Name = "uscitemshowsimple2";
            this.uscitemshowsimple2.Size = new System.Drawing.Size(324, 135);
            this.uscitemshowsimple2.TabIndex = 194;
            this.uscitemshowsimple2.Visible = false;
            // 
            // CmdShow
            // 
            this.CmdShow.BackColor = System.Drawing.Color.PowderBlue;
            this.CmdShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdShow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdShow.ForeColor = System.Drawing.Color.Black;
            this.CmdShow.Location = new System.Drawing.Point(243, 145);
            this.CmdShow.Name = "CmdShow";
            this.CmdShow.Size = new System.Drawing.Size(75, 36);
            this.CmdShow.TabIndex = 195;
            this.CmdShow.Text = "Show";
            this.CmdShow.UseVisualStyleBackColor = false;
            this.CmdShow.Click += new System.EventHandler(this.CmdShow_Click);
            // 
            // Frmbillwisesettlereport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(246)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(331, 193);
            this.Controls.Add(this.uscitemshowsimple2);
            this.Controls.Add(this.txtcusctomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdShow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmbillwisesettlereport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billwisesettlement Report";
            this.Load += new System.EventHandler(this.Frmbillwisesettlereport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcusctomer;
        public Uscitemshowsimple uscitemshowsimple2;
        private System.Windows.Forms.Button CmdShow;
    }
}