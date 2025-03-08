namespace design_patterns.AbstractFactory.Accounts.Golden;

public class GoldenAccount : AccountFactory
{
    private ITax _tax;
    private IDebitCard _debitCard;
    private ICreditCard _creditCard;

    public override ITax GetTax()
    {
        if (_tax == null)
            _tax = new Tax();
        return new Tax();
    }

    public override IDebitCard GetDebitCard()
    {
        if (_debitCard == null)
            _debitCard = new DebitCard();
        return _debitCard;
    }

    public override ICreditCard GetCreditCard()
    {
        if (_creditCard == null)
            _creditCard = new CreditCard();
        return _creditCard;
    }
    
    public override string ToString()
    {
        return "Golden Account";
    }
}