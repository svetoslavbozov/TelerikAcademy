public class Frog : Animal
{
    public Frog()
    {

    }
    public Frog(string name, string sex, int age)
        : base(name, sex, age)
    {

    }
    public override void MakeSound()
    {
        System.Console.WriteLine("ribbit");
    }
}

