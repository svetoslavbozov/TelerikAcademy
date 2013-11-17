public class Worker : Human
{
    private int weekSalary;
    private int workHoursPerDay;

    public int WorkHoursPerDay
    {
        get { return workHoursPerDay; }
        set { workHoursPerDay = value; }
    }

    public int WeekSalary
    {
        get { return weekSalary; }
        set { weekSalary = value; }
    }
    public int MoneyPerHour()
    {
        return weekSalary / 5 / workHoursPerDay;
    }
    public Worker()
    {

    }
}
