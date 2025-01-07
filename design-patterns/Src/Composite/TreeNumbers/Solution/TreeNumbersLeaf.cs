namespace design_patterns.Composite.TreeNumbers.Solution;

public class TreeNumbersLeaf : ITreeNumbers
{
    private readonly int _number;

    public TreeNumbersLeaf(int number)
    {
        _number = number;
    }


    public void Add(ITreeNumbers child)
    {
        throw new InvalidOperationException("Invalid Operation in Leaf");
    }

    public void Remove(ITreeNumbers child)
    {
        // Do nothing because it's a leaf         
    }

    public int NumberOfNodes()
    {
        return 1;
    }

    public int Sum()
    {
        return _number;
    }

    public int Higher()
    {
        return _number;
    }

    public override string ToString()
    {
        return $"Leaf[{_number}]";
    }
}