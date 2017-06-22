﻿using System.Collections.Generic;

namespace Sales.Repositories
{
    public interface IRepository<T> where T : class
    {
        bool Delete(T entity);
        int Insert(T entity);
        bool Update(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
