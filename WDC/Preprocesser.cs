using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyLanguage
{
    class Preprocesser
    {
        private StartupArgs _StartupArgs;
        public List<string> _includedFilename = new List<string>();
        public List<SourceFile> _SourceFile = new List<SourceFile>();

        public Preprocesser(StartupArgs sa)
        {
            this._StartupArgs = sa;
        }

        public void SortSourceFile()
        {
            _SourceFile.Sort();
        }

        private void include(string filename)
        {
            Console.WriteLine("Including {0}", filename);
            Preprocess(filename);
        }

        public void Preprocess(string filename)
        {
            if (_includedFilename.IndexOf(filename) >= 0)
            {
                Console.WriteLine("Included {0}", filename);
                return;
            }
            Console.WriteLine("Preprocessing {0}", filename);
            string basepath = new FileInfo(filename).DirectoryName;
            SourceFile sf = new SourceFile(filename);
            _SourceFile.Add(sf);
            _includedFilename.Add(filename);

            StringBuilder newcodesb = new StringBuilder();
            //string filename;
            for (int i = 0; i < _StartupArgs.LibInclude.Count; ++i)
            {
                include(Path.Combine(_StartupArgs.IncludePath, _StartupArgs.LibInclude[i] + ".h"));
            }
            string[] lns = sf.code.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            for (int i = 0; i < lns.Length; ++i)
            {
                if (lns[i].Trim().StartsWith("#"))
                {
                    string cmddata = lns[i].Trim().Substring(1);
                    string cmd = "", data = "";
                    int index = cmddata.IndexOf(' ');
                    if (index >= 0)
                    {
                        cmd = cmddata.Substring(0, index).Trim();
                        data = cmddata.Substring(index + 1).Trim();
                    }
                    else
                    {
                        cmd = cmddata;
                    }

                    switch (cmd)
                    {
                        case "inc":
                        case "inclib":
                            include(Path.Combine(_StartupArgs.IncludePath, data + ".h"));
                            break;
                        case "incfile":
                            include(Path.Combine(basepath, data));
                            break;
                        default:
                            throw new Exception("Invaild preprocess command");
                            //break;
                    }
                    newcodesb.AppendLine();
                }
                else
                {
                    newcodesb.AppendLine(lns[i]);
                }
            }
            sf.code = newcodesb.ToString();
            //return sb.ToString();
        }

    }
}
