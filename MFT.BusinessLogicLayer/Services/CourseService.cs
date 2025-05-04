using MFT.BusinessLogicLayer.Dtos.Courses;
using MFT.DataAccessLayer.Entities;
using MFT.DataAccessLayer.Repositories;
using MFT.DataAccessLayer.Repositories.Contracts;

namespace MFT.BusinessLogicLayer.Services;

public class CourseService
{
    private ICourseRepository _courseRepository;
    

    public CourseService()
    {
        _courseRepository = new CourseRepository() ;
    }

    public GetCoursesDto Get(int id)
    {
        Course course = _courseRepository.GetById(id);
        GetCoursesDto coursesDto = new GetCoursesDto()
        {
            Capacity = course.Capacity,
            Name = course.Name,
         
        };
        return coursesDto;
       
    }

    public GetCoursesDto Get(string name)
    {
        Course course = _courseRepository.GetCourseByName(name);
        GetCoursesDto coursesDto = new GetCoursesDto()
        {
            Capacity = course.Capacity,
            Name = course.Name,
           
        };
        return coursesDto;
    }
    public List<GetAllCoursesDto> GetAll()
    {
        
        List<Course> courses = _courseRepository.GetAll();
        
        List<GetAllCoursesDto> destinationCourses = new List<GetAllCoursesDto>();

        foreach (Course course in courses)
        {
            GetAllCoursesDto getAllCoursesDto = new GetAllCoursesDto();
            getAllCoursesDto.Id = course.Id;
            getAllCoursesDto.Name = course.Name;
            getAllCoursesDto.Capacity = course.Capacity;
            getAllCoursesDto.Code = course.Code;
            
            
            destinationCourses.Add(getAllCoursesDto);
        }
        return destinationCourses;
    }

    
   public void Update(Course courses)
   {
       UpdateCourseDto updateCourseDto = new UpdateCourseDto()
       {
           Name = courses.Name,
           Capacity = courses.Capacity,
           Code = courses.Code,
           Id = courses.Id
       };
       _courseRepository.Update(courses);
   }
    public void Add(AddCourseDto addCourseDto)
    {
        Course course = new();

        course.Name = addCourseDto.Name;
        course.Capacity = addCourseDto.Capacity;
        course.Code = addCourseDto.Code;
        course.Teacher.Id = addCourseDto.TeacherId;

               
        _courseRepository.Add(course);

    }

    public void Delete(DeleteCourseDto deleteCourseDto)
    {
        _courseRepository.Remove(deleteCourseDto.Id);
    }
    

    public GetAllCoursesDto GetByName(string name)
    {
        Course course = _courseRepository.GetCourseByName(name);
        GetAllCoursesDto getAllCoursesDto = new GetAllCoursesDto();

        getAllCoursesDto.Id = course.Id;
        getAllCoursesDto.Name = course.Name;
        getAllCoursesDto.Capacity = course.Capacity;    
        getAllCoursesDto.Code = course.Code;

        return getAllCoursesDto;
    }

    public void AddStudentInCourse(int courseId, int studentId)
    {
        Course course = _courseRepository.GetById(courseId);
        Student student = course.Students.FirstOrDefault(e => e.Id == studentId);
        
        course.Students.Add(student);
    }

    public void Update(UpdateCourseDto courseDto)
    {
       Course course = _courseRepository.GetById(courseDto.Id);

      
        course.Name = courseDto.Name;
        course.Capacity = courseDto.Capacity;   
        course.Code = courseDto.Code;
        

        _courseRepository.Update(course);
    }
}