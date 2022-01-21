using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SimplyTeachingDesktop
{
    public partial class LoginView : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public LoginView()
        {
            InitializeComponent();
            dataController = ControllersUtility.GetDataController();
        }

        private Boolean Validate_Email(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void TbUser_Enter(object sender, EventArgs e)
        {
            if(TbUser.Text == "Usuario")
            {
                TbUser.Text = "";
                TbUser.ForeColor = Color.White;
            }
        }

        private void TbPass_Enter(object sender, EventArgs e)
        {
            if(TbPass.Text == "Contraseña")
            {
                TbPass.Text = "";
                TbPass.ForeColor = Color.White;
                TbPass.PasswordChar = '*';
            }
        }

        private void TbUser_Leave(object sender, EventArgs e)
        {
            if(TbUser.Text == "")
            {
                TbUser.Text = "Usuario";
                TbUser.ForeColor = Color.Gray;
            }
        }

        private void TbPass_Leave(object sender, EventArgs e)
        {
            if (TbPass.Text == "")
            {
                TbPass.Text = "Contraseña";
                TbPass.ForeColor = Color.Gray;
                TbPass.PasswordChar = '\0';
            }
        }

        private void TbUser_Changed(object sender, EventArgs e)
        {

            if(TbUser.Text =="" || TbUser.Text == "Usuario")
            {
                TbUser.BorderStyle = BorderStyle.None;
                TbUser.BackColor = Color.Black;
            }
            else if (!Validate_Email(TbUser.Text))
            {
                TbUser.BackColor = Color.FromArgb(255, 80, 0, 0);
            }
            else
            {
                TbUser.BorderStyle = BorderStyle.None;
                TbUser.BackColor = Color.FromArgb(255, 0, 80, 0);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (dataController.Login(TbUser.Text, TbPass.Text))
            {
                TeachersView teachersView = new TeachersView();
                teachersView.Show();
                this.Visible = false;
            }
        }
    }
}
