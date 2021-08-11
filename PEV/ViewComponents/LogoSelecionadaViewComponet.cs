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
    [ViewComponent(Name = "Logo")]
    public class LogoSelecionadaViewComponet : ViewComponent
    {
        public List<tb_logomarca> Logo { get; set; }


        public LogoSelecionadaViewComponet()
        {
            var Img = new LogoDB();
            Logo = Img.LogoMarca();

            
        }
        public async Task<IViewComponentResult>InvokeAsync()
        {
            return View(Logo);
        }
    }
}
