public class Cat : Animal
{
    public Cat()
    {

    }
    public Cat(string name, string sex, int age) : base(name,sex,age)
    {

    }
    public override void MakeSound()
    {
        System.Console.WriteLine("myau");
    }
}

