using MFT.BusinessLogicLayer.Dtos.Students;
using MFT.BusinessLogicLayer.Dtos.TeacherDto;
using MFT.DataAccessLayer.Entities;
using MFT.DataAccessLayer.Repositories;
using MFT.DataAccessLayer.Repositories.Contracts;

namespace MFT.BusinessLogicLayer.Services;

public class TeacherService
{
   private ITeacherRepository _teacherRepository;

   public TeacherService()
   {
      _teacherRepository = new TeacherRepository();
   }

    
   public GetTeacherDto GetById(int id)
   {
      Teacher teacher = _teacherRepository.GetById(id);
      GetTeacherDto getTeacherDto = new GetTeacherDto()
      {
         Name = teacher.FirstName,
         LastName = teacher.LastName
      };
      
      return getTeacherDto;
   }

   public void Add(AddTeachertDto teacherDto)
   {
      Teacher teacher = new();
      teacher.FirstName = teacherDto.FirstName;
      teacher.LastName = teacherDto.LastName;
      teacher.TeacherCode = teacherDto.Code;
      
      _teacherRepository.Add(teacher);
   }

   public List<GetTeacherCoursesDto> GetTeacherCourses(string name , string lastName)
   {
      List<Course> courses = _teacherRepository.GetTeacherCourses(name, lastName);

      List<GetTeacherCoursesDto> teacherCoursesDto = new();
      foreach (Course course in courses)
      {
         GetTeacherCoursesDto teacherCourseDto = new();
         teacherCourseDto.Courses.Add(course);
      }

      return teacherCoursesDto;
   }

   public GetByIdTeacherDto Get(int id)
   {
      Teacher teacher = _teacherRepository.GetById(id);
      GetByIdTeacherDto getByIdTeacherDto = new();
      
      getByIdTeacherDto.Name = teacher.FirstName;
      getByIdTeacherDto.LastName = teacher.LastName;

      return getByIdTeacherDto;
   }

   public void Update(UpdateTeacherDto teacherDto)
   {
      Teacher teacher = _teacherRepository.GetById(teacherDto.Id);
      teacher.FirstName = teacherDto.FirstName;
      teacher.LastName = teacherDto.LastName;
      teacher.TeacherCode = teacherDto.Code;
      
      _teacherRepository.Update(teacher);

   }

   public List<GetAllTeacherDto> GetAll()
   {
      List<Teacher> teachers = _teacherRepository.GetAll();
      List<GetAllTeacherDto> teachersDto = new();

      foreach (Teacher teacher in teachers)
      {
          GetAllTeacherDto getAllTeacherDto = new GetAllTeacherDto();
            getAllTeacherDto.FirstName = teacher.FirstName;
            getAllTeacherDto.LastName = teacher.LastName;
            getAllTeacherDto.Id =teacher.Id;
            getAllTeacherDto.TeacherCode = teacher.TeacherCode;

            teachersDto.Add(getAllTeacherDto);

      }
      return teachersDto;
   }

   public void Delete(DeleteTeacherDto teacherDto)
   {
      _teacherRepository.Remove(teacherDto.Id);

     
    }
  
}