using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyTeachingDesktop
{
    public partial class StudentsPanel : UserControl
    {
        public StudentsPanel()
        {
            InitializeComponent();
            this.BackColor = EnvironmentVars.color6;
            LbCurso.ForeColor = EnvironmentVars.color1;
            LbEmail.ForeColor = EnvironmentVars.color1;
            LbTel1.ForeColor = EnvironmentVars.color1;
            LbTel2.ForeColor = EnvironmentVars.color1;
            LbTutor.ForeColor = EnvironmentVars.color1;
            TbCurso.BackColor = EnvironmentVars.color7;
            TbEmail.BackColor = EnvironmentVars.color7;
            TbTel1.BackColor = EnvironmentVars.color7;
            TbTel2.BackColor = EnvironmentVars.color7;
            TbTutor.BackColor = EnvironmentVars.color7;
            TbCurso.ForeColor = EnvironmentVars.color1;
            TbEmail.ForeColor = EnvironmentVars.color1;
            TbTel1.ForeColor = EnvironmentVars.color1;
            TbTel2.ForeColor = EnvironmentVars.color1;
            TbTutor.ForeColor = EnvironmentVars.color1;
        }
    }
}
