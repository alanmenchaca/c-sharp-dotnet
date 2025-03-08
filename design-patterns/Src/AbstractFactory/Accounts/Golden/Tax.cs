namespace design_patterns.AbstractFactory.Accounts.Golden;

public class Tax : ITax
{
    public double GetTaxApplied()
    {
        return 0.02;
    }
}