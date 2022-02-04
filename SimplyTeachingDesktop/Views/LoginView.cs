using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SimplyTeachingDesktop.Views;

namespace SimplyTeachingDesktop
{
    public partial class LoginView : UserForm
    {
        DataController controller;
        public LoginView()
        {
            //PruebaFlow pruebaFlow = new PruebaFlow();
            //pruebaFlow.ShowDialog();
            InitializeComponent();
            controller = ControllerBuilder.GetController();
            BtnExit.Location = new Point(this.Width - 30, 0);
            this.CenterToScreen();
            setTheme();
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
                TbPass.ForeColor = EnvironmentVars.color1;
                TbPass.PasswordChar = '*';
            }
        }

        private void TbUser_Leave(object sender, EventArgs e)
        {
            if(TbUser.Text == "")
            {
                TbUser.Text = "Usuario";
                TbUser.ForeColor = EnvironmentVars.color2;
            }
        }

        private void TbPass_Leave(object sender, EventArgs e)
        {
            if (TbPass.Text == "")
            {
                TbPass.Text = "Contraseña";
                TbPass.ForeColor = EnvironmentVars.color2;
                TbPass.PasswordChar = '\0';
            }
        }

        private void TbUser_Changed(object sender, EventArgs e)
        {

            if(TbUser.Text =="" || TbUser.Text == "Usuario")
            {
                TbUser.BorderStyle = BorderStyle.None;
                TbUser.BackColor = EnvironmentVars.color7;
            }
            else if (!controller.Validate_Email(TbUser.Text))
            {
                TbUser.BackColor = Color.FromArgb(255, 80, 0, 0);
            }
            else
            {
                TbUser.BorderStyle = BorderStyle.None;
                TbUser.BackColor = EnvironmentVars.color7;
                TbUser.ForeColor = EnvironmentVars.color1;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(controller.TestConnection())
            {
                if (controller.Login(TbUser.Text.Trim(), TbPass.Text.Trim()))
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
            else
            {
                MessageBox.Show("Ha habido algún error con la conexión\nComprueba que tengas conexión a internet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                BtnLogin_Click(null, null);
        }

        private void LbNight_Click(object sender, EventArgs e)
        {
            if(EnvironmentVars.night)
            {
                EnvironmentVars.SetNight(false);
            }
            else
            {
                EnvironmentVars.SetNight(true);
            }
            setTheme();

        }

        private void setTheme()
        {
            BackColor = EnvironmentVars.color6;
            LbNight.ForeColor = EnvironmentVars.color1;
            LbSimplyTeaching.ForeColor = EnvironmentVars.color1;
            TbPass.BackColor = EnvironmentVars.color7;
            TbUser.BackColor = EnvironmentVars.color7;
            TbPass.ForeColor = EnvironmentVars.color2;
            TbUser.ForeColor = EnvironmentVars.color2;
            BtnExit.ForeColor = EnvironmentVars.color1;
            Bitmap image = null;
            if (EnvironmentVars.night)
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
