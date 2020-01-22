using Entities.Classes;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsRepo
{
    public class Repository
    {
        public List<Entity> entitiesList = new List<Entity>();
        public Repository (List<Entity> entitiesList)
        {
            this.entitiesList = entitiesList;
        }

    }
}
