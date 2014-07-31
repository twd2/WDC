using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyLanguage
{
    class SourceFile : IComparable<SourceFile>
    {
        public string filename, code;

        public SourceFile(string filename)
        {
            this.filename = filename;
            code = File.ReadAllText(filename);
        }

        public int CompareTo(SourceFile b)
        {
            if (this == null && b == null)
            {
                return 0;
            }
            if (this != null && b == null)
            {
                return 1;
            }
            if (this == null && b != null)
            {
                return -1;
            }
            if (!this.filename.EndsWith(".h") && !b.filename.EndsWith(".h"))
            {
                return 0;
            }
            if (!this.filename.EndsWith(".h") && b.filename.EndsWith(".h"))
            {
                return 1;
            }
            if (this.filename.EndsWith(".h") && !b.filename.EndsWith(".h"))
            {
                return -1;
            }
            return 0;
        }
    }
}
