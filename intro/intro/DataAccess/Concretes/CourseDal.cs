using intro.Bussines;
using intro.DataAccess.Abstracts;
using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.DataAccess.Concretes;

public class CourseDal:ICourseDal
{
    List<Course> courses;

    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = "C# Version 5..";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Java";
        course2.Description = "Java Version 8..";
        course2.Price = 1500;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Delphi";
        course3.Description = "Delphi Version 11..";
        course3.Price = 500;

       courses =new List<Course> {course1, course2, course3};   

    }    
    public List<Course> GetAll()
    {
        //db işlemleri yapılır

        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);    
    }

}
