using System.Collections.Generic;
using System;
using Entities.Classes;


namespace GenericsRepo
{
    public class Repository<T> : IRepository<T>
        where T : Entity
    {
        List<T> _entities;
        public Repository(List<T> entities)
        {
            _entities = entities;
        }
        public List<T> GetAll()
        {
            return _entities;
        }
        public T GetEntity(int id)
        {
            var someEntityById = _entities.Find(item => item.Id == id);
            if (someEntityById == null) { Console.WriteLine("Entity with input id doesnt exist"); }
            return someEntityById;
        }
        public void Create(T entity)
        {
            _entities.Add(entity);
        }
        public bool Delete(int id)
        {
            var someEntityById = _entities.Find(item => item.Id == id);
            _entities.Remove(someEntityById);
            if (someEntityById == null) { return true; }
            else { return false; }     
        }
        public void Update(T entity)
        {
            int i = entity.Id;
            var someEntityById = _entities.Find(item => item.Id == i);
            if (someEntityById == null)
            {
                _entities.Add(entity);
            }
            else
            {
                _entities.Remove(someEntityById);
                _entities.Add(entity);
            }
        }
    }
}
