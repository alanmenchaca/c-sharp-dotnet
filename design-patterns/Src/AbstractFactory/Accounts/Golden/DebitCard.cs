namespace design_patterns.AbstractFactory.Accounts.Golden;

public class DebitCard : IDebitCard
{
    public int GetDebitCardCost()
    {
        return 5;
    }
}