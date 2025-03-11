namespace design_patterns.Structural.Composite.Expression.Solution;

public class Number : IExpression
{
    private int Value { get; }

    public Number(int value)
    {
        Value = value;
    }

    public int Operate()
    {
        return Value;
    }
    
    public override string ToString()
    {
        return Value.ToString();
    }
}