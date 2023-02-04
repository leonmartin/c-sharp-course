using System;
  
class UserInterface {

    public AccountsManager myAccountsManager;

    public string initMessage = """
        Please select one option by entering the according number:
        (1) Display Balance Overview.
        (2) Display Account Details.
        (3) Make a Transaction.
        (4) Exit.
        """;

    public UserInterface() 
    {
        AccountsManager myAccountsManager = new AccountsManager();
    }

    public void DisplayAccountsOverview()
    {
        List<Account> accounts = myAccountsManager.Accounts;

        foreach (Account account in accounts)
        {
            Console.WriteLine(account);
        }
    }

    public void DisplayAccountDetails(int accountNumber)
    {
        List<Account> accounts = myAccountsManager.Accounts;

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
            int option = Int16.Parse(chosenOption);

            switch (option)
            {
                case 1:
                    DisplayAccountsOverview();
                    break;

                case 2:
                    Console.WriteLine("Please enter the account number:");
                    string userInput = Console.ReadLine() ?? "1";
                    int accountNumber = Int16.Parse(userInput);

                    DisplayAccountDetails(accountNumber);
                    break;

                case 3:
                    ExitUserInterface();
                    break;

                default:
                    Console.WriteLine("This option is not available.");
                    break;
            }
        }
    }
}
