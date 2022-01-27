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
            List<Entity> teachers = repository.findAll();

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
    }
}
