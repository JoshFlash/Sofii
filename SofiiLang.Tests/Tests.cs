using Xunit.Abstractions;

namespace SofiiLang.Tests;

public class Tests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Tests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }
    
    [Fact]
    [Trait("Category", "AST")]
    public void TestAST_HelloWorld()
    {

    }
}