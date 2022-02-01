using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyTeachingDesktop.UserComponents
{
    public partial class SelectHour : UserControl
    {
        public SelectHour()
        {
            InitializeComponent();
            setTheme();
        }

        private void UpHour_Click(object sender, EventArgs e)
        {
            if (int.Parse(TbH.Text) < 23) TbH.Text = (int.Parse(TbH.Text) + 1).ToString();
            else TbH.Text = "0";
            if (int.Parse(TbH.Text) < 10) TbH.Text = "0" + TbH.Text;
        }

        private void DownHour_Click(object sender, EventArgs e)
        {
            if (int.Parse(TbH.Text) > 0) TbH.Text = (int.Parse(TbH.Text) - 1).ToString();
            else TbH.Text = "23";
            if (int.Parse(TbH.Text) < 10) TbH.Text = "0" + TbH.Text;
        }

        private void UpMin_Click(object sender, EventArgs e)
        {
            if (int.Parse(TbMin.Text) < 23) TbMin.Text = (int.Parse(TbMin.Text) + 1).ToString();
            else
            {
                TbMin.Text = "59";
                DownHour_Click(null, null);
            }
            if (int.Parse(TbMin.Text) < 10) TbMin.Text = "0" + TbMin.Text;
        }

        private void DownMin_Click(object sender, EventArgs e)
        {
            if (int.Parse(TbMin.Text) > 0) TbMin.Text = (int.Parse(TbMin.Text) - 1).ToString();
            else
            {
                TbMin.Text = "59";
                DownHour_Click(null, null);
            }
            if (int.Parse(TbMin.Text) < 10) TbMin.Text = "0" + TbMin.Text;
        }

        public void setTheme()
        {
            BackColor = EnvironmentVars.color5;
            TbH.BackColor = EnvironmentVars.color7;
            TbMin.BackColor = EnvironmentVars.color7;
            TbH.ForeColor = EnvironmentVars.color1;
            TbMin.ForeColor = EnvironmentVars.color1;
            LbDotes.ForeColor = EnvironmentVars.color1;
            BtnDown1.ForeColor = EnvironmentVars.color1;
            BtnDown2.ForeColor = EnvironmentVars.color1;
            BtnUp1.ForeColor = EnvironmentVars.color1;
            BtnUp2.ForeColor = EnvironmentVars.color1;
            BtnDown1.BackColor = EnvironmentVars.color5;
            BtnDown2.BackColor = EnvironmentVars.color5;
            BtnUp1.BackColor = EnvironmentVars.color5;
            BtnUp2.BackColor = EnvironmentVars.color5;

        }

        private void SelectHour_Load(object sender, EventArgs e)
        {

        }

        private void BtnUp2_MouseDown(object sender, MouseEventArgs e)
        {
            Thread.Sleep(10);
            UpMin_Click(null, null);
        }
    }
}
