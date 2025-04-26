using design_patterns.Creational.Singleton;
using NUnit.Framework;

namespace design_patterns.Test.Creational.Singleton;

public class SingletonPatternTest
{
    [Test]
    public void TestSingletonNotNull()
    {
        Assert.That(SingletonPattern.GetSingleton(), Is.Not.Null);
    }

    [Test]
    public void TestIsSingleton()
    {
        Assert.That(SingletonPattern.GetSingleton(), Is.InstanceOf<SingletonPattern>());
    }
}