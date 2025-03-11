namespace design_patterns.Creational.Singleton.Logger;

public class Clazz2
{
    private Logger _logger;

    public Clazz2(Logger logger)
    {
        _logger = logger;
    }

    public void Method1()
    {
        _logger.AddLog("Clazz2:Method1");
    }

    public void Method2()
    {
        Clazz3 c3 = new Clazz3(_logger);
        c3.Method1();
        _logger.AddLog("Clazz2:Method2");
    }
}