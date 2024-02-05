using intro1.Entities;

namespace intro1.Business;

public class CourseManager
{
     Course[] courses = new Course[3];
    //constructor
    public CourseManager()
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

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }
    public Course[] GetAll()
    {
        //burası normalde veri kaynağından çekilir.
        return courses;
    }
}