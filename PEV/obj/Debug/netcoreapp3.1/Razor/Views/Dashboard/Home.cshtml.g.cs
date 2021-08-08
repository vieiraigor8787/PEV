#pragma checksum "C:\PEV\PEV\Views\Dashboard\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de03b1dfb3804d1ba9d8d07f201868967d877e87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Home), @"mvc.1.0.view", @"/Views/Dashboard/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de03b1dfb3804d1ba9d8d07f201868967d877e87", @"/Views/Dashboard/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de7af3700166531c5bb78c6fd589b0223871d87", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClienteCidade>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
  
    Layout = "_Layout_dashboard";
    ViewData["Title"] = "Dashboard";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
    var PSV = (List<ClienteCidade>)(@ViewData["PSV"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<hr />
<h5>Pedidos e Faturamento</h5>
<br />

<div class=""col-sm-12 mb-6 no-padding"">
    <div class=""card-group"">
            <div class=""card col-md-4 no-padding "">
        <a href=""../Pedido"">
                <div class=""card-body"">
                    <div class=""h1 text-muted text-right mb-4"">
                        <i class=""ti-check-box text-primary border-primary""></i>
                    </div>

                    <div class=""h4 mb-0"">
                        <span class=""count"">");
#nullable restore
#line 22 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                       Write(ViewData["VDVendas"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>

                    <small class=""text-muted text-uppercase font-weight-bold"">Pedidos - Últimos 7 dias</small>
                    <div class=""progress progress-xs mt-3 mb-0 bg-flat-color-1"" style=""width: 40%; height: 5px;""></div>
                </div>
        </a>
            </div>
            <div class=""card col-md-6 no-padding "">
        <a href=""../Pedido"">
                <div class=""card-body"">
                    <div class=""h1 text-muted text-right mb-4"">
                        <i class=""ti-money text-success border-success""></i>
                    </div>
                    <div class=""h4 mb-0"">
                        <span>");
#nullable restore
#line 37 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                         Write(ViewData["VDValor"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                    <small class=""text-muted text-uppercase font-weight-bold"">Faturamento - Últimos 7 dias</small>
                    <div class=""progress progress-xs mt-3 mb-0 bg-flat-color-5"" style=""width: 40%; height: 5px;""></div>
                </div>
        </a>
            </div>
            <div class=""card col-md-6 no-padding "">
        <a href=""../Pedido"">
                <div class=""card-body"">
                    <div class=""h1 text-muted text-right mb-4"">
                        <i class=""ti-bar-chart text-warning border-warning""></i>
                    </div>
                    <div class=""h4 mb-0"">
                        <span>");
#nullable restore
#line 51 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                         Write(ViewData["VDMediaVenda"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                    <small class=""text-muted text-uppercase font-weight-bold"">Ticket Médio</small>
                    <div class=""progress progress-xs mt-3 mb-0 bg-flat-color-3"" style=""width: 40%; height: 5px;""></div>
                </div>
        </a>
            </div>
            <div class=""card col-md-6 no-padding "">
        <a href=""../Pedido"">
                <div class=""card-body"">
                    <div class=""h1 text-muted text-right mb-4"">
                        <i class=""ti-stats-up text-success border-success""></i>
                    </div>
                    <div class=""h4 mb-0"">
                        <span>");
#nullable restore
#line 65 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                         Write(ViewData["VDMaiorVenda"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                    <small class=""text-muted text-uppercase font-weight-bold"">Maior Venda Realizada</small>
                    <div class=""progress progress-xs mt-3 mb-0 bg-flat-color-5"" style=""width: 40%; height: 5px;""></div>
                </div>
        </a>
            </div>
            <div class=""card col-md-6 no-padding "">
        <a href=""../Pedido"">
                <div class=""card-body"">
                    <div class=""h1 text-muted text-right mb-4"">
                        <i class=""ti-shopping-cart-full text-danger border-danger""></i>
                    </div>
                    <div class=""h4 mb-0"">");
#nullable restore
#line 78 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                    Write(ViewData["VDVendTotal"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    <small class=""text-muted text-uppercase font-weight-bold"">Total de Pedidos</small>
                    <div class=""progress progress-xs mt-3 mb-0 bg-flat-color-4"" style=""width: 40%; height: 5px;""></div>
                </div>
        </a>
            </div>
            <div class=""card col-md-6 no-padding "">
        <a href=""../Pedido"">
                <div class=""card-body"">
                    <div class=""h1 text-muted text-right mb-4"">
                        <i class=""fa fa-money text-success border-success""></i>
                    </div>
                    <div class=""h4 mb-0"">
                        <span>");
#nullable restore
#line 91 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                         Write(ViewData["VDVendValorTotal"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                    <small class=""text-muted text-uppercase font-weight-bold"">Faturamento Total</small>
                    <div class=""progress progress-xs mt-3 mb-0 bg-flat-color-5"" style=""width: 40%; height: 5px;""></div>
                </div>
        </a>
            </div>
    </div>
</div>
<div class=""col-sm-12 mb-6 no-padding"">
    <div class=""content mt-3 no-padding"">
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
                                       ");
            WriteLiteral(" <th>Quantidade</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 118 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                     if (Model.Count > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 123 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                               Write(item.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 124 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                               Write(item.UF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 125 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                               Write(item.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 127 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                         
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>Sem Registros</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 134 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
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
</div>
<div>
    <h5>Informações sobre Produtos e Clientes</h5>
    <hr />
    <div class=""col-lg-6 col-md-6 no-padding"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""stat-widget-four"">
                    <div class=""stat-icon dib"">
                        <i class=""fa fa-users text-primary""></i>
                    </div>
                    <div class=""stat-content"">
                        <div class=""text-left dib"">
                            <div class=""stat-heading"">Clientes Cadastrados</div>
                            <div class=""stat-text"">");
#nullable restore
#line 157 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                              Write(ViewData["VDClientes"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-lg-6 col-md-6 no-padding"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""stat-widget-four"">
                    <div class=""stat-icon dib"">
                        <i class=""fa fa-edit text-danger""></i>
                    </div>
                    <div class=""stat-content"">
                        <div class=""text-left dib"">
                            <div class=""stat-heading"">Produtos cadastrados</div>
                            <div class=""stat-text"">");
#nullable restore
#line 174 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                              Write(ViewData["VDProdutos"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-lg-6 col-md-6 no-padding"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""stat-widget-four"">
                    <div class=""stat-icon dib "">
                        <i class=""ti-server text-warning""></i>
                    </div>
                    <div class=""stat-content"">
                        <div class=""text-left dib"">
                            <div class=""stat-heading"">Produtos em estoque</div>
                            <div class=""stat-text"">");
#nullable restore
#line 192 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                              Write(ViewData["VDQuantidadeProdutos"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-lg-6 col-md-6 no-padding"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""stat-widget-four"">
                    <div class=""stat-icon dib"">
                        <i class=""ti-arrow-top-right text-success""></i>
                    </div>
                    <div class=""stat-content"">
                        <div class=""text-left dib"">
                            <div class=""stat-heading"">O mais vendido: ");
#nullable restore
#line 209 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                                                 Write(ViewData["VDNomeProdutoMaisVendidoNome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"stat-text\">Quantidade: ");
#nullable restore
#line 210 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                                          Write(ViewData["VDNomeProdutoMaisVendidoQuantidade"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div>
    <div class=""col-sm-12 mb-6 no-padding"">
        <div class=""content mt-5 no-padding"">
            <h5>Lista de produtos com baixa movimentação </h5>
            <hr />
            <div class=""animated fadeIn"">
                <div class=""row"">
                    <div class=""col-md-12"">
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
#line 236 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                         if (PSV.Count > 0)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 238 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                             foreach (var item in PSV)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td>");
#nullable restore
#line 241 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                </tr>\r\n");
#nullable restore
#line 243 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 243 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                             
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>Sem Registros</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 250 "C:\PEV\PEV\Views\Dashboard\Home.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script src=""https://cdn.datatables.net/1.10.25/js/jquery.dataTables.min.js""></script>
<script>
    $(document).ready(function () {
        $('#test').DataTable({
            ""scrollY"": ""200px"",
            ""scrollCollapse"": true,
            ""paging"": true
        });
    });
</script>
");
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