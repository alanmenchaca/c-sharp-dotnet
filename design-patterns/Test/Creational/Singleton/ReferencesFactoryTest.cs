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
    public void TestSingletonNotNull()
    {
        Assert.That(ReferencesFactory.GetFactory(), Is.Not.Null);
    }

    [Test]
    public void TestGetReference()
    {
        Assert.That(_rf.GetReference("key1"), Is.EqualTo(0));
        Assert.That(_rf.GetReference("key2"), Is.EqualTo(1));
    }

    [Test]
    public void TestRemoveReference()
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