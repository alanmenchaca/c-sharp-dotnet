namespace design_patterns.Test.Singleton;

using design_patterns.Singleton.Factory.Solution;

public class ReferencesFactoryTest
{
    public ReferencesFactoryTest()
    {
    }

    [Fact]
    public void TestSingletonNotNull()
    {
        Assert.NotNull(ReferencesFactory.GetFactory());
    }

    [Fact]
    public void TestGetReference()
    {
        ReferencesFactory rf = ReferencesFactory.GetFactory();
        Assert.Equal(0, rf.GetReference("key1"));
        Assert.Equal(1, rf.GetReference("key2"));
        rf.ClearResources();
    }

    [Fact]
    public void TestRemoveReference()
    {
        ReferencesFactory rf = ReferencesFactory.GetFactory();
        Assert.Equal(0, rf.GetReference("key3"));
        rf.RemoveReference("key3");
        Assert.Equal(1, rf.GetReference("key3"));
        rf.ClearResources();
    }
}