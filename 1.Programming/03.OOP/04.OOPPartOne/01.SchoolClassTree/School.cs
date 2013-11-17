using System.Collections.Generic;

public class School
{
    private List<Student> students;
    private List<Class> classes;

    public List<Class> MyProperty
    {
        get { return classes; }
        set { classes = value; }
    }

    public List<Student> Students
    {
        get { return students; }
        set { students = value; }
    }
    public School()
    {

    }
}

