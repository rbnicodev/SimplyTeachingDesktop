using System;
using System.Collections.Generic;

namespace SimplyTeachingDesktop
{
    interface Repository
    {
        bool save(Entity entity);
        bool delete(Entity entity);
        Entity find(int id);
        List<Entity> findAll();
    }
}
