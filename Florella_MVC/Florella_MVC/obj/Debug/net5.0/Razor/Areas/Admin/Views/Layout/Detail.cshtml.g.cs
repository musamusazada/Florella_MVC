#pragma checksum "C:\Users\musam\Desktop\Back-End\Florella_MVC\Florella_MVC\Florella_MVC\Areas\Admin\Views\Layout\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b320a22f5dea622e42852fbe8d06a8778b9f8cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Layout_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Layout/Detail.cshtml")]
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
#line 1 "C:\Users\musam\Desktop\Back-End\Florella_MVC\Florella_MVC\Florella_MVC\Areas\Admin\Views\_ViewImports.cshtml"
using Florella_MVC.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\musam\Desktop\Back-End\Florella_MVC\Florella_MVC\Florella_MVC\Areas\Admin\Views\_ViewImports.cshtml"
using Florella_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b320a22f5dea622e42852fbe8d06a8778b9f8cf", @"/Areas/Admin/Views/Layout/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e8d87b6f9d426c8f1c73d745f4ba9c22aba7c54", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Layout_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Layout>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""content-wrapper"">
    <div class=""row"">
        <div class=""col-md-6 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <h4 class=""card-title"">Category</h4>
                    <p class=""card-description"">
                        ");
#nullable restore
#line 10 "C:\Users\musam\Desktop\Back-End\Florella_MVC\Florella_MVC\Florella_MVC\Areas\Admin\Views\Layout\Detail.cshtml"
                   Write(Model.Slogan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 12 "C:\Users\musam\Desktop\Back-End\Florella_MVC\Florella_MVC\Florella_MVC\Areas\Admin\Views\Layout\Detail.cshtml"
                   Write(Model.facebook_url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br>\r\n                        ");
#nullable restore
#line 14 "C:\Users\musam\Desktop\Back-End\Florella_MVC\Florella_MVC\Florella_MVC\Areas\Admin\Views\Layout\Detail.cshtml"
                   Write(Model.twitter_url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Layout> Html { get; private set; }
    }
}
#pragma warning restore 1591
