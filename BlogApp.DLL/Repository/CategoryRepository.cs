using BlogApp.DLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace BlogApp.DLL.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        private BlogAppContext _context = null;

        public CategoryRepository(BlogAppContext context)
        {
            _context = context;
        }
        public IEnumerable<Category> GetAllList(Expression<Func<Category, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return _context.Categories.ToList();
            }
            return _context.Categories.Where(predicate).ToList();
        }

        public Category Get(Expression<Func<Category, bool>> predicate)
        {
            return _context.Categories.SingleOrDefault(predicate);
        }

        public void Insert(Category entity)
        {
            _context.Categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            _context.Categories.Remove(entity);
        }
        public void Update(Category entity)
        {
            _context.Categories.Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
        public long Count()
        {
            return _context.Categories.LongCount();
        }
    }
}
