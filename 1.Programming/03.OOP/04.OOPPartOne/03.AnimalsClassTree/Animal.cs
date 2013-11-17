using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Animal : ISound
{
    private string name = "none";
    private string sex = "none";
    private int age = 0;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    
    public string Sex
    {
        get { return sex; }
        set { sex = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public Animal()
    {

    }
    public Animal(string name, string sex, int age)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }

    public abstract void MakeSound();
    public static void PrintAverage(Animal[] animals)
    {
        var result =
            from animal in animals
            group animal by animal.GetType();

        foreach (var item in result)
        {
            Console.WriteLine("{0} - {1}", item.Key.Name, item.Average(x => x.Age));
        }
    }
}

