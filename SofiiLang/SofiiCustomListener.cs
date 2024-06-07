using Antlr4.Runtime;

namespace SofiiLang;
using System;

public class SofiiCustomListener : SofiiBaseListener
{
    private int _level = 0;

    private string GetIndentation()
    {
        return new string(' ', _level * 2);
    }

    public override void EnterEveryRule(ParserRuleContext ctx)
    {
        Console.WriteLine(GetIndentation()  + "|--> " + ctx.GetType().Name);
        _level++;
    }

    public override void ExitEveryRule(ParserRuleContext ctx)
    {
        _level--;
    }

    private void PrintRule(string message)
    {
        Console.WriteLine(GetIndentation() + message);
    }
    
    public override void EnterProgram(SofiiParser.ProgramContext context)
    {
        PrintRule("Entering program...");
    }

    public override void ExitProgram(SofiiParser.ProgramContext context)
    {
        PrintRule("Exiting program.");
    }

    public override void EnterUse_stmt(SofiiParser.Use_stmtContext context)
    {
        PrintRule($"Using: {context.IDENTIFIER().ToString()}");
    }

    public override void EnterEnum_def(SofiiParser.Enum_defContext context)
    {
        PrintRule($"Defining enum: {context.IDENTIFIER().ToString()}");
    }

    public override void EnterTraits_def(SofiiParser.Traits_defContext context)
    {
        PrintRule($"Defining traits: {context.IDENTIFIER().GetText()}");
    }

    public override void EnterClass_def(SofiiParser.Class_defContext context)
    {
        PrintRule($"Defining class: {context.IDENTIFIER().ToString()}");
    }

    public override void EnterFunc_def(SofiiParser.Func_defContext context)
    {
        PrintRule($"Defining function: {context.IDENTIFIER().GetText()}");
    }

    public override void EnterVar_def(SofiiParser.Var_defContext context)
    {
        PrintRule($"Defining variable: {context.IDENTIFIER().GetText()} of type {context.type().GetText()}");
    }

    public override void EnterAssign_stmt(SofiiParser.Assign_stmtContext context)
    {
        PrintRule($"Assigning value to: {context.IDENTIFIER().GetText()}");
    }

    public override void EnterReturn_stmt(SofiiParser.Return_stmtContext context)
    {
        PrintRule("Return statement.");
    }

    public override void EnterIf_stmt(SofiiParser.If_stmtContext context)
    {
        PrintRule("If statement.");
    }

    public override void EnterFor_stmt(SofiiParser.For_stmtContext context)
    {
        PrintRule($"For loop over: {context.IDENTIFIER().GetText()}");
    }

    public override void EnterWhile_stmt(SofiiParser.While_stmtContext context)
    {
        PrintRule("While loop.");
    }

    public override void EnterSwitch_stmt(SofiiParser.Switch_stmtContext context)
    {
        PrintRule("Switch statement.");
    }

    public override void EnterExpression(SofiiParser.ExpressionContext context)
    {
        PrintRule($"Expression: {context.GetText()}");
    }
}
