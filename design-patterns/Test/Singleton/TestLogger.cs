using design_patterns.Singleton.Logger.Solution;

namespace design_patterns.Test.Singleton;

public class TestLogger
{
    [Fact]
    public void TestSingletonNotNull()
    {
        Assert.NotNull(Logger.Instance);
    }
    
    [Fact]
    public void TestIsSingleton()
    {
        Assert.Same(Logger.Instance, Logger.Instance);
    }
}