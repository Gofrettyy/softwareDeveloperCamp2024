// See https://aka.ms/new-console-template for more information

using intro1.Business;
using intro1.DataAccess.Concretes;
using intro1.Entities;

Console.WriteLine("Hello, World!");

string message1 ="Krediler";
int term = 12;
double amount =100000;

//variables --> camelCase yazılır.
bool isAuthenticated = true;
Console.WriteLine(message1);

//condition
if (isAuthenticated)
{
    Console.WriteLine("Buton-->Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Buton-->Sisteme giriş yap");
}



//Array

string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5", "Kredi6" };
//string[] loans2 = new string[6];
//loans2[0]="Kredi 1";

     //start        condition   //increment
/*for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}*/

CourseManager courseManager = new(new EfCourseDal()); //new syntax
List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++) //liste olunca count yazmak gerek lenght değilde.
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}
Console.WriteLine("kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id=1;
customer1.NationalIdentity="12345678922";
customer1.FirstName="Nazife";
customer1.LastName="Aliçavuş";
customer1.CustomerNumber="123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id=2;
customer2.NationalIdentity="12345678921";
customer2.FirstName="Nehir";
customer2.LastName="Aliçavuş";
customer2.CustomerNumber="123457";

CoorporateCustomer customer3 = new();
customer3.Id = 3;
customer3.CustomerNumber = "654778";
customer3.Name = "Kodlamaio";
customer3.TaxNumber="1234567893";

CoorporateCustomer customer4 = new(); //.net8de bu şekildede newleyebilirsin bir classı
customer4.Id = 4;
customer4.CustomerNumber = "654738";
customer4.Name = "Abc";
customer4.TaxNumber="1234534243";

//value types --> int,bool,double...
//reference types--> arrays, classes,abstract classes,interfaces


//aşağıdaki durum bir polymorpism örneğidir.
BaseCustomer[] customers = {customer1,customer2,customer3,customer4};

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);  
}