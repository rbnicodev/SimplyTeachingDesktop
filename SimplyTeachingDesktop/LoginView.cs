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
            setTheme();
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
                EnviromentVars.SetNight(false);
            }
            else
            {
                EnviromentVars.SetNight(true);
            }
            setTheme();

        }

        private void setTheme()
        {
            BackColor = EnviromentVars.color6;
            LbNight.ForeColor = EnviromentVars.color1;
            LbSimplyTeaching.ForeColor = EnviromentVars.color1;
            TbPass.BackColor = EnviromentVars.color7;
            TbUser.BackColor = EnviromentVars.color7;
            TbPass.ForeColor = EnviromentVars.color2;
            TbUser.ForeColor = EnviromentVars.color2;
            BtnExit.ForeColor = EnviromentVars.color1;
            Bitmap image = null;
            if (EnviromentVars.night)
            {
                image = new Bitmap("images/logo-night.png");
            }
            else
            {
                image = new Bitmap("images/logo-day.png");
            }
            this.PbLogo.Dock = DockStyle.None;
            this.PbLogo.Image = (Image)image;
            image = null;
        }
    }
}
