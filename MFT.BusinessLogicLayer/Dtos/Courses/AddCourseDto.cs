using MFT.DataAccessLayer.Entities;

namespace MFT.BusinessLogicLayer.Dtos.Courses;

public class AddCourseDto
{
    public int Capacity { get; set; }
    public string Name { get; set; }

    public string Code { get; set; }

    public int TeacherId { get; set; }
}