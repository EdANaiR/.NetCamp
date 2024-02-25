using Lesson_2_Task_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Task_3.Abstracts;

public interface ICategoryDal
{
    List<Category> GetAll();
    void Add(Category category);
    void Remove(Category category);
    void Update(Category category);
}
