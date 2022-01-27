using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop.Repositories
{
    internal class MdbSubjectRepository : Repository
    {
        private readonly string connectionString = "datasource=localhost;port=3306;username=root;password=bitnami;database=SimplyTeaching;";
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
            SubjectModel entity = new SubjectModel();

            connection = new MySqlConnection(connectionString);
            query = "SELECT * FROM subjects WHERE id = @id;";
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
                        entity.hour = int.Parse(reader.GetString(2));
                        entity.day = int.Parse(reader.GetString(3));
                        entity.price = double.Parse(reader.GetString(4));
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
            SubjectModel entity;

            connection = new MySqlConnection(connectionString);
            query = "SELECT * FROM subjects";
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
                        entity = new SubjectModel();
                        entity.id = int.Parse(reader.GetString(0));
                        entity.name = reader.GetString(1);
                        entity.hour = int.Parse(reader.GetString(2));
                        entity.day = int.Parse(reader.GetString(3));
                        entity.price = double.Parse(reader.GetString(4));
                        
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
            }
            catch (AggregateException ex) { Console.WriteLine(ex.StackTrace); }
            catch (Exception ex) { Console.WriteLine(ex.StackTrace); }

            return result;
        }
    }
}
