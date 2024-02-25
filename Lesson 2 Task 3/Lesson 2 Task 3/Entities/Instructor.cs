using Lesson_2_Task_3.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Task_3.Entities;

public class Instructor
{
    private InstructorDal instructorDal;

    public Instructor(InstructorDal instructorDal)
    {
        this.instructorDal = instructorDal;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
