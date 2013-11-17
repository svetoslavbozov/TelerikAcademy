public class People
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public People()
    {

    }

    public People(string name)
    {
        this.Name = name;
    }
}

