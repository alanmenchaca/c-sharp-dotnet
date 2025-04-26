namespace design_patterns.Creational.AbstractFactory.Accounts.Golden;

public class GoldenAccount : AccountFactory
{
    private ITax? _tax;
    private IDebitCard? _debitCard;
    private ICreditCard? _creditCard;

    public override ITax GetTax()
    {
        _tax ??= new Tax();
        return _tax;
    }

    public override IDebitCard GetDebitCard()
    {
        _debitCard ??= new DebitCard();
        return _debitCard;
    }

    public override ICreditCard GetCreditCard()
    {
        _creditCard ??= new CreditCard();
        return _creditCard;
    }
    
    public override string ToString()
    {
        return "Golden Account";
    }
}