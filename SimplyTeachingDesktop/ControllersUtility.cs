using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
    class ControllersUtility
    {
        private static DataController dataController;
        private ControllersUtility() { }

        public static DataController GetDataController()
        {
            if(dataController == null)
            {
                dataController = new DataController();
            }
            return dataController;
        }

    }
}
