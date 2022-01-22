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
    public partial class StudentsView : TeachersView
    {
        public StudentsView()
        {
            InitializeComponent();
        }

        private void BtnProfesores_Click(object sender, EventArgs e)
        {
            TeachersView form = new TeachersView();
            form.Show();
            this.Close();
        }
    }
}
