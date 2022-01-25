using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplyTeachingDesktop
{
    public partial class TableView : UserForm
    {
        private int type = 0;
        private Color backColor;
        public TableView()
        {

            InitializeComponent();
            studentsPanel1.Visible = false;
            subjectPanel1.Visible = false;
            teacherPanel1.Visible = true;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            dataTable.Width = this.Width / 2 - 10;
            dataTable.Height = this.Height - 45;
            dataTable.Columns[0].Width = dataTable.Width - 1;
            LbEntity.Location = new Point((this.Width / 4) * 3 - LbEntity.Width / 2, 30);
            teacherPanel1.Location = new Point(this.Width * 640 / 1280, this.Height * 120 / 720);
            teacherPanel1.Width = this.Width * 615 / 1280;
            studentsPanel1.Location = new Point(this.Width * 640 / 1280, this.Height * 120 / 720);
            studentsPanel1.Width = this.Width * 615 / 1280;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            dataTable_Initcialize();
            LbEntity.Location = new Point((this.Width / 4) * 3 - LbEntity.Width / 2, 30);
        }
        private void dataTable_Initcialize()
        {
            dataTable.BorderStyle = BorderStyle.None;
            dataTable.Width = this.Width / 2 - 10;
            dataTable.Height = this.Height - 45;
            dataTable.BackgroundColor = EnviromentVars.color6;
            dataTable.BorderStyle = BorderStyle.None;
            dataTable.Width = this.Width / 2 - 12;
            dataTable.Height = this.Height - 40;
            dataTable.Columns[0].Width = dataTable.Width - 1;
            dataTable.EnableHeadersVisualStyles = false;
            dataTable.RowHeadersVisible = false;
            dataTable.ColumnHeadersVisible = false;
            dataTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataTable.Font = new Font(dataTable.Font, FontStyle.Bold);
            dataTable.DefaultCellStyle.Font = new Font("Segoe UI", 15);
            dataTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataTable.DefaultCellStyle.BackColor = EnviromentVars.color6;
            dataTable.DefaultCellStyle.SelectionBackColor = EnviromentVars.color2;
            dataTable.DefaultCellStyle.ForeColor = EnviromentVars.color1;
            dataTable.DefaultCellStyle.SelectionForeColor = EnviromentVars.color1;
            dataTable.Rows.Add("Jacinto");
            dataTable.Rows.Add("Eustaquio");
            dataTable.Rows.Add("Rigodolfo");
            dataTable.Rows.Add("Eneldo");
            dataTable.Rows.Add("Roberto");
            int i = 2;
            foreach (DataGridViewRow dgvr in dataTable.Rows)
            {
                if ((i % 2) == 0)
                {
                    dgvr.DefaultCellStyle.BackColor = EnviromentVars.color5;
                }
                dgvr.Height = 40;
                dgvr.Resizable = DataGridViewTriState.False;
                i++;
            }
        }

        private void LabelButton_MouseHover(object sender, EventArgs e)
        {
            backColor = ((Label)sender).BackColor;
            ((Label)sender).BackColor = EnviromentVars.color3;
        }

        private void LabelButton_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = backColor;
        }

        private void LabelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ((Label)sender).BackColor = EnviromentVars.color4;
            backColor = ((Label)sender).BackColor;
        }

        private void BtnAsignaturas_Click(object sender, EventArgs e)
        {
            BtnAsignaturas.BackColor = EnviromentVars.color4;
            BtnProfesores.BackColor = EnviromentVars.color2;
            BtnAlumnos.BackColor = EnviromentVars.color2;
            backColor = ((Label)sender).BackColor;
            LbEntity.Text = "Asignaturas";
            type = 1;
            studentsPanel1.Visible = false;
            teacherPanel1.Visible = false;
            subjectPanel1.Visible = true;
        }

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            BtnAsignaturas.BackColor = EnviromentVars.color2;
            BtnProfesores.BackColor = EnviromentVars.color2;
            BtnAlumnos.BackColor = EnviromentVars.color4;
            backColor = ((Label)sender).BackColor;
            LbEntity.Text = "Alumnos";
            type = 2;
            studentsPanel1.Visible = true;
            teacherPanel1.Visible = false;
            subjectPanel1.Visible = false;
        }

        private void BtnProfesores_Click(object sender, EventArgs e)
        {
            BtnAsignaturas.BackColor = EnviromentVars.color2;
            BtnProfesores.BackColor = EnviromentVars.color4;
            BtnAlumnos.BackColor = EnviromentVars.color2;
            backColor = ((Label)sender).BackColor;
            LbEntity.Text = "Profesores";
            type = 0;
            teacherPanel1.Visible = true;
            studentsPanel1.Visible = false;
            subjectPanel1.Visible = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddEditForm addEditForm = new AddEditForm();
            this.Visible = false;
            if(addEditForm.ShowDialog() == DialogResult.OK)
            {
                ReloadTable();
            } else
            {
                this.Visible = true;
            }
        }

        private void ReloadTable()
        {

        }

    }
}
