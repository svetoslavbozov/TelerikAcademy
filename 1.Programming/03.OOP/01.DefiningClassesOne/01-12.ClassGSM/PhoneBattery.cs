using System;

public enum BatteryType
{
    LiIon, NiMH, NiCd
}
 
public class PhoneBattery
{
    private string model;
    private int? hoursTalk;
    private int? hoursIdle;
    private BatteryType? batteryType = null;

    public PhoneBattery()
    {
    }

    public PhoneBattery(string model)
    {
        this.model = model;
    }

    public PhoneBattery(string model, int hoursTalk)
    {
        this.model = model;
        this.hoursTalk = hoursTalk;
    }

    public PhoneBattery(string model, int hoursTalk, int hoursIdle)
    {
        this.model = model;
        this.hoursTalk = hoursTalk;
        this.hoursIdle = hoursIdle;
    }

    public BatteryType? BatteryType
    {
        get { return this.batteryType; }
        set { this.batteryType = value; }
    }

    public string Model 
    {
        get { return this.model; }
        set { this.model = value; } 
    }

    public int? HoursTalk
    {
        get { return this.hoursTalk; }
        set { this.hoursTalk = value; }
    }

    public int? HoursIdle
    {
        get { return this.hoursIdle; }
        set { this.hoursIdle = value; }
    }
}

