using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRMTokensRun
{
    internal class TokenHelp
    {
        internal string name { get; }
        internal string content { get; }
        internal int cursorpos { get; }
        internal int sellength { get; }

        public TokenHelp(string name, string content, int cursorpos, int sellength)
        {
            this.name = name;
            this.content = content;
            this.cursorpos = cursorpos;
            this.sellength = sellength;
        }

        public override string ToString()
        {
            return name;
        }
    }
}