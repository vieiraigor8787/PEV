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
    [ViewComponent(Name = "Categorias")]
    public class CategoriasViewComponet : ViewComponent
    {
        public List<tb_categoria> ItensCategorias { get; set; }


        public CategoriasViewComponet()
        {
            var MLista = new CategoriaDB();
            ItensCategorias = MLista.GetAllCategoria();
            
        }
        public async Task<IViewComponentResult>InvokeAsync()
        {
            return View(ItensCategorias);
        }
    }
}
