using MFT.DataAccessLayer.Data;
using MFT.DataAccessLayer.Entities;
using MFT.DataAccessLayer.Entities.Base;

namespace MFT.DataAccessLayer.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected ApplicationDbContext _context;

        public Repository()
        {
            _context = new ApplicationDbContext();
        }

        public T GetById(int id)
        {   var entity = _context
                .Set<T>()
                .SingleOrDefault(e => e.Id == id);

            return entity;
        }
        
        public List<T> GetAll()
        {
            var entitiesAsList = _context
                .Set<T>()
                .ToList();
            return entitiesAsList;
        }


        public void Add(T entity)
        {
            _context.Set<T>()
                .Add(entity);
            _context.SaveChanges();
        }


        public void Update(T entity)
        {
            _context.Set<T>()
                .Update(entity);
            _context.SaveChanges();
        }


        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
            {
                Remove(entity);
            }
        }
    }
}
