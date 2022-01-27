﻿using System.Drawing;
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
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            //
            // BtnLogin
            // 
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            //this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(75)))), ((int)(((byte)(174)))));
            this.BtnLogin.BackColor = EnvironmentVars.colorResalt;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = EnvironmentVars.colorResaltLow;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = EnvironmentVars.colorResaltHigh;
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
            this.TbUser.BackColor = EnvironmentVars.color7;
            this.TbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUser.ForeColor = EnvironmentVars.color2;
            this.TbUser.Location = new System.Drawing.Point(112, 156);
            this.TbUser.Margin = new System.Windows.Forms.Padding(2);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(225, 25);
            this.TbUser.TabIndex = 2;
            this.TbUser.Text = "Usuario";
            this.TbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbUser.TextChanged += new System.EventHandler(this.TbUser_Changed);
            this.TbUser.Enter += new System.EventHandler(this.TbUser_Enter);
            this.TbUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            this.TbUser.Leave += new System.EventHandler(this.TbUser_Leave);
            // 
            // TbPass
            // 
            this.TbPass.BackColor = EnvironmentVars.color7;
            this.TbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPass.ForeColor = EnvironmentVars.color2;
            this.TbPass.Location = new System.Drawing.Point(112, 205);
            this.TbPass.Margin = new System.Windows.Forms.Padding(2);
            this.TbPass.Name = "TbPass";
            this.TbPass.Size = new System.Drawing.Size(225, 25);
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
            this.LbSimplyTeaching.ForeColor = EnvironmentVars.color1;
            this.LbSimplyTeaching.Location = new System.Drawing.Point(104, 102);
            this.LbSimplyTeaching.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbSimplyTeaching.Name = "LbSimplyTeaching";
            this.LbSimplyTeaching.Size = new System.Drawing.Size(256, 42);
            this.LbSimplyTeaching.TabIndex = 5;
            this.LbSimplyTeaching.Text = "Simply Teaching";
            // 
            // LbNight
            // 
            this.LbNight.ForeColor = EnvironmentVars.color1;
            this.LbNight.AutoSize = true;
            this.LbNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNight.Location = new System.Drawing.Point(405, 291);
            this.LbNight.Name = "LbNight";
            this.LbNight.Size = new System.Drawing.Size(33, 25);
            this.LbNight.TabIndex = 9;
            this.LbNight.Text = "🌓";
            this.LbNight.Click += new System.EventHandler(this.LbNight_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(450, 325);
            this.Controls.Add(this.LbNight);
            this.Controls.Add(this.LbSimplyTeaching);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.TbPass);
            this.Controls.Add(this.TbUser);
            this.Controls.Add(this.BtnLogin);
            this.MaximumSize = new System.Drawing.Size(450, 325);
            this.MinimumSize = new System.Drawing.Size(450, 325);
            this.Name = "LoginView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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
    }
}
