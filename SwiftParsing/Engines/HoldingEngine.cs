using SwiftParsing.Interfaces;
using SwiftParsing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftParsing.Engines
{
    abstract class HoldingEngine
    {
        protected bool _isTransactionEngine = false;
        protected ITagStrategy _currentStrategy;
        protected List<Holding> _holdings = new();
    }
}
