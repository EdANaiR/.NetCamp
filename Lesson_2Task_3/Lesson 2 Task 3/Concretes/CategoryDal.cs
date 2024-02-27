using Lesson_2_Task_3.Abstracts;
using Lesson_2_Task_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_Task_3.Concretes;

public class CategoryDal : ICategoryDal
{


    List<Category> categorys;


    public CategoryDal()
    {
        Category category1 = new Category();
        category1.id = 1;
        category1.name = "Programlama";


        Category category2 = new Category();
        category1.id = 2;
        category2.name = "Tümü";



        categorys = new List<Category> { category1, category2 };
    }

    public void Add(Category category)
    {
         categorys.Add(category);
    }

    public List<Category> GetAll()
    {
        return categorys;
    }

  

    public void Remove(Category category)
    {
        throw new NotImplementedException();
    }

    

    public void Update(Category category)
    {
        throw new NotImplementedException();
    }
}
