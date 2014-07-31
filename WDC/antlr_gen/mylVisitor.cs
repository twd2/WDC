// Generated from myl.g4 by ANTLR 4.0.1-SNAPSHOT
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

public interface ImylVisitor<Result> : IParseTreeVisitor<Result> {
	Result VisitOn_interrupt_stat(mylParser.On_interrupt_statContext context);

	Result VisitFor_stat(mylParser.For_statContext context);

	Result VisitFor_step(mylParser.For_stepContext context);

	Result VisitFunc_def_no_var(mylParser.Func_def_no_varContext context);

	Result VisitNumber_expr_node(mylParser.Number_expr_nodeContext context);

	Result VisitNot_node(mylParser.Not_nodeContext context);

	Result VisitNum_cmp_node(mylParser.Num_cmp_nodeContext context);

	Result VisitIds_def(mylParser.Ids_defContext context);

	Result VisitAddrref_node(mylParser.Addrref_nodeContext context);

	Result VisitXor_node(mylParser.Xor_nodeContext context);

	Result VisitShlshr(mylParser.ShlshrContext context);

	Result VisitIfelse_node(mylParser.Ifelse_nodeContext context);

	Result VisitIf_node(mylParser.If_nodeContext context);

	Result VisitVar_ref_node(mylParser.Var_ref_nodeContext context);

	Result VisitParams_node(mylParser.Params_nodeContext context);

	Result VisitLet_stat(mylParser.Let_statContext context);

	Result VisitSubvar_node(mylParser.Subvar_nodeContext context);

	Result VisitSelf_addsub_stat(mylParser.Self_addsub_statContext context);

	Result VisitFunc_dec_no_var(mylParser.Func_dec_no_varContext context);

	Result VisitProg(mylParser.ProgContext context);

	Result VisitContinue_stat(mylParser.Continue_statContext context);

	Result VisitRef_addr_node(mylParser.Ref_addr_nodeContext context);

	Result VisitMuldiv(mylParser.MuldivContext context);

	Result VisitSelf_addsub_node(mylParser.Self_addsub_nodeContext context);

	Result VisitBreak_stat(mylParser.Break_statContext context);

	Result VisitAnd_node(mylParser.And_nodeContext context);

	Result VisitAddvar_node(mylParser.Addvar_nodeContext context);

	Result VisitString_node(mylParser.String_nodeContext context);

	Result VisitVaradd_node(mylParser.Varadd_nodeContext context);

	Result VisitFunc_node(mylParser.Func_nodeContext context);

	Result VisitRef_node(mylParser.Ref_nodeContext context);

	Result VisitOr_node(mylParser.Or_nodeContext context);

	Result VisitId_node(mylParser.Id_nodeContext context);

	Result VisitIdref_node(mylParser.Idref_nodeContext context);

	Result VisitStat(mylParser.StatContext context);

	Result VisitChar_node(mylParser.Char_nodeContext context);

	Result VisitFunc_ret(mylParser.Func_retContext context);

	Result VisitAddsub(mylParser.AddsubContext context);

	Result VisitMod_node(mylParser.Mod_nodeContext context);

	Result VisitConst_node(mylParser.Const_nodeContext context);

	Result VisitParams_use(mylParser.Params_useContext context);

	Result VisitVarsub_node(mylParser.Varsub_nodeContext context);

	Result VisitFunc_def_var(mylParser.Func_def_varContext context);

	Result VisitInt_node(mylParser.Int_nodeContext context);

	Result VisitFunc_dec_var(mylParser.Func_dec_varContext context);

	Result VisitWhile_stat(mylParser.While_statContext context);

	Result VisitAsm(mylParser.AsmContext context);
}
