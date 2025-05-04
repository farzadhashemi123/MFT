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

        // CRUD
        // Create
        // Read
        // Update
        // Delete

        /// <summary>
        /// Read (With Where)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id)
        {
       
            var entity = _context
                .Set<T>()
                .SingleOrDefault(e => e.Id == id);

            return entity;
        }

        /// <summary>
        /// Read (Without Where)
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            var entitiesAsList = _context
                .Set<T>()
                .ToList();
            return entitiesAsList;
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Add(T entity)
        {
            _context.Set<T>()
                .Add(entity);
            _context.SaveChanges();
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            //_context.Students.Update(new Student()); // Runtime error

            // Set<T>(): DbSet<Student>, DbSet<Course>
            _context.Set<T>()
                .Update(entity);
            _context.SaveChanges();
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(T entity)
        {
            //_context.Courses.Remove(new Course()); // Runtime error

            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            // Find(id) <===> Where(e=> e.Id == id).FirstOrDefault() <===> FirstOrDefault(e=> e.Id == id)
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
            {
                Remove(entity);
            }
            // jaleb bood age else mineveshtim
        }
    }
}
