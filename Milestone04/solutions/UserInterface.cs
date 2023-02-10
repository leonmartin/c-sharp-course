class UserInterface
{

    public AccountsManager Manager;

    public string initMessage = """
        Menu options:
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
            Console.WriteLine($"Account {account.AccountNumber}: {account.Balance} Euro after {account.Transactions.Count} transactions.");
        }
    }

    public void DisplayAccountDetails(string accountNumber)
    {
        List<Account> accounts = Manager.Accounts;

        foreach (Account account in accounts)
        {
            if (account.AccountNumber == accountNumber)
            {
                Console.WriteLine($"Account {account.AccountNumber} has {account.Balance} Euro.");
                Console.WriteLine($"\t{account.Transactions.Count} transactions are on record:");

                foreach (Transaction transaction in account.Transactions)
                {
                    Console.WriteLine("\t\t" + transaction);
                }

                return;
            }
        }

        Console.WriteLine("No account with the specified number was found.");
    }

    public void SubmitTransaction(string accountNumber, decimal amount, string otherAccountNumber)
    {
        List<Account> accounts = Manager.Accounts;

        foreach (Account account in accounts)
        {
            if (account.AccountNumber == accountNumber)
            {
                account.MakeTransaction(amount, otherAccountNumber);
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
            Console.Write("""
                Menu options:
                (1) Display Balance Overview.
                (2) Display Account Details.
                (3) Make a Transaction.
                (4) Exit.
                Please enter a number: 
                """);

            string chosenOption = Console.ReadLine() ?? "1";
            int option = Int32.Parse(chosenOption);

            switch (option)
            {
                case 1:
                    DisplayAccountsOverview();
                    break;

                case 2:
                    Console.Write("Please enter number of the account to be viewed: ");
                    string accountNumber = Console.ReadLine() ?? "1";

                    DisplayAccountDetails(accountNumber);
                    break;

                case 3:
                    Console.Write("Please enter the account number from which the amount is to be transferred: ");
                    string thisAccountNumber = Console.ReadLine() ?? "1";

                    Console.Write("Please enter the amount to be transferred: ");
                    string userInput = Console.ReadLine() ?? "0m";
                    decimal amount = Decimal.Parse(userInput);

                    Console.Write("Please enter the account number to which the amount is to be transferred: ");
                    string otherAccountNumber = Console.ReadLine() ?? "1";

                    SubmitTransaction(thisAccountNumber, amount, otherAccountNumber);
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
