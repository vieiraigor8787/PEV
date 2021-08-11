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
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace PEV.Controllers
{
    public class DashboardController : Controller
    {

        private readonly IHttpContextAccessor _hCont;
        private readonly IHostingEnvironment hostingEnvironment;
        IWebHostEnvironment _appEnvironment;

        public DashboardController(IHttpContextAccessor httpContextAccessor, IHostingEnvironment environment, IWebHostEnvironment env)
        {
            _hCont = httpContextAccessor;
            hostingEnvironment = environment;
            _appEnvironment = env;
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

        public IActionResult Video()
        {
            string pasta = "imagens";
            string caminho_WebRoot = _appEnvironment.WebRootPath;

            string caminhoVideos = Path.Combine(caminho_WebRoot, pasta);

            string[] arquivosVideos = Directory.GetFiles(caminhoVideos)
                                               .Select(Path.GetFileName)
                                               .ToArray();

            List<string> listaVideos = new List<string>(arquivosVideos);
            return View(listaVideos);

        }


        [Authorize(Roles = "A")]
        public IActionResult Cadastros()
        {
            return View();
        }

        [Authorize(Roles = "A")]
        public IActionResult Logomarca()
        {
            string pasta = "imagens";
            string caminho_WebRoot = _appEnvironment.WebRootPath;

            string caminhoVideos = Path.Combine(caminho_WebRoot, pasta);

            string[] arquivosVideos = Directory.GetFiles(caminhoVideos)
                                               .Select(Path.GetFileName)
                                               .ToArray();

            List<string> listaVideos = new List<string>(arquivosVideos);
            return View(listaVideos);
        }

        public IActionResult FotoSelecionada(string Nome)
        {
            LogoDB Img = new LogoDB();

            if (Img.InserirLogo(Nome))
            {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Genero inserido com sucesso!</div>";
            }
            else
            {
                return Json(new { success = false, msg = "Erro ao Cadastrar!" });
            }
            
            return View("Logomarca");
        }

        [HttpPost]
        public async Task<IActionResult> UploadFiles(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "imagens");
                var fullPath = Path.Combine(uploads, GetUniqueFileName(formFile.FileName));
                formFile.CopyTo(new FileStream(fullPath, FileMode.Create));


            }
            return RedirectToAction("Logomarca", "Dashboard");
            //return Ok(new { count = files.Count, size, filePath });
        }
        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }



        [Authorize(Roles = "A")]
        public IActionResult Home()
        {

            //RelatorioDB Col = new RelatorioDB();
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

            //RelatorioDB GeneroNome = new RelatorioDB();
            //RelatorioDB GeneroQuantidade = new RelatorioDB();


            //ViewData["VDColaboradores"] = Col.Colaboradores().TotalColaborador;
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

            //ViewData["VDGeneroNome"] = GeneroNome.GeneroMaisVendido().Descricao;
            //ViewData["VDGeneroQuantidade"] = GeneroQuantidade.GeneroMaisVendido().Quantidade;

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
