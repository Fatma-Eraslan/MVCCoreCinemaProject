﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.DataBase.Repositories.Abstract
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
