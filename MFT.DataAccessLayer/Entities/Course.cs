using MFT.DataAccessLayer.Entities.Base;

namespace MFT.DataAccessLayer.Entities
{
    public class Course : Entity
    {
        public int Capacity { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
    }
}
