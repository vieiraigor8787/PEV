using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEV.Models
{
    public class produtosubcategoriaModel : tb_produto_subcategoria
    {
        public string Descricao { get; set; }
    }
    public class tb_produto_subcategoria
    {
        public int CodigoSubCategoria { get; set; }
        public int CodigoProduto { get; set; }
    }
}
