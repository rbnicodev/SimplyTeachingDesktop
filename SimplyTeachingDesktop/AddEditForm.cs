using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
    internal class AddEditForm : UserForm
    {
        protected override void BtnExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
