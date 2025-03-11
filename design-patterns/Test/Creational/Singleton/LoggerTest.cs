using design_patterns.Creational.Singleton.Logger.Solution;
using NUnit.Framework;

namespace design_patterns.Test.Creational.Singleton;

public class LoggerTest
{
    [Test]
    public void TestSingletonNotNull()
    {
        Assert.That(Logger.Instance, Is.Not.Null);
    }

    [Test]
    public void TestIsSingleton()
    {
        Assert.That(Logger.Instance, Is.InstanceOf<Logger>());
    }
}