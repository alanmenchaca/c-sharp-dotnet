namespace design_patterns.Composite.TreeNumbers.Solution;

public class TreeNumbersComposite : ITreeNumbers
{
    private readonly string? _name;
    private readonly List<ITreeNumbers> _treeNumbersList;

    public TreeNumbersComposite(string? name)
    {
        _name = name;
        _treeNumbersList = [];
    }

    public void Add(ITreeNumbers child)
    {
        _treeNumbersList.Add(child);
    }

    public void Remove(ITreeNumbers child)
    {
        _treeNumbersList.Remove(child);
    }

    public int NumberOfNodes()
    {
        return _treeNumbersList.Count;
    }

    public int Sum()
    {
        return _treeNumbersList.Sum(x => x.Sum());
    }

    public int Higher()
    {
        if (_treeNumbersList.Count > 0)
        {
            return _treeNumbersList.Max(x => x.Higher());
        }

        throw new InvalidOperationException("No Elements in the Composite Tree");
    }

    public override string ToString()
    {
        return $"[{_name}]";
    }
}