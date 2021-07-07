using System;
using System.Collections.Generic;

namespace ConsultaEstadosLogalty.Models
{
    public partial class ControlFirmaEnvio
    {
        public int PkControlFirmaEnvio { get; set; }
        public string Pagare { get; set; }
        public int? NumEnvio { get; set; }
        public string Guid { get; set; }
    }
}
