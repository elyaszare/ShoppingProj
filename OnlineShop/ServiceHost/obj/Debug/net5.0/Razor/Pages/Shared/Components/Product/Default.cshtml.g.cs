#pragma checksum "D:\PistachioShop\OnlineShop\OnlineShop\ServiceHost\Pages\Shared\Components\Product\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08934a58aa7bfe4321e76d10dbaa4772f10d7f98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Product.Pages_Shared_Components_Product_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Product/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Product
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
#line 1 "D:\PistachioShop\OnlineShop\OnlineShop\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08934a58aa7bfe4321e76d10dbaa4772f10d7f98", @"/Pages/Shared/Components/Product/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d027006424b9e12b1709732f146fce9f1d78e6a1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Product_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_01_Query.Contracts.Product.ProductQueryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-main"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<section class=\"products\">\r\n\r\n    <!--Header-->\r\n\r\n    <header>\r\n        <div class=\"container\">\r\n            <h2 class=\"title\">محصولات محبوب</h2>\r\n            <div class=\"text\">\r\n                <p>\r\n                    مطابقت کامل خود را پیدا کنید ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08934a58aa7bfe4321e76d10dbaa4772f10d7f984330", async() => {
                WriteLiteral("مشاهده همه");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </header>\r\n\r\n    <!--Content-->\r\n\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row\">\r\n\r\n            <!--Product item-->\r\n\r\n");
#nullable restore
#line 27 "D:\PistachioShop\OnlineShop\OnlineShop\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
             foreach (var product in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-6 col-lg-4"">
                    <article>
                        <div class=""info"">
                            <span class=""add-favorite"">
                                <a href=""javascript:void(0);"" data-title=""افزودن به علاقه مندی ها"" data-title-added=""افزودن به  لیست علاقه مندی "">
                                    <i class=""icon icon-heart""></i>
                                </a>
                            </span>
                            <span>
                                <a href=""#productid1"" class=""mfp-open"" data-title=""نمایش سریع "">
                                    <i class=""icon icon-eye""></i>
                                </a>
                            </span>
                        </div>
                        <div class=""btn btn-add"">
                            <i class=""icon icon-cart""></i>
                        </div>
                        <div class=""figure-grid"">
                            <div class=""image"">
   ");
            WriteLiteral("                             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08934a58aa7bfe4321e76d10dbaa4772f10d7f987177", async() => {
                WriteLiteral("\r\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 1774, "\"", 1812, 2);
                WriteAttributeValue("", 1780, "ProductPictures/", 1780, 16, true);
#nullable restore
#line 49 "D:\PistachioShop\OnlineShop\OnlineShop\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
WriteAttributeValue("", 1796, product.Picture, 1796, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1813, "\"", 1838, 1);
#nullable restore
#line 49 "D:\PistachioShop\OnlineShop\OnlineShop\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
WriteAttributeValue("", 1819, product.PictureAlt, 1819, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1839, "\"", 1868, 1);
#nullable restore
#line 49 "D:\PistachioShop\OnlineShop\OnlineShop\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
WriteAttributeValue("", 1847, product.PictureTitle, 1847, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\PistachioShop\OnlineShop\OnlineShop\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                                         WriteLiteral(product.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"text\">\r\n                                <h2 class=\"title h4\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08934a58aa7bfe4321e76d10dbaa4772f10d7f9810838", async() => {
#nullable restore
#line 54 "D:\PistachioShop\OnlineShop\OnlineShop\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                                                                   Write(product.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "D:\PistachioShop\OnlineShop\OnlineShop\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                                             WriteLiteral(product.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </h2>\r\n                                <sub>");
#nullable restore
#line 56 "D:\PistachioShop\OnlineShop\OnlineShop\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</sub>\r\n");
#nullable restore
#line 57 "D:\PistachioShop\OnlineShop\OnlineShop\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                 if (product.HasDiscount)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <sup>");
#nullable restore
#line 59 "D:\PistachioShop\OnlineShop\OnlineShop\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                    Write(product.PriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</sup>\r\n");
#nullable restore
#line 60 "D:\PistachioShop\OnlineShop\OnlineShop\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                                }                               

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"description clearfix\">\r\n                                    ");
#nullable restore
#line 62 "D:\PistachioShop\OnlineShop\OnlineShop\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
                               Write(product.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </div>\r\n                        </div>\r\n                    </article>\r\n                </div>\r\n");
#nullable restore
#line 68 "D:\PistachioShop\OnlineShop\OnlineShop\ServiceHost\Pages\Shared\Components\Product\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div> <!--/row-->\r\n\r\n    </div>\r\n\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_01_Query.Contracts.Product.ProductQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
