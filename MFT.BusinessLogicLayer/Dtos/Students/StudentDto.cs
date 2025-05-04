using MFT.DataAccessLayer.Entities;

namespace MFT.BusinessLogicLayer.Dtos.Students
{
    public class StudentDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public string Code { get; set; }
        public List<Course> Courses { get; set; }
    }
}
