#pragma checksum "I:\Nueva carpeta (2)\UNED\PROGRAMACION AVANZADA EN WEB\Proyecto1\COVIDVaccinesEffectsRegistry\COVIDVaccinesEffectsRegistry\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8ca6dc0cddd7b80d79f40b3f2faf0444a02baf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "I:\Nueva carpeta (2)\UNED\PROGRAMACION AVANZADA EN WEB\Proyecto1\COVIDVaccinesEffectsRegistry\COVIDVaccinesEffectsRegistry\Views\_ViewImports.cshtml"
using COVIDVaccinesEffectsRegistry;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\Nueva carpeta (2)\UNED\PROGRAMACION AVANZADA EN WEB\Proyecto1\COVIDVaccinesEffectsRegistry\COVIDVaccinesEffectsRegistry\Views\_ViewImports.cshtml"
using COVIDVaccinesEffectsRegistry.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8ca6dc0cddd7b80d79f40b3f2faf0444a02baf1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f08d87cce8021fa7798c4b6fc8ea9a9de3a85aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "I:\Nueva carpeta (2)\UNED\PROGRAMACION AVANZADA EN WEB\Proyecto1\COVIDVaccinesEffectsRegistry\COVIDVaccinesEffectsRegistry\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">\r\n        Bienvenido a la  plataforma de recopilacion de información de enfermedades y las\r\n        inyecciones experimentales propuestas para la atención de COVID\r\n    </h1>\r\n    <h3><a");
            BeginWriteAttribute("href", " href=\"", 286, "\"", 323, 1);
#nullable restore
#line 10 "I:\Nueva carpeta (2)\UNED\PROGRAMACION AVANZADA EN WEB\Proyecto1\COVIDVaccinesEffectsRegistry\COVIDVaccinesEffectsRegistry\Views\Home\Index.cshtml"
WriteAttributeValue("", 293, Url.Action("Index", "Doctor"), 293, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Click para iniciar reporte</a>.</h3>\r\n</div>\r\n");
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
