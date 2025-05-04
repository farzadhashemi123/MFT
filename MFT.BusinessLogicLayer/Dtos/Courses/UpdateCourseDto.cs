using MFT.DataAccessLayer.Entities;

namespace MFT.BusinessLogicLayer.Dtos.Courses;

public class UpdateCourseDto
{
    public int Id { get; set; }
    public int Capacity { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
  


}