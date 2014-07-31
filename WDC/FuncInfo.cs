using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLanguage
{
    class FuncInfo
    {
        public int ParamsCount, VarCount;
        public int VarRelAddress, ParamRelAddress;
        public bool defined = false;

        public FuncInfo(int ParamsCount, int VarCount)
        {
            this.ParamsCount = ParamsCount;
            this.VarCount = VarCount;
            VarRelAddress = -2; //ebp-0:保存的之前的ebp, ebp-1:保存的eip
            ParamRelAddress = VarRelAddress - VarCount; 
            /*调用函数时, 先压入参数, 然后压入定义的变量, 这样, 参数的起始地址是已知的, 参数个数未知,
             * 可以传递任意数量的参数。
             * 调用方清栈。
             * 返回值存放eax中。
             * 类似于cdecl
             * */
        }
    }
}
