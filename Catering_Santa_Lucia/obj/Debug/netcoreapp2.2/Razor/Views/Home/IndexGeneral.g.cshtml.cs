#pragma checksum "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Home\IndexGeneral.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57394cef8fe6ead4bdd6985fe1e1cecd9fd85693"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexGeneral), @"mvc.1.0.view", @"/Views/Home/IndexGeneral.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/IndexGeneral.cshtml", typeof(AspNetCore.Views_Home_IndexGeneral))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57394cef8fe6ead4bdd6985fe1e1cecd9fd85693", @"/Views/Home/IndexGeneral.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7093e1bb69eddc89a64e1873e0c79d385299c593", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexGeneral : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Home\IndexGeneral.cshtml"
  
    ViewData["Title"] = "Seccion de Cliente";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(103, 39, true);
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1>");
            EndContext();
            BeginContext(143, 17, false);
#line 9 "D:\SISCARCOOP\Catering Casa Santa Lucia\Catering_Santa_Lucia\Views\Home\IndexGeneral.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(160, 438, true);
            WriteLiteral(@"</h1>
    <div class=""jumbotron jumbotron-fluid"">
        <div class=""container"">
            <h1 class=""display-4"">Sistema Catering:Cliente</h1>
            <p class=""lead"">Bienvenido al sistema de catering de casa santa Lucia, Usted se ha ingresado al sistema como cliente, 
                            Favor realizar pedido mediante las opciones en la parte superior izquierda del navegador</p>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
