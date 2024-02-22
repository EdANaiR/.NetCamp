using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

}
class SqlServerCustomerDal : ICustomerDal
{
    void ICustomerDal.Add()
    {
        Console.WriteLine("Sql Added");
    }

    void ICustomerDal.Delete()
    {
        Console.WriteLine("Sql Delete");
    }

    void ICustomerDal.Update()
    {
        Console.WriteLine("Sql Update");
    }
}

class OracleCustomerDal : ICustomerDal
{
    void ICustomerDal.Add()
    {
        Console.WriteLine("Oracle Added");
    }

    void ICustomerDal.Delete()
    {
        Console.WriteLine("Oracle Delete");
    }

    void ICustomerDal.Update()
    {
        Console.WriteLine("Oracle Update");
    } 
}

class CustomerManager    
{
    public void Add(ICustomerDal customerDal)
    {
        customerDal.Add();
    }
}