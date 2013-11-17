public class Loan : Account
{
    public Loan(Customer customer, decimal balance, decimal interest)
        : base(customer, balance, interest)
    {

    }

    public override decimal CalculateInterest(int months)
    {
        string type = this.Customer.GetType().ToString();
        decimal interest = 0;

        switch (type)
        {
            //get the type of customer and swith to calculate interest
            //if new type is added later just add case
            case "Individual":
                if (months > 3)
                {
                    interest = months * this.Interest;
                }
                break;
            case "Company":
                if (months > 2)
                {
                    interest = months * this.Interest;
                }
                break;
            default:
                break;
        }

        return interest;
    }
}

