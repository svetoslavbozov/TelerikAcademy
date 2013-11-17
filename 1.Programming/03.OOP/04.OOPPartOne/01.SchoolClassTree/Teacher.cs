using System;
using System.Collections.Generic;

public class Teacher : People , ICommentable
{
    private List<Discipline> disciplines;
    private string comments;

    public string Comments
    {
        get { return comments; }
        set { comments = value; }
    }
    
    public List<Discipline> Disciplines
    {
        get { return disciplines; }
        set { disciplines = value; }
    }

    public Teacher()
    {

    }

    public Teacher(string name) : base(name)
    {

    }

    public void AddComment(string comment)
    {
        this.Comments += comment + Environment.NewLine;
    }
}

