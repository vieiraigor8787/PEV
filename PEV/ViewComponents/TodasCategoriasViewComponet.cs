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
    [ViewComponent(Name = "TodasCategorias")]
    public class TodasCategoriasViewComponet : ViewComponent
    {
        public class ListaCompleta
        {
            public string Categoria { get; set; }
            public List<string> Sub { get; set; }
        }

        public List<tb_categoria> ItensCategorias { get; set; }


        public TodasCategoriasViewComponet()
        {
            var MLista = new CategoriaDB();
            ItensCategorias = MLista.GetAllCategoria();
        }


        public async Task<IViewComponentResult>InvokeAsync()
        {
            var ListaCompleta = new List<ListaCompleta>();

            CategoriaDB Subc = new CategoriaDB();
            foreach (var a in ItensCategorias)
            {
                var ltc = new ListaCompleta();
                var ltsub = new List<string>();

                var sub = Subc.GetAllCategoriaSub(a.CodigoCategoria);

                foreach (var item in sub)
                {
                    ltc.Categoria = a.Descricao;
                    ltsub.Add(item.Nome);
                }

                ltc.Sub = ltsub;

                ListaCompleta.Add(ltc);

            }
            return View(ListaCompleta);
        }
    }
}
