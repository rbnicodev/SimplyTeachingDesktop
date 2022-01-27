using SimplyTeachingDesktop.Repositories;
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
            repository = new MdbSubjectRepository();
        }

        public string[][] AllSubjectsId()
        {
            List<Entity> subjects = repository.FindAll();

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

        public string[] Find(int id)
        {
            SubjectModel model = repository.Find(id) as SubjectModel;
            string[] result = new string[10];
            result[0] = model.id.ToString();
            result[1] = model.name;
            result[2] = model.hour.ToString();
            result[3] = model.day.ToString();
            result[4] = model.price.ToString();

            return result;
        }
    }
}
