#pragma checksum "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\PagesBeforeWeek\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "326bf43ac56c8edb953836b832f83f1004264b7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PagesBeforeWeek_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PagesBeforeWeek/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"326bf43ac56c8edb953836b832f83f1004264b7a", @"/Views/Shared/Components/PagesBeforeWeek/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eab713535ef49fb469a6736dc176086081b7f675", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PagesBeforeWeek_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ario.CMS.Data.Models.Page>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""best-of-the-week"">
    <div class=""container"">
        <h1>
            <div class=""text"">برترین اخبار هفته گذشته</div>
            <div class=""carousel-nav"" id=""best-of-the-week-nav"">
                <div class=""prev"">
                    <i class=""ion-ios-arrow-left""></i>
                </div>
                <div class=""next"">
                    <i class=""ion-ios-arrow-right""></i>
                </div>
            </div>
        </h1>
        <div class=""owl-carousel owl-theme carousel-1"">
");
#nullable restore
#line 17 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\PagesBeforeWeek\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <article class=\"article\">\n                    <div class=\"inner\">\n                        <figure>\n                            <a href=\"single-post.html\">\n                                <img");
            BeginWriteAttribute("src", " src=\"", 826, "\"", 859, 2);
            WriteAttributeValue("", 832, "/PageImages/", 832, 12, true);
#nullable restore
#line 23 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\PagesBeforeWeek\Default.cshtml"
WriteAttributeValue("", 844, item.ImageName, 844, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Sample Article\">\n                            </a>\n                        </figure>\n                        <div class=\"padding\">\n                            <div class=\"detail\">\n                                <div class=\"time\">");
#nullable restore
#line 28 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\PagesBeforeWeek\Default.cshtml"
                                             Write(item.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                                <div class=\"category\"><a href=\"category.html\">");
#nullable restore
#line 29 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\PagesBeforeWeek\Default.cshtml"
                                                                         Write(item.Visit);

#line default
#line hidden
#nullable disable
            WriteLiteral(" بازدید</a></div>\n                            </div>\n                            <h2><a href=\"single-post.html\">");
#nullable restore
#line 31 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\PagesBeforeWeek\Default.cshtml"
                                                      Write(item.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\n                            <p>");
#nullable restore
#line 32 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\PagesBeforeWeek\Default.cshtml"
                          Write(item.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        </div>\n                    </div>\n                </article>\n");
#nullable restore
#line 36 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\PagesBeforeWeek\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</section>");
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