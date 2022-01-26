using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop.Servers
{
    internal class SubjectServer
    {
        private Repository repository;

        public SubjectServer()
        {
            repository = new MdbStudentRepository();
        }

        public string[][] AllSubjectsId()
        {
            List<Entity> subjects = repository.findAll();

            string[][] subjectsTable = new string[subjects.Count][];
            int i = 0;
            subjects.ForEach(subject =>
            {
                string[] row = new string[2];
                row[0] = (subject as SubjectModel).id.ToString();
                row[1] = (subject as SubjectModel).name.ToString();
                subjectsTable[i] = row;
            });

            return subjectsTable;
        }
    }
}
