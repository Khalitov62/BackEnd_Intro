#pragma checksum "C:\Users\user\source\repos\BackEnd_Intro\BackEnd_Intro\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3c579ac8b6f02bf6c2f118d675aab2056debcd4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3c579ac8b6f02bf6c2f118d675aab2056debcd4", @"/Views/Home/Index.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 style=\"color:red\">Hello Ap204</h1>\r\n\r\n\r\n    <span>Product name: ");
#nullable restore
#line 5 "C:\Users\user\source\repos\BackEnd_Intro\BackEnd_Intro\Views\Home\Index.cshtml"
                   Write(ViewBag.Product);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n    <span>Product count: ");
#nullable restore
#line 6 "C:\Users\user\source\repos\BackEnd_Intro\BackEnd_Intro\Views\Home\Index.cshtml"
                    Write(ViewData["Count"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n    <span>Product type: ");
#nullable restore
#line 7 "C:\Users\user\source\repos\BackEnd_Intro\BackEnd_Intro\Views\Home\Index.cshtml"
                   Write(TempData["Type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
