//using MFT.DataAccessLayer.Entities;

using MFT.DataAccessLayer.Entities;
using MFT.DataAccessLayer.Repositories.Base;
using MFT.DataAccessLayer.Repositories.Contracts;

namespace MFT.DataAccessLayer.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public List<Student> GetAllByName(string name)
        {
            List<Student> students = _context.Students
                .Where(e => e.FirstName == name || e.LastName == name)
                .ToList();

            return students;
        }

      
    }
}
