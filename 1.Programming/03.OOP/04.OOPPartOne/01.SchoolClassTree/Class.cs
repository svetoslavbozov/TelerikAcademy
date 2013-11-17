using System;
using System.Collections.Generic;
public class Class
{
    private List<Teacher> teachers;
    private string identifier;
    private string comments;

    public string Comments
    {
        get { return comments; }
        set { comments = value; }
    }
    
    public string Idendtifier
    {
        get { return identifier; }
        set { identifier = value; }
    }
    
    public List<Teacher> Teachers
    {
        get { return teachers; }
        set { teachers = value; }
    }

    public void AddComment(string comment)
    {
        this.Comments += comment + Environment.NewLine;
    }
    public Class()
    {

    }
}

