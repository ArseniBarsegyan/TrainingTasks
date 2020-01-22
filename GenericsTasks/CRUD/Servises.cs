using Entities.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using GenericsRepo;

namespace CRUD
{
    public class Servises
    {
        List<Entity> _entities = new List<Entity>();
        public Servises(List<Entity> entities)
        {
            _entities = entities;
        }
        public void CreateEntity(Entity entity)
        {
            _entities.Add(entity);
        }
        public void DeleteEntity (int id)
        {
            var someEntityById = _entities.Find(item => item.Id == id);
            if (someEntityById == null) { Console.WriteLine("Panda with input id doesnt exist")}; 
            _entities.Remove(someEntityById);
        }

        public void Update(Entity entity, int id)
        {
           
        }
    }

}

