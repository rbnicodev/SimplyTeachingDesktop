using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop.Servers
{
    internal class TeacherServer
    {
        Repository repository;

        public TeacherServer()
        {
            repository = new MdbTeacherRepository();
        }
        public string[][] AllTeachersId()
        {
            List<Entity> teachers = repository.FindAll();

            string[][] teachersTable = new string[teachers.Count][];
            int i = 0;
            teachers.ForEach(teacher =>
            {
                string[] row = new string[2];
                row[0] = (teacher as TeacherModel).id.ToString();
                row[1] = (teacher as TeacherModel).name + " " + (teacher as TeacherModel).last_name_1;
                teachersTable[i] = row;
                i++;
            });

            return teachersTable;
        }

        public string[] Find(int id)
        {
            TeacherModel model = repository.Find(id) as TeacherModel;
            string[] result = new string[10];
            result[0] = model.id.ToString();
            result[1] = model.dni;
            result[1] = model.name;
            result[2] = model.last_name_1;
            result[3] = model.last_name_2;
            result[4] = model.post_address;
            result[5] = model.seg_social.ToString();
            result[6] = model.tel_1.ToString();
            if(model.tel_1 <= 0)
            {
                result[7] = model.tel_2.ToString();
            }else
            {
                result[7] = "";
            }
            result[8] = model.email;

            return result;
        }

        public List<string> FindAll()
        {
            List <string> teachers = new List<string>();
            foreach(TeacherModel teacher in repository.FindAll())
            {
                teachers.Add(teacher.name + " " + teacher.last_name_1);
            }

            return teachers;
        }
    }
}
