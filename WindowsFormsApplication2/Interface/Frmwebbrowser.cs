using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Frmwebbrowser : Form
    {
        public Frmwebbrowser()
        {
            InitializeComponent();
        }
        public static string Filepath = "www.mouscore.com";
        public void RefreshUrl()
        {
            this.webBrowser1.Url = new System.Uri("http://"+Filepath, System.UriKind.Absolute);
            txturl.Text = "http://" + Filepath;
            this.Close();
        }

        private void Frmwebbrowser_Load(object sender, EventArgs e)
        {
            RefreshUrl();
        }

        private void Frmwebbrowser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }
    }
}
