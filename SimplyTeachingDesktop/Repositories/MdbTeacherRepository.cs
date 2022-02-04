using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
    internal class MdbTeacherRepository : Repository
    {
        private readonly string connectionString = EnvironmentVars.UrlConnection;
        private MySqlConnection connection = null;
        private MySqlCommand command = null;
        private MySqlDataReader reader = null;
        string query = null;
        public bool Delete(Entity entity)
        {
            throw new NotImplementedException();
        }

        public Entity Find(int id)
        {
            TeacherModel entity = new TeacherModel();

            connection = new MySqlConnection(connectionString);
            query = "SELECT * FROM teachers WHERE id = @id;";
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
                        entity.dni = reader.GetString(1);
                        entity.name = reader.GetString(2);
                        entity.last_name_1 = reader.GetString(3);
                        entity.last_name_2 = reader.GetString(4);
                        entity.post_address = reader.GetString(5);
                        entity.seg_social = int.Parse(reader.GetString(6));
                        entity.tel_1 = int.Parse(reader.GetString(7));
                        try { entity.tel_2 = int.Parse(reader.GetString(8)); } catch (SqlNullValueException ex) { }
                        entity.email = reader.GetString(9);
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
            TeacherModel entity = new TeacherModel();

            connection = new MySqlConnection(connectionString);
            query = "SELECT * FROM teachers";
            command = connection.CreateCommand();
            command.CommandText = query;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        entity = new TeacherModel();
                        entity.id = int.Parse(reader.GetString(0));
                        Console.WriteLine(entity.id);
                        entity.dni = reader.GetString(1);
                        Console.WriteLine(entity.dni);
                        entity.name = reader.GetString(2);
                        Console.WriteLine(entity.name);
                        entity.last_name_1 = reader.GetString(3);
                        Console.WriteLine(entity.last_name_1);
                        entity.last_name_2 = reader.GetString(4);
                        Console.WriteLine(entity.last_name_2);
                        entity.post_address = reader.GetString(5);
                        entity.seg_social = int.Parse(reader.GetString(6));
                        entity.tel_1 = int.Parse(reader.GetString(7));
                        try { entity.tel_2 = int.Parse(reader.GetString(8)); } catch (SqlNullValueException ex) { }
                        entity.email = reader.GetString(9);

                        list.Add(entity);
                        entity = null;
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("MdbTeacherRepository\n"+ ex.Message);
            }
            finally
            {
                if(connection != null)
                    connection.Close();
            }


            return list;
        }

        public bool Save(Entity entity)
        {
            connection = new MySqlConnection(connectionString);
            command = new MySqlCommand(query, connection);
            TeacherModel model = entity as TeacherModel;
            bool result = false;
            if (Find(model.id) == null) query = "INSERT INTO teachers (dni, name, last_name_1, last_name_2, post_address, seg_social, tel_1, tel_2, email) VALUES (@dni, @name, @last_name_1, @last_name_2, @post_address, @seg_social, @tel_1, @tel_2, @email);";
            else
            {
                query = "UPDATE teachers SET dni = @dni, name = @name, last_name_1 = @last_name_1, last_name_2 = @last_name_2, post_address = @post_address, seg_social = @seg_social, tel_1 = @tel_1, tel_2 = @tel_2, email = @email WHERE id = @id";
            }

            try { command.Parameters.AddWithValue("@id", model.id); } catch (Exception ex) { }
            command.Parameters.AddWithValue("@dni", model.dni);
            command.Parameters.AddWithValue("@name", model.name);
            command.Parameters.AddWithValue("@last_name_1", model.last_name_1);
            command.Parameters.AddWithValue("@last_name_2", model.last_name_2);
            command.Parameters.AddWithValue("@post_address", model.post_address);
            command.Parameters.AddWithValue("@seg_social", model.seg_social);
            command.Parameters.AddWithValue("@tel_1", model.tel_1);
            command.Parameters.AddWithValue("@tel_2", model.tel_2);
            command.Parameters.AddWithValue("@email", model.email);


            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                result = true;
            }
            catch (MySqlException ex) { Console.WriteLine(ex.StackTrace + "NO VAAAAA"); }
            catch (Exception e) { Console.WriteLine(e.StackTrace); }
            finally
            {
                if (connection != null)
                    connection.Close();
            }

            return result;
        }

        public bool TestConnection()
        {
            bool result = false;

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
