﻿using System;
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
        private int type, id = -1;
        private DataController controller;
        private string[] entity;

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

        public AddEditForm(int type, string id)
        {
            this.type = type;
            this.id = int.Parse(id);
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            controller = ControllerBuilder.GetController();
            if (id < 0) BtnDelete.Enabled = false;
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
            BtnSave.ForeColor = EnvironmentVars.color1;
            BtnSave.BackColor = EnvironmentVars.color2;
            BtnDelete.ForeColor = EnvironmentVars.color1;
            BtnDelete.BackColor = EnvironmentVars.color2;
            BtnSave2.ForeColor = EnvironmentVars.color1;
            BtnSave2.BackColor = EnvironmentVars.color2;
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
            if (id >= 0)
            {
                entity = controller.FindTeacher(id.ToString());
                teachersAdd1.TbID.Text = entity[0];
                teachersAdd1.TbDNI.Text = entity[1];
                teachersAdd1.TbName.Text = entity[2];
                teachersAdd1.TbLastname1.Text = entity[3];
                teachersAdd1.TbLastName2.Text = entity[4];
                teachersAdd1.TbDir.Text = entity[5];
                teachersAdd1.TbSegSocial.Text = entity[6];
                teachersAdd1.TbTel1.Text = entity[7];
                teachersAdd1.TbTel2.Text = entity[8];
                teachersAdd1.TbEmail.Text = entity[9];
            }
        }
        private void addSubject()
        {
            
            LbEntity.Text = "Asignatura";
            teachersAdd1.Visible = false;
            subjectsAdd1.Visible = true;
            studentsAdd1.Visible = false;
            this.Width = 500;
            subjectsAdd1.Location = new Point(this.Width / 2 - subjectsAdd1.Width / 2, 90);
            BtnCancel.Location = new Point(50, 520);
            BtnDelete.Location = new Point(375, 520);
            BtnSave.Location = new Point(145, 520);
            BtnSave2.Location = new Point(255, 520);

            if(id >= 0)
            {
                entity = controller.FindSubject(id.ToString());
                subjectsAdd1.TbID.Text = entity[0];
                subjectsAdd1.TbName.Text = entity[1];
                Console.WriteLine(entity[2]);
                subjectsAdd1.selectHour1.TbH.Text = (int.Parse(entity[2].Replace(":", "").Replace("h", "")) / 100).ToString();
                subjectsAdd1.selectHour1.TbMin.Text = (int.Parse(entity[2].Replace(":", "").Replace("h", "")) % 100).ToString();
                subjectsAdd1.CbDay.Text = entity[3];
                subjectsAdd1.TbPrice.Text = entity[4];
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            bool result = false;
            if(MessageBox.Show("¿Estás seguro de querer borrar este registro?", "Borrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                switch (type)
                {
                    case 0: result = controller.DeleteTeacher(teachersAdd1.TbID.Text); break;
                    case 1: result = controller.DeleteSubject(subjectsAdd1.TbID.Text); break;
                    case 2: result = controller.DeleteStudent(studentsAdd1.TbID.Text); break;
                    default: break;
                }

                if (!result) MessageBox.Show("Ha habido un problema al borrar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else DialogResult = DialogResult.OK;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool result = false;
            switch(type)
            {
                case 0: result = saveTeacher(); break;
                case 1: result = saveSubject(); break;
                case 2: result = saveStudent(); break;
                default:;break;
            }
            if(result) this.DialogResult = DialogResult.OK;
            else MessageBox.Show("Parece que ha habido un error al intentar guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool saveTeacher() { return false; }
        private bool saveSubject() 
        {
            string[] subject = new string[5];

            subject[0] = subjectsAdd1.TbID.Text.Trim();
            subject[1] = subjectsAdd1.TbName.Text.Trim();
            subject[2] = subjectsAdd1.selectHour1.TbH.Text + subjectsAdd1.selectHour1.TbMin.Text;
            subject[3] = (subjectsAdd1.CbDay.SelectedIndex + 1).ToString();
            subject[4] = subjectsAdd1.TbPrice.Text.Trim();
            for(int i = 0; i < subject.Length; i++)
            {
                Console.WriteLine(subject[i]);
            }
            return controller.SaveSubject(subject);

        }
        private bool saveStudent() { return true; }

        private void addStudent()
        {
            
            LbEntity.Text = "Alumno";
            teachersAdd1.Visible = false;
            subjectsAdd1.Visible = false;
            studentsAdd1.Visible = true;
            studentsAdd1.CbTutor.Items.Clear();
            List<string> teachers = controller.FindAllTeachers();
            foreach(string teacher in teachers)
            {
                studentsAdd1.CbTutor.Items.Add(teacher);
            }
            if (id >= 0)
            {
                entity = controller.FindStudent(id.ToString());
                studentsAdd1.TbID.Text = entity[0];
                studentsAdd1.TbName.Text = entity[1];
                studentsAdd1.TbLastname1.Text = entity[2];
                studentsAdd1.TbLastName2.Text = entity[3];
                studentsAdd1.TbDir.Text = entity[4];
                studentsAdd1.TbTel1.Text = entity[5];
                studentsAdd1.TbTel2.Text = entity[6];
                studentsAdd1.TbEmail.Text = entity[7];
                studentsAdd1.CbTutor.Text = entity[8];
            }
        }
    }
}
