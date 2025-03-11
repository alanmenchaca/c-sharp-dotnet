namespace design_patterns.Structural.Composite.Expression.Solution;

public abstract class Operation : IExpression
{
    public IExpression Expression1 { get; }
    public IExpression Expression2 { get; }

    public Operation(IExpression expression1, IExpression expression2)
    {
        Expression1 = expression1;
        Expression2 = expression2;
    }

    public abstract int Operate();
    protected abstract string OperationString();

    public override string ToString()
    {
        return $"({Expression1} {OperationString()} {Expression2})";
    }
}