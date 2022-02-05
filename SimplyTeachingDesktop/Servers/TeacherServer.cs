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
            if(model != null)
            {
                result[0] = model.id.ToString();
                result[1] = model.dni;
                result[2] = model.name;
                result[3] = model.last_name_1;
                result[4] = model.last_name_2;
                result[5] = model.post_address;
                if (model.seg_social > 0) result[6] = model.seg_social.ToString();
                else result[6] = "";

                if (model.tel_1 > 0) result[7] = model.tel_1.ToString();
                else result[7] = "";

                if (model.tel_2 > 0)  result[8] = model.tel_2.ToString();
                else result[8] = "";

                result[9] = model.email;
            }
            else
            {
                for(int i = 0; i < 10; i++)
                {
                    result[i] = "";
                }
            }

            return result;
        }
        public string[] Find(string name)
        {
            foreach(TeacherModel teacher in repository.FindAll())
            {
                if(teacher.name.Equals(name))
                    return Find(teacher.id);
            }
            return null;
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

        public bool Save(string[] teacher)
        {
            TeacherModel model = new TeacherModel();
            int aux;
            if(int.TryParse(teacher[0], out aux)) model.id = aux;
            aux = 0;
            model.dni = teacher[1];
            model.name = teacher[2];
            model.last_name_1 = teacher[3];
            model.last_name_2 = teacher[4];
            model.post_address = teacher[5];
            if (int.TryParse(teacher[6], out aux)) model.seg_social = aux;
            aux = 0;
            if (int.TryParse(teacher[7], out aux)) model.tel_1 = aux;
            aux = 0;
            if (int.TryParse(teacher[8], out aux)) model.tel_2 = aux;
            aux = 0;
            model.email = teacher[9];

            return repository.Save(model);

        }

        public bool Delete(string id)
        {
            return repository.Delete(repository.Find(int.Parse(id.Trim())));
        }
    }
}
