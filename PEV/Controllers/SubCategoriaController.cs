using PEV.Data;
using PEV.Models;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using PEV.Classes;

namespace PEV.Controllers
{
    public class SubCategoriaController : Controller
    {

        private readonly IHttpContextAccessor _hCont;

        public SubCategoriaController(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
        }

        public IActionResult Index()
        {
            SubCategoriaDB Cat = new SubCategoriaDB();
            var MLista = Cat.GetAllSubCategoria();
            return View(MLista);
        }

        public IActionResult SubcategoriasMenu(int CodigoSubCategoria)
        {

            SubCategoriaDB Prod = new SubCategoriaDB();
            var resp = Prod.GetProdutoVWListSubcategoria(CodigoSubCategoria);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            var _Carrinho = new CarrinhoController(_hCont);
            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            return View(resp);
        }

        public IActionResult CadastroSubCategoria()
        {

            ViewData["Valida"] = "";
            ProdutoDB Cat = new ProdutoDB();
            ViewData["LTCat"] = Cat.GetCategoria();

            return View();
        }

        public IActionResult Desativar(int codigocategoria)
        {
            SubCategoriaDB Cat = new SubCategoriaDB();
            Cat.ExcluirDados(codigocategoria);
            return RedirectToAction("index", "subcategoria");
        }

        public IActionResult Editar(int CodigoSubCategoria, string Descricao)
        {
            var model = new tb_subcategoria();
            model.CodigoSubCategoria = CodigoSubCategoria;
            model.Nome = Descricao;
            ViewData["Valida"] = "";
            return View("CadastroSubCategoria", model);
        }
        public IActionResult Salvar(tb_subcategoria obj)
        {
            string smgvalida = Validar(obj);
            if (smgvalida != "")
            {
                ViewData["Valida"] = smgvalida;
                return View("CadastroSubcategoria");
            }

            SubCategoriaDB Cat = new SubCategoriaDB();

            if (obj.CodigoSubCategoria == 0)
            {

                if (Cat.InserirDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Sub-Categoria inserida com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir Categoria!</div>";
                }
            }
            else
            {
                if (Cat.UpdateDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Sub-Categoria atualizada com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Sub-Categoria!</div>";
                }

            }
                return View("cadastrosubcategoria");
        }

        public string Validar(tb_subcategoria obj)
        {

            SubCategoriaDB Cat = new SubCategoriaDB();

            if (String.IsNullOrEmpty(obj.Nome))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Digite o nome da categoria</div>";
            }

            if (Cat.ValidarNome(obj))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Categoria já cadastradoa!</div>";
            }

            return "";
        }
    }
}
