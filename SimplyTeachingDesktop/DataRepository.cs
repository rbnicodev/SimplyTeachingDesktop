using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
    abstract class DataRepository
    {
        public abstract Boolean Login(string username, string password);
        public abstract Boolean SaveTeacher(Teacher teacher);
        public abstract Boolean DeleteTeacher(int id);
        public abstract Teacher GetTeacher(int id);
        public abstract List<Teacher> GetAllTeachers();
        public abstract Boolean SaveSubject(Subject subject);
        public abstract Boolean DeleteSubject(int id);
        public abstract Subject GetSubject(int id);
        public abstract List<Subject> GetAllSubjects();
        public abstract Boolean SaveStudent(Student student);
        public abstract Boolean DeleteStudent(int id);
        public abstract Student GetStudent(int id);
        public abstract List<Student> GetAllStudents();


    }
}
