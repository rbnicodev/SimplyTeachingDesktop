using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
    internal class DataController
    {
        private DataRepository dataRepository = new MdbDataRepository();
        public DataController() { }
        public Boolean Login(string user, string pass)
        {
            return dataRepository.Login(user, pass);
        }
        public Boolean SaveTeacher(String[] teacherString)
        {
            bool result = false;

            Teacher teacher = new Teacher();
            teacher.id = int.Parse(teacherString[0]);
            teacher.name = teacherString[1];
            teacher.last_name_1 = teacherString[2];
            teacher.last_name_2 = teacherString[3];
            teacher.post_address = teacherString[4];
            teacher.seg_social = int.Parse(teacherString[5]);
            teacher.tel_1 = int.Parse(teacherString[6]);
            teacher.tel_2 = int.Parse(teacherString[7]);
            teacher.setImage(teacherString[8]);

            dataRepository.SaveTeacher(teacher);

            return result;
        }

    }
}
