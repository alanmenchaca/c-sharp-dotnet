namespace design_patterns.Creational.AbstractFactory.Accounts.Golden;

public class DebitCard : IDebitCard
{
    public int GetDebitCardCost()
    {
        return 5;
    }
}