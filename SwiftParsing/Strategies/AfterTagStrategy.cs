using SwiftParsing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftParsing.Strategies
{
    class AfterTagStrategy : Tag, ITagStrategy
    {
        private string _columnName;
        public AfterTagStrategy(string prefix, string columnName) : base(prefix) => _columnName = columnName;

        public void ExecuteStrategy(IBuilder builder, string line) => builder.Build(_columnName, line[_prefix.Length..]);
    }
}
