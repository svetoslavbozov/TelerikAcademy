public abstract class Account
{
    private Customer customer;
    private decimal balance;
    private decimal interest;

    public decimal Interest
    {
        get { return interest; }
        set { interest = value; }
    }

    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public Customer Customer
    {
        get { return customer; }
        set { customer = value; }
    }

    public Account(Customer customer, decimal balance, decimal interest)
    {
        this.Customer = customer;
        this.Balance = balance;
        this.Interest = interest;
    }

    public void Deposit(decimal amount)
    {
        this.Balance += amount;
    }

    public abstract decimal CalculateInterest(int months);

}
