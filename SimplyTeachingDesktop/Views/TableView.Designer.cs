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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LbSimplyTeaching = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.PictureBox();
            this.BtnAdd = new System.Windows.Forms.PictureBox();
            this.LbEntity = new System.Windows.Forms.Label();
            this.studentsPanel1 = new SimplyTeachingDesktop.StudentsPanel();
            this.subjectPanel1 = new SimplyTeachingDesktop.SubjectPanel();
            this.BtnBack = new System.Windows.Forms.Label();
            this.BtnProfesores = new System.Windows.Forms.Button();
            this.BtnAsignaturas = new System.Windows.Forms.Button();
            this.BtnAlumnos = new System.Windows.Forms.Button();
            this.teacherPanel1 = new SimplyTeachingDesktop.TeacherPanel();
            this.HelpPanel = new System.Windows.Forms.Panel();
            this.LbHelp = new System.Windows.Forms.Label();
            this.BtnHelpAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdd)).BeginInit();
            this.HelpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHelpAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BtnMinimize.Location = new System.Drawing.Point(870, 0);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BtnMaximize.Location = new System.Drawing.Point(900, 0);
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.Location = new System.Drawing.Point(930, 0);
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
            this.dataTable.Location = new System.Drawing.Point(9, 132);
            this.dataTable.Margin = new System.Windows.Forms.Padding(2);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 24;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTable.Size = new System.Drawing.Size(471, 443);
            this.dataTable.TabIndex = 3;
            this.dataTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataTable_CellMouseClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
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
            this.BtnEdit.Location = new System.Drawing.Point(818, 532);
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
            this.BtnAdd.Location = new System.Drawing.Point(636, 532);
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
            this.LbEntity.Location = new System.Drawing.Point(53, 32);
            this.LbEntity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbEntity.Name = "LbEntity";
            this.LbEntity.Size = new System.Drawing.Size(375, 98);
            this.LbEntity.TabIndex = 9;
            this.LbEntity.Text = "Profesores";
            this.LbEntity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // studentsPanel1
            // 
            this.studentsPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.studentsPanel1.Location = new System.Drawing.Point(500, 83);
            this.studentsPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.studentsPanel1.Name = "studentsPanel1";
            this.studentsPanel1.Size = new System.Drawing.Size(450, 447);
            this.studentsPanel1.TabIndex = 14;
            // 
            // subjectPanel1
            // 
            this.subjectPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.subjectPanel1.Location = new System.Drawing.Point(500, 61);
            this.subjectPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subjectPanel1.Name = "subjectPanel1";
            this.subjectPanel1.Size = new System.Drawing.Size(440, 447);
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
            // BtnProfesores
            // 
            this.BtnProfesores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnProfesores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnProfesores.FlatAppearance.BorderSize = 0;
            this.BtnProfesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProfesores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProfesores.ForeColor = System.Drawing.Color.White;
            this.BtnProfesores.Location = new System.Drawing.Point(600, 32);
            this.BtnProfesores.Margin = new System.Windows.Forms.Padding(0);
            this.BtnProfesores.Name = "BtnProfesores";
            this.BtnProfesores.Size = new System.Drawing.Size(120, 32);
            this.BtnProfesores.TabIndex = 17;
            this.BtnProfesores.Text = "Profesores";
            this.BtnProfesores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProfesores.UseVisualStyleBackColor = true;
            this.BtnProfesores.Click += new System.EventHandler(this.BtnProfesores_Click);
            // 
            // BtnAsignaturas
            // 
            this.BtnAsignaturas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAsignaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BtnAsignaturas.FlatAppearance.BorderSize = 0;
            this.BtnAsignaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAsignaturas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnAsignaturas.ForeColor = System.Drawing.Color.White;
            this.BtnAsignaturas.Location = new System.Drawing.Point(720, 32);
            this.BtnAsignaturas.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAsignaturas.Name = "BtnAsignaturas";
            this.BtnAsignaturas.Size = new System.Drawing.Size(120, 32);
            this.BtnAsignaturas.TabIndex = 11;
            this.BtnAsignaturas.Text = "Asignaturas";
            this.BtnAsignaturas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAsignaturas.UseVisualStyleBackColor = false;
            this.BtnAsignaturas.Click += new System.EventHandler(this.BtnAsignaturas_Click);
            // 
            // BtnAlumnos
            // 
            this.BtnAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.BtnAlumnos.FlatAppearance.BorderSize = 0;
            this.BtnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlumnos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnAlumnos.ForeColor = System.Drawing.Color.White;
            this.BtnAlumnos.Location = new System.Drawing.Point(840, 32);
            this.BtnAlumnos.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAlumnos.Name = "BtnAlumnos";
            this.BtnAlumnos.Size = new System.Drawing.Size(120, 32);
            this.BtnAlumnos.TabIndex = 19;
            this.BtnAlumnos.Text = "Alumnos";
            this.BtnAlumnos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAlumnos.UseVisualStyleBackColor = true;
            this.BtnAlumnos.Click += new System.EventHandler(this.BtnAlumnos_Click);
            // 
            // teacherPanel1
            // 
            this.teacherPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.teacherPanel1.AutoSize = true;
            this.teacherPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.teacherPanel1.Location = new System.Drawing.Point(487, 65);
            this.teacherPanel1.MinimumSize = new System.Drawing.Size(461, 447);
            this.teacherPanel1.Name = "teacherPanel1";
            this.teacherPanel1.Size = new System.Drawing.Size(461, 447);
            this.teacherPanel1.TabIndex = 13;
            // 
            // HelpPanel
            // 
            this.HelpPanel.Controls.Add(this.LbHelp);
            this.HelpPanel.Controls.Add(this.BtnHelpAdd);
            this.HelpPanel.Location = new System.Drawing.Point(32, 292);
            this.HelpPanel.Name = "HelpPanel";
            this.HelpPanel.Size = new System.Drawing.Size(396, 95);
            this.HelpPanel.TabIndex = 20;
            this.HelpPanel.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LbHelp
            // 
            this.LbHelp.AutoSize = true;
            this.LbHelp.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHelp.ForeColor = System.Drawing.Color.White;
            this.LbHelp.Location = new System.Drawing.Point(96, 30);
            this.LbHelp.Name = "LbHelp";
            this.LbHelp.Size = new System.Drawing.Size(220, 37);
            this.LbHelp.TabIndex = 10;
            this.LbHelp.Text = "Añadir Profesor";
            this.LbHelp.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnHelpAdd
            // 
            this.BtnHelpAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnHelpAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnHelpAdd.Image")));
            this.BtnHelpAdd.Location = new System.Drawing.Point(19, 17);
            this.BtnHelpAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHelpAdd.Name = "BtnHelpAdd";
            this.BtnHelpAdd.Size = new System.Drawing.Size(57, 59);
            this.BtnHelpAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHelpAdd.TabIndex = 9;
            this.BtnHelpAdd.TabStop = false;
            this.BtnHelpAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.HelpPanel);
            this.Controls.Add(this.BtnAlumnos);
            this.Controls.Add(this.BtnAsignaturas);
            this.Controls.Add(this.BtnProfesores);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.LbSimplyTeaching);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.LbEntity);
            this.Controls.Add(this.studentsPanel1);
            this.Controls.Add(this.subjectPanel1);
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
            this.Controls.SetChildIndex(this.subjectPanel1, 0);
            this.Controls.SetChildIndex(this.studentsPanel1, 0);
            this.Controls.SetChildIndex(this.LbEntity, 0);
            this.Controls.SetChildIndex(this.dataTable, 0);
            this.Controls.SetChildIndex(this.LbSimplyTeaching, 0);
            this.Controls.SetChildIndex(this.BtnEdit, 0);
            this.Controls.SetChildIndex(this.BtnAdd, 0);
            this.Controls.SetChildIndex(this.BtnBack, 0);
            this.Controls.SetChildIndex(this.BtnProfesores, 0);
            this.Controls.SetChildIndex(this.BtnAsignaturas, 0);
            this.Controls.SetChildIndex(this.BtnAlumnos, 0);
            this.Controls.SetChildIndex(this.BtnMinimize, 0);
            this.Controls.SetChildIndex(this.BtnMaximize, 0);
            this.Controls.SetChildIndex(this.BtnExit, 0);
            this.Controls.SetChildIndex(this.HelpPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdd)).EndInit();
            this.HelpPanel.ResumeLayout(false);
            this.HelpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHelpAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.DataGridView dataTable;
        protected System.Windows.Forms.Label LbSimplyTeaching;
        protected System.Windows.Forms.PictureBox BtnEdit;
        protected System.Windows.Forms.PictureBox BtnAdd;
        protected System.Windows.Forms.Label LbEntity;
        private StudentsPanel studentsPanel1;
        private SubjectPanel subjectPanel1;
        private System.Windows.Forms.Label BtnBack;
        private Button BtnProfesores;
        private Button BtnAsignaturas;
        private Button BtnAlumnos;
        private TeacherPanel teacherPanel1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private Panel HelpPanel;
        private Label LbHelp;
        protected PictureBox BtnHelpAdd;
    }
}