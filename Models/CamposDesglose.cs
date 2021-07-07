using System;
using System.Collections.Generic;

namespace ConsultaEstadosLogalty.Models
{
    public partial class CamposDesglose
    {
        public int IdDetalleConciliacion { get; set; }
        public int IdProcesoConciliacion { get; set; }
        public string GuId { get; set; }
        public string EstadoActualTransaccion { get; set; }
        public string BinaryContenGroupId { get; set; }
        public string EstadoActualGrupo { get; set; }
        public string ResultadoActualGrupo { get; set; }
        public DateTime? FechaFirma { get; set; }
        public int? IdFirma { get; set; }
        public string ComentariosFirma { get; set; }
        public int? RstadoFirma { get; set; }
        public string ResultadoFirma { get; set; }
        public string ComentarioAutorizador { get; set; }
    }
}
