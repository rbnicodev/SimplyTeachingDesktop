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
                i++;
            });

            return subjectsTable;
        }

        public string[] Find(int id)
        {
            SubjectModel model = repository.Find(id) as SubjectModel;
            string[] result = new string[10];
            result[0] = model.id.ToString();
            result[1] = model.name;
            result[2] = model.hour.Substring(0, model.hour.Length - 3);
            switch(model.day)
            {
                case 1: result[3] = "Lunes"; break;
                case 2: result[3] = "Martes"; break;
                case 3: result[3] = "Miércoles"; break;
                case 4: result[3] = "Jueves"; break;
                case 5: result[3] = "Viernes"; break;
                default: result[3] = ""; break;
            }
            result[4] = model.price.ToString();

            return result;
        }

        public bool Save(string[] subject)
        {
            SubjectModel model = new SubjectModel();
            int aux;
            double aux2;
            if (int.TryParse(subject[0], out aux))
                model.id = aux;
            model.name = subject[1];
            model.hour = subject[2];
            if (int.TryParse(subject[3], out aux)) model.day = aux;
            if (double.TryParse(subject[4], out aux2)) model.price = aux2;

            return repository.Save(model);

        }

        public bool Delete(string id)
        {
            return repository.Delete(repository.Find(int.Parse(id)));
        }
    }
}
