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
        public string last_name_1;
        public string last_name_2;
        public string post_address;
        public int tel_1;
        public int tel_2;
        public string email;
        public int tutor_id;
        public StudentModel()
        {
        }
    }
}
