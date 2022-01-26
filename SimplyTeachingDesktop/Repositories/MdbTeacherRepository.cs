using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
    internal class MdbTeacherRepository : Repository
    {
        private readonly string connectionString = "datasource=localhost;port=3306;username=root;password=bitnami;database=SimplyTeaching;";
        private MySqlConnection connection = null;
        private MySqlCommand command = null;
        private MySqlDataReader reader = null;
        string query = null;
        bool result = true;
        public bool delete(Entity entity)
        {
            throw new NotImplementedException();
        }

        public Entity find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Entity> findAll()
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
                        //entity.tel_2 = int.Parse(reader.GetString(8));
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

        public bool save(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
