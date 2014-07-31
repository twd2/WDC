using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLanguage
{
    class CompileException: Exception 
    {
        public Antlr4.Runtime.ParserRuleContext context;

        public CompileException(string msg, Antlr4.Runtime.ParserRuleContext context)
            : base(msg)
        {
            this.context = context;
        }

        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Compile Error: {0}", Message);
            Console.ForegroundColor = ConsoleColor.Gray;
            if (context != null)
            {

                Console.WriteLine("In line {0}: {1}",
                    context.start.Line == context.stop.Line ? context.start.Line.ToString() : context.start.Line.ToString() + "~" + context.stop.Line.ToString(),
                    context.GetText());
            }
        }
    }
}
