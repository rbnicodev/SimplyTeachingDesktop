using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SimplyTeachingDesktop
{
    public partial class TableView : UserForm
    {
        private int type = 0;
        private Color backColor;
        private DataController controller = ControllerBuilder.GetController();
        public TableView()
        {

            InitializeComponent();
            this.CenterToScreen();
            studentsPanel1.Visible = false;
            subjectPanel1.Visible = false;
            teacherPanel1.Visible = true;
            setTheme();
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
            dataTable.BackgroundColor = EnvironmentVars.color6;
            dataTable.BorderStyle = BorderStyle.None;
            dataTable.Width = this.Width / 2 - 12;
            dataTable.Height = this.Height - 40;
            dataTable.Columns[1].Width = dataTable.Width - dataTable.Columns[0].Width -2;
            dataTable.EnableHeadersVisualStyles = false;
            dataTable.RowHeadersVisible = false;
            dataTable.ColumnHeadersVisible = false;
            dataTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataTable.Font = new Font(dataTable.Font, FontStyle.Bold);
            dataTable.DefaultCellStyle.Font = new Font("Segoe UI", 15);
            dataTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataTable.DefaultCellStyle.BackColor = EnvironmentVars.color6;
            dataTable.DefaultCellStyle.SelectionBackColor = EnvironmentVars.color2;
            dataTable.DefaultCellStyle.ForeColor = EnvironmentVars.color1;
            dataTable.DefaultCellStyle.SelectionForeColor = EnvironmentVars.color1;
            dataTable.Rows.Clear();
            dataTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ReloadTable();


            int i = 2;
            foreach (DataGridViewRow dgvr in dataTable.Rows)
            {
                if ((i % 2) == 0)
                {
                    dgvr.DefaultCellStyle.BackColor = EnvironmentVars.color5;
                }
                dgvr.Height = 40;
                dgvr.Resizable = DataGridViewTriState.False;
                i++;
            }
        }

        private void LabelButton_MouseHover(object sender, EventArgs e)
        {
            backColor = ((Label)sender).BackColor;
            ((Label)sender).BackColor = EnvironmentVars.color4;
        }

        private void LabelButton_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = backColor;
        }

        private void LabelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ((Label)sender).BackColor = EnvironmentVars.color6;
            backColor = ((Label)sender).BackColor;
        }

        private void BtnProfesores_Click(object sender, EventArgs e)
        {
            BtnAsignaturas.BackColor = EnvironmentVars.color5;
            BtnProfesores.BackColor = EnvironmentVars.color6;
            BtnAlumnos.BackColor = EnvironmentVars.color5;
            backColor = ((Label)sender).BackColor;
            LbEntity.Text = "Profesores";
            type = 0;
            ReloadTable();
            teacherPanel1.Visible = true;
            studentsPanel1.Visible = false;
            subjectPanel1.Visible = false;
        }

        private void BtnAsignaturas_Click(object sender, EventArgs e)
        {
            BtnAsignaturas.BackColor = EnvironmentVars.color6;
            BtnProfesores.BackColor = EnvironmentVars.color5;
            BtnAlumnos.BackColor = EnvironmentVars.color5;
            backColor = ((Label)sender).BackColor;
            LbEntity.Text = "Asignaturas";
            type = 1;
            studentsPanel1.Visible = false;
            teacherPanel1.Visible = false;
            subjectPanel1.Visible = true;
        }

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            BtnAsignaturas.BackColor = EnvironmentVars.color5;
            BtnProfesores.BackColor = EnvironmentVars.color5;
            BtnAlumnos.BackColor = EnvironmentVars.color6;
            backColor = ((Label)sender).BackColor;
            LbEntity.Text = "Alumnos";
            type = 2;
            studentsPanel1.Visible = true;
            teacherPanel1.Visible = false;
            subjectPanel1.Visible = false;
        }

        

        

        private void ReloadTable()
        {
            dataTable.Rows.Clear();
            string[][] rows = null;
            if (type == 0)
            {
                rows = controller.TeachersTable();
                if(rows != null)
                {
                    for (int i = 0; i < rows.Length; i++)
                    {
                        dataTable.Rows.Add(rows[i]);
                    }
                }
            }
            else if (type == 1)
            {
                dataTable.Rows.Add(controller.SubjectsTable());
            } else if (type == 2)
            {
                dataTable.Rows.Add(controller.StudentsTable());
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new LoginView().ShowDialog();
        }
        private void setTheme()
        {
            dataTable_Initcialize();
            this.BackColor = EnvironmentVars.color6;
            LbEntity.ForeColor = EnvironmentVars.color1;
            LbSimplyTeaching.ForeColor = EnvironmentVars.color1;

            Bitmap image2 = null;
            if (EnvironmentVars.night)
            {
                image2 = new Bitmap("images/add-night.png");
            }
            else
            {
                image2 = new Bitmap("images/add-day.png");
            }
            this.BtnAdd.Dock = DockStyle.None;
            this.BtnAdd.Image = (Image)image2;
            image2 = null;

            Bitmap image = null;
            if (EnvironmentVars.night)
            {
                image = new Bitmap("images/edit-night.png");
            }
            else
            {
                image = new Bitmap("images/edit-day.png");
            }
            this.BtnEdit.Dock = DockStyle.None;
            this.BtnEdit.Image = (Image)image;
            image = null;

            BtnAlumnos.ForeColor = EnvironmentVars.color1;
            BtnAlumnos.BackColor = EnvironmentVars.color5;
            BtnProfesores.ForeColor = EnvironmentVars.color1;
            BtnProfesores.BackColor = EnvironmentVars.color6;
            BtnAsignaturas.ForeColor = EnvironmentVars.color1;
            BtnAsignaturas.BackColor = EnvironmentVars.color5;
            BtnBack.ForeColor = EnvironmentVars.color1;
            BtnMaximize.ForeColor = EnvironmentVars.color1;
            BtnExit.ForeColor = EnvironmentVars.color1;
            BtnMinimize.ForeColor = EnvironmentVars.color1;

            studentsPanel1.BackColor = EnvironmentVars.color6;
            teacherPanel1.BackColor = EnvironmentVars.color6;
            subjectPanel1.BackColor = EnvironmentVars.color6;
            dataTable.GridColor = EnvironmentVars.color2;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddEditForm addEditForm = new AddEditForm();
            this.Visible = false;
            if (addEditForm.ShowDialog() == DialogResult.OK)
            {
                ReloadTable();
            }
            else
            {
                this.Visible = true;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataTable.SelectedRows[0].Cells[1].Value.ToString();
                AddEditForm addEditForm = new AddEditForm(type, id);
                this.Visible = false;
                if (addEditForm.ShowDialog() == DialogResult.OK)
                {
                    ReloadTable();
                }
                else
                {
                    this.Visible = true;
                }
            }catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("No hay fila seleccionada o no es válida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
