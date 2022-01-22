using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimplyTeachingDesktop
{
    public partial class TableView : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private int type = 0;
        private Color backColor;
        public TableView()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            dataTable.Width = this.Width / 2 - 10;
            dataTable.Height = this.Height - 45;
            dataTable.Columns[0].Width = dataTable.Width - 1;
            LbEntity.Location = new Point((this.Width/4)*3 - LbEntity.Width / 2, 30);
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            } else if(this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            DgvTeachers_Initcialize();
            LbEntity.Location = new Point((this.Width / 4) * 3 - LbEntity.Width / 2, 30);
        }
        private void DgvTeachers_Initcialize()
        {
            dataTable.Width = this.Width / 2 - 10;
            dataTable.Height = this.Height - 45;
            dataTable.BackgroundColor = Color.FromArgb(255, 44, 44, 44);
            dataTable.BorderStyle = BorderStyle.None;
            dataTable.Width = this.Width / 2 - 12;
            dataTable.Height = this.Height - 40;
            dataTable.Columns[0].Width = dataTable.Width -1;
            dataTable.EnableHeadersVisualStyles = false;
            dataTable.RowHeadersVisible = false;
            dataTable.ColumnHeadersVisible = false;
            dataTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataTable.Font = new Font(dataTable.Font, FontStyle.Bold);
            dataTable.DefaultCellStyle.Font = new Font("Segoe UI", 15);
            dataTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataTable.DefaultCellStyle.BackColor = Color.FromArgb(255, 44, 44, 44);
            dataTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 84, 84, 84);
            dataTable.DefaultCellStyle.ForeColor = Color.White;
            dataTable.DefaultCellStyle.SelectionForeColor = Color.White;
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
                    dgvr.DefaultCellStyle.BackColor = Color.FromArgb(255, 54, 54, 54);
                }
                dgvr.Height = 40;
                dgvr.Resizable = DataGridViewTriState.False;
                i++;
            }
        }

        private void LabelButton_MouseHover(object sender, EventArgs e)
        {
            backColor = ((Label)sender).BackColor;
            ((Label)sender).BackColor = Color.FromArgb(255, 74, 74, 74);
        }

        private void LabelButton_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = backColor;
        }

        private void LabelButton_MouseClick(object sender, MouseEventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(255, 64, 64, 64);
            backColor = ((Label)sender).BackColor;
        }

        private void BtnAsignaturas_Click(object sender, EventArgs e)
        {
            BtnAsignaturas.BackColor = Color.FromArgb(255, 64, 64, 64);
            BtnProfesores.BackColor = Color.FromArgb(255, 84, 84, 84);
            BtnAlumnos.BackColor = Color.FromArgb(255, 84, 84, 84);
            backColor = ((Label)sender).BackColor;
            LbEntity.Text = "Asignaturas";
            type = 1;
        }

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            BtnAsignaturas.BackColor = Color.FromArgb(255, 84, 84, 84);
            BtnProfesores.BackColor = Color.FromArgb(255, 84, 84, 84);
            BtnAlumnos.BackColor = Color.FromArgb(255, 64, 64, 64);
            backColor = ((Label)sender).BackColor;
            LbEntity.Text = "Alumnos";
            type = 2;
        }

        private void BtnProfesores_Click(object sender, EventArgs e)
        {
            BtnAsignaturas.BackColor = Color.FromArgb(255, 84, 84, 84);
            BtnProfesores.BackColor = Color.FromArgb(255, 64, 64, 64);
            BtnAlumnos.BackColor = Color.FromArgb(255, 84, 84, 84);
            backColor = ((Label)sender).BackColor;
            LbEntity.Text = "Profesores";
            type = 0;
        }
    }
}
