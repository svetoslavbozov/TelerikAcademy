using System;
using System.Collections.Generic;

public class Bank
{
    private List<Account> accounts = new List<Account>();

    public List<Account> Accounts
    {
        get { return this.accounts; }
    }

    public void Add(Account account)
    {
        accounts.Add(account);
    }
}

