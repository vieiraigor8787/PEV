#pragma checksum "C:\PEV\PEV\Views\Menu\AddEndereco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "147244809ca5dda0c368dc75402cd51201a4d7b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_AddEndereco), @"mvc.1.0.view", @"/Views/Menu/AddEndereco.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147244809ca5dda0c368dc75402cd51201a4d7b5", @"/Views/Menu/AddEndereco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de7af3700166531c5bb78c6fd589b0223871d87", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_AddEndereco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CadastroLogin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/viacep.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cod"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FormCadastro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SalvarEnd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\PEV\PEV\Views\Menu\AddEndereco.cshtml"
                ViewData["Title"] = "Atualizão de Cadastro"; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "147244809ca5dda0c368dc75402cd51201a4d7b56223", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "147244809ca5dda0c368dc75402cd51201a4d7b57345", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\PEV\PEV\Views\Menu\AddEndereco.cshtml"
Write(Html.Raw(ViewData["Valida"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "147244809ca5dda0c368dc75402cd51201a4d7b58661", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "147244809ca5dda0c368dc75402cd51201a4d7b58927", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 10 "C:\PEV\PEV\Views\Menu\AddEndereco.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.tb_login.CodigoLogin);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "147244809ca5dda0c368dc75402cd51201a4d7b510695", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 11 "C:\PEV\PEV\Views\Menu\AddEndereco.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.JsonLTEDR);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <div class=""row"">
        <aside class=""col-md-12"">
            <div class=""card"">
                <article class=""card-body"">
                    <h6>Endereço</h6>
                    <hr />

                    <div class=""form-row"">
                        <div class=""form-group col"">
                            <label for=""txt_ender_descricao"">Tipo</label>
                            <input type=""text"" class=""form-control"" id=""txt_ender_descricao"" placeholder=""casa, escritório, casa de praia"">
                        </div>
                        <div class=""form-group col"">
                            <label for=""txt_ender_cep"">Cep</label>
                            <input type=""text"" class=""form-control"" id=""txt_ender_cep"">
                        </div>
                        <div class=""form-group col"">
                            <label for=""txt_ender_endereco"">Logradouro</label>
                            <input type=""text"" class=""form-control"" id=""txt_ender_endereco"">
 ");
                WriteLiteral(@"                       </div>
                        <div class=""form-group col-md-1"">
                            <label for=""txt_ender_numero"">Número</label>
                            <input type=""text"" class=""form-control"" id=""txt_ender_numero"">
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col"">
                            <label for=""txt_ender_bairro"">Bairro</label>
                            <input type=""text"" class=""form-control"" id=""txt_ender_bairro"">
                        </div>
                        <div class=""form-group col"">
                            <label for=""txt_ender_cidade"">Cidade</label>
                            <input type=""text"" class=""form-control"" id=""txt_ender_cidade"">
                        </div>
                        <div class=""form-group col-md-1"">
                            <label for=""txt_ender_uf"">UF</label>
                            <input ");
                WriteLiteral(@"type=""text"" class=""form-control"" id=""txt_ender_uf"">
                        </div>
                        <div class=""form-group col"">
                            <button type=""button"" class=""btn btn-success"" style=""margin-top:30px;"" onclick=""AddEndereco();"">Adicionar Endereço</button>
                        </div>
                    </div>
                </article>
            </div>
        </aside>
    </div>
    <table id=""tb_endereco"" class=""table bg-light"">
        <tbody>
        </tbody>
    </table>

    <div class=""ml-3"">
    <button type=""submit"" class=""btn btn-primary btn-block mb-3"" style=""width:10%"">Salvar</button>
    <button type=""button"" class=""btn btn-info btn-sm"" onclick=""window.location.href='../Menu/EditaSSenha'"">Voltar</button>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"



<script>
    var MtzEndereco;



    $(document).ready(function () {

        if ($(""#JsonLTEDR"").val() != """") {
            MtzEndereco = JSON.parse($(""#JsonLTEDR"").val());
        }
        else {
            MtzEndereco = [];
        }

        GetTabela();
    });


    function AddEndereco() {
        if ($(""#txt_ender_descricao"").val() == """") {
            alert(""Digite a Descrição"");
            $(""#txt_ender_descricao"").focus();
            return;
        }

        MtzEndereco.push(
            {
                CodigoLogin: $(""#cod"").val(),
                CodigoEndereco: 0,
                Descricao: $(""#txt_ender_descricao"").val(),
                Cep: $(""#txt_ender_cep"").val(),
                Endereco: $(""#txt_ender_endereco"").val(),
                Numero: $(""#txt_ender_numero"").val(),
                Bairro: $(""#txt_ender_bairro"").val(),
                Cidade: $(""#txt_ender_cidade"").val(),
                UF: $(""#txt_ender_uf"").val(),
            }");
            WriteLiteral(@"
        );
        GetTabela();
        $(""#txt_ender_descricao"").val("""");
        $(""#txt_ender_cep"").val("""");
        $(""#txt_ender_endereco"").val("""");
        $(""#txt_ender_numero"").val("""");
        $(""#txt_ender_bairro"").val("""");
        $(""#txt_ender_cidade"").val("""");
        $(""#txt_ender_uf"").val("""");
        $(""#txt_ender_descricao"").focus();

    }

    function GetTabela() {
        $(""#JsonLTEDR"").val(JSON.stringify(MtzEndereco));
        $(""#tb_endereco > tbody "").html("""");
        var sHtml = """";
        for (var x = 0; x <= MtzEndereco.length - 1; x++) {
            sHtml = ""<tr>"";
            sHtml += ""<td>Descrição: "" + MtzEndereco[x].Descricao + ""</td>"";
            sHtml += ""<td>CEP: "" + MtzEndereco[x].Cep + ""</td>"";
            sHtml += ""<td>Logradouro: "" + MtzEndereco[x].Endereco + ""</td>"";
            sHtml += ""<tr/>"";
            sHtml += ""<tr>"";
            sHtml += ""<td>Número: "" + MtzEndereco[x].Numero + ""</td>"";
            sHtml += ""<td>Bairro: "" + MtzEnde");
            WriteLiteral(@"reco[x].Bairro + ""</td>"";
            sHtml += ""<td>Cidade: "" + MtzEndereco[x].Cidade + ""</td>"";
            sHtml += ""<td>UF: "" + MtzEndereco[x].UF + ""</td>"";
            sHtml += ""</tr>"";
            sHtml += ""<tr>"";
            sHtml += ""<td><a href='##' onclick='ExcluirEnder("" + x + "")'>Excluir</a></td>"";
            sHtml += ""</tr>"";
            $(""#tb_endereco > tbody "").append(sHtml);
        }
    }

    function ExcluirEnder(x) {
        delete MtzEndereco[x];
        MtzEndereco.splice(x, 1);
        GetTabela();
    }
    function SetSubmit() {
        $('#FormCadastro').submit(function (e) {
            e.preventDefault();
            var form = $(this);
            var url = form.attr('action');
            $.ajax({
                type: ""POST"",
                url: url,
                data: form.serialize(),
                success: function (data) {
                    if (data.success) {
                        alertSucesso(data.msg);
                    } else {
");
            WriteLiteral(@"
                        if (data.msg.indexOf(""Erro"") > -1) {
                            alertErro(data.msg);
                        }
                        else {
                            alertInformacao(data.msg);
                        }
                    }
                }
            });

        });
    }


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CadastroLogin> Html { get; private set; }
    }
}
#pragma warning restore 1591
