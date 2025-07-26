namespace WindowsFormsApplication2
{
    partial class Uscnuemeric
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnuemeric = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnuemeric
            // 
            this.txtnuemeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtnuemeric.Location = new System.Drawing.Point(0, 0);
            this.txtnuemeric.Multiline = true;
            this.txtnuemeric.Name = "txtnuemeric";
            this.txtnuemeric.Size = new System.Drawing.Size(88, 22);
            this.txtnuemeric.TabIndex = 0;
            this.txtnuemeric.Enter += new System.EventHandler(this.txtnuemeric_Enter);
            // 
            // Uscnuemeric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtnuemeric);
            this.Name = "Uscnuemeric";
            this.Size = new System.Drawing.Size(88, 22);
            this.Click += new System.EventHandler(this.Uscnuemeric_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnuemeric;
    }
}
