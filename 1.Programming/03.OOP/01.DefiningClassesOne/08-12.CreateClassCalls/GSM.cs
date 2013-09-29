using System;
using System.Text;
using System.Collections.Generic;

class GSM
{
    private string model = null;
    private string manufacturer = null;
    private int? price = null;
    private string owner = null;
    private PhoneBattery battery = new PhoneBattery();
    private PhoneDisplay display = new PhoneDisplay();

    private static GSM iPhone4S = new GSM("IPhone", "Apple");

    private List<Calls> callHistory = new List<Calls>();

    public List<Calls> CallHistory
    {
        get { return callHistory; }
        set { callHistory = value; }
    }    

    public static GSM IPhone
    {
        get { return iPhone4S; }
    }

    public PhoneDisplay Display
    {
        get { return display; }
        set { display = value; }
    }    

    public PhoneBattery Battery
    {
        get { return battery; }
        set { battery = value; }
    }    

    public string Owner
    {
        get { return owner; }
        set { owner = value; }
    }    

    public int? Price
    {
        get { return price; }
        set { price = value; }
    }
    public string Manufacturer
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }
    

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public GSM(string model, string manufacturer)
    {
        this.model = model;
        this.manufacturer = manufacturer;
    }
    public GSM(string model, string manufacturer, int price) : this(model, manufacturer)
    {
        this.price = price;
    }
    public GSM(string model, string manufacturer, int price, string owner)
        : this(model, manufacturer, price)
    {
        this.owner = owner;
    }
    public GSM(string model, string manufacturer, int price, string owner, PhoneBattery battery)
        : this(model, manufacturer, price, owner)
    {
        this.battery = battery;
    }
    public GSM(string model, string manufacturer, int price, string owner, PhoneBattery battery, PhoneDisplay display)
        : this(model, manufacturer, price, owner, battery)
    {
        this.display = display;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        result.AppendLine(this.model);
        result.AppendLine(this.manufacturer);
        result.AppendLine(this.price.ToString());
        result.AppendLine(this.owner);
        result.AppendLine(this.battery.BatteryType.ToString());
        result.AppendLine(this.battery.HoursIdle.ToString());
        result.AppendLine(this.battery.HoursTalk.ToString());
        result.AppendLine(this.battery.Model);
        result.AppendLine(this.display.Size.ToString());
        result.AppendLine(this.display.Colors.ToString());

        return result.ToString();
    }

    public void DeleteCallHistory()
    {
        this.callHistory.Clear();
    }
    public void DeleteCall(int index)
    {
        this.callHistory.RemoveAt(index);
    }
    public void DeleteCall(Calls call)
    {
        this.callHistory.Remove(call);
    }
    //public double CallsTotalCost()
    //{
    //    double cost = 0;

    //    foreach (var item in this.callHistory)
    //    {
    //        cost += (item.Duration / 60) * Calls.costPerCall;
    //    }

    //    return cost;
    //}

    public double CallsTotalCost(double price)
    {
        double cost = 0;

        foreach (var item in this.callHistory)
        {
            cost += (item.Duration / 60) * price;
        }

        return cost;
    }
}

