namespace design_patterns.Composite.Expression;

public class Multiplication : Operation
{
    public Multiplication(IExpression left, IExpression right) : base(left, right) { }

    public override int Evaluate()
    {
        return Left.Evaluate() * Right.Evaluate();
    }

    public override string ToString()
    {
        return $"({Left} * {Right})";
    }
}