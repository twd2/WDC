using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLanguage
{

    enum VarType
    {
        abs, //绝对地址
        rel //相对ebp地址
    }

    class VarInfo
    {
        VarType Type = 0;
        int Address = 0;

        public VarInfo(VarType Type, int Address)
        {
            this.Type = Type;
            this.Address = Address;
        }

        ~VarInfo ()
        {

        }

        public string getAbsAddress()
        {
            StringBuilder sb = new StringBuilder();
            switch (Type)
            {
                case VarType.abs:
                    sb.AppendLine("pushi " + Address.ToString());  //Address
                    break;
                case VarType.rel:
                    sb.AppendLine("pushi ebp");
                    sb.AppendLine("pushi " + Address.ToString());
                    sb.AppendLine("addi"); //Address+ebp
                    break;
                default:
                    break;
            }
            return sb.ToString();
        }

    }
}
