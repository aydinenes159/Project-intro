
using intro.Business;
using intro.Entities;

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables -->camleCase
bool isAuthenticated = false;
Console.WriteLine(message1);

if (isAuthenticated)
{

    Console.WriteLine("Buton --> Hoşgeldin Enes");


}
else
{
    Console.WriteLine("Buton -->Sisteme giriş yap");
}

string[] loans = { "kredi 1", "kredi 2", "kredi 3", "kredi 4", "kredi 5", "kredi 6" };
//string[] loans2 =new string[0];
//loans2[] "kredi 1";




//start   conditiion   //increment
for(int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

Course course = new Course();
course.Id = 1;
course.Name = "c#";
course.Description = ".Net 8 vs ....";
course.price = 0;

Course course1 = new Course();
course1.Id = 1;
course1.Name = "Java";
course1.Description = "java 17 ....";
course1.price = 10;

Course course2 = new Course();
course2.Id = 1;
course2.Name = "Python";
course2.Description = "Python 3.12 .....";
course2.price = 20;

Course[] courses = {course, course1, course2 };

for(int i = 0;i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + "/" + courses[i].price);
}

CourseManager courseManager = new CourseManager();
Course[]courses2= courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses[i].price);
}


Console.WriteLine("kod bitti");