namespace design_patterns.Creational.AbstractFactory.Accounts.Bronze;

public class Tax : ITax
{
    public double GetTaxApplied()
    {
        return 0.01;
    }
}