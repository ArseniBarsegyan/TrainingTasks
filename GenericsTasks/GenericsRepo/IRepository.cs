using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsRepo
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetEntity(int id);
        void Create(T entity);
        void Update(T entity);

        /// <summary>
        /// Delete entity and return true if entity was deleted.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}
