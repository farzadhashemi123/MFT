using MFT.BusinessLogicLayer.Dtos.Students;
using MFT.DataAccessLayer.Entities;
using MFT.DataAccessLayer.Repositories;
using MFT.DataAccessLayer.Repositories.Contracts;

namespace MFT.BusinessLogicLayer.Services
{
    public class StudentService
    {
        private IStudentRepository _studentRepository;
        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        /// <summary>
        /// Get Entity + Mapping
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GetStudentDto Get(int id)
        {
            Student student = _studentRepository.GetById(id);

            // Mapping - نگاشت
            //GetStudentDto studentDto = new GetStudentDto()
            //{
            //    FirstName = student.FirstName,
            //    LastName = student.LastName
            //};

            // Mapping - نگاشت
            GetStudentDto studentDto = new GetStudentDto();
            studentDto.FirstName = student.FirstName;
            studentDto.LastName = student.LastName;

            return studentDto;
        }

        public List<GetAllByNameStudentDto> GetAllByName(string name)
        {
            List<Student> sourceStudents = _studentRepository.GetAllByName(name);

            // Mapping - نگاشت
            List<GetAllByNameStudentDto> destinationStudents = new List<GetAllByNameStudentDto>();
            foreach (Student student in sourceStudents)
            {
                GetAllByNameStudentDto studentDto = new GetAllByNameStudentDto();
                studentDto.FirstName = student.FirstName;
                studentDto.LastName = student.LastName;
                studentDto.Code = student.Code;
            }

            return destinationStudents;
        }

        public List<GetAllStudentDto> GetAll()
        {
            List<Student> sourceStudents = _studentRepository.GetAll();

            // Mapping - نگاشت
            List<GetAllStudentDto> destinationStudents = new List<GetAllStudentDto>();
            foreach (Student student in sourceStudents)
            {
                GetAllStudentDto studentDto = new GetAllStudentDto();
                studentDto.Id = student.Id;
                studentDto.FirstName = student.FirstName;
                studentDto.LastName = student.LastName;
                studentDto.NationalId = student.NationalId;
                studentDto.Code = student.Code;

                destinationStudents.Add(studentDto);
            }

            return destinationStudents;
        }

        public void Add(AddStudentDto studentDto)
        {
            // Mapping - نگاشت
            Student student = new Student();
            // student.Id = por nemikonim // Identity column dar nazar gereftim
            student.FirstName = studentDto.FirstName;
            student.LastName = studentDto.LastName;
            student.NationalId = studentDto.NationalId;
            student.Code = Guid.NewGuid().ToString(); // kar haye sakht

            _studentRepository.Add(student);
        }

        public void Update(UpdateStudentDto studentDto)
        {
            // Mapping - نگاشت
            Student student = _studentRepository.GetById(studentDto.Id);
            student.FirstName = studentDto.FirstName;
            student.LastName = studentDto.LastName;
            student.NationalId = studentDto.NationalId;

            _studentRepository.Update(student);
        }

        public void Delete(DeleteStudentDto studentDto)
        {
            // Mapping - نگاشت
            // Student student = _studentRepository.GetById(studentDto.Id);
            // _studentRepository.Remove(student);

            _studentRepository.Remove(studentDto.Id);
        }
    }
}
