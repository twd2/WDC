using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyLanguage
{
    class Program
    {
        static StartupArgs _StartupArgs;

        static void PrintUsage()
        {
            Console.WriteLine("Usage: MyLanguage -ilop\r\n" +
                "    -i, --input=?:\t\tInput file name, \"-\" for standard input\r\n" +
                "    -l, --inclib, --include=?:\tInclude library\r\n" +
                "    -o, --output=?:\t\tOutput file name, \"-\" for standard output\r\n" +
                "    -p, --includepath=?:\tPath to search included file");
        }

        static void Main(string[] args)
        {
            try
            {
                _StartupArgs = StartupArgs.Parse(args);
            }
            catch (ArgumentException)
            {
                PrintUsage();
                return;
            }
            Stream inputStream = null, outputStream = null;
            if (_StartupArgs.InputFilename !="")
            {
                if(_StartupArgs.InputFilename=="-")
                {
                    inputStream = Console.OpenStandardInput();
                }
                else
                {
                    inputStream = new FileStream(_StartupArgs.InputFilename, FileMode.Open, FileAccess.Read);
                }
            }
            if (_StartupArgs.OutputFilename != "")
            {
                if (_StartupArgs.OutputFilename == "-")
                {
                    outputStream = Console.OpenStandardOutput();
                }
                else
                {
                    outputStream = new FileStream(_StartupArgs.OutputFilename, FileMode.Create, FileAccess.Write);
                }
            }
            if (inputStream != null && outputStream != null)
            {
                Console.WriteLine("Compiling...");
                StreamReader sr = new StreamReader(inputStream, Encoding.UTF8);
                StreamWriter sw = new StreamWriter(outputStream, Encoding.UTF8);

                string src = sr.ReadToEnd();
                try
                {
                    string asmsrc = Compile(_StartupArgs.InputFilename);
                    sw.Write(asmsrc);
                    sw.Flush();
                    outputStream.Flush();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("OK");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (CompileException ex)
                {
                    ex.Print();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Failed");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                }

                if (inputStream != null)
                {
                    inputStream.Close();
                }
                if (outputStream != null)
                {
                    outputStream.Close();
                }
            }
        }

        static string Compile(string filename)
        {
            StringWriter sw = new StringWriter();

            Preprocesser pp = new Preprocesser(_StartupArgs);
            pp.Preprocess(filename);

            Dictionary<string, FuncInfo> _Function_Dec = new Dictionary<string, FuncInfo>();
            pp.SortSourceFile();

            for (int i = 0; i < pp._SourceFile.Count; ++i)
            {
                Console.WriteLine("Compiling {0}", pp._SourceFile[i].filename);
                Visitor v = new Visitor(sw, _Function_Dec, i == 0, i == pp._SourceFile.Count - 1, i);
                AntlrInputStream s = new AntlrInputStream(pp._SourceFile[i].code);
                mylLexer lexer = new mylLexer(s);
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                mylParser parser = new mylParser(tokens);
                IParseTree tree = parser.prog();
                v.Visit(tree);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < _Function_Dec.Count; ++i)
            {
                if (!_Function_Dec.Values.ElementAt(i).defined)
                {
                    Console.WriteLine("Warning: function {0} is declared but not undefined, may cause AssemblerException", _Function_Dec.Keys.ElementAt(i));
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            return sw.ToString();
        }
    }
}
