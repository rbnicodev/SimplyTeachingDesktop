using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
    public class SubjectModel : Entity
    {
        public int type = 1;
        public int id;
        public string name;
        public int hour;
        public int day;
        public double price;
        public SubjectModel()
        {
        }
    }
}
