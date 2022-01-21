using System.Drawing;

namespace SimplyTeachingDesktop
{
    partial class LoginView
    {
        private DataController dataController;
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(75)))), ((int)(((byte)(174)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(55)))), ((int)(((byte)(155)))));
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(220, 310);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(160, 60);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Iniciar Sesión";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TbUser
            // 
            this.TbUser.BackColor = System.Drawing.Color.Black;
            this.TbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUser.ForeColor = System.Drawing.Color.Gray;
            this.TbUser.Location = new System.Drawing.Point(149, 192);
            this.TbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(300, 31);
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
            this.TbPass.BackColor = System.Drawing.Color.Black;
            this.TbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbPass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPass.ForeColor = System.Drawing.Color.Gray;
            this.TbPass.Location = new System.Drawing.Point(149, 252);
            this.TbPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbPass.Name = "TbPass";
            this.TbPass.Size = new System.Drawing.Size(300, 31);
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
            this.PbLogo.Location = new System.Drawing.Point(171, 28);
            this.PbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(260, 100);
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
            this.LbSimplyTeaching.Location = new System.Drawing.Point(139, 126);
            this.LbSimplyTeaching.Name = "LbSimplyTeaching";
            this.LbSimplyTeaching.Size = new System.Drawing.Size(320, 52);
            this.LbSimplyTeaching.TabIndex = 5;
            this.LbSimplyTeaching.Text = "Simply Teaching";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(560, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "🗙";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LbSimplyTeaching);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.TbPass);
            this.Controls.Add(this.TbUser);
            this.Controls.Add(this.BtnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "LoginView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimplyTeaching";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
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
        private System.Windows.Forms.Button button1;
    }
}

