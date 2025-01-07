namespace design_patterns.Composite.Expression;

public class Number : IExpression
{
    private int _number;

    public Number(int number)
    {
        _number = number;
    }

    public int Evaluate()
    {
        return _number;
    }

    public override string ToString()
    {
        return _number.ToString();
    }
}