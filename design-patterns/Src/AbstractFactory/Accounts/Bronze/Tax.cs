namespace design_patterns.AbstractFactory.Accounts.Bronze;

public class Tax :ITax
{
    public double GetTaxApplied()
    {
        return 0.01;
    }
}