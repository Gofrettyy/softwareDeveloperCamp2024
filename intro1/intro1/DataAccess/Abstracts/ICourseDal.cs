using intro1.Entities;

namespace intro1.DataAccess.Abstracts;

public interface ICourseDal //interface arayüzdür imzalardan oluşur aslında bir şablondur yyani
{
    List<Course> GetAll();
    
    void Add(Course course);

}