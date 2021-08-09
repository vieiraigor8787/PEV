#pragma checksum "C:\PEV\PEV\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3203b5ddb75ec392cc6f7427eb80be1554a8c5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\PEV\PEV\Views\_ViewImports.cshtml"
using PEV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PEV\PEV\Views\_ViewImports.cshtml"
using PEV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3203b5ddb75ec392cc6f7427eb80be1554a8c5a", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de7af3700166531c5bb78c6fd589b0223871d87", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClienteCidade>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
  
    Layout = "_Layout_dashboard";
    ViewData["Title"] = "Dashboard";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
var PSV = (List<ClienteCidade>)(@ViewData["PSV"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    h3 {
        margin-bottom: 1em
    }

    .square-data {
        box-shadow: 2px 3px 8px black;
        width: 22%;
    }

    .square-data p {
        margin-left: 5px;
    }

    .square-data p:first-child {
        color: #000;
        font-size: 18px;
        margin-top: 5px;
    }

    .info {
        background: #c7c7c7;
    }

    .info p {
        font-size: 14px !important;
        margin: 0;
        margin-left: 5px;
        padding: 2px 0;
    }

    .sq-bellow {
        width: 30%
    }

    .sq-double {
        width: 47%;
        color: #fff
    }

    .sq-double p:first-child {
        font-size: 22px;
        text-align: center;
        margin-top: 15px;
    }

    .square-data span {
        font-size: 40px;
        display: block;
        text-align: center;
    }

    .square-data.sq-double {
        padding: 1em 0;
    }

    .square-data .sq-double span {
        font-size: 40px;
        display: block;
        text");
            WriteLiteral(@"-align: center;
    }

    .square-data.sq-bellow span {
        font-size: 30px;
        display: block;
        text-align: center;
    }
</style>

<div class=""container"">
    <div class=""dash-title"">
        <h3>Painel de Visualização</h3>
    </div>
    <hr />
    <div class=""content mt-3"">
        <h5>Pedido e faturamento</h5>
        <hr />
        <div class=""d-flex justify-content-around"">
            <div class=""square-data"">
                <p>Pedidos</p>
                <span style=""color:#0026ff;"">");
#nullable restore
#line 88 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                        Write(ViewData["VDVendas"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <div class=\"info\">\r\n                    <p>Últimos 7 dias</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"square-data\">\r\n                <p>Faturamento</p>\r\n                <span style=\"color: #ff6a00;\">");
#nullable restore
#line 95 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                         Write(ViewData["VDValor"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <div class=\"info\">\r\n                    <p>Últimos 7 dias</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"square-data\">\r\n                <p>Ticket médio</p>\r\n                <span style=\"color: #b200ff;\">");
#nullable restore
#line 102 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                         Write(ViewData["VDMediaVenda"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"square-data\">\r\n                <p>Maior venda realizada</p>\r\n                <span style=\"color: #570f5a;\">");
#nullable restore
#line 106 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                         Write(ViewData["VDMaiorVenda"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
        </div>
        <div class=""d-flex justify-content-around mb-5 mt-3"">
            <div class=""square-data sq-double"" style=""background-color: #90CBFB;"">
                <p style=""#110066"">Total de pedidos</p>
                <span style=""color: #110066"">");
#nullable restore
#line 112 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                        Write(ViewData["VDVendTotal"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"square-data sq-double\" style=\"background:#110066\">\r\n                <p style=\"color:#FFD432\">Fatutamento total</p>\r\n                <span style=\"color: #FFD432\">");
#nullable restore
#line 116 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                        Write(ViewData["VDVendValorTotal"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
        </div>
    </div>
            <div class=""content mt-3"">
                <h5>Pedidos por Cidades</h5>
                <hr />
                <div class=""animated fadeIn"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""card"">
                                <div class=""card-body"">
                                    <table id=""bootstrap-data-table-export"" class=""table table-striped table-bordered"">
                                        <thead>
                                            <tr>
                                                <th>Cidade</th>
                                                <th>UF</th>
                                                <th>Quantidade</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 137 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                             if (Model.Count > 0)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td>");
#nullable restore
#line 142 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                                       Write(item.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 143 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                                       Write(item.UF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 144 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                                       Write(item.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 146 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                                 
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>Sem Registros</td>\r\n                                                </tr>\r\n");
#nullable restore
#line 153 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
            WriteLiteral(@"        <div class=""content mt-3"">
            <h5>Informações sobre produto</h5>
            <hr />
            <div class=""d-flex justify-content-around mb-2 mt-3"">
                <div class=""square-data sq-double"">
                    <p>Produtos cadastrados</p>
                    <span style=""color: #0f5a42;"">");
#nullable restore
#line 174 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                             Write(ViewData["VDProdutos"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"square-data sq-double\">\r\n                    <p>Produtos em estoque</p>\r\n                    <span style=\"color: #825a01;\">");
#nullable restore
#line 178 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                             Write(ViewData["VDQuantidadeProdutos"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n            <div class=\"d-flex justify-content-around mt-3\">\r\n                <div class=\"square-data sq-bellow\">\r\n                    <p>Produto mais vendido</p>\r\n                    <span");
            BeginWriteAttribute("style", " style=\"", 6638, "\"", 6646, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 184 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                              Write(ViewData["VDNomeProdutoMaisVendidoNome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <div class=\"info\">\r\n                        <p");
            BeginWriteAttribute("style", " style=\"", 6764, "\"", 6772, 0);
            EndWriteAttribute();
            WriteLiteral(">Quantidade: ");
#nullable restore
#line 186 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                           Write(ViewData["VDNomeProdutoMaisVendidoQuantidade"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"square-data sq-bellow\">\r\n                    <p>Gênero mais vendido</p>\r\n                    <span");
            BeginWriteAttribute("style", " style=\"", 7017, "\"", 7025, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 191 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                              Write(ViewData["VDGeneroNome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <div class=\"info\">\r\n                        <p");
            BeginWriteAttribute("style", " style=\"", 7127, "\"", 7135, 0);
            EndWriteAttribute();
            WriteLiteral(">Quantidade: ");
#nullable restore
#line 193 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                           Write(ViewData["VDGeneroQuantidade"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"square-data sq-bellow\">\r\n                    <p style=\"color: black\">Tamanho mais vendido</p>\r\n                    <span");
            BeginWriteAttribute("style", " style=\"", 7386, "\"", 7394, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 198 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                              Write(ViewData["VDTamMaisVendeuTam"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <div class=\"info\">\r\n                        <p");
            BeginWriteAttribute("style", " style=\"", 7502, "\"", 7510, 0);
            EndWriteAttribute();
            WriteLiteral(">Quantidade: ");
#nullable restore
#line 200 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                           Write(ViewData["VDTamMaisVendeuQtd"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
        </div>
    <div class=""content mt-5"">
        <h5>Lista de produtos com baixa movimentação </h5>
        <hr />
        <div class=""animated fadeIn"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <table id=""bootstrap-data-table-export-2"" class=""table table-striped table-bordered"">
                                <thead>
                                    <tr>
                                        <th>Nome</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 220 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                     if (PSV.Count > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 222 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                         foreach (var item in PSV)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 225 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 227 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 227 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                         
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>Sem Registros</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 234 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <h5>Usuários e Produtos</h5>
    <hr />
    <div class=""d-flex justify-content-between"">

        <div class=""square-data sq-bellow"">
            <p>Clientes registrados</p>
            <p style=""        font-size: 40px;
        color: #f94b83;
        text-align: center"">");
#nullable restore
#line 251 "C:\PEV\PEV\Views\Dashboard\Index.cshtml"
                       Write(ViewData["VDClientes"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
    </div>
</div>


<script src=""https://cdn.datatables.net/1.10.25/js/jquery.dataTables.min.js""></script>
<script>
    $(document).ready(function() {
    $('#test').DataTable( {
        ""scrollY"":        ""200px"",
        ""scrollCollapse"": true,
        ""paging"":         true
    } );
} );
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClienteCidade>> Html { get; private set; }
    }
}
#pragma warning restore 1591
