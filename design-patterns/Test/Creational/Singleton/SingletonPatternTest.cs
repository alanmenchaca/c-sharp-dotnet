using design_patterns.Creational.Singleton;
using NUnit.Framework;

namespace design_patterns.Test.Creational.Singleton;

public class SingletonPatternTest
{
    [Test]
    public void GetSingleton_ShouldReturnSingletonInstance()
    {
        // Act
        var singleton = SingletonPattern.GetSingleton();

        // Assert
        Assert.That(singleton, Is.Not.Null);
        Assert.That(singleton, Is.InstanceOf<SingletonPattern>());
    }

    [Test]
    public void GetSingleton_ShouldReturnSameInstance_WhenCalledMultipleTimes()
    {
        // Act
        var singleton1 = SingletonPattern.GetSingleton();
        var singleton2 = SingletonPattern.GetSingleton();

        // Assert
        Assert.That(singleton1, Is.EqualTo(singleton2));
    }
}