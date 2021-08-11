using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEV.Models
{
    public class PagamentoModel : tb_pagamento_dados
    {
        public tb_pagamento_dados tb_pagamento { get; set; }
    }
    public class tb_pagamento_dados
    {
        public int IdPagamento { get; set; }    
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
