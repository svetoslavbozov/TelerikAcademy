public class Students
{
    private string firstName;
    private string lastName;
    private int age;
    public Students(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Students(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
        
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
        
}

