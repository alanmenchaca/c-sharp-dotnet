namespace design_patterns.Singleton.Logger.Solution;

public class Clazz2
{
    public void Method1()
    {
        Logger.Instance.AddLog("Clazz2:Method1");
    }

    public void Method2()
    {
        Clazz3 c3 = new Clazz3();
        c3.Method1();
        Logger.Instance.AddLog("Clazz2:Method2");
    }
}