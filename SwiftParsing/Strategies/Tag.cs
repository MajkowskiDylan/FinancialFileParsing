using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftParsing.Strategies
{
    public abstract class Tag
    {
        protected string _prefix;
        protected Tag(string prefix) => _prefix = prefix;
    }
}
