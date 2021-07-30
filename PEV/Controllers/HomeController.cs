﻿using PEV.Classes;
using PEV.Data;
using PEV.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MSAP.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PEV.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpContextAccessor _hCont;

        private readonly ILogger<HomeController> _logger;

        private readonly CarrinhoController _Carrinho;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _hCont = httpContextAccessor;
            _Carrinho = new CarrinhoController(_hCont);
        }


        public IActionResult Index()
        {

            ProdutoDB Prod = new ProdutoDB();
            var resp = Prod.GetProdutoVWList();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);


            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;


            return View(resp);
        }

        public IActionResult Infantil()
        {

            ProdutoDB Prod = new ProdutoDB();
            var resp = Prod.GetProdutoVWListInfantil();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            return View(resp);
        }

        public IActionResult CategoriasMenu(string Descricao)
        {

            ProdutoDB Prod = new ProdutoDB();
            var resp = Prod.GetProdutoVWListCategoria(Descricao);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            return View(resp);
        }

        public IActionResult Busca(tb_produto obj)
        {

            ProdutoDB Prod = new ProdutoDB();
            var resp = Prod.GetProdutoVWListBusca(obj.Nome);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            return View(resp);
        }

        public IActionResult Masculino()
        {

            ProdutoDB Prod = new ProdutoDB();
            var resp = Prod.GetProdutoVWListMasculino();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            return View(resp);
        }

        public IActionResult Feminino()
        {

            ProdutoDB Prod = new ProdutoDB();
            var resp = Prod.GetProdutoVWListFeminino();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            return View(resp);
        }

        public IActionResult Carrinho()
        {
            CarrinhoController car = new CarrinhoController(_hCont);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            ViewData["Carrinho"] = car.GetAll();

            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c=>c.Quantidade) : 0;

            return View();
        }

        public IActionResult ProdutoDetail(int id)
        {
            ProdutoDB Produto = new ProdutoDB();
            var resp = Produto.GetProdutoView(id);

            CarrinhoController car = new CarrinhoController(_hCont);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            ViewData["ListTamanhoProd"] = Produto.GetTamanhoProduto(id);
            ViewData["Carrinho"] = car.GetAll();

            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            return View(resp);
        }

        public IActionResult GetQuantidadeProduto(int id) { 
            ProdutoDB Produto = new ProdutoDB();
            var resp = Produto.GetQtdProduto(id);
            return Json(new { result= resp });
        }

        public async Task<IActionResult> Finalizar()
        {            

            CarrinhoController car = new CarrinhoController(_hCont);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            ViewData["Carrinho"] = car.GetAll();

            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            if (ViewData["NomeLogin"] == "")
            {
                return RedirectToAction("index", "login",new { redirect = "finalizar" });
            }
            else
            {
                var email = "eccestilo@gmail.com";
                var token = "21cad8a1-ea46-4fd3-9033-4da0e2f3b8e2520042e44d5da2bde3c350207fd55b9150fb-1682-4184-987c-c7ecbafe4ca7";
                var PagSeg = new CPagSeguro(email, token, CPagSeguro.eAmbiente.Producao);

                var resp = await PagSeg.GetSessaoAsync();
                ViewData["JsBPG"] = PagSeg.GetBiblioTecaJS();
                ViewData["TK"] = resp;

                ViewData["Enderecos"] = GetEnderecos();
                return View();
            }
        }

        public IActionResult FinalizarPedido(FinalizarPedidoVM obj) {

            FinalizarPedidoDB fPed = new FinalizarPedidoDB(_hCont);

            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            var RespEstoque = fPed.ValidaQuantidade();

            if (RespEstoque != "") {
                return Json(new { success = false, msg = RespEstoque, redirect = "/home/Index" });
            }


            var Resp = fPed.FinalizarPedido(obj);

            if (Resp)
            {
                var CodigoLogin = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.CodigoLogin);
                var CodigoPedido = fPed.GetPedidoVenda(Convert.ToInt32(CodigoLogin));
                var Email = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Email);

                EnviarEmail Send = new EnviarEmail();
                string Msg = "Obrigado! Pedido Nº " + CodigoPedido + " confirmado. Aguardando confirmação de pagamento!";
                string Titulo = "Compra realizada!";
                Send.Enviar(Email, Msg, Titulo);

                return Json(new { success = true, msg = "Pedido Nº " + CodigoPedido +" Finalizado!",redirect= "/home/PedidoConcluido" });

            }
            else
            {
                return Json(new { success = false, msg = "Infelizmente não temos tudo que você precisa, Refaça sua compra com a quantidade limite que aparece em cada produto, Obrigado e boa compra!", redirect = "/home/Index" });
            }
            
        }


        public List<SelectListItem>  GetEnderecos() {            
            string sSQL = "";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
            cn.Open();

            sSQL = "SELECT * FROM tb_endereco where CodigoLogin=@CodigoLogin and ativo=1";
            cmd.Parameters.AddWithValue("@CodigoLogin", CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.CodigoLogin));
            cmd.CommandText = sSQL;
            cmd.Connection = cn;
            var Dr = cmd.ExecuteReader();
            
            List<SelectListItem> LT = new List<SelectListItem>();
            
            while (Dr.Read())
            {
                var Item = new SelectListItem()
                {
                    Value = Dr["CEP"].ToString(),
                    Text = Dr["Descricao"].ToString()+ " - "+
                           Dr["Endereco"].ToString()+ "," +
                           Dr["Numero"].ToString() +
                           " | CEP: " + Dr["CEP"].ToString()
                };

                LT.Add(Item);                
            }
            
            return LT;
        }
        public IActionResult PedidoConcluido()
        {

            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            CarrinhoController car = new CarrinhoController(_hCont);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            ViewData["Carrinho"] = car.GetAll();

            return View();

        }

        [Authorize(Roles = "A")]
        public IActionResult Dashboard()
        {

            RelatorioDB Col = new RelatorioDB();
            RelatorioDB Prod = new RelatorioDB();
            RelatorioDB ProdQuant = new RelatorioDB();
            RelatorioDB Cli = new RelatorioDB();
            RelatorioDB Vend = new RelatorioDB();
            RelatorioDB VendValor = new RelatorioDB();
            RelatorioDB VendMaior = new RelatorioDB();
            RelatorioDB VendMedia = new RelatorioDB();
            RelatorioDB VendTotal = new RelatorioDB();
            RelatorioDB VendValorTotal = new RelatorioDB();
            RelatorioDB TamMaisVendeuQtd = new RelatorioDB();
            RelatorioDB TamMaisVendeuTam = new RelatorioDB();

            RelatorioDB NomeMaisVendido = new RelatorioDB();
            RelatorioDB TamMaisVendido = new RelatorioDB();
            RelatorioDB QuantidadeMaisVendido = new RelatorioDB();
            RelatorioDB NomeProdutoMaisVendido = new RelatorioDB();
            RelatorioDB NomeProdutoMaisVendidoQuantidade = new RelatorioDB();

            RelatorioDB GeneroNome = new RelatorioDB();
            RelatorioDB GeneroQuantidade = new RelatorioDB();

            ViewData["VDColaboradores"] = Col.Colaboradores().TotalColaborador;
            ViewData["VDClientes"] = Cli.Clientes().TotalCliente;
            ViewData["VDProdutos"] = Prod.Produtos().TotalProduto;
            ViewData["VDQuantidadeProdutos"] = ProdQuant.QuantidadeProdutos().QuantidadeTotal;
            ViewData["VDVendas"] = Vend.Vendas().TotalVenda;
            ViewData["VDValor"] = VendValor.VendaValor().VendaValor.ToString("C");
            ViewData["VDMaiorVenda"] = VendMaior.MaiorVendas().MaiorVenda.ToString("C");
            ViewData["VDMediaVenda"] = VendMedia.MediaVendas().MedidaVendas.ToString("C");
            ViewData["VDVendTotal"] = VendTotal.VendasTotal().VendasTotal;
            ViewData["VDVendValorTotal"] = VendValorTotal.VendaValorTotal().VendasValorTotal.ToString("C");
            ViewData["VDTamMaisVendeuQtd"] = TamMaisVendeuQtd.TamanhoMaisVendeu().Quantidade;
            ViewData["VDTamMaisVendeuTam"] = TamMaisVendeuTam.TamanhoMaisVendeu().Tamanho;

            ViewData["VDNomeMaisVendido"] = NomeMaisVendido.NomeTamMaisVendido().Nome;
            ViewData["VDTamMaisVendido"] = TamMaisVendido.NomeTamMaisVendido().Tamanho;
            ViewData["VDQuantidadeMaisVendido"] = QuantidadeMaisVendido.NomeTamMaisVendido().Quantidade;

            ViewData["VDNomeProdutoMaisVendidoNome"] = NomeProdutoMaisVendido.NomeProdutoMaisVendido().Nome;
            ViewData["VDNomeProdutoMaisVendidoQuantidade"] = NomeProdutoMaisVendidoQuantidade.NomeProdutoMaisVendido().Quantidade;

            ViewData["VDGeneroNome"] = GeneroNome.GeneroMaisVendido().Descricao;
            ViewData["VDGeneroQuantidade"] = GeneroQuantidade.GeneroMaisVendido().Quantidade;

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}