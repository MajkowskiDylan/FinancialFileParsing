using SwiftParsing.Interfaces;
using SwiftParsing.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftParsing.Engines
{
    class MT941Engine : HoldingEngine,  IEngine
    {
        protected string _mtKey;
        protected List<string> _fileRecords;
        protected Dictionary<string, ITagStrategy> _strategies;

        public MT941Engine(List<string> filesRecords)
        {
            _mtKey = StringConstants.MT941;
            _fileRecords = filesRecords;
            _strategies = FileStrategies.strategies941;
        }

        public List<string> GetRecords()
        {
            throw new NotImplementedException();
        }

        protected override IEngine GetMtEngine()
        {
            throw new NotImplementedException();
        }

        protected override Dictionary<string, ITagStrategy> GetStrategies()
        {
            throw new NotImplementedException();
        }
    }
}
