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
    [ViewComponent(Name = "Subcategorias")]
    public class SubcategoriasViewComponet : ViewComponent
    {
        public List<tb_subcategoria> ItensCategorias { get; set; }


        public SubcategoriasViewComponet()
        {
            var MLista = new SubCategoriaDB();
            ItensCategorias = MLista.GetAllSubCategoria();
            
        }
        public async Task<IViewComponentResult>InvokeAsync()
        {
            return View(ItensCategorias);
        }
    }
}
