using System.Text;

public class SofiiCustomListener : SofiiBaseListener
{
    private int _indentLevel = 0;
    private readonly StringBuilder _output = new StringBuilder();

    private void Indent()
    {
        _indentLevel++;
    }

    private void Dedent()
    {
        if (_indentLevel > 0)
            _indentLevel--;
    }

    private void PrintIndented(string message)
    {
        _output.AppendLine(new string(' ', _indentLevel * 2) + message);
    }

    public override void EnterWithin_stmt(SofiiParser.Within_stmtContext context)
    {
        PrintIndented($"Entering within statement: {context.GetText()}");
        Indent();
    }

    public override void ExitWithin_stmt(SofiiParser.Within_stmtContext context)
    {
        Dedent();
        PrintIndented($"Exiting within statement: {context.GetText()}");
    }

    public override void EnterUse_stmt(SofiiParser.Use_stmtContext context)
    {
        PrintIndented($"Entering use statement: {context.GetText()}");
        Indent();
    }

    public override void ExitUse_stmt(SofiiParser.Use_stmtContext context)
    {
        Dedent();
        PrintIndented($"Exiting use statement: {context.GetText()}");
    }

    public override void EnterEnum_def(SofiiParser.Enum_defContext context)
    {
        PrintIndented($"Entering enum definition: {context.GetChild(1).GetText()}");
        Indent();
    }

    public override void ExitEnum_def(SofiiParser.Enum_defContext context)
    {
        Dedent();
        PrintIndented($"Exiting enum definition: {context.GetChild(1).GetText()}");
    }

    public override void EnterTrait_def(SofiiParser.Trait_defContext context)
    {
        PrintIndented($"Entering trait definition: {context.GetChild(1).GetText()}");
        Indent();
    }

    public override void ExitTrait_def(SofiiParser.Trait_defContext context)
    {
        Dedent();
        PrintIndented($"Exiting trait definition: {context.GetChild(1).GetText()}");
    }

    public override void EnterClass_def(SofiiParser.Class_defContext context)
    {
        PrintIndented($"Entering class definition: {context.GetChild(1).GetText()}");
        Indent();
    }

    public override void ExitClass_def(SofiiParser.Class_defContext context)
    {
        Dedent();
        PrintIndented($"Exiting class definition: {context.GetChild(1).GetText()}");
    }

    public override void EnterFunc_def(SofiiParser.Func_defContext context)
    {
        PrintIndented($"Entering function definition: {context.GetChild(1).GetText()}");
        Indent();
    }

    public override void ExitFunc_def(SofiiParser.Func_defContext context)
    {
        Dedent();
        PrintIndented($"Exiting function definition: {context.GetChild(1).GetText()}");
    }

    public override void EnterInit_def(SofiiParser.Init_defContext context)
    {
        PrintIndented($"Entering init definition: {context.GetChild(1).GetText()}");
        Indent();
    }

    public override void ExitInit_def(SofiiParser.Init_defContext context)
    {
        Dedent();
        PrintIndented($"Exiting init definition: {context.GetChild(1).GetText()}");
    }

    public override void EnterMacro_def(SofiiParser.Macro_defContext context)
    {
        PrintIndented($"Entering macro definition: {context.GetChild(1).GetText()}");
        Indent();
    }

    public override void ExitMacro_def(SofiiParser.Macro_defContext context)
    {
        Dedent();
        PrintIndented($"Exiting macro definition: {context.GetChild(1).GetText()}");
    }

    public override void EnterVar_def(SofiiParser.Var_defContext context)
    {
        PrintIndented($"Entering variable definition: {context.GetText()}");
        Indent();
    }

    public override void ExitVar_def(SofiiParser.Var_defContext context)
    {
        Dedent();
        PrintIndented($"Exiting variable definition: {context.GetText()}");
    }

    public override void EnterConst_def(SofiiParser.Const_defContext context)
    {
        PrintIndented($"Entering constant definition: {context.GetText()}");
        Indent();
    }

    public override void ExitConst_def(SofiiParser.Const_defContext context)
    {
        Dedent();
        PrintIndented($"Exiting constant definition: {context.GetText()}");
    }

    public override void EnterAssign_stmt(SofiiParser.Assign_stmtContext context)
    {
        PrintIndented($"Entering assignment statement: {context.GetText()}");
        Indent();
    }

    public override void ExitAssign_stmt(SofiiParser.Assign_stmtContext context)
    {
        Dedent();
        PrintIndented($"Exiting assignment statement: {context.GetText()}");
    }

    public override void EnterReturn_stmt(SofiiParser.Return_stmtContext context)
    {
        PrintIndented($"Entering return statement: {context.GetText()}");
        Indent();
    }

    public override void ExitReturn_stmt(SofiiParser.Return_stmtContext context)
    {
        Dedent();
        PrintIndented($"Exiting return statement: {context.GetText()}");
    }

    public override void EnterIf_stmt(SofiiParser.If_stmtContext context)
    {
        PrintIndented($"Entering if statement: {context.GetText()}");
        Indent();
    }

    public override void ExitIf_stmt(SofiiParser.If_stmtContext context)
    {
        Dedent();
        PrintIndented($"Exiting if statement: {context.GetText()}");
    }

    public override void EnterFor_stmt(SofiiParser.For_stmtContext context)
    {
        PrintIndented($"Entering for statement: {context.GetText()}");
        Indent();
    }

    public override void ExitFor_stmt(SofiiParser.For_stmtContext context)
    {
        Dedent();
        PrintIndented($"Exiting for statement: {context.GetText()}");
    }

    public override void EnterWhile_stmt(SofiiParser.While_stmtContext context)
    {
        PrintIndented($"Entering while statement: {context.GetText()}");
        Indent();
    }

    public override void ExitWhile_stmt(SofiiParser.While_stmtContext context)
    {
        Dedent();
        PrintIndented($"Exiting while statement: {context.GetText()}");
    }

    public override void EnterSwitch_stmt(SofiiParser.Switch_stmtContext context)
    {
        PrintIndented($"Entering switch statement: {context.GetText()}");
        Indent();
    }

    public override void ExitSwitch_stmt(SofiiParser.Switch_stmtContext context)
    {
        Dedent();
        PrintIndented($"Exiting switch statement: {context.GetText()}");
    }

    public override void EnterGuard_stmt(SofiiParser.Guard_stmtContext context)
    {
        PrintIndented($"Entering guard statement: {context.GetText()}");
        Indent();
    }

    public override void ExitGuard_stmt(SofiiParser.Guard_stmtContext context)
    {
        Dedent();
        PrintIndented($"Exiting guard statement: {context.GetText()}");
    }

    public override void EnterCommand_call_stmt(SofiiParser.Command_call_stmtContext context)
    {
        PrintIndented($"Entering command call statement: {context.GetText()}");
        Indent();
    }

    public override void ExitCommand_call_stmt(SofiiParser.Command_call_stmtContext context)
    {
        Dedent();
        PrintIndented($"Exiting command call statement: {context.GetText()}");
    }

    public override void EnterExpression(SofiiParser.ExpressionContext context)
    {
        PrintIndented($"Entering expression: {context.GetText()}");
        Indent();
    }

    public override void ExitExpression(SofiiParser.ExpressionContext context)
    {
        Dedent();
        PrintIndented($"Exiting expression: {context.GetText()}");
    }

    public override void EnterLiteral(SofiiParser.LiteralContext context)
    {
        PrintIndented($"Entering literal: {context.GetText()}");
        Indent();
    }

    public override void ExitLiteral(SofiiParser.LiteralContext context)
    {
        Dedent();
        PrintIndented($"Exiting literal: {context.GetText()}");
    }

    public override void EnterType(SofiiParser.TypeContext context)
    {
        PrintIndented($"Entering type: {context.GetText()}");
        Indent();
    }

    public override void ExitType(SofiiParser.TypeContext context)
    {
        Dedent();
        PrintIndented($"Exiting type: {context.GetText()}");
    }

    public string GetOutput()
    {
        return _output.ToString();
    }
}

