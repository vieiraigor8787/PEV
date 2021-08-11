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
    public class PagamentoController : Controller
    {

        private readonly IHttpContextAccessor _hCont;

        public PagamentoController(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
        }

        [Authorize(Roles = "A")]
        public IActionResult Index()
        {
            PagamentoDB Pg = new PagamentoDB();
            var MLista = Pg.PagamentoDados();
           

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View(MLista);
        }

        [Authorize(Roles = "A")]
        public IActionResult CadastroPagamentoDados()
        {
            ViewData["Valida"] = "";

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View();
        }

        [Authorize(Roles = "A")]
        public IActionResult Excluir(int IdPagamento)
        {
            PagamentoDB Pg = new PagamentoDB();
            Pg.ExcluirDados(IdPagamento);
            return RedirectToAction("index", "Pagamento");
        }

        [Authorize(Roles = "A")]
        public IActionResult Editar(int IdPagamento, string Email, string Token)
        {
            var model = new tb_pagamento_dados();
            model.IdPagamento = IdPagamento;
            model.Email = Email;
            model.Token = Token;
            ViewData["Valida"] = "";
            return View("CadastroPagamentoDados", model);
        }

       // [Authorize(Roles = "A")]
        public IActionResult Salvar(tb_pagamento_dados obj)
        {
            //string smgvalida = Validar(obj);
            //if(smgvalida != "")
            //{
            //    ViewData["Valida"] = smgvalida;
            //    return View("CadastroGenero");
            //}

            PagamentoDB Pg = new PagamentoDB();

            if(obj.IdPagamento == 0)
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
            return View("CadastroPagamentoDados");
        }

    }
}
