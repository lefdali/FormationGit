// See https://aka.ms/new-console-template for more information
using Formation;

Console.WriteLine("Hello, World!  ");

Formations git = new Formations();

git.Name = "git";
git.Id = 1;

List<Student> students = new List<Student>()
{
    new Student() { Id = 1,Name="Mouaad"},
    new Student() { Id = 2,Name="Ahmed"}
};   

git.Students = students;

foreach (Student std in students)
{

    Console.WriteLine(std.Name + " is included in formation " + git.Name);
}
    

//branche blefdali22


