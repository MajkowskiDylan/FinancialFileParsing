using SwiftParsing.Interfaces;
using SwiftParsing.Models;
using SwiftParsing.Utils;
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
            switch (columnName)
            {
                case StringConstants.colReference: _holding._reference = columnValue;
                    break;
                case StringConstants.colSens: _holding._sens = char.Parse(columnValue);
                    break;
                case StringConstants.colCurrencyCode: _holding._currencyCode = columnValue;
                    break;
                case StringConstants.colAmount: _holding._amount = columnValue;
                    break;
                case StringConstants.colCashAccount: _holding._cashAccount = columnValue;
                    break;
                case StringConstants.colPreviousBalanceSens: _holding._previousBalanceSens = columnValue;
                    break;
                case StringConstants.colPreviousBalanceAmount: _holding._previousBalanceAmount = columnValue;
                    break;
                default: throw new Exception($"Couldn't set string value '{columnValue}' to holding column.");
            }
        }

        public void Build(string columnName, DateTime columnValue)
        {
            throw new NotImplementedException();
        }
    }
}
