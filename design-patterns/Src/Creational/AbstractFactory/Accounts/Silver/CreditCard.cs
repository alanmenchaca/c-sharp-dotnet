namespace design_patterns.Creational.AbstractFactory.Accounts.Silver;

public class CreditCard : ICreditCard
{
    public int GetCreditCardCost()
    {
        return 10;
    }

    public int MaxCreditLimit()
    {
        return 2000;
    }
}