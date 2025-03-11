namespace design_patterns.Structural.Composite.Expression;

public class Subtraction : Operation
{
    public Subtraction(IExpression left, IExpression right) : base(left, right) { }

    public override int Evaluate()
    {
        return Left.Evaluate() - Right.Evaluate();
    }

    public override string ToString()
    {
        return $"({Left} - {Right})";
    }
}