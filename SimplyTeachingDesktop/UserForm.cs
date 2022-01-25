using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyTeachingDesktop
{
    public partial class UserForm : Form
    {
        protected bool dragging = false;
        protected Point startPoint = new Point(0, 0);
        public UserForm()
        {

            InitializeComponent();
            BackColor = EnvironmentVars.color6;
            BtnExit.ForeColor = EnvironmentVars.color1;
            BtnMaximize.ForeColor = EnvironmentVars.color1;
            BtnMinimize.ForeColor = EnvironmentVars.color1;
        }

        protected void UserForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                BtnMaximize.Font = new Font("Marlett", 14);
                BtnMaximize.Text = "";
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                BtnMaximize.Font = new Font("Segoe UI", 12);
                BtnMaximize.Text = "🗖";
            }
        }

        protected void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        protected void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        protected virtual void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        protected void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        protected void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            BtnExit.ForeColor = Color.White;
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            BtnExit.ForeColor = EnvironmentVars.color1;
        }
    }
}
