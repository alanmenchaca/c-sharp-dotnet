namespace design_patterns.Singleton;

/*
 * Singleton is a creational design pattern that lets you ensure that a class
 * has only one instance, while providing a global access point to this instance.
 *
 * Why would anyone want to control how many instances a class has? The most
 * common reason for this is to control access to some shared resource—for example,
 * a database or a file.
 */
public class Singleton
{
    // Eager initialization
    // private static Singleton SingletonInstance { get; } = new Singleton();
    private static Singleton _singleton;

    private Singleton() { }

    public static Singleton GetSingleton()
    {
        // Lazy initialization
        if (_singleton == null)
        {
            _singleton = new Singleton();
        }

        return _singleton;
    }
}