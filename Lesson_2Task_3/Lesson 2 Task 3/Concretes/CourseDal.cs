using Lesson_2_Task_3.Abstracts;
using Lesson_2_Task_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Task_3.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> courses;


    public CourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Title = "2024 Yazılım Geliştirici Yetiştirme Kampı";
        course1.Description = "C# Version 5..";
        course1.Price = 0;
        course1.Instructor = "Engin Demirog";
        course1.Category = "Programlama";
        course1.ImageUrl = "";
        course1.StartDate = DateTime.Now;
        course1.EndDate = DateTime.Now;
        course1.Language = "C#";
        course1.Level = "Junior";



        Course course2 = new Course();
        course2.Id = 2;
        course2.Title = "Yazılım Geliştirici Yetiştirme Kampı (C# + Angular)";
        course2.Description = "Angular..";
        course2.Price = 0;
        course2.Instructor = "Engin Demirog";
        course2.Category = "Programlama";
        course2.ImageUrl = "";
        course2.StartDate = DateTime.Now;
        course2.EndDate = DateTime.Now;
        course2.Language = "Angular and C#";
        course2.Level = "Junior";


        Course course3 = new Course();
        course3.Id = 3;
        course3.Title = "Yazılım Geliştirici Yetiştirme Kampı (Java + REACT)";
        course3.Description = "Java..";
        course3.Price = 0;
        course3.Instructor = "Engin Demirog";
        course3.Category = "Programlama";
        course3.ImageUrl = "";
        course3.StartDate = DateTime.Now;
        course3.EndDate = DateTime.Now;
        course3.Language = "Java and React";
        course3.Level = "Junior";



        courses = new List<Course> { course1, course2, course3 };
    }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Remove(Course course)
        {
            Course courseToDelete = courses.SingleOrDefault(c => c.Id == course.Id);
            if (course != null)
            {
                courses.Remove(courseToDelete);
            }
        }

        public void Update(Course course)
        {
            Course courseToUpdate = courses.SingleOrDefault(c => c.Id == course.Id);
            if (courseToUpdate != null)
            {
                courseToUpdate.Title = course.Title;
            }
        }
    }


