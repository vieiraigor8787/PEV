#pragma checksum "C:\Users\igor.cerqueira\Documents\PEV\PEV\Views\Home\Finalizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6da9eef79cee58d561747d184537f23a64cdebee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Finalizar), @"mvc.1.0.view", @"/Views/Home/Finalizar.cshtml")]
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
#line 1 "C:\Users\igor.cerqueira\Documents\PEV\PEV\Views\_ViewImports.cshtml"
using PEV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\igor.cerqueira\Documents\PEV\PEV\Views\_ViewImports.cshtml"
using PEV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6da9eef79cee58d561747d184537f23a64cdebee", @"/Views/Home/Finalizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abe107446159a55c9d1cd9d79bfe4e37f0886e81", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Finalizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalizarPedidoVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "04510", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "04014", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txt_cep"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control txt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formPagamento"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FinalizarPedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jsPagSeg.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.mask.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\igor.cerqueira\Documents\PEV\PEV\Views\Home\Finalizar.cshtml"
    ViewData["Title"] = "Finalizar";
    var LTEnderecos = (List<SelectListItem>)(ViewData["Enderecos"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n<h3 class=\"font-weight-bold\">Escolher endereço de entrega</h3>\r\n<hr />\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6da9eef79cee58d561747d184537f23a64cdebee7356", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6da9eef79cee58d561747d184537f23a64cdebee7622", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 14 "C:\Users\igor.cerqueira\Documents\PEV\PEV\Views\Home\Finalizar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CEP);

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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6da9eef79cee58d561747d184537f23a64cdebee9314", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 15 "C:\Users\igor.cerqueira\Documents\PEV\PEV\Views\Home\Finalizar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TotalPedido);

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
                WriteLiteral("\r\n\r\n\r\n    <div>\r\n        <input type=\"hidden\" id=\"SessionPG\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 485, "\"", 508, 1);
#nullable restore
#line 19 "C:\Users\igor.cerqueira\Documents\PEV\PEV\Views\Home\Finalizar.cshtml"
WriteAttributeValue("", 493, ViewData["TK"], 493, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
        <input type=""hidden"" id=""BandeiraSel"" class=""form-control"" />




        <aside class=""col-lg-12"" style=""padding: 0"">

            <div class=""card mb-8"">
                <div class=""card-body"">
                    <div class=""form-group"">
                        <label>Calculo de frete</label>
                        <div class=""input-group"">
                            <select id=""txt_servico"" type=""text"" class=""form-control"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6da9eef79cee58d561747d184537f23a64cdebee11984", async() => {
                    WriteLiteral("PAC");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6da9eef79cee58d561747d184537f23a64cdebee13237", async() => {
                    WriteLiteral("SEDEX");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </select>\r\n                        </div>\r\n                        <br>\r\n                        <div class=\"input-group\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6da9eef79cee58d561747d184537f23a64cdebee14650", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 39 "C:\Users\igor.cerqueira\Documents\PEV\PEV\Views\Home\Finalizar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = LTEnderecos;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <br>
                        <p>Valor do frete:  R$ <span id=""RespFrete""></span></p>

                    </div>
                </div> <!-- card-body.// -->
            </div> <!-- card.// -->
            <hr />
            <h3 class=""font-weight-bold"">Resumo do pedido</h3>
            <hr />
            <div class=""card mb-5"">
                <div class=""card-body"">
                    <dl class=""dlist-align"">
                        <dt>Produtos: R$</dt>
                        <dd id=""ValorTotalProduto"" class=""text-right""></dd>
                    </dl>
                    <br><br>
                    <dl class=""dlist-align"">
                        <dt>Frete: R$</dt>
                        <dd id=""RespFrete2"" class=""text-right text-danger""></dd>
                    </dl>
                    <br>
                    <dl class=""dlist-align"">
                        <dt>Total: R$</dt>
                        <dd id=""ValorFinal");
                WriteLiteral(@""" class=""text-right text-dark b""><strong></strong></dd>
                    </dl>

                </div> <!-- card-body.// -->
            </div> <!-- card.// -->

        </aside>
    </div>


    <hr />
    <h3 class=""font-weight-bold"">Escolher forma de pagamento</h3>
    <hr />

    <div>
        <aside class=""col-lg-12"" style=""padding: 0"">
            <div class=""card mb-8"">
                <div class=""card-body"">
                    <div class=""form-group"">
                        <label>Selecione a forma de pagamento</label>
                        <div class=""input-group"">
                            <select id=""FormaPagamento"" type=""text"" class=""form-control"">
                            </select>
                        </div>
                    </div>
                    <div class=""row clsCard"">
                        <div class=""form-group col-10"">
                            <label for=""NumeroCartao"" class=""control-label"">Numero do Cartão:</label>
                  ");
                WriteLiteral(@"          <input type=""number"" id=""NumeroCartao"" class=""form-control"" />
                        </div>
                        <div class=""form-group col-2 text-left"">
                            <div id=""dvBCC"" style=""margin-top:30px;margin-left:-35px;""></div>
                        </div>
                        <div class=""form-group col-4"">
                            <label for=""Validade"" class=""control-label"">Validade</label>
                            <input type=""text"" id=""Validade"" class=""form-control"" />
                            <small>MM/AA</small>
                        </div>
                        <div class=""form-group col-4"">
                            <label for=""CVV"" class=""control-label"">CVV</label>
                            <input type=""number"" id=""CVV"" class=""form-control"" />
                        </div>

                        <div class=""form-group col-md-6"">
                            <div id=""dvCardNumberCC""></div>
                            <label for");
                WriteLiteral(@"=""NomeCartao"" class=""control-label"">Nome Impresso no Cartão:</label>
                            <input type=""text"" id=""NomeCartao"" class=""form-control"" />
                        </div>

                        <div id=""dvParcelamento"" class=""form-group col-md-12"" style=""display:none;"">
                            <div id=""dvParceLoading""></div>
                            <label for=""Parcelamento"" class=""control-label"">Parcelamento</label>
                            <select id=""Parcelamento"" class=""form-control""></select>
                        </div>

                    </div>


                </div> <!-- card-body.// -->




            </div> <!-- card.// -->
            <br />
            <br />

        </aside>
    </div>

    <button id=""btFinalizar"" class=""btn btn-primary text-right"" type=""button"" href=""##"" onclick=""FinalizarPedido();"">Efetuar Pagamento</button>

    <hr />

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
            WriteLiteral("\r\n");
#nullable restore
#line 139 "C:\Users\igor.cerqueira\Documents\PEV\PEV\Views\Home\Finalizar.cshtml"
Write(Html.Raw(ViewData["JsBPG"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6da9eef79cee58d561747d184537f23a64cdebee22169", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6da9eef79cee58d561747d184537f23a64cdebee23209", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(document).ready(function () {

        PagSeguroDirectPayment.setSessionId($(""#SessionPG"").val());

        SetsFuncsPagSeguro();

        SetSubmit();

        $(""#Validade"").mask(""99/99"");
        $(""#CPF"").mask(""999.999.999-99"");


        $(""#btn_Calcular"").click(function () {
            CalcularFrete();
        });

        $(""#txt_servico"").change(function () {
            CalcularFrete();
        });

        $(""#txt_cep"").change(function () {
            CalcularFrete();
        });

        GetCarrinho();

        setTimeout(function () {
            CalcularFrete();
        }, 1000);


    })

    function SetsFuncsPagSeguro() {

        $(""#ValorFinal"").blur(function () {
            GetMetodosPag($(this).html(), $(""#FormaPagamento""), $(""#dvFormPagLoading""));
        });


        $(""#NumeroCartao"").blur(function () {
            if ($(this).val() == """") {
                return;
            }
            GetBandeiraCC($(this).val(), $(");
            WriteLiteral(@"""#dvBCC""), $(""#BandeiraSel""));
            setTimeout(function () {
                GetParcelamento($(""#ValorFinal"").html(), $(""#BandeiraSel"").val(), $(""#Parcelamento""), $(""#dvParceLoading""));
                $(""#dvCardNumberCC"").html("""");
                $(""#dvParcelamento"").show();                
            }, 1000);

        });

        $(""#FormaPagamento"").change(function () {
            $(""#dvbanco"").hide();
            $(""#dvParcelamento"").hide();

            if ($(this).val() == 3) {
                $(""#dvbanco"").show();
            }

            /*else if ($(this).val() == 1) {

                $(""#dvParcelamento"").show();
            }*/


        });

    }


    function CalcularFrete() {
        Calcular($(""#txt_cep"").val(), $(""#txt_servico"").val());
    }

    function formata(v) {
        return v.toLocaleString(""pt-BR"", { minimumFractionDigits: 2 });
    }

    function Calcular(_cep, _servico) {
        $(""#RespFrete"").html(""Aguarde..."");
        var");
            WriteLiteral(" _url = \'");
#nullable restore
#line 225 "C:\Users\igor.cerqueira\Documents\PEV\PEV\Views\Home\Finalizar.cshtml"
               Write(Url.Action("GetCalculo", "CalculaFrete"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $.ajax({
            url: _url,
            type: 'GET',
            data: {
                cep : _cep,
                cdservico : _servico,
            },
            processData: true,
            contentType: true,
            success: function (result) {


                $(""#RespFrete"").html(result.resposta);
                $(""#RespFrete2"").html(result.resposta);
                SomaValorFreteProduto();

            }
            ,
            error: function (jqXHR) {

            },
            complete: function (jqXHR, status) {

            },
        });

    }
        function GetFoto(_CodigoProduto) {

        var _url = '");
#nullable restore
#line 255 "C:\Users\igor.cerqueira\Documents\PEV\PEV\Views\Home\Finalizar.cshtml"
               Write(Url.Action("GetFoto", "Carrinho"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

        $.ajax({
            url: _url,
            type: 'GET',
            processData: true,
            contentType: true,
            data: { CodigoProduto: _CodigoProduto },
            success: function (result) {
                if (result.success) {
                    $("".f_"" + _CodigoProduto).attr(""src"", result.caminho);
                }
                else {
                    return ""Caminho IMG"";
                }

             }
            ,
            error: function (jqXHR) {

            },
            complete: function (jqXHR, status) {

            }
        });
    }
    function GetCarrinho() {

        var tb = """";
        var Total = 0;
        var Quantidade = 0;
        $(""#idcarrinho"").html("""");
        var _url = '");
#nullable restore
#line 287 "C:\Users\igor.cerqueira\Documents\PEV\PEV\Views\Home\Finalizar.cshtml"
               Write(Url.Action("GetAll", "Carrinho"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

        $.ajax({
            url: _url,
            type: 'GET',
            processData: true,
            contentType: true,
            success: function (result) {
                if (result.success) {
                    tb = ""<tr>"";
                    $.each(result.resp, function (i, item) {
                        var f2 = item.preco.toLocaleString('pt-br', { minimumFractionDigits: 2 });
                        tb += ""<td><figure class='media'>"";
                        tb += ""<div class='img-wrap'><img class='f_"" + item.codigoProduto + ""' src=''class='img-thumbnail img-sm'></div>"";
                        tb += ""<figcaption class='media-body'>"";
                        tb += ""<h6 class='title text-truncate'>"" + item.nome + ""</h6>"";
                        tb += ""<dl class='dlist-inline small'><dt>Tamanho: </dt><dd>"" + item.tamanho + ""</dd></dl>"";
                        tb += ""</figcaption></figure ></td>"";
                        tb += ""<td>"" + item.quantidade + "" </td>"";
    ");
            WriteLiteral(@"                    tb += ""<td><div class='price-wrap'><var class='price'>R$ "" + formata(item.quantidade * item.preco) + ""</var>"";
                        tb += ""<small class='text-muted'> R$ "" + f2 + "" cada</small></div></td>"";
                        tb += ""<td class='text-right'><a href='##' class='btn btn-light' onclick='RemoveItem("" + item.id + "");'>Remover</a></td>"";
                        tb += ""</tr>"";
                        Total += item.preco * item.quantidade;
                        Quantidade += item.quantidade;

                        $(""#ValorTotalProduto"").html(Total.toLocaleString('pt-br', { minimumFractionDigits: 2 }));
                        $(""#QuantidadeTotalProduto"").html(Quantidade);
                        $(""#idcarrinho"").html(tb);

                        GetFoto(item.codigoProduto);
                    });



                }
            }
            ,
            error: function (jqXHR) {

            },
            complete: function (jqXHR, status) {
");
            WriteLiteral(@"
            }

        });

    }


    function SomaValorFreteProduto() {
        var Frete = parseFloat($(""#RespFrete"").html().replace('.', '').replace(',', '.'));
        var TotalFinal = parseFloat($(""#ValorTotalProduto"").html().replace('.', '').replace(',', '.'));
        var Total = (Frete + TotalFinal).toLocaleString('pt-br', { minimumFractionDigits: 2 });

        $(""#TotalPedido"").val(Total);
        $(""#CEP"").val($(""#txt_cep"").val());


        $(""#ValorFinal"").html(Total);
        $(""#ValorFinal"").blur();
    }

      function RemoveItem(codigo) {
        var _url = '");
#nullable restore
#line 351 "C:\Users\igor.cerqueira\Documents\PEV\PEV\Views\Home\Finalizar.cshtml"
               Write(Url.Action("RemoveItem", "Carrinho"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

        $.ajax({
            url: _url,
            type: 'GET',
            data: {
                Id: codigo
            },
            processData: true,
            contentType: true,
            success: function (result) {
                GetCarrinho();
            }
            ,
            error: function (jqXHR) {

            },
            complete: function (jqXHR, status) {

            }

        });
      }

    function FinalizarPedido() {
        
        $(""#btFinalizar"").html(""Processando Pagamento"");
        $(""#btFinalizar"").prop(""disabled"", true);

        setTimeout(function () {
            $('#formPagamento').submit();           
        }, 4000);

    }


    function SetSubmit() {
        $('#formPagamento').submit(function (e) {
            e.preventDefault();
            var form = $(this);
            var url = form.attr('action');
            $.ajax({
                type: ""POST"",
                url: url,
                data: f");
            WriteLiteral(@"orm.serialize(),
                success: function (data) {
                    if (data.success) {
                        alertSucesso(data.msg);

                        setTimeout(function () {
                            window.location.href = data.redirect;
                        }, 4000);

                    } else {

                        $(""#btFinalizar"").html(""Efetuar Pagamento"");
                        $(""#btFinalizar"").prop(""disabled"", false);

                        if (data.msg.indexOf(""Erro"") > -1) {
                            alertErro(data.msg);
                            setTimeout(function () {
                                window.location.href = data.redirect;
                            },10000);
                        }
                        else {
                            alertInformacao(data.msg);
                            setTimeout(function () {
                                window.location.href = data.redirect;
                            ");
            WriteLiteral("},10000);\r\n                        }\r\n                    }\r\n                }\r\n            });\r\n\r\n        });\r\n    }\r\n\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalizarPedidoVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
