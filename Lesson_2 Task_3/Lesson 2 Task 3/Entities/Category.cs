using Lesson_2_Task_3.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Task_3.Entities;

public class Category
{
    private CategoryDal categoryDal;

    public Category(CategoryDal categoryDal)
    {
        this.categoryDal = categoryDal;
    }

    public int id { get; set; }
    public string name { get; set; }

}
