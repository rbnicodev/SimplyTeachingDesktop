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
        public Boolean Login(string user, string pass)
        {
            //TO-DO
            //userServer.Login(user, pass);
            //
            //
            return true;
        }
        
        public Boolean ValidateTeacher(String[] teacherString)
        {
            Boolean result = true;

            return result;
        }
        public Boolean ValidateStudent(String[] teacherString)
        {
            Boolean result = true;

            return result;
        }
        public Boolean ValidateSubject(String[] teacherString)
        {
            Boolean result = true;

            return result;
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

    }
}
