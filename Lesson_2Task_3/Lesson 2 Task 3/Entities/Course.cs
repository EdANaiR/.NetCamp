using Lesson_2_Task_3.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Lesson_2_Task_3.Entities;

public class Course
{
    
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Instructor { get; set; }
    public string ImageUrl { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Price { get; set; }
    public string Category { get; set; }
    public string Level { get; set; }
    public string Language { get; set; }
    
   

}
