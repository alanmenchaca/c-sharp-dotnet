namespace design_patterns.Creational.Singleton.Logger;

public class Clazz3
{
    private Logger _logger;

    public Clazz3(Logger logger)
    {
        _logger = logger;
    }

    public void Method1()
    {
        _logger.AddLog("Clazz3:Method1");
    }
}