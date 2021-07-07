using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsultaEstadosLogalty.Models
{
    public partial class State
    {
        [Key]
        public int CodigoRespuesta { get; set; }
        public string DescRespuesta { get; set; }
    }
}
