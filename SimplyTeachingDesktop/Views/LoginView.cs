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
        bool signup = false;
        public LoginView()
        {
            InitializeComponent();
            controller = ControllerBuilder.GetController();
            BtnExit.Location = new Point(this.Width - 30, 0);
            this.CenterToScreen();
            setTheme();
        }

        /// <summary>
        /// Empty the user textBox when clicking on it
        /// </summary>
        /// <param name="sender">TextBox User</param>
        /// <param name="e">TextBox User</param>
        private void TbUser_Enter(object sender, EventArgs e)
        {
            if(TbUser.Text == "Usuario")
            {
                TbUser.Text = "";
                TbUser.ForeColor = EnvironmentVars.color1;
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


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(!signup)
            {
                if (controller.TestConnection())
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
            else
            {
                if(controller.SignUp(TbUser.Text, TbPass.Text))
                {
                    MessageBox.Show("El registro se ha realizado con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    DialogResult result = MessageBox.Show("Ha habido un error durante el registro", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if(result == DialogResult.Retry)
                    {
                        return;
                    }
                }

                SignUp_Click(null, null);
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
            BtnSignUp.ForeColor = EnvironmentVars.color1;
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

        private void SignUp_Click(object sender, EventArgs e)
        {
            if(!signup)
            {
                TbPass.Text = "";
                TbUser.Text = "";
                TbPass_Leave(null, null);
                TbUser_Leave(null, null);
                signup = true;
                BtnLogin.Text = "Registrarse";
                BtnSignUp.Text = "❮";
                this.Focus();
            }
            else
            {
                TbPass.Text = "";
                TbUser.Text = "";
                TbPass_Leave(null, null);
                TbUser_Leave(null, null);
                signup = false;
                BtnLogin.Text = "Iniciar Sesión";
                BtnSignUp.Text = "Registrarse";
                this.Focus();
            }
        }
    }
}
