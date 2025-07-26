namespace WindowsFormsApplication2
{
    partial class FrmHoldpopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoldpopup));
            this.cmdpopup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdpopup
            // 
            this.cmdpopup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdpopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdpopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdpopup.Location = new System.Drawing.Point(0, 1);
            this.cmdpopup.Name = "cmdpopup";
            this.cmdpopup.Size = new System.Drawing.Size(202, 102);
            this.cmdpopup.TabIndex = 0;
            this.cmdpopup.Text = "ssdsdsds";
            this.cmdpopup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdpopup.UseVisualStyleBackColor = false;
            // 
            // FrmHoldpopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 425);
            this.Controls.Add(this.cmdpopup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHoldpopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHoldpopup";
            this.Load += new System.EventHandler(this.FrmHoldpopup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button cmdpopup;

    }
}