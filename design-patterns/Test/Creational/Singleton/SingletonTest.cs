using design_patterns.Creational.Singleton;
using NUnit.Framework;

namespace design_patterns.Test.Creational.Singleton;

public class SingletonTest
{
    [Test]
    public void TestSingletonNotNull()
    {
        Assert.That(SingletonProvider.GetSingleton(), Is.Not.Null);
    }

    [Test]
    public void TestIsSingleton()
    {
        Assert.That(SingletonProvider.GetSingleton(), Is.InstanceOf<SingletonProvider>());
    }
}