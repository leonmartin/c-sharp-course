using System;
using System.Collections.Generic;
  
class Account {
  
    public int AccountNumber;
    public decimal Balance;

    public List<Transaction> Transactions;

    public Account(int accountNumber) {
        AccountNumber = accountNumber;
        Balance = 0;
        List<Transaction> Transactions = new List<Transaction>(); 
    }

    public void MakeTransaction(decimal amount, int otherAccountNumber)
    {
        Transaction transaction = new Transaction(amount, otherAccountNumber);
        Transactions.Add(transaction);
        
        Balance += amount;
    }
}
