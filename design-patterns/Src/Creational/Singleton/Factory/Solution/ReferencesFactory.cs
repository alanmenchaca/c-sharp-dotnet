namespace design_patterns.Creational.Singleton.Factory.Solution;

public class ReferencesFactory
{
    /*
     * Singleton must have:
     * private attribute of the same class
     * private Constructor
     * public static method to get the instance
     */
    private static ReferencesFactory _rf;
    private readonly Dictionary<string, int> _references;
    private int _reference;

    private ReferencesFactory()
    {
        _references = new Dictionary<string, int>();
        _reference = 0;
    }

    public static ReferencesFactory GetFactory()
    {
        // lazy initialization
        if (_rf == null)
            _rf = new ReferencesFactory();

        return _rf;
    }

    public int GetReference(string key)
    {
        var isPresent = _references.TryGetValue(key, out var value);
        if (!isPresent)
        {
            value = _reference++;
            _references.Add(key, value);
        }

        return value;
    }

    public void RemoveReference(string key)
    {
        _references.Remove(key);
    }

    public void ClearResources()
    {
        _references.Clear();
        _reference = 0;
    }
}