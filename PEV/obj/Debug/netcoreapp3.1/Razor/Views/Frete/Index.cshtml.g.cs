#pragma checksum "C:\PEV\PEV\Views\Frete\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b94038b0d787ae2ca470dc3d0ea185d08f31f980"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Frete_Index), @"mvc.1.0.view", @"/Views/Frete/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b94038b0d787ae2ca470dc3d0ea185d08f31f980", @"/Views/Frete/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de7af3700166531c5bb78c6fd589b0223871d87", @"/Views/_ViewImports.cshtml")]
    public class Views_Frete_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tb_frete_dados>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\PEV\PEV\Views\Frete\Index.cshtml"
                ViewData["Title"] = "Dados de Pagamento";

                Layout = "_Layout_dashboard"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>Cep do local da Postagem</h5>\r\n<hr />\r\n\r\n<div class=\"content mt-3\">\r\n    <div class=\"animated fadeIn\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <div class=\"card\">\r\n");
            WriteLiteral(@"                    <div class=""card-body"">
                        <table id=""bootstrap-data-table-export"" class=""table table-striped table-bordered"">
                            <thead>
                                <tr>
                                    <th>Código</th>
                                    <th>CEP</th>
                                </tr>
                            </thead>
                            <tbody>
                                        <tr>
                                            <td>");
#nullable restore
#line 29 "C:\PEV\PEV\Views\Frete\Index.cshtml"
                                           Write(Model.IdFrete);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 30 "C:\PEV\PEV\Views\Frete\Index.cshtml"
                                           Write(Model.CEP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1471, "\"", 1557, 5);
            WriteAttributeValue("", 1481, "window.location.href=\'/frete/editar?IdFrete=", 1481, 44, true);
#nullable restore
#line 31 "C:\PEV\PEV\Views\Frete\Index.cshtml"
WriteAttributeValue("", 1525, Model.IdFrete, 1525, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1539, "&Email=", 1539, 7, true);
#nullable restore
#line 31 "C:\PEV\PEV\Views\Frete\Index.cshtml"
WriteAttributeValue("", 1546, Model.CEP, 1546, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1556, "\'", 1556, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></button></td>\r\n                                            <td><button type=\"button\" class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1700, "\"", 1770, 3);
            WriteAttributeValue("", 1710, "window.location.href=\'/frete/excluir?IdFrete=", 1710, 45, true);
#nullable restore
#line 32 "C:\PEV\PEV\Views\Frete\Index.cshtml"
WriteAttributeValue("", 1755, Model.IdFrete, 1755, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1769, "\'", 1769, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-trash""></i></button></td>
                                        </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div><!-- .animated -->
</div><!-- .content -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tb_frete_dados> Html { get; private set; }
    }
}
#pragma warning restore 1591
