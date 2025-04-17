namespace ConsoleApp1.SolidPrinciples;

/*
 * The Dependency Inversion Principle suggests that high-level modules
 * should not depend on low-level modules, but both should depend on
 * abstractions. Additionally, abstractions should not depend on details;
 * details should depend on abstractions.
 * Key Idea: High-level modules should not depend on low-level modules;
 * both should depend on abstractions.
 */
public class DependencyInversionPrinciple
{
    /*
     * The LightBulb class is a low-level module. The Switch class directly
     * depends on the concrete LightBulb class, violating the DIP.
     */
    /*public class LightBulb
    {
        public bool IsOn { get; private set; }
        public void TurnOn() { /* implementation #1# }
        public void TurnOff() { /* implementation #1# }
    }

    public class Switch
    {
        private LightBulb bulb;
        
        public Switch(LightBulb bulb)
        {
            this.bulb = bulb;
        }
        
        public void Toggle()
        {
            if (bulb.IsOn)
                bulb.TurnOff();
            else
                bulb.TurnOn();
        }
    }*/
    
    /*
     * By introducing an abstraction (ISwitchable), the Switch class 
     * now depends on an abstraction, adhering to the DIP.
     */
    public interface ISwitchable
    {
        public bool IsOn { get; }
        public void TurnOn();
        public void TurnOff();
    }
    
    public class LightBulb : ISwitchable
    {
        public bool IsOn { get; private set; }
        public void TurnOn() { /* implementation #1 */ }
        public void TurnOff() { /* implementation #1 */ }
    }
    
    public class Switch
    {
        private ISwitchable device;
        
        public Switch(ISwitchable device)
        {
            this.device = device;
        }
        
        public void Toggle()
        {
            if (device.IsOn)
                device.TurnOff();
            else
                device.TurnOn();
        }
    }
    
    /*
     * Explanation: According to DIP, do not write any tightly coupled 
     * code because that is a nightmare to maintain when the application
     * is growing bigger and bigger.
     * If a class depends on another class, then we need to change one
     * class if something changes in that dependent class. We should always
     * try to write loosely coupled code.
     */
}