using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyTeachingDesktop.UserComponents
{
    public partial class StudentsAdd : UserControl
    {
        public StudentsAdd()
        {
            InitializeComponent();
            setTheme();
        }
        public void setTheme()
        {
            this.BackColor = EnvironmentVars.color5;
            LbID.ForeColor = EnvironmentVars.color1;
            LbName.ForeColor = EnvironmentVars.color1;
            LbLastName1.ForeColor = EnvironmentVars.color1;
            LbLastName2.ForeColor = EnvironmentVars.color1;
            LbTel1.ForeColor = EnvironmentVars.color1;
            LbTel2.ForeColor = EnvironmentVars.color1;
            LbEmail.ForeColor = EnvironmentVars.color1;
            LbTutor.ForeColor = EnvironmentVars.color1;
            LbPostAddress.ForeColor = EnvironmentVars.color1;
            TbID.BackColor = EnvironmentVars.color7;
            TbID.ForeColor = EnvironmentVars.color1;
            TbName.BackColor = EnvironmentVars.color7;
            TbName.ForeColor = EnvironmentVars.color1;
            TbLastname1.BackColor = EnvironmentVars.color7;
            TbLastname1.ForeColor = EnvironmentVars.color1;
            TbLastName2.ForeColor = EnvironmentVars.color1;
            TbLastName2.BackColor = EnvironmentVars.color7;
            TbDir.ForeColor = EnvironmentVars.color1;
            TbDir.BackColor = EnvironmentVars.color7;
            TbTel1.ForeColor = EnvironmentVars.color1;
            TbTel1.BackColor = EnvironmentVars.color7;
            TbTel2.ForeColor = EnvironmentVars.color1;
            TbTel2.BackColor = EnvironmentVars.color7;
            TbEmail.ForeColor = EnvironmentVars.color1;
            TbEmail.BackColor = EnvironmentVars.color7;
            CbTutor.ForeColor = EnvironmentVars.color1;
            CbTutor.BackColor = EnvironmentVars.color7;
        }
    }
}
