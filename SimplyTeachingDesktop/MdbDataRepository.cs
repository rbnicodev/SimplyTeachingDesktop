using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
 
    internal class MdbDataRepository : DataRepository
    {
        private readonly string connectionString = "datasource=localhost;port=3306;username=root;password=bitnami;database=SimplyTeaching;";
        private MySqlConnection connection = null;
        private MySqlCommand command = null;
        string query = null;
        bool result = true;

        public override bool DeleteStudent(int id)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return result;
        }

        public override bool DeleteSubject(int id)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return result;
        }

        public override bool DeleteTeacher(int id)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return result;
        }

        public override List<Student> GetAllStudents()
        {
            List<Student> students = null;
            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return students;
        }

        public override List<Subject> GetAllSubjects()
        {
            List<Subject> subjects = null;
            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return subjects;
        }

        public override List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = null;
            try
            {
                

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return teachers;
        }

        public override Student GetStudent(int id)
        {
            Student student = null;
            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return student;
        }

        public override Subject GetSubject(int id)
        {
            Subject subject = null;
            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return subject;
        }

        public override Teacher GetTeacher(int id)
        {
            Teacher teacher = null;
            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return teacher;
        }

        public override bool Login(string username, string password)
        {
            try
            {
                if (!username.Equals("admin@academy.es") || !password.Equals("admin"))
                    result = false;
                else
                    result = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            Console.WriteLine(username);
            Console.WriteLine(password);
            return result;
        }

        public override bool SaveStudent(Student student)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return result;
        }

        public override bool SaveSubject(Subject subject)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return result;
        }

        public override bool SaveTeacher(Teacher teacher)
        {

            try
            {
                byte[] photo = teacher.image;
                connection = new MySqlConnection(connectionString);
                query = "INSERT INTO teachers (id, name, last_name_1, last_name_2, post_address, seg_social, tel_1, tel_2, email, photo) VALUES(@id, @name, @last_name_1, @last_name_2, @post_address, @seg_social, @tel_1, @tel_2, @email, @photo);";
                command = connection.CreateCommand();
                command.CommandText = query;
                command.Parameters.AddWithValue("@id", teacher.id);
                command.Parameters.AddWithValue("@name", teacher.name);
                command.Parameters.AddWithValue("@last_name_1", teacher.last_name_1);
                command.Parameters.AddWithValue("@last_name_2", teacher.last_name_2);
                command.Parameters.AddWithValue("@post_address", teacher.post_address);
                command.Parameters.AddWithValue("@seg_social", teacher.seg_social);
                command.Parameters.AddWithValue("@tel_1", teacher.tel_1);
                command.Parameters.AddWithValue("@tel_2", teacher.tel_2);
                command.Parameters.AddWithValue("@email", teacher.email);
                command.Parameters.AddWithValue("@photo", teacher.image);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            { 
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return result;
        }


    }
}
