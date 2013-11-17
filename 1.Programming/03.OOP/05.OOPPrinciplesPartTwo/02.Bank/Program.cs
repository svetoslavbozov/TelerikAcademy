using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Deposit individualDeposit = new Deposit(new Individual("Pesho"), 100, (decimal)1.11);
            Deposit companyDeposit = new Deposit(new Company("Some Company"), 1000, (decimal)3.34);

            Account individualLoan = new Loan(new Individual("Misho"),1000,(decimal)15);
            Account companyLoan = new Loan(new Company("Second Company"),10000,(decimal)12.5);

            Account individualMortgage = new Mortgage(new Individual("Gosho"),10000,(decimal)19.5);
            Account companyMortgage = new Mortgage(new Company("Third Company"),100000,(decimal)15.5);

            individualDeposit.Deposit(100);
            companyDeposit.WithDraw(100);

            Bank OBB = new Bank();
            OBB.Add(individualDeposit);
            OBB.Add(individualLoan);
            OBB.Add(individualMortgage);
            OBB.Add(companyDeposit);
            OBB.Add(companyLoan);
            OBB.Add(companyMortgage);

            int months = 8;

            foreach (Account item in OBB.Accounts)
            {
                Console.WriteLine("Account type = {0} Account Owner = {1} Interest = {2:F4}",
                item.GetType().Name.PadRight(9, ' '),
                item.Customer.GetType().ToString().PadRight(11, ' '),
                item.CalculateInterest(months));
            }


            Console.WriteLine();
        }
    }

