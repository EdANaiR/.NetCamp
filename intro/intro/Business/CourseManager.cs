using intro.DataAccess.Abstracts;
using intro.DataAccess.Concretes;
using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Bussines;

public class CourseManager
{
    //dependency injection
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    

    public List<Course> GetAll()     //Method
    {
        //business Rules
        //Veri kaynağından çekilir.
        return _courseDal.GetAll();
    }

}
