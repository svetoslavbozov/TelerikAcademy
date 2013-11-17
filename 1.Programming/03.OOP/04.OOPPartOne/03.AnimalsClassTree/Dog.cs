public class Dog : Animal
{
    public Dog()
    {

    }
    public Dog(string name, string sex, int age)
        : base(name, sex, age)
    {

    }
    public override void MakeSound()
    {
        System.Console.WriteLine("bark bark");
    }
}

