﻿namespace design_patterns.Test.Singleton;

using design_patterns.Singleton;

public class SingletonTest
{
    [Fact]
    private void TestSingletonNotNull()
    {
        Assert.NotNull(Singleton.GetSingleton());
    }

    [Fact]
    private void TestIsSingleton()
    {
        Assert.Same(Singleton.GetSingleton(), Singleton.GetSingleton());
    }
}