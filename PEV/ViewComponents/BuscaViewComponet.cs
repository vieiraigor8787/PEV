using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using PEV.Classes;
using PEV.Data;
using PEV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEV.ViewComponents
{
    [ViewComponent(Name = "Busca")]
    public class BuscaViewComponet : ViewComponent
    {
        public tb_produto ItensBusca { get; set; }


        public BuscaViewComponet()
        {
            var palavra = new tb_produto();
            ItensBusca = palavra ;
            
        }
        public async Task<IViewComponentResult>InvokeAsync()
        {
            return View(ItensBusca);
        }
    }
}
