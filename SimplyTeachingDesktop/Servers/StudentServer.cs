using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop.Servers
{
    internal class StudentServer
    {
        private Repository studentsRepository;
        private Repository teachersRepository;

        public StudentServer()
        {
            studentsRepository = new MdbStudentRepository();
            teachersRepository = new MdbTeacherRepository();
        }
        public string[][] AllStudentsId()
        {
            List<Entity> students = studentsRepository.FindAll(); 

            string[][] studentsTable = new string[students.Count][];
            int i = 0;
            students.ForEach(student =>
            {
                string[] row = new string[2];
                row[0] = (student as StudentModel).id.ToString();
                row[1] = (student as StudentModel).name + " " + (student as StudentModel).last_name_1;
                studentsTable[i] = row;
                i++;
            });

            return studentsTable;
        }
        public string[] Find(int id)
        {
            StudentModel model = studentsRepository.Find(id) as StudentModel;
            string[] result = new string[10];
            result[0] = model.id.ToString();
            result[1] = model.name;
            result[2] = model.last_name_1;
            result[3] = model.last_name_2;
            result[4] = model.post_address;

            if (model.tel_1 > 0) result[5] = model.tel_1.ToString();
            else result[5] = "";

            if (model.tel_2 <= 0) result[6] = "";
            else result[6] = model.tel_2.ToString();

            result[7] = model.email;
            result[8] = (teachersRepository.Find(model.tutor_id) as TeacherModel).name + " " + (teachersRepository.Find(model.tutor_id) as TeacherModel).last_name_1;

            return result;
        }

        public bool Save(string[] student)
        {
            StudentModel model = new StudentModel();
            int aux;
            if (int.TryParse(student[0], out aux)) model.id = aux;
            aux = 0;
            model.name = student[1];
            model.last_name_1 = student[2];
            model.last_name_2 = student[3];
            model.post_address = student[4];
            if (int.TryParse(student[5], out aux)) model.tel_1 = aux;
            aux = 0;
            if (int.TryParse(student[6], out aux)) model.tel_2 = aux;
            aux = 0;
            model.email = student[7];
            if (int.TryParse(student[8], out aux)) model.tutor_id = aux;
            aux = 0;

            return studentsRepository.Save(model);
        }

        public bool Delete(string id)
        {
            return studentsRepository.Delete(studentsRepository.Find(int.Parse(id.Trim())));
        }
    }
}
