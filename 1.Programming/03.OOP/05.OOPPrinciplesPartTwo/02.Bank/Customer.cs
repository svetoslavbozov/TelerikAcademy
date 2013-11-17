public abstract class Customer
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Customer(string name)
    {
        this.Name = name;
    }
    
}
