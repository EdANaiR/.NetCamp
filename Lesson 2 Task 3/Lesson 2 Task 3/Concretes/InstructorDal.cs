using Lesson_2_Task_3.Abstracts;
using Lesson_2_Task_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Task_3.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> instructors;


    public InstructorDal()
    {
        Instructor instructor1 = new Instructor();
        instructor1.Id = 1;
        instructor1.FirstName = "Engin";
        instructor1.LastName = "Demirog";
        instructor1.Email = "EnginDemiro@gmail.io";

        Instructor instructor2 = new Instructor();
        instructor2.Id = 2;
        instructor2.FirstName = "Halit Enes";
        instructor2.LastName = "Kalaycı";
        instructor2.Email = "Halit Kalaycı@gmail.io";

        instructors = new List<Instructor> { instructor1, instructor2 };
    }
    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
    }

    public void Add(Course course)
    {
        throw new NotImplementedException();
    }

    public List<Instructor> GetAll()
    {
        return instructors;
    }

    public void Remove(Instructor instructor)
    {
        Instructor instructorToRemove = instructors.SingleOrDefault(i => i.Id == instructor.Id);
        if (instructorToRemove != null)
        {
            instructors.Remove(instructorToRemove);
        }
    }

    public void Remove(Course course)
    {
        throw new NotImplementedException();
    }

    public void Update(Instructor instructor)
    {
        Instructor instructorToUpdate = instructors.SingleOrDefault(i => i.Id == instructor.Id);
        if (instructorToUpdate != null)
        {
            instructorToUpdate.FirstName = instructor.FirstName;
            instructorToUpdate.LastName = instructor.LastName;
        }
    }

    public void Update(Course course)
    {
        throw new NotImplementedException();
    }
}
