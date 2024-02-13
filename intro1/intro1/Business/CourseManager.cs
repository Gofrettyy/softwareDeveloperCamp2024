using intro1.DataAccess.Abstracts;
using intro1.DataAccess.Concretes;
using intro1.Entities;

namespace intro1.Business;

public class CourseManager
{
   //business dataaccess katmanını newleyemez kuralın sebebi ise
   private ICourseDal _courseDal;
 //bu gördüğümüz desene dependency injection denir
   public CourseManager(ICourseDal courseDal)
   {
       _courseDal = courseDal;
   }

   //eğer sen beni newlersen bana bir courseDal vermek zorundasın.
   public List<Course> GetAll()
    {
        //business rules
       // CourseDal courseDal = new CourseDal(); // burda coursedala bağımlı olduğu için newlemek burada mantıksız. 
                            
        return _courseDal.GetAll();
    }
}