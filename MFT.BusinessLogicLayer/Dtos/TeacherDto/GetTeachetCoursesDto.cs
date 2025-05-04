using MFT.DataAccessLayer.Entities;

namespace MFT.BusinessLogicLayer.Dtos.TeacherDto;

public class GetTeacherCoursesDto
{
    public List<Course> Courses { get; set; }
}