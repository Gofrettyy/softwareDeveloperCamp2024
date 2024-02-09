// See https://aka.ms/new-console-template for more information

using intro1.Business;
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

CourseManager courseManager = new(); //new syntax
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}
Console.WriteLine("kod bitti");