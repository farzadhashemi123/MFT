using MFT.DataAccessLayer.Entities;
using MFT.DataAccessLayer.Repositories.Base;

namespace MFT.DataAccessLayer.Repositories.Contracts
{
    public interface ICourseRepository : IRepository<Course>
    {
        public Course GetCourseByName(string courseName);
        void AddStudentInCourse(int StudentId , int CourseId);
    }
}
