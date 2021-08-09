using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEV.Models
{
    public class LogomarcaModel : tb_logomarca
    {
        public tb_logomarca tb_logomarca { get; set; }
        public string JsonLTLogomarca { get; set; }
    }
    public class tb_logomarca
    {
        public int CodigoLogomarca { get; set; }    
        public string Caminho { get; set; }
    }
}
