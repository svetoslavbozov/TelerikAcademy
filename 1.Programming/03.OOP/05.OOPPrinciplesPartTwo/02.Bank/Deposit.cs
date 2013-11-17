using System;
public class Deposit : Account, IWithdrawable
{
    public Deposit(Customer customer, decimal balance, decimal interest)
        : base(customer, balance, interest)
    {

    }
    public override decimal CalculateInterest(int months)
    {
        decimal interest = 2;

        if (this.Balance >= 1000)
        {
            interest = months * this.Interest;
        }

        return interest;
    }

    public void WithDraw(decimal amount)
    {
        if (amount > this.Balance)
        {
            throw new ArgumentOutOfRangeException("Insufficient funds");
        }
        else
        {
            this.Balance -= amount;
        }
    }
}

