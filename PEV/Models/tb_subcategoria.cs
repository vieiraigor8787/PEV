using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PEV.Models
{
    public class tb_subcategoria
    {
        public int CodigoSubCategoria { get; set; }
        public string Nome { get; set; }
        public string Ativo { get; set; }

        [Display(Name = "Gostaria que essa subcategoria apareça no menu principal?", Prompt = "")]
        public string Menu { get; set; }

        public string JsonLTCategoria { get; set; }
    }

}

