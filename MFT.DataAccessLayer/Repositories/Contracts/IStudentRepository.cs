using MFT.DataAccessLayer.Entities;
using MFT.DataAccessLayer.Repositories.Base;

namespace MFT.DataAccessLayer.Repositories.Contracts
{
    public interface IStudentRepository : IRepository<Student>
    {
        List<Student> GetAllByName(string name);
    }
}
