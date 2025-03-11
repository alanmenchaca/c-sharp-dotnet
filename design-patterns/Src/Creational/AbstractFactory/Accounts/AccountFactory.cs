namespace design_patterns.Creational.AbstractFactory.Accounts;

public abstract class AccountFactory
{
    private static AccountFactory? _accountFactory;

    public static void SetAccountFactory(AccountFactory? accountTypeFactory)
    {
        _accountFactory = accountTypeFactory;
    }

    public static AccountFactory? GetAccountFactory()
    {
        return _accountFactory;
    }
    
    public abstract ITax GetTax();
    public abstract IDebitCard GetDebitCard();
    public abstract ICreditCard GetCreditCard();
}