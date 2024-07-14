using ApplicationCore.Interfaces.Repository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ShippingDbContext _db;
        public BaseRepository(ShippingDbContext db)
        {
            _db = db;
        }
        public async Task<int> AddAsync(T entity)
        {
            _db.Set<T>().Add(entity);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            var entity = await _db.Set<T>().FindAsync(id);
            if (entity == null) { return 0; }
            _db.Set<T>().Remove(entity);
            return await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> condition)
        {
            return await _db.Set<T>().Where(condition).ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _db.Set<T>().FindAsync(id).AsTask();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            //_db.Set<T>().Update(entity);
            _db.Entry(entity).State = EntityState.Modified;
            return await _db.SaveChangesAsync();
        }
    }
}
