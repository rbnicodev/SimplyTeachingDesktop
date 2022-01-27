namespace SimplyTeachingDesktop
{
    partial class SubjectPanel
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
            this.LbID = new System.Windows.Forms.Label();
            this.LbHora = new System.Windows.Forms.Label();
            this.LbDia = new System.Windows.Forms.Label();
            this.TbID = new System.Windows.Forms.TextBox();
            this.TbHora = new System.Windows.Forms.TextBox();
            this.TbDia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbID
            // 
            this.LbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbID.AutoSize = true;
            this.LbID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbID.ForeColor = EnvironmentVars.color1;
            this.LbID.Location = new System.Drawing.Point(12, 100);
            this.LbID.Name = "LbID";
            this.LbID.Size = new System.Drawing.Size(48, 35);
            this.LbID.TabIndex = 0;
            this.LbID.Text = "ID:";
            // 
            // LbHora
            // 
            this.LbHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbHora.AutoSize = true;
            this.LbHora.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHora.ForeColor = EnvironmentVars.color1;
            this.LbHora.Location = new System.Drawing.Point(12, 233);
            this.LbHora.Name = "LbHora";
            this.LbHora.Size = new System.Drawing.Size(79, 35);
            this.LbHora.TabIndex = 1;
            this.LbHora.Text = "Hora:";
            // 
            // LbDia
            // 
            this.LbDia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbDia.AutoSize = true;
            this.LbDia.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDia.ForeColor = EnvironmentVars.color1;
            this.LbDia.Location = new System.Drawing.Point(12, 366);
            this.LbDia.Name = "LbDia";
            this.LbDia.Size = new System.Drawing.Size(60, 35);
            this.LbDia.TabIndex = 2;
            this.LbDia.Text = "Día:";
            // 
            // TbID
            // 
            this.TbID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbID.BackColor = EnvironmentVars.color7;
            this.TbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbID.Enabled = false;
            this.TbID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbID.ForeColor = EnvironmentVars.color1;
            this.TbID.Location = new System.Drawing.Point(188, 100);
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(412, 34);
            this.TbID.TabIndex = 3;
            // 
            // TbHora
            // 
            this.TbHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbHora.BackColor = EnvironmentVars.color7;
            this.TbHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbHora.Enabled = false;
            this.TbHora.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbHora.ForeColor = EnvironmentVars.color1;
            this.TbHora.Location = new System.Drawing.Point(188, 233);
            this.TbHora.Name = "TbHora";
            this.TbHora.Size = new System.Drawing.Size(412, 34);
            this.TbHora.TabIndex = 4;
            // 
            // TbDia
            // 
            this.TbDia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDia.BackColor = EnvironmentVars.color7;
            this.TbDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDia.Enabled = false;
            this.TbDia.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDia.ForeColor = EnvironmentVars.color1;
            this.TbDia.Location = new System.Drawing.Point(188, 366);
            this.TbDia.Name = "TbDia";
            this.TbDia.Size = new System.Drawing.Size(412, 34);
            this.TbDia.TabIndex = 5;
            // 
            // SubjectPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = EnvironmentVars.color6;
            this.Controls.Add(this.TbDia);
            this.Controls.Add(this.TbHora);
            this.Controls.Add(this.TbID);
            this.Controls.Add(this.LbDia);
            this.Controls.Add(this.LbHora);
            this.Controls.Add(this.LbID);
            this.Name = "SubjectPanel";
            this.Size = new System.Drawing.Size(615, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LbID;
        public System.Windows.Forms.Label LbHora;
        public System.Windows.Forms.Label LbDia;
        public System.Windows.Forms.TextBox TbID;
        public System.Windows.Forms.TextBox TbHora;
        public System.Windows.Forms.TextBox TbDia;
    }
}
