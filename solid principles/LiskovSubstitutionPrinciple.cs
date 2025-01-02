namespace ConsoleApp1.SolidPrinciples;

/*
 * The Liskov Substitution Principle states that objects of a superclass
 * should be replaced with objects of a subclass without affecting the
 * correctness of the program.
 * Key Idea: We should be able to use any subclass where we use its
 * parent class.
 */
public class LiskovSubstitutionPrinciple
{
    /*public interface IBird
    {
        public void Fly() { }

        public void Walk() { }
    }*/

    /*public class Parrot : IBird
    {
        public void Fly() { }

        public void Walk() { }
    }*/

    // The penguin class violates the LSP by not implementing the Fly method.
    /*public class Penguin : IBird
    {
        // it's break the principle of LSP. Penguin can not fly.
        public void Fly() { }
        public void Walk() { }
    }*/

    /*
     * By implementing the IBird interface, the Parrot class can be used wherever 
     * an IBird is expected. The Parrot class can fly and walk, so it implements 
     * the Fly and Walk methods. The Penguin class can also be used wherever an 
     * IBird is expected, but it only implements the Walk method. This is fine
     * because penguins can't fly.
     */
    public interface IBird { }
    
    public interface IFlyingBird : IBird
    {
        public void Fly();
    }
    
    public interface IWalkingBird : IBird
    {
        public void Walk();
    }
    
    public class Parrot : IFlyingBird, IWalkingBird
    {
        public void Fly() { }
        public void Walk() { }
    }
    
    public class Penguin : IWalkingBird
    {
        public void Walk() { }
    }
    
    /*
     * Explanation: According to LSP, a derived class should not break the base
     * class's type definition and behavior which means objects of a base class
     * shall be replaceable with objects of its derived classes without breaking
     * the application.
     */
}