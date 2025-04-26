namespace design_patterns.Creational.Singleton;

/*
 * The Singleton should always be a 'sealed' class to prevent inheritance through
 *  external classes and also through nested classes
 */
public sealed class SingletonPattern
{
    // Eager initialization
    // private static SingletonProvider SingletonInstance { get; } = new SingletonProvider();
    private static SingletonPattern? _singleton;
    
    /*
     * The singleton's constructor should always be private to prevent instantiation
     * (direct construction calls) through the 'new' operator.
     */
    private SingletonPattern() { }
    
    /*
     * The singleton class defines the 'GetInstance' method that serves as an
     * alternative to constructor and lets clients access the same instance of
     * this class over and over.
     */
    public static SingletonPattern GetSingleton()
    {
        /*
         * The function on the first run, it creates a singleton object and places
         * it into the static variable. On subsequent runs, it returns the client
         * existing object stored in the static field.
         */
        // Lazy initialization
        return _singleton ??= new SingletonPattern();
    }
}