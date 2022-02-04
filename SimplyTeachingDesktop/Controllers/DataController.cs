using SimplyTeachingDesktop.Servers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
    internal class DataController
    {
        private StudentServer studentServer;
        private SubjectServer subjectServer;
        private TeacherServer teacherServer;
        private UserServer userServer;
        public DataController() 
        {
            studentServer = new StudentServer();
            subjectServer = new SubjectServer();
            teacherServer = new TeacherServer();
            userServer = new UserServer();
        }

        public Boolean TestConnection()
        {
            bool result = false; ;
            if (userServer.TestConnection()) result = true;

            return result;
        }

        public Boolean Login(string user, string pass)
        {
            return userServer.Login(user, pass);
        }
        

        public Boolean Validate_Email(String email)
        {
            bool result;
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
        public string[][] TeachersTable() { 
        
            return teacherServer.AllTeachersId();

        }

        public string[][] StudentsTable()
        {
            return studentServer.AllStudentsId();
        }

        public string[][] SubjectsTable()
        {
            return subjectServer.AllSubjectsId();
        }

        public string[] FindTeacher(string id)
        {
            int a;
            if (int.TryParse(id, out a)) return teacherServer.Find(a);
            else return null;
        }

        public string[] FindTeacherByName(string name)
        {
            return teacherServer.Find(name);
        }

        public string[] FindSubject(string id)
        {
            int a;
            if (int.TryParse(id, out a)) return subjectServer.Find(a);
            else return null;
        }

        public string[] FindStudent(string id)
        {
            int a;
            if (int.TryParse(id, out a)) return studentServer.Find(a);
            else return null;
        }

        public Boolean SaveStudent(string[] student) { return true; }

        public Boolean SaveSubject(string[] subject) { return subjectServer.Save(subject); }

        public Boolean SaveTeacher(string[] teacher) { return teacherServer.Save(teacher); }
        public Boolean DeleteStudent(string id) { return true; ; }
        public Boolean DeleteSubject(string id) { return subjectServer.Delete(id); }
        public Boolean DeleteTeacher(string id) { return true; }
        public List<string> FindAllTeachers() { return teacherServer.FindAll(); }

    }
}
