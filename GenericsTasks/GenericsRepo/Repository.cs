using System.Collections.Generic;
using System;
using Entities.Classes;
using System.Linq;

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
            var entity = _entities.FirstOrDefault(item => item.Id == id);
            if (entity == null) { Console.WriteLine("Entity with input id doesnt exist"); }
            return entity;
        }
        public void Create(T entity)
        {
            _entities.Add(entity);
        }
        public bool Delete(int id)
        {
            var entity = _entities.FirstOrDefault(item => item.Id == id);
            // А если у тебя тут будет Remove(null)? Не выкинет ли exception?
            if (entity!= null)
            { _entities.Remove(entity); }
            else
            { Console.WriteLine("There is no entiity with so id!");            }
            
            // Всегда переноси тело if-else с новых строчек, как ты сделал в методе Update()
            if (entity == null)
            { return true; }
            else
            { return false; }     
        }
        public void Update(T entity)
        {
            int i = entity.Id;
            // Всегда лучше используй FirstOrDefault()
            var someEntityById = _entities.FirstOrDefault(item => item.Id == i);
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
