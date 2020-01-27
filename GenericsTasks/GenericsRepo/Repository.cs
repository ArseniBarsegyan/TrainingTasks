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
            // названия переменных. не преувеличивай, называй просто и ясно. 
            // просто entity.
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
            // А если у тебя тут будет Remove(null)? Не выкинет ли exception?
            _entities.Remove(someEntityById);
            // Всегда переноси тело if-else с новых строчек, как ты сделал в методе Update()
            if (someEntityById == null) { return true; }
            else { return false; }     
        }
        public void Update(T entity)
        {
            int i = entity.Id;
            // Всегда лучше используй FirstOrDefault()
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
