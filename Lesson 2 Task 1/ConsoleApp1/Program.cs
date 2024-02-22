// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");


int num = 255;

Console.WriteLine("Number: "+num);

var number = 10;
Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");   // Single Lıne If

string[] students = { "asya", "tugba", "hüseyin" };

foreach(var student in students)
{
    Console.WriteLine(student);
}


//Çok Boyutlu Diziler

string[,] regions = new string[4,3]      //4-> satır  3->Sutün   //Burada 0'dan başlamaz index
{
    {"antalya","bursa","balıkesir" }, 
    { "ankara", "Konya", "Yozgat"},
    { "antalya","Adana","Mersin"},
    { "Rize", "İzmir", "Samsun"}
};




for (int i = 0; i<= regions.GetUpperBound(0); i++)
{
    for(int j = 0; j<= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("****************");

}
string[] studentts = new string[3] { "Eda", "Hüseyin", "Hayat" };

foreach (var studd in studentts)        //studd elemanı studenttsde' ki elemanları sahiplenir
{
    Console.WriteLine(studd);
}

//FOREACH daha çok Veri tabanında datayı gezmek için kullanılır


CustomerManager customerManager = new CustomerManager();
customerManager.Add(new SqlServerCustomerDal()); //Katmanlar arası geçiş 



Courses course = new Courses();
course.ID = 12563;
course.Name = "English";
course.Description = "Verbb";
course.price = 1256;

Console.WriteLine(course.Name + " - " + course.Description + " - " + course.price);



