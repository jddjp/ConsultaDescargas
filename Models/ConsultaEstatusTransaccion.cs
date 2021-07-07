using System;
using System.Collections.Generic;

namespace ConsultaEstadosLogalty.Models
{
    public partial class ConsultaEstatusTransaccion
    {
        public int PkConsultaEstatusTransaccion { get; set; }
        public string CancelCode { get; set; }
        public string CancelReason { get; set; }
        public string Comment { get; set; }
        public string ExternalId { get; set; }
        public string Guid { get; set; }
        public string Result { get; set; }
        public string SubstateComment { get; set; }
        public string SubstateDate { get; set; }
        public string SubstateValue { get; set; }
        public string Value { get; set; }
    }
}
