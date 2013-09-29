using System;

public class PhoneDisplay
{
    private int? size = null;
    private int? colors = null;

    public int? Colors
    {
        get { return this.colors; }
        set { this.colors = value; }
    }
    public int? Size
    {
        get { return this.size; }
        set { this.size = value; }
    }
    public PhoneDisplay()
    {

    }
    public PhoneDisplay(int size)
    {
        this.size = size;
    }
    public PhoneDisplay(int size, int colors)
    {
        this.size = size;
        this.colors = colors;
    }
}

