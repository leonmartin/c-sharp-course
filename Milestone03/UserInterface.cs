using System;
  
class UserInterface {

    public AccountsManager Manager;

    public string initMessage = """
        Please select one option by entering the according number:
        (1) Display Balance Overview.
        (2) Display Account Details.
        (3) Make a Transaction.
        (4) Exit.
        """;

    public UserInterface() 
    {
        Manager = new AccountsManager();
    }

    public void DisplayAccountsOverview()
    {
        List<Account> accounts = Manager.Accounts;

        foreach (Account account in accounts)
        {
            Console.WriteLine($"Account {account.AccountNumber}: {account.Balance}€ after {account.Transactions.Count} transactions.");
        }
    }

    public void DisplayAccountDetails(string accountNumber)
    {
        List<Account> accounts = Manager.Accounts;

        foreach (Account account in accounts)
        {
            if (account.AccountNumber == accountNumber)
            {
                Console.WriteLine(account);
                return;
            }
        }

        Console.WriteLine("No account with the specified number was found.");
    }

    public void ExitUserInterface()
    {
        Console.WriteLine("""
        ****************************************
        *************** Bye Bye! ***************
        ****************************************
        """);
        System.Environment.Exit(0);
    }
  
    public void LaunchUserInterface()
    {

        Console.WriteLine("""
        ****************************************
        *** Welcome to the best Banking App! ***
        ****************************************
        """);

        while (true)
        {
            Console.WriteLine(initMessage);

            string chosenOption = Console.ReadLine() ?? "1";
            int option = Int32.Parse(chosenOption);

            switch (option)
            {
                case 1:
                    DisplayAccountsOverview();
                    break;

                case 2:
                    Console.WriteLine("Please enter the account number:");
                    string accountNumber = Console.ReadLine() ?? "1";

                    DisplayAccountDetails(accountNumber);
                    break;

                case 3:
                    break;

                case 4:
                    ExitUserInterface();
                    break;

                default:
                    Console.WriteLine("This option is not available.");
                    break;
            }
        }
    }
}
