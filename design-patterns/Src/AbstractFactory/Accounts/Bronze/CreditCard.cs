namespace design_patterns.AbstractFactory.Accounts.Bronze;

public class CreditCard : ICreditCard
{
    public int GetCreditCardCost()
    {
        return 0;
    }

    public int MaxCreditLimit()
    {
        return 600;
    }
}