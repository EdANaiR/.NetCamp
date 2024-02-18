// See https://aka.ms/new-console-template for more information
using intro.Bussines;
using intro.DataAccess.Concretes;
using intro.Entities;

Console.WriteLine("Hello, World!");


bool isAuthenticated = false;

//condition
if (isAuthenticated)                // isAuthenticated==true ile aynı  
{
    Console.WriteLine("Buton --> Hoşgeldin Kullanıcı");
}
else
{
    Console.WriteLine("Buton-->Sisteme giriş yap");   
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" }; //Db'den gelir

for (int i =0; i<loans.Length; i++)                //i loans uzunluğundan büyük olana kadar döngüye devam et
{
    Console.WriteLine(loans[i]);                   // index değerlerini yazdırır.
}




CourseManager coursemanager = new(new EfCourseDal());
List<Course> courses2 = coursemanager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}




IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678";
customer1.FirstName = "Karahan";
customer1.LastName = "Yiğit";
customer1.CustomerNumber = "12356";


IndividualCustomer customer2 = new IndividualCustomer();
customer1.Id = 2;
customer1.NationalIdentity = "1234556";
customer1.FirstName = "Kenan";
customer1.LastName = "Işık";
customer1.CustomerNumber = "45698";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Tan";
customer3.CustomerNumber = "123654";
customer3.TaxNumber = "123654789";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Güneş";
customer4.CustomerNumber = "1236549";
customer4.TaxNumber = "1236547895";

//value types --> int, bool, double...
//reference types --> array, class, interface..


BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}
