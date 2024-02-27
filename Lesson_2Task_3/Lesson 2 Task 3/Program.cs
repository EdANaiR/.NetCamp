// See https://aka.ms/new-console-template for more information
using Lesson_2_Task_3.Concretes;
using Lesson_2_Task_3.Entities;
using Lesson_2_Task_3.Abstracts;

Console.WriteLine("Hello, World!");




Course course = new(new CourseDal());
List<Course> course2 = Course.GetAll();

foreach (var Course in course1)
{
    Console.WriteLine(course.Id + " = " + course.Title);

}


Instructor instructor = new(new InstructorDal());
List<Instructor> instructor1 = instructor.GetAll();


Category category = new(new CategoryDal());
List<Course> category1 = course.GetAll();

foreach (var Category in category1)
{
    Console.WriteLine(category.id + " = " + category.name);

}