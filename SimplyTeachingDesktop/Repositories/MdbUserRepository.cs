using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop.Repositories
{
    internal class MdbUserRepository : Repository
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
            UserModel entity = new UserModel();

            connection = new MySqlConnection(connectionString);
            query = "SELECT * FROM users WHERE id = @id;";
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
                        entity.user = reader.GetString(1);
                        entity.password = reader.GetString(2);
                    }
                }
            }
            catch (MySqlException ex) { }
            return entity;
        }

        public List<Entity> FindAll()
        {
            List<Entity> list = new List<Entity>();
            UserModel entity = new UserModel();

            connection = new MySqlConnection(connectionString);
            query = "SELECT * FROM users";
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
                        entity = new UserModel();
                        entity.id = int.Parse(reader.GetString(0));
                        entity.user = reader.GetString(1);
                        entity.password = reader.GetString(2);

                        list.Add(entity);
                        entity = null;
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


            return list;
        }

        public bool Save(Entity entity)
        {
            throw new NotImplementedException();
        }

        public bool TestConnection()
        {
            bool result = false;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                result = true;
            }
            catch (AggregateException ex) { Console.WriteLine(ex.StackTrace); }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }

            return result;
        }

    }
}
