#pragma checksum "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dea4db3c7a8f98d95cfdc2afe6e6bd85f4dd9fbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
#line 1 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\_ViewImports.cshtml"
using WatchManageStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\_ViewImports.cshtml"
using WatchManageStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea4db3c7a8f98d95cfdc2afe6e6bd85f4dd9fbc", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0897fb513dcf51d4d8d0f59fb37e263cfb4c8a06", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WatchManageStore.Areas.Admin.Models.StoreVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-box-inner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""breadcrumb-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <!-- breadcrumb-list start -->
                <ul class=""breadcrumb-list"">
                    <li class=""breadcrumb-item"">");
#nullable restore
#line 13 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\Shop\Index.cshtml"
                                           Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    <li class=""breadcrumb-item active"">Shop</li>
                </ul>
                <!-- breadcrumb-list end -->
            </div>
        </div>
    </div>
</div>
<div class=""product-area section-pb section-pt-30"">
    <div class=""container"">
        <div class=""tab-pane fade show active"">
            <div class=""product-carousel-group"">

                <div class=""row"" id=""listStore"">
");
#nullable restore
#line 27 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\Shop\Index.cshtml"
                     foreach (var item in Model)
                    {
                        string link = $"/Shop/Details/{item.StoreId}";
                        var id = @item.StoreId;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-lg-4"">
                            <!-- single-product-area start -->
                            <div class=""single-product-area mt-30"">
                                <div class=""product-thumb"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 1319, "\"", 1353, 2);
            WriteAttributeValue("", 1326, "/Shop/Details/", 1326, 14, true);
#nullable restore
#line 35 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\Shop\Index.cshtml"
WriteAttributeValue("", 1340, item.StoreId, 1340, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <img class=\"primary-image\"");
            BeginWriteAttribute("src", " src=", 1423, "", 1444, 2);
            WriteAttributeValue("", 1428, "imgs/", 1428, 5, true);
#nullable restore
#line 36 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\Shop\Index.cshtml"
WriteAttributeValue("", 1433, item.Image, 1433, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"360\" height=\"318\"");
            BeginWriteAttribute("alt", " alt=\"", 1469, "\"", 1475, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </a>
                                </div>
                                <div class=""product-caption"">
                                    <div class=""price-box"">
                                        <div>
                                            <a> <h3>");
#nullable restore
#line 42 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\Shop\Index.cshtml"
                                               Write(item.StoreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3> </a>\r\n                                        </div>\r\n                                        <div>\r\n                                            <i class=\"far fa-map\"></i>\r\n                                            <span>");
#nullable restore
#line 46 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\Shop\Index.cshtml"
                                             Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        </div>
                                        <div>
                                            <a href=""#"" class=""phone"">
                                                <i class=""fas fa-tty""></i> <span>
                                               Điện thoại: ");
#nullable restore
#line 51 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\Shop\Index.cshtml"
                                                      Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                             </span>\r\n                                            </a>\r\n                                        </div>\r\n                                        <div>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2617, "\"", 2629, 1);
#nullable restore
#line 56 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2624, link, 2624, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" title=""cua-hang-truc-tuyen-online-voi-uu-dai"">
                                                <i class=""fas fa-map-signs""></i> <span>Giới thiệu cửa hàng đồng hồ</span>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- single-product-area end -->
                        </div>
");
#nullable restore
#line 65 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\Shop\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).on('click', '#search', function () {
            $(""#search-form"").submit((e) => {
                e.preventDefault();
            });
            var value = $(""#myInput"").val().trim().toLowerCase();
            $.ajax({
                url: '/Shop/SearchStore',
                type: 'get',
                data: { search: value },
                success: function (data) {
                    $('#listStore').empty();
                    $.each(data.searchItem, function (k, v) {
                        let str = `<div class=""col-lg-4"">
                                <div class=""single-product-area mt-30"">
                                    <div class=""product-thumb"">
                                        <a>
                                            <img class=""primary-image"" src=""imgs/${v.image}"" width=""360"" height=""318"" alt="""">
                                            </a>
                                        </div>
                         ");
                WriteLiteral(@"               <div class=""product-caption"">
                                            <div class=""price-box"">
                                                <div>
                                                    <a> <h3>${v.storeName}</h3> </a>
                                                </div>
                                                <div>
                                                    <i class=""far fa-map""></i>
                                                    <span>${v.address}</span>
                                                </div>
                                                <div>
                                                    <a href=""#"" class=""phone"">
                                                        <i class=""fas fa-tty""></i> <span>
                                                            ${v.phone}
                                                        </span>
                                                    </a>
                     ");
                WriteLiteral(@"                           </div>
                                                <div>
                                                    <a href=""/Shop/Details/${v.storeId}"" title=""cua-hang-truc-tuyen-online-voi-uu-dai"">
                                                        <i class=""fas fa-map-signs""></i> <span>Giới thiệu cửa hàng đồng hồ</span>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                             </div>`;
                        document.querySelector('#listStore').insertAdjacentHTML('beforeend', str);
                    })
                },
                error: function (xhr, status, error) {
                    console.log(xhr);
                }
            });
        })

    </script>
");
            }
            );
            DefineSection("search", async() => {
                WriteLiteral("\r\n    <div class=\"search-box-wrapper\">\r\n        <div class=\"search-box-inner-wrap\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dea4db3c7a8f98d95cfdc2afe6e6bd85f4dd9fbc13677", async() => {
                    WriteLiteral(@"
                <div class=""search-field-wrap"">
                    <input type=""text"" class=""search-field"" placeholder=""Tìm kiếm..."" id=""myInput"">

                    <div class=""search-btn"">
                        <button id=""search""><i class=""icon-magnifier""></i></button>
                    </div>
                </div>

            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WatchManageStore.Areas.Admin.Models.StoreVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
