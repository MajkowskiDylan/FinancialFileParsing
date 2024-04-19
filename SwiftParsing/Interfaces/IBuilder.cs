using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftParsing.Interfaces
{
    interface IBuilder
    {
        void Build(string columnName, string columnValue);
        void Build(string columnName, DateTime columnValue);
    }
}
