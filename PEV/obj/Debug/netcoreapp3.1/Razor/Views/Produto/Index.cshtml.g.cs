#pragma checksum "C:\PEV\PEV\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa642b7a47c38290010836ad223726f612c08b5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa642b7a47c38290010836ad223726f612c08b5b", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de7af3700166531c5bb78c6fd589b0223871d87", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\PEV\PEV\Views\Produto\Index.cshtml"
                ViewData["Title"] = "Produto";

                Layout = "_Layout_dashboard"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""content mt-3"">
    <div class=""animated fadeIn"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <div><strong class=""card-title"">Lista de Produtos</strong>
                        <button class=""btn btn-primary"" type=""button"" onclick=""window.location.href ='/produto/cadastroproduto'"">Novo Produto</button></div>
                    </div>
                    <div class=""card-body"">
                        <table id=""bootstrap-data-table-export"" class=""table table-striped table-bordered"">
                            <thead>
                                <tr>
                                    <th>Código Interno</th>
                                    <th>Nome</th>
                                    <th>Valor</th>
                                    <th>Quantidade</th>
                                    <th>Ativo</th>
                                    <t");
            WriteLiteral("h>Tamanho</th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 31 "C:\PEV\PEV\Views\Produto\Index.cshtml"
                                 if (Model.Count > 0)
                                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\PEV\PEV\Views\Produto\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 36 "C:\PEV\PEV\Views\Produto\Index.cshtml"
                   Write(item.CodigoInterno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\PEV\PEV\Views\Produto\Index.cshtml"
                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\PEV\PEV\Views\Produto\Index.cshtml"
                   Write(item.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "C:\PEV\PEV\Views\Produto\Index.cshtml"
                   Write(item.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\PEV\PEV\Views\Produto\Index.cshtml"
                   Write(item.Ativo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\PEV\PEV\Views\Produto\Index.cshtml"
                   Write(item.Tamanho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1887, "\"", 2029, 7);
            WriteAttributeValue("", 1897, "window.location.href=\'/produto/editar?CodigoProduto=", 1897, 52, true);
#nullable restore
#line 42 "C:\PEV\PEV\Views\Produto\Index.cshtml"
WriteAttributeValue("", 1949, item.CodigoProduto, 1949, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1968, "&CodigoInterno=", 1968, 15, true);
#nullable restore
#line 42 "C:\PEV\PEV\Views\Produto\Index.cshtml"
WriteAttributeValue("", 1983, item.CodigoInterno, 1983, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2002, "&Descricao=", 2002, 11, true);
#nullable restore
#line 42 "C:\PEV\PEV\Views\Produto\Index.cshtml"
WriteAttributeValue("", 2013, item.Descricao, 2013, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2028, "\'", 2028, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></button></td>\r\n                </tr>\r\n");
#nullable restore
#line 44 "C:\PEV\PEV\Views\Produto\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\PEV\PEV\Views\Produto\Index.cshtml"
  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>Sem Registros</td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "C:\PEV\PEV\Views\Produto\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div><!-- .animated -->\r\n</div><!-- .content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tb_produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
