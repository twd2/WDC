// Generated from myl.g4 by ANTLR 4.0.1-SNAPSHOT
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

public partial class mylParser : Parser {
	public const int
		T__19=1, T__18=2, T__17=3, T__16=4, T__15=5, T__14=6, T__13=7, T__12=8, 
		T__11=9, T__10=10, T__9=11, T__8=12, T__7=13, T__6=14, T__5=15, T__4=16, 
		T__3=17, T__2=18, T__1=19, T__0=20, TYPE=21, ID=22, INT=23, COMM_BLOCK=24, 
		LINE_COMM=25, NEWLINE=26, CHAR=27, STRING=28, CONST=29, TRUE=30, FALSE=31, 
		LET=32, EQU=33, GT=34, SHR=35, GTE=36, LT=37, SHL=38, LTE=39, MOD=40, 
		ADD=41, SUB=42, MUL=43, DIV=44, AND=45, OR=46, NOT=47, NEQU=48, XOR=49, 
		SEM=50, WS=51;
	public static readonly string[] tokenNames = {
		"<INVALID>", "'on_interrupt'", "']'", "'&'", "')'", "','", "'while'", 
		"'['", "'for'", "'('", "'uses'", "'if'", "'--'", "'continue'", "'return'", 
		"'asm'", "'{'", "'break'", "'else'", "'}'", "'++'", "TYPE", "ID", "INT", 
		"COMM_BLOCK", "LINE_COMM", "NEWLINE", "CHAR", "STRING", "CONST", "'true'", 
		"'false'", "'='", "'=='", "'>'", "'>>'", "GTE", "'<'", "'<<'", "LTE", 
		"'%'", "'+'", "'-'", "'*'", "'/'", "AND", "OR", "NOT", "NEQU", "XOR", 
		"';'", "WS"
	};
	public const int
		RULE_prog = 0, RULE_stat = 1, RULE_break_stat = 2, RULE_continue_stat = 3, 
		RULE_on_interrupt_stat = 4, RULE_let_stat = 5, RULE_while_stat = 6, RULE_for_stat = 7, 
		RULE_for_step = 8, RULE_if_stat = 9, RULE_func_dec = 10, RULE_func_def = 11, 
		RULE_ids_def = 12, RULE_func_ret = 13, RULE_asm = 14, RULE_number_expr = 15, 
		RULE_self_addsub_stat = 16, RULE_self_addsub = 17, RULE_var_ref = 18, 
		RULE_func_call = 19, RULE_params_use = 20;
	public static readonly string[] ruleNames = {
		"prog", "stat", "break_stat", "continue_stat", "on_interrupt_stat", "let_stat", 
		"while_stat", "for_stat", "for_step", "if_stat", "func_dec", "func_def", 
		"ids_def", "func_ret", "asm", "number_expr", "self_addsub_stat", "self_addsub", 
		"var_ref", "func_call", "params_use"
	};

	public override string GrammarFileName { get { return "myl.g4"; } }

	public override string[] TokenNames { get { return tokenNames; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public mylParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ProgContext : ParserRuleContext {
		public StatContext stat(int i) {
			return GetRuleContext<StatContext>(i);
		}
		public StatContext[] stat() {
			return GetRuleContexts<StatContext>();
		}
		public ProgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_prog; }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterProg(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitProg(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProg(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgContext prog() {
		ProgContext _localctx = new ProgContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_prog);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 45;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << 1) | (1L << 6) | (1L << 8) | (1L << 9) | (1L << 11) | (1L << 12) | (1L << 13) | (1L << 14) | (1L << 15) | (1L << 16) | (1L << 17) | (1L << 20) | (1L << TYPE) | (1L << ID) | (1L << MUL) | (1L << SEM))) != 0)) {
				{
				{
				State = 42; stat();
				}
				}
				State = 47;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatContext : ParserRuleContext {
		public On_interrupt_statContext on_interrupt_stat() {
			return GetRuleContext<On_interrupt_statContext>(0);
		}
		public For_statContext for_stat() {
			return GetRuleContext<For_statContext>(0);
		}
		public Func_decContext func_dec() {
			return GetRuleContext<Func_decContext>(0);
		}
		public ITerminalNode SEM() { return GetToken(mylParser.SEM, 0); }
		public StatContext[] stat() {
			return GetRuleContexts<StatContext>();
		}
		public Func_defContext func_def() {
			return GetRuleContext<Func_defContext>(0);
		}
		public Func_retContext func_ret() {
			return GetRuleContext<Func_retContext>(0);
		}
		public Let_statContext let_stat() {
			return GetRuleContext<Let_statContext>(0);
		}
		public StatContext stat(int i) {
			return GetRuleContext<StatContext>(i);
		}
		public Self_addsub_statContext self_addsub_stat() {
			return GetRuleContext<Self_addsub_statContext>(0);
		}
		public Continue_statContext continue_stat() {
			return GetRuleContext<Continue_statContext>(0);
		}
		public Func_callContext func_call() {
			return GetRuleContext<Func_callContext>(0);
		}
		public Break_statContext break_stat() {
			return GetRuleContext<Break_statContext>(0);
		}
		public While_statContext while_stat() {
			return GetRuleContext<While_statContext>(0);
		}
		public AsmContext asm() {
			return GetRuleContext<AsmContext>(0);
		}
		public If_statContext if_stat() {
			return GetRuleContext<If_statContext>(0);
		}
		public StatContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_stat; }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterStat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitStat(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStat(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatContext stat() {
		StatContext _localctx = new StatContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_stat);
		int _la;
		try {
			State = 90;
			switch (_input.La(1)) {
			case 1:
			case 6:
			case 8:
			case 9:
			case 11:
			case 12:
			case 13:
			case 14:
			case 15:
			case 17:
			case 20:
			case TYPE:
			case ID:
			case MUL:
			case SEM:
				EnterOuterAlt(_localctx, 1);
				{
				State = 80;
				switch ( Interpreter.AdaptivePredict(_input,1,_ctx) ) {
				case 1:
					{
					State = 48; Match(SEM);
					}
					break;

				case 2:
					{
					State = 49; let_stat();
					State = 50; Match(SEM);
					}
					break;

				case 3:
					{
					State = 52; if_stat();
					}
					break;

				case 4:
					{
					State = 53; while_stat();
					}
					break;

				case 5:
					{
					State = 54; for_stat();
					}
					break;

				case 6:
					{
					State = 55; self_addsub_stat();
					State = 56; Match(SEM);
					}
					break;

				case 7:
					{
					State = 58; on_interrupt_stat();
					State = 59; Match(SEM);
					}
					break;

				case 8:
					{
					State = 61; break_stat();
					State = 62; Match(SEM);
					}
					break;

				case 9:
					{
					State = 64; continue_stat();
					State = 65; Match(SEM);
					}
					break;

				case 10:
					{
					State = 67; asm();
					State = 68; Match(SEM);
					}
					break;

				case 11:
					{
					State = 70; func_call();
					State = 71; Match(SEM);
					}
					break;

				case 12:
					{
					State = 73; func_dec();
					State = 74; Match(SEM);
					}
					break;

				case 13:
					{
					State = 76; func_def();
					}
					break;

				case 14:
					{
					State = 77; func_ret();
					State = 78; Match(SEM);
					}
					break;
				}
				}
				break;
			case 16:
				EnterOuterAlt(_localctx, 2);
				{
				State = 82; Match(16);
				State = 86;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << 1) | (1L << 6) | (1L << 8) | (1L << 9) | (1L << 11) | (1L << 12) | (1L << 13) | (1L << 14) | (1L << 15) | (1L << 16) | (1L << 17) | (1L << 20) | (1L << TYPE) | (1L << ID) | (1L << MUL) | (1L << SEM))) != 0)) {
					{
					{
					State = 83; stat();
					}
					}
					State = 88;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				State = 89; Match(19);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Break_statContext : ParserRuleContext {
		public Break_statContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_break_stat; }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterBreak_stat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitBreak_stat(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBreak_stat(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Break_statContext break_stat() {
		Break_statContext _localctx = new Break_statContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_break_stat);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 92; Match(17);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Continue_statContext : ParserRuleContext {
		public Continue_statContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_continue_stat; }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterContinue_stat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitContinue_stat(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitContinue_stat(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Continue_statContext continue_stat() {
		Continue_statContext _localctx = new Continue_statContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_continue_stat);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 94; Match(13);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class On_interrupt_statContext : ParserRuleContext {
		public ITerminalNode ID() { return GetToken(mylParser.ID, 0); }
		public Number_exprContext number_expr() {
			return GetRuleContext<Number_exprContext>(0);
		}
		public On_interrupt_statContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_on_interrupt_stat; }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterOn_interrupt_stat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitOn_interrupt_stat(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOn_interrupt_stat(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public On_interrupt_statContext on_interrupt_stat() {
		On_interrupt_statContext _localctx = new On_interrupt_statContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_on_interrupt_stat);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 96; Match(1);
			State = 97; Match(9);
			State = 98; number_expr(0);
			State = 99; Match(5);
			State = 100; Match(ID);
			State = 101; Match(4);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Let_statContext : ParserRuleContext {
		public Var_refContext var_ref() {
			return GetRuleContext<Var_refContext>(0);
		}
		public Number_exprContext number_expr() {
			return GetRuleContext<Number_exprContext>(0);
		}
		public ITerminalNode LET() { return GetToken(mylParser.LET, 0); }
		public Let_statContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_let_stat; }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterLet_stat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitLet_stat(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLet_stat(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Let_statContext let_stat() {
		Let_statContext _localctx = new Let_statContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_let_stat);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 103; var_ref();
			State = 104; Match(LET);
			State = 105; number_expr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class While_statContext : ParserRuleContext {
		public Number_exprContext number_expr() {
			return GetRuleContext<Number_exprContext>(0);
		}
		public StatContext stat() {
			return GetRuleContext<StatContext>(0);
		}
		public While_statContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_while_stat; }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterWhile_stat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitWhile_stat(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWhile_stat(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public While_statContext while_stat() {
		While_statContext _localctx = new While_statContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_while_stat);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 107; Match(6);
			State = 108; Match(9);
			State = 109; number_expr(0);
			State = 110; Match(4);
			State = 111; stat();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class For_statContext : ParserRuleContext {
		public StatContext sinit;
		public For_stepContext sstep;
		public StatContext smain;
		public StatContext stat(int i) {
			return GetRuleContext<StatContext>(i);
		}
		public For_stepContext for_step() {
			return GetRuleContext<For_stepContext>(0);
		}
		public Number_exprContext number_expr() {
			return GetRuleContext<Number_exprContext>(0);
		}
		public ITerminalNode SEM() { return GetToken(mylParser.SEM, 0); }
		public StatContext[] stat() {
			return GetRuleContexts<StatContext>();
		}
		public For_statContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_for_stat; }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterFor_stat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitFor_stat(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFor_stat(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public For_statContext for_stat() {
		For_statContext _localctx = new For_statContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_for_stat);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 113; Match(8);
			State = 114; Match(9);
			State = 115; _localctx.sinit = stat();
			State = 116; number_expr(0);
			State = 117; Match(SEM);
			State = 118; _localctx.sstep = for_step();
			State = 119; Match(4);
			State = 120; _localctx.smain = stat();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class For_stepContext : ParserRuleContext {
		public Self_addsub_statContext self_addsub_stat() {
			return GetRuleContext<Self_addsub_statContext>(0);
		}
		public StatContext stat() {
			return GetRuleContext<StatContext>(0);
		}
		public Let_statContext let_stat() {
			return GetRuleContext<Let_statContext>(0);
		}
		public For_stepContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_for_step; }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterFor_step(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitFor_step(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFor_step(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public For_stepContext for_step() {
		For_stepContext _localctx = new For_stepContext(_ctx, State);
		EnterRule(_localctx, 16, RULE_for_step);
		try {
			State = 125;
			switch ( Interpreter.AdaptivePredict(_input,4,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 122; let_stat();
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 123; self_addsub_stat();
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 124; stat();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class If_statContext : ParserRuleContext {
		public If_statContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_if_stat; }
	 
		public If_statContext() { }
		public virtual void CopyFrom(If_statContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class Ifelse_nodeContext : If_statContext {
		public StatContext truestat;
		public StatContext falsestat;
		public StatContext stat(int i) {
			return GetRuleContext<StatContext>(i);
		}
		public Number_exprContext number_expr() {
			return GetRuleContext<Number_exprContext>(0);
		}
		public StatContext[] stat() {
			return GetRuleContexts<StatContext>();
		}
		public Ifelse_nodeContext(If_statContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterIfelse_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitIfelse_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIfelse_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class If_nodeContext : If_statContext {
		public Number_exprContext number_expr() {
			return GetRuleContext<Number_exprContext>(0);
		}
		public StatContext stat() {
			return GetRuleContext<StatContext>(0);
		}
		public If_nodeContext(If_statContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterIf_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitIf_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIf_node(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public If_statContext if_stat() {
		If_statContext _localctx = new If_statContext(_ctx, State);
		EnterRule(_localctx, 18, RULE_if_stat);
		try {
			State = 141;
			switch ( Interpreter.AdaptivePredict(_input,5,_ctx) ) {
			case 1:
				_localctx = new If_nodeContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 127; Match(11);
				State = 128; Match(9);
				State = 129; number_expr(0);
				State = 130; Match(4);
				State = 131; stat();
				}
				break;

			case 2:
				_localctx = new Ifelse_nodeContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 133; Match(11);
				State = 134; Match(9);
				State = 135; number_expr(0);
				State = 136; Match(4);
				State = 137; ((Ifelse_nodeContext)_localctx).truestat = stat();
				State = 138; Match(18);
				State = 139; ((Ifelse_nodeContext)_localctx).falsestat = stat();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Func_decContext : ParserRuleContext {
		public Func_decContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_func_dec; }
	 
		public Func_decContext() { }
		public virtual void CopyFrom(Func_decContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class Func_dec_no_varContext : Func_decContext {
		public Ids_defContext params_def;
		public Ids_defContext ids_def() {
			return GetRuleContext<Ids_defContext>(0);
		}
		public ITerminalNode ID() { return GetToken(mylParser.ID, 0); }
		public ITerminalNode TYPE() { return GetToken(mylParser.TYPE, 0); }
		public Func_dec_no_varContext(Func_decContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterFunc_dec_no_var(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitFunc_dec_no_var(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunc_dec_no_var(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Func_dec_varContext : Func_decContext {
		public Ids_defContext params_def;
		public Ids_defContext vars_def;
		public Ids_defContext ids_def(int i) {
			return GetRuleContext<Ids_defContext>(i);
		}
		public Ids_defContext[] ids_def() {
			return GetRuleContexts<Ids_defContext>();
		}
		public ITerminalNode ID() { return GetToken(mylParser.ID, 0); }
		public ITerminalNode TYPE() { return GetToken(mylParser.TYPE, 0); }
		public Func_dec_varContext(Func_decContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterFunc_dec_var(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitFunc_dec_var(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunc_dec_var(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Func_decContext func_dec() {
		Func_decContext _localctx = new Func_decContext(_ctx, State);
		EnterRule(_localctx, 20, RULE_func_dec);
		try {
			State = 159;
			switch ( Interpreter.AdaptivePredict(_input,6,_ctx) ) {
			case 1:
				_localctx = new Func_dec_no_varContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 143; Match(TYPE);
				State = 144; Match(ID);
				State = 145; Match(9);
				State = 146; ((Func_dec_no_varContext)_localctx).params_def = ids_def();
				State = 147; Match(4);
				}
				break;

			case 2:
				_localctx = new Func_dec_varContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 149; Match(TYPE);
				State = 150; Match(ID);
				State = 151; Match(9);
				State = 152; ((Func_dec_varContext)_localctx).params_def = ids_def();
				State = 153; Match(4);
				State = 154; Match(10);
				State = 155; Match(9);
				State = 156; ((Func_dec_varContext)_localctx).vars_def = ids_def();
				State = 157; Match(4);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Func_defContext : ParserRuleContext {
		public Func_defContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_func_def; }
	 
		public Func_defContext() { }
		public virtual void CopyFrom(Func_defContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class Func_def_no_varContext : Func_defContext {
		public Ids_defContext params_def;
		public Ids_defContext ids_def() {
			return GetRuleContext<Ids_defContext>(0);
		}
		public ITerminalNode ID() { return GetToken(mylParser.ID, 0); }
		public StatContext stat() {
			return GetRuleContext<StatContext>(0);
		}
		public ITerminalNode TYPE() { return GetToken(mylParser.TYPE, 0); }
		public Func_def_no_varContext(Func_defContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterFunc_def_no_var(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitFunc_def_no_var(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunc_def_no_var(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Func_def_varContext : Func_defContext {
		public Ids_defContext params_def;
		public Ids_defContext vars_def;
		public Ids_defContext ids_def(int i) {
			return GetRuleContext<Ids_defContext>(i);
		}
		public Ids_defContext[] ids_def() {
			return GetRuleContexts<Ids_defContext>();
		}
		public ITerminalNode ID() { return GetToken(mylParser.ID, 0); }
		public StatContext stat() {
			return GetRuleContext<StatContext>(0);
		}
		public ITerminalNode TYPE() { return GetToken(mylParser.TYPE, 0); }
		public Func_def_varContext(Func_defContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterFunc_def_var(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitFunc_def_var(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunc_def_var(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Func_defContext func_def() {
		Func_defContext _localctx = new Func_defContext(_ctx, State);
		EnterRule(_localctx, 22, RULE_func_def);
		try {
			State = 179;
			switch ( Interpreter.AdaptivePredict(_input,7,_ctx) ) {
			case 1:
				_localctx = new Func_def_no_varContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 161; Match(TYPE);
				State = 162; Match(ID);
				State = 163; Match(9);
				State = 164; ((Func_def_no_varContext)_localctx).params_def = ids_def();
				State = 165; Match(4);
				State = 166; stat();
				}
				break;

			case 2:
				_localctx = new Func_def_varContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 168; Match(TYPE);
				State = 169; Match(ID);
				State = 170; Match(9);
				State = 171; ((Func_def_varContext)_localctx).params_def = ids_def();
				State = 172; Match(4);
				State = 173; Match(10);
				State = 174; Match(9);
				State = 175; ((Func_def_varContext)_localctx).vars_def = ids_def();
				State = 176; Match(4);
				State = 177; stat();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Ids_defContext : ParserRuleContext {
		public ITerminalNode ID(int i) {
			return GetToken(mylParser.ID, i);
		}
		public ITerminalNode[] ID() { return GetTokens(mylParser.ID); }
		public ITerminalNode TYPE(int i) {
			return GetToken(mylParser.TYPE, i);
		}
		public ITerminalNode[] TYPE() { return GetTokens(mylParser.TYPE); }
		public Ids_defContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_ids_def; }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterIds_def(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitIds_def(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIds_def(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Ids_defContext ids_def() {
		Ids_defContext _localctx = new Ids_defContext(_ctx, State);
		EnterRule(_localctx, 24, RULE_ids_def);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 191;
			_la = _input.La(1);
			if (_la==TYPE) {
				{
				State = 181; Match(TYPE);
				State = 182; Match(ID);
				State = 188;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==5) {
					{
					{
					State = 183; Match(5);
					State = 184; Match(TYPE);
					State = 185; Match(ID);
					}
					}
					State = 190;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Func_retContext : ParserRuleContext {
		public Number_exprContext number_expr() {
			return GetRuleContext<Number_exprContext>(0);
		}
		public Func_retContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_func_ret; }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterFunc_ret(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitFunc_ret(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunc_ret(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Func_retContext func_ret() {
		Func_retContext _localctx = new Func_retContext(_ctx, State);
		EnterRule(_localctx, 26, RULE_func_ret);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 193; Match(14);
			State = 194; number_expr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class AsmContext : ParserRuleContext {
		public ITerminalNode STRING() { return GetToken(mylParser.STRING, 0); }
		public AsmContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_asm; }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterAsm(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitAsm(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAsm(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AsmContext asm() {
		AsmContext _localctx = new AsmContext(_ctx, State);
		EnterRule(_localctx, 28, RULE_asm);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 196; Match(15);
			State = 197; Match(9);
			State = 198; Match(STRING);
			State = 199; Match(4);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Number_exprContext : ParserRuleContext {
		public Number_exprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_number_expr; }
	 
		public Number_exprContext() { }
		public virtual void CopyFrom(Number_exprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class Number_expr_nodeContext : Number_exprContext {
		public Number_exprContext number_expr() {
			return GetRuleContext<Number_exprContext>(0);
		}
		public Number_expr_nodeContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterNumber_expr_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitNumber_expr_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumber_expr_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Not_nodeContext : Number_exprContext {
		public ITerminalNode NOT() { return GetToken(mylParser.NOT, 0); }
		public Number_exprContext number_expr() {
			return GetRuleContext<Number_exprContext>(0);
		}
		public Not_nodeContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterNot_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitNot_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNot_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Func_nodeContext : Number_exprContext {
		public Func_callContext func_call() {
			return GetRuleContext<Func_callContext>(0);
		}
		public Func_nodeContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterFunc_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitFunc_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunc_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Ref_nodeContext : Number_exprContext {
		public Var_refContext var_ref() {
			return GetRuleContext<Var_refContext>(0);
		}
		public Ref_nodeContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterRef_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitRef_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRef_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Num_cmp_nodeContext : Number_exprContext {
		public IToken op;
		public ITerminalNode EQU() { return GetToken(mylParser.EQU, 0); }
		public ITerminalNode GT() { return GetToken(mylParser.GT, 0); }
		public ITerminalNode LT() { return GetToken(mylParser.LT, 0); }
		public ITerminalNode NEQU() { return GetToken(mylParser.NEQU, 0); }
		public Number_exprContext number_expr(int i) {
			return GetRuleContext<Number_exprContext>(i);
		}
		public ITerminalNode LTE() { return GetToken(mylParser.LTE, 0); }
		public Number_exprContext[] number_expr() {
			return GetRuleContexts<Number_exprContext>();
		}
		public ITerminalNode GTE() { return GetToken(mylParser.GTE, 0); }
		public Num_cmp_nodeContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterNum_cmp_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitNum_cmp_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNum_cmp_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Or_nodeContext : Number_exprContext {
		public Number_exprContext number_expr(int i) {
			return GetRuleContext<Number_exprContext>(i);
		}
		public Number_exprContext[] number_expr() {
			return GetRuleContexts<Number_exprContext>();
		}
		public ITerminalNode OR() { return GetToken(mylParser.OR, 0); }
		public Or_nodeContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterOr_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitOr_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOr_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Xor_nodeContext : Number_exprContext {
		public ITerminalNode XOR() { return GetToken(mylParser.XOR, 0); }
		public Number_exprContext number_expr(int i) {
			return GetRuleContext<Number_exprContext>(i);
		}
		public Number_exprContext[] number_expr() {
			return GetRuleContexts<Number_exprContext>();
		}
		public Xor_nodeContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterXor_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitXor_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitXor_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ShlshrContext : Number_exprContext {
		public IToken op;
		public ITerminalNode SHR() { return GetToken(mylParser.SHR, 0); }
		public Number_exprContext number_expr(int i) {
			return GetRuleContext<Number_exprContext>(i);
		}
		public ITerminalNode SHL() { return GetToken(mylParser.SHL, 0); }
		public Number_exprContext[] number_expr() {
			return GetRuleContexts<Number_exprContext>();
		}
		public ShlshrContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterShlshr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitShlshr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitShlshr(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Char_nodeContext : Number_exprContext {
		public ITerminalNode CHAR() { return GetToken(mylParser.CHAR, 0); }
		public Char_nodeContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterChar_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitChar_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitChar_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AddsubContext : Number_exprContext {
		public IToken op;
		public ITerminalNode SUB() { return GetToken(mylParser.SUB, 0); }
		public Number_exprContext number_expr(int i) {
			return GetRuleContext<Number_exprContext>(i);
		}
		public Number_exprContext[] number_expr() {
			return GetRuleContexts<Number_exprContext>();
		}
		public ITerminalNode ADD() { return GetToken(mylParser.ADD, 0); }
		public AddsubContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterAddsub(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitAddsub(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAddsub(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Mod_nodeContext : Number_exprContext {
		public Number_exprContext number_expr(int i) {
			return GetRuleContext<Number_exprContext>(i);
		}
		public ITerminalNode MOD() { return GetToken(mylParser.MOD, 0); }
		public Number_exprContext[] number_expr() {
			return GetRuleContexts<Number_exprContext>();
		}
		public Mod_nodeContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterMod_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitMod_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMod_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Const_nodeContext : Number_exprContext {
		public ITerminalNode CONST() { return GetToken(mylParser.CONST, 0); }
		public Const_nodeContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterConst_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitConst_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitConst_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Ref_addr_nodeContext : Number_exprContext {
		public Var_refContext var_ref() {
			return GetRuleContext<Var_refContext>(0);
		}
		public Ref_addr_nodeContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterRef_addr_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitRef_addr_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRef_addr_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MuldivContext : Number_exprContext {
		public IToken op;
		public Number_exprContext number_expr(int i) {
			return GetRuleContext<Number_exprContext>(i);
		}
		public ITerminalNode DIV() { return GetToken(mylParser.DIV, 0); }
		public ITerminalNode MUL() { return GetToken(mylParser.MUL, 0); }
		public Number_exprContext[] number_expr() {
			return GetRuleContexts<Number_exprContext>();
		}
		public MuldivContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterMuldiv(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitMuldiv(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMuldiv(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Int_nodeContext : Number_exprContext {
		public ITerminalNode INT() { return GetToken(mylParser.INT, 0); }
		public Int_nodeContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterInt_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitInt_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInt_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Self_addsub_nodeContext : Number_exprContext {
		public Self_addsubContext self_addsub() {
			return GetRuleContext<Self_addsubContext>(0);
		}
		public Self_addsub_nodeContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterSelf_addsub_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitSelf_addsub_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSelf_addsub_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class And_nodeContext : Number_exprContext {
		public Number_exprContext number_expr(int i) {
			return GetRuleContext<Number_exprContext>(i);
		}
		public ITerminalNode AND() { return GetToken(mylParser.AND, 0); }
		public Number_exprContext[] number_expr() {
			return GetRuleContexts<Number_exprContext>();
		}
		public And_nodeContext(Number_exprContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterAnd_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitAnd_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAnd_node(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Number_exprContext number_expr(int _p) {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = State;
		Number_exprContext _localctx = new Number_exprContext(_ctx, _parentState);
		Number_exprContext _prevctx = _localctx;
		int _startState = 30;
		EnterRecursionRule(_localctx, RULE_number_expr, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 216;
			switch ( Interpreter.AdaptivePredict(_input,10,_ctx) ) {
			case 1:
				{
				_localctx = new Not_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				State = 202; Match(NOT);
				State = 203; number_expr(17);
				}
				break;

			case 2:
				{
				_localctx = new Func_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 204; func_call();
				}
				break;

			case 3:
				{
				_localctx = new Self_addsub_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 205; self_addsub();
				}
				break;

			case 4:
				{
				_localctx = new Ref_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 206; var_ref();
				}
				break;

			case 5:
				{
				_localctx = new Ref_addr_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 207; Match(3);
				State = 208; var_ref();
				}
				break;

			case 6:
				{
				_localctx = new Char_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 209; Match(CHAR);
				}
				break;

			case 7:
				{
				_localctx = new Int_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 210; Match(INT);
				}
				break;

			case 8:
				{
				_localctx = new Const_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 211; Match(CONST);
				}
				break;

			case 9:
				{
				_localctx = new Number_expr_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				State = 212; Match(9);
				State = 213; number_expr(0);
				State = 214; Match(4);
				}
				break;
			}
			_ctx.stop = _input.Lt(-1);
			State = 244;
			_errHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(_input,12,_ctx);
			while ( _alt!=2 && _alt!=-1 ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 242;
					switch ( Interpreter.AdaptivePredict(_input,11,_ctx) ) {
					case 1:
						{
						_localctx = new MuldivContext(new Number_exprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						State = 218;
						if (!(Precpred(_ctx, 16))) throw new FailedPredicateException(this, "Precpred(_ctx, 16)");
						State = 219;
						((MuldivContext)_localctx).op = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==MUL || _la==DIV) ) {
							((MuldivContext)_localctx).op = _errHandler.RecoverInline(this);
						}
						Consume();
						State = 220; number_expr(17);
						}
						break;

					case 2:
						{
						_localctx = new ShlshrContext(new Number_exprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						State = 221;
						if (!(Precpred(_ctx, 15))) throw new FailedPredicateException(this, "Precpred(_ctx, 15)");
						State = 222;
						((ShlshrContext)_localctx).op = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==SHR || _la==SHL) ) {
							((ShlshrContext)_localctx).op = _errHandler.RecoverInline(this);
						}
						Consume();
						State = 223; number_expr(16);
						}
						break;

					case 3:
						{
						_localctx = new AddsubContext(new Number_exprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						State = 224;
						if (!(Precpred(_ctx, 14))) throw new FailedPredicateException(this, "Precpred(_ctx, 14)");
						State = 225;
						((AddsubContext)_localctx).op = _input.Lt(1);
						_la = _input.La(1);
						if ( !(_la==ADD || _la==SUB) ) {
							((AddsubContext)_localctx).op = _errHandler.RecoverInline(this);
						}
						Consume();
						State = 226; number_expr(15);
						}
						break;

					case 4:
						{
						_localctx = new Mod_nodeContext(new Number_exprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						State = 227;
						if (!(Precpred(_ctx, 13))) throw new FailedPredicateException(this, "Precpred(_ctx, 13)");
						State = 228; Match(MOD);
						State = 229; number_expr(14);
						}
						break;

					case 5:
						{
						_localctx = new Num_cmp_nodeContext(new Number_exprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						State = 230;
						if (!(Precpred(_ctx, 12))) throw new FailedPredicateException(this, "Precpred(_ctx, 12)");
						State = 231;
						((Num_cmp_nodeContext)_localctx).op = _input.Lt(1);
						_la = _input.La(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << EQU) | (1L << GT) | (1L << GTE) | (1L << LT) | (1L << LTE) | (1L << NEQU))) != 0)) ) {
							((Num_cmp_nodeContext)_localctx).op = _errHandler.RecoverInline(this);
						}
						Consume();
						State = 232; number_expr(13);
						}
						break;

					case 6:
						{
						_localctx = new And_nodeContext(new Number_exprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						State = 233;
						if (!(Precpred(_ctx, 11))) throw new FailedPredicateException(this, "Precpred(_ctx, 11)");
						State = 234; Match(AND);
						State = 235; number_expr(12);
						}
						break;

					case 7:
						{
						_localctx = new Xor_nodeContext(new Number_exprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						State = 236;
						if (!(Precpred(_ctx, 10))) throw new FailedPredicateException(this, "Precpred(_ctx, 10)");
						State = 237; Match(XOR);
						State = 238; number_expr(11);
						}
						break;

					case 8:
						{
						_localctx = new Or_nodeContext(new Number_exprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						State = 239;
						if (!(Precpred(_ctx, 9))) throw new FailedPredicateException(this, "Precpred(_ctx, 9)");
						State = 240; Match(OR);
						State = 241; number_expr(10);
						}
						break;
					}
					} 
				}
				State = 246;
				_errHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(_input,12,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class Self_addsub_statContext : ParserRuleContext {
		public Self_addsubContext self_addsub() {
			return GetRuleContext<Self_addsubContext>(0);
		}
		public Self_addsub_statContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_self_addsub_stat; }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterSelf_addsub_stat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitSelf_addsub_stat(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSelf_addsub_stat(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Self_addsub_statContext self_addsub_stat() {
		Self_addsub_statContext _localctx = new Self_addsub_statContext(_ctx, State);
		EnterRule(_localctx, 32, RULE_self_addsub_stat);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 247; self_addsub();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Self_addsubContext : ParserRuleContext {
		public Self_addsubContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_self_addsub; }
	 
		public Self_addsubContext() { }
		public virtual void CopyFrom(Self_addsubContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class Addvar_nodeContext : Self_addsubContext {
		public Var_refContext var_ref() {
			return GetRuleContext<Var_refContext>(0);
		}
		public Addvar_nodeContext(Self_addsubContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterAddvar_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitAddvar_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAddvar_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Subvar_nodeContext : Self_addsubContext {
		public Var_refContext var_ref() {
			return GetRuleContext<Var_refContext>(0);
		}
		public Subvar_nodeContext(Self_addsubContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterSubvar_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitSubvar_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSubvar_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Varadd_nodeContext : Self_addsubContext {
		public Var_refContext var_ref() {
			return GetRuleContext<Var_refContext>(0);
		}
		public Varadd_nodeContext(Self_addsubContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterVaradd_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitVaradd_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVaradd_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Varsub_nodeContext : Self_addsubContext {
		public Var_refContext var_ref() {
			return GetRuleContext<Var_refContext>(0);
		}
		public Varsub_nodeContext(Self_addsubContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterVarsub_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitVarsub_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVarsub_node(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Self_addsubContext self_addsub() {
		Self_addsubContext _localctx = new Self_addsubContext(_ctx, State);
		EnterRule(_localctx, 34, RULE_self_addsub);
		try {
			State = 259;
			switch ( Interpreter.AdaptivePredict(_input,13,_ctx) ) {
			case 1:
				_localctx = new Varadd_nodeContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 249; var_ref();
				State = 250; Match(20);
				}
				break;

			case 2:
				_localctx = new Addvar_nodeContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 252; Match(20);
				State = 253; var_ref();
				}
				break;

			case 3:
				_localctx = new Varsub_nodeContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 254; var_ref();
				State = 255; Match(12);
				}
				break;

			case 4:
				_localctx = new Subvar_nodeContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 257; Match(12);
				State = 258; var_ref();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Var_refContext : ParserRuleContext {
		public Var_refContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_var_ref; }
	 
		public Var_refContext() { }
		public virtual void CopyFrom(Var_refContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class Addrref_nodeContext : Var_refContext {
		public Number_exprContext number_expr() {
			return GetRuleContext<Number_exprContext>(0);
		}
		public Addrref_nodeContext(Var_refContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterAddrref_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitAddrref_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAddrref_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Id_nodeContext : Var_refContext {
		public ITerminalNode ID() { return GetToken(mylParser.ID, 0); }
		public Id_nodeContext(Var_refContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterId_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitId_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitId_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Idref_nodeContext : Var_refContext {
		public ITerminalNode ID() { return GetToken(mylParser.ID, 0); }
		public Number_exprContext number_expr() {
			return GetRuleContext<Number_exprContext>(0);
		}
		public Idref_nodeContext(Var_refContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterIdref_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitIdref_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIdref_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Var_ref_nodeContext : Var_refContext {
		public Var_refContext var_ref() {
			return GetRuleContext<Var_refContext>(0);
		}
		public Var_ref_nodeContext(Var_refContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterVar_ref_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitVar_ref_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVar_ref_node(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Var_refContext var_ref() {
		Var_refContext _localctx = new Var_refContext(_ctx, State);
		EnterRule(_localctx, 36, RULE_var_ref);
		try {
			State = 276;
			switch ( Interpreter.AdaptivePredict(_input,14,_ctx) ) {
			case 1:
				_localctx = new Addrref_nodeContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 261; Match(MUL);
				State = 262; Match(9);
				State = 263; number_expr(0);
				State = 264; Match(4);
				}
				break;

			case 2:
				_localctx = new Idref_nodeContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 266; Match(ID);
				State = 267; Match(7);
				State = 268; number_expr(0);
				State = 269; Match(2);
				}
				break;

			case 3:
				_localctx = new Id_nodeContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 271; Match(ID);
				}
				break;

			case 4:
				_localctx = new Var_ref_nodeContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 272; Match(9);
				State = 273; var_ref();
				State = 274; Match(4);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Func_callContext : ParserRuleContext {
		public Func_callContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_func_call; }
	 
		public Func_callContext() { }
		public virtual void CopyFrom(Func_callContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class String_nodeContext : Func_callContext {
		public ITerminalNode ID() { return GetToken(mylParser.ID, 0); }
		public ITerminalNode STRING() { return GetToken(mylParser.STRING, 0); }
		public String_nodeContext(Func_callContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterString_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitString_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitString_node(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Params_nodeContext : Func_callContext {
		public Params_useContext params_use() {
			return GetRuleContext<Params_useContext>(0);
		}
		public ITerminalNode ID() { return GetToken(mylParser.ID, 0); }
		public Params_nodeContext(Func_callContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterParams_node(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitParams_node(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParams_node(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Func_callContext func_call() {
		Func_callContext _localctx = new Func_callContext(_ctx, State);
		EnterRule(_localctx, 38, RULE_func_call);
		try {
			State = 287;
			switch ( Interpreter.AdaptivePredict(_input,15,_ctx) ) {
			case 1:
				_localctx = new Params_nodeContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 278; Match(ID);
				State = 279; Match(9);
				State = 280; params_use();
				State = 281; Match(4);
				}
				break;

			case 2:
				_localctx = new String_nodeContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 283; Match(ID);
				State = 284; Match(9);
				State = 285; Match(STRING);
				State = 286; Match(4);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Params_useContext : ParserRuleContext {
		public Number_exprContext number_expr(int i) {
			return GetRuleContext<Number_exprContext>(i);
		}
		public Number_exprContext[] number_expr() {
			return GetRuleContexts<Number_exprContext>();
		}
		public Params_useContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int GetRuleIndex() { return RULE_params_use; }
		public override void EnterRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.EnterParams_use(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ImylListener typedListener = listener as ImylListener;
			if (typedListener != null) typedListener.ExitParams_use(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ImylVisitor<TResult> typedVisitor = visitor as ImylVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParams_use(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Params_useContext params_use() {
		Params_useContext _localctx = new Params_useContext(_ctx, State);
		EnterRule(_localctx, 40, RULE_params_use);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 297;
			_la = _input.La(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << 3) | (1L << 9) | (1L << 12) | (1L << 20) | (1L << ID) | (1L << INT) | (1L << CHAR) | (1L << CONST) | (1L << MUL) | (1L << NOT))) != 0)) {
				{
				State = 289; number_expr(0);
				State = 294;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==5) {
					{
					{
					State = 290; Match(5);
					State = 291; number_expr(0);
					}
					}
					State = 296;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 15: return number_expr_sempred((Number_exprContext)_localctx, predIndex);
		}
		return true;
	}
	private bool number_expr_sempred(Number_exprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(_ctx, 16);

		case 1: return Precpred(_ctx, 15);

		case 2: return Precpred(_ctx, 14);

		case 3: return Precpred(_ctx, 13);

		case 4: return Precpred(_ctx, 12);

		case 5: return Precpred(_ctx, 11);

		case 6: return Precpred(_ctx, 10);

		case 7: return Precpred(_ctx, 9);
		}
		return true;
	}

	public static readonly string _serializedATN =
		"\x5\x3\x35\x12E\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6"+
		"\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE"+
		"\t\xE\x4\xF\t\xF\x4\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4"+
		"\x14\t\x14\x4\x15\t\x15\x4\x16\t\x16\x3\x2\a\x2.\n\x2\f\x2\xE\x2\x31\v"+
		"\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x5\x3S\n\x3"+
		"\x3\x3\x3\x3\a\x3W\n\x3\f\x3\xE\x3Z\v\x3\x3\x3\x5\x3]\n\x3\x3\x4\x3\x4"+
		"\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a"+
		"\x3\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t"+
		"\x3\t\x3\t\x3\n\x3\n\x3\n\x5\n\x80\n\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3"+
		"\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x5\v\x90\n\v\x3\f\x3\f\x3\f\x3\f"+
		"\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x5\f\xA2"+
		"\n\f\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r\x3\r"+
		"\x3\r\x3\r\x3\r\x3\r\x3\r\x5\r\xB6\n\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\a"+
		"\xE\xBD\n\xE\f\xE\xE\xE\xC0\v\xE\x5\xE\xC2\n\xE\x3\xF\x3\xF\x3\xF\x3\x10"+
		"\x3\x10\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11"+
		"\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x5\x11"+
		"\xDB\n\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3"+
		"\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3"+
		"\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\a\x11\xF5\n\x11\f\x11\xE\x11\xF8"+
		"\v\x11\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13"+
		"\x3\x13\x3\x13\x3\x13\x5\x13\x106\n\x13\x3\x14\x3\x14\x3\x14\x3\x14\x3"+
		"\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3"+
		"\x14\x5\x14\x117\n\x14\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15"+
		"\x3\x15\x3\x15\x5\x15\x122\n\x15\x3\x16\x3\x16\x3\x16\a\x16\x127\n\x16"+
		"\f\x16\xE\x16\x12A\v\x16\x5\x16\x12C\n\x16\x3\x16\x2\x2\x3 \x17\x2\x2"+
		"\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10\x2\x12\x2\x14\x2\x16\x2\x18\x2\x1A"+
		"\x2\x1C\x2\x1E\x2 \x2\"\x2$\x2&\x2(\x2*\x2\x2\x6\x3-.\x4%%((\x3+,\x6#"+
		"$&\'))\x32\x32\x148\x2/\x3\x2\x2\x2\x4\\\x3\x2\x2\x2\x6^\x3\x2\x2\x2\b"+
		"`\x3\x2\x2\x2\n\x62\x3\x2\x2\x2\fi\x3\x2\x2\x2\xEm\x3\x2\x2\x2\x10s\x3"+
		"\x2\x2\x2\x12\x7F\x3\x2\x2\x2\x14\x8F\x3\x2\x2\x2\x16\xA1\x3\x2\x2\x2"+
		"\x18\xB5\x3\x2\x2\x2\x1A\xC1\x3\x2\x2\x2\x1C\xC3\x3\x2\x2\x2\x1E\xC6\x3"+
		"\x2\x2\x2 \xDA\x3\x2\x2\x2\"\xF9\x3\x2\x2\x2$\x105\x3\x2\x2\x2&\x116\x3"+
		"\x2\x2\x2(\x121\x3\x2\x2\x2*\x12B\x3\x2\x2\x2,.\x5\x4\x3\x2-,\x3\x2\x2"+
		"\x2.\x31\x3\x2\x2\x2/-\x3\x2\x2\x2/\x30\x3\x2\x2\x2\x30\x3\x3\x2\x2\x2"+
		"\x31/\x3\x2\x2\x2\x32S\a\x34\x2\x2\x33\x34\x5\f\a\x2\x34\x35\a\x34\x2"+
		"\x2\x35S\x3\x2\x2\x2\x36S\x5\x14\v\x2\x37S\x5\xE\b\x2\x38S\x5\x10\t\x2"+
		"\x39:\x5\"\x12\x2:;\a\x34\x2\x2;S\x3\x2\x2\x2<=\x5\n\x6\x2=>\a\x34\x2"+
		"\x2>S\x3\x2\x2\x2?@\x5\x6\x4\x2@\x41\a\x34\x2\x2\x41S\x3\x2\x2\x2\x42"+
		"\x43\x5\b\x5\x2\x43\x44\a\x34\x2\x2\x44S\x3\x2\x2\x2\x45\x46\x5\x1E\x10"+
		"\x2\x46G\a\x34\x2\x2GS\x3\x2\x2\x2HI\x5(\x15\x2IJ\a\x34\x2\x2JS\x3\x2"+
		"\x2\x2KL\x5\x16\f\x2LM\a\x34\x2\x2MS\x3\x2\x2\x2NS\x5\x18\r\x2OP\x5\x1C"+
		"\xF\x2PQ\a\x34\x2\x2QS\x3\x2\x2\x2R\x32\x3\x2\x2\x2R\x33\x3\x2\x2\x2R"+
		"\x36\x3\x2\x2\x2R\x37\x3\x2\x2\x2R\x38\x3\x2\x2\x2R\x39\x3\x2\x2\x2R<"+
		"\x3\x2\x2\x2R?\x3\x2\x2\x2R\x42\x3\x2\x2\x2R\x45\x3\x2\x2\x2RH\x3\x2\x2"+
		"\x2RK\x3\x2\x2\x2RN\x3\x2\x2\x2RO\x3\x2\x2\x2S]\x3\x2\x2\x2TX\a\x12\x2"+
		"\x2UW\x5\x4\x3\x2VU\x3\x2\x2\x2WZ\x3\x2\x2\x2XV\x3\x2\x2\x2XY\x3\x2\x2"+
		"\x2Y[\x3\x2\x2\x2ZX\x3\x2\x2\x2[]\a\x15\x2\x2\\R\x3\x2\x2\x2\\T\x3\x2"+
		"\x2\x2]\x5\x3\x2\x2\x2^_\a\x13\x2\x2_\a\x3\x2\x2\x2`\x61\a\xF\x2\x2\x61"+
		"\t\x3\x2\x2\x2\x62\x63\a\x3\x2\x2\x63\x64\a\v\x2\x2\x64\x65\x5 \x11\x2"+
		"\x65\x66\a\a\x2\x2\x66g\a\x18\x2\x2gh\a\x6\x2\x2h\v\x3\x2\x2\x2ij\x5&"+
		"\x14\x2jk\a\"\x2\x2kl\x5 \x11\x2l\r\x3\x2\x2\x2mn\a\b\x2\x2no\a\v\x2\x2"+
		"op\x5 \x11\x2pq\a\x6\x2\x2qr\x5\x4\x3\x2r\xF\x3\x2\x2\x2st\a\n\x2\x2t"+
		"u\a\v\x2\x2uv\x5\x4\x3\x2vw\x5 \x11\x2wx\a\x34\x2\x2xy\x5\x12\n\x2yz\a"+
		"\x6\x2\x2z{\x5\x4\x3\x2{\x11\x3\x2\x2\x2|\x80\x5\f\a\x2}\x80\x5\"\x12"+
		"\x2~\x80\x5\x4\x3\x2\x7F|\x3\x2\x2\x2\x7F}\x3\x2\x2\x2\x7F~\x3\x2\x2\x2"+
		"\x80\x13\x3\x2\x2\x2\x81\x82\a\r\x2\x2\x82\x83\a\v\x2\x2\x83\x84\x5 \x11"+
		"\x2\x84\x85\a\x6\x2\x2\x85\x86\x5\x4\x3\x2\x86\x90\x3\x2\x2\x2\x87\x88"+
		"\a\r\x2\x2\x88\x89\a\v\x2\x2\x89\x8A\x5 \x11\x2\x8A\x8B\a\x6\x2\x2\x8B"+
		"\x8C\x5\x4\x3\x2\x8C\x8D\a\x14\x2\x2\x8D\x8E\x5\x4\x3\x2\x8E\x90\x3\x2"+
		"\x2\x2\x8F\x81\x3\x2\x2\x2\x8F\x87\x3\x2\x2\x2\x90\x15\x3\x2\x2\x2\x91"+
		"\x92\a\x17\x2\x2\x92\x93\a\x18\x2\x2\x93\x94\a\v\x2\x2\x94\x95\x5\x1A"+
		"\xE\x2\x95\x96\a\x6\x2\x2\x96\xA2\x3\x2\x2\x2\x97\x98\a\x17\x2\x2\x98"+
		"\x99\a\x18\x2\x2\x99\x9A\a\v\x2\x2\x9A\x9B\x5\x1A\xE\x2\x9B\x9C\a\x6\x2"+
		"\x2\x9C\x9D\a\f\x2\x2\x9D\x9E\a\v\x2\x2\x9E\x9F\x5\x1A\xE\x2\x9F\xA0\a"+
		"\x6\x2\x2\xA0\xA2\x3\x2\x2\x2\xA1\x91\x3\x2\x2\x2\xA1\x97\x3\x2\x2\x2"+
		"\xA2\x17\x3\x2\x2\x2\xA3\xA4\a\x17\x2\x2\xA4\xA5\a\x18\x2\x2\xA5\xA6\a"+
		"\v\x2\x2\xA6\xA7\x5\x1A\xE\x2\xA7\xA8\a\x6\x2\x2\xA8\xA9\x5\x4\x3\x2\xA9"+
		"\xB6\x3\x2\x2\x2\xAA\xAB\a\x17\x2\x2\xAB\xAC\a\x18\x2\x2\xAC\xAD\a\v\x2"+
		"\x2\xAD\xAE\x5\x1A\xE\x2\xAE\xAF\a\x6\x2\x2\xAF\xB0\a\f\x2\x2\xB0\xB1"+
		"\a\v\x2\x2\xB1\xB2\x5\x1A\xE\x2\xB2\xB3\a\x6\x2\x2\xB3\xB4\x5\x4\x3\x2"+
		"\xB4\xB6\x3\x2\x2\x2\xB5\xA3\x3\x2\x2\x2\xB5\xAA\x3\x2\x2\x2\xB6\x19\x3"+
		"\x2\x2\x2\xB7\xB8\a\x17\x2\x2\xB8\xBE\a\x18\x2\x2\xB9\xBA\a\a\x2\x2\xBA"+
		"\xBB\a\x17\x2\x2\xBB\xBD\a\x18\x2\x2\xBC\xB9\x3\x2\x2\x2\xBD\xC0\x3\x2"+
		"\x2\x2\xBE\xBC\x3\x2\x2\x2\xBE\xBF\x3\x2\x2\x2\xBF\xC2\x3\x2\x2\x2\xC0"+
		"\xBE\x3\x2\x2\x2\xC1\xB7\x3\x2\x2\x2\xC1\xC2\x3\x2\x2\x2\xC2\x1B\x3\x2"+
		"\x2\x2\xC3\xC4\a\x10\x2\x2\xC4\xC5\x5 \x11\x2\xC5\x1D\x3\x2\x2\x2\xC6"+
		"\xC7\a\x11\x2\x2\xC7\xC8\a\v\x2\x2\xC8\xC9\a\x1E\x2\x2\xC9\xCA\a\x6\x2"+
		"\x2\xCA\x1F\x3\x2\x2\x2\xCB\xCC\b\x11\x1\x2\xCC\xCD\a\x31\x2\x2\xCD\xDB"+
		"\x5 \x11\x13\xCE\xDB\x5(\x15\x2\xCF\xDB\x5$\x13\x2\xD0\xDB\x5&\x14\x2"+
		"\xD1\xD2\a\x5\x2\x2\xD2\xDB\x5&\x14\x2\xD3\xDB\a\x1D\x2\x2\xD4\xDB\a\x19"+
		"\x2\x2\xD5\xDB\a\x1F\x2\x2\xD6\xD7\a\v\x2\x2\xD7\xD8\x5 \x11\x2\xD8\xD9"+
		"\a\x6\x2\x2\xD9\xDB\x3\x2\x2\x2\xDA\xCB\x3\x2\x2\x2\xDA\xCE\x3\x2\x2\x2"+
		"\xDA\xCF\x3\x2\x2\x2\xDA\xD0\x3\x2\x2\x2\xDA\xD1\x3\x2\x2\x2\xDA\xD3\x3"+
		"\x2\x2\x2\xDA\xD4\x3\x2\x2\x2\xDA\xD5\x3\x2\x2\x2\xDA\xD6\x3\x2\x2\x2"+
		"\xDB\xF6\x3\x2\x2\x2\xDC\xDD\f\x12\x2\x2\xDD\xDE\t\x2\x2\x2\xDE\xF5\x5"+
		" \x11\x13\xDF\xE0\f\x11\x2\x2\xE0\xE1\t\x3\x2\x2\xE1\xF5\x5 \x11\x12\xE2"+
		"\xE3\f\x10\x2\x2\xE3\xE4\t\x4\x2\x2\xE4\xF5\x5 \x11\x11\xE5\xE6\f\xF\x2"+
		"\x2\xE6\xE7\a*\x2\x2\xE7\xF5\x5 \x11\x10\xE8\xE9\f\xE\x2\x2\xE9\xEA\t"+
		"\x5\x2\x2\xEA\xF5\x5 \x11\xF\xEB\xEC\f\r\x2\x2\xEC\xED\a/\x2\x2\xED\xF5"+
		"\x5 \x11\xE\xEE\xEF\f\f\x2\x2\xEF\xF0\a\x33\x2\x2\xF0\xF5\x5 \x11\r\xF1"+
		"\xF2\f\v\x2\x2\xF2\xF3\a\x30\x2\x2\xF3\xF5\x5 \x11\f\xF4\xDC\x3\x2\x2"+
		"\x2\xF4\xDF\x3\x2\x2\x2\xF4\xE2\x3\x2\x2\x2\xF4\xE5\x3\x2\x2\x2\xF4\xE8"+
		"\x3\x2\x2\x2\xF4\xEB\x3\x2\x2\x2\xF4\xEE\x3\x2\x2\x2\xF4\xF1\x3\x2\x2"+
		"\x2\xF5\xF8\x3\x2\x2\x2\xF6\xF4\x3\x2\x2\x2\xF6\xF7\x3\x2\x2\x2\xF7!\x3"+
		"\x2\x2\x2\xF8\xF6\x3\x2\x2\x2\xF9\xFA\x5$\x13\x2\xFA#\x3\x2\x2\x2\xFB"+
		"\xFC\x5&\x14\x2\xFC\xFD\a\x16\x2\x2\xFD\x106\x3\x2\x2\x2\xFE\xFF\a\x16"+
		"\x2\x2\xFF\x106\x5&\x14\x2\x100\x101\x5&\x14\x2\x101\x102\a\xE\x2\x2\x102"+
		"\x106\x3\x2\x2\x2\x103\x104\a\xE\x2\x2\x104\x106\x5&\x14\x2\x105\xFB\x3"+
		"\x2\x2\x2\x105\xFE\x3\x2\x2\x2\x105\x100\x3\x2\x2\x2\x105\x103\x3\x2\x2"+
		"\x2\x106%\x3\x2\x2\x2\x107\x108\a-\x2\x2\x108\x109\a\v\x2\x2\x109\x10A"+
		"\x5 \x11\x2\x10A\x10B\a\x6\x2\x2\x10B\x117\x3\x2\x2\x2\x10C\x10D\a\x18"+
		"\x2\x2\x10D\x10E\a\t\x2\x2\x10E\x10F\x5 \x11\x2\x10F\x110\a\x4\x2\x2\x110"+
		"\x117\x3\x2\x2\x2\x111\x117\a\x18\x2\x2\x112\x113\a\v\x2\x2\x113\x114"+
		"\x5&\x14\x2\x114\x115\a\x6\x2\x2\x115\x117\x3\x2\x2\x2\x116\x107\x3\x2"+
		"\x2\x2\x116\x10C\x3\x2\x2\x2\x116\x111\x3\x2\x2\x2\x116\x112\x3\x2\x2"+
		"\x2\x117\'\x3\x2\x2\x2\x118\x119\a\x18\x2\x2\x119\x11A\a\v\x2\x2\x11A"+
		"\x11B\x5*\x16\x2\x11B\x11C\a\x6\x2\x2\x11C\x122\x3\x2\x2\x2\x11D\x11E"+
		"\a\x18\x2\x2\x11E\x11F\a\v\x2\x2\x11F\x120\a\x1E\x2\x2\x120\x122\a\x6"+
		"\x2\x2\x121\x118\x3\x2\x2\x2\x121\x11D\x3\x2\x2\x2\x122)\x3\x2\x2\x2\x123"+
		"\x128\x5 \x11\x2\x124\x125\a\a\x2\x2\x125\x127\x5 \x11\x2\x126\x124\x3"+
		"\x2\x2\x2\x127\x12A\x3\x2\x2\x2\x128\x126\x3\x2\x2\x2\x128\x129\x3\x2"+
		"\x2\x2\x129\x12C\x3\x2\x2\x2\x12A\x128\x3\x2\x2\x2\x12B\x123\x3\x2\x2"+
		"\x2\x12B\x12C\x3\x2\x2\x2\x12C+\x3\x2\x2\x2\x14/RX\\\x7F\x8F\xA1\xB5\xBE"+
		"\xC1\xDA\xF4\xF6\x105\x116\x121\x128\x12B";
	public static readonly ATN _ATN =
		ATNSimulator.Deserialize(_serializedATN.ToCharArray());
}
