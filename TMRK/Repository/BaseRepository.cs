using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TMRK.Context;
using TMRK.Models;
using TMRK.Services;

namespace TMRK.Repository
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        private Rep_gsandbContext _dbContext;
        protected DbSet<TEntity> _dbSet;

        public BaseRepository(Rep_gsandbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> whereCluse = null,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> orderBy = null,
            string includes = "")
        {
            IQueryable<TEntity> query = _dbSet;
            if (whereCluse != null)
            {
                query = query.Where(whereCluse);
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            if (!string.IsNullOrEmpty(includes))
            {
                foreach (string include in includes.Split(","))
                {
                    query = query.Include(include.Trim()).IgnoreQueryFilters();
                }
            }
            return query;
        }
        public virtual ValueTask<TEntity> GetByIdAsync(object id)
        {
            return _dbSet.FindAsync(id);
        }

        public virtual ValueTask<EntityEntry<TEntity>> AddAsync(TEntity entity)
        {
            return _dbSet.AddAsync(entity);
        }

        public virtual EntityEntry<TEntity> UpdateAsync(TEntity entity)
        {
            return _dbSet.Update(entity);
        }

        public virtual EntityEntry<TEntity> Delete(TEntity entity)
        {
            return _dbSet.Remove(entity);
        }

        public virtual async Task<EntityEntry<TEntity>> DeleteByIdAsync(object id)
        {
            var entity = await GetByIdAsync(id);
            return Delete(entity);
        }

        public virtual Task SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
        public virtual Task<PaginatedList<TEntity>> PaginatedListAsync(IQueryable<TEntity> query, int pageIndex, int pageSize)
        {
            return PaginatedList<TEntity>.CreateAsync(query, pageIndex, pageSize);
        }
    }
}
