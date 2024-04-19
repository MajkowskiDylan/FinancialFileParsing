using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftParsing.Models
{
    public class Holding
    {
        public string _mt { get; set; }
        public string _reference { get; set; }
        public char _sens { get; set; }
        public DateTime _statementDate { get; set; }
        public string _currencyCode { get; set; }
        public string _amount { get; set; }
        public string _cashAccount { get; set; }   
        public char _previousBalanceStatementDate { get; set; }
        public string _previousBalanceAmount { get; set; }
    }
}
