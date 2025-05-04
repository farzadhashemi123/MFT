using MFT.DataAccessLayer.Entities;

namespace MFT.BusinessLogicLayer.Dtos.Courses;

public class GetCoursesDto
{
    public int Capacity { get; set; }
    public string Name { get; set; }
    public int  TeacherId { get; set; }
}