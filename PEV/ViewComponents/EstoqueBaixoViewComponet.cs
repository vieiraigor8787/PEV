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
    [ViewComponent(Name = "EstoqueBaixo")]
    public class EstoqueBaixoViewComponet : ViewComponent
    {
        public bool EstoqueBaixo { get; set; }


        public EstoqueBaixoViewComponet()
        {
            var MLista = new ProdutoDB();
            EstoqueBaixo = MLista.ValidaEstoque();


        }
        public async Task<IViewComponentResult>InvokeAsync()
        {
            return View(EstoqueBaixo);

        }
    }
}
