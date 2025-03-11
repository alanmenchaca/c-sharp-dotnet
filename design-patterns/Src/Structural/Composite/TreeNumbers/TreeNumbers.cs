namespace design_patterns.Structural.Composite.TreeNumbers;

public class TreeNumbers
{
    private readonly int _number;
    private readonly string? _name;
    private readonly List<TreeNumbers> _treeNumbersList;

    public TreeNumbers(string? name)
    {
        this._name = name;
        _treeNumbersList = new List<TreeNumbers>();
    }

    public TreeNumbers(int number)
    {
        this._number = number;
        _treeNumbersList = null;
    }

    public bool IsComposite()
    {
        return _treeNumbersList != null;
    }

    public void Add(TreeNumbers child)
    {
        if (IsComposite())
        {
            _treeNumbersList.Add(child);
        }
        else
        {
            throw new InvalidOperationException("Invalid Operation in Leaf");
        }
    }

    public void Remove(TreeNumbers child)
    {
        if (IsComposite())
            _treeNumbersList.Remove(child);
    }

    public int NumberOfNodes()
    {
        return IsComposite() ? _treeNumbersList.Count : 1;
    }

    public int Sum()
    {
        return IsComposite() ? _treeNumbersList.Sum(x => x.Sum()) : _number;
    }

    public int Higher()
    {
        return IsComposite() ? _treeNumbersList.Max(x => x.Higher()) : _number;
    }

    public override string ToString()
    {
        return "TreeNumbers{" +
               $"number={_number}" +
               $", name={_name}" +
               $", treeNumbersList={_treeNumbersList}" +
               "}";
    }
}