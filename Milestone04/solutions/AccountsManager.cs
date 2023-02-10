class AccountsManager {

    public List<Account> Accounts;

    public AccountsManager()
    {
        Accounts = loadAccountsOfUser();
    }

    // In a real application, this function would retrieve the accounts data via an endpoint.
    // Here, we just use dummy data.
    public List<Account> loadAccountsOfUser()
    {
        List<Account> userAccounts = new List<Account>();

        Account accountA = new Account("1234567890");
        accountA.MakeTransaction(34545.23m, "1222333442");
        accountA.MakeTransaction(-23235.23m, "4562333442");
        accountA.MakeTransaction(-69.77m, "1222333442");
        accountA.MakeTransaction(17223.23m, "1222377741");

        userAccounts.Add(accountA);

        Account accountB = new Account("0987654321");
        accountB.MakeTransaction(786.23m, "4234566263");
        accountB.MakeTransaction(2335.10m, "4562333442");
        accountB.MakeTransaction(-3453.44m, "1222333442");

        userAccounts.Add(accountB);

        return userAccounts;
    }

}
