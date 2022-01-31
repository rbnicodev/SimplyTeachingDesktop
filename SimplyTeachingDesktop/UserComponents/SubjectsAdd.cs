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
    public partial class SubjectsAdd : UserControl
    {
        public SubjectsAdd()
        {
            InitializeComponent();
            setTheme();
        }

        public void setTheme()
        {
            selectHour1.setTheme();
            LbDay.ForeColor = EnvironmentVars.color1;
            LbHour.ForeColor = EnvironmentVars.color1;
            LbID.ForeColor = EnvironmentVars.color1;
            LbName.ForeColor = EnvironmentVars.color1;
            LbPrice.ForeColor = EnvironmentVars.color1;
            TbID.ForeColor = EnvironmentVars.color1;
            TbName.ForeColor = EnvironmentVars.color1;
            TbPrice.ForeColor = EnvironmentVars.color1;
            TbID.BackColor = EnvironmentVars.color7;
            TbName.BackColor = EnvironmentVars.color7;
            TbPrice.BackColor = EnvironmentVars.color7;
            this.BackColor = EnvironmentVars.color5;
        }
    }
}
