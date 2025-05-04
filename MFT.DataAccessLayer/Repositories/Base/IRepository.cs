using MFT.DataAccessLayer.Entities;

namespace MFT.DataAccessLayer.Repositories.Base
{
    /// <summary>
    /// Base Contract
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
    {
        public T GetById(int id);
        public List<T> GetAll();
        public void Add(T entity);
        public void Update(T entity);
        public void Remove(T entity);
        public void Remove(int id);
    }
}
