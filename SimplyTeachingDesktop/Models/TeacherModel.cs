using System.IO;
namespace SimplyTeachingDesktop
{
    public class TeacherModel : Entity 
    {
        public TeacherModel()
        {
        }
        public int id;
        public string dni;
        public string name;
        public string last_name_1;
        public string last_name_2;
        public string post_address;
        public int seg_social;
        public int tel_1;
        public int tel_2;
        public string email;
        public int type = 0;
    }
}
