using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftParsing.Interfaces
{
    interface ITagStrategy
    {
        public void ExecuteStrategy(IBuilder builder, string line);
    }
}
