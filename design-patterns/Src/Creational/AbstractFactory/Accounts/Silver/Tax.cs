namespace design_patterns.Creational.AbstractFactory.Accounts.Silver;

public class Tax : ITax
{
    public double GetTaxApplied()
    {
        return 0.015;
    }
}