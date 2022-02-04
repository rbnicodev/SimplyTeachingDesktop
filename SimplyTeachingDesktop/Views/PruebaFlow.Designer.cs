namespace SimplyTeachingDesktop.Views
{
    partial class PruebaFlow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BtnMinimize.Location = new System.Drawing.Point(711, 0);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BtnMaximize.Location = new System.Drawing.Point(741, 0);
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.Location = new System.Drawing.Point(771, 0);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(249, 370);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // PruebaFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PruebaFlow";
            this.Text = "PruebaFlow";
            this.Controls.SetChildIndex(this.BtnMinimize, 0);
            this.Controls.SetChildIndex(this.BtnMaximize, 0);
            this.Controls.SetChildIndex(this.BtnExit, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}