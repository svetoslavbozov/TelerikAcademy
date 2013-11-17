public class Mortgage : Account
{
    public Mortgage(Customer customer, decimal balance, decimal interest)
        : base(customer, balance, interest)
    {

    }
    public override decimal CalculateInterest(int months)
    {
        //get the type of customer and swith to calculate interest
        //if new type is added later just add case
        string type = this.Customer.GetType().ToString();
        decimal result = 0;

        switch (type)
        {
            case "Individual":

                if (months > 6)
                {
                    result = (decimal)(months * this.Interest);
                }

                break;

            case "Company":

                if (months > 12)
                {
                    result += ((months - 12) *  this.Interest);
                }

                result += (months * this.Interest) / 2;

                break;

            default:
                break;
        }

        return result;
    }
}

