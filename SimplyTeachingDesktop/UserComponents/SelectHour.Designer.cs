namespace SimplyTeachingDesktop.UserComponents
{
    partial class SelectHour
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
            this.TbH = new System.Windows.Forms.TextBox();
            this.BtnDown2 = new System.Windows.Forms.Button();
            this.BtnUp2 = new System.Windows.Forms.Button();
            this.TbMin = new System.Windows.Forms.TextBox();
            this.LbDotes = new System.Windows.Forms.Label();
            this.BtnDown1 = new System.Windows.Forms.Button();
            this.BtnUp1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbH
            // 
            this.TbH.BackColor = System.Drawing.Color.Black;
            this.TbH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbH.ForeColor = System.Drawing.Color.White;
            this.TbH.Location = new System.Drawing.Point(27, 13);
            this.TbH.Name = "TbH";
            this.TbH.ReadOnly = true;
            this.TbH.Size = new System.Drawing.Size(44, 29);
            this.TbH.TabIndex = 0;
            this.TbH.Text = "00";
            this.TbH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnDown2
            // 
            this.BtnDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDown2.FlatAppearance.BorderSize = 0;
            this.BtnDown2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDown2.ForeColor = System.Drawing.Color.White;
            this.BtnDown2.Location = new System.Drawing.Point(130, 29);
            this.BtnDown2.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDown2.Name = "BtnDown2";
            this.BtnDown2.Size = new System.Drawing.Size(20, 20);
            this.BtnDown2.TabIndex = 5;
            this.BtnDown2.TabStop = false;
            this.BtnDown2.Text = "▼";
            this.BtnDown2.UseVisualStyleBackColor = false;
            this.BtnDown2.Click += new System.EventHandler(this.DownMin_Click);
            // 
            // BtnUp2
            // 
            this.BtnUp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnUp2.FlatAppearance.BorderSize = 0;
            this.BtnUp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUp2.ForeColor = System.Drawing.Color.White;
            this.BtnUp2.Location = new System.Drawing.Point(130, 6);
            this.BtnUp2.Margin = new System.Windows.Forms.Padding(0);
            this.BtnUp2.Name = "BtnUp2";
            this.BtnUp2.Size = new System.Drawing.Size(20, 20);
            this.BtnUp2.TabIndex = 4;
            this.BtnUp2.TabStop = false;
            this.BtnUp2.Text = "▲";
            this.BtnUp2.UseVisualStyleBackColor = false;
            this.BtnUp2.Click += new System.EventHandler(this.UpMin_Click);
            // 
            // TbMin
            // 
            this.TbMin.BackColor = System.Drawing.Color.Black;
            this.TbMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMin.ForeColor = System.Drawing.Color.White;
            this.TbMin.Location = new System.Drawing.Point(83, 13);
            this.TbMin.Name = "TbMin";
            this.TbMin.ReadOnly = true;
            this.TbMin.Size = new System.Drawing.Size(44, 29);
            this.TbMin.TabIndex = 1;
            this.TbMin.Text = "00";
            this.TbMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LbDotes
            // 
            this.LbDotes.AutoSize = true;
            this.LbDotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LbDotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDotes.ForeColor = System.Drawing.Color.White;
            this.LbDotes.Location = new System.Drawing.Point(67, 9);
            this.LbDotes.Name = "LbDotes";
            this.LbDotes.Size = new System.Drawing.Size(22, 31);
            this.LbDotes.TabIndex = 6;
            this.LbDotes.Text = ":";
            // 
            // BtnDown1
            // 
            this.BtnDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDown1.FlatAppearance.BorderSize = 0;
            this.BtnDown1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDown1.ForeColor = System.Drawing.Color.White;
            this.BtnDown1.Location = new System.Drawing.Point(4, 29);
            this.BtnDown1.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDown1.Name = "BtnDown1";
            this.BtnDown1.Size = new System.Drawing.Size(20, 20);
            this.BtnDown1.TabIndex = 8;
            this.BtnDown1.TabStop = false;
            this.BtnDown1.Text = "▼";
            this.BtnDown1.UseVisualStyleBackColor = false;
            this.BtnDown1.Click += new System.EventHandler(this.DownHour_Click);
            // 
            // BtnUp1
            // 
            this.BtnUp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnUp1.FlatAppearance.BorderSize = 0;
            this.BtnUp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUp1.ForeColor = System.Drawing.Color.White;
            this.BtnUp1.Location = new System.Drawing.Point(4, 6);
            this.BtnUp1.Margin = new System.Windows.Forms.Padding(0);
            this.BtnUp1.Name = "BtnUp1";
            this.BtnUp1.Size = new System.Drawing.Size(20, 20);
            this.BtnUp1.TabIndex = 7;
            this.BtnUp1.TabStop = false;
            this.BtnUp1.Text = "▲";
            this.BtnUp1.UseVisualStyleBackColor = false;
            this.BtnUp1.Click += new System.EventHandler(this.UpHour_Click);
            // 
            // SelectHour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.BtnDown1);
            this.Controls.Add(this.BtnUp1);
            this.Controls.Add(this.TbMin);
            this.Controls.Add(this.BtnDown2);
            this.Controls.Add(this.BtnUp2);
            this.Controls.Add(this.TbH);
            this.Controls.Add(this.LbDotes);
            this.Name = "SelectHour";
            this.Size = new System.Drawing.Size(165, 53);
            this.Load += new System.EventHandler(this.SelectHour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TbH;
        public System.Windows.Forms.Button BtnDown2;
        public System.Windows.Forms.Button BtnUp2;
        public System.Windows.Forms.TextBox TbMin;
        public System.Windows.Forms.Label LbDotes;
        public System.Windows.Forms.Button BtnDown1;
        public System.Windows.Forms.Button BtnUp1;
    }
}
