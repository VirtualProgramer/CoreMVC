#pragma checksum "C:\Users\hyt\Documents\GitHub\CoreMVC\CoreMVC\Views\Home\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b3b3c74c02b72efaca1d401750f87b4374a8018"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Welcome), @"mvc.1.0.view", @"/Views/Home/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Welcome.cshtml", typeof(AspNetCore.Views_Home_Welcome))]
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
#line 1 "C:\Users\hyt\Documents\GitHub\CoreMVC\CoreMVC\Views\_ViewImports.cshtml"
using CoreMVC;

#line default
#line hidden
#line 2 "C:\Users\hyt\Documents\GitHub\CoreMVC\CoreMVC\Views\_ViewImports.cshtml"
using CoreMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b3b3c74c02b72efaca1d401750f87b4374a8018", @"/Views/Home/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e49ef1b62a3bca90a51ee9002da6167d250edae6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\hyt\Documents\GitHub\CoreMVC\CoreMVC\Views\Home\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 28, true);
            WriteLiteral("\r\n<h1>Welcome</h1>\r\n\r\n<ul>\r\n");
            EndContext();
#line 9 "C:\Users\hyt\Documents\GitHub\CoreMVC\CoreMVC\Views\Home\Welcome.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
            BeginContext(183, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(196, 19, false);
#line 11 "C:\Users\hyt\Documents\GitHub\CoreMVC\CoreMVC\Views\Home\Welcome.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(215, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 12 "C:\Users\hyt\Documents\GitHub\CoreMVC\CoreMVC\Views\Home\Welcome.cshtml"
    }

#line default
#line hidden
            BeginContext(229, 5, true);
            WriteLiteral("</ul>");
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