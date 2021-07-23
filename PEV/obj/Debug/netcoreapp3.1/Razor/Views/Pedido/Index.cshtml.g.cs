#pragma checksum "C:\PEV\PEV\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "321ebd828ce95dd7e85995abc9080f8fde9ee768"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"321ebd828ce95dd7e85995abc9080f8fde9ee768", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de7af3700166531c5bb78c6fd589b0223871d87", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TodosPedidos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\PEV\PEV\Views\Pedido\Index.cshtml"
                ViewData["Title"] = "Pedidos";

                Layout = "_Layout_dashboard"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content mt-3"">
<div class=""animated fadeIn"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <strong class=""card-title"">Lista de Vendas</strong>
                </div>
                <div class=""card-body"">
                    <table id=""bootstrap-data-table-export"" class=""table table-striped table-bordered"">
                        <thead>
                            <tr>
                                <th>Venda</th>
                                <th>Cliente</th>
                                <th>Valor</th>
                                <th>Data</th>
                                <th>Status</th>
                                <th>Editar Status</th>
                                <th>Ver Itens</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 28 "C:\PEV\PEV\Views\Pedido\Index.cshtml"
                             if (Model.Count > 0)
                            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\PEV\PEV\Views\Pedido\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 33 "C:\PEV\PEV\Views\Pedido\Index.cshtml"
               Write(item.CodigoVenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\PEV\PEV\Views\Pedido\Index.cshtml"
               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\PEV\PEV\Views\Pedido\Index.cshtml"
               Write(item.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\PEV\PEV\Views\Pedido\Index.cshtml"
               Write(item.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\PEV\PEV\Views\Pedido\Index.cshtml"
               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1545, "\"", 1622, 3);
            WriteAttributeValue("", 1555, "window.location.href=\'/pedido/Editar?CodigoVenda=", 1555, 49, true);
#nullable restore
#line 38 "C:\PEV\PEV\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1604, item.CodigoVenda, 1604, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1621, "\'", 1621, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit \"></i></button></td>\r\n                <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1739, "\"", 1818, 3);
            WriteAttributeValue("", 1749, "window.location.href=\'/pedido/VerItens?CodigoVenda=", 1749, 51, true);
#nullable restore
#line 39 "C:\PEV\PEV\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1800, item.CodigoVenda, 1800, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1817, "\'", 1817, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-search\"></i></button></td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\PEV\PEV\Views\Pedido\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\PEV\PEV\Views\Pedido\Index.cshtml"
  }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>Sem Registros</td>\r\n            </tr>\r\n");
#nullable restore
#line 47 "C:\PEV\PEV\Views\Pedido\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div><!-- .animated -->\r\n</div><!-- .content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TodosPedidos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
