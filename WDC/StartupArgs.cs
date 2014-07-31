using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLanguage
{
    class StartupArgs
    {
        public string IncludePath = "lib";
        public string InputFilename = "";
        public string OutputFilename = "";
        public List<string> LibInclude = new List<string>();

        public static StartupArgs Parse(string[] args)
        {
            if (args.Length == 0)
            {
                throw new ArgumentException("No Arg");
            }
            StartupArgs sa = new StartupArgs();
            for (int i = 0; i < args.Length; ++i)
            {
                string arg = args[i];
                if (arg.StartsWith("--"))
                {
                    switch (arg.Substring(2).ToLower())
                    {
                        case "input":
                            if (i + 1 < args.Length)
                            {
                                sa.InputFilename = args[i + 1];
                                ++i;
                            }
                            break;
                        case "includepath":
                            if (i + 1 < args.Length)
                            {
                                sa.IncludePath = args[i + 1];
                                ++i;
                            }
                            break;
                        case "output":
                            if (i + 1 < args.Length)
                            {
                                sa.OutputFilename = args[i + 1];
                                ++i;
                            }
                            break;
                        case "inclib":
                        case "include":
                            if (i + 1 < args.Length)
                            {
                                sa.LibInclude.Add(args[i + 1]);
                                ++i;
                            }
                            break;
                        default:
                            throw new ArgumentException("Wrong Arg \"" + arg + "\"");
                            //break;
                    }
                }
                else if (arg.StartsWith("-"))
                {
                    for (int j = 1; j < arg.Length; ++j)
                    {
                        char ch = arg.ToLower()[j];
                        switch (ch)
                        {
                            case 'i':
                                if (i + 1 < args.Length)
                                {
                                    sa.InputFilename = args[i + 1];
                                    ++i;
                                }
                                break;
                            case 'p':
                                if (i + 1 < args.Length)
                                {
                                    sa.IncludePath = args[i + 1];
                                    ++i;
                                }
                                break;
                            case 'o':
                                if (i + 1 < args.Length)
                                {
                                    sa.OutputFilename = args[i + 1];
                                    ++i;
                                }
                                break;
                            case 'l':
                                if (i + 1 < args.Length)
                                {
                                    sa.LibInclude.Add(args[i + 1]);
                                    ++i;
                                }
                                break;
                            default:
                                throw new ArgumentException("Wrong Arg \"" + arg + "\"");
                                //break;
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Wrong Arg \"" + arg + "\"");
                }
            }
            return sa;
        }

    }
}
