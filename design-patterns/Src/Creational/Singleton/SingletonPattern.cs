namespace design_patterns.Creational.Singleton;

/*
 * Singleton is a creational design pattern that lets you ensure that a class
 * has only one instance, while providing a global access point to this instance.
 *
 * Why would anyone want to controkl how many instances a class has? The most
 * common reason for this is to control access to some shared resource — for example,
 * a database or a file.
 */
public class SingletonPattern
{
    // Eager initialization
    // private static SingletonProvider SingletonInstance { get; } = new SingletonProvider();
    private static SingletonPattern? _singleton;

    private SingletonPattern()
    {
    }
    
    public static SingletonPattern GetSingleton()
    {
        // Lazy initialization
        return _singleton ??= new SingletonPattern();
    }
}