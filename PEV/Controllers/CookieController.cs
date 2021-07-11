using PEV.Classes;
using PEV.Data;
using PEV.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEV.Controllers
{
    public class CookieController : Controller
    {
        private readonly IHttpContextAccessor _hCont;

        public CookieController(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
        }

        //public CookieController()
        //{
        //}

        //public string GetAll()
        //{
        //    string Carrinho = "<table>";
        //    foreach (var item in Request.Cookies)
        //    {
        //        Carrinho += "<tr>";
        //        Carrinho += "<td>" + item.Key + "</td>";
        //        Carrinho += "<td>" + item.Value + "</td>";
        //        Carrinho += "<td><a href='##' onclick='RemoveItem(" + item.Key + ");'>Excluir</a></td>";
        //        Carrinho += "</tr>";
        //    }
        //    Carrinho += "</table>";
        //    return Carrinho;
        //}

        //[HttpGet]
        //public void RemoveItem(string key)
        //{
        //    Response.Cookies.Delete(key);
        //}

        //[HttpGet] //AQUIE SE QUISER UM ITEM ESPECÍFICO 
        //public string Get(string key)
        //{
        //    return Request.Cookies[key];
        //}
    }
}
