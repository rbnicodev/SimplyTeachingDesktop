using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
    internal class ControllerBuilder
    {
        public static DataController controller;
        public static DataController GetController()
        {
            if(controller == null)
            {
                controller = new DataController();
            }

            return controller;
        }
    }
}
