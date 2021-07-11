﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEV.Classes;
using PEV.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace PEV.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly IHttpContextAccessor _hCont;

        private string _Key = "Carrinho";

        public CarrinhoController(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
        }

        [HttpGet]
        public void AddCar(int CodigoProduto, string Nome, string Tamanho, string Preco, int Quantidade, string Foto)
        {
            List<CarrinhoModel> Car = null;
            CarrinhoModel item = new CarrinhoModel();

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                Culture = new System.Globalization.CultureInfo("pt-BR"),
            };

            if (GetKey() != null)
            {
                Car = JsonConvert.DeserializeObject<List<CarrinhoModel>>(GetKey(), settings);
            }
            else
            {
                Car = new List<CarrinhoModel>();
            }

            item.CodigoProduto = CodigoProduto;
            item.Nome = Nome;
            item.Tamanho = Tamanho;
            item.Preco = Convert.ToDouble(Preco);
            item.Quantidade = Quantidade;
            item.Foto = Foto;

            bool NewProdLista = true;

            foreach (var prod in Car)
            {
                if (prod.CodigoProduto == item.CodigoProduto && prod.Tamanho == item.Tamanho)
                {
                    prod.Quantidade += item.Quantidade;
                    NewProdLista = false;
                }
            }

            if (NewProdLista)
            {
                Car.Add(item);
            }


            Set(_Key, JsonConvert.SerializeObject(Car, settings), 10);
        }

        public void Set(string key, string value, int? expireTime)
        {
            _hCont.HttpContext.Response.Cookies.Delete(key);

            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMilliseconds(10);

            _hCont.HttpContext.Response.Cookies.Append(key, value, option);
        }

        [HttpGet]
        public void RemoveItem(int Id)
        {
            List<CarrinhoModel> Car = new List<CarrinhoModel>();

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                Culture = new System.Globalization.CultureInfo("pt-BR")
            };

            if (GetKey() != null)
            {
                Car = JsonConvert.DeserializeObject<List<CarrinhoModel>>(GetKey(), settings);
                Car = Car.Where(c => c.Id != Id).ToList();
                Set(_Key, JsonConvert.SerializeObject(Car, settings), 10);
            }
        }


        public void RemoveAll()
        {
            List<CarrinhoModel> Car = new List<CarrinhoModel>();

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                Culture = new System.Globalization.CultureInfo("pt-BR")
            };

            Set(_Key, JsonConvert.SerializeObject(Car, settings), 10);

        }

        [HttpGet] //AQUIE SE QUISER UM ITEM ESPECÍFICO 
        public string GetKey()
        {
            return _hCont.HttpContext.Request.Cookies[_Key];
        }


        public IActionResult GetFoto(int CodigoProduto)
        {

            string sSQL = "";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
            cn.Open();
            cmd.Connection = cn;

            sSQL = "SELECT caminho FROM tb_produto_foto where CodigoProduto=" + CodigoProduto + " order by codigofoto limit 1";
            cmd.CommandText = sSQL;
            var Dr = cmd.ExecuteReader();
            Dr.Read();

            string _Caminho = "CAMINHO";

            if (Dr.HasRows)
            {
                _Caminho = Dr["caminho"].ToString();
            }

            return Json(new { success = true, caminho = _Caminho });

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<CarrinhoModel> Car = new List<CarrinhoModel>();

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                Culture = new System.Globalization.CultureInfo("pt-BR")
            };

            if (GetKey() != null)
            {
                Car = JsonConvert.DeserializeObject<List<CarrinhoModel>>(GetKey(), settings);

                int ids = 0;
                foreach (var itemC in Car)
                {
                    ids++;
                    itemC.Id = ids;
                }

                Set(_Key, JsonConvert.SerializeObject(Car, settings), 10);

            }

            return Json(new { success = (Car.Count > 0) ? true : false, resp = Car });

        }


        public List<CarrinhoModel> GetAllDB()
        {
            List<CarrinhoModel> Car = new List<CarrinhoModel>();

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                Culture = new System.Globalization.CultureInfo("pt-BR")
            };

            if (GetKey() != null)
            {
                Car = JsonConvert.DeserializeObject<List<CarrinhoModel>>(GetKey(), settings);

                int ids = 0;
                foreach (var itemC in Car)
                {
                    ids++;
                    itemC.Id = ids;
                }


                return Car;
            }

            return null;

        }

    }
}