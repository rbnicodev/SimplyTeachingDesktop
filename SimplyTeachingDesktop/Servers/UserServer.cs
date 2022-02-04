using SimplyTeachingDesktop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyTeachingDesktop.Servers
{
    internal class UserServer
    {
        private Repository repository = new MdbUserRepository();

        public bool TestConnection()
        {
            bool result = false;
            if (repository.TestConnection()) result = true;
            return result;
        }
        public bool Login(string user, string pass)
        {
            bool result = false;

            List<Entity> users = repository.FindAll();

            foreach (Entity entity in users)
            {
                UserModel userModel = entity as UserModel;
                if (userModel.user.Equals(user) && userModel.password.Equals(pass))
                    result = true;
            }
            return result;
        }
    }
}
