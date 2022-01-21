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
    public partial class TeachersView : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public TeachersView()
        {
            InitializeComponent();
            DgvTeachers.Width = this.Width / 2 - 12;
            DgvTeachers.Height = this.Height - 40;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            DgvTeachers.Width = this.Width / 2 - 10;
            DgvTeachers.Height = this.Height - 45;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            } else if(this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            DgvTeachers.Width = this.Width / 2 - 10;
            DgvTeachers.Height = this.Height - 45;
            DgvTeachers.BackgroundColor = Color.FromArgb(255, 84, 84, 84);
            DgvTeachers.BorderStyle = BorderStyle.None;
        }
    }
}
