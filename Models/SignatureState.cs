using System;
using System.Collections.Generic;

namespace ConsultaEstadosLogalty.Models
{
    public partial class SignatureState
    {
        public int Result { get; set; }
        public string SubstateDate { get; set; }
        public int RuleId { get; set; }
        public int SubstateValue { get; set; }
        public int Value { get; set; }
        public string ResultDate { get; set; }
        public string Date { get; set; }
        public string SubstateComment { get; set; }
        public string Comment { get; set; }
        public int ReceiverId { get; set; }
        public string RejectReason { get; set; }
    }
}
