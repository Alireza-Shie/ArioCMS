#pragma checksum "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LatestComment\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec529ef02264d44004693e7ade6d305d4c32d61a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LatestComment_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LatestComment/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec529ef02264d44004693e7ade6d305d4c32d61a", @"/Views/Shared/Components/LatestComment/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eab713535ef49fb469a6736dc176086081b7f675", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LatestComment_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ario.CMS.Data.Models.PageComment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"category-section border-radius\">\r\n    <header><i class=\"fa fa-commenting-o fa-2x\"></i> <h3> اخرین نظرات </h3></header>\r\n    <ul>\r\n");
#nullable restore
#line 6 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LatestComment\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><span> ");
#nullable restore
#line 8 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LatestComment\Default.cshtml"
                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  گفته : </span>\r\n                <br />\r\n                <p>");
#nullable restore
#line 10 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LatestComment\Default.cshtml"
              Write(item.CommentText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <br />\r\n                <span> مربوط به :</span><a");
            BeginWriteAttribute("href", " href=\"", 434, "\"", 441, 0);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 12 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LatestComment\Default.cshtml"
                                               Write(item.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                </li>\r\n");
#nullable restore
#line 14 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Shared\Components\LatestComment\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ario.CMS.Data.Models.PageComment>> Html { get; private set; }
    }
}
#pragma warning restore 1591