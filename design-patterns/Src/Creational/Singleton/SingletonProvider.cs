namespace design_patterns.Creational.Singleton;

/*
 * Singleton is a creational design pattern that lets you ensure that a class
 * has only one instance, while providing a global access point to this instance.
 *
 * Why would anyone want to control how many instances a class has? The most
 * common reason for this is to control access to some shared resource — for example,
 * a database or a file.
 */
public class SingletonProvider
{
    // Eager initialization
    // private static SingletonProvider SingletonInstance { get; } = new SingletonProvider();
    private static SingletonProvider? _singleton;

    private SingletonProvider() { }

    public static SingletonProvider? GetSingleton()
    {
        // Lazy initialization
        if (_singleton == null)
        {
            _singleton = new SingletonProvider();
        }

        return _singleton;
    }
}