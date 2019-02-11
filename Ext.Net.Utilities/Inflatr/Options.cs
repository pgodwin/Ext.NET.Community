using System;
using System.Collections.Generic;
using System.Text;

namespace Ext.Net.Utilities.Inflatr
{
    public class Options
    {
        private int wrap = 80;
        public int Wrap
        {
            get
            {
                return this.wrap;
            }
            set
            {
                this.wrap = value;
            }
        }

        private string indent = "  ";
        public string Indent
        {
            get
            {
                return this.indent;
            }
            set
            {
                this.indent = value;
            }
        }

        private int level = 0;
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }

        public Options Clone()
        {
            return new Options { Indent = this.Indent, Wrap = this.Wrap, Level = this.Level };
        }
    }
}
