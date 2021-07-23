#pragma checksum "C:\PEV\PEV\Views\Usuario\Cliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9619d774383f881ff43a02a48e424113ad598bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cliente), @"mvc.1.0.view", @"/Views/Usuario/Cliente.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9619d774383f881ff43a02a48e424113ad598bb", @"/Views/Usuario/Cliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de7af3700166531c5bb78c6fd589b0223871d87", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Cliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_login>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
                ViewData["Title"] = "Clientes";

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
                        <strong class=""card-title"">Lista de Clientes</strong>
                    </div>
                    <div class=""card-body"">
                        <table id=""bootstrap-data-table-export"" class=""table table-striped table-bordered"">
                            <thead>
                                <tr>
                                    <th>Código</th>
                                    <th>Nome</th>
                                    <th>Email</th>
                                    <th>Telefone</th>
                                    <th>CPF</th>
                                    <th>Ativo</th>
                                    <th>Editar</th>
                                    <th>Nova Senha</th>
                                </tr>
            ");
            WriteLiteral("                </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 31 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
                                 if (Model.Count > 0)
                                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 36 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
                                   Write(item.CodigoLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 37 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
                                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 38 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
                                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 39 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
                                   Write(item.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 40 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
                                   Write(item.CPF_CNPJ);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 41 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
                                   Write(item.Ativo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1883, "\"", 2110, 17);
            WriteAttributeValue("", 1893, "window.location.href=\'/usuario/EditarSemSenhaCliente?CodigoLogin=", 1893, 65, true);
#nullable restore
#line 42 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 1958, item.CodigoLogin, 1958, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1975, "&Nome=", 1975, 6, true);
#nullable restore
#line 42 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 1981, item.Nome, 1981, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1991, "&Email=", 1991, 7, true);
#nullable restore
#line 42 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 1998, item.Email, 1998, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2009, "&Telefone=", 2009, 10, true);
#nullable restore
#line 42 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 2019, item.Telefone, 2019, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2033, "&CPF_CNPJ=", 2033, 10, true);
#nullable restore
#line 42 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 2043, item.CPF_CNPJ, 2043, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2057, "&Senha=", 2057, 7, true);
#nullable restore
#line 42 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 2064, item.Senha, 2064, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2075, "&Tipo=", 2075, 6, true);
#nullable restore
#line 42 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 2081, item.Tipo, 2081, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2091, "&Ativo=", 2091, 7, true);
#nullable restore
#line 42 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 2098, item.Ativo, 2098, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2109, "\'", 2109, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></button></td>\r\n                                    <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2246, "\"", 2336, 3);
            WriteAttributeValue("", 2256, "window.location.href=\'/usuario/EditarSenhaCliente?CodigoLogin=", 2256, 62, true);
#nullable restore
#line 43 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
WriteAttributeValue("", 2318, item.CodigoLogin, 2318, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2335, "\'", 2335, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-key\"></i></button></td>\r\n                                </tr>\r\n");
#nullable restore
#line 45 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>Sem Registros</td>\r\n    </tr>\r\n");
#nullable restore
#line 51 "C:\PEV\PEV\Views\Usuario\Cliente.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tb_login>> Html { get; private set; }
    }
}
#pragma warning restore 1591
