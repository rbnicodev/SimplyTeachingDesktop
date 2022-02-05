namespace SimplyTeachingDesktop.UserComponents
{
    partial class SubjectsAdd
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
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.LbPrice = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbID = new System.Windows.Forms.TextBox();
            this.LbDay = new System.Windows.Forms.Label();
            this.LbHour = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.LbID = new System.Windows.Forms.Label();
            this.CbDay = new System.Windows.Forms.ComboBox();
            this.selectHour1 = new SimplyTeachingDesktop.UserComponents.SelectHour();
            this.SuspendLayout();
            // 
            // TbPrice
            // 
            this.TbPrice.BackColor = System.Drawing.Color.Black;
            this.TbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPrice.ForeColor = System.Drawing.Color.White;
            this.TbPrice.Location = new System.Drawing.Point(158, 362);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(258, 29);
            this.TbPrice.TabIndex = 4;
            // 
            // LbPrice
            // 
            this.LbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbPrice.AutoSize = true;
            this.LbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPrice.ForeColor = System.Drawing.Color.White;
            this.LbPrice.Location = new System.Drawing.Point(47, 362);
            this.LbPrice.Name = "LbPrice";
            this.LbPrice.Size = new System.Drawing.Size(56, 21);
            this.LbPrice.TabIndex = 53;
            this.LbPrice.Text = "Precio:";
            // 
            // TbName
            // 
            this.TbName.BackColor = System.Drawing.Color.Black;
            this.TbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbName.ForeColor = System.Drawing.Color.White;
            this.TbName.Location = new System.Drawing.Point(158, 92);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(258, 29);
            this.TbName.TabIndex = 1;
            // 
            // TbID
            // 
            this.TbID.BackColor = System.Drawing.Color.Black;
            this.TbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbID.Enabled = false;
            this.TbID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbID.ForeColor = System.Drawing.Color.White;
            this.TbID.Location = new System.Drawing.Point(158, 2);
            this.TbID.Name = "TbID";
            this.TbID.ReadOnly = true;
            this.TbID.Size = new System.Drawing.Size(258, 29);
            this.TbID.TabIndex = 0;
            // 
            // LbDay
            // 
            this.LbDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbDay.AutoSize = true;
            this.LbDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDay.ForeColor = System.Drawing.Color.White;
            this.LbDay.Location = new System.Drawing.Point(47, 272);
            this.LbDay.Name = "LbDay";
            this.LbDay.Size = new System.Drawing.Size(36, 21);
            this.LbDay.TabIndex = 40;
            this.LbDay.Text = "Día:";
            // 
            // LbHour
            // 
            this.LbHour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbHour.AutoSize = true;
            this.LbHour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHour.ForeColor = System.Drawing.Color.White;
            this.LbHour.Location = new System.Drawing.Point(47, 182);
            this.LbHour.Name = "LbHour";
            this.LbHour.Size = new System.Drawing.Size(47, 21);
            this.LbHour.TabIndex = 39;
            this.LbHour.Text = "Hora:";
            // 
            // LbName
            // 
            this.LbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.ForeColor = System.Drawing.Color.White;
            this.LbName.Location = new System.Drawing.Point(47, 92);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(71, 21);
            this.LbName.TabIndex = 38;
            this.LbName.Text = "Nombre:";
            // 
            // LbID
            // 
            this.LbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbID.AutoSize = true;
            this.LbID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbID.ForeColor = System.Drawing.Color.White;
            this.LbID.Location = new System.Drawing.Point(47, 2);
            this.LbID.Name = "LbID";
            this.LbID.Size = new System.Drawing.Size(28, 21);
            this.LbID.TabIndex = 37;
            this.LbID.Text = "ID:";
            // 
            // CbDay
            // 
            this.CbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDay.FormattingEnabled = true;
            this.CbDay.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes"});
            this.CbDay.Location = new System.Drawing.Point(158, 272);
            this.CbDay.Name = "CbDay";
            this.CbDay.Size = new System.Drawing.Size(258, 21);
            this.CbDay.TabIndex = 3;
            // 
            // selectHour1
            // 
            this.selectHour1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.selectHour1.Location = new System.Drawing.Point(158, 170);
            this.selectHour1.Name = "selectHour1";
            this.selectHour1.Size = new System.Drawing.Size(165, 53);
            this.selectHour1.TabIndex = 2;
            // 
            // SubjectsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.selectHour1);
            this.Controls.Add(this.CbDay);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.LbPrice);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.TbID);
            this.Controls.Add(this.LbDay);
            this.Controls.Add(this.LbHour);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.LbID);
            this.Name = "SubjectsAdd";
            this.Size = new System.Drawing.Size(490, 393);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TbPrice;
        public System.Windows.Forms.Label LbPrice;
        public System.Windows.Forms.TextBox TbName;
        public System.Windows.Forms.TextBox TbID;
        public System.Windows.Forms.Label LbDay;
        public System.Windows.Forms.Label LbHour;
        public System.Windows.Forms.Label LbName;
        public System.Windows.Forms.Label LbID;
        public SelectHour selectHour1;
        public System.Windows.Forms.ComboBox CbDay;
    }
}
