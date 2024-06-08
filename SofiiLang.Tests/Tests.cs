using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
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
    
    [Fact]
    [Trait("Category", "AST")]
    public void TestAST_UseTestFile()
    {
        // Sample sofii code
        var inputFilePath = "../../../test.sofii";
        string input;

        try
        {
            input = File.ReadAllText(inputFilePath);
        }
        catch (Exception e)
        {
            _testOutputHelper.WriteLine($"Error reading file: {e.Message}");
            return;
        }

        // Setup ANTLR to parse the input code
        AntlrInputStream inputStream = new AntlrInputStream(input);
        SofiiLexer lexer = new SofiiLexer(inputStream);
        CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
        SofiiParser parser = new SofiiParser(commonTokenStream);

        // Parse the input code
        IParseTree tree = parser.program();

        // Create and attach the listener
        SofiiCustomListener listener = new SofiiCustomListener();
        ParseTreeWalker walker = new ParseTreeWalker();
        walker.Walk(listener, tree);

        _testOutputHelper.WriteLine(listener.GetOutput());
    }
}