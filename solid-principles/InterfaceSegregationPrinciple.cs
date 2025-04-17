namespace ConsoleApp1.SolidPrinciples;

/*
 * The Interface Segregation Principle (ISP) states that a class
 * should not be forced to implement interfaces it does not use.
 * This principle encourages the creation of smaller, client-specific
 * interfaces.
 * Key Idea: A class should not be forced to implement interfaces it
 * does not use.
 */
public class InterfaceSegregationPrinciple
{
    // The Robot is forced to implement the Eat method, violating ISP.
    /*public interface IWorker
    {
        void Work();
        void Eat();
    }

    public class Manager : IWorker
    {
        public void Work() { }
        public void Eat() { }
    }

    public class Robot : IWorker
    {
        public void Work() { }
        public void Eat() { }
    }*/
    
    /*
     * By splitting the IWorker interface into smaller interfaces (IWorkable
     * and IEatable), classes can implement only what they need, adhering to
     * the ISP.
     */
    public interface IWorkable
    {
        void Work();
    }
    
    public interface IEatable
    {
        void Eat();
    }
    
    public class Manager : IWorkable, IEatable
    {
        public void Work() { }
        public void Eat() { }
    }
    
    public class Robot : IWorkable
    {
        public void Work() { }
    }
    
    /*
     * Explanation: According to ISP, any client should not be forced to an
     * interface that is irrelevant to it. In other words, clients should not
     * be forced to depend on methods that they do not use.
     */
}