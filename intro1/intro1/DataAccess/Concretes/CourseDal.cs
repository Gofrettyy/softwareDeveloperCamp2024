using intro1.DataAccess.Abstracts;
using intro1.Entities;

namespace intro1.DataAccess.Concretes;

public class CourseDal:ICourseDal //DataAccessLayer demek dal.
{   List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".NET 8 vs...";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "JAVA";
        course2.Description = "JAVA 17...";
        course2.Price = 0;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Phyton";
        course3.Description = "Phyton 3.12...";
        course3.Price = 0;

        courses = new List<Course> { course1, course2, course3 };

    }
    public List<Course> GetAll()
    {
        //burada db işlemleri yapılır.
        //sql tekrar et.

        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
    
}