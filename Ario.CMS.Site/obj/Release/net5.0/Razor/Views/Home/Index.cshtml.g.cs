#pragma checksum "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f4c91774b645c164809c5f62eab422a4e5be1d9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4c91774b645c164809c5f62eab422a4e5be1d9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eab713535ef49fb469a6736dc176086081b7f675", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "صفحه اصلی";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""home"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8 col-md-12 col-sm-12 col-xs-12"">
                <div class=""headline"">
                    <div class=""nav"" id=""headline-nav"">
                        <a class=""right carousel-control"" role=""button"" data-slide=""next"">
                            <span class=""ion-ios-arrow-right"" aria-hidden=""true""></span>
                            <span class=""sr-only"">بعدی</span>
                        </a>
                        <a class=""left carousel-control"" role=""button"" data-slide=""prev"">
                            <span class=""ion-ios-arrow-left"" aria-hidden=""true""></span>
                            <span class=""sr-only"">قبلی</span>
                        </a>
                    </div>
                    <!--TopTags For Slider-->
                    <div class=""owl-carousel owl-theme"" id=""headline"">
                        ");
#nullable restore
#line 22 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Home\Index.cshtml"
                   Write(await Component.InvokeAsync("TopTagsSlider"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <!--End TopTags-->\r\n                </div>\r\n                ");
#nullable restore
#line 26 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("Slider"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"line\">\r\n                    <div>آخرین اخبار</div>\r\n                </div>\r\n                ");
#nullable restore
#line 30 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("LatestPage"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""banner"">
                    <a href=""#"">
                        <img src=""/WebSiteTemplate/images/ads.png"" alt=""Sample Article"">
                    </a>
                </div>
                <div class=""line transparent little""></div>
                <div class=""row"">
                    <div class=""col-md-6 col-sm-6 trending-tags"">
                        <h1 class=""title-col"">برچسب های برتر</h1>
                        <div class=""body-col"">
                            ");
#nullable restore
#line 41 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Home\Index.cshtml"
                       Write(await Component.InvokeAsync("TopTags"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    ");
#nullable restore
#line 44 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("MostNewsForContent"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"line top\">\r\n                    <div>کم بازدید ترین اخبار</div>\r\n                </div>\r\n                ");
#nullable restore
#line 49 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("LeastVisitedNews"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-xs-6 col-md-4 sidebar\" id=\"sidebar\">\r\n                <div class=\"sidebar-title for-tablet\">سایدبار</div>\r\n");
#nullable restore
#line 53 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Home\Index.cshtml"
                 if (User.IsInRole("Admin"))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("AdminCard"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Home\Index.cshtml"
                                                             
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 57 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("MostNews"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <aside id=""sponsored"">
                    <h1 class=""aside-title"">اسپانسر ها</h1>
                    <div class=""aside-body"">
                        <ul class=""sponsored"">
                            <li>
                                <a href=""#"">
                                    <img src=""/WebSiteTemplate/images/sponsored.png"" alt=""Sponsored"">
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <img src=""/WebSiteTemplate/images/sponsored.png"" alt=""Sponsored"">
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <img src=""/WebSiteTemplate/images/sponsored.png"" alt=""Sponsored"">
                                </a>
                            </li>
                            <li>
                         ");
            WriteLiteral(@"       <a href=""#"">
                                    <img src=""/WebSiteTemplate/images/sponsored.png"" alt=""Sponsored"">
                                </a>
                            </li>
                        </ul>
                    </div>
                </aside>
            </div>
        </div>
    </div>
</section>

");
#nullable restore
#line 90 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("PagesBeforeWeek"));

#line default
#line hidden
#nullable disable
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