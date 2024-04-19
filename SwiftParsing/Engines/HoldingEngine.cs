using SwiftParsing.Builder;
using SwiftParsing.Interfaces;
using SwiftParsing.Models;
using System.Collections.Generic;

namespace SwiftParsing.Engines
{
    abstract class HoldingEngine
    {
        protected bool _isTransactionEngine = false;
        protected ITagStrategy _currentStrategy;
        protected List<Holding> _holdings = new();

        public List<Holding> Run()
        {
            HoldingBuilder hb = new();
            var engine = GetMtEngine();
            var records = engine.GetRecords();
            var strategies = GetStrategies();
            records.ForEach((line) => ProcessLine(line, strategies, hb));

            return _holdings;
        }

        protected void ProcessLine(string line, Dictionary<string, ITagStrategy> strategies, HoldingBuilder hb)
        {
            var foundTag = false;

            // New holding.
            if (line.StartsWith("-}"))
            {
                _holdings.Add(hb.GetHolding());
                hb.CreateHolding();
            }
            else
            {
                foreach (var s in strategies)
                {
                    foundTag = true;
                    SetStrategy(strategies[s.Key]);
                    hb.SetHolding(strategies[s.Key], line);

                    if (foundTag)
                        break;
                }
            }
        }

        public void SetStrategy(ITagStrategy strategy) => this._currentStrategy = strategy;
        protected abstract IEngine GetMtEngine();
        protected abstract Dictionary<string, ITagStrategy> GetStrategies();
    }
}
