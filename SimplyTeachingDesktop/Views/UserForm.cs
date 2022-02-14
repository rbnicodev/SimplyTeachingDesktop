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
    /// <summary>
    /// Generic custom form from which the rest of the windows will inherit.
    /// </summary>
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
            this.CenterToScreen();
        }
        /// <summary>
        /// Listener that makes elements reactive to window size
        /// </summary>
        /// <param name="sender">This form</param>
        /// <param name="e">Resize</param>
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
        /// <summary>
        /// Listener for the maximize button. Serves as a switch to change the icon and the function it calls
        /// </summary>
        /// <param name="sender">Button Maximize</param>
        /// <param name="e">Click</param>
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
        /// <summary>
        /// Listener for the minimize button.
        /// </summary>
        /// <param name="sender">Button Minimize</param>
        /// <param name="e">Click</param>
        protected void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Listener for the exit button
        /// </summary>
        /// <param name="sender">Button Exit</param>
        /// <param name="e">Click</param>
        protected virtual void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //////////////////////////////////////////////////////////////////
        /// <summary>
        /// These three functions [Form_MouseDown(); Form_MouseUp(); FormMouseMove();] work together so that the form, when customized, can be dragged around the window with the mouse.
        /// </summary>
        /// <param name="sender">Form</param>
        /// <param name="e">MouseMove/MouseUp/MouseDown</param>
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



        ////////////////////////////////////////////////////////////////


        /// <summary>
        /// Change the forecolor of the exit button to red when the mouse hovers over it
        /// </summary>
        /// <param name="sender">Button Exit</param>
        /// <param name="e">Enter</param>
        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            BtnExit.ForeColor = Color.White;
        }

        /// <summary>
        /// Change the forecolor of the exit button to red when the mouse leave it
        /// </summary>
        /// <param name="sender">Button Exit</param>
        /// <param name="e">Leave</param>
        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            BtnExit.ForeColor = EnvironmentVars.color1;
        }
    }
}
