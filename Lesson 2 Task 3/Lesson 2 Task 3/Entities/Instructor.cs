using Lesson_2_Task_3.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Task_3.Entities;

public class Instructor
{
    private InstructorDal ınstructorDal;

    public Instructor(InstructorDal ınstructorDal)
    {
        this.ınstructorDal = ınstructorDal;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
