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
    }
}
