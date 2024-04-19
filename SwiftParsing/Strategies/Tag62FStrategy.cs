using SwiftParsing.Interfaces;
using SwiftParsing.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftParsing.Strategies
{
    class Tag62FStrategy : Tag, ITagStrategy
    {
        public Tag62FStrategy(string prefix) : base(prefix)
        {
        }

        public void ExecuteStrategy(IBuilder builder, string line)
        {
            var index = 5;
            var sens = line.Substring(index, 1);
            index++;

            var stringDate = line.Substring(index, 6);
            var sYear = stringDate[..2];
            var sMonth = stringDate.Substring(2, 2);
            var sDay = stringDate.Substring(4, 2);
            var iYear = int.Parse(sYear, CultureInfo.InvariantCulture) + 2000;
            var iMonth = int.Parse(sMonth, CultureInfo.InvariantCulture);
            var iDay = int.Parse(sDay, CultureInfo.InvariantCulture);
            DateTime aDate = new(iYear, iMonth, iDay);

            index += 6;
            var currency = line.Substring(index, 3);
            index += 3;
            var amount = line[index..];

            builder.Build(StringConstants.colSens, sens);
            builder.Build(StringConstants.colStatementDate, aDate);
            builder.Build(StringConstants.colCurrencyCode, currency);
            builder.Build(StringConstants.colAmount, amount);
        }
    }
}
