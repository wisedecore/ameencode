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
    public partial class Frmiconset : Form
    {
        public Frmiconset()
        {
            InitializeComponent();
        }
        DBTask _dbtask = new DBTask();
        Clsiconset _ico = new Clsiconset();
        int HX; int HY; int FX; int FY;
        private void Frmiconset_Load(object sender, EventArgs e)
        {
            existingValueLod();
            CommonClass._Nextg.FormIcon(this);

        }
        public void existingValueLod()
        {
            combHX.BackColor = Color.White;
            combHY.BackColor = Color.White;
            combFx.BackColor = Color.White;
            combFY.BackColor = Color.White;

            HX =Convert.ToInt32( _dbtask.ExecuteScalar("select Xvalue from tblicon where icon='Header'"));
            HY = Convert.ToInt32(_dbtask.ExecuteScalar("select Yvalue from tblicon where icon='Header'"));
            combHX.Text = HX.ToString() ;
            combHY.Text = HY.ToString();
            FX = Convert.ToInt32(_dbtask.ExecuteScalar("select Xvalue from tblicon where icon='Footer'"));
            FY = Convert.ToInt32(_dbtask.ExecuteScalar("select Yvalue from tblicon where icon='Footer'"));
            combFx.Text = FX.ToString();
            combFY.Text = FY.ToString();

        }


        public void nextginitializationH()
        {
            HX =Convert.ToInt32( combHX.Text);
            HY = Convert.ToInt32(combHY.Text);
            _ico.ICONnAME = "Header";
            _ico.X = HX;
            _ico.Y = HY;
            _ico.Inserticons();

        }
        public void nextginitializationF()
        {
            FX = Convert.ToInt32(combFx.Text);
            FY = Convert.ToInt32(combFY.Text);
            _ico.ICONnAME = "Footer";
            _ico.X = FX;
            _ico.Y = FY;
            _ico.Inserticons();
        }

        private void cmdHreset_Click(object sender, EventArgs e)
        {
            combHX.BackColor = Color.Tomato;
            combHY.BackColor = Color.Tomato;
            _dbtask.ExecuteNonQuery("delete tblicon where icon='Header'");
        }

        private void CmdHset_Click(object sender, EventArgs e)
        {
            combHX.BackColor = Color.LimeGreen;
            combHY.BackColor = Color.LimeGreen;
            nextginitializationH();
        }

        private void CmdF_Click(object sender, EventArgs e)
        {
            combFx.BackColor = Color.LimeGreen;
            combFY.BackColor = Color.LimeGreen;
            nextginitializationF();

        }

        private void cmdFreset_Click(object sender, EventArgs e)
        {
            combFx.BackColor = Color.Tomato;
            combFY.BackColor = Color.Tomato;
            _dbtask.ExecuteNonQuery("delete tblicon where icon='Footer'");

        }

        private void cmdHreset_MouseHover(object sender, EventArgs e)
        {
            cmdHreset.BackColor = Color.Black;
            cmdHreset.ForeColor = Color.Red;


        }

        private void cmdHreset_MouseLeave(object sender, EventArgs e)
        {
            cmdHreset.BackColor = Color.LightGoldenrodYellow;
            cmdHreset.ForeColor = Color.Black;

        }

        private void cmdFreset_MouseHover(object sender, EventArgs e)
        {
            cmdFreset.BackColor = Color.Black;
            cmdFreset.ForeColor = Color.Red;

        }

        private void cmdFreset_MouseLeave(object sender, EventArgs e)
        {
            cmdFreset.BackColor = Color.LightGoldenrodYellow;
            cmdFreset.ForeColor = Color.Black;

        }

        private void CmdHset_MouseHover(object sender, EventArgs e)
        {
            CmdHset.BackColor = Color.Black;
            CmdHset.ForeColor = Color.Lime;
        }

        private void CmdHset_MouseLeave(object sender, EventArgs e)
        {
            CmdHset.BackColor = Color.LightGoldenrodYellow;
            CmdHset.ForeColor = Color.Black;

        }

        private void CmdF_MouseLeave(object sender, EventArgs e)
        {
            CmdF.BackColor = Color.LightGoldenrodYellow;
            CmdF.ForeColor = Color.Black;

        }

        private void CmdF_MouseHover(object sender, EventArgs e)
        {
            CmdF.BackColor = Color.Black;
            CmdF.ForeColor = Color.Lime;
        }
    }
}
