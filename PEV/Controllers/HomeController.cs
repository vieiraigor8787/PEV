using PEV.Classes;
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
using System.Net;
using System.Xml;
using System.Text;

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

        [HttpPost]
        public JsonResult Checkout(FinalizarPedidoVM obj)
        {
            //URI de checkout.
            string uri = @"https://ws.pagseguro.uol.com.br/v2/checkout";

            //Conjunto de parâmetros/formData.
            System.Collections.Specialized.NameValueCollection postData = new System.Collections.Specialized.NameValueCollection();
            postData.Add("email", "danieltoguti@gmail.com");
            postData.Add("token", "2cd2eb37-563a-4360-9483-2a2f272aed6d0489e06b44a08cb92fd03926cf2f2be4b5bd-47f0-4d83-951f-a6094f300510");
            postData.Add("currency", "BRL");
            postData.Add("itemId1", "0001");
            postData.Add("itemDescription1", "ProdutoPagSeguroI");
            postData.Add("itemAmount1", "3.00");
            postData.Add("itemQuantity1", "1");
            postData.Add("itemWeight1", "200");
            postData.Add("reference", "REF1234");
            postData.Add("senderName", "Jose Comprador");
            postData.Add("senderAreaCode", "44");
            postData.Add("senderPhone", "999999999");
            postData.Add("senderEmail", "comprador@uol.com.br");
            postData.Add("shippingAddressRequired", "false");

            //String que receberá o XML de retorno.
            string xmlString = null;

            //Webclient faz o post para o servidor de pagseguro.
            using (WebClient wc = new WebClient())
            {
                //Informa header sobre URL.
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

                //Faz o POST e retorna o XML contendo resposta do servidor do pagseguro.
                var result = wc.UploadValues(uri, postData);

                //Obtém string do XML.
                xmlString = Encoding.ASCII.GetString(result);
            }

            //Cria documento XML.
            XmlDocument xmlDoc = new XmlDocument();

            //Carrega documento XML por string.
            xmlDoc.LoadXml(xmlString);

            //Obtém código de transação (Checkout).
            var code = xmlDoc.GetElementsByTagName("code")[0];

            //Obtém data de transação (Checkout).
            var date = xmlDoc.GetElementsByTagName("date")[0];

            //Monta a URL para pagamento.
            var paymentUrl = string.Concat("https://pagseguro.uol.com.br/v2/checkout/payment.html?code=", code.InnerText);

            //Retorna dados para HTML.
            return Json(paymentUrl);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}