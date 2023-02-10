AccountsManager manager = new AccountsManager();

// Test printing accounts and account details
List<Account> accounts = manager.loadAccountsOfUser();

foreach (Account account in accounts)
{
    Console.WriteLine(account.AccountNumber, account.Balance, account.Transactions.Count);

    foreach (Transaction transaction in account.Transactions)
    {
        Console.WriteLine(transaction);
    }
}

// Test making a transaction
Account someAccount = accounts.ElementAt(0);

Console.WriteLine(someAccount.Balance);
accounts.ElementAt(0).MakeTransaction(1234.42m, "9367348923");
Console.WriteLine(someAccount.Balance);
