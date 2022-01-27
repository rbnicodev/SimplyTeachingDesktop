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
            throw new NotImplementedException();
        }

        public List<Entity> FindAll()
        {
            throw new NotImplementedException();
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
