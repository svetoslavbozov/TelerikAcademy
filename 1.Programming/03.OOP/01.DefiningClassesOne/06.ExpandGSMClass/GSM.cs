using System;
using System.Text;

class GSM
{
    private string model = null;
    private string manufacturer = null;
    private int? price = null;
    private string owner = null;
    private PhoneBattery battery = new PhoneBattery();
    private PhoneDisplay display = new PhoneDisplay();

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
}

