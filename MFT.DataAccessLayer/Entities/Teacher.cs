using MFT.DataAccessLayer.Entities.Base;

namespace MFT.DataAccessLayer.Entities;

public class Teacher : Entity 
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TeacherCode { get; set; }
    public List<Course> Courses { get; set; }
}