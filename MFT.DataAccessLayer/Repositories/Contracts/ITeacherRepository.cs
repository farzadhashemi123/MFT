using MFT.DataAccessLayer.Entities;
using MFT.DataAccessLayer.Repositories.Base;

namespace MFT.DataAccessLayer.Repositories.Contracts;

public interface ITeacherRepository : IRepository<Teacher>
{
    public List<Course> GetTeacherCourses(string name, string lastName);
}