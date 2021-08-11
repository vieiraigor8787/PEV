using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEV.Models
{
    public class FreteModel : tb_pagamento_dados
    {
        public tb_frete_dados tb_pagamento { get; set; }
    }
    public class tb_frete_dados
    {
        public int IdFrete { get; set; }    
        public string CEP { get; set; }
    }
}
