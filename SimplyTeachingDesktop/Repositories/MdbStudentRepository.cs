using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
 
    internal class MdbStudentRepository : Repository
    {
        private readonly string connectionString = EnvironmentVars.UrlConnection;
        private MySqlConnection connection = null;
        private MySqlCommand command = null;
        string query = null;
        private bool result;
        private MySqlDataReader reader = null;

        public bool Delete(Entity entity)
        {
            result = false;
            connection = new MySqlConnection(connectionString);
            query = "DELETE FROM students WHERE id = @id;";
            command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", (entity as StudentModel).id);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            { }
            finally
            {
                if (connection != null) connection.Close();
            }
            return result;
        }


        public Entity Find(int id)
        {
            StudentModel entity = new StudentModel();

            connection = new MySqlConnection(connectionString);
            query = "SELECT * FROM students WHERE id = @id;";
            command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        entity.id = int.Parse(reader.GetString(0));
                        entity.name = reader.GetString(1);
                        entity.last_name_1 = reader.GetString(2);
                        entity.last_name_2 = reader.GetString(3);
                        entity.post_address = reader.GetString(4);
                        entity.tel_1 = int.Parse(reader.GetString(5));
                        try { entity.tel_2 = int.Parse(reader.GetString(6)); } catch (SqlNullValueException ex) { }
                        entity.email = reader.GetString(7);
                        entity.tutor_id = int.Parse(reader.GetString(8));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("MdbTeacherRepository\n" + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }


            return entity;
        }

        public List<Entity> FindAll()
        {
            List<Entity> list = new List<Entity>();
            StudentModel entity;

            connection = new MySqlConnection(connectionString);
            query = "SELECT * FROM students";
            command = connection.CreateCommand();
            command.CommandText = query;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        entity = new StudentModel();
                        entity.id = int.Parse(reader.GetString(0));
                        entity.name = reader.GetString(1);
                        Console.WriteLine(entity.name);
                        entity.last_name_1 = reader.GetString(2);
                        Console.WriteLine(entity.last_name_1);
                        entity.last_name_2 = reader.GetString(3);
                        Console.WriteLine(entity.last_name_2);
                        entity.post_address = reader.GetString(4);
                        entity.tel_1 = int.Parse(reader.GetString(5));
                        try { entity.tel_2 = int.Parse(reader.GetString(6)); } catch (SqlNullValueException ex) { }
                        entity.email = reader.GetString(7);

                        list.Add(entity);
                        entity = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("MdbStudentRepository\n" + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }


            return list;
        }

        public bool Save(Entity entity)
        {
            connection = new MySqlConnection(connectionString);
            StudentModel model = entity as StudentModel;
            bool result = false;
            if (model.id == 0) query = "INSERT INTO students VALUES (@id, @name, @last_name_1, @last_name_2, @post_address, @tel_1, @tel_2, @email, @teacher_id)";
            else query = "UPDATE students SET name = @name, last_name_1 = @last_name_1, last_name_2 = @last_name_2, post_address = @post_address, tel_1 = @tel_1, tel_2 = @tel_2, email = @email, teacher_id = @teacher_id WHERE id = @id;";

            command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", model.id);
            command.Parameters.AddWithValue("@name", model.name);
            command.Parameters.AddWithValue("@last_name_1", model.last_name_1);
            command.Parameters.AddWithValue("@last_name_2", model.last_name_2);
            command.Parameters.AddWithValue("@post_address", model.post_address);
            command.Parameters.AddWithValue("@tel_1", model.tel_1);
            command.Parameters.AddWithValue("@tel_2", model.tel_2);
            command.Parameters.AddWithValue("@email", model.email);
            command.Parameters.AddWithValue("@teacher_id", model.tutor_id);


            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                result = true;
            }
            catch (MySqlException ex) { Console.WriteLine("\n\n\nSTUDENT REPOSITORY Save()\n" + ex.StackTrace); }
            catch (Exception e) { Console.WriteLine("\n\n\nSTUDENT REPOSITORY Save()\n" + e.StackTrace); }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return result;
        }

        public bool TestConnection()
        {
            result = false;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (AggregateException ex) { Console.WriteLine(ex.StackTrace); }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }

            return result;
        }
    }
}
