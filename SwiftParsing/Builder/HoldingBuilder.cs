using SwiftParsing.Interfaces;
using SwiftParsing.Models;
using System;

namespace SwiftParsing.Builder
{
    class HoldingBuilder: IBuilder
    {
        private Holding _holding;
        public HoldingBuilder() => this.Reset();
        public void Reset() => this._holding = new Holding();
        public Holding GetHolding() => _holding;
        public void SetHolding(ITagStrategy strategy, string line) => strategy.ExecuteStrategy(this, line);
        public Holding CreateHolding()
        {
            Holding holding = this._holding;
            this.Reset();

            return holding;
        }
        public void Build(string columnName, string columnValue)
        {
            throw new NotImplementedException();
        }

        public void Build(string columnName, DateTime columnValue)
        {
            throw new NotImplementedException();
        }
    }
}
