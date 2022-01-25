using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SimplyTeachingDesktop
{
    public partial class LoginView : UserForm
    {
        public LoginView()
        {
            InitializeComponent();
            dataController = new DataController();
            BtnExit.Location = new Point(this.Width - 30, 0);
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
                TbPass.ForeColor = EnviromentVars.color1;
                TbPass.PasswordChar = '*';
            }
        }

        private void TbUser_Leave(object sender, EventArgs e)
        {
            if(TbUser.Text == "")
            {
                TbUser.Text = "Usuario";
                TbUser.ForeColor = EnviromentVars.color2;
            }
        }

        private void TbPass_Leave(object sender, EventArgs e)
        {
            if (TbPass.Text == "")
            {
                TbPass.Text = "Contraseña";
                TbPass.ForeColor = EnviromentVars.color2;
                TbPass.PasswordChar = '\0';
            }
        }

        private void TbUser_Changed(object sender, EventArgs e)
        {

            if(TbUser.Text =="" || TbUser.Text == "Usuario")
            {
                TbUser.BorderStyle = BorderStyle.None;
                TbUser.BackColor = EnviromentVars.color7;
            }
            else if (!Validate_Email(TbUser.Text))
            {
                TbUser.BackColor = Color.FromArgb(255, 80, 0, 0);
            }
            else
            {
                TbUser.BorderStyle = BorderStyle.None;
                TbUser.BackColor = EnviromentVars.color7;
                TbUser.ForeColor = EnviromentVars.color1;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (dataController.Login(TbUser.Text.Trim(), TbPass.Text.Trim()))
            {
                TableView teachersView = new TableView();
                teachersView.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                BtnLogin_Click(null, null);
        }

        private void LbNight_Click(object sender, EventArgs e)
        {
            if(EnviromentVars.night)
            {
                EnviromentVars.setNight(false);
            }
            else
            {
                EnviromentVars.setNight(true);
            }
            this.Visible = false;
            new LoginView().Show();
        }
    }
}
