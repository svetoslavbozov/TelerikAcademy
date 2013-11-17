using System;
public class Discipline : ICommentable
{
    private string name;
    private int lectures;
    private int exercises;
    private string comments;

    public string Comments
    {
        get { return comments; }
        set { comments = value; }
    }

    public int Exercises
    {
        get { return exercises; }
        set { exercises = value; }
    }
    
    public int Lectures
    {
        get { return lectures; }
        set { lectures = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void AddComment(string comment)
    {
        this.Comments += comments + Environment.NewLine;
    }
    public Discipline()
    {

    }
}

