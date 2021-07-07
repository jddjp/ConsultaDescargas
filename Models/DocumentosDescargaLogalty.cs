using System;
using System.Collections.Generic;

namespace ConsultaEstadosLogalty.Models
{
    public partial class DocumentosDescargaLogalty
    {
        public string Pagare { get; set; }
        public string Guid { get; set; }
        public byte[] Documento { get; set; }
    }
}
