using MFT.DataAccessLayer.Entities;
using MFT.DataAccessLayer.Repositories.Base;
using MFT.DataAccessLayer.Repositories.Contracts;

namespace MFT.DataAccessLayer.Repositories
{
    public class CourseRepository :  Repository<Course>, ICourseRepository
    {
        public Course GetCourseByName(string name)
        {
            var courses = _context.Courses.Where(e=> e.Name == name).FirstOrDefault();
            return  courses;
        }
        public void AddStudentInCourse(int StudentId, int CourseId)
        {
            Student student = _context.Students.FirstOrDefault(e => e.Id == StudentId);
            Course course = _context.Courses.FirstOrDefault(e => e.Id == CourseId);
            
            course.Students.Add(student);
            
        }
    }
}
