#pragma checksum "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Pedidos\DetailsGeneral.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06b640f873cf2f73be35222b7deb7c69fb6323c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_DetailsGeneral), @"mvc.1.0.view", @"/Views/Pedidos/DetailsGeneral.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedidos/DetailsGeneral.cshtml", typeof(AspNetCore.Views_Pedidos_DetailsGeneral))]
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
#line 1 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\_ViewImports.cshtml"
using Catering_Santa_Lucia;

#line default
#line hidden
#line 2 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\_ViewImports.cshtml"
using Catering_Santa_Lucia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06b640f873cf2f73be35222b7deb7c69fb6323c0", @"/Views/Pedidos/DetailsGeneral.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7093e1bb69eddc89a64e1873e0c79d385299c593", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_DetailsGeneral : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Catering_Santa_Lucia.Models.Pedido>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexGeneral", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Pedidos\DetailsGeneral.cshtml"
  
    ViewData["Title"] = "DetailsGeneral";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(142, 136, true);
            WriteLiteral("\r\n<h1>DetailsGeneral</h1>\r\n\r\n<div>\r\n    <h4>Pedido</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(279, 49, false);
#line 15 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Pedidos\DetailsGeneral.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaCreacion));

#line default
#line hidden
            EndContext();
            BeginContext(328, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(392, 45, false);
#line 18 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Pedidos\DetailsGeneral.cshtml"
       Write(Html.DisplayFor(model => model.FechaCreacion));

#line default
#line hidden
            EndContext();
            BeginContext(437, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(500, 47, false);
#line 21 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Pedidos\DetailsGeneral.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaPedido));

#line default
#line hidden
            EndContext();
            BeginContext(547, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(611, 43, false);
#line 24 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Pedidos\DetailsGeneral.cshtml"
       Write(Html.DisplayFor(model => model.FechaPedido));

#line default
#line hidden
            EndContext();
            BeginContext(654, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(717, 53, false);
#line 27 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Pedidos\DetailsGeneral.cshtml"
       Write(Html.DisplayNameFor(model => model.ClienteNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(770, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(834, 56, false);
#line 30 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Pedidos\DetailsGeneral.cshtml"
       Write(Html.DisplayFor(model => model.ClienteNavigation.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(890, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(953, 50, false);
#line 33 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Pedidos\DetailsGeneral.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1067, 58, false);
#line 36 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Pedidos\DetailsGeneral.cshtml"
       Write(Html.DisplayFor(model => model.TipoNavigation.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1188, 53, false);
#line 39 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Pedidos\DetailsGeneral.cshtml"
       Write(Html.DisplayNameFor(model => model.UsuarioNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1305, 56, false);
#line 42 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Pedidos\DetailsGeneral.cshtml"
       Write(Html.DisplayFor(model => model.UsuarioNavigation.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1408, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06b640f873cf2f73be35222b7deb7c69fb6323c08951", async() => {
                BeginContext(1461, 8, true);
                WriteLiteral("Regresar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1473, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Catering_Santa_Lucia.Models.Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
