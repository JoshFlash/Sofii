//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Sofii.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SofiiParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface ISofiiListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] SofiiParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] SofiiParser.ProgramContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.within_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWithin_stmt([NotNull] SofiiParser.Within_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.within_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWithin_stmt([NotNull] SofiiParser.Within_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.use_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUse_stmt([NotNull] SofiiParser.Use_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.use_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUse_stmt([NotNull] SofiiParser.Use_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] SofiiParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] SofiiParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.enum_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnum_def([NotNull] SofiiParser.Enum_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.enum_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnum_def([NotNull] SofiiParser.Enum_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.enum_case"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnum_case([NotNull] SofiiParser.Enum_caseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.enum_case"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnum_case([NotNull] SofiiParser.Enum_caseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.traits_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTraits_def([NotNull] SofiiParser.Traits_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.traits_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTraits_def([NotNull] SofiiParser.Traits_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.class_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClass_def([NotNull] SofiiParser.Class_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.class_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClass_def([NotNull] SofiiParser.Class_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.const_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConst_def([NotNull] SofiiParser.Const_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.const_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConst_def([NotNull] SofiiParser.Const_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.macro_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMacro_def([NotNull] SofiiParser.Macro_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.macro_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMacro_def([NotNull] SofiiParser.Macro_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.func_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_def([NotNull] SofiiParser.Func_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.func_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_def([NotNull] SofiiParser.Func_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.param_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParam_list([NotNull] SofiiParser.Param_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.param_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParam_list([NotNull] SofiiParser.Param_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParam([NotNull] SofiiParser.ParamContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParam([NotNull] SofiiParser.ParamContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType([NotNull] SofiiParser.TypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType([NotNull] SofiiParser.TypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.var_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVar_def([NotNull] SofiiParser.Var_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.var_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVar_def([NotNull] SofiiParser.Var_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.assign_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssign_stmt([NotNull] SofiiParser.Assign_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.assign_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssign_stmt([NotNull] SofiiParser.Assign_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.return_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturn_stmt([NotNull] SofiiParser.Return_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.return_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturn_stmt([NotNull] SofiiParser.Return_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.if_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIf_stmt([NotNull] SofiiParser.If_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.if_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIf_stmt([NotNull] SofiiParser.If_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.for_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_stmt([NotNull] SofiiParser.For_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.for_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_stmt([NotNull] SofiiParser.For_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.while_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhile_stmt([NotNull] SofiiParser.While_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.while_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhile_stmt([NotNull] SofiiParser.While_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.switch_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitch_stmt([NotNull] SofiiParser.Switch_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.switch_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitch_stmt([NotNull] SofiiParser.Switch_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.switch_case"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitch_case([NotNull] SofiiParser.Switch_caseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.switch_case"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitch_case([NotNull] SofiiParser.Switch_caseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] SofiiParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] SofiiParser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.expression_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression_stmt([NotNull] SofiiParser.Expression_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.expression_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression_stmt([NotNull] SofiiParser.Expression_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] SofiiParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] SofiiParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimary([NotNull] SofiiParser.PrimaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimary([NotNull] SofiiParser.PrimaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.func_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_call([NotNull] SofiiParser.Func_callContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.func_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_call([NotNull] SofiiParser.Func_callContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SofiiParser.operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperator([NotNull] SofiiParser.OperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SofiiParser.operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperator([NotNull] SofiiParser.OperatorContext context);
}
