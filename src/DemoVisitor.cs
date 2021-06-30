//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Poc and Personal\dslq\Demo.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="DemoParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IDemoVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="DemoParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStart([NotNull] DemoParser.StartContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>compareExp</c>
	/// labeled alternative in <see cref="DemoParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompareExp([NotNull] DemoParser.CompareExpContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>andLogicalExp</c>
	/// labeled alternative in <see cref="DemoParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAndLogicalExp([NotNull] DemoParser.AndLogicalExpContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>bracketExp</c>
	/// labeled alternative in <see cref="DemoParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBracketExp([NotNull] DemoParser.BracketExpContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>orLogicalExp</c>
	/// labeled alternative in <see cref="DemoParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrLogicalExp([NotNull] DemoParser.OrLogicalExpContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DemoParser.attrPath"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttrPath([NotNull] DemoParser.AttrPathContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>boolean</c>
	/// labeled alternative in <see cref="DemoParser.attrValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolean([NotNull] DemoParser.BooleanContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>null</c>
	/// labeled alternative in <see cref="DemoParser.attrValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNull([NotNull] DemoParser.NullContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="DemoParser.attrValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] DemoParser.StringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>double</c>
	/// labeled alternative in <see cref="DemoParser.attrValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDouble([NotNull] DemoParser.DoubleContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>long</c>
	/// labeled alternative in <see cref="DemoParser.attrValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLong([NotNull] DemoParser.LongContext context);
}
