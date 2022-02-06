using System.Drawing;
using System.Windows.Forms;

namespace SimplyTeachingDesktop
{
    partial class LoginView
    {
        //private DataController dataController;
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TbUser = new System.Windows.Forms.TextBox();
            this.TbPass = new System.Windows.Forms.TextBox();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.LbSimplyTeaching = new System.Windows.Forms.Label();
            this.LbNight = new System.Windows.Forms.Label();
            this.BtnSignUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(195)))));
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(225)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(165, 252);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(120, 49);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Iniciar Sesión";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TbUser
            // 
            this.TbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.TbUser.Location = new System.Drawing.Point(57, 155);
            this.TbUser.Margin = new System.Windows.Forms.Padding(2);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(338, 32);
            this.TbUser.TabIndex = 2;
            this.TbUser.Text = "Usuario";
            this.TbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbUser.Enter += new System.EventHandler(this.TbUser_Enter);
            this.TbUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            this.TbUser.Leave += new System.EventHandler(this.TbUser_Leave);
            // 
            // TbPass
            // 
            this.TbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.TbPass.Location = new System.Drawing.Point(57, 205);
            this.TbPass.Margin = new System.Windows.Forms.Padding(2);
            this.TbPass.Name = "TbPass";
            this.TbPass.Size = new System.Drawing.Size(338, 32);
            this.TbPass.TabIndex = 3;
            this.TbPass.Text = "Contraseña";
            this.TbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbPass.Enter += new System.EventHandler(this.TbPass_Enter);
            this.TbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            this.TbPass.Leave += new System.EventHandler(this.TbPass_Leave);
            // 
            // PbLogo
            // 
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(128, 23);
            this.PbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(195, 81);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 4;
            this.PbLogo.TabStop = false;
            // 
            // LbSimplyTeaching
            // 
            this.LbSimplyTeaching.AutoSize = true;
            this.LbSimplyTeaching.BackColor = System.Drawing.Color.Transparent;
            this.LbSimplyTeaching.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSimplyTeaching.ForeColor = System.Drawing.Color.White;
            this.LbSimplyTeaching.Location = new System.Drawing.Point(104, 102);
            this.LbSimplyTeaching.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbSimplyTeaching.Name = "LbSimplyTeaching";
            this.LbSimplyTeaching.Size = new System.Drawing.Size(256, 42);
            this.LbSimplyTeaching.TabIndex = 5;
            this.LbSimplyTeaching.Text = "Simply Teaching";
            // 
            // LbNight
            // 
            this.LbNight.AutoSize = true;
            this.LbNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNight.ForeColor = System.Drawing.Color.White;
            this.LbNight.Location = new System.Drawing.Point(405, 291);
            this.LbNight.Name = "LbNight";
            this.LbNight.Size = new System.Drawing.Size(33, 25);
            this.LbNight.TabIndex = 9;
            this.LbNight.Text = "🌓";
            this.LbNight.Click += new System.EventHandler(this.LbNight_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.AutoSize = true;
            this.BtnSignUp.FlatAppearance.BorderSize = 0;
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignUp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSignUp.ForeColor = System.Drawing.Color.White;
            this.BtnSignUp.Location = new System.Drawing.Point(0, 284);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(104, 40);
            this.BtnSignUp.TabIndex = 10;
            this.BtnSignUp.Text = "Registrarse";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 325);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.LbNight);
            this.Controls.Add(this.LbSimplyTeaching);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.TbPass);
            this.Controls.Add(this.TbUser);
            this.Controls.Add(this.BtnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximumSize = new System.Drawing.Size(450, 325);
            this.MinimumSize = new System.Drawing.Size(450, 325);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimplyTeaching";
            this.Controls.SetChildIndex(this.BtnLogin, 0);
            this.Controls.SetChildIndex(this.TbUser, 0);
            this.Controls.SetChildIndex(this.TbPass, 0);
            this.Controls.SetChildIndex(this.PbLogo, 0);
            this.Controls.SetChildIndex(this.LbSimplyTeaching, 0);
            this.Controls.SetChildIndex(this.BtnMinimize, 0);
            this.Controls.SetChildIndex(this.BtnMaximize, 0);
            this.Controls.SetChildIndex(this.BtnExit, 0);
            this.Controls.SetChildIndex(this.LbNight, 0);
            this.Controls.SetChildIndex(this.BtnSignUp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TbUser;
        private System.Windows.Forms.TextBox TbPass;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Label LbSimplyTeaching;
        private System.Windows.Forms.Label LbNight;
        private Button BtnSignUp;
    }
}

