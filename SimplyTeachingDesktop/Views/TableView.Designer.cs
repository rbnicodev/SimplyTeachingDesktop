using System.Drawing;
using System.Windows.Forms;

namespace SimplyTeachingDesktop
{
    partial class TableView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableView));
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.LbSimplyTeaching = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.PictureBox();
            this.BtnAdd = new System.Windows.Forms.PictureBox();
            this.LbEntity = new System.Windows.Forms.Label();
            this.BtnAlumnos = new System.Windows.Forms.Label();
            this.BtnAsignaturas = new System.Windows.Forms.Label();
            this.BtnProfesores = new System.Windows.Forms.Label();
            this.studentsPanel1 = new SimplyTeachingDesktop.StudentsPanel();
            this.teacherPanel1 = new SimplyTeachingDesktop.TeacherPanel();
            this.subjectPanel1 = new SimplyTeachingDesktop.SubjectPanel();
            this.BtnBack = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdd)).BeginInit();
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
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.AllowUserToOrderColumns = true;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre});
            this.dataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dataTable.Location = new System.Drawing.Point(9, 32);
            this.dataTable.Margin = new System.Windows.Forms.Padding(2);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.Size = new System.Drawing.Size(471, 543);
            this.dataTable.TabIndex = 3;
            // 
            // LbSimplyTeaching
            // 
            this.LbSimplyTeaching.AutoSize = true;
            this.LbSimplyTeaching.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSimplyTeaching.ForeColor = System.Drawing.Color.White;
            this.LbSimplyTeaching.Location = new System.Drawing.Point(30, 9);
            this.LbSimplyTeaching.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbSimplyTeaching.Name = "LbSimplyTeaching";
            this.LbSimplyTeaching.Size = new System.Drawing.Size(91, 13);
            this.LbSimplyTeaching.TabIndex = 6;
            this.LbSimplyTeaching.Text = "Simply Teaching";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(489, 32);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(22, 24);
            this.BtnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnEdit.TabIndex = 7;
            this.BtnEdit.TabStop = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(489, 551);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(22, 24);
            this.BtnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.TabStop = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LbEntity
            // 
            this.LbEntity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbEntity.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEntity.ForeColor = System.Drawing.Color.White;
            this.LbEntity.Location = new System.Drawing.Point(532, 32);
            this.LbEntity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbEntity.Name = "LbEntity";
            this.LbEntity.Size = new System.Drawing.Size(375, 98);
            this.LbEntity.TabIndex = 9;
            this.LbEntity.Text = "Profesores";
            this.LbEntity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnAlumnos
            // 
            this.BtnAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BtnAlumnos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlumnos.ForeColor = System.Drawing.Color.White;
            this.BtnAlumnos.Location = new System.Drawing.Point(840, 552);
            this.BtnAlumnos.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAlumnos.Name = "BtnAlumnos";
            this.BtnAlumnos.Size = new System.Drawing.Size(120, 32);
            this.BtnAlumnos.TabIndex = 10;
            this.BtnAlumnos.Text = "Alumnos";
            this.BtnAlumnos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAlumnos.Click += new System.EventHandler(this.BtnAlumnos_Click);
            this.BtnAlumnos.MouseLeave += new System.EventHandler(this.LabelButton_MouseLeave);
            this.BtnAlumnos.MouseHover += new System.EventHandler(this.LabelButton_MouseHover);
            // 
            // BtnAsignaturas
            // 
            this.BtnAsignaturas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAsignaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BtnAsignaturas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsignaturas.ForeColor = System.Drawing.Color.White;
            this.BtnAsignaturas.Location = new System.Drawing.Point(720, 552);
            this.BtnAsignaturas.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAsignaturas.Name = "BtnAsignaturas";
            this.BtnAsignaturas.Size = new System.Drawing.Size(120, 32);
            this.BtnAsignaturas.TabIndex = 11;
            this.BtnAsignaturas.Text = "Asignaturas";
            this.BtnAsignaturas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAsignaturas.Click += new System.EventHandler(this.BtnAsignaturas_Click);
            this.BtnAsignaturas.MouseLeave += new System.EventHandler(this.LabelButton_MouseLeave);
            this.BtnAsignaturas.MouseHover += new System.EventHandler(this.LabelButton_MouseHover);
            // 
            // BtnProfesores
            // 
            this.BtnProfesores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnProfesores.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfesores.ForeColor = System.Drawing.Color.White;
            this.BtnProfesores.Location = new System.Drawing.Point(600, 552);
            this.BtnProfesores.Margin = new System.Windows.Forms.Padding(0);
            this.BtnProfesores.Name = "BtnProfesores";
            this.BtnProfesores.Size = new System.Drawing.Size(120, 32);
            this.BtnProfesores.TabIndex = 12;
            this.BtnProfesores.Text = "Profesores";
            this.BtnProfesores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProfesores.Click += new System.EventHandler(this.BtnProfesores_Click);
            this.BtnProfesores.MouseLeave += new System.EventHandler(this.LabelButton_MouseLeave);
            this.BtnProfesores.MouseHover += new System.EventHandler(this.LabelButton_MouseHover);
            // 
            // studentsPanel1
            // 
            this.studentsPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.studentsPanel1.Location = new System.Drawing.Point(490, 101);
            this.studentsPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentsPanel1.Name = "studentsPanel1";
            this.studentsPanel1.Size = new System.Drawing.Size(461, 447);
            this.studentsPanel1.TabIndex = 14;
            // 
            // teacherPanel1
            // 
            this.teacherPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.teacherPanel1.AutoSize = true;
            this.teacherPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.teacherPanel1.Location = new System.Drawing.Point(490, 101);
            this.teacherPanel1.MinimumSize = new System.Drawing.Size(461, 447);
            this.teacherPanel1.Name = "teacherPanel1";
            this.teacherPanel1.Size = new System.Drawing.Size(461, 447);
            this.teacherPanel1.TabIndex = 13;
            // 
            // subjectPanel1
            // 
            this.subjectPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.subjectPanel1.Location = new System.Drawing.Point(490, 101);
            this.subjectPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subjectPanel1.Name = "subjectPanel1";
            this.subjectPanel1.Size = new System.Drawing.Size(461, 447);
            this.subjectPanel1.TabIndex = 15;
            // 
            // BtnBack
            // 
            this.BtnBack.AutoSize = true;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(5, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(20, 25);
            this.BtnBack.TabIndex = 16;
            this.BtnBack.Text = "❮";
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnProfesores);
            this.Controls.Add(this.BtnAsignaturas);
            this.Controls.Add(this.BtnAlumnos);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.LbSimplyTeaching);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.LbEntity);
            this.Controls.Add(this.subjectPanel1);
            this.Controls.Add(this.studentsPanel1);
            this.Controls.Add(this.teacherPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.MinimumSize = new System.Drawing.Size(960, 585);
            this.Name = "TableView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeachersView";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.Controls.SetChildIndex(this.teacherPanel1, 0);
            this.Controls.SetChildIndex(this.studentsPanel1, 0);
            this.Controls.SetChildIndex(this.subjectPanel1, 0);
            this.Controls.SetChildIndex(this.LbEntity, 0);
            this.Controls.SetChildIndex(this.dataTable, 0);
            this.Controls.SetChildIndex(this.LbSimplyTeaching, 0);
            this.Controls.SetChildIndex(this.BtnEdit, 0);
            this.Controls.SetChildIndex(this.BtnAdd, 0);
            this.Controls.SetChildIndex(this.BtnAlumnos, 0);
            this.Controls.SetChildIndex(this.BtnAsignaturas, 0);
            this.Controls.SetChildIndex(this.BtnProfesores, 0);
            this.Controls.SetChildIndex(this.BtnMinimize, 0);
            this.Controls.SetChildIndex(this.BtnMaximize, 0);
            this.Controls.SetChildIndex(this.BtnExit, 0);
            this.Controls.SetChildIndex(this.BtnBack, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.DataGridView dataTable;
        protected System.Windows.Forms.Label LbSimplyTeaching;
        protected System.Windows.Forms.PictureBox BtnEdit;
        protected System.Windows.Forms.PictureBox BtnAdd;
        protected System.Windows.Forms.Label LbEntity;
        protected System.Windows.Forms.Label BtnAlumnos;
        protected System.Windows.Forms.Label BtnAsignaturas;
        protected System.Windows.Forms.Label BtnProfesores;
        private TeacherPanel teacherPanel1;
        private StudentsPanel studentsPanel1;
        private SubjectPanel subjectPanel1;
        private System.Windows.Forms.Label BtnBack;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
    }
}