#pragma checksum "C:\Users\Amir Hossin\Desktop\News_App\Web\Views\ShowNews\ShowgroupsArchive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5440a02df2d5863839117242fb8e72702895a78f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShowNews_ShowgroupsArchive), @"mvc.1.0.view", @"/Views/ShowNews/ShowgroupsArchive.cshtml")]
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
#line 1 "C:\Users\Amir Hossin\Desktop\News_App\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amir Hossin\Desktop\News_App\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5440a02df2d5863839117242fb8e72702895a78f", @"/Views/ShowNews/ShowgroupsArchive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_ShowNews_ShowgroupsArchive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DomainClass.PagesTB>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Amir Hossin\Desktop\News_App\Web\Views\ShowNews\ShowgroupsArchive.cshtml"
   
    ViewData["Title"] = "ارشیو خبر ها";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"col-md-12 col-sm-12 col-xs-12 pull-left\">\r\n\r\n   \r\n\r\n    <!-- last news -->\r\n    <section class=\"last-news-section border-radius\">\r\n        <header><i class=\"icons icon-doc-2\"></i>  <h3> آرشیو خبر ها</h3> </header>\r\n        <ul>\r\n");
#nullable restore
#line 15 "C:\Users\Amir Hossin\Desktop\News_App\Web\Views\ShowNews\ShowgroupsArchive.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5440a02df2d5863839117242fb8e72702895a78f4265", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 466, "~/img/", 466, 6, true);
#nullable restore
#line 18 "C:\Users\Amir Hossin\Desktop\News_App\Web\Views\ShowNews\ShowgroupsArchive.cshtml"
AddHtmlAttributeValue("", 472, item.ImageName, 472, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h2 ><a");
            BeginWriteAttribute("href", " href=\"", 518, "\"", 547, 2);
            WriteAttributeValue("", 525, "/showNews/", 525, 10, true);
#nullable restore
#line 19 "C:\Users\Amir Hossin\Desktop\News_App\Web\Views\ShowNews\ShowgroupsArchive.cshtml"
WriteAttributeValue("", 535, item.PageID, 535, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\Amir Hossin\Desktop\News_App\Web\Views\ShowNews\ShowgroupsArchive.cshtml"
                                                     Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h2>\r\n                    <p>\r\n                        ");
#nullable restore
#line 21 "C:\Users\Amir Hossin\Desktop\News_App\Web\Views\ShowNews\ShowgroupsArchive.cshtml"
                   Write(item.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <span><i class=\"fa fa-calendar\"></i> انتشار : ");
#nullable restore
#line 23 "C:\Users\Amir Hossin\Desktop\News_App\Web\Views\ShowNews\ShowgroupsArchive.cshtml"
                                                             Write(Utilitis.DateConvertor.DateConvertor.ToShamsi(item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span>بازدید : ");
#nullable restore
#line 24 "C:\Users\Amir Hossin\Desktop\News_App\Web\Views\ShowNews\ShowgroupsArchive.cshtml"
                              Write(item.Visist);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span>پسند : ");
#nullable restore
#line 25 "C:\Users\Amir Hossin\Desktop\News_App\Web\Views\ShowNews\ShowgroupsArchive.cshtml"
                            Write(item.Like);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li>\r\n");
#nullable restore
#line 27 "C:\Users\Amir Hossin\Desktop\News_App\Web\Views\ShowNews\ShowgroupsArchive.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </ul>\r\n    </section>\r\n    <!-- End last news -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DomainClass.PagesTB>> Html { get; private set; }
    }
}
#pragma warning restore 1591
