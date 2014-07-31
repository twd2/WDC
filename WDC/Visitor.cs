using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyLanguage
{
    class Visitor : mylBaseVisitor<object>
    {

        Stack<Dictionary<string, VarInfo>> _Function_Var = new Stack<Dictionary<string, VarInfo>>();
        private Dictionary<string, FuncInfo> _Function_Dec;
        Stack<LoopInfo> _Loop = new Stack<LoopInfo>();
        //private bool isInLoop = false;
        //private string _CurrentLoopStartLab, _CurrentLoopEndLab, _CurrentLoopNextLab;

        private bool _isFirst;
        private bool _isLast;

        TextWriter _tw;
        private int _TreeID = 0;
        private int _MaxLableID = -1;

        public Visitor(TextWriter tw, bool isFirst, bool isLast, int TreeID = 0)
        {
            _tw = tw;
            _Function_Dec = new Dictionary<string, FuncInfo>();
            this._isFirst = isFirst;
            this._isLast = isLast;
            this._TreeID = TreeID;
        }

        public Visitor(TextWriter tw, Dictionary<string, FuncInfo> func_dec, bool isFirst, bool isLast = false, int TreeID = 0)
        {
            _tw = tw;
            _Function_Dec = func_dec;
            this._isFirst = isFirst;
            this._isLast = isLast;
            this._TreeID = TreeID;
        }

        ~Visitor()
        {

        }

        private Dictionary<string, VarInfo> vartable()
        {
            if (_Function_Var.Count <= 0) return null;
            return _Function_Var.Peek();
        }

        private string getLabelID()
        {
            return "_CODE_" + _TreeID.ToString() + "_LABEL_" + (++_MaxLableID).ToString() + "_";
        }

        private string getLabelUserFunction(string funcname)
        {
            return "_USER_FUNCTION_" + funcname + "_";
        }

        private string getLabelInterruptFunction(string funcname)
        {
            return "_INTERRUPT_FUNCTION_" + funcname + "_";
        }

        public override object Visit(Antlr4.Runtime.Tree.IParseTree tree)
        {
            string labstart = "_LABEL_START_";
            if (_isFirst)
            {
                _tw.WriteLine("jmp " + labstart);
            }
            base.Visit(tree);
            if (_isLast)
            {
                _tw.WriteLine(labstart + ":");
                string funcname = "main";
                FuncInfo fi = getFuncInfo(funcname, null);
                if (fi.ParamsCount > 0)
                {
                    throw new CompileException("Main shouldn't have param.", null);
                }
                //先从右到左压参数
                //然后压变量, 置零
                for (int i = 0; i < fi.VarCount + fi.ParamsCount; ++i)
                {
                    _tw.WriteLine("pushi 0");
                }
                _tw.WriteLine("call " + getLabelUserFunction(funcname));
                //clear stack
                for (int i = 0; i < fi.VarCount + fi.ParamsCount; ++i)
                {
                    _tw.WriteLine("popi");
                    //_tw.WriteLine("popi r7");
                }
                _tw.WriteLine("cli");
                _tw.WriteLine("hlt");
            }
            return null;
        }

        public override object VisitConst_node(mylParser.Const_nodeContext context)
        {
            switch (context.CONST().GetText())
            {
                case "true":
                    _tw.WriteLine("pushi 1");
                    break;
                case "false":
                    _tw.WriteLine("pushi 0");
                    break;
                default:
                    break;
            }
            return null;
        }

        public override object VisitInt_node(mylParser.Int_nodeContext context)
        {
            _tw.WriteLine("pushi " + context.INT().GetText());
            return null;
            //return base.VisitInt_node(context);
        }

        public override object VisitChar_node(mylParser.Char_nodeContext context)
        {
            string s = parseString(context.CHAR().GetText());
            _tw.WriteLine("pushi " + (byte)s[0]);
            return null;
        }

        public override object VisitId_node(mylParser.Id_nodeContext context)
        {
            checkVar(context.ID().GetText(), context);
            _tw.Write(vartable()[context.ID().GetText()].getAbsAddress());
            return null;
        }

        private void checkVar(string varname, ParserRuleContext context)
        {
            if (vartable() == null || !vartable().ContainsKey(varname))
            {
                throw new CompileException("Undefined var \"" + varname + "\"", context);
            }
        }

        public override object VisitMuldiv(mylParser.MuldivContext context)
        {
            base.VisitMuldiv(context);
            if (context.op.Type == mylParser.MUL)
            {
                _tw.WriteLine("muli");
            }
            else
            {
                _tw.WriteLine("divi");
                _tw.WriteLine("popi r1");
                _tw.WriteLine("popi"); //drop 余数
                //_tw.WriteLine("popi r7"); //drop 余数
                _tw.WriteLine("pushi r1");
            }
            return null;
        }

        public override object VisitAddsub(mylParser.AddsubContext context)
        {
            base.VisitAddsub(context);
            if (context.op.Type == mylParser.ADD)
            {
                _tw.WriteLine("addi");
            }
            else
            {
                _tw.WriteLine("subi");
            }
            return null;
        }

        public override object VisitMod_node(mylParser.Mod_nodeContext context)
        {
            base.VisitMod_node(context);
            _tw.WriteLine("divi");
            _tw.WriteLine("popi"); //drop 商
            //_tw.WriteLine("popi r7"); //drop 商
            return null;
        }

        public override object VisitAnd_node(mylParser.And_nodeContext context)
        {
            base.VisitAnd_node(context);
            _tw.WriteLine("and");
            return null;
        }

        public override object VisitNot_node(mylParser.Not_nodeContext context)
        {
            base.VisitNot_node(context);
            _tw.WriteLine("not");
            return null;
        }

        public override object VisitOr_node(mylParser.Or_nodeContext context)
        {
            base.VisitOr_node(context);
            _tw.WriteLine("or");
            return null;
        }

        public override object VisitXor_node(mylParser.Xor_nodeContext context)
        {
            base.VisitXor_node(context);
            _tw.WriteLine("xor");
            return null;
        }

        public override object VisitNum_cmp_node(mylParser.Num_cmp_nodeContext context)
        {
            base.VisitNum_cmp_node(context);
            switch (context.op.Type)
            {
                case mylParser.LT:
                    _tw.WriteLine("lti");
                    break;
                case mylParser.LTE:
                    _tw.WriteLine("ltei");
                    break;
                case mylParser.GT:
                    _tw.WriteLine("gti");
                    break;
                case mylParser.GTE:
                    _tw.WriteLine("gtei");
                    break;
                case mylParser.EQU:
                    _tw.WriteLine("eqi");
                    break;
                case mylParser.NEQU:
                    _tw.WriteLine("neqi");
                    break;
                default:
                    break;
            }
            return null;
        }

        public override object VisitIf_node(mylParser.If_nodeContext context)
        {
            base.Visit(context.number_expr());
            string lab = getLabelID();
            _tw.WriteLine("jf " + lab);
            base.Visit(context.stat());
            _tw.WriteLine(lab + ":");
            return null;
            //return base.VisitIf_node(context);
        }

        public override object VisitIfelse_node(mylParser.Ifelse_nodeContext context)
        {
            base.Visit(context.number_expr());
            string falselab = getLabelID(), endiflab = getLabelID();
            _tw.WriteLine("jf " + falselab);
            base.Visit(context.truestat);
            _tw.WriteLine("jmp " + endiflab);
            _tw.WriteLine(falselab + ":");
            base.Visit(context.falsestat);
            _tw.WriteLine(endiflab + ":");
            return null;
        }

        public override object VisitShlshr(mylParser.ShlshrContext context)
        {
            base.VisitShlshr(context);
            if (context.op.Type == mylParser.SHL)
            {
                _tw.WriteLine("shl");
            }
            else
            {
                _tw.WriteLine("shr");
            }
            return null;
        }

        public override object VisitWhile_stat(mylParser.While_statContext context)
        {
            //isInLoop = true;
            LoopInfo li = new LoopInfo();
            li.StartLab = getLabelID();
            li.NextLab = li.StartLab;
            li.EndLab = getLabelID();
            _Loop.Push(li);
            _tw.WriteLine(li.StartLab + ":");
            base.Visit(context.number_expr());
            _tw.WriteLine("jf " + li.EndLab);
            base.Visit(context.stat());
            _tw.WriteLine("jmp " + li.StartLab);
            _tw.WriteLine(li.EndLab + ":");
            _Loop.Pop();
            return null;
            //return base.VisitWhile_stat(context);
        }

        public override object VisitRef_node(mylParser.Ref_nodeContext context)
        {
            base.VisitRef_node(context);
            _tw.WriteLine("ldri");
            return null;
        }

        public override object VisitRef_addr_node(mylParser.Ref_addr_nodeContext context)
        {
            return base.VisitRef_addr_node(context);
        }

        /*public override object VisitPutchar_stat(mylParser.Putchar_statContext context)
        {
            base.VisitPutchar_stat(context);
            _tw.WriteLine("prc");
            return null;
        }*/

        /*
        public override object VisitGetchar_node(mylParser.Getchar_nodeContext context)
        {
            _tw.WriteLine("rdc");
            return null;
        }
        */

        public override object VisitAsm(mylParser.AsmContext context)
        {
            _tw.WriteLine(parseString(context.STRING().GetText()));
            return null;
        }

        private string parseString(string src)
        {
            StringBuilder sb = new StringBuilder();
            bool stat = false;
            for (int i = 1; i < src.Length - 1; ++i)
            {
                if (!stat)
                {
                    if (src[i] == '\\')
                    {
                        stat = true;
                    }
                    else
                    {
                        sb.Append(src[i]);
                    }
                }
                else
                {
                    switch (src[i])
                    {
                        case 'n':
                            sb.Append('\n');
                            break;
                        case 't':
                            sb.Append('\t');
                            break;
                        case 'r':
                            sb.Append('\r');
                            break;
                        case '\\':
                            sb.Append('\\');
                            break;
                        case '"':
                            sb.Append('"');
                            break;
                        case '\'':
                            sb.Append('\'');
                            break;
                        default:
                            break;
                    }
                    stat = false;
                }
            }
            return sb.ToString();
        }

        public override object VisitLet_stat(mylParser.Let_statContext context)
        {
            base.VisitLet_stat(context);
            _tw.WriteLine("stri");
            //_tw.WriteLine("pushi " + context.ID().GetText());
            return null;
        }

        public override object VisitAddrref_node(mylParser.Addrref_nodeContext context)
        {
            return base.VisitAddrref_node(context);
        }

        public override object VisitIdref_node(mylParser.Idref_nodeContext context)
        {
            checkVar(context.ID().GetText(), context);
            _tw.Write(vartable()[context.ID().GetText()].getAbsAddress());
            base.VisitIdref_node(context);
            _tw.WriteLine("subi");
            return null;
            //return base.VisitIdref_node(context);
        }

        public override object VisitString_node(mylParser.String_nodeContext context)
        {
            string str = parseString(context.STRING().GetText());
            string funcname = context.ID().GetText();
            FuncInfo fi = getFuncInfo(funcname, context);
            if (str.Length + 1 < fi.ParamsCount)
            {
                throw new CompileException("Param not enough", context);
            }
            //先从右到左压参数
            _tw.WriteLine("pushi 0");
            for (int i = str.Length - 1; i >= 0; --i)
            {
                _tw.WriteLine("pushi " + ((byte)str[i]).ToString());
            }
            //然后压变量, 置零
            for (int i = 0; i < fi.VarCount; ++i)
            {
                _tw.WriteLine("pushi 0");
            }
            _tw.WriteLine("call " + getLabelUserFunction(funcname));
            //clear stack
            for (int i = 0; i < fi.VarCount; ++i)
            {
                _tw.WriteLine("popi");
                //_tw.WriteLine("popi r7");
            }
            for (int i = str.Length - 1; i >= 0; --i)
            {
                _tw.WriteLine("popi");
                //_tw.WriteLine("popi r7");
            }
            _tw.WriteLine("popi");
            //_tw.WriteLine("popi r7");
            return null;
        }

        public override object VisitParams_node(mylParser.Params_nodeContext context)
        {
            string funcname = context.ID().GetText();
            FuncInfo fi = getFuncInfo(funcname, context);
            if (context.params_use().number_expr().Length < fi.ParamsCount)
            {
                throw new CompileException("Param not enough", context);
            }
            //先从右到左压参数
            for (int i = context.params_use().number_expr().Length - 1; i >= 0; --i)
            {
                base.Visit(context.params_use().number_expr()[i]);
            }
            //然后压变量, 置零
            for (int i = 0; i < fi.VarCount; ++i)
            {
                _tw.WriteLine("pushi 0");
            }
            _tw.WriteLine("call " + getLabelUserFunction(funcname));
            //clear stack
            for (int i = 0; i < fi.VarCount; ++i)
            {
                _tw.WriteLine("popi");
                //_tw.WriteLine("popi r7");
            }
            for (int i = context.params_use().number_expr().Length - 1; i >= 0; --i)
            {
                _tw.WriteLine("popi");
                //_tw.WriteLine("popi r7");
            }
            return null;
        }

        private FuncInfo getFuncInfo(string funcname, ParserRuleContext context)
        {
            if (!_Function_Dec.ContainsKey(funcname) /*|| !_Function_Dec[funcname].defined*/)
            {
                throw new CompileException("Undefined function \"" + funcname + "\"", context);
            }
            return _Function_Dec[funcname];
        }

        private void addFuncDec(string funcname, FuncInfo fi, ParserRuleContext context)
        {
            if (_Function_Dec.ContainsKey(funcname))
            {
                FuncInfo oldfi = _Function_Dec[funcname];
                if (oldfi.VarCount != fi.VarCount || oldfi.ParamsCount != fi.ParamsCount)
                {
                    throw new CompileException("Function define mismatch", context);
                }
            }
            else
            {
                _Function_Dec.Add(funcname, fi);
            }
        }

        private void addFuncDef(string funcname, FuncInfo fi, ParserRuleContext context)
        {
            if (_Function_Dec.ContainsKey(funcname))
            {
                FuncInfo oldfi = _Function_Dec[funcname];
                if (oldfi.VarCount != fi.VarCount || oldfi.ParamsCount != fi.ParamsCount)
                {
                    throw new CompileException("Function define mismatch", context);
                }
                else
                {
                    oldfi.defined = true;
                }
            }
            else
            {
                _Function_Dec.Add(funcname, fi);
                fi.defined = true;
            }
        }

        public override object VisitFunc_def_no_var(mylParser.Func_def_no_varContext context)
        {
            string funcname = context.ID().GetText();
            var paramsids = context.params_def.ID();
            FuncInfo fi = new FuncInfo(paramsids.Length, 0);
            fi.defined = true;
            addFuncDef(funcname, fi, context);
            var funcvar = new Dictionary<string, VarInfo>();

            for (int i = 0; i < paramsids.Length; ++i)
            {
                funcvar.Add(paramsids[i].GetText(), new VarInfo(VarType.rel, fi.ParamRelAddress - i));
            }
            _Function_Var.Push(funcvar);
            _tw.WriteLine(getLabelUserFunction(funcname) + ":");
            _tw.WriteLine("pushi ebp"); //save ebp
            _tw.WriteLine("pushi esp");
            _tw.WriteLine("popi ebp"); //ebp=esp

            base.Visit(context.stat());

            //防止没有return
            _tw.WriteLine("popi ebp"); //reload ebp
            _tw.WriteLine("ret");

            _Function_Var.Pop();
            return null;
        }

        public override object VisitFunc_dec_no_var(mylParser.Func_dec_no_varContext context)
        {
            string funcname = context.ID().GetText();
            var paramsids = context.params_def.ID();
            FuncInfo fi = new FuncInfo(paramsids.Length, 0);
            addFuncDec(funcname, fi, context);
            return null;
        }

        public override object VisitFunc_def_var(mylParser.Func_def_varContext context)
        {
            string funcname = context.ID().GetText();
            var paramsids = context.params_def.ID();
            var varids = context.vars_def.ID();
            FuncInfo fi = new FuncInfo(paramsids.Length, varids.Length);
            fi.defined = true;
            addFuncDef(funcname, fi, context);
            var funcvar = new Dictionary<string, VarInfo>();
            for (int i = 0; i < varids.Length; ++i)
            {
                funcvar.Add(varids[i].GetText(), new VarInfo(VarType.rel, fi.VarRelAddress - i));
            }
            for (int i = 0; i < paramsids.Length; ++i)
            {
                funcvar.Add(paramsids[i].GetText(), new VarInfo(VarType.rel, fi.ParamRelAddress - i));
            }
            _Function_Var.Push(funcvar);
            _tw.WriteLine(getLabelUserFunction(funcname) + ":");
            _tw.WriteLine("pushi ebp"); //save ebp
            _tw.WriteLine("pushi esp");
            _tw.WriteLine("popi ebp"); //ebp=esp

            base.Visit(context.stat());

            //防止没有return
            _tw.WriteLine("popi ebp"); //reload ebp
            _tw.WriteLine("ret");

            _Function_Var.Pop();
            return null;
        }

        public override object VisitFunc_dec_var(mylParser.Func_dec_varContext context)
        {
            string funcname = context.ID().GetText();
            var paramsids = context.params_def.ID();
            var varids = context.vars_def.ID();
            FuncInfo fi = new FuncInfo(paramsids.Length, varids.Length);
            addFuncDec(funcname, fi, context);
            return null;
        }

        public override object VisitOn_interrupt_stat(mylParser.On_interrupt_statContext context)
        {
            string funcname = context.ID().GetText();
            FuncInfo fi = getFuncInfo(funcname, context);
            if (fi.ParamsCount > 0 || fi.VarCount > 0)
            {
                throw new CompileException("Interrupt function shouldn't have param or var.", context);
            }
            //string labskip = getLabelID();
            //_tw.WriteLine("jmp " + labskip);

            ////interrupt function call wrapper
            //_tw.WriteLine(getLabelInterruptFunction(funcname) + ":");
            ////压变量, 置零
            //for (int i = 0; i < fi.VarCount; ++i)
            //{
            //    _tw.WriteLine("pushi 0");
            //}
            //_tw.WriteLine("call " + getLabelUserFunction(funcname));
            ////clear stack
            //for (int i = 0; i < fi.VarCount; ++i)
            //{
            //    _tw.WriteLine("popi r7");
            //}
            //_tw.WriteLine("ret");

            //_tw.WriteLine(labskip + ":");
            //base.VisitOn_interrupt_stat(context);
            //_tw.WriteLine("jint " + getLabelInterruptFunction(funcname));
            base.VisitOn_interrupt_stat(context);
            _tw.WriteLine("jint " + getLabelUserFunction(funcname));
            return null;
        }

        public override object VisitFunc_ret(mylParser.Func_retContext context)
        {
            base.VisitFunc_ret(context);
            _tw.WriteLine("popi eax");
            _tw.WriteLine("popi ebp"); //reload ebp
            _tw.WriteLine("ret");
            return null;
        }

        public override object VisitFunc_node(mylParser.Func_nodeContext context)
        {
            base.VisitFunc_node(context);
            _tw.WriteLine("pushi eax");
            return null;
        }

        public override object VisitAddvar_node(mylParser.Addvar_nodeContext context)
        {
            base.Visit(context.var_ref());
            _tw.WriteLine("ldri"); //load var
            _tw.WriteLine("inci");// ++
            _tw.WriteLine("popi r0");// r0=加后的值
            base.Visit(context.var_ref());
            _tw.WriteLine("pushi r0");
            _tw.WriteLine("stri"); //set var=加后的值
            _tw.WriteLine("pushi r0"); //push 加后的值(本表达式返回值)
            return null;
        }

        public override object VisitVaradd_node(mylParser.Varadd_nodeContext context)
        {
            base.Visit(context.var_ref());
            _tw.WriteLine("ldri"); //load var
            _tw.WriteLine("popi r0");// 保存原来的值到r0

            _tw.WriteLine("pushi r0"); //节约一次ldri
            _tw.WriteLine("inci");// ++
            _tw.WriteLine("popi r1");// r1=加后的值
            base.Visit(context.var_ref());
            _tw.WriteLine("pushi r1");
            _tw.WriteLine("stri"); //set var=加后的值

            _tw.WriteLine("pushi r0");  //push 原来的值(本表达式返回值)
            return null;
        }

        public override object VisitSubvar_node(mylParser.Subvar_nodeContext context)
        {
            base.Visit(context.var_ref());
            _tw.WriteLine("ldri"); //load var
            _tw.WriteLine("deci");// --
            _tw.WriteLine("popi r0");// r0=减后的值
            base.Visit(context.var_ref());
            _tw.WriteLine("pushi r0");
            _tw.WriteLine("stri"); //set var=减后的值
            _tw.WriteLine("pushi r0"); //push 减后的值(本表达式返回值)
            return null;
        }

        public override object VisitVarsub_node(mylParser.Varsub_nodeContext context)
        {
            base.Visit(context.var_ref());
            _tw.WriteLine("ldri"); //load var
            _tw.WriteLine("popi r0");// 保存原来的值到r0

            _tw.WriteLine("pushi r0"); //节约一次ldri
            _tw.WriteLine("deci");// --
            _tw.WriteLine("popi r1");// r1=减后的值
            base.Visit(context.var_ref());
            _tw.WriteLine("pushi r1");
            _tw.WriteLine("stri"); //set var=减后的值

            _tw.WriteLine("pushi r0");  //push 原来的值(本表达式返回值)
            return null;
        }

        public override object VisitNumber_expr_node(mylParser.Number_expr_nodeContext context)
        {
            return base.VisitNumber_expr_node(context);
        }

        public override object VisitSelf_addsub_stat(mylParser.Self_addsub_statContext context)
        {
            base.VisitSelf_addsub_stat(context);
            _tw.WriteLine("popi"); //drop返回值
            //_tw.WriteLine("popi r7"); //drop返回值
            return null;
        }

        public override object VisitFor_stat(mylParser.For_statContext context)
        {
            base.Visit(context.sinit);

            LoopInfo li = new LoopInfo();
            li.StartLab = getLabelID();
            li.NextLab = getLabelID();
            li.EndLab = getLabelID();
            _Loop.Push(li);

            _tw.WriteLine(li.StartLab + ":");
            base.Visit(context.number_expr());
            _tw.WriteLine("jf " + li.EndLab);
            base.Visit(context.smain);
            _tw.WriteLine(li.NextLab + ":");
            base.Visit(context.sstep);
            _tw.WriteLine("jmp " + li.StartLab);
            _tw.WriteLine(li.EndLab + ":");
            _Loop.Pop();
            return null;
        }

        public override object VisitBreak_stat(mylParser.Break_statContext context)
        {
            if (_Loop.Count == 0)
            {
                throw new CompileException("is not in loop", context);
            }
            _tw.WriteLine("jmp " + _Loop.Peek().EndLab);
            return null;
        }

        public override object VisitContinue_stat(mylParser.Continue_statContext context)
        {
            if (_Loop.Count == 0)
            {
                throw new CompileException("is not in loop", context);
            }
            _tw.WriteLine("jmp " + _Loop.Peek().NextLab);
            return null;
        }

    }
}
