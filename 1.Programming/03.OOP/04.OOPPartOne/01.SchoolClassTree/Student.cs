using System;
public class Student : People, ICommentable
{
    private int classNumber;
    private string comments;

    public string Comments
    {
        get { return comments; }
        set { comments = value; }
    }
    
    public int ClassNumber
    {
        get { return classNumber; }
        set { classNumber = value; }
    }

    public Student()
    {

    }
    public Student(string name) : base(name)
    {

    }

    public void AddComment(string comment)
    {
        this.Comments += comment + Environment.NewLine;
    }
    
}
