using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ConsoleApplication1
{
    public class Repository<T>  where T : class
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Add(T entityToAdd)
        {
            _context.Set<T>().Add(entityToAdd);
        }

        public void Delete(T entityToDelete)
        {
            _context.Set<T>().Remove(entityToDelete);
        }

        public void SaveChanges()
        {
            var changedItems = _context.ChangeTracker.Entries()
                .Where(e => e.State != EntityState.Unchanged)
                .ToList();

            _context.SaveChanges();
        }
    }
}