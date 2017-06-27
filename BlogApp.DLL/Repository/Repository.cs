using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DLL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BlogAppContext _context = null;
        private readonly DbSet<T> _dbSet;
        public Repository(BlogAppContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public IEnumerable<T> GetAllList(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return _dbSet.AsEnumerable();
            }
            return _dbSet.Where(predicate).ToList();
        }
        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.SingleOrDefault(predicate);
        }
        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        public long Count()
        {
            return _dbSet.LongCount();
        }
    }
}
