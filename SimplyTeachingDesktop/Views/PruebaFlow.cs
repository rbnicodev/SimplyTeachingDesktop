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
    public partial class PruebaFlow : UserForm
    {
        private DataController controller = new DataController();
        public PruebaFlow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            List<Label> labels = new List<Label>();
            List<string> teachers = controller.FindAllTeachers();
            foreach (string teacher in teachers)
            {
                Label label = new Label();
                label.Text = teacher;
                labels.Add(label);
            }

            foreach(Label label1 in labels)
            {
                flowLayoutPanel1.Controls.Add(label1);
                label1.Visible = true;
            }
        }
    }
}
