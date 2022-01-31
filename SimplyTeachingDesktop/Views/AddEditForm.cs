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
            this.CenterToParent();
            SetTheme();
            this.BtnMaximize.Enabled = false;
            switch(type)
            {
                case 0: addTeacher(); break;
                case 1: addSubject(); break;
                case 2: addStudent(); break;
                default: addTeacher(); break;
            }
        }

        public void SetTheme()
        {
            this.BackColor = EnvironmentVars.color5;
            studentsAdd1.BackColor = EnvironmentVars.color5;
            teachersAdd1.BackColor = EnvironmentVars.color5;
            subjectsAdd1.BackColor = EnvironmentVars.color5;
        }

        private void addTeacher()
        {
            teachersAdd1.Visible = true;
            subjectsAdd1.Visible = false;
            studentsAdd1.Visible = false;
        }
        private void addSubject()
        {
            teachersAdd1.Visible = false;
            subjectsAdd1.Visible = true;
            studentsAdd1.Visible = false;
        }

        private void addStudent()
        {
            teachersAdd1.Visible = false;
            subjectsAdd1.Visible = false;
            studentsAdd1.Visible = true;
        }
    }
}
