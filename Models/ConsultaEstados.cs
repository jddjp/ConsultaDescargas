using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsultaEstadosLogalty.Models
{
    class ConsultaEstados
    {
        [Key]
        public int CodigoRespuesta { get; set; }
        public string DescRespuesta { get; set; }
      
    }
}
