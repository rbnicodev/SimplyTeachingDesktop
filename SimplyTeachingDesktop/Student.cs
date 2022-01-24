using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
    public class Student : Entity
    {
        private int id;
        private string name;
        private string last_name1;
        private string last_name2;
        private string post_address;
        private int tel1;
        private int tel2;
        private string email;
        public Student()
        {
            type = 2;
        }
    }
}
