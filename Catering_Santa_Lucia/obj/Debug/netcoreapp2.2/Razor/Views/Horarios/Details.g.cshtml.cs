#pragma checksum "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Horarios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a2431b58a323fbb2a8cfb7e201982af6f4e31d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Horarios_Details), @"mvc.1.0.view", @"/Views/Horarios/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Horarios/Details.cshtml", typeof(AspNetCore.Views_Horarios_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a2431b58a323fbb2a8cfb7e201982af6f4e31d6", @"/Views/Horarios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7093e1bb69eddc89a64e1873e0c79d385299c593", @"/Views/_ViewImports.cshtml")]
    public class Views_Horarios_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Catering_Santa_Lucia.Models.Horario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Horarios\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(89, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Horario</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(220, 44, false);
#line 14 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Horarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(264, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(328, 40, false);
#line 17 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Horarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(368, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(431, 52, false);
#line 20 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Horarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MeseroNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(483, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(547, 51, false);
#line 23 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Horarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.MeseroNavigation.Id));

#line default
#line hidden
            EndContext();
            BeginContext(598, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(661, 52, false);
#line 26 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Horarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PedidoNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(713, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(777, 51, false);
#line 29 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Horarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.PedidoNavigation.Id));

#line default
#line hidden
            EndContext();
            BeginContext(828, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(876, 68, false);
#line 34 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Horarios\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(944, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(952, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a2431b58a323fbb2a8cfb7e201982af6f4e31d67018", async() => {
                BeginContext(974, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(990, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Catering_Santa_Lucia.Models.Horario> Html { get; private set; }
    }
}
#pragma warning restore 1591
