namespace SimplyTeachingDesktop.Views
{
    partial class AddEditForm
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
            this.teachersAdd1 = new SimplyTeachingDesktop.UserComponents.TeachersAdd();
            this.LbEntity = new System.Windows.Forms.Label();
            this.studentsAdd1 = new SimplyTeachingDesktop.UserComponents.StudentsAdd();
            this.subjectsAdd1 = new SimplyTeachingDesktop.UserComponents.SubjectsAdd();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnSave2 = new System.Windows.Forms.Button();
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
            // teachersAdd1
            // 
            this.teachersAdd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.teachersAdd1.Location = new System.Drawing.Point(12, 90);
            this.teachersAdd1.Name = "teachersAdd1";
            this.teachersAdd1.Size = new System.Drawing.Size(930, 393);
            this.teachersAdd1.TabIndex = 9;
            // 
            // LbEntity
            // 
            this.LbEntity.AutoSize = true;
            this.LbEntity.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEntity.ForeColor = System.Drawing.Color.White;
            this.LbEntity.Location = new System.Drawing.Point(405, 25);
            this.LbEntity.Name = "LbEntity";
            this.LbEntity.Size = new System.Drawing.Size(127, 37);
            this.LbEntity.TabIndex = 10;
            this.LbEntity.Text = "Profesor";
            // 
            // studentsAdd1
            // 
            this.studentsAdd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.studentsAdd1.Location = new System.Drawing.Point(18, 90);
            this.studentsAdd1.Name = "studentsAdd1";
            this.studentsAdd1.Size = new System.Drawing.Size(930, 393);
            this.studentsAdd1.TabIndex = 11;
            // 
            // subjectsAdd1
            // 
            this.subjectsAdd1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.subjectsAdd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.subjectsAdd1.Location = new System.Drawing.Point(242, 90);
            this.subjectsAdd1.Name = "subjectsAdd1";
            this.subjectsAdd1.Size = new System.Drawing.Size(490, 393);
            this.subjectsAdd1.TabIndex = 12;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(200, 520);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(685, 520);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(375, 520);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(100, 23);
            this.BtnSave.TabIndex = 15;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnSave2
            // 
            this.BtnSave2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.BtnSave2.FlatAppearance.BorderSize = 0;
            this.BtnSave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave2.ForeColor = System.Drawing.Color.White;
            this.BtnSave2.Location = new System.Drawing.Point(485, 520);
            this.BtnSave2.Name = "BtnSave2";
            this.BtnSave2.Size = new System.Drawing.Size(100, 23);
            this.BtnSave2.TabIndex = 16;
            this.BtnSave2.Text = "Guardar y Cont.";
            this.BtnSave2.UseVisualStyleBackColor = false;
            this.BtnSave2.Click += new System.EventHandler(this.BtnSave2_Click);
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(960, 577);
            this.Controls.Add(this.BtnSave2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LbEntity);
            this.Controls.Add(this.teachersAdd1);
            this.Controls.Add(this.subjectsAdd1);
            this.Controls.Add(this.studentsAdd1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditForm";
            this.Controls.SetChildIndex(this.studentsAdd1, 0);
            this.Controls.SetChildIndex(this.subjectsAdd1, 0);
            this.Controls.SetChildIndex(this.teachersAdd1, 0);
            this.Controls.SetChildIndex(this.LbEntity, 0);
            this.Controls.SetChildIndex(this.BtnMinimize, 0);
            this.Controls.SetChildIndex(this.BtnMaximize, 0);
            this.Controls.SetChildIndex(this.BtnExit, 0);
            this.Controls.SetChildIndex(this.BtnCancel, 0);
            this.Controls.SetChildIndex(this.BtnDelete, 0);
            this.Controls.SetChildIndex(this.BtnSave, 0);
            this.Controls.SetChildIndex(this.BtnSave2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserComponents.TeachersAdd teachersAdd1;
        private System.Windows.Forms.Label LbEntity;
        private UserComponents.StudentsAdd studentsAdd1;
        private UserComponents.SubjectsAdd subjectsAdd1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnSave2;
    }
}