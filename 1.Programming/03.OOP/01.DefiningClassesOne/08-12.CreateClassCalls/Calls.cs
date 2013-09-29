using System;
using System.Text;

class Calls
{    

    private DateTime dateAndTime;
    private double duration;
    private string phoneNumber;

    //public static readonly double costPerCall = 0.37;

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }

    public double Duration
    {
        get { return duration; }
        set { duration = value; }
    }
    
    public DateTime Date
    {
        get { return dateAndTime; }
        set { dateAndTime = value; }
    }

    public Calls(DateTime date, int duration, string phoneNumber)
    {
        this.dateAndTime = date;
        this.duration = duration;
        this.phoneNumber = phoneNumber;
    }
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        result.AppendLine(this.dateAndTime.ToString());
        result.AppendLine(this.duration.ToString());
        result.AppendLine(this.phoneNumber);

        return result.ToString();
    }
}

