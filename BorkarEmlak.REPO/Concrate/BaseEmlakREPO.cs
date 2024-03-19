using BorkarEmlak.DATA.Abstract;
using BorkarEmlak.REPO.Abstract;
using BorkarEmlak.REPO.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BorkarEmlak.REPO.Concrate
{
    public class BaseEmlakREPO<T> : IBaseEmlakREPO<T> where T : BaseEmlak
    {
        private readonly ApplicationContext _applicationContext;


        public BaseEmlakREPO(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

      
      

        public int Create(T entity)
        {
            _applicationContext.Set<T>().Add(entity);
            return _applicationContext.SaveChanges();
        }

        public int Delete(T entity)
        {
            _applicationContext.Entry<T>(entity).State = EntityState.Modified;
            return _applicationContext.SaveChanges();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _applicationContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _applicationContext.Set<T>().FindAsync(id);
        }

        public async Task<TResult> GetFilteredFirstOrDefaultAsync<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null)
        {
            IQueryable<T> query = _applicationContext.Set<T>();
            if(join != null)
            {
                query=join(query);
            }
            if(where != null)
            {
                query=query.Where(where);
            }
            if (orderBy != null)
            {
                return await orderBy(query).Select(select).FirstOrDefaultAsync();
            }
            else
            {
                return await query.Select(select).FirstOrDefaultAsync();
            }
        }

        public async Task<List<TResult>> GetFilteredListAsync<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null)
        {
            IQueryable<T> query = _applicationContext.Set<T>();
            if (join != null)
            {
                query = join(query);
            }
            if (where != null)
            {
                query = query.Where(where);
            }
            if (orderBy != null)
            {
                return await orderBy(query).Select(select).ToListAsync();
            }
            else
            {
                return await query.Select(select).ToListAsync();
            }
        }

        public async Task<List<T>> GetWhereAsync(Expression<Func<T, bool>> expression)
        {
            return await _applicationContext.Set<T>().Where(expression).ToListAsync();
        }

        public int Update(T entity)
        {
           _applicationContext.Entry<T>(entity).State = EntityState.Modified;
            return _applicationContext.SaveChanges();
        }

        public List<T> GetAllWhere(Expression<Func<T, bool>> expression)
        {
            return _applicationContext.Set<T>().Where(expression).ToList();
        }
    }

}
