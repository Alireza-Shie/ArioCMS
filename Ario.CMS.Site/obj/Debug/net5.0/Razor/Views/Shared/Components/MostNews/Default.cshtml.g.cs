#pragma checksum "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\MostNews\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ab1cd744fdb8486d593cbc3b86959a15431709c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MostNews_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MostNews/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ab1cd744fdb8486d593cbc3b86959a15431709c", @"/Views/Shared/Components/MostNews/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eab713535ef49fb469a6736dc176086081b7f675", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MostNews_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ario.CMS.Data.Models.Page>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<aside class=\"mt-3\">\n    <h1 class=\"aside-title\">\n        محبوب ترین اخبار <a href=\"/Archive\" class=\"all\">\n            مشاهده همه <i class=\"ion-ios-arrow-left\"></i>\n        </a>\n    </h1>\n    <div class=\"aside-body\">\n");
#nullable restore
#line 10 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\MostNews\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <article class=\"article-mini\">\n                <div class=\"inner\">\n                    <figure>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 445, "\"", 486, 4);
            WriteAttributeValue("", 452, "/News/", 452, 6, true);
#nullable restore
#line 15 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\MostNews\Default.cshtml"
WriteAttributeValue("", 458, item.PageID, 458, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 470, "/", 470, 1, true);
#nullable restore
#line 15 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\MostNews\Default.cshtml"
WriteAttributeValue("", 471, item.PageTitle, 471, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <img");
            BeginWriteAttribute("src", " src=\"", 521, "\"", 554, 2);
            WriteAttributeValue("", 527, "/PageImages/", 527, 12, true);
#nullable restore
#line 16 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\MostNews\Default.cshtml"
WriteAttributeValue("", 539, item.ImageName, 539, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 555, "\"", 576, 1);
#nullable restore
#line 16 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\MostNews\Default.cshtml"
WriteAttributeValue("", 561, item.PageTitle, 561, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        </a>\n                    </figure>\n                    <div class=\"padding\">\n                        <h1>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 739, "\"", 780, 4);
            WriteAttributeValue("", 746, "/News/", 746, 6, true);
#nullable restore
#line 21 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\MostNews\Default.cshtml"
WriteAttributeValue("", 752, item.PageID, 752, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 764, "/", 764, 1, true);
#nullable restore
#line 21 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\MostNews\Default.cshtml"
WriteAttributeValue("", 765, item.PageTitle, 765, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\MostNews\Default.cshtml"
                                                                    Write(item.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (ArioCMS)</a>\n                        </h1>\n                    </div>\n                </div>\n            </article>\n");
#nullable restore
#line 26 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\MostNews\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</aside>");
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
