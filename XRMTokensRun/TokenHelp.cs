using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XRMTokensRun
{
    internal class TokenHelp
    {
        internal string name { get; }
        internal string content { get; }
        internal int cursorpos { get; }
        internal int sellength { get; }
        internal string help { get; }
        internal string url { get; }

        public TokenHelp(string name, string content, int cursorpos, int sellength, string help, string url)
        {
            this.name = name;
            this.content = content;
            this.cursorpos = cursorpos;
            this.sellength = sellength;
            this.help = help;
            this.url = url;
        }

        public override string ToString()
        {
            return name;
        }
    }
}