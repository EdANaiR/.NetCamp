using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.DataAccess.Abstracts;

public interface ICourseDal            //Beni implemente eden bunları eklemek zorunda 
{                                   
    List<Course> GetAll();
    void Add(Course course);
}
