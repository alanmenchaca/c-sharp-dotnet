using design_patterns.Structural.Composite.TreeNumbers.Solution;
using NUnit.Framework;

namespace design_patterns.Test.Structural.Composite;

public class TreeNumbersTest
{
    private readonly ITreeNumbers _root;
    private readonly ITreeNumbers _sub11;
    private readonly ITreeNumbers _leaf;

    public TreeNumbersTest()
    {
        _root = new TreeNumbersComposite("Root");
        _sub11 = new TreeNumbersComposite("Sub11");
        _leaf = new TreeNumbersLeaf(1);

        _sub11.Add(new TreeNumbersLeaf(2));
        _sub11.Add(new TreeNumbersLeaf(3));

        var sub12 = new TreeNumbersComposite("Sub12");
        sub12.Add(new TreeNumbersLeaf(-5));
        sub12.Add(new TreeNumbersLeaf(6));

        var sub1 = new TreeNumbersComposite("Sub1");
        sub1.Add(_sub11);
        sub1.Add(new TreeNumbersLeaf(4));
        sub1.Add(sub12);

        _root.Add(_leaf);
        _root.Add(sub1);
        _root.Add(new TreeNumbersLeaf(7));
    }

    [Test]
    public void TestNumberOfTreeNumbersIfLeaf()
    {
        Assert.That(_leaf.NumberOfNodes(), Is.EqualTo(1));
    }

    [Test]
    public void TestNumberOfTreeNumbersIfComposite()
    {
        Assert.That(_root.NumberOfNodes(), Is.EqualTo(3));
        Assert.That(_sub11.NumberOfNodes(), Is.EqualTo(2));
    }

    [Test]
    public void TestSumIfLeaf()
    {
        Assert.That(_leaf.Sum(), Is.EqualTo(1));
    }

    [Test]
    public void TestSumIfComposite()
    {
        Assert.That(_root.Sum(), Is.EqualTo(18));
    }

    [Test]
    public void TestHigherIfLeaf()
    {
        Assert.That(_leaf.Higher(), Is.EqualTo(1));
    }

    [Test]
    public void TestHigherIfComposite()
    {
        Assert.That(_root.Higher(), Is.EqualTo(7));
    }

    [Test]
    public void TestAddIfLeaf()
    {
        Assert.Throws<InvalidOperationException>(() => _leaf.Add(new TreeNumbersLeaf(8)));
    }
}