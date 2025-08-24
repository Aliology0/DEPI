using System;

public struct Account
{
    private int accountId;
    private string accountHolder;
    private decimal balance;

    #region Properties
    public int AccountId
    {
        get { return accountId; }
        set { accountId = value; }
    }

    public string AccountHolder
    {
        get { return accountHolder; }
        set { accountHolder = value; }
    }

    public decimal Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
                balance = value;
            else
                balance = 0;
        }
    }
    #endregion

    // Constructor
    public Account(int id, string holder, decimal initialBalance)
    {
        accountId = id;
        accountHolder = holder;
        balance = initialBalance >= 0 ? initialBalance : 0;
    }

    public override string ToString()
    {
        return $"Account ID: {AccountId}, Holder: {AccountHolder}, Balance: {Balance:C}";
    }
}