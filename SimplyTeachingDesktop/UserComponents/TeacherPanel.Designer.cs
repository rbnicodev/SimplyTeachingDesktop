namespace SimplyTeachingDesktop
{
    partial class TeacherPanel
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbTel1 = new System.Windows.Forms.Label();
            this.LbTel2 = new System.Windows.Forms.Label();
            this.LbDir = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.TbTel1 = new System.Windows.Forms.TextBox();
            this.TbTel2 = new System.Windows.Forms.TextBox();
            this.TbDir = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbTel1
            // 
            this.LbTel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbTel1.AutoSize = true;
            this.LbTel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTel1.ForeColor = EnvironmentVars.color1;
            this.LbTel1.Location = new System.Drawing.Point(12, 85);
            this.LbTel1.Name = "LbTel1";
            this.LbTel1.Size = new System.Drawing.Size(146, 35);
            this.LbTel1.TabIndex = 0;
            this.LbTel1.Text = "Teléfono 1:";
            // 
            // LbTel2
            // 
            this.LbTel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbTel2.AutoSize = true;
            this.LbTel2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTel2.ForeColor = EnvironmentVars.color1;
            this.LbTel2.Location = new System.Drawing.Point(12, 195);
            this.LbTel2.Name = "LbTel2";
            this.LbTel2.Size = new System.Drawing.Size(146, 35);
            this.LbTel2.TabIndex = 1;
            this.LbTel2.Text = "Teléfono 2:";
            // 
            // LbDir
            // 
            this.LbDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbDir.AutoSize = true;
            this.LbDir.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDir.ForeColor = EnvironmentVars.color1;
            this.LbDir.Location = new System.Drawing.Point(12, 305);
            this.LbDir.Name = "LbDir";
            this.LbDir.Size = new System.Drawing.Size(132, 35);
            this.LbDir.TabIndex = 2;
            this.LbDir.Text = "Dirección:";
            // 
            // LbEmail
            // 
            this.LbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.ForeColor = EnvironmentVars.color1;
            this.LbEmail.Location = new System.Drawing.Point(12, 415);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(96, 35);
            this.LbEmail.TabIndex = 3;
            this.LbEmail.Text = "E-Mail:";
            // 
            // TbTel1
            // 
            this.TbTel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbTel1.BackColor = EnvironmentVars.color7;
            this.TbTel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbTel1.Enabled = false;
            this.TbTel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTel1.ForeColor = EnvironmentVars.color1;
            this.TbTel1.Location = new System.Drawing.Point(188, 85);
            this.TbTel1.Name = "TbTel1";
            this.TbTel1.Size = new System.Drawing.Size(412, 34);
            this.TbTel1.TabIndex = 4;
            // 
            // TbTel2
            // 
            this.TbTel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbTel2.BackColor = EnvironmentVars.color7;
            this.TbTel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbTel2.Enabled = false;
            this.TbTel2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTel2.ForeColor = EnvironmentVars.color1;
            this.TbTel2.Location = new System.Drawing.Point(188, 195);
            this.TbTel2.Name = "TbTel2";
            this.TbTel2.Size = new System.Drawing.Size(412, 34);
            this.TbTel2.TabIndex = 5;
            // 
            // TbDir
            // 
            this.TbDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDir.BackColor = EnvironmentVars.color7;
            this.TbDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDir.Enabled = false;
            this.TbDir.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDir.ForeColor = EnvironmentVars.color1;
            this.TbDir.Location = new System.Drawing.Point(188, 305);
            this.TbDir.Name = "TbDir";
            this.TbDir.Size = new System.Drawing.Size(412, 34);
            this.TbDir.TabIndex = 6;
            // 
            // TbEmail
            // 
            this.TbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbEmail.BackColor = EnvironmentVars.color7;
            this.TbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbEmail.Enabled = false;
            this.TbEmail.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbEmail.ForeColor = EnvironmentVars.color1;
            this.TbEmail.Location = new System.Drawing.Point(188, 415);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(412, 34);
            this.TbEmail.TabIndex = 7;
            // 
            // TeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = EnvironmentVars.color6;
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.TbDir);
            this.Controls.Add(this.TbTel2);
            this.Controls.Add(this.TbTel1);
            this.Controls.Add(this.LbEmail);
            this.Controls.Add(this.LbDir);
            this.Controls.Add(this.LbTel2);
            this.Controls.Add(this.LbTel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(615, 550);
            this.Name = "TeacherPanel";
            this.Size = new System.Drawing.Size(615, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LbTel1;
        public System.Windows.Forms.Label LbTel2;
        public System.Windows.Forms.Label LbDir;
        public System.Windows.Forms.Label LbEmail;
        public System.Windows.Forms.TextBox TbTel1;
        public System.Windows.Forms.TextBox TbTel2;
        public System.Windows.Forms.TextBox TbDir;
        public System.Windows.Forms.TextBox TbEmail;
    }
}
