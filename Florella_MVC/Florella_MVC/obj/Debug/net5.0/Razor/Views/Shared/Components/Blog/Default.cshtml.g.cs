#pragma checksum "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Florella-MM\Florella_MVC\Florella_MVC\Florella_MVC\Views\Shared\Components\Blog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5b3a7a89fc92e2d1d599cd475842c4553aeb1d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Blog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Blog/Default.cshtml")]
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
#line 1 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Florella-MM\Florella_MVC\Florella_MVC\Florella_MVC\Views\_ViewImports.cshtml"
using Florella_MVC.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Florella-MM\Florella_MVC\Florella_MVC\Florella_MVC\Views\_ViewImports.cshtml"
using Florella_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5b3a7a89fc92e2d1d599cd475842c4553aeb1d0", @"/Views/Shared/Components/Blog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db2f827e42e06c33a0a6f50af5de5d4fcccb7a3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Blog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row pb-5\">\r\n");
#nullable restore
#line 4 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Florella-MM\Florella_MVC\Florella_MVC\Florella_MVC\Views\Shared\Components\Blog\Default.cshtml"
     foreach(var blog in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6 col-lg-4\">\r\n        <div class=\"item\">\r\n            <div class=\"img position-relative\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 223, "\"", 244, 2);
            WriteAttributeValue("", 229, "img/", 229, 4, true);
#nullable restore
#line 9 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Florella-MM\Florella_MVC\Florella_MVC\Florella_MVC\Views\Shared\Components\Blog\Default.cshtml"
WriteAttributeValue("", 233, blog.image, 233, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 263, "\"", 269, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"date rounded bg-light position-absolute py-1 px-2\">\r\n                    <span>");
#nullable restore
#line 11 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Florella-MM\Florella_MVC\Florella_MVC\Florella_MVC\Views\Shared\Components\Blog\Default.cshtml"
                     Write(Html.DisplayFor(disItem => blog.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n            <div class=\"text mt-3 text-center px-5\">\r\n                <h5>");
#nullable restore
#line 15 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Florella-MM\Florella_MVC\Florella_MVC\Florella_MVC\Views\Shared\Components\Blog\Default.cshtml"
               Write(blog.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"text-black-50\">");
#nullable restore
#line 16 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Florella-MM\Florella_MVC\Florella_MVC\Florella_MVC\Views\Shared\Components\Blog\Default.cshtml"
                                    Write(blog.article);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\musam\Desktop\Back-End\ASP_NET_CORE\Florella-MM\Florella_MVC\Florella_MVC\Florella_MVC\Views\Shared\Components\Blog\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
