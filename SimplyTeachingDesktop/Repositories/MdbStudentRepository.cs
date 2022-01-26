using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop
{
 
    internal class MdbStudentRepository : Repository
    {
        private readonly string connectionString = "datasource=localhost;port=3306;username=root;password=bitnami;database=SimplyTeaching;";
        private MySqlConnection connection = null;
        private MySqlCommand command = null;
        string query = null;
        bool result = true;

        public bool delete(Entity entity)
        {
            throw new NotImplementedException();
        }

        public Entity find(int id)
        {
            return new StudentModel();
        }

        public List<Entity> findAll()
        {
            throw new NotImplementedException();
        }

        public bool save(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
