using SwiftParsing.Interfaces;
using SwiftParsing.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftParsing.Utils
{
    class FileStrategies
    {
        public static readonly Dictionary<string, ITagStrategy> strategies941 = new()
        {
            { StringConstants.tag25slash, new AfterTagStrategy(StringConstants.tag25slash, StringConstants.colCashAccount) },
            { StringConstants.tag62F, new Tag62FStrategy(StringConstants.tag62F) },
            { StringConstants.tag64, new Tag64Strategy(StringConstants.tag64) },
            { StringConstants.tag20, new AfterTagStrategy(StringConstants.tag20, StringConstants.colReference) }
        };
    }
}
