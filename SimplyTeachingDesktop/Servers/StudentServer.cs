using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop.Servers
{
    internal class StudentServer
    {
        private Repository repository;

        public StudentServer()
        {
            repository = new MdbStudentRepository();
        }
        public string[][] AllStudentsId()
        {
            List<Entity> students = repository.FindAll(); 

            string[][] studentsTable = new string[students.Count][];
            int i = 0;
            students.ForEach(student =>
            {
                string[] row = new string[2];
                row[0] = (student as StudentModel).id.ToString();
                row[1] = (student as StudentModel).name.ToString();
                studentsTable[i] = row;
            });

            return studentsTable;
        }
    }
}
