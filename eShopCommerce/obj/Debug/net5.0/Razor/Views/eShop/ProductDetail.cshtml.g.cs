#pragma checksum "D:\ProJectChuan\bShop\eShopCommerce\Views\eShop\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08ceb20446b0cd68a62b29db6458001fd5f57478"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_eShop_ProductDetail), @"mvc.1.0.view", @"/Views/eShop/ProductDetail.cshtml")]
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
#line 1 "D:\ProJectChuan\bShop\eShopCommerce\Views\_ViewImports.cshtml"
using eShopCommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ProJectChuan\bShop\eShopCommerce\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ProJectChuan\bShop\eShopCommerce\Views\_ViewImports.cshtml"
using eShopCommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08ceb20446b0cd68a62b29db6458001fd5f57478", @"/Views/eShop/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"666b7fcb5af5046f427e1b56838a6697d660402a", @"/Views/_ViewImports.cshtml")]
    public class Views_eShop_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eShopCommerce.ViewModel.ProductDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal qtyFrm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal qtyFrm pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\ProJectChuan\bShop\eShopCommerce\Views\eShop\ProductDetail.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""span9"">
    <ul class=""breadcrumb"">
        <li><a href=""index.html"">Home</a> <span class=""divider"">/</span></li>
        <li><a href=""products.html"">Products</a> <span class=""divider"">/</span></li>
        <li class=""active"">product Details</li>
    </ul>
    <div class=""row"">
        <div id=""gallery"" class=""span3"">
            <a href=""~user/themes/images/products/large/f1.jpg"" title=""Fujifilm FinePix S2950 Digital Camera"">
                <img src=""themes/images/products/large/3.jpg"" style=""width:100%"" alt=""Fujifilm FinePix S2950 Digital Camera"" />
            </a>
            <div id=""differentview"" class=""moreOptopm carousel slide"">
                <div class=""carousel-inner"">
                    <div class=""item active"">
                        <a href=""themes/images/products/large/f1.jpg""> <img style=""width:29%"" src=""themes/images/products/large/f1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1010, "\"", 1016, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                        <a href=\"themes/images/products/large/f2.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1161, "\"", 1167, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                        <a href=\"themes/images/products/large/f3.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1312, "\"", 1318, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                    </div>\r\n                    <div class=\"item\">\r\n                        <a href=\"themes/images/products/large/f3.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1531, "\"", 1537, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                        <a href=\"themes/images/products/large/f1.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1682, "\"", 1688, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                        <a href=\"themes/images/products/large/f2.jpg\"> <img style=\"width:29%\" src=\"themes/images/products/large/f2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 1833, "\"", 1839, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                    </div>
                </div>
                <!--
                <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">‹</a>
                <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"">›</a>
                -->
            </div>

            <div class=""btn-toolbar"">
                <div class=""btn-group"">
                    <span class=""btn""><i class=""icon-envelope""></i></span>
                    <span class=""btn""><i class=""icon-print""></i></span>
                    <span class=""btn""><i class=""icon-zoom-in""></i></span>
                    <span class=""btn""><i class=""icon-star""></i></span>
                    <span class=""btn""><i class="" icon-thumbs-up""></i></span>
                    <span class=""btn""><i class=""icon-thumbs-down""></i></span>
                </div>
            </div>
        </div>
        <div class=""span6"">
            <h3> ");
#nullable restore
#line 48 "D:\ProJectChuan\bShop\eShopCommerce\Views\eShop\ProductDetail.cshtml"
            Write(Model.product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n            <small>- (14MP, 18x Optical Zoom) 3-inch LCD</small>\r\n            <hr class=\"soft\" />\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08ceb20446b0cd68a62b29db6458001fd5f574788441", async() => {
                WriteLiteral("\r\n                <div class=\"control-group\">\r\n                    <label class=\"control-label\"><span>");
#nullable restore
#line 53 "D:\ProJectChuan\bShop\eShopCommerce\Views\eShop\ProductDetail.cshtml"
                                                  Write(Model.product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></label>
                    <div class=""controls"">
                        <input type=""number"" class=""span1"" placeholder=""Qty."" />
                        <button type=""submit"" class=""btn btn-large btn-primary pull-right""> Add to cart <i class="" icon-shopping-cart""></i></button>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <hr class=\"soft\" />\r\n            <h4>");
#nullable restore
#line 62 "D:\ProJectChuan\bShop\eShopCommerce\Views\eShop\ProductDetail.cshtml"
           Write(Model.product.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral(" In Stock</h4>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08ceb20446b0cd68a62b29db6458001fd5f5747810805", async() => {
                WriteLiteral("\r\n                <div class=\"control-group\">\r\n                    <label class=\"control-label\"><span>Color</span></label>\r\n                    <div class=\"controls\">\r\n                        <select class=\"span2\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08ceb20446b0cd68a62b29db6458001fd5f5747811322", async() => {
                    WriteLiteral("Black");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08ceb20446b0cd68a62b29db6458001fd5f5747812364", async() => {
                    WriteLiteral("Red");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08ceb20446b0cd68a62b29db6458001fd5f5747813404", async() => {
                    WriteLiteral("Blue");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08ceb20446b0cd68a62b29db6458001fd5f5747814445", async() => {
                    WriteLiteral("Brown");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <hr class=""soft clr"" />
            <p>
                14 Megapixels. 18.0 x Optical Zoom. 3.0-inch LCD Screen. Full HD photos and 1280 x 720p HD movie capture. ISO sensitivity ISO6400 at reduced resolution.
                Tracking Auto Focus. Motion Panorama Mode. Face Detection technology with Blink detection and Smile and shoot mode. 4 x AA batteries not included. WxDxH 110.2 ×81.4x73.4mm.
                Weight 0.341kg (excluding battery and memory card). Weight 0.437kg (including battery and memory card).

            </p>
            <a class=""btn btn-small pull-right"" href=""#detail"">More Details</a>
            <br class=""clr"" />
            <a href=""#"" name=""detail""></a>
            <hr class=""soft"" />
        </div>

        <div class=""span9"">
            <ul id=""productDetail"" class=""nav nav-tabs"">
                <li><a href=""#profile"" data-toggle=""tab"">Related Products</a></li>
            </ul>
            <div id=""myTabContent"" class=""tab-content"">

          ");
            WriteLiteral(@"      <div class=""tab-pane active"" id=""profile"">
                    <div id=""myTab"" class=""pull-right"">
                        <a href=""#blockView"" data-toggle=""tab""><span class=""btn btn-large btn-primary""><i class=""icon-th-large""></i></span></a>
                    </div>
                    <br class=""clr"" />
                    <hr class=""soft"" />
                    <div class=""tab-content"">
                        <div class=""tab-pane active"" id=""blockView"">
                            <ul class=""thumbnails"">

");
#nullable restore
#line 105 "D:\ProJectChuan\bShop\eShopCommerce\Views\eShop\ProductDetail.cshtml"
                                 foreach (var item in Model.productincategory)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"span3\">\r\n                                        <div class=\"thumbnail\">\r\n                                            <a href=\"product_details.html\"><img src=\"themes/images/products/10.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6037, "\"", 6043, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                                            <div class=\"caption\">\r\n                                                <h5>");
#nullable restore
#line 111 "D:\ProJectChuan\bShop\eShopCommerce\Views\eShop\ProductDetail.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                                <p>
                                                    Lorem Ipsum is simply dummy text.
                                                </p>
                                                <h4 style=""text-align:center""><a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a> <a class=""btn"" href=""#"">Add to <i class=""icon-shopping-cart""></i></a> <a class=""btn btn-primary"" href=""#"">&euro;");
#nullable restore
#line 115 "D:\ProJectChuan\bShop\eShopCommerce\Views\eShop\ProductDetail.cshtml"
                                                                                                                                                                                                                                                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                            </div>\r\n                                        </div>\r\n                                    </li>\r\n");
#nullable restore
#line 119 "D:\ProJectChuan\bShop\eShopCommerce\Views\eShop\ProductDetail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </ul>
                            <hr class=""soft"" />
                        </div>
                    </div>
                    <br class=""clr"">
                </div>
            </div>
        </div>

    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eShopCommerce.ViewModel.ProductDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
