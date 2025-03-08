namespace design_patterns.AbstractFactory.Accounts.Bronze;

public class DebitCard: IDebitCard
{
    public int GetDebitCardCost()
    {
        return 0;
    }
}