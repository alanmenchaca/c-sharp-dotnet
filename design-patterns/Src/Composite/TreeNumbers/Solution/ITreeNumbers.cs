namespace design_patterns.Composite.TreeNumbers.Solution;

public interface ITreeNumbers
{
    public void Add(ITreeNumbers child);
    public void Remove(ITreeNumbers child);
    public int NumberOfNodes();
    public int Sum();
    public int Higher();
}