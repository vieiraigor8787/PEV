﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PEV.Models
{
    public class tb_genero
    {
        public int CodigoGenero { get; set; }
        [Display(Name = "Descrição", Prompt = "")]
        public string Descricao { get; set; }
    }
}

