#pragma checksum "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa94589ad52d8c6702cfe30a1e86bdca51e73ade"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_ShowPage), @"mvc.1.0.view", @"/Views/News/ShowPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa94589ad52d8c6702cfe30a1e86bdca51e73ade", @"/Views/News/ShowPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eab713535ef49fb469a6736dc176086081b7f675", @"/Views/_ViewImports.cshtml")]
    public class Views_News_ShowPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ario.CMS.Data.Models.Page>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AddComment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml"
  
    ViewData["Title"] = Model.PageTitle;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""single first"" style=""padding-top: 220px;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 col-lg-4 sidebar"">
                <aside>
                    <div class=""aside-body"">
                        <figure class=""ads"">
                            <a href=""single-post.html"">
                                <img src=""/WebSiteTemplate/images/ad.png"">
                            </a>
                            <figcaption class=""text-center"">تبلغات</figcaption>
                        </figure>
                    </div>
                </aside>
            </div>
            <div class=""col-md-12 col-lg-8 float-right"">
                <ol class=""breadcrumb"">
                    <li><a href=""#"">خانه</a></li>
                    <li><a href=""#"">اخبار</a></li>
                    <li class=""active"">");
#nullable restore
#line 25 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml"
                                  Write(Model.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ol>\r\n                <article class=\"article main-article mt-5\">\r\n                    <header>\r\n                        <h3 class=\"pt-0\">");
#nullable restore
#line 29 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml"
                                    Write(Model.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <ul class=\"details\">\r\n                            <li>تاریخ ");
#nullable restore
#line 31 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml"
                                 Write(Model.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><a>");
#nullable restore
#line 32 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml"
                              Write(ViewBag.groupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li><a>");
#nullable restore
#line 33 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml"
                              Write(Model.Visit);

#line default
#line hidden
#nullable disable
            WriteLiteral(" بازدید</a></li>\r\n                        </ul>\r\n                    </header>\r\n                    <div class=\"main\">\r\n                        <p>\r\n                            ");
#nullable restore
#line 38 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml"
                       Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <div class=\"featured mb-5\">\r\n                            <figure>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1760, "\"", 1794, 2);
            WriteAttributeValue("", 1766, "/PageImages/", 1766, 12, true);
#nullable restore
#line 42 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml"
WriteAttributeValue("", 1778, Model.ImageName, 1778, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <figcaption>تصویر ArioCMS</figcaption>\r\n                            </figure>\r\n                        </div>\r\n\r\n                        <p>\r\n                            ");
#nullable restore
#line 48 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml"
                       Write(Html.Raw(Model.PageText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                    <footer>\r\n                        <div class=\"col d-inline-block pr-0\">\r\n                            <ul class=\"tags\">\r\n");
#nullable restore
#line 54 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml"
                                 foreach (var item in Model.Tags.Split(','))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2380, "\"", 2409, 2);
            WriteAttributeValue("", 2387, "/search/search?q=", 2387, 17, true);
#nullable restore
#line 56 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml"
WriteAttributeValue("", 2404, item, 2404, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 56 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml"
                                                                    Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 57 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>
                        <div class=""col d-inline-block"">

                        </div>
                    </footer>
                </article>
                <br />

                ");
#nullable restore
#line 67 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml"
           Write(await Component.InvokeAsync("ShowComments", new { pageId = Model.PageID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa94589ad52d8c6702cfe30a1e86bdca51e73ade11842", async() => {
                WriteLiteral(@"
                    <div class=""col-md-12"">
                        <h3 class=""title"">ارسال دیدگاه جدید</h3>
                    </div>
                    <div class=""form-group col-md-4"">
                        <label for=""name"">نام <span class=""required""></span></label>
                        <input type=""text"" id=""name"" name=""Name"" class=""form-control"">
                    </div>
                    <div class=""form-group col-md-4"">
                        <label for=""email"">ایمیل <span class=""required""></span></label>
                        <input type=""email"" id=""email"" name=""Email"" class=""form-control"">
                    </div>
                    <div class=""form-group col-md-12"">
                        <label for=""message"">دیدگاه <span class=""required""></span></label>
                        <textarea class=""form-control"" name=""CommentText"" placeholder=""دیگاه خود را بنویسید ...""></textarea>
                    </div>
                    <div class=""form-group col-md-12"">
     ");
                WriteLiteral("                   <button class=\"btn btn-primary float-right\">ارسال دیدگاه</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "E:\Developer Projects\Web ASP Project\Ario.CMS\Ario.CMS.Site\Views\News\ShowPage.cshtml"
                                                                                                      WriteLiteral(Model.PageID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["pageId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["pageId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ario.CMS.Data.Models.Page> Html { get; private set; }
    }
}
#pragma warning restore 1591
