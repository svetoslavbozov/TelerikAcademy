/*Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour in descending order. Merge the lists and sort them by first name and last name.*/


using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static string[] firstNames = { "Tora", "Suber", "Fern", "Linares", "Donita", "Brodersen", "Stefanie", "Mcroy", "Elmo", "Aron", "Edris", "Abram", "Jennifer", "Morlan", "Monica", "Buesing", "Leann", "Moralez", "Belinda", "Mcabee" };

    static string[] lastNames = { "Owen", "Trammel", "Bobbie", "Felberbaum", "Susan", "Dinapoli", "Elvina", "Sawtelle", "Paola", "Granados", "Hazel", "Devore", "Stacia", "Soderberg", "Ricki", "Fortenberry", "Tien", "Derossett", "Chia", "Bozarth" };

    static Random randomGenerator = new Random();

    const int GROUPS_COUNT = 10;

    static void Main()
    {

        List<Student> students = new List<Student>();
        //populate students list
        for (int i = 0; i < GROUPS_COUNT; i++)
        {
            Student currentStudent = new Student();

            //first and last name selected from the static arrays with random generated index
            currentStudent.FirstName = firstNames[randomGenerator.Next(0, firstNames.Length - 1)];
            currentStudent.Lastname = lastNames[randomGenerator.Next(0, lastNames.Length - 1)];

            //random generated grade between 1 and 12
            currentStudent.Grade = randomGenerator.Next(1, 12);

            students.Add(currentStudent);
        }

        List<Worker> workers = new List<Worker>();
        //populate workers list
        for (int i = 0; i < GROUPS_COUNT; i++)
        {
            Worker currentWorker = new Worker();

            //first and last name selected from the static arrays with random generated index
            currentWorker.FirstName = firstNames[randomGenerator.Next(0, firstNames.Length - 1)];
            currentWorker.Lastname = lastNames[randomGenerator.Next(0, lastNames.Length - 1)];

            //random generated week salary and work hours per day
            currentWorker.WeekSalary = randomGenerator.Next(500, 10000);
            currentWorker.WorkHoursPerDay = randomGenerator.Next(1, 12);

            workers.Add(currentWorker);
        }

        //sort with extention method and print students
        var lambdaSortedStudents = students.OrderBy(x => x.Grade).ToList();

        Console.WriteLine("Students sorted with extention method\n ");

        foreach (var item in lambdaSortedStudents)
        {
            Console.WriteLine("{0} {1} {2}", item.Grade, item.FirstName, item.Lastname);
        }

        //sort with LINQ and print students
        var linqSortedStudents =
            from student in students
            orderby student.Grade
            select student;

        Console.WriteLine();
        Console.WriteLine("Students sorted with linq\n");

        foreach (var item in linqSortedStudents)
        {
            Console.WriteLine("{0} {1} {2}", item.Grade, item.FirstName, item.Lastname);
        }

        //sort with extention method and print workers
        var lambdaSortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();

        Console.WriteLine();
        Console.WriteLine("Workers sorted with extentio method\n");

        foreach (var item in lambdaSortedWorkers)
        {
            Console.WriteLine("{0} {1} {2}", item.MoneyPerHour(), item.FirstName, item.Lastname);
        }

        //sort witn LINQ and print workers
        var linqSortedWorkers =
            from worker in workers
            orderby worker.MoneyPerHour() descending
            select worker;

        Console.WriteLine();
        Console.WriteLine("Workers sorted with linq\n");

        foreach (var item in linqSortedWorkers)
        {
            Console.WriteLine("{0} {1} {2}", item.MoneyPerHour(), item.FirstName, item.Lastname);
        }

        //merge students and workers sort both ways and print results
        List<Human> humans = new List<Human>();
        humans.AddRange(students);
        humans.AddRange(workers);

        var lambdaSorterHumans = humans.OrderBy(x => x.FirstName).ThenBy(x => x.Lastname);

        Console.WriteLine();
        Console.WriteLine("Humans sorted with extention method\n");

        foreach (var item in lambdaSorterHumans)
        {
            Console.WriteLine("{0} {1}", item.FirstName, item.Lastname);
        }

        var linqSortedHumans =
            from human in humans
            orderby human.FirstName, human.Lastname
            select human;

        Console.WriteLine();
        Console.WriteLine("Humans sorted with linq\n");

        foreach (var item in linqSortedHumans)
        {
            Console.WriteLine("{0} {1}", item.FirstName, item.Lastname);
        }

        Console.WriteLine();
    }
}
