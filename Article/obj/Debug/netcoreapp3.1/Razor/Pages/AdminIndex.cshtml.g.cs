#pragma checksum "E:\Project\Article\Article\Pages\AdminIndex.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b8f5d0b50f455920e68a7b23347ba2bab5ce6cda3d291c347fd59e2259b966db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Article.Pages.Pages_AdminIndex), @"mvc.1.0.razor-page", @"/Pages/AdminIndex.cshtml")]
namespace Article.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Project\Article\Article\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\Article\Article\Pages\_ViewImports.cshtml"
using Article;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Project\Article\Article\Pages\_ViewImports.cshtml"
using Article.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b8f5d0b50f455920e68a7b23347ba2bab5ce6cda3d291c347fd59e2259b966db", @"/Pages/AdminIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e777a0b9d5257eb842c7188716d86e2ebe20afd2a8f31631bb46b32d15c47a93", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_AdminIndex : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Project\Article\Article\Pages\AdminIndex.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""Cont"">
    <section>
        <div class=""container"">
            <div class=""photo-card"">
                <div class=""photo-background"" style=""background-image:url(&quot;~/img/product-aeon-feature.jpg&quot;);""></div>
                <div class=""photo-details"">
                    <h1 style=""font-family: Cairo, sans-serif;"">مرحبا بك &nbsp;</h1>
                    <p style=""text-align: center;"">يسعدنا&nbsp; انضمامك الينا , يمكنك من خلال لوحة التحكم ادارة المحتوى الخاص بك على الموقع&nbsp;</p>
                    <div class=""photo-tags""></div>
                </div>
            </div>
        </div>
    </section>
    <div class=""row space-rows"">
        <div class=""col"">
            <div class=""card cards-shadown cards-hover"" data-aos=""flip-left"" data-aos-duration=""950"">
                <div class=""card-header"">
                    <span class=""space""><a href=""#""><i class=""fa fa-cloud-download"" id=""download-icon-1""></i></a></span>
                    <div class=""cardheader-text"">
   ");
            WriteLiteral("                      <h4 id=\"heading-card-1\" style=\"text-align: center;font-size: 81px;\">");
#nullable restore
#line 25 "E:\Project\Article\Article\Pages\AdminIndex.cshtml"
                                                                                        Write(Model.AllPost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4> 
                    </div>
                </div>
                <div class=""card-body"">
                    <p class=""card-text cardbody-sub-text"" style=""text-align: center;"">مشاركاتك الكلية</p>
                </div>
            </div>
        </div>
        <div class=""col"">
            <div class=""card cards-shadown cards-hover"" data-aos=""slide-right"" data-aos-duration=""950"">
                <div class=""card-header"">
                    <span class=""space""><a href=""#""><i class=""fa fa-cloud-download"" id=""download-icon-2""></i></a></span>
                    <div class=""cardheader-text"">
                         <h4 id=""heading-card-2"" style=""text-align: center;font-size: 81px;"">");
#nullable restore
#line 38 "E:\Project\Article\Article\Pages\AdminIndex.cshtml"
                                                                                        Write(Model.PostThisYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4> 
                    </div>
                </div>
                <div class=""card-body"">
                    <p class=""card-text cardbody-sub-text"" style=""text-align: center;"">مشاركاتك لهذه السنة</p>
                </div>
            </div>
        </div>
        <div class=""col"">
            <div class=""card cards-shadown cards-hover"" data-aos=""flip-up"" data-aos-duration=""950"">
                <div class=""card-header cards-header-hover"">
                    <span class=""space""><a href=""#""><i class=""fa fa-cloud-download"" id=""download-icon-3""></i></a></span>
                    <div class=""cardheader-text"">
                         <h4 id=""heading-card-3"" style=""text-align: center;font-size: 81px;"">");
#nullable restore
#line 51 "E:\Project\Article\Article\Pages\AdminIndex.cshtml"
                                                                                        Write(Model.PostLastMouth);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4> 
                    </div>
                </div>
                <div class=""card-body"">
                    <p class=""card-text sub-text-color""></p>
                    <p class=""card-text cardbody-sub-text"" style=""text-align: center;"">مشاركاتك لهذه الشهر</p>
                </div>
            </div>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Article.Pages.AdminIndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Article.Pages.AdminIndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Article.Pages.AdminIndexModel>)PageContext?.ViewData;
        public Article.Pages.AdminIndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
