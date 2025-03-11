namespace design_patterns.Creational.AbstractFactory.Accounts.Bronze;

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