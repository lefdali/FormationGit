// See https://aka.ms/new-console-template for more information
using Formation;

Console.WriteLine("Hello, World!  ");

Formations git = new Formations();

git.Name = "git";
git.Id = 1; 

List<Student> students = new List<Student>()
{
    new Student() { Id = 1,Name="Mouaad"}
};   

git.Students = students;


Console.WriteLine("mkharchich changes");

//branche blefdali22


