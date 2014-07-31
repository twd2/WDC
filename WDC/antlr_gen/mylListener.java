// Generated from myl.g4 by ANTLR 4.1
import org.antlr.v4.runtime.misc.NotNull;
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link mylParser}.
 */
public interface mylListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link mylParser#on_interrupt_stat}.
	 * @param ctx the parse tree
	 */
	void enterOn_interrupt_stat(@NotNull mylParser.On_interrupt_statContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#on_interrupt_stat}.
	 * @param ctx the parse tree
	 */
	void exitOn_interrupt_stat(@NotNull mylParser.On_interrupt_statContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#for_stat}.
	 * @param ctx the parse tree
	 */
	void enterFor_stat(@NotNull mylParser.For_statContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#for_stat}.
	 * @param ctx the parse tree
	 */
	void exitFor_stat(@NotNull mylParser.For_statContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#for_step}.
	 * @param ctx the parse tree
	 */
	void enterFor_step(@NotNull mylParser.For_stepContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#for_step}.
	 * @param ctx the parse tree
	 */
	void exitFor_step(@NotNull mylParser.For_stepContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#func_def_no_var}.
	 * @param ctx the parse tree
	 */
	void enterFunc_def_no_var(@NotNull mylParser.Func_def_no_varContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#func_def_no_var}.
	 * @param ctx the parse tree
	 */
	void exitFunc_def_no_var(@NotNull mylParser.Func_def_no_varContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#number_expr_node}.
	 * @param ctx the parse tree
	 */
	void enterNumber_expr_node(@NotNull mylParser.Number_expr_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#number_expr_node}.
	 * @param ctx the parse tree
	 */
	void exitNumber_expr_node(@NotNull mylParser.Number_expr_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#not_node}.
	 * @param ctx the parse tree
	 */
	void enterNot_node(@NotNull mylParser.Not_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#not_node}.
	 * @param ctx the parse tree
	 */
	void exitNot_node(@NotNull mylParser.Not_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#num_cmp_node}.
	 * @param ctx the parse tree
	 */
	void enterNum_cmp_node(@NotNull mylParser.Num_cmp_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#num_cmp_node}.
	 * @param ctx the parse tree
	 */
	void exitNum_cmp_node(@NotNull mylParser.Num_cmp_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#ids_def}.
	 * @param ctx the parse tree
	 */
	void enterIds_def(@NotNull mylParser.Ids_defContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#ids_def}.
	 * @param ctx the parse tree
	 */
	void exitIds_def(@NotNull mylParser.Ids_defContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#addrref_node}.
	 * @param ctx the parse tree
	 */
	void enterAddrref_node(@NotNull mylParser.Addrref_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#addrref_node}.
	 * @param ctx the parse tree
	 */
	void exitAddrref_node(@NotNull mylParser.Addrref_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#xor_node}.
	 * @param ctx the parse tree
	 */
	void enterXor_node(@NotNull mylParser.Xor_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#xor_node}.
	 * @param ctx the parse tree
	 */
	void exitXor_node(@NotNull mylParser.Xor_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#shlshr}.
	 * @param ctx the parse tree
	 */
	void enterShlshr(@NotNull mylParser.ShlshrContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#shlshr}.
	 * @param ctx the parse tree
	 */
	void exitShlshr(@NotNull mylParser.ShlshrContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#ifelse_node}.
	 * @param ctx the parse tree
	 */
	void enterIfelse_node(@NotNull mylParser.Ifelse_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#ifelse_node}.
	 * @param ctx the parse tree
	 */
	void exitIfelse_node(@NotNull mylParser.Ifelse_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#if_node}.
	 * @param ctx the parse tree
	 */
	void enterIf_node(@NotNull mylParser.If_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#if_node}.
	 * @param ctx the parse tree
	 */
	void exitIf_node(@NotNull mylParser.If_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#var_ref_node}.
	 * @param ctx the parse tree
	 */
	void enterVar_ref_node(@NotNull mylParser.Var_ref_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#var_ref_node}.
	 * @param ctx the parse tree
	 */
	void exitVar_ref_node(@NotNull mylParser.Var_ref_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#params_node}.
	 * @param ctx the parse tree
	 */
	void enterParams_node(@NotNull mylParser.Params_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#params_node}.
	 * @param ctx the parse tree
	 */
	void exitParams_node(@NotNull mylParser.Params_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#let_stat}.
	 * @param ctx the parse tree
	 */
	void enterLet_stat(@NotNull mylParser.Let_statContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#let_stat}.
	 * @param ctx the parse tree
	 */
	void exitLet_stat(@NotNull mylParser.Let_statContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#subvar_node}.
	 * @param ctx the parse tree
	 */
	void enterSubvar_node(@NotNull mylParser.Subvar_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#subvar_node}.
	 * @param ctx the parse tree
	 */
	void exitSubvar_node(@NotNull mylParser.Subvar_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#self_addsub_stat}.
	 * @param ctx the parse tree
	 */
	void enterSelf_addsub_stat(@NotNull mylParser.Self_addsub_statContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#self_addsub_stat}.
	 * @param ctx the parse tree
	 */
	void exitSelf_addsub_stat(@NotNull mylParser.Self_addsub_statContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#func_dec_no_var}.
	 * @param ctx the parse tree
	 */
	void enterFunc_dec_no_var(@NotNull mylParser.Func_dec_no_varContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#func_dec_no_var}.
	 * @param ctx the parse tree
	 */
	void exitFunc_dec_no_var(@NotNull mylParser.Func_dec_no_varContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#prog}.
	 * @param ctx the parse tree
	 */
	void enterProg(@NotNull mylParser.ProgContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#prog}.
	 * @param ctx the parse tree
	 */
	void exitProg(@NotNull mylParser.ProgContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#continue_stat}.
	 * @param ctx the parse tree
	 */
	void enterContinue_stat(@NotNull mylParser.Continue_statContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#continue_stat}.
	 * @param ctx the parse tree
	 */
	void exitContinue_stat(@NotNull mylParser.Continue_statContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#ref_addr_node}.
	 * @param ctx the parse tree
	 */
	void enterRef_addr_node(@NotNull mylParser.Ref_addr_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#ref_addr_node}.
	 * @param ctx the parse tree
	 */
	void exitRef_addr_node(@NotNull mylParser.Ref_addr_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#muldiv}.
	 * @param ctx the parse tree
	 */
	void enterMuldiv(@NotNull mylParser.MuldivContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#muldiv}.
	 * @param ctx the parse tree
	 */
	void exitMuldiv(@NotNull mylParser.MuldivContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#self_addsub_node}.
	 * @param ctx the parse tree
	 */
	void enterSelf_addsub_node(@NotNull mylParser.Self_addsub_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#self_addsub_node}.
	 * @param ctx the parse tree
	 */
	void exitSelf_addsub_node(@NotNull mylParser.Self_addsub_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#break_stat}.
	 * @param ctx the parse tree
	 */
	void enterBreak_stat(@NotNull mylParser.Break_statContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#break_stat}.
	 * @param ctx the parse tree
	 */
	void exitBreak_stat(@NotNull mylParser.Break_statContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#and_node}.
	 * @param ctx the parse tree
	 */
	void enterAnd_node(@NotNull mylParser.And_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#and_node}.
	 * @param ctx the parse tree
	 */
	void exitAnd_node(@NotNull mylParser.And_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#addvar_node}.
	 * @param ctx the parse tree
	 */
	void enterAddvar_node(@NotNull mylParser.Addvar_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#addvar_node}.
	 * @param ctx the parse tree
	 */
	void exitAddvar_node(@NotNull mylParser.Addvar_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#string_node}.
	 * @param ctx the parse tree
	 */
	void enterString_node(@NotNull mylParser.String_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#string_node}.
	 * @param ctx the parse tree
	 */
	void exitString_node(@NotNull mylParser.String_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#varadd_node}.
	 * @param ctx the parse tree
	 */
	void enterVaradd_node(@NotNull mylParser.Varadd_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#varadd_node}.
	 * @param ctx the parse tree
	 */
	void exitVaradd_node(@NotNull mylParser.Varadd_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#func_node}.
	 * @param ctx the parse tree
	 */
	void enterFunc_node(@NotNull mylParser.Func_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#func_node}.
	 * @param ctx the parse tree
	 */
	void exitFunc_node(@NotNull mylParser.Func_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#ref_node}.
	 * @param ctx the parse tree
	 */
	void enterRef_node(@NotNull mylParser.Ref_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#ref_node}.
	 * @param ctx the parse tree
	 */
	void exitRef_node(@NotNull mylParser.Ref_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#or_node}.
	 * @param ctx the parse tree
	 */
	void enterOr_node(@NotNull mylParser.Or_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#or_node}.
	 * @param ctx the parse tree
	 */
	void exitOr_node(@NotNull mylParser.Or_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#id_node}.
	 * @param ctx the parse tree
	 */
	void enterId_node(@NotNull mylParser.Id_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#id_node}.
	 * @param ctx the parse tree
	 */
	void exitId_node(@NotNull mylParser.Id_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#idref_node}.
	 * @param ctx the parse tree
	 */
	void enterIdref_node(@NotNull mylParser.Idref_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#idref_node}.
	 * @param ctx the parse tree
	 */
	void exitIdref_node(@NotNull mylParser.Idref_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#stat}.
	 * @param ctx the parse tree
	 */
	void enterStat(@NotNull mylParser.StatContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#stat}.
	 * @param ctx the parse tree
	 */
	void exitStat(@NotNull mylParser.StatContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#char_node}.
	 * @param ctx the parse tree
	 */
	void enterChar_node(@NotNull mylParser.Char_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#char_node}.
	 * @param ctx the parse tree
	 */
	void exitChar_node(@NotNull mylParser.Char_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#func_ret}.
	 * @param ctx the parse tree
	 */
	void enterFunc_ret(@NotNull mylParser.Func_retContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#func_ret}.
	 * @param ctx the parse tree
	 */
	void exitFunc_ret(@NotNull mylParser.Func_retContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#addsub}.
	 * @param ctx the parse tree
	 */
	void enterAddsub(@NotNull mylParser.AddsubContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#addsub}.
	 * @param ctx the parse tree
	 */
	void exitAddsub(@NotNull mylParser.AddsubContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#mod_node}.
	 * @param ctx the parse tree
	 */
	void enterMod_node(@NotNull mylParser.Mod_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#mod_node}.
	 * @param ctx the parse tree
	 */
	void exitMod_node(@NotNull mylParser.Mod_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#const_node}.
	 * @param ctx the parse tree
	 */
	void enterConst_node(@NotNull mylParser.Const_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#const_node}.
	 * @param ctx the parse tree
	 */
	void exitConst_node(@NotNull mylParser.Const_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#params_use}.
	 * @param ctx the parse tree
	 */
	void enterParams_use(@NotNull mylParser.Params_useContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#params_use}.
	 * @param ctx the parse tree
	 */
	void exitParams_use(@NotNull mylParser.Params_useContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#varsub_node}.
	 * @param ctx the parse tree
	 */
	void enterVarsub_node(@NotNull mylParser.Varsub_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#varsub_node}.
	 * @param ctx the parse tree
	 */
	void exitVarsub_node(@NotNull mylParser.Varsub_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#func_def_var}.
	 * @param ctx the parse tree
	 */
	void enterFunc_def_var(@NotNull mylParser.Func_def_varContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#func_def_var}.
	 * @param ctx the parse tree
	 */
	void exitFunc_def_var(@NotNull mylParser.Func_def_varContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#int_node}.
	 * @param ctx the parse tree
	 */
	void enterInt_node(@NotNull mylParser.Int_nodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#int_node}.
	 * @param ctx the parse tree
	 */
	void exitInt_node(@NotNull mylParser.Int_nodeContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#func_dec_var}.
	 * @param ctx the parse tree
	 */
	void enterFunc_dec_var(@NotNull mylParser.Func_dec_varContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#func_dec_var}.
	 * @param ctx the parse tree
	 */
	void exitFunc_dec_var(@NotNull mylParser.Func_dec_varContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#while_stat}.
	 * @param ctx the parse tree
	 */
	void enterWhile_stat(@NotNull mylParser.While_statContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#while_stat}.
	 * @param ctx the parse tree
	 */
	void exitWhile_stat(@NotNull mylParser.While_statContext ctx);

	/**
	 * Enter a parse tree produced by {@link mylParser#asm}.
	 * @param ctx the parse tree
	 */
	void enterAsm(@NotNull mylParser.AsmContext ctx);
	/**
	 * Exit a parse tree produced by {@link mylParser#asm}.
	 * @param ctx the parse tree
	 */
	void exitAsm(@NotNull mylParser.AsmContext ctx);
}