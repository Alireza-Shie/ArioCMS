#pragma checksum "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LatestPagesFooter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11e1f1eebc22d370e21a3d996937c60fb7d018c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LatestPagesFooter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LatestPagesFooter/Default.cshtml")]
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
#line 1 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\_ViewImports.cshtml"
using Ario.CMS.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\_ViewImports.cshtml"
using Ario.CMS.Site.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\_ViewImports.cshtml"
using Ario.CMS.ViewModel.ManageUser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\_ViewImports.cshtml"
using Ario.CMS.ViewModel.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\_ViewImports.cshtml"
using Ario.CMS.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11e1f1eebc22d370e21a3d996937c60fb7d018c2", @"/Views/Shared/Components/LatestPagesFooter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eab713535ef49fb469a6736dc176086081b7f675", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LatestPagesFooter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ario.CMS.Data.Models.Page>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"block\">\n    <h1 class=\"block-title\">آخرین خبر ها</h1>\n    <div class=\"block-body\">\n");
#nullable restore
#line 6 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LatestPagesFooter\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <article class=\"article-mini\">\n                <div class=\"inner\">\n                    <figure>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 323, "\"", 364, 4);
            WriteAttributeValue("", 330, "/News/", 330, 6, true);
#nullable restore
#line 11 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LatestPagesFooter\Default.cshtml"
WriteAttributeValue("", 336, item.PageID, 336, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 348, "/", 348, 1, true);
#nullable restore
#line 11 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LatestPagesFooter\Default.cshtml"
WriteAttributeValue("", 349, item.PageTitle, 349, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <img");
            BeginWriteAttribute("src", " src=\"", 399, "\"", 432, 2);
            WriteAttributeValue("", 405, "/PageImages/", 405, 12, true);
#nullable restore
#line 12 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LatestPagesFooter\Default.cshtml"
WriteAttributeValue("", 417, item.ImageName, 417, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Sample Article\">\n                        </a>\n                    </figure>\n                    <div class=\"padding\">\n                        <h1>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 616, "\"", 657, 4);
            WriteAttributeValue("", 623, "/News/", 623, 6, true);
#nullable restore
#line 17 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LatestPagesFooter\Default.cshtml"
WriteAttributeValue("", 629, item.PageID, 629, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 641, "/", 641, 1, true);
#nullable restore
#line 17 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LatestPagesFooter\Default.cshtml"
WriteAttributeValue("", 642, item.PageTitle, 642, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LatestPagesFooter\Default.cshtml"
                                                                    Write(item.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                        </h1>\n                    </div>\n                </div>\n            </article>\n");
#nullable restore
#line 22 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LatestPagesFooter\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"/Archive\" class=\"btn btn-magz white btn-block text-center\">\n            مشاهده همه <i class=\"ion-ios-arrow-thin-left\"></i>\n        </a>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ario.CMS.Data.Models.Page>> Html { get; private set; }
    }
}
#pragma warning restore 1591
