using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
    internal class AddEditForm : UserForm
    {
        private UserComponents.StudentsAdd studentsAdd1;
        private int type;
        private DataController controller;
        private Button studentsave;
        private Button studentcancel;
        private Button studentdelete;

        private Button subjectsave;
        private Button subjectcancel;
        private Button subjectdelete;

        private Button teachersave;
        private Button teachercancel;
        private Button teacherdelete;

        public AddEditForm(int type) 
        {
            this.type = type;
            InitializeComponent();
            studentsAdd1.BtDelete.Enabled = false;
            init();

        }
        public AddEditForm(int type, string id)
        {
            this.type = type;
            InitializeComponent();
            init();

        }
        private void init()
        {
            BackColor = EnvironmentVars.color5;
            controller = ControllerBuilder.GetController();
            this.CenterToParent();
            if (type != 2)
                studentsAdd1.Visible = false;
            else studentsAdd1.Visible = true;
            studentsave = studentsAdd1.BtSave;
            studentcancel = studentsAdd1.BtCancel;
            studentdelete = studentsAdd1.BtDelete;
            studentsave.Click += new EventHandler(BtnStudentSave_Click);
            studentcancel.Click += new EventHandler(BtnCancel_Click);
            studentdelete.Click += new EventHandler(BtnStudentDelete_Click);
            List<string> teachers = new List<string>();
            teachers.Add("hola");
            studentsAdd1.CbTutor.DataSource = controller.FindAllTeachers();
        }
        protected override void BtnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void InitializeComponent()
        {
            this.studentsAdd1 = new SimplyTeachingDesktop.UserComponents.StudentsAdd();
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
            this.BtnMaximize.Enabled = false;
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BtnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // studentsAdd1
            // 
            this.studentsAdd1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsAdd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.studentsAdd1.Location = new System.Drawing.Point(12, 35);
            this.studentsAdd1.Name = "studentsAdd1";
            this.studentsAdd1.Size = new System.Drawing.Size(930, 535);
            this.studentsAdd1.TabIndex = 9;
            //this.studentsAdd1.BtSave.Click += new System.EventHandler(this.BtnStudentSave_Click);
            this.studentsAdd1.BackColor = EnvironmentVars.color5;
            this.studentsAdd1.LbID.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.LbName.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.LbLastName1.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.LbLastName2.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.LbPostAddress.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.LbTel1.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.LbTel2.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.LbEmail.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.LbTutor.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.TbID.BackColor = EnvironmentVars.color7;
            this.studentsAdd1.TbID.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.TbName.BackColor = EnvironmentVars.color7;
            this.studentsAdd1.TbName.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.TbLastname1.BackColor = EnvironmentVars.color7;
            this.studentsAdd1.TbLastname1.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.TbLastName2.BackColor = EnvironmentVars.color7;
            this.studentsAdd1.TbLastName2.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.TbDir.BackColor = EnvironmentVars.color7;
            this.studentsAdd1.TbDir.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.TbEmail.BackColor = EnvironmentVars.color7;
            this.studentsAdd1.TbEmail.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.TbTel1.BackColor = EnvironmentVars.color7;
            this.studentsAdd1.TbTel1.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.TbTel2.BackColor = EnvironmentVars.color7;
            this.studentsAdd1.TbTel2.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.CbTutor.BackColor = EnvironmentVars.color7;
            this.studentsAdd1.CbTutor.ForeColor = EnvironmentVars.color1;
            this.studentsAdd1.TbID.BackColor = EnvironmentVars.color7;
            this.studentsAdd1.TbID.ForeColor = EnvironmentVars.color1;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.studentsAdd1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximumSize = new System.Drawing.Size(960, 585);
            this.MinimumSize = new System.Drawing.Size(960, 585);
            this.Name = "AddEditForm";
            this.Controls.SetChildIndex(this.BtnMinimize, 0);
            this.Controls.SetChildIndex(this.BtnMaximize, 0);
            this.Controls.SetChildIndex(this.BtnExit, 0);
            this.Controls.SetChildIndex(this.studentsAdd1, 0);
            this.ResumeLayout(false);

        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }
        private void BtnStudentSave_Click(object sender, EventArgs e)
        {
            bool result = false;
            int tel, id;

            string[] student = new string[9];
            if (int.TryParse(studentsAdd1.TbID.Text.Replace(";", "").Trim(), out id))
                student[0] = id.ToString();
            else
            {
                MessageBox.Show("El ID no es correcto\nDebe ser un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            student[1] = studentsAdd1.TbName.Text.Replace(";", "").Trim();
            student[2] = studentsAdd1.TbLastname1.Text.Replace(";", "").Trim();
            student[3] = studentsAdd1.TbLastName2.Text.Replace(";", "").Trim();
            student[4] = studentsAdd1.TbDir.Text.Replace(";", "").Trim();
            if(int.TryParse(studentsAdd1.TbTel1.Text.Replace(";", "").Trim(), out tel) || studentsAdd1.TbTel1.Text == "")
                student[5] = tel.ToString();
            else
            {
                MessageBox.Show("El número de teléfono no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(studentsAdd1.TbTel2.Text.Replace(";", "").Trim(), out tel))
                student[6] = tel.ToString();
            else
            {
                MessageBox.Show("El número de teléfono no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            student[7] = studentsAdd1.CbTutor.Text.Replace(";", "").Trim();


            if(controller.SaveStudent(student))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
        private void BtnStudentDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(studentsAdd1.TbID.Text, out id))
                if (MessageBox.Show("¿Estás seguro de querer borrar este registro?", "Borrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    controller.DeleteStudent(studentsAdd1.TbID.Text);
                    DialogResult = DialogResult.OK;
                }
        }

    }
}
