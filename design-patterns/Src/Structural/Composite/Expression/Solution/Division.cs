namespace design_patterns.Structural.Composite.Expression.Solution;

public class Division : Operation
{
    public Division(IExpression expression1, IExpression expression2)
        : base(expression1, expression2) { }

    public override int Operate()
    {
        return Expression1.Operate() / Expression2.Operate();
    }

    protected override string OperationString()
    {
        return "/";
    }
}