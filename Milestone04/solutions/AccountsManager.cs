class AccountsManager {

    public List<Account> Accounts;

    public AccountsManager()
    {
        Accounts = loadAccountsOfUser();
    }

    public List<Account> loadAccountsOfUser()
    {
        List<Account> userAccounts = new List<Account>();

        Account accountA = new Account("1234567890");
        accountA.MakeTransaction(34545.23m, "1222333442");
        accountA.MakeTransaction(-23235.23m, "4562333442");
        accountA.MakeTransaction(-69.77m, "1222333442");
        accountA.MakeTransaction(17223.23m, "1222377741");

        userAccounts.Add(accountA);

        return userAccounts;
    }

}
