using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
    public class Subject : Entity
    {
        private int id;
        private int hour;
        private double price;
        private int day;
        public Subject()
        {
            type = 1;
        }
    }
}
