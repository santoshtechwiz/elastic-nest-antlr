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

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class DemoLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, BOOLEAN=3, NULL=4, COMPARISON_OPERATOR=5, AND=6, OR=7, 
		O=8, R=9, A=10, N=11, D=12, EQ=13, E=14, Q=15, NE=16, GT=17, LT=18, GE=19, 
		LE=20, CO=21, SW=22, EW=23, BR_OPEN=24, BR_CLOSE=25, ATTRNAME=26, STRING=27, 
		DOUBLE=28, INT=29, EXP=30, WS=31;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "ATTR_NAME_CHAR", "DIGIT", "ALPHA", "ESC", "UNICODE", 
		"HEX", "BOOLEAN", "NULL", "COMPARISON_OPERATOR", "AND", "OR", "O", "R", 
		"A", "N", "D", "EQ", "E", "Q", "NE", "GT", "LT", "GE", "LE", "CO", "SW", 
		"EW", "BR_OPEN", "BR_CLOSE", "ATTRNAME", "STRING", "DOUBLE", "INT", "EXP", 
		"WS"
	};


	public DemoLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public DemoLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'.'", "'-'", null, "'null'", null, null, null, null, null, null, 
		null, null, null, null, null, "'ne'", "'gt'", "'lt'", "'ge'", "'le'", 
		"'co'", "'sw'", "'ew'", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "BOOLEAN", "NULL", "COMPARISON_OPERATOR", "AND", "OR", 
		"O", "R", "A", "N", "D", "EQ", "E", "Q", "NE", "GT", "LT", "GE", "LE", 
		"CO", "SW", "EW", "BR_OPEN", "BR_CLOSE", "ATTRNAME", "STRING", "DOUBLE", 
		"INT", "EXP", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Demo.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static DemoLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '!', '\xE5', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x5', '\x4', 'U', '\n', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x5', '\a', '^', '\n', '\a', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x5', '\n', 'q', '\n', '\n', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x5', '\x14', '\x8F', '\n', '\x14', '\x3', 
		'\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', 
		'\x17', '\x3', '\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', 
		'\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', 
		'\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', 
		'\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', 
		'\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', '\x3', '\x1F', '\x3', 
		' ', '\x3', ' ', '\x3', '!', '\x3', '!', '\a', '!', '\xB3', '\n', '!', 
		'\f', '!', '\xE', '!', '\xB6', '\v', '!', '\x3', '\"', '\x3', '\"', '\x3', 
		'\"', '\a', '\"', '\xBB', '\n', '\"', '\f', '\"', '\xE', '\"', '\xBE', 
		'\v', '\"', '\x3', '\"', '\x3', '\"', '\x3', '#', '\x5', '#', '\xC3', 
		'\n', '#', '\x3', '#', '\x3', '#', '\x3', '#', '\x6', '#', '\xC8', '\n', 
		'#', '\r', '#', '\xE', '#', '\xC9', '\x3', '#', '\x5', '#', '\xCD', '\n', 
		'#', '\x3', '$', '\x3', '$', '\x3', '$', '\a', '$', '\xD2', '\n', '$', 
		'\f', '$', '\xE', '$', '\xD5', '\v', '$', '\x5', '$', '\xD7', '\n', '$', 
		'\x3', '%', '\x3', '%', '\x5', '%', '\xDB', '\n', '%', '\x3', '%', '\x3', 
		'%', '\x3', '&', '\x6', '&', '\xE0', '\n', '&', '\r', '&', '\xE', '&', 
		'\xE1', '\x3', '&', '\x3', '&', '\x2', '\x2', '\'', '\x3', '\x3', '\x5', 
		'\x4', '\a', '\x2', '\t', '\x2', '\v', '\x2', '\r', '\x2', '\xF', '\x2', 
		'\x11', '\x2', '\x13', '\x5', '\x15', '\x6', '\x17', '\a', '\x19', '\b', 
		'\x1B', '\t', '\x1D', '\n', '\x1F', '\v', '!', '\f', '#', '\r', '%', '\xE', 
		'\'', '\xF', ')', '\x10', '+', '\x11', '-', '\x12', '/', '\x13', '\x31', 
		'\x14', '\x33', '\x15', '\x35', '\x16', '\x37', '\x17', '\x39', '\x18', 
		';', '\x19', '=', '\x1A', '?', '\x1B', '\x41', '\x1C', '\x43', '\x1D', 
		'\x45', '\x1E', 'G', '\x1F', 'I', ' ', 'K', '!', '\x3', '\x2', '\x12', 
		'\x5', '\x2', '/', '/', '<', '<', '\x61', '\x61', '\x4', '\x2', '\x43', 
		'\\', '\x63', '|', '\n', '\x2', '$', '$', '\x31', '\x31', '^', '^', '\x64', 
		'\x64', 'h', 'h', 'p', 'p', 't', 't', 'v', 'v', '\x5', '\x2', '\x32', 
		';', '\x43', 'H', '\x63', 'h', '\x4', '\x2', 'Q', 'Q', 'q', 'q', '\x4', 
		'\x2', 'T', 'T', 't', 't', '\x4', '\x2', '\x43', '\x43', '\x63', '\x63', 
		'\x4', '\x2', 'P', 'P', 'p', 'p', '\x4', '\x2', '\x46', '\x46', '\x66', 
		'\x66', '\x4', '\x2', 'G', 'G', 'g', 'g', '\x4', '\x2', 'S', 'S', 's', 
		's', '\x4', '\x2', '$', '$', '^', '^', '\x3', '\x2', '\x32', ';', '\x3', 
		'\x2', '\x33', ';', '\x4', '\x2', '-', '-', '/', '/', '\x4', '\x2', '\v', 
		'\v', '\"', '\"', '\x2', '\xED', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', 
		')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', 
		'\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', '=', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', '\x2', '\x41', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x43', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 'G', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'I', '\x3', '\x2', '\x2', '\x2', '\x2', 'K', '\x3', '\x2', '\x2', 
		'\x2', '\x3', 'M', '\x3', '\x2', '\x2', '\x2', '\x5', 'O', '\x3', '\x2', 
		'\x2', '\x2', '\a', 'T', '\x3', '\x2', '\x2', '\x2', '\t', 'V', '\x3', 
		'\x2', '\x2', '\x2', '\v', 'X', '\x3', '\x2', '\x2', '\x2', '\r', 'Z', 
		'\x3', '\x2', '\x2', '\x2', '\xF', '_', '\x3', '\x2', '\x2', '\x2', '\x11', 
		'\x65', '\x3', '\x2', '\x2', '\x2', '\x13', 'p', '\x3', '\x2', '\x2', 
		'\x2', '\x15', 'r', '\x3', '\x2', '\x2', '\x2', '\x17', 'w', '\x3', '\x2', 
		'\x2', '\x2', '\x19', 'y', '\x3', '\x2', '\x2', '\x2', '\x1B', '}', '\x3', 
		'\x2', '\x2', '\x2', '\x1D', '\x80', '\x3', '\x2', '\x2', '\x2', '\x1F', 
		'\x82', '\x3', '\x2', '\x2', '\x2', '!', '\x84', '\x3', '\x2', '\x2', 
		'\x2', '#', '\x86', '\x3', '\x2', '\x2', '\x2', '%', '\x88', '\x3', '\x2', 
		'\x2', '\x2', '\'', '\x8E', '\x3', '\x2', '\x2', '\x2', ')', '\x90', '\x3', 
		'\x2', '\x2', '\x2', '+', '\x92', '\x3', '\x2', '\x2', '\x2', '-', '\x94', 
		'\x3', '\x2', '\x2', '\x2', '/', '\x97', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\x9A', '\x3', '\x2', '\x2', '\x2', '\x33', '\x9D', '\x3', '\x2', '\x2', 
		'\x2', '\x35', '\xA0', '\x3', '\x2', '\x2', '\x2', '\x37', '\xA3', '\x3', 
		'\x2', '\x2', '\x2', '\x39', '\xA6', '\x3', '\x2', '\x2', '\x2', ';', 
		'\xA9', '\x3', '\x2', '\x2', '\x2', '=', '\xAC', '\x3', '\x2', '\x2', 
		'\x2', '?', '\xAE', '\x3', '\x2', '\x2', '\x2', '\x41', '\xB0', '\x3', 
		'\x2', '\x2', '\x2', '\x43', '\xB7', '\x3', '\x2', '\x2', '\x2', '\x45', 
		'\xC2', '\x3', '\x2', '\x2', '\x2', 'G', '\xD6', '\x3', '\x2', '\x2', 
		'\x2', 'I', '\xD8', '\x3', '\x2', '\x2', '\x2', 'K', '\xDF', '\x3', '\x2', 
		'\x2', '\x2', 'M', 'N', '\a', '\x30', '\x2', '\x2', 'N', '\x4', '\x3', 
		'\x2', '\x2', '\x2', 'O', 'P', '\a', '/', '\x2', '\x2', 'P', '\x6', '\x3', 
		'\x2', '\x2', '\x2', 'Q', 'U', '\t', '\x2', '\x2', '\x2', 'R', 'U', '\x5', 
		'\t', '\x5', '\x2', 'S', 'U', '\x5', '\v', '\x6', '\x2', 'T', 'Q', '\x3', 
		'\x2', '\x2', '\x2', 'T', 'R', '\x3', '\x2', '\x2', '\x2', 'T', 'S', '\x3', 
		'\x2', '\x2', '\x2', 'U', '\b', '\x3', '\x2', '\x2', '\x2', 'V', 'W', 
		'\x4', '\x32', ';', '\x2', 'W', '\n', '\x3', '\x2', '\x2', '\x2', 'X', 
		'Y', '\t', '\x3', '\x2', '\x2', 'Y', '\f', '\x3', '\x2', '\x2', '\x2', 
		'Z', ']', '\a', '^', '\x2', '\x2', '[', '^', '\t', '\x4', '\x2', '\x2', 
		'\\', '^', '\x5', '\xF', '\b', '\x2', ']', '[', '\x3', '\x2', '\x2', '\x2', 
		']', '\\', '\x3', '\x2', '\x2', '\x2', '^', '\xE', '\x3', '\x2', '\x2', 
		'\x2', '_', '`', '\a', 'w', '\x2', '\x2', '`', '\x61', '\x5', '\x11', 
		'\t', '\x2', '\x61', '\x62', '\x5', '\x11', '\t', '\x2', '\x62', '\x63', 
		'\x5', '\x11', '\t', '\x2', '\x63', '\x64', '\x5', '\x11', '\t', '\x2', 
		'\x64', '\x10', '\x3', '\x2', '\x2', '\x2', '\x65', '\x66', '\t', '\x5', 
		'\x2', '\x2', '\x66', '\x12', '\x3', '\x2', '\x2', '\x2', 'g', 'h', '\a', 
		'v', '\x2', '\x2', 'h', 'i', '\a', 't', '\x2', '\x2', 'i', 'j', '\a', 
		'w', '\x2', '\x2', 'j', 'q', '\a', 'g', '\x2', '\x2', 'k', 'l', '\a', 
		'h', '\x2', '\x2', 'l', 'm', '\a', '\x63', '\x2', '\x2', 'm', 'n', '\a', 
		'n', '\x2', '\x2', 'n', 'o', '\a', 'u', '\x2', '\x2', 'o', 'q', '\a', 
		'g', '\x2', '\x2', 'p', 'g', '\x3', '\x2', '\x2', '\x2', 'p', 'k', '\x3', 
		'\x2', '\x2', '\x2', 'q', '\x14', '\x3', '\x2', '\x2', '\x2', 'r', 's', 
		'\a', 'p', '\x2', '\x2', 's', 't', '\a', 'w', '\x2', '\x2', 't', 'u', 
		'\a', 'n', '\x2', '\x2', 'u', 'v', '\a', 'n', '\x2', '\x2', 'v', '\x16', 
		'\x3', '\x2', '\x2', '\x2', 'w', 'x', '\x5', '\'', '\x14', '\x2', 'x', 
		'\x18', '\x3', '\x2', '\x2', '\x2', 'y', 'z', '\x5', '!', '\x11', '\x2', 
		'z', '{', '\x5', '#', '\x12', '\x2', '{', '|', '\x5', '%', '\x13', '\x2', 
		'|', '\x1A', '\x3', '\x2', '\x2', '\x2', '}', '~', '\x5', '\x1D', '\xF', 
		'\x2', '~', '\x7F', '\x5', '\x1F', '\x10', '\x2', '\x7F', '\x1C', '\x3', 
		'\x2', '\x2', '\x2', '\x80', '\x81', '\t', '\x6', '\x2', '\x2', '\x81', 
		'\x1E', '\x3', '\x2', '\x2', '\x2', '\x82', '\x83', '\t', '\a', '\x2', 
		'\x2', '\x83', ' ', '\x3', '\x2', '\x2', '\x2', '\x84', '\x85', '\t', 
		'\b', '\x2', '\x2', '\x85', '\"', '\x3', '\x2', '\x2', '\x2', '\x86', 
		'\x87', '\t', '\t', '\x2', '\x2', '\x87', '$', '\x3', '\x2', '\x2', '\x2', 
		'\x88', '\x89', '\t', '\n', '\x2', '\x2', '\x89', '&', '\x3', '\x2', '\x2', 
		'\x2', '\x8A', '\x8F', '\a', '?', '\x2', '\x2', '\x8B', '\x8C', '\x5', 
		')', '\x15', '\x2', '\x8C', '\x8D', '\x5', '+', '\x16', '\x2', '\x8D', 
		'\x8F', '\x3', '\x2', '\x2', '\x2', '\x8E', '\x8A', '\x3', '\x2', '\x2', 
		'\x2', '\x8E', '\x8B', '\x3', '\x2', '\x2', '\x2', '\x8F', '(', '\x3', 
		'\x2', '\x2', '\x2', '\x90', '\x91', '\t', '\v', '\x2', '\x2', '\x91', 
		'*', '\x3', '\x2', '\x2', '\x2', '\x92', '\x93', '\t', '\f', '\x2', '\x2', 
		'\x93', ',', '\x3', '\x2', '\x2', '\x2', '\x94', '\x95', '\a', 'p', '\x2', 
		'\x2', '\x95', '\x96', '\a', 'g', '\x2', '\x2', '\x96', '.', '\x3', '\x2', 
		'\x2', '\x2', '\x97', '\x98', '\a', 'i', '\x2', '\x2', '\x98', '\x99', 
		'\a', 'v', '\x2', '\x2', '\x99', '\x30', '\x3', '\x2', '\x2', '\x2', '\x9A', 
		'\x9B', '\a', 'n', '\x2', '\x2', '\x9B', '\x9C', '\a', 'v', '\x2', '\x2', 
		'\x9C', '\x32', '\x3', '\x2', '\x2', '\x2', '\x9D', '\x9E', '\a', 'i', 
		'\x2', '\x2', '\x9E', '\x9F', '\a', 'g', '\x2', '\x2', '\x9F', '\x34', 
		'\x3', '\x2', '\x2', '\x2', '\xA0', '\xA1', '\a', 'n', '\x2', '\x2', '\xA1', 
		'\xA2', '\a', 'g', '\x2', '\x2', '\xA2', '\x36', '\x3', '\x2', '\x2', 
		'\x2', '\xA3', '\xA4', '\a', '\x65', '\x2', '\x2', '\xA4', '\xA5', '\a', 
		'q', '\x2', '\x2', '\xA5', '\x38', '\x3', '\x2', '\x2', '\x2', '\xA6', 
		'\xA7', '\a', 'u', '\x2', '\x2', '\xA7', '\xA8', '\a', 'y', '\x2', '\x2', 
		'\xA8', ':', '\x3', '\x2', '\x2', '\x2', '\xA9', '\xAA', '\a', 'g', '\x2', 
		'\x2', '\xAA', '\xAB', '\a', 'y', '\x2', '\x2', '\xAB', '<', '\x3', '\x2', 
		'\x2', '\x2', '\xAC', '\xAD', '\a', '*', '\x2', '\x2', '\xAD', '>', '\x3', 
		'\x2', '\x2', '\x2', '\xAE', '\xAF', '\a', '+', '\x2', '\x2', '\xAF', 
		'@', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xB4', '\x5', '\v', '\x6', '\x2', 
		'\xB1', '\xB3', '\x5', '\a', '\x4', '\x2', '\xB2', '\xB1', '\x3', '\x2', 
		'\x2', '\x2', '\xB3', '\xB6', '\x3', '\x2', '\x2', '\x2', '\xB4', '\xB2', 
		'\x3', '\x2', '\x2', '\x2', '\xB4', '\xB5', '\x3', '\x2', '\x2', '\x2', 
		'\xB5', '\x42', '\x3', '\x2', '\x2', '\x2', '\xB6', '\xB4', '\x3', '\x2', 
		'\x2', '\x2', '\xB7', '\xBC', '\a', '$', '\x2', '\x2', '\xB8', '\xBB', 
		'\x5', '\r', '\a', '\x2', '\xB9', '\xBB', '\n', '\r', '\x2', '\x2', '\xBA', 
		'\xB8', '\x3', '\x2', '\x2', '\x2', '\xBA', '\xB9', '\x3', '\x2', '\x2', 
		'\x2', '\xBB', '\xBE', '\x3', '\x2', '\x2', '\x2', '\xBC', '\xBA', '\x3', 
		'\x2', '\x2', '\x2', '\xBC', '\xBD', '\x3', '\x2', '\x2', '\x2', '\xBD', 
		'\xBF', '\x3', '\x2', '\x2', '\x2', '\xBE', '\xBC', '\x3', '\x2', '\x2', 
		'\x2', '\xBF', '\xC0', '\a', '$', '\x2', '\x2', '\xC0', '\x44', '\x3', 
		'\x2', '\x2', '\x2', '\xC1', '\xC3', '\a', '/', '\x2', '\x2', '\xC2', 
		'\xC1', '\x3', '\x2', '\x2', '\x2', '\xC2', '\xC3', '\x3', '\x2', '\x2', 
		'\x2', '\xC3', '\xC4', '\x3', '\x2', '\x2', '\x2', '\xC4', '\xC5', '\x5', 
		'G', '$', '\x2', '\xC5', '\xC7', '\a', '\x30', '\x2', '\x2', '\xC6', '\xC8', 
		'\t', '\xE', '\x2', '\x2', '\xC7', '\xC6', '\x3', '\x2', '\x2', '\x2', 
		'\xC8', '\xC9', '\x3', '\x2', '\x2', '\x2', '\xC9', '\xC7', '\x3', '\x2', 
		'\x2', '\x2', '\xC9', '\xCA', '\x3', '\x2', '\x2', '\x2', '\xCA', '\xCC', 
		'\x3', '\x2', '\x2', '\x2', '\xCB', '\xCD', '\x5', 'I', '%', '\x2', '\xCC', 
		'\xCB', '\x3', '\x2', '\x2', '\x2', '\xCC', '\xCD', '\x3', '\x2', '\x2', 
		'\x2', '\xCD', '\x46', '\x3', '\x2', '\x2', '\x2', '\xCE', '\xD7', '\a', 
		'\x32', '\x2', '\x2', '\xCF', '\xD3', '\t', '\xF', '\x2', '\x2', '\xD0', 
		'\xD2', '\t', '\xE', '\x2', '\x2', '\xD1', '\xD0', '\x3', '\x2', '\x2', 
		'\x2', '\xD2', '\xD5', '\x3', '\x2', '\x2', '\x2', '\xD3', '\xD1', '\x3', 
		'\x2', '\x2', '\x2', '\xD3', '\xD4', '\x3', '\x2', '\x2', '\x2', '\xD4', 
		'\xD7', '\x3', '\x2', '\x2', '\x2', '\xD5', '\xD3', '\x3', '\x2', '\x2', 
		'\x2', '\xD6', '\xCE', '\x3', '\x2', '\x2', '\x2', '\xD6', '\xCF', '\x3', 
		'\x2', '\x2', '\x2', '\xD7', 'H', '\x3', '\x2', '\x2', '\x2', '\xD8', 
		'\xDA', '\t', '\v', '\x2', '\x2', '\xD9', '\xDB', '\t', '\x10', '\x2', 
		'\x2', '\xDA', '\xD9', '\x3', '\x2', '\x2', '\x2', '\xDA', '\xDB', '\x3', 
		'\x2', '\x2', '\x2', '\xDB', '\xDC', '\x3', '\x2', '\x2', '\x2', '\xDC', 
		'\xDD', '\x5', 'G', '$', '\x2', '\xDD', 'J', '\x3', '\x2', '\x2', '\x2', 
		'\xDE', '\xE0', '\t', '\x11', '\x2', '\x2', '\xDF', '\xDE', '\x3', '\x2', 
		'\x2', '\x2', '\xE0', '\xE1', '\x3', '\x2', '\x2', '\x2', '\xE1', '\xDF', 
		'\x3', '\x2', '\x2', '\x2', '\xE1', '\xE2', '\x3', '\x2', '\x2', '\x2', 
		'\xE2', '\xE3', '\x3', '\x2', '\x2', '\x2', '\xE3', '\xE4', '\b', '&', 
		'\x2', '\x2', '\xE4', 'L', '\x3', '\x2', '\x2', '\x2', '\x11', '\x2', 
		'T', ']', 'p', '\x8E', '\xB4', '\xBA', '\xBC', '\xC2', '\xC9', '\xCC', 
		'\xD3', '\xD6', '\xDA', '\xE1', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
