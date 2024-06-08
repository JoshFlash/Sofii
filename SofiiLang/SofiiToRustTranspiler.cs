using System.Text;

public class SofiiToRustTranspiler : SofiiBaseListener
{
    private readonly StringBuilder _rustCode = new StringBuilder();
    private int _indentLevel = 0;

    private void Indent() => _indentLevel++;
    private void Dedent() => _indentLevel--;

    private void PrintIndented(string text)
    {
        _rustCode.AppendLine(new string(' ', _indentLevel * 4) + text);
    }

    public string GetRustCode() => _rustCode.ToString();

    public override void EnterWithin_stmt(SofiiParser.Within_stmtContext context)
    {
        var moduleName = context.IDENTIFIER(0).GetText();
        PrintIndented($"mod {moduleName} {{");
        
        Indent();
    }

    public override void EnterUse_stmt(SofiiParser.Use_stmtContext context)
    {
        var library = context.IDENTIFIER(0).GetText().Replace("use ", "");
        var useStatement = $"use {library.Replace(".", "::")};\n";

        _rustCode.Insert(0, useStatement);
    }

    public override void EnterMacro_def(SofiiParser.Macro_defContext context)
    {
        var macroName = context.IDENTIFIER().GetText();
        var genericParams = context.generic_params()?.GetText();
        PrintIndented($"macro_rules! {macroName} {genericParams} {{");
        Indent();
    }

    public override void ExitMacro_def(SofiiParser.Macro_defContext context)
    {
        Dedent();
        PrintIndented("}");
    }

    public override void EnterEnum_def(SofiiParser.Enum_defContext context)
    {
        var enumName = context.IDENTIFIER().GetText();
        PrintIndented($"enum {enumName} {{");
        Indent();
    }

    public override void ExitEnum_def(SofiiParser.Enum_defContext context)
    {
        Dedent();
        PrintIndented("}");
    }

    public override void EnterEnum_case(SofiiParser.Enum_caseContext context)
    {
        var caseName = context.IDENTIFIER().GetText();
        var type = context.type()?.GetText();
        if (type != null)
        {
            PrintIndented($"{caseName}({type}),");
        }
        else
        {
            PrintIndented($"{caseName},");
        }
    }

    public override void EnterTrait_def(SofiiParser.Trait_defContext context)
    {
        var traitName = context.IDENTIFIER().GetText();
        PrintIndented($"trait {traitName} {{");
        Indent();
    }

    public override void ExitTrait_def(SofiiParser.Trait_defContext context)
    {
        Dedent();
        PrintIndented("}");
    }

    public override void EnterTrait_method(SofiiParser.Trait_methodContext context)
    {
        var methodName = context.IDENTIFIER().GetText();
        var paramsList = context.param_list()?.GetText();
        var returnType = context.type()?.GetText();
        PrintIndented($"fn {methodName}({paramsList}) -> {returnType};");
    }

    public override void EnterClass_def(SofiiParser.Class_defContext context)
    {
        var className = context.IDENTIFIER(0).GetText();
        PrintIndented($"struct {className} {{");
        Indent();
    }

    public override void ExitClass_def(SofiiParser.Class_defContext context)
    {
        Dedent();
        PrintIndented("}");
        var className = context.IDENTIFIER(0).GetText();
        PrintIndented($"impl {className} {{");
        Indent();
    }

    public override void EnterConst_def(SofiiParser.Const_defContext context)
    {
        var constName = context.IDENTIFIER().GetText();
        var type = context.type()?.GetText();
        var expr = context.expression()?.GetText();
        PrintIndented($"const {constName}: {type} = {expr};");
    }

    public override void EnterVar_def(SofiiParser.Var_defContext context)
    {
        var varName = context.IDENTIFIER().GetText();
        var type = context.type()?.GetText();
        PrintIndented($"let mut {varName}: {type};");
    }

    public override void EnterFunc_def(SofiiParser.Func_defContext context)
    {
        var funcName = context.IDENTIFIER().GetText();
        var paramsList = context.param_list()?.GetText();
        var returnType = context.type()?.GetText();
        PrintIndented($"fn {funcName}({paramsList}) -> {returnType} {{");
        Indent();
    }

    public override void ExitFunc_def(SofiiParser.Func_defContext context)
    {
        Dedent();
        PrintIndented("}");
    }

    public override void EnterMethod_def(SofiiParser.Method_defContext context)
    {
        var methodName = context.IDENTIFIER().GetText();
        var paramsList = context.param_list()?.GetText();
        var returnType = context.type()?.GetText();
        PrintIndented($"fn {methodName}({paramsList}) -> {returnType} {{");
        Indent();
    }

    public override void ExitMethod_def(SofiiParser.Method_defContext context)
    {
        Dedent();
        PrintIndented("}");
    }

    public override void EnterAssign_stmt(SofiiParser.Assign_stmtContext context)
    {
        var target = context.IDENTIFIER()?.GetText() ?? context.member_access().GetText();
        var expr = context.expression().GetText();
        PrintIndented($"{target} = {expr};");
    }

    public override void EnterReturn_stmt(SofiiParser.Return_stmtContext context)
    {
        var expr = context.expression()?.GetText();
        PrintIndented($"return {expr};");
    }

    public override void EnterIf_stmt(SofiiParser.If_stmtContext context)
    {
        var condition = context.expression().GetText();
        PrintIndented($"if {condition} {{");
        Indent();
    }

    public override void ExitIf_stmt(SofiiParser.If_stmtContext context)
    {
        Dedent();
        PrintIndented("}");
    }

    public override void EnterFor_stmt(SofiiParser.For_stmtContext context)
    {
        var iterator = context.IDENTIFIER().GetText();
        var collection = context.expression().GetText();
        PrintIndented($"for {iterator} in {collection} {{");
        Indent();
    }

    public override void ExitFor_stmt(SofiiParser.For_stmtContext context)
    {
        Dedent();
        PrintIndented("}");
    }

    public override void EnterWhile_stmt(SofiiParser.While_stmtContext context)
    {
        var condition = context.expression().GetText();
        PrintIndented($"while {condition} {{");
        Indent();
    }

    public override void ExitWhile_stmt(SofiiParser.While_stmtContext context)
    {
        Dedent();
        PrintIndented("}");
    }

    public override void EnterSwitch_stmt(SofiiParser.Switch_stmtContext context)
    {
        var expression = context.expression().GetText();
        PrintIndented($"match {expression} {{");
        Indent();
    }

    public override void ExitSwitch_stmt(SofiiParser.Switch_stmtContext context)
    {
        Dedent();
        PrintIndented("}");
    }

    public override void EnterSwitch_case(SofiiParser.Switch_caseContext context)
    {
        var caseType = context.type().GetText();
        var identifier = context.GetText();
        PrintIndented($"{caseType}({identifier}) => {{");
        Indent();
    }

    public override void ExitSwitch_case(SofiiParser.Switch_caseContext context)
    {
        Dedent();
        PrintIndented("},");
    }

    public override void EnterCommand_call_stmt(SofiiParser.Command_call_stmtContext context)
    {
        var call = context.command_call().GetText();
        PrintIndented($"{call};");
    }

    public override void ExitProgram(SofiiParser.ProgramContext context)
    {
        while (_indentLevel > 0)
        {
            Dedent();
            PrintIndented("}");
        }

        _rustCode.Replace("Print", "println!");
    }
}
