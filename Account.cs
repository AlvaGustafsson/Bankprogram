using System;

public class Account
{
    private double balance;
    private Customer owner;
    private long accountNumber;

	public Account(Customer c, int n)
	{
        owner = c;
        accountNumber = parseLong("8000" + (100000 + n));
	}

    public bool deposit(double amount)
    {
        if(amount > 0)
            balance += amount;
        else
            return false;

        return true;
    }
}
