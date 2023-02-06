using System;
using System.Collections.Generic;

class Account
{
    public string AccountNumber;
    public decimal Balance;

    public List<Transaction> Transactions;

    public Account(string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
        Transactions = new List<Transaction>();
    }

    public void MakeTransaction(decimal amount, string otherAccountNumber)
    {
        Transaction transaction = new Transaction(amount, otherAccountNumber);
        Transactions.Add(transaction);

        Balance += amount;
    }
}
