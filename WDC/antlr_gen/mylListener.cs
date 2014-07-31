// Generated from myl.g4 by ANTLR 4.0.1-SNAPSHOT
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

public interface ImylListener : IParseTreeListener {
	void EnterOn_interrupt_stat(mylParser.On_interrupt_statContext context);
	void ExitOn_interrupt_stat(mylParser.On_interrupt_statContext context);

	void EnterFor_stat(mylParser.For_statContext context);
	void ExitFor_stat(mylParser.For_statContext context);

	void EnterFor_step(mylParser.For_stepContext context);
	void ExitFor_step(mylParser.For_stepContext context);

	void EnterFunc_def_no_var(mylParser.Func_def_no_varContext context);
	void ExitFunc_def_no_var(mylParser.Func_def_no_varContext context);

	void EnterNumber_expr_node(mylParser.Number_expr_nodeContext context);
	void ExitNumber_expr_node(mylParser.Number_expr_nodeContext context);

	void EnterNot_node(mylParser.Not_nodeContext context);
	void ExitNot_node(mylParser.Not_nodeContext context);

	void EnterNum_cmp_node(mylParser.Num_cmp_nodeContext context);
	void ExitNum_cmp_node(mylParser.Num_cmp_nodeContext context);

	void EnterIds_def(mylParser.Ids_defContext context);
	void ExitIds_def(mylParser.Ids_defContext context);

	void EnterAddrref_node(mylParser.Addrref_nodeContext context);
	void ExitAddrref_node(mylParser.Addrref_nodeContext context);

	void EnterXor_node(mylParser.Xor_nodeContext context);
	void ExitXor_node(mylParser.Xor_nodeContext context);

	void EnterShlshr(mylParser.ShlshrContext context);
	void ExitShlshr(mylParser.ShlshrContext context);

	void EnterIfelse_node(mylParser.Ifelse_nodeContext context);
	void ExitIfelse_node(mylParser.Ifelse_nodeContext context);

	void EnterIf_node(mylParser.If_nodeContext context);
	void ExitIf_node(mylParser.If_nodeContext context);

	void EnterVar_ref_node(mylParser.Var_ref_nodeContext context);
	void ExitVar_ref_node(mylParser.Var_ref_nodeContext context);

	void EnterParams_node(mylParser.Params_nodeContext context);
	void ExitParams_node(mylParser.Params_nodeContext context);

	void EnterLet_stat(mylParser.Let_statContext context);
	void ExitLet_stat(mylParser.Let_statContext context);

	void EnterSubvar_node(mylParser.Subvar_nodeContext context);
	void ExitSubvar_node(mylParser.Subvar_nodeContext context);

	void EnterSelf_addsub_stat(mylParser.Self_addsub_statContext context);
	void ExitSelf_addsub_stat(mylParser.Self_addsub_statContext context);

	void EnterFunc_dec_no_var(mylParser.Func_dec_no_varContext context);
	void ExitFunc_dec_no_var(mylParser.Func_dec_no_varContext context);

	void EnterProg(mylParser.ProgContext context);
	void ExitProg(mylParser.ProgContext context);

	void EnterContinue_stat(mylParser.Continue_statContext context);
	void ExitContinue_stat(mylParser.Continue_statContext context);

	void EnterRef_addr_node(mylParser.Ref_addr_nodeContext context);
	void ExitRef_addr_node(mylParser.Ref_addr_nodeContext context);

	void EnterMuldiv(mylParser.MuldivContext context);
	void ExitMuldiv(mylParser.MuldivContext context);

	void EnterSelf_addsub_node(mylParser.Self_addsub_nodeContext context);
	void ExitSelf_addsub_node(mylParser.Self_addsub_nodeContext context);

	void EnterBreak_stat(mylParser.Break_statContext context);
	void ExitBreak_stat(mylParser.Break_statContext context);

	void EnterAnd_node(mylParser.And_nodeContext context);
	void ExitAnd_node(mylParser.And_nodeContext context);

	void EnterAddvar_node(mylParser.Addvar_nodeContext context);
	void ExitAddvar_node(mylParser.Addvar_nodeContext context);

	void EnterString_node(mylParser.String_nodeContext context);
	void ExitString_node(mylParser.String_nodeContext context);

	void EnterVaradd_node(mylParser.Varadd_nodeContext context);
	void ExitVaradd_node(mylParser.Varadd_nodeContext context);

	void EnterFunc_node(mylParser.Func_nodeContext context);
	void ExitFunc_node(mylParser.Func_nodeContext context);

	void EnterRef_node(mylParser.Ref_nodeContext context);
	void ExitRef_node(mylParser.Ref_nodeContext context);

	void EnterOr_node(mylParser.Or_nodeContext context);
	void ExitOr_node(mylParser.Or_nodeContext context);

	void EnterId_node(mylParser.Id_nodeContext context);
	void ExitId_node(mylParser.Id_nodeContext context);

	void EnterIdref_node(mylParser.Idref_nodeContext context);
	void ExitIdref_node(mylParser.Idref_nodeContext context);

	void EnterStat(mylParser.StatContext context);
	void ExitStat(mylParser.StatContext context);

	void EnterChar_node(mylParser.Char_nodeContext context);
	void ExitChar_node(mylParser.Char_nodeContext context);

	void EnterFunc_ret(mylParser.Func_retContext context);
	void ExitFunc_ret(mylParser.Func_retContext context);

	void EnterAddsub(mylParser.AddsubContext context);
	void ExitAddsub(mylParser.AddsubContext context);

	void EnterMod_node(mylParser.Mod_nodeContext context);
	void ExitMod_node(mylParser.Mod_nodeContext context);

	void EnterConst_node(mylParser.Const_nodeContext context);
	void ExitConst_node(mylParser.Const_nodeContext context);

	void EnterParams_use(mylParser.Params_useContext context);
	void ExitParams_use(mylParser.Params_useContext context);

	void EnterVarsub_node(mylParser.Varsub_nodeContext context);
	void ExitVarsub_node(mylParser.Varsub_nodeContext context);

	void EnterFunc_def_var(mylParser.Func_def_varContext context);
	void ExitFunc_def_var(mylParser.Func_def_varContext context);

	void EnterInt_node(mylParser.Int_nodeContext context);
	void ExitInt_node(mylParser.Int_nodeContext context);

	void EnterFunc_dec_var(mylParser.Func_dec_varContext context);
	void ExitFunc_dec_var(mylParser.Func_dec_varContext context);

	void EnterWhile_stat(mylParser.While_statContext context);
	void ExitWhile_stat(mylParser.While_statContext context);

	void EnterAsm(mylParser.AsmContext context);
	void ExitAsm(mylParser.AsmContext context);
}
