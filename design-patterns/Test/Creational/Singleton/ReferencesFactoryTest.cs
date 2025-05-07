using design_patterns.Creational.Singleton;
using NUnit.Framework;

namespace design_patterns.Test.Creational.Singleton;

[TestFixture]
public class ReferencesFactoryTest
{
    private ReferencesFactory _rf;

    [SetUp]
    public void Setup()
    {
        _rf = ReferencesFactory.GetFactory();
    }

    [Test]
    public void GetFactory_ShouldReturnReferencesFactoryInstance()
    {
        // Act
        var factory = ReferencesFactory.GetFactory();

        // Assert
        Assert.That(ReferencesFactory.GetFactory(), Is.Not.Null);
        Assert.That(factory, Is.InstanceOf<ReferencesFactory>());
    }

    [Test]
    public void GetFactory_ShouldReturnSameInstance_WhenCalledMultipleTimes()
    {
        // Act
        var factory1 = ReferencesFactory.GetFactory();
        var factory2 = ReferencesFactory.GetFactory();
        
        // Assert
        Assert.That(factory1, Is.EqualTo(factory2));
    }

    [Test]
    public void GetReference_ShouldReturnSameValue_ForSameKey()
    {
        // Act & Assert
        Assert.That(_rf.GetReference("key1"), Is.EqualTo(0));
        Assert.That(_rf.GetReference("key1"), Is.EqualTo(0));
    }

    [Test]
    public void GetReference_ShouldReturnIncrementedValue_ForDifferentKeys()
    {
        // Act & Assert
        Assert.That(_rf.GetReference("key1"), Is.EqualTo(0));
        Assert.That(_rf.GetReference("key2"), Is.EqualTo(1));
        Assert.That(_rf.GetReference("key3"), Is.EqualTo(2));
    }

    [Test]
    public void GetReference_ShouldReturnIncrementedValue_AfterKeyRemoval()
    {
        Assert.That(_rf.GetReference("key1"), Is.EqualTo(0));
        _rf.RemoveReference("key1");
        Assert.That(_rf.GetReference("key1"), Is.EqualTo(1));
    }

    [TearDown]
    public void TearDown()
    {
        _rf.ClearResources();
    }
}