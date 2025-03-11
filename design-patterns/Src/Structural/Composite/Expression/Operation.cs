namespace design_patterns.Structural.Composite.Expression;

public abstract class Operation : IExpression
{
    public IExpression Left { get; }
    public IExpression Right { get; }

    public Operation(IExpression left, IExpression right)
    {
        Left = left;
        Right = right;
    }
    
    public abstract int Evaluate();
}