using MFT.DataAccessLayer.Entities.Base;

namespace MFT.DataAccessLayer.Entities
{
    public class Student : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public string Code { get; set; }
        
        public List<Course> Courses { get; set; }
    }
}
