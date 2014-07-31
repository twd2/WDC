// Generated from myl.g4 by ANTLR 4.1
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class mylParser extends Parser {
	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__19=1, T__18=2, T__17=3, T__16=4, T__15=5, T__14=6, T__13=7, T__12=8, 
		T__11=9, T__10=10, T__9=11, T__8=12, T__7=13, T__6=14, T__5=15, T__4=16, 
		T__3=17, T__2=18, T__1=19, T__0=20, TYPE=21, ID=22, INT=23, COMM_BLOCK=24, 
		LINE_COMM=25, NEWLINE=26, CHAR=27, STRING=28, CONST=29, TRUE=30, FALSE=31, 
		LET=32, EQU=33, GT=34, SHR=35, GTE=36, LT=37, SHL=38, LTE=39, MOD=40, 
		ADD=41, SUB=42, MUL=43, DIV=44, AND=45, OR=46, NOT=47, NEQU=48, XOR=49, 
		SEM=50, WS=51;
	public static final String[] tokenNames = {
		"<INVALID>", "'on_interrupt'", "']'", "'&'", "')'", "','", "'while'", 
		"'['", "'for'", "'('", "'uses'", "'if'", "'--'", "'continue'", "'return'", 
		"'asm'", "'{'", "'break'", "'else'", "'}'", "'++'", "TYPE", "ID", "INT", 
		"COMM_BLOCK", "LINE_COMM", "NEWLINE", "CHAR", "STRING", "CONST", "'true'", 
		"'false'", "'='", "'=='", "'>'", "'>>'", "GTE", "'<'", "'<<'", "LTE", 
		"'%'", "'+'", "'-'", "'*'", "'/'", "AND", "OR", "NOT", "NEQU", "XOR", 
		"';'", "WS"
	};
	public static final int
		RULE_prog = 0, RULE_stat = 1, RULE_break_stat = 2, RULE_continue_stat = 3, 
		RULE_on_interrupt_stat = 4, RULE_let_stat = 5, RULE_while_stat = 6, RULE_for_stat = 7, 
		RULE_for_step = 8, RULE_if_stat = 9, RULE_func_dec = 10, RULE_func_def = 11, 
		RULE_ids_def = 12, RULE_func_ret = 13, RULE_asm = 14, RULE_number_expr = 15, 
		RULE_self_addsub_stat = 16, RULE_self_addsub = 17, RULE_var_ref = 18, 
		RULE_func_call = 19, RULE_params_use = 20;
	public static final String[] ruleNames = {
		"prog", "stat", "break_stat", "continue_stat", "on_interrupt_stat", "let_stat", 
		"while_stat", "for_stat", "for_step", "if_stat", "func_dec", "func_def", 
		"ids_def", "func_ret", "asm", "number_expr", "self_addsub_stat", "self_addsub", 
		"var_ref", "func_call", "params_use"
	};

	@Override
	public String getGrammarFileName() { return "myl.g4"; }

	@Override
	public String[] getTokenNames() { return tokenNames; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public mylParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}
	public static class ProgContext extends ParserRuleContext {
		public StatContext stat(int i) {
			return getRuleContext(StatContext.class,i);
		}
		public List<StatContext> stat() {
			return getRuleContexts(StatContext.class);
		}
		public ProgContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_prog; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterProg(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitProg(this);
		}
	}

	public final ProgContext prog() throws RecognitionException {
		ProgContext _localctx = new ProgContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_prog);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(45);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << 1) | (1L << 6) | (1L << 8) | (1L << 9) | (1L << 11) | (1L << 12) | (1L << 13) | (1L << 14) | (1L << 15) | (1L << 16) | (1L << 17) | (1L << 20) | (1L << TYPE) | (1L << ID) | (1L << MUL) | (1L << SEM))) != 0)) {
				{
				{
				setState(42); stat();
				}
				}
				setState(47);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class StatContext extends ParserRuleContext {
		public For_statContext for_stat() {
			return getRuleContext(For_statContext.class,0);
		}
		public Self_addsub_statContext self_addsub_stat() {
			return getRuleContext(Self_addsub_statContext.class,0);
		}
		public Func_retContext func_ret() {
			return getRuleContext(Func_retContext.class,0);
		}
		public Func_defContext func_def() {
			return getRuleContext(Func_defContext.class,0);
		}
		public AsmContext asm() {
			return getRuleContext(AsmContext.class,0);
		}
		public Let_statContext let_stat() {
			return getRuleContext(Let_statContext.class,0);
		}
		public If_statContext if_stat() {
			return getRuleContext(If_statContext.class,0);
		}
		public Break_statContext break_stat() {
			return getRuleContext(Break_statContext.class,0);
		}
		public Func_decContext func_dec() {
			return getRuleContext(Func_decContext.class,0);
		}
		public StatContext stat(int i) {
			return getRuleContext(StatContext.class,i);
		}
		public On_interrupt_statContext on_interrupt_stat() {
			return getRuleContext(On_interrupt_statContext.class,0);
		}
		public Func_callContext func_call() {
			return getRuleContext(Func_callContext.class,0);
		}
		public List<StatContext> stat() {
			return getRuleContexts(StatContext.class);
		}
		public TerminalNode SEM() { return getToken(mylParser.SEM, 0); }
		public Continue_statContext continue_stat() {
			return getRuleContext(Continue_statContext.class,0);
		}
		public While_statContext while_stat() {
			return getRuleContext(While_statContext.class,0);
		}
		public StatContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_stat; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterStat(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitStat(this);
		}
	}

	public final StatContext stat() throws RecognitionException {
		StatContext _localctx = new StatContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_stat);
		int _la;
		try {
			setState(90);
			switch (_input.LA(1)) {
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
				enterOuterAlt(_localctx, 1);
				{
				setState(80);
				switch ( getInterpreter().adaptivePredict(_input,1,_ctx) ) {
				case 1:
					{
					setState(48); match(SEM);
					}
					break;

				case 2:
					{
					setState(49); let_stat();
					setState(50); match(SEM);
					}
					break;

				case 3:
					{
					setState(52); if_stat();
					}
					break;

				case 4:
					{
					setState(53); while_stat();
					}
					break;

				case 5:
					{
					setState(54); for_stat();
					}
					break;

				case 6:
					{
					setState(55); self_addsub_stat();
					setState(56); match(SEM);
					}
					break;

				case 7:
					{
					setState(58); on_interrupt_stat();
					setState(59); match(SEM);
					}
					break;

				case 8:
					{
					setState(61); break_stat();
					setState(62); match(SEM);
					}
					break;

				case 9:
					{
					setState(64); continue_stat();
					setState(65); match(SEM);
					}
					break;

				case 10:
					{
					setState(67); asm();
					setState(68); match(SEM);
					}
					break;

				case 11:
					{
					setState(70); func_call();
					setState(71); match(SEM);
					}
					break;

				case 12:
					{
					setState(73); func_dec();
					setState(74); match(SEM);
					}
					break;

				case 13:
					{
					setState(76); func_def();
					}
					break;

				case 14:
					{
					setState(77); func_ret();
					setState(78); match(SEM);
					}
					break;
				}
				}
				break;
			case 16:
				enterOuterAlt(_localctx, 2);
				{
				setState(82); match(16);
				setState(86);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << 1) | (1L << 6) | (1L << 8) | (1L << 9) | (1L << 11) | (1L << 12) | (1L << 13) | (1L << 14) | (1L << 15) | (1L << 16) | (1L << 17) | (1L << 20) | (1L << TYPE) | (1L << ID) | (1L << MUL) | (1L << SEM))) != 0)) {
					{
					{
					setState(83); stat();
					}
					}
					setState(88);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				setState(89); match(19);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Break_statContext extends ParserRuleContext {
		public Break_statContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_break_stat; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterBreak_stat(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitBreak_stat(this);
		}
	}

	public final Break_statContext break_stat() throws RecognitionException {
		Break_statContext _localctx = new Break_statContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_break_stat);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(92); match(17);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Continue_statContext extends ParserRuleContext {
		public Continue_statContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_continue_stat; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterContinue_stat(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitContinue_stat(this);
		}
	}

	public final Continue_statContext continue_stat() throws RecognitionException {
		Continue_statContext _localctx = new Continue_statContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_continue_stat);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(94); match(13);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class On_interrupt_statContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(mylParser.ID, 0); }
		public Number_exprContext number_expr() {
			return getRuleContext(Number_exprContext.class,0);
		}
		public On_interrupt_statContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_on_interrupt_stat; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterOn_interrupt_stat(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitOn_interrupt_stat(this);
		}
	}

	public final On_interrupt_statContext on_interrupt_stat() throws RecognitionException {
		On_interrupt_statContext _localctx = new On_interrupt_statContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_on_interrupt_stat);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(96); match(1);
			setState(97); match(9);
			setState(98); number_expr(0);
			setState(99); match(5);
			setState(100); match(ID);
			setState(101); match(4);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Let_statContext extends ParserRuleContext {
		public TerminalNode LET() { return getToken(mylParser.LET, 0); }
		public Number_exprContext number_expr() {
			return getRuleContext(Number_exprContext.class,0);
		}
		public Var_refContext var_ref() {
			return getRuleContext(Var_refContext.class,0);
		}
		public Let_statContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_let_stat; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterLet_stat(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitLet_stat(this);
		}
	}

	public final Let_statContext let_stat() throws RecognitionException {
		Let_statContext _localctx = new Let_statContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_let_stat);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(103); var_ref();
			setState(104); match(LET);
			setState(105); number_expr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class While_statContext extends ParserRuleContext {
		public Number_exprContext number_expr() {
			return getRuleContext(Number_exprContext.class,0);
		}
		public StatContext stat() {
			return getRuleContext(StatContext.class,0);
		}
		public While_statContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_while_stat; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterWhile_stat(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitWhile_stat(this);
		}
	}

	public final While_statContext while_stat() throws RecognitionException {
		While_statContext _localctx = new While_statContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_while_stat);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(107); match(6);
			setState(108); match(9);
			setState(109); number_expr(0);
			setState(110); match(4);
			setState(111); stat();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class For_statContext extends ParserRuleContext {
		public StatContext sinit;
		public For_stepContext sstep;
		public StatContext smain;
		public StatContext stat(int i) {
			return getRuleContext(StatContext.class,i);
		}
		public Number_exprContext number_expr() {
			return getRuleContext(Number_exprContext.class,0);
		}
		public List<StatContext> stat() {
			return getRuleContexts(StatContext.class);
		}
		public TerminalNode SEM() { return getToken(mylParser.SEM, 0); }
		public For_stepContext for_step() {
			return getRuleContext(For_stepContext.class,0);
		}
		public For_statContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_for_stat; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterFor_stat(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitFor_stat(this);
		}
	}

	public final For_statContext for_stat() throws RecognitionException {
		For_statContext _localctx = new For_statContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_for_stat);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(113); match(8);
			setState(114); match(9);
			setState(115); ((For_statContext)_localctx).sinit = stat();
			setState(116); number_expr(0);
			setState(117); match(SEM);
			setState(118); ((For_statContext)_localctx).sstep = for_step();
			setState(119); match(4);
			setState(120); ((For_statContext)_localctx).smain = stat();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class For_stepContext extends ParserRuleContext {
		public Self_addsub_statContext self_addsub_stat() {
			return getRuleContext(Self_addsub_statContext.class,0);
		}
		public Let_statContext let_stat() {
			return getRuleContext(Let_statContext.class,0);
		}
		public StatContext stat() {
			return getRuleContext(StatContext.class,0);
		}
		public For_stepContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_for_step; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterFor_step(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitFor_step(this);
		}
	}

	public final For_stepContext for_step() throws RecognitionException {
		For_stepContext _localctx = new For_stepContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_for_step);
		try {
			setState(125);
			switch ( getInterpreter().adaptivePredict(_input,4,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(122); let_stat();
				}
				break;

			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(123); self_addsub_stat();
				}
				break;

			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(124); stat();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class If_statContext extends ParserRuleContext {
		public If_statContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_if_stat; }
	 
		public If_statContext() { }
		public void copyFrom(If_statContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class Ifelse_nodeContext extends If_statContext {
		public StatContext truestat;
		public StatContext falsestat;
		public StatContext stat(int i) {
			return getRuleContext(StatContext.class,i);
		}
		public Number_exprContext number_expr() {
			return getRuleContext(Number_exprContext.class,0);
		}
		public List<StatContext> stat() {
			return getRuleContexts(StatContext.class);
		}
		public Ifelse_nodeContext(If_statContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterIfelse_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitIfelse_node(this);
		}
	}
	public static class If_nodeContext extends If_statContext {
		public Number_exprContext number_expr() {
			return getRuleContext(Number_exprContext.class,0);
		}
		public StatContext stat() {
			return getRuleContext(StatContext.class,0);
		}
		public If_nodeContext(If_statContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterIf_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitIf_node(this);
		}
	}

	public final If_statContext if_stat() throws RecognitionException {
		If_statContext _localctx = new If_statContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_if_stat);
		try {
			setState(141);
			switch ( getInterpreter().adaptivePredict(_input,5,_ctx) ) {
			case 1:
				_localctx = new If_nodeContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(127); match(11);
				setState(128); match(9);
				setState(129); number_expr(0);
				setState(130); match(4);
				setState(131); stat();
				}
				break;

			case 2:
				_localctx = new Ifelse_nodeContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(133); match(11);
				setState(134); match(9);
				setState(135); number_expr(0);
				setState(136); match(4);
				setState(137); ((Ifelse_nodeContext)_localctx).truestat = stat();
				setState(138); match(18);
				setState(139); ((Ifelse_nodeContext)_localctx).falsestat = stat();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Func_decContext extends ParserRuleContext {
		public Func_decContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_func_dec; }
	 
		public Func_decContext() { }
		public void copyFrom(Func_decContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class Func_dec_no_varContext extends Func_decContext {
		public Ids_defContext params_def;
		public TerminalNode ID() { return getToken(mylParser.ID, 0); }
		public TerminalNode TYPE() { return getToken(mylParser.TYPE, 0); }
		public Ids_defContext ids_def() {
			return getRuleContext(Ids_defContext.class,0);
		}
		public Func_dec_no_varContext(Func_decContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterFunc_dec_no_var(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitFunc_dec_no_var(this);
		}
	}
	public static class Func_dec_varContext extends Func_decContext {
		public Ids_defContext params_def;
		public Ids_defContext vars_def;
		public Ids_defContext ids_def(int i) {
			return getRuleContext(Ids_defContext.class,i);
		}
		public TerminalNode ID() { return getToken(mylParser.ID, 0); }
		public TerminalNode TYPE() { return getToken(mylParser.TYPE, 0); }
		public List<Ids_defContext> ids_def() {
			return getRuleContexts(Ids_defContext.class);
		}
		public Func_dec_varContext(Func_decContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterFunc_dec_var(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitFunc_dec_var(this);
		}
	}

	public final Func_decContext func_dec() throws RecognitionException {
		Func_decContext _localctx = new Func_decContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_func_dec);
		try {
			setState(159);
			switch ( getInterpreter().adaptivePredict(_input,6,_ctx) ) {
			case 1:
				_localctx = new Func_dec_no_varContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(143); match(TYPE);
				setState(144); match(ID);
				setState(145); match(9);
				setState(146); ((Func_dec_no_varContext)_localctx).params_def = ids_def();
				setState(147); match(4);
				}
				break;

			case 2:
				_localctx = new Func_dec_varContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(149); match(TYPE);
				setState(150); match(ID);
				setState(151); match(9);
				setState(152); ((Func_dec_varContext)_localctx).params_def = ids_def();
				setState(153); match(4);
				setState(154); match(10);
				setState(155); match(9);
				setState(156); ((Func_dec_varContext)_localctx).vars_def = ids_def();
				setState(157); match(4);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Func_defContext extends ParserRuleContext {
		public Func_defContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_func_def; }
	 
		public Func_defContext() { }
		public void copyFrom(Func_defContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class Func_def_no_varContext extends Func_defContext {
		public Ids_defContext params_def;
		public TerminalNode ID() { return getToken(mylParser.ID, 0); }
		public StatContext stat() {
			return getRuleContext(StatContext.class,0);
		}
		public TerminalNode TYPE() { return getToken(mylParser.TYPE, 0); }
		public Ids_defContext ids_def() {
			return getRuleContext(Ids_defContext.class,0);
		}
		public Func_def_no_varContext(Func_defContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterFunc_def_no_var(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitFunc_def_no_var(this);
		}
	}
	public static class Func_def_varContext extends Func_defContext {
		public Ids_defContext params_def;
		public Ids_defContext vars_def;
		public Ids_defContext ids_def(int i) {
			return getRuleContext(Ids_defContext.class,i);
		}
		public TerminalNode ID() { return getToken(mylParser.ID, 0); }
		public StatContext stat() {
			return getRuleContext(StatContext.class,0);
		}
		public TerminalNode TYPE() { return getToken(mylParser.TYPE, 0); }
		public List<Ids_defContext> ids_def() {
			return getRuleContexts(Ids_defContext.class);
		}
		public Func_def_varContext(Func_defContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterFunc_def_var(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitFunc_def_var(this);
		}
	}

	public final Func_defContext func_def() throws RecognitionException {
		Func_defContext _localctx = new Func_defContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_func_def);
		try {
			setState(179);
			switch ( getInterpreter().adaptivePredict(_input,7,_ctx) ) {
			case 1:
				_localctx = new Func_def_no_varContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(161); match(TYPE);
				setState(162); match(ID);
				setState(163); match(9);
				setState(164); ((Func_def_no_varContext)_localctx).params_def = ids_def();
				setState(165); match(4);
				setState(166); stat();
				}
				break;

			case 2:
				_localctx = new Func_def_varContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(168); match(TYPE);
				setState(169); match(ID);
				setState(170); match(9);
				setState(171); ((Func_def_varContext)_localctx).params_def = ids_def();
				setState(172); match(4);
				setState(173); match(10);
				setState(174); match(9);
				setState(175); ((Func_def_varContext)_localctx).vars_def = ids_def();
				setState(176); match(4);
				setState(177); stat();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Ids_defContext extends ParserRuleContext {
		public List<TerminalNode> ID() { return getTokens(mylParser.ID); }
		public TerminalNode TYPE(int i) {
			return getToken(mylParser.TYPE, i);
		}
		public List<TerminalNode> TYPE() { return getTokens(mylParser.TYPE); }
		public TerminalNode ID(int i) {
			return getToken(mylParser.ID, i);
		}
		public Ids_defContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_ids_def; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterIds_def(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitIds_def(this);
		}
	}

	public final Ids_defContext ids_def() throws RecognitionException {
		Ids_defContext _localctx = new Ids_defContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_ids_def);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(191);
			_la = _input.LA(1);
			if (_la==TYPE) {
				{
				setState(181); match(TYPE);
				setState(182); match(ID);
				setState(188);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==5) {
					{
					{
					setState(183); match(5);
					setState(184); match(TYPE);
					setState(185); match(ID);
					}
					}
					setState(190);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Func_retContext extends ParserRuleContext {
		public Number_exprContext number_expr() {
			return getRuleContext(Number_exprContext.class,0);
		}
		public Func_retContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_func_ret; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterFunc_ret(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitFunc_ret(this);
		}
	}

	public final Func_retContext func_ret() throws RecognitionException {
		Func_retContext _localctx = new Func_retContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_func_ret);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(193); match(14);
			setState(194); number_expr(0);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class AsmContext extends ParserRuleContext {
		public TerminalNode STRING() { return getToken(mylParser.STRING, 0); }
		public AsmContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_asm; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterAsm(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitAsm(this);
		}
	}

	public final AsmContext asm() throws RecognitionException {
		AsmContext _localctx = new AsmContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_asm);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(196); match(15);
			setState(197); match(9);
			setState(198); match(STRING);
			setState(199); match(4);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Number_exprContext extends ParserRuleContext {
		public int _p;
		public Number_exprContext(ParserRuleContext parent, int invokingState) { super(parent, invokingState); }
		public Number_exprContext(ParserRuleContext parent, int invokingState, int _p) {
			super(parent, invokingState);
			this._p = _p;
		}
		@Override public int getRuleIndex() { return RULE_number_expr; }
	 
		public Number_exprContext() { }
		public void copyFrom(Number_exprContext ctx) {
			super.copyFrom(ctx);
			this._p = ctx._p;
		}
	}
	public static class Number_expr_nodeContext extends Number_exprContext {
		public Number_exprContext number_expr() {
			return getRuleContext(Number_exprContext.class,0);
		}
		public Number_expr_nodeContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterNumber_expr_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitNumber_expr_node(this);
		}
	}
	public static class Not_nodeContext extends Number_exprContext {
		public Number_exprContext number_expr() {
			return getRuleContext(Number_exprContext.class,0);
		}
		public TerminalNode NOT() { return getToken(mylParser.NOT, 0); }
		public Not_nodeContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterNot_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitNot_node(this);
		}
	}
	public static class Func_nodeContext extends Number_exprContext {
		public Func_callContext func_call() {
			return getRuleContext(Func_callContext.class,0);
		}
		public Func_nodeContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterFunc_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitFunc_node(this);
		}
	}
	public static class Ref_nodeContext extends Number_exprContext {
		public Var_refContext var_ref() {
			return getRuleContext(Var_refContext.class,0);
		}
		public Ref_nodeContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterRef_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitRef_node(this);
		}
	}
	public static class Num_cmp_nodeContext extends Number_exprContext {
		public Token op;
		public TerminalNode GTE() { return getToken(mylParser.GTE, 0); }
		public TerminalNode LT() { return getToken(mylParser.LT, 0); }
		public TerminalNode LTE() { return getToken(mylParser.LTE, 0); }
		public TerminalNode EQU() { return getToken(mylParser.EQU, 0); }
		public List<Number_exprContext> number_expr() {
			return getRuleContexts(Number_exprContext.class);
		}
		public TerminalNode NEQU() { return getToken(mylParser.NEQU, 0); }
		public Number_exprContext number_expr(int i) {
			return getRuleContext(Number_exprContext.class,i);
		}
		public TerminalNode GT() { return getToken(mylParser.GT, 0); }
		public Num_cmp_nodeContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterNum_cmp_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitNum_cmp_node(this);
		}
	}
	public static class Or_nodeContext extends Number_exprContext {
		public TerminalNode OR() { return getToken(mylParser.OR, 0); }
		public List<Number_exprContext> number_expr() {
			return getRuleContexts(Number_exprContext.class);
		}
		public Number_exprContext number_expr(int i) {
			return getRuleContext(Number_exprContext.class,i);
		}
		public Or_nodeContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterOr_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitOr_node(this);
		}
	}
	public static class Xor_nodeContext extends Number_exprContext {
		public TerminalNode XOR() { return getToken(mylParser.XOR, 0); }
		public List<Number_exprContext> number_expr() {
			return getRuleContexts(Number_exprContext.class);
		}
		public Number_exprContext number_expr(int i) {
			return getRuleContext(Number_exprContext.class,i);
		}
		public Xor_nodeContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterXor_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitXor_node(this);
		}
	}
	public static class ShlshrContext extends Number_exprContext {
		public Token op;
		public TerminalNode SHL() { return getToken(mylParser.SHL, 0); }
		public List<Number_exprContext> number_expr() {
			return getRuleContexts(Number_exprContext.class);
		}
		public TerminalNode SHR() { return getToken(mylParser.SHR, 0); }
		public Number_exprContext number_expr(int i) {
			return getRuleContext(Number_exprContext.class,i);
		}
		public ShlshrContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterShlshr(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitShlshr(this);
		}
	}
	public static class Char_nodeContext extends Number_exprContext {
		public TerminalNode CHAR() { return getToken(mylParser.CHAR, 0); }
		public Char_nodeContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterChar_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitChar_node(this);
		}
	}
	public static class AddsubContext extends Number_exprContext {
		public Token op;
		public List<Number_exprContext> number_expr() {
			return getRuleContexts(Number_exprContext.class);
		}
		public Number_exprContext number_expr(int i) {
			return getRuleContext(Number_exprContext.class,i);
		}
		public TerminalNode SUB() { return getToken(mylParser.SUB, 0); }
		public TerminalNode ADD() { return getToken(mylParser.ADD, 0); }
		public AddsubContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterAddsub(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitAddsub(this);
		}
	}
	public static class Mod_nodeContext extends Number_exprContext {
		public List<Number_exprContext> number_expr() {
			return getRuleContexts(Number_exprContext.class);
		}
		public Number_exprContext number_expr(int i) {
			return getRuleContext(Number_exprContext.class,i);
		}
		public TerminalNode MOD() { return getToken(mylParser.MOD, 0); }
		public Mod_nodeContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterMod_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitMod_node(this);
		}
	}
	public static class Const_nodeContext extends Number_exprContext {
		public TerminalNode CONST() { return getToken(mylParser.CONST, 0); }
		public Const_nodeContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterConst_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitConst_node(this);
		}
	}
	public static class Ref_addr_nodeContext extends Number_exprContext {
		public Var_refContext var_ref() {
			return getRuleContext(Var_refContext.class,0);
		}
		public Ref_addr_nodeContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterRef_addr_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitRef_addr_node(this);
		}
	}
	public static class MuldivContext extends Number_exprContext {
		public Token op;
		public TerminalNode MUL() { return getToken(mylParser.MUL, 0); }
		public TerminalNode DIV() { return getToken(mylParser.DIV, 0); }
		public List<Number_exprContext> number_expr() {
			return getRuleContexts(Number_exprContext.class);
		}
		public Number_exprContext number_expr(int i) {
			return getRuleContext(Number_exprContext.class,i);
		}
		public MuldivContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterMuldiv(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitMuldiv(this);
		}
	}
	public static class Int_nodeContext extends Number_exprContext {
		public TerminalNode INT() { return getToken(mylParser.INT, 0); }
		public Int_nodeContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterInt_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitInt_node(this);
		}
	}
	public static class Self_addsub_nodeContext extends Number_exprContext {
		public Self_addsubContext self_addsub() {
			return getRuleContext(Self_addsubContext.class,0);
		}
		public Self_addsub_nodeContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterSelf_addsub_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitSelf_addsub_node(this);
		}
	}
	public static class And_nodeContext extends Number_exprContext {
		public TerminalNode AND() { return getToken(mylParser.AND, 0); }
		public List<Number_exprContext> number_expr() {
			return getRuleContexts(Number_exprContext.class);
		}
		public Number_exprContext number_expr(int i) {
			return getRuleContext(Number_exprContext.class,i);
		}
		public And_nodeContext(Number_exprContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterAnd_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitAnd_node(this);
		}
	}

	public final Number_exprContext number_expr(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		Number_exprContext _localctx = new Number_exprContext(_ctx, _parentState, _p);
		Number_exprContext _prevctx = _localctx;
		int _startState = 30;
		enterRecursionRule(_localctx, RULE_number_expr);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(216);
			switch ( getInterpreter().adaptivePredict(_input,10,_ctx) ) {
			case 1:
				{
				_localctx = new Not_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;

				setState(202); match(NOT);
				setState(203); number_expr(17);
				}
				break;

			case 2:
				{
				_localctx = new Func_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(204); func_call();
				}
				break;

			case 3:
				{
				_localctx = new Self_addsub_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(205); self_addsub();
				}
				break;

			case 4:
				{
				_localctx = new Ref_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(206); var_ref();
				}
				break;

			case 5:
				{
				_localctx = new Ref_addr_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(207); match(3);
				setState(208); var_ref();
				}
				break;

			case 6:
				{
				_localctx = new Char_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(209); match(CHAR);
				}
				break;

			case 7:
				{
				_localctx = new Int_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(210); match(INT);
				}
				break;

			case 8:
				{
				_localctx = new Const_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(211); match(CONST);
				}
				break;

			case 9:
				{
				_localctx = new Number_expr_nodeContext(_localctx);
				_ctx = _localctx;
				_prevctx = _localctx;
				setState(212); match(9);
				setState(213); number_expr(0);
				setState(214); match(4);
				}
				break;
			}
			_ctx.stop = _input.LT(-1);
			setState(244);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,12,_ctx);
			while ( _alt!=2 && _alt!=-1 ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(242);
					switch ( getInterpreter().adaptivePredict(_input,11,_ctx) ) {
					case 1:
						{
						_localctx = new MuldivContext(new Number_exprContext(_parentctx, _parentState, _p));
						pushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						setState(218);
						if (!(16 >= _localctx._p)) throw new FailedPredicateException(this, "16 >= $_p");
						setState(219);
						((MuldivContext)_localctx).op = _input.LT(1);
						_la = _input.LA(1);
						if ( !(_la==MUL || _la==DIV) ) {
							((MuldivContext)_localctx).op = (Token)_errHandler.recoverInline(this);
						}
						consume();
						setState(220); number_expr(17);
						}
						break;

					case 2:
						{
						_localctx = new ShlshrContext(new Number_exprContext(_parentctx, _parentState, _p));
						pushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						setState(221);
						if (!(15 >= _localctx._p)) throw new FailedPredicateException(this, "15 >= $_p");
						setState(222);
						((ShlshrContext)_localctx).op = _input.LT(1);
						_la = _input.LA(1);
						if ( !(_la==SHR || _la==SHL) ) {
							((ShlshrContext)_localctx).op = (Token)_errHandler.recoverInline(this);
						}
						consume();
						setState(223); number_expr(16);
						}
						break;

					case 3:
						{
						_localctx = new AddsubContext(new Number_exprContext(_parentctx, _parentState, _p));
						pushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						setState(224);
						if (!(14 >= _localctx._p)) throw new FailedPredicateException(this, "14 >= $_p");
						setState(225);
						((AddsubContext)_localctx).op = _input.LT(1);
						_la = _input.LA(1);
						if ( !(_la==ADD || _la==SUB) ) {
							((AddsubContext)_localctx).op = (Token)_errHandler.recoverInline(this);
						}
						consume();
						setState(226); number_expr(15);
						}
						break;

					case 4:
						{
						_localctx = new Mod_nodeContext(new Number_exprContext(_parentctx, _parentState, _p));
						pushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						setState(227);
						if (!(13 >= _localctx._p)) throw new FailedPredicateException(this, "13 >= $_p");
						setState(228); match(MOD);
						setState(229); number_expr(14);
						}
						break;

					case 5:
						{
						_localctx = new Num_cmp_nodeContext(new Number_exprContext(_parentctx, _parentState, _p));
						pushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						setState(230);
						if (!(12 >= _localctx._p)) throw new FailedPredicateException(this, "12 >= $_p");
						setState(231);
						((Num_cmp_nodeContext)_localctx).op = _input.LT(1);
						_la = _input.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << EQU) | (1L << GT) | (1L << GTE) | (1L << LT) | (1L << LTE) | (1L << NEQU))) != 0)) ) {
							((Num_cmp_nodeContext)_localctx).op = (Token)_errHandler.recoverInline(this);
						}
						consume();
						setState(232); number_expr(13);
						}
						break;

					case 6:
						{
						_localctx = new And_nodeContext(new Number_exprContext(_parentctx, _parentState, _p));
						pushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						setState(233);
						if (!(11 >= _localctx._p)) throw new FailedPredicateException(this, "11 >= $_p");
						setState(234); match(AND);
						setState(235); number_expr(12);
						}
						break;

					case 7:
						{
						_localctx = new Xor_nodeContext(new Number_exprContext(_parentctx, _parentState, _p));
						pushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						setState(236);
						if (!(10 >= _localctx._p)) throw new FailedPredicateException(this, "10 >= $_p");
						setState(237); match(XOR);
						setState(238); number_expr(11);
						}
						break;

					case 8:
						{
						_localctx = new Or_nodeContext(new Number_exprContext(_parentctx, _parentState, _p));
						pushNewRecursionContext(_localctx, _startState, RULE_number_expr);
						setState(239);
						if (!(9 >= _localctx._p)) throw new FailedPredicateException(this, "9 >= $_p");
						setState(240); match(OR);
						setState(241); number_expr(10);
						}
						break;
					}
					} 
				}
				setState(246);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,12,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public static class Self_addsub_statContext extends ParserRuleContext {
		public Self_addsubContext self_addsub() {
			return getRuleContext(Self_addsubContext.class,0);
		}
		public Self_addsub_statContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_self_addsub_stat; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterSelf_addsub_stat(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitSelf_addsub_stat(this);
		}
	}

	public final Self_addsub_statContext self_addsub_stat() throws RecognitionException {
		Self_addsub_statContext _localctx = new Self_addsub_statContext(_ctx, getState());
		enterRule(_localctx, 32, RULE_self_addsub_stat);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(247); self_addsub();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Self_addsubContext extends ParserRuleContext {
		public Self_addsubContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_self_addsub; }
	 
		public Self_addsubContext() { }
		public void copyFrom(Self_addsubContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class Addvar_nodeContext extends Self_addsubContext {
		public Var_refContext var_ref() {
			return getRuleContext(Var_refContext.class,0);
		}
		public Addvar_nodeContext(Self_addsubContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterAddvar_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitAddvar_node(this);
		}
	}
	public static class Subvar_nodeContext extends Self_addsubContext {
		public Var_refContext var_ref() {
			return getRuleContext(Var_refContext.class,0);
		}
		public Subvar_nodeContext(Self_addsubContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterSubvar_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitSubvar_node(this);
		}
	}
	public static class Varadd_nodeContext extends Self_addsubContext {
		public Var_refContext var_ref() {
			return getRuleContext(Var_refContext.class,0);
		}
		public Varadd_nodeContext(Self_addsubContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterVaradd_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitVaradd_node(this);
		}
	}
	public static class Varsub_nodeContext extends Self_addsubContext {
		public Var_refContext var_ref() {
			return getRuleContext(Var_refContext.class,0);
		}
		public Varsub_nodeContext(Self_addsubContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterVarsub_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitVarsub_node(this);
		}
	}

	public final Self_addsubContext self_addsub() throws RecognitionException {
		Self_addsubContext _localctx = new Self_addsubContext(_ctx, getState());
		enterRule(_localctx, 34, RULE_self_addsub);
		try {
			setState(259);
			switch ( getInterpreter().adaptivePredict(_input,13,_ctx) ) {
			case 1:
				_localctx = new Varadd_nodeContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(249); var_ref();
				setState(250); match(20);
				}
				break;

			case 2:
				_localctx = new Addvar_nodeContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(252); match(20);
				setState(253); var_ref();
				}
				break;

			case 3:
				_localctx = new Varsub_nodeContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(254); var_ref();
				setState(255); match(12);
				}
				break;

			case 4:
				_localctx = new Subvar_nodeContext(_localctx);
				enterOuterAlt(_localctx, 4);
				{
				setState(257); match(12);
				setState(258); var_ref();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Var_refContext extends ParserRuleContext {
		public Var_refContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_var_ref; }
	 
		public Var_refContext() { }
		public void copyFrom(Var_refContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class Addrref_nodeContext extends Var_refContext {
		public Number_exprContext number_expr() {
			return getRuleContext(Number_exprContext.class,0);
		}
		public Addrref_nodeContext(Var_refContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterAddrref_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitAddrref_node(this);
		}
	}
	public static class Id_nodeContext extends Var_refContext {
		public TerminalNode ID() { return getToken(mylParser.ID, 0); }
		public Id_nodeContext(Var_refContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterId_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitId_node(this);
		}
	}
	public static class Idref_nodeContext extends Var_refContext {
		public TerminalNode ID() { return getToken(mylParser.ID, 0); }
		public Number_exprContext number_expr() {
			return getRuleContext(Number_exprContext.class,0);
		}
		public Idref_nodeContext(Var_refContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterIdref_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitIdref_node(this);
		}
	}
	public static class Var_ref_nodeContext extends Var_refContext {
		public Var_refContext var_ref() {
			return getRuleContext(Var_refContext.class,0);
		}
		public Var_ref_nodeContext(Var_refContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterVar_ref_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitVar_ref_node(this);
		}
	}

	public final Var_refContext var_ref() throws RecognitionException {
		Var_refContext _localctx = new Var_refContext(_ctx, getState());
		enterRule(_localctx, 36, RULE_var_ref);
		try {
			setState(276);
			switch ( getInterpreter().adaptivePredict(_input,14,_ctx) ) {
			case 1:
				_localctx = new Addrref_nodeContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(261); match(MUL);
				setState(262); match(9);
				setState(263); number_expr(0);
				setState(264); match(4);
				}
				break;

			case 2:
				_localctx = new Idref_nodeContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(266); match(ID);
				setState(267); match(7);
				setState(268); number_expr(0);
				setState(269); match(2);
				}
				break;

			case 3:
				_localctx = new Id_nodeContext(_localctx);
				enterOuterAlt(_localctx, 3);
				{
				setState(271); match(ID);
				}
				break;

			case 4:
				_localctx = new Var_ref_nodeContext(_localctx);
				enterOuterAlt(_localctx, 4);
				{
				setState(272); match(9);
				setState(273); var_ref();
				setState(274); match(4);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Func_callContext extends ParserRuleContext {
		public Func_callContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_func_call; }
	 
		public Func_callContext() { }
		public void copyFrom(Func_callContext ctx) {
			super.copyFrom(ctx);
		}
	}
	public static class String_nodeContext extends Func_callContext {
		public TerminalNode ID() { return getToken(mylParser.ID, 0); }
		public TerminalNode STRING() { return getToken(mylParser.STRING, 0); }
		public String_nodeContext(Func_callContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterString_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitString_node(this);
		}
	}
	public static class Params_nodeContext extends Func_callContext {
		public TerminalNode ID() { return getToken(mylParser.ID, 0); }
		public Params_useContext params_use() {
			return getRuleContext(Params_useContext.class,0);
		}
		public Params_nodeContext(Func_callContext ctx) { copyFrom(ctx); }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterParams_node(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitParams_node(this);
		}
	}

	public final Func_callContext func_call() throws RecognitionException {
		Func_callContext _localctx = new Func_callContext(_ctx, getState());
		enterRule(_localctx, 38, RULE_func_call);
		try {
			setState(287);
			switch ( getInterpreter().adaptivePredict(_input,15,_ctx) ) {
			case 1:
				_localctx = new Params_nodeContext(_localctx);
				enterOuterAlt(_localctx, 1);
				{
				setState(278); match(ID);
				setState(279); match(9);
				setState(280); params_use();
				setState(281); match(4);
				}
				break;

			case 2:
				_localctx = new String_nodeContext(_localctx);
				enterOuterAlt(_localctx, 2);
				{
				setState(283); match(ID);
				setState(284); match(9);
				setState(285); match(STRING);
				setState(286); match(4);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Params_useContext extends ParserRuleContext {
		public List<Number_exprContext> number_expr() {
			return getRuleContexts(Number_exprContext.class);
		}
		public Number_exprContext number_expr(int i) {
			return getRuleContext(Number_exprContext.class,i);
		}
		public Params_useContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_params_use; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).enterParams_use(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof mylListener ) ((mylListener)listener).exitParams_use(this);
		}
	}

	public final Params_useContext params_use() throws RecognitionException {
		Params_useContext _localctx = new Params_useContext(_ctx, getState());
		enterRule(_localctx, 40, RULE_params_use);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(297);
			_la = _input.LA(1);
			if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << 3) | (1L << 9) | (1L << 12) | (1L << 20) | (1L << ID) | (1L << INT) | (1L << CHAR) | (1L << CONST) | (1L << MUL) | (1L << NOT))) != 0)) {
				{
				setState(289); number_expr(0);
				setState(294);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==5) {
					{
					{
					setState(290); match(5);
					setState(291); number_expr(0);
					}
					}
					setState(296);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public boolean sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 15: return number_expr_sempred((Number_exprContext)_localctx, predIndex);
		}
		return true;
	}
	private boolean number_expr_sempred(Number_exprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return 16 >= _localctx._p;

		case 1: return 15 >= _localctx._p;

		case 2: return 14 >= _localctx._p;

		case 3: return 13 >= _localctx._p;

		case 4: return 12 >= _localctx._p;

		case 5: return 11 >= _localctx._p;

		case 6: return 10 >= _localctx._p;

		case 7: return 9 >= _localctx._p;
		}
		return true;
	}

	public static final String _serializedATN =
		"\3\uacf5\uee8c\u4f5d\u8b0d\u4a45\u78bd\u1b2f\u3378\3\65\u012e\4\2\t\2"+
		"\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22\t\22"+
		"\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\3\2\7\2.\n\2\f\2\16\2\61\13\2"+
		"\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3"+
		"\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\3\5\3S\n\3\3"+
		"\3\3\3\7\3W\n\3\f\3\16\3Z\13\3\3\3\5\3]\n\3\3\4\3\4\3\5\3\5\3\6\3\6\3"+
		"\6\3\6\3\6\3\6\3\6\3\7\3\7\3\7\3\7\3\b\3\b\3\b\3\b\3\b\3\b\3\t\3\t\3\t"+
		"\3\t\3\t\3\t\3\t\3\t\3\t\3\n\3\n\3\n\5\n\u0080\n\n\3\13\3\13\3\13\3\13"+
		"\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\5\13\u0090\n\13\3\f"+
		"\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\3\f\5\f\u00a2"+
		"\n\f\3\r\3\r\3\r\3\r\3\r\3\r\3\r\3\r\3\r\3\r\3\r\3\r\3\r\3\r\3\r\3\r\3"+
		"\r\3\r\5\r\u00b6\n\r\3\16\3\16\3\16\3\16\3\16\7\16\u00bd\n\16\f\16\16"+
		"\16\u00c0\13\16\5\16\u00c2\n\16\3\17\3\17\3\17\3\20\3\20\3\20\3\20\3\20"+
		"\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21"+
		"\3\21\5\21\u00db\n\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21"+
		"\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21\3\21"+
		"\7\21\u00f5\n\21\f\21\16\21\u00f8\13\21\3\22\3\22\3\23\3\23\3\23\3\23"+
		"\3\23\3\23\3\23\3\23\3\23\3\23\5\23\u0106\n\23\3\24\3\24\3\24\3\24\3\24"+
		"\3\24\3\24\3\24\3\24\3\24\3\24\3\24\3\24\3\24\3\24\5\24\u0117\n\24\3\25"+
		"\3\25\3\25\3\25\3\25\3\25\3\25\3\25\3\25\5\25\u0122\n\25\3\26\3\26\3\26"+
		"\7\26\u0127\n\26\f\26\16\26\u012a\13\26\5\26\u012c\n\26\3\26\2\27\2\4"+
		"\6\b\n\f\16\20\22\24\26\30\32\34\36 \"$&(*\2\6\3\2-.\4\2%%((\3\2+,\6\2"+
		"#$&\'))\62\62\u0148\2/\3\2\2\2\4\\\3\2\2\2\6^\3\2\2\2\b`\3\2\2\2\nb\3"+
		"\2\2\2\fi\3\2\2\2\16m\3\2\2\2\20s\3\2\2\2\22\177\3\2\2\2\24\u008f\3\2"+
		"\2\2\26\u00a1\3\2\2\2\30\u00b5\3\2\2\2\32\u00c1\3\2\2\2\34\u00c3\3\2\2"+
		"\2\36\u00c6\3\2\2\2 \u00da\3\2\2\2\"\u00f9\3\2\2\2$\u0105\3\2\2\2&\u0116"+
		"\3\2\2\2(\u0121\3\2\2\2*\u012b\3\2\2\2,.\5\4\3\2-,\3\2\2\2.\61\3\2\2\2"+
		"/-\3\2\2\2/\60\3\2\2\2\60\3\3\2\2\2\61/\3\2\2\2\62S\7\64\2\2\63\64\5\f"+
		"\7\2\64\65\7\64\2\2\65S\3\2\2\2\66S\5\24\13\2\67S\5\16\b\28S\5\20\t\2"+
		"9:\5\"\22\2:;\7\64\2\2;S\3\2\2\2<=\5\n\6\2=>\7\64\2\2>S\3\2\2\2?@\5\6"+
		"\4\2@A\7\64\2\2AS\3\2\2\2BC\5\b\5\2CD\7\64\2\2DS\3\2\2\2EF\5\36\20\2F"+
		"G\7\64\2\2GS\3\2\2\2HI\5(\25\2IJ\7\64\2\2JS\3\2\2\2KL\5\26\f\2LM\7\64"+
		"\2\2MS\3\2\2\2NS\5\30\r\2OP\5\34\17\2PQ\7\64\2\2QS\3\2\2\2R\62\3\2\2\2"+
		"R\63\3\2\2\2R\66\3\2\2\2R\67\3\2\2\2R8\3\2\2\2R9\3\2\2\2R<\3\2\2\2R?\3"+
		"\2\2\2RB\3\2\2\2RE\3\2\2\2RH\3\2\2\2RK\3\2\2\2RN\3\2\2\2RO\3\2\2\2S]\3"+
		"\2\2\2TX\7\22\2\2UW\5\4\3\2VU\3\2\2\2WZ\3\2\2\2XV\3\2\2\2XY\3\2\2\2Y["+
		"\3\2\2\2ZX\3\2\2\2[]\7\25\2\2\\R\3\2\2\2\\T\3\2\2\2]\5\3\2\2\2^_\7\23"+
		"\2\2_\7\3\2\2\2`a\7\17\2\2a\t\3\2\2\2bc\7\3\2\2cd\7\13\2\2de\5 \21\2e"+
		"f\7\7\2\2fg\7\30\2\2gh\7\6\2\2h\13\3\2\2\2ij\5&\24\2jk\7\"\2\2kl\5 \21"+
		"\2l\r\3\2\2\2mn\7\b\2\2no\7\13\2\2op\5 \21\2pq\7\6\2\2qr\5\4\3\2r\17\3"+
		"\2\2\2st\7\n\2\2tu\7\13\2\2uv\5\4\3\2vw\5 \21\2wx\7\64\2\2xy\5\22\n\2"+
		"yz\7\6\2\2z{\5\4\3\2{\21\3\2\2\2|\u0080\5\f\7\2}\u0080\5\"\22\2~\u0080"+
		"\5\4\3\2\177|\3\2\2\2\177}\3\2\2\2\177~\3\2\2\2\u0080\23\3\2\2\2\u0081"+
		"\u0082\7\r\2\2\u0082\u0083\7\13\2\2\u0083\u0084\5 \21\2\u0084\u0085\7"+
		"\6\2\2\u0085\u0086\5\4\3\2\u0086\u0090\3\2\2\2\u0087\u0088\7\r\2\2\u0088"+
		"\u0089\7\13\2\2\u0089\u008a\5 \21\2\u008a\u008b\7\6\2\2\u008b\u008c\5"+
		"\4\3\2\u008c\u008d\7\24\2\2\u008d\u008e\5\4\3\2\u008e\u0090\3\2\2\2\u008f"+
		"\u0081\3\2\2\2\u008f\u0087\3\2\2\2\u0090\25\3\2\2\2\u0091\u0092\7\27\2"+
		"\2\u0092\u0093\7\30\2\2\u0093\u0094\7\13\2\2\u0094\u0095\5\32\16\2\u0095"+
		"\u0096\7\6\2\2\u0096\u00a2\3\2\2\2\u0097\u0098\7\27\2\2\u0098\u0099\7"+
		"\30\2\2\u0099\u009a\7\13\2\2\u009a\u009b\5\32\16\2\u009b\u009c\7\6\2\2"+
		"\u009c\u009d\7\f\2\2\u009d\u009e\7\13\2\2\u009e\u009f\5\32\16\2\u009f"+
		"\u00a0\7\6\2\2\u00a0\u00a2\3\2\2\2\u00a1\u0091\3\2\2\2\u00a1\u0097\3\2"+
		"\2\2\u00a2\27\3\2\2\2\u00a3\u00a4\7\27\2\2\u00a4\u00a5\7\30\2\2\u00a5"+
		"\u00a6\7\13\2\2\u00a6\u00a7\5\32\16\2\u00a7\u00a8\7\6\2\2\u00a8\u00a9"+
		"\5\4\3\2\u00a9\u00b6\3\2\2\2\u00aa\u00ab\7\27\2\2\u00ab\u00ac\7\30\2\2"+
		"\u00ac\u00ad\7\13\2\2\u00ad\u00ae\5\32\16\2\u00ae\u00af\7\6\2\2\u00af"+
		"\u00b0\7\f\2\2\u00b0\u00b1\7\13\2\2\u00b1\u00b2\5\32\16\2\u00b2\u00b3"+
		"\7\6\2\2\u00b3\u00b4\5\4\3\2\u00b4\u00b6\3\2\2\2\u00b5\u00a3\3\2\2\2\u00b5"+
		"\u00aa\3\2\2\2\u00b6\31\3\2\2\2\u00b7\u00b8\7\27\2\2\u00b8\u00be\7\30"+
		"\2\2\u00b9\u00ba\7\7\2\2\u00ba\u00bb\7\27\2\2\u00bb\u00bd\7\30\2\2\u00bc"+
		"\u00b9\3\2\2\2\u00bd\u00c0\3\2\2\2\u00be\u00bc\3\2\2\2\u00be\u00bf\3\2"+
		"\2\2\u00bf\u00c2\3\2\2\2\u00c0\u00be\3\2\2\2\u00c1\u00b7\3\2\2\2\u00c1"+
		"\u00c2\3\2\2\2\u00c2\33\3\2\2\2\u00c3\u00c4\7\20\2\2\u00c4\u00c5\5 \21"+
		"\2\u00c5\35\3\2\2\2\u00c6\u00c7\7\21\2\2\u00c7\u00c8\7\13\2\2\u00c8\u00c9"+
		"\7\36\2\2\u00c9\u00ca\7\6\2\2\u00ca\37\3\2\2\2\u00cb\u00cc\b\21\1\2\u00cc"+
		"\u00cd\7\61\2\2\u00cd\u00db\5 \21\2\u00ce\u00db\5(\25\2\u00cf\u00db\5"+
		"$\23\2\u00d0\u00db\5&\24\2\u00d1\u00d2\7\5\2\2\u00d2\u00db\5&\24\2\u00d3"+
		"\u00db\7\35\2\2\u00d4\u00db\7\31\2\2\u00d5\u00db\7\37\2\2\u00d6\u00d7"+
		"\7\13\2\2\u00d7\u00d8\5 \21\2\u00d8\u00d9\7\6\2\2\u00d9\u00db\3\2\2\2"+
		"\u00da\u00cb\3\2\2\2\u00da\u00ce\3\2\2\2\u00da\u00cf\3\2\2\2\u00da\u00d0"+
		"\3\2\2\2\u00da\u00d1\3\2\2\2\u00da\u00d3\3\2\2\2\u00da\u00d4\3\2\2\2\u00da"+
		"\u00d5\3\2\2\2\u00da\u00d6\3\2\2\2\u00db\u00f6\3\2\2\2\u00dc\u00dd\6\21"+
		"\2\3\u00dd\u00de\t\2\2\2\u00de\u00f5\5 \21\2\u00df\u00e0\6\21\3\3\u00e0"+
		"\u00e1\t\3\2\2\u00e1\u00f5\5 \21\2\u00e2\u00e3\6\21\4\3\u00e3\u00e4\t"+
		"\4\2\2\u00e4\u00f5\5 \21\2\u00e5\u00e6\6\21\5\3\u00e6\u00e7\7*\2\2\u00e7"+
		"\u00f5\5 \21\2\u00e8\u00e9\6\21\6\3\u00e9\u00ea\t\5\2\2\u00ea\u00f5\5"+
		" \21\2\u00eb\u00ec\6\21\7\3\u00ec\u00ed\7/\2\2\u00ed\u00f5\5 \21\2\u00ee"+
		"\u00ef\6\21\b\3\u00ef\u00f0\7\63\2\2\u00f0\u00f5\5 \21\2\u00f1\u00f2\6"+
		"\21\t\3\u00f2\u00f3\7\60\2\2\u00f3\u00f5\5 \21\2\u00f4\u00dc\3\2\2\2\u00f4"+
		"\u00df\3\2\2\2\u00f4\u00e2\3\2\2\2\u00f4\u00e5\3\2\2\2\u00f4\u00e8\3\2"+
		"\2\2\u00f4\u00eb\3\2\2\2\u00f4\u00ee\3\2\2\2\u00f4\u00f1\3\2\2\2\u00f5"+
		"\u00f8\3\2\2\2\u00f6\u00f4\3\2\2\2\u00f6\u00f7\3\2\2\2\u00f7!\3\2\2\2"+
		"\u00f8\u00f6\3\2\2\2\u00f9\u00fa\5$\23\2\u00fa#\3\2\2\2\u00fb\u00fc\5"+
		"&\24\2\u00fc\u00fd\7\26\2\2\u00fd\u0106\3\2\2\2\u00fe\u00ff\7\26\2\2\u00ff"+
		"\u0106\5&\24\2\u0100\u0101\5&\24\2\u0101\u0102\7\16\2\2\u0102\u0106\3"+
		"\2\2\2\u0103\u0104\7\16\2\2\u0104\u0106\5&\24\2\u0105\u00fb\3\2\2\2\u0105"+
		"\u00fe\3\2\2\2\u0105\u0100\3\2\2\2\u0105\u0103\3\2\2\2\u0106%\3\2\2\2"+
		"\u0107\u0108\7-\2\2\u0108\u0109\7\13\2\2\u0109\u010a\5 \21\2\u010a\u010b"+
		"\7\6\2\2\u010b\u0117\3\2\2\2\u010c\u010d\7\30\2\2\u010d\u010e\7\t\2\2"+
		"\u010e\u010f\5 \21\2\u010f\u0110\7\4\2\2\u0110\u0117\3\2\2\2\u0111\u0117"+
		"\7\30\2\2\u0112\u0113\7\13\2\2\u0113\u0114\5&\24\2\u0114\u0115\7\6\2\2"+
		"\u0115\u0117\3\2\2\2\u0116\u0107\3\2\2\2\u0116\u010c\3\2\2\2\u0116\u0111"+
		"\3\2\2\2\u0116\u0112\3\2\2\2\u0117\'\3\2\2\2\u0118\u0119\7\30\2\2\u0119"+
		"\u011a\7\13\2\2\u011a\u011b\5*\26\2\u011b\u011c\7\6\2\2\u011c\u0122\3"+
		"\2\2\2\u011d\u011e\7\30\2\2\u011e\u011f\7\13\2\2\u011f\u0120\7\36\2\2"+
		"\u0120\u0122\7\6\2\2\u0121\u0118\3\2\2\2\u0121\u011d\3\2\2\2\u0122)\3"+
		"\2\2\2\u0123\u0128\5 \21\2\u0124\u0125\7\7\2\2\u0125\u0127\5 \21\2\u0126"+
		"\u0124\3\2\2\2\u0127\u012a\3\2\2\2\u0128\u0126\3\2\2\2\u0128\u0129\3\2"+
		"\2\2\u0129\u012c\3\2\2\2\u012a\u0128\3\2\2\2\u012b\u0123\3\2\2\2\u012b"+
		"\u012c\3\2\2\2\u012c+\3\2\2\2\24/RX\\\177\u008f\u00a1\u00b5\u00be\u00c1"+
		"\u00da\u00f4\u00f6\u0105\u0116\u0121\u0128\u012b";
	public static final ATN _ATN =
		ATNSimulator.deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}