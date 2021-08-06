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
    public class DashboardController : Controller
    {

        private readonly IHttpContextAccessor _hCont;

        public DashboardController(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
        }

        [Authorize(Roles = "A")]
        public IActionResult Index()
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

            RelatorioDB ProdSemVenda = new RelatorioDB();

            ViewData["PSV"] = ProdSemVenda.ProdutoSemVenda();

            RelatorioDB Cidade = new RelatorioDB();
            var MLista = Cidade.ClienteCidade();
            return View(MLista);
        }

        [Authorize(Roles = "A")]
        public IActionResult Home()
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

            RelatorioDB ProdSemVenda = new RelatorioDB();

            ViewData["PSV"] = ProdSemVenda.ProdutoSemVenda();

            RelatorioDB Cidade = new RelatorioDB();
            var MLista = Cidade.ClienteCidade();
            return View(MLista);
        }
    }
}
