using Lesson_2_Task_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Task_3.Abstracts
{
    public interface IInstructorDal
    {

        List<Instructor> GetAll();
        void Add(Instructor instructor);
        void Remove(Instructor instructor);
        void Update(Instructor instructor);
    }
}
