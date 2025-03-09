using NUnit.Framework;

namespace design_patterns.Test.Singleton;

using design_patterns.Singleton;

public class SingletonTest
{
    [Test]
    public void TestSingletonNotNull()
    {
        Assert.That(Singleton.GetSingleton(), Is.Not.Null);
    }

    [Test]
    public void TestIsSingleton()
    {
        Assert.That(Singleton.GetSingleton(), Is.InstanceOf<Singleton>());
    }
}