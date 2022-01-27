using System;
using System.Collections.Generic;

namespace SimplyTeachingDesktop
{
    interface Repository
    {
        bool TestConnection();
        bool Save(Entity entity);
        bool Delete(Entity entity);
        Entity Find(int id);
        List<Entity> FindAll();
    }
}
