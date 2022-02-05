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
    public partial class SubjectPanel : UserControl
    {
        public SubjectPanel()
        {
            InitializeComponent();
            BackColor = EnvironmentVars.color6;
        }

        public void SetTheme()
        {
            LbDia.ForeColor = EnvironmentVars.color1;
            LbHora.ForeColor = EnvironmentVars.color1;
            TbDia.ForeColor = EnvironmentVars.color1;
            TbHora.ForeColor = EnvironmentVars.color1;
            TbDia.BackColor = EnvironmentVars.color7;
            TbHora.BackColor = EnvironmentVars.color7;
        }
    }
}
