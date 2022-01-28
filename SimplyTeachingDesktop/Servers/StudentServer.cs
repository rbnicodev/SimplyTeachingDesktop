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
            result[5] = model.tel_1.ToString();
            if (model.tel_2 <= 0) result[6] = "";
            else result[6] = model.tel_2.ToString();
            result[7] = model.email;
            result[8] = (teachersRepository.Find(model.tutor_id) as TeacherModel).name + " " + (teachersRepository.Find(model.tutor_id) as TeacherModel).last_name_1;

            return result;
        }
    }
}
