using MFT.DataAccessLayer.Entities;
using MFT.DataAccessLayer.Repositories.Base;
using MFT.DataAccessLayer.Repositories.Contracts;

namespace MFT.DataAccessLayer.Repositories;

public class TeacherRepository :Repository<Teacher> , ITeacherRepository
{
  

    public List<Course> GetTeacherCourses(string name, string lastName)
  {
      List<Course> courses = _context.Courses
          .Where
              (e => e.Teacher.FirstName == name || e.Teacher.LastName == lastName)
          .ToList();
      
      return courses;
  }
}