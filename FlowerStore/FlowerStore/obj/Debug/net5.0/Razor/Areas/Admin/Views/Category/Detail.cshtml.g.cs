#pragma checksum "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Areas\Admin\Views\Category\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b40e4a01779ff3f83ef21a55bfd7e0e527f75fae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Detail.cshtml")]
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
#line 1 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Areas\Admin\Views\_ViewImports.cshtml"
using FlowerStore.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Areas\Admin\Views\_ViewImports.cshtml"
using FlowerStore.Areas.Admin.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Areas\Admin\Views\_ViewImports.cshtml"
using FlowerStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b40e4a01779ff3f83ef21a55bfd7e0e527f75fae", @"/Areas/Admin/Views/Category/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2036a686b0e45268f05c6ac5726f373ec591398b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <div class=\"content-wrapper\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6 grid-margin stretch-card\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        <h4 class=\"card-title\">");
#nullable restore
#line 9 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Areas\Admin\Views\Category\Detail.cshtml"
                                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p class=\"card-description\">\r\n                            ");
#nullable restore
#line 11 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Areas\Admin\Views\Category\Detail.cshtml"
                       Write(Html.Raw(Model.Desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
