using System;
using System.Collections.Generic;

namespace ConsultaEstadosLogalty.Models
{
    public partial class DocumentoFirmaEnvio
    {
        public int PkIdArchivo { get; set; }
        public string IdCredi { get; set; }
        public DateTime? FechaDocumento { get; set; }
        public string NombreArchivo { get; set; }
        public string Archivo { get; set; }
        public int? Estatus { get; set; }
        public string Pagare { get; set; }
    }
}
