namespace design_patterns.Creational.Singleton.Factory;

public class ReferencesFactory
{
    private readonly Dictionary<string, int> _references;
    private int _reference;

    public ReferencesFactory()
    {
        _references = new Dictionary<string, int>();
        _reference = 0;
    }

    public int GetReference(string key)
    {
        var isPresent = _references.TryGetValue(key, out var value);
        if (!isPresent)
        {
            _references.Add(key, _reference++);
        }

        return value;
    }

    public void RemoveReference(string key)
    {
        _references.Remove(key);
    }
}