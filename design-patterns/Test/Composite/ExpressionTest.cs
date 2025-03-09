using design_patterns.Composite.Expression.Solution;
using NUnit.Framework;

namespace design_patterns.Test.Composite;

public class ExpressionTest
{
    private readonly IExpression _exp1, _exp2, _exp3, _exp4, _exp5, _exp6;

    public ExpressionTest()
    {
        // ((3 - ((4 / 2) * 3)) + 4)
        _exp1 = new Number(4);
        _exp2 = new Summation(_exp1, new Number(2));
        _exp3 = new Subtraction(_exp1, new Number(3));
        _exp4 = new Multiplication(_exp1, new Number(2));
        _exp5 = new Division(_exp1, new Number(3));
        _exp6 = new Summation(
            new Subtraction(
                new Number(3),
                new Multiplication(
                    new Division(_exp1, new Number(2)),
                    new Number(3)
                )
            ),
            _exp1
        );
    }

    [Test]
    public void TestNumber()
    {
        Assert.That(_exp1.Operate(), Is.EqualTo(4));
    }

    [Test]
    public void TestSummation()
    {
        Assert.That(_exp2.Operate(), Is.EqualTo(6));
    }

    [Test]
    public void TestSubtraction()
    {
        Assert.That(_exp3.Operate(), Is.EqualTo(1));
    }

    [Test]
    public void TestMultiplication()
    {
        Assert.That(_exp4.Operate(), Is.EqualTo(8));
    }

    [Test]
    public void TestDivision()
    {
        Assert.That(_exp5.Operate(), Is.EqualTo(1));
    }

    [Test]
    public void TestComplexExpression()
    {
        Assert.That(_exp6.Operate(), Is.EqualTo(1));
    }

    [Test]
    public void TestToString()
    {
        Assert.That(_exp1.ToString(), Is.EqualTo("4"));
        Assert.That(_exp2.ToString(), Is.EqualTo("(4 + 2)"));
        Assert.That(_exp3.ToString(), Is.EqualTo("(4 - 3)"));
        Assert.That(_exp4.ToString(), Is.EqualTo("(4 * 2)"));
        Assert.That(_exp5.ToString(), Is.EqualTo("(4 / 3)"));
        Assert.That(_exp6.ToString(), Is.EqualTo("((3 - ((4 / 2) * 3)) + 4)"));
    }
}