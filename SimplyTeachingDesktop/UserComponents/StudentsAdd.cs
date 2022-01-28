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
            this.BackColor = EnvironmentVars.color6;
            LbID.ForeColor = EnvironmentVars.color1;
            LbName.ForeColor = EnvironmentVars.color1;
            LbLastName1.ForeColor = EnvironmentVars.color1;
            LbLastName2.ForeColor = EnvironmentVars.color1;
            LbTel1.ForeColor = EnvironmentVars.color1;
            LbTel2.ForeColor = EnvironmentVars.color1;
            LbEmail.ForeColor = EnvironmentVars.color1;
            LbTutor.ForeColor = EnvironmentVars.color1;
            TbID.BackColor = EnvironmentVars.color7;
            TbID.ForeColor = EnvironmentVars.color1;
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
