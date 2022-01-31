using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyTeachingDesktop.Views
{
    public partial class AddEditForm : UserForm
    {
        private int type;
        private TextBox field1, field2, field3, field4, field5, field6, field7, field8, field9, field10;

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        public AddEditForm(int type)
        {
            this.type = type;
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            
            switch(type)
            {
                case 0: addTeacher(); break;
                case 1: addSubject(); break;
                case 2: addStudent(); break;
                default: addTeacher(); break;
            }
            LbEntity.Location = new Point(this.Width / 2 - LbEntity.Width / 2, 26);
            this.CenterToParent();
            SetTheme();
            this.BtnMaximize.Visible = false;
            this.BtnExit.Visible = false;
            this.BtnMinimize.Visible = false;
            this.BtnCancel.DialogResult = DialogResult.Cancel;
        }

        public void SetTheme()
        {
            LbEntity.ForeColor = EnvironmentVars.color1;
            BtnCancel.ForeColor = EnvironmentVars.color1;
            BtnCancel.BackColor = EnvironmentVars.color2;
            this.BackColor = EnvironmentVars.color5;
            studentsAdd1.setTheme();
            subjectsAdd1.setTheme();
            teachersAdd1.setTheme();
        }

        private void addTeacher()
        {
            LbEntity.Text = "Profesor";
            teachersAdd1.Visible = true;
            subjectsAdd1.Visible = false;
            studentsAdd1.Visible = false;
        }
        private void addSubject()
        {
            LbEntity.Text = "Asignatura";
            teachersAdd1.Visible = false;
            subjectsAdd1.Visible = true;
            studentsAdd1.Visible = false;
            this.Width = 500;
            subjectsAdd1.Location = new Point(this.Width / 2 - subjectsAdd1.Width / 2, 90);
        }

        private void addStudent()
        {
            LbEntity.Text = "Alumno";
            teachersAdd1.Visible = false;
            subjectsAdd1.Visible = false;
            studentsAdd1.Visible = true;
        }
    }
}
