using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

RunParser();

static void RunParser()
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
        Console.WriteLine($"Error reading file: {e.Message}");
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

    Console.Write(listener.GetOutput());
}