﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IService<T> where T : class  
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);

        //void'den task'a çevirdik çünkü veri tabanında savechanges islemini yapacağız.
        Task RemoveAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}