namespace SimplyTeachingDesktop
{
    partial class LoginView
    {
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.TbUser = new System.Windows.Forms.TextBox();
            this.TbPass = new System.Windows.Forms.TextBox();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.LbSimplyTeaching = new System.Windows.Forms.Label();
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
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(65)))), ((int)(((byte)(164)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(220, 310);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(160, 60);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Iniciar Sesión";
            this.BtnLogin.UseVisualStyleBackColor = false;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(537, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(62, 40);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "x";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // TbUser
            // 
            this.TbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.TbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUser.ForeColor = System.Drawing.Color.Gray;
            this.TbUser.Location = new System.Drawing.Point(150, 192);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(300, 31);
            this.TbUser.TabIndex = 2;
            this.TbUser.Text = "Usuario";
            this.TbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbUser.TextChanged += new System.EventHandler(this.TbUser_Changed);
            this.TbUser.Enter += new System.EventHandler(this.TbUser_Enter);
            this.TbUser.Leave += new System.EventHandler(this.TbUser_Leave);
            // 
            // TbPass
            // 
            this.TbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.TbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbPass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPass.ForeColor = System.Drawing.Color.Gray;
            this.TbPass.Location = new System.Drawing.Point(150, 252);
            this.TbPass.Name = "TbPass";
            this.TbPass.Size = new System.Drawing.Size(300, 31);
            this.TbPass.TabIndex = 3;
            this.TbPass.Text = "Contraseña";
            this.TbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbPass.Enter += new System.EventHandler(this.TbPass_Enter);
            this.TbPass.Leave += new System.EventHandler(this.TbPass_Leave);
            // 
            // PbLogo
            // 
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(170, 28);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(260, 100);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 4;
            this.PbLogo.TabStop = false;
            // 
            // LbSimplyTeaching
            // 
            this.LbSimplyTeaching.AutoSize = true;
            this.LbSimplyTeaching.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSimplyTeaching.ForeColor = System.Drawing.Color.White;
            this.LbSimplyTeaching.Location = new System.Drawing.Point(138, 126);
            this.LbSimplyTeaching.Name = "LbSimplyTeaching";
            this.LbSimplyTeaching.Size = new System.Drawing.Size(320, 52);
            this.LbSimplyTeaching.TabIndex = 5;
            this.LbSimplyTeaching.Text = "Simply Teaching";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.LbSimplyTeaching);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.TbPass);
            this.Controls.Add(this.TbUser);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "LoginView";
            this.ShowIcon = false;
            this.Text = "SimplyTeaching";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TbUser;
        private System.Windows.Forms.TextBox TbPass;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.Label LbSimplyTeaching;
    }
}

