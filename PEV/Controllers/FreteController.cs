using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEV.Data;
using PEV.Models;
using Microsoft.AspNetCore.Http;
using PEV.Classes;
using Microsoft.AspNetCore.Authorization;

namespace PEV.Controllers
{
    public class FreteController : Controller
    {

        private readonly IHttpContextAccessor _hCont;

        public FreteController(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
        }

        [Authorize(Roles = "A")]
        public IActionResult Index()
        {

            FreteDB Ft = new FreteDB();
            var MLista = Ft.FreteDados();
           

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View(MLista);
        }

        [Authorize(Roles = "A")]
        public IActionResult CadastroFreteDados()
        {
            ViewData["Valida"] = "";

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View();
        }

        [Authorize(Roles = "A")]
        public IActionResult Excluir(int IdFrete)
        {
            FreteDB Pg = new FreteDB();
            Pg.ExcluirDados(IdFrete);
            return RedirectToAction("index", "Frete");
        }

        [Authorize(Roles = "A")]
        public IActionResult Editar(int IdFrete, string CEP)
        {
            var model = new tb_frete_dados();
            model.IdFrete = IdFrete;
            model.CEP = CEP;
            ViewData["Valida"] = "";
            return View("CadastroFreteDados", model);
        }

       // [Authorize(Roles = "A")]
        public IActionResult Salvar(tb_frete_dados obj)
        {

            FreteDB Pg = new FreteDB();

            if(obj.IdFrete == 0)
            {
                if (Pg.InserirDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Dados inseridos com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir dados!</div>";
                }
            }
            else
            {
                if (Pg.UpDateDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Dados atualizados com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar dados!</div>";
                }
            }
            return View("CadastroFreteDados");
        }

    }
}
