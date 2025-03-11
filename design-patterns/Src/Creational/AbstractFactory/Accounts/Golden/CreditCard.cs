namespace design_patterns.Creational.AbstractFactory.Accounts.Golden;

public class CreditCard : ICreditCard
{
    public int GetCreditCardCost()
    {
        return 20;
    }

    public int MaxCreditLimit()
    {
        return 4000;
    }
}