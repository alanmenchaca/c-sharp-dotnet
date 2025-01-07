using design_patterns.Composite.TreeNumbers.Solution;

namespace design_patterns.Test.Composite;

public class TestTreeNumbers
{
    private readonly ITreeNumbers _root;
    private readonly ITreeNumbers _sub11;
    private readonly ITreeNumbers _leaf;

    public TestTreeNumbers()
    {
        _root = new TreeNumbersComposite("Root");
        _sub11 = new TreeNumbersComposite("Sub11");
        _leaf = new TreeNumbersLeaf(1);

        _sub11.Add(new TreeNumbersLeaf(2));
        _sub11.Add(new TreeNumbersLeaf(3));

        ITreeNumbers sub12 = new TreeNumbersComposite("Sub12");
        sub12.Add(new TreeNumbersLeaf(-5));
        sub12.Add(new TreeNumbersLeaf(6));

        ITreeNumbers sub1 = new TreeNumbersComposite("Sub1");
        sub1.Add(_sub11);
        sub1.Add(new TreeNumbersLeaf(4));
        sub1.Add(sub12);

        _root.Add(_leaf);
        _root.Add(sub1);
        _root.Add(new TreeNumbersLeaf(7));
    }

    [Fact]
    public void TestNumberOfTreeNumbersIfLeaf()
    {
        Assert.Equal(1, _leaf.NumberOfNodes());
    }

    [Fact]
    public void TestNumberOfTreeNumbersIfComposite()
    {
        Assert.Equal(3, _root.NumberOfNodes());
        Assert.Equal(2, _sub11.NumberOfNodes());
    }

    [Fact]
    public void TestSumIfLeaf()
    {
        Assert.Equal(1, _leaf.Sum());
    }

    [Fact]
    public void TestSumIfComposite()
    {
        Assert.Equal(18, _root.Sum());
    }

    [Fact]
    public void TestHigherIfLeaf()
    {
        Assert.Equal(1, _leaf.Higher());
    }

    [Fact]
    public void TestHigherIfComposite()
    {
        Assert.Equal(7, _root.Higher());
    }

    [Fact]
    public void TestAddIfLeaf()
    {
        Assert.Throws<InvalidOperationException>(() => _leaf.Add(new TreeNumbersLeaf(8)));
    }
}