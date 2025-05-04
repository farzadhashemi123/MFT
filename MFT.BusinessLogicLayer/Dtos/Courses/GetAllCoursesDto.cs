using MFT.DataAccessLayer.Entities;

namespace MFT.BusinessLogicLayer.Dtos.Courses;

public class GetAllCoursesDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public string Code { get; set; }
    public int TeacherId { get; set; }

}