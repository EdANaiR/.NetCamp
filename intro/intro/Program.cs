// See https://aka.ms/new-console-template for more information
using intro.Bussines;
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




CourseManager coursemanager = new CourseManager();
Course[] courses2 = coursemanager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}
