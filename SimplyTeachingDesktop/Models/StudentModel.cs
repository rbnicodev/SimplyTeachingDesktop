using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
    public class StudentModel : Entity
    {
        public int type = 2;
        public int id;
        public string name;
        public string last_name1;
        public string last_name2;
        public string post_address;
        public int tel1;
        public int tel2;
        public string email;
        public StudentModel()
        {
        }
    }
}
