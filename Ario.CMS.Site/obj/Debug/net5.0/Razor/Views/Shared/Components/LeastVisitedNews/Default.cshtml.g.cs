#pragma checksum "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LeastVisitedNews\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec71829f2c17b02a029bacb39092ff6f4795c52d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LeastVisitedNews_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LeastVisitedNews/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec71829f2c17b02a029bacb39092ff6f4795c52d", @"/Views/Shared/Components/LeastVisitedNews/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eab713535ef49fb469a6736dc176086081b7f675", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LeastVisitedNews_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ario.CMS.Data.Models.Page>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"row\">\n");
#nullable restore
#line 4 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LeastVisitedNews\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <article class=\"col-md-12 article-list\">\n            <div class=\"inner\">\n                <figure>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 232, "\"", 273, 4);
            WriteAttributeValue("", 239, "/News/", 239, 6, true);
#nullable restore
#line 9 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LeastVisitedNews\Default.cshtml"
WriteAttributeValue("", 245, item.PageID, 245, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 257, "/", 257, 1, true);
#nullable restore
#line 9 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LeastVisitedNews\Default.cshtml"
WriteAttributeValue("", 258, item.PageTitle, 258, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 304, "\"", 337, 2);
            WriteAttributeValue("", 310, "/PageImages/", 310, 12, true);
#nullable restore
#line 10 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LeastVisitedNews\Default.cshtml"
WriteAttributeValue("", 322, item.ImageName, 322, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 338, "\"", 359, 1);
#nullable restore
#line 10 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LeastVisitedNews\Default.cshtml"
WriteAttributeValue("", 344, item.PageTitle, 344, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    </a>\n                </figure>\n                <div class=\"details\">\n                    <div class=\"detail\">\n                        <i class=\"fa fa-clock float-right ml-2 mt-0-5\"></i>\n                        <div class=\"time\">");
#nullable restore
#line 16 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LeastVisitedNews\Default.cshtml"
                                     Write(item.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    </div>\n                    <h1>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 722, "\"", 763, 4);
            WriteAttributeValue("", 729, "/News/", 729, 6, true);
#nullable restore
#line 19 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LeastVisitedNews\Default.cshtml"
WriteAttributeValue("", 735, item.PageID, 735, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 747, "/", 747, 1, true);
#nullable restore
#line 19 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LeastVisitedNews\Default.cshtml"
WriteAttributeValue("", 748, item.PageTitle, 748, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LeastVisitedNews\Default.cshtml"
                                                                Write(item.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (ArioCMS) ...</a>\n                    </h1>\n                    <p>\n                        ");
#nullable restore
#line 22 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LeastVisitedNews\Default.cshtml"
                   Write(item.ShortDescription.Trim().Replace("،", " ").Substring(0, 55));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...\n                    </p>\n                    <footer>\n                        <div>");
#nullable restore
#line 25 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LeastVisitedNews\Default.cshtml"
                        Write(item.Visit);

#line default
#line hidden
#nullable disable
            WriteLiteral(" بازدید</div>\n                        <a class=\"btn btn-primary more\"");
            BeginWriteAttribute("href", " href=\"", 1105, "\"", 1146, 4);
            WriteAttributeValue("", 1112, "/News/", 1112, 6, true);
#nullable restore
#line 26 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LeastVisitedNews\Default.cshtml"
WriteAttributeValue("", 1118, item.PageID, 1118, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1130, "/", 1130, 1, true);
#nullable restore
#line 26 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LeastVisitedNews\Default.cshtml"
WriteAttributeValue("", 1131, item.PageTitle, 1131, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                            <div>بیشتر</div>\n                            <div><i class=\"ion-ios-arrow-thin-left\"></i></div>\n                        </a>\n                    </footer>\n                </div>\n            </div>\n        </article>\n");
#nullable restore
#line 34 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LeastVisitedNews\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ario.CMS.Data.Models.Page>> Html { get; private set; }
    }
}
#pragma warning restore 1591
