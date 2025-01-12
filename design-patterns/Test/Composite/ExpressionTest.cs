using design_patterns.Composite.Expression.Solution;

namespace design_patterns.Test.Composite;

public class ExpressionTest
{
    private IExpression exp1, exp2, exp3, exp4, exp5, exp6;

    public ExpressionTest()
    {
        exp1 = new Number(4);
        exp2 = new Summation(exp1, new Number(2));
        exp3 = new Subtraction(exp1, new Number(3));
        exp4 = new Multiplication(exp1, new Number(2));
        exp5 = new Division(exp1, new Number(3));
        exp6 = new Summation(
            new Subtraction(
                new Number(3),
                new Multiplication(
                    new Division(exp1, new Number(2)),
                    new Number(3)
                )
            ),
            exp1
        );
        // ((3 - ((4 / 2) * 3)) + 4)
    }
    
    [Fact]
    public void TestNumber()
    {
        Assert.Equal(4, exp1.Operate());
    }
    
    [Fact]
    public void TestSummation()
    {
        Assert.Equal(6, exp2.Operate());
    }
    
    [Fact]
    public void TestSubtraction()
    {
        Assert.Equal(1, exp3.Operate());
    }
    
    [Fact]
    public void TestMultiplication()
    {
        Assert.Equal(8, exp4.Operate());
    }
    
    [Fact]
    public void TestDivision()
    {
        Assert.Equal(1, exp5.Operate());
    }
    
    [Fact]
    public void TestComplexExpression()
    {
        Assert.Equal(1, exp6.Operate());
    }
    
    [Fact]
    public void TestToString()
    {
        Assert.Equal("4", exp1.ToString());
        Assert.Equal("(4 + 2)", exp2.ToString());
        Assert.Equal("(4 - 3)", exp3.ToString());
        Assert.Equal("(4 * 2)", exp4.ToString());
        Assert.Equal("(4 / 3)", exp5.ToString());
        Assert.Equal("((3 - ((4 / 2) * 3)) + 4)", exp6.ToString());
    }
}