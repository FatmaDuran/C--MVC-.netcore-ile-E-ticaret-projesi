#pragma checksum "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1526d71caf60dee081bac7b5c6aff98fbfcc7d09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/List.cshtml", typeof(AspNetCore.Views_Product_List))]
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
#line 1 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\_ViewImports.cshtml"
using Eshop.WebUI.Entity;

#line default
#line hidden
#line 2 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\_ViewImports.cshtml"
using Eshop.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1526d71caf60dee081bac7b5c6aff98fbfcc7d09", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca56290ea2b4e6e706bf8f2f5a368239875dd5ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Eshop.WebUI.Infrastructure.PageLinkTagHelper __Eshop_WebUI_Infrastructure_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 42, true);
            WriteLiteral("    <!-- ViewData[\"Title\"] = \"Index\";-->\r\n");
            EndContext();
            BeginContext(74, 247, true);
            WriteLiteral("\r\n<section id=\"content\">\r\n\r\n    <section id=\"shop\" class=\"container\">\r\n\r\n        <div class=\"row\">\r\n\r\n            <!-- sidebar start -->\r\n            <div id=\"sidebar\" class=\"col-md-3\">\r\n\r\n                <div class=\"widget\">\r\n                    ");
            EndContext();
            BeginContext(321, 464, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1526d71caf60dee081bac7b5c6aff98fbfcc7d094526", async() => {
                BeginContext(347, 431, true);
                WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control input-lg"" placeholder=""Search..."">
                            <span class=""input-group-btn"">
                                <button class=""btn btn-default btn-lg"" type=""submit""><i class=""fa fa-search""></i></button>
                            </span>
                        </div>

                    ");
                EndContext();
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
            EndContext();
            BeginContext(785, 46, true);
            WriteLiteral("\r\n                </div>\r\n\r\n\r\n                ");
            EndContext();
            BeginContext(832, 43, false);
#line 28 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\List.cshtml"
           Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(875, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(896, 47, false);
#line 30 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\List.cshtml"
           Write(await Component.InvokeAsync("FeaturedProducts"));

#line default
#line hidden
            EndContext();
            BeginContext(943, 575, true);
            WriteLiteral(@"



            </div>
            <!-- sidebar end -->
            <!-- right column start -->
            <div class=""col-md-9"">

                <div class=""row"">

                    <div class=""col-md-12 wow fadeIn"" style=""visibility: visible; animation-name: fadeIn;"">
                        <div class=""row product-results"">
                            <div class=""product-results"">
                                <div class=""col-xs-8"">
                                    <p class=""woocommerce-result-count"">
                                        ");
            EndContext();
            BeginContext(1519, 27, false);
#line 46 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\List.cshtml"
                                   Write(Model.PagingInfo.TotalItems);

#line default
#line hidden
            EndContext();
            BeginContext(1546, 195, true);
            WriteLiteral(" ??r??n var\r\n                                    </p>\r\n                                </div>\r\n\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n");
            EndContext();
#line 55 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\List.cshtml"
                     foreach (var product in Model.Products)
                    {
                        

#line default
#line hidden
            BeginContext(1851, 37, false);
#line 57 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\List.cshtml"
                   Write(Html.Partial("_ProductItem", product));

#line default
#line hidden
            EndContext();
#line 57 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\List.cshtml"
                                                              
                    }

#line default
#line hidden
            BeginContext(1913, 50, true);
            WriteLiteral("\r\n\r\n\r\n\r\n                </div>\r\n\r\n                ");
            EndContext();
            BeginContext(1963, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1526d71caf60dee081bac7b5c6aff98fbfcc7d099293", async() => {
            }
            );
            __Eshop_WebUI_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::Eshop.WebUI.Infrastructure.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__Eshop_WebUI_Infrastructure_PageLinkTagHelper);
#line 65 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\List.cshtml"
__Eshop_WebUI_Infrastructure_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __Eshop_WebUI_Infrastructure_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Eshop_WebUI_Infrastructure_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2024, 136, true);
            WriteLiteral("\r\n               \r\n\r\n            </div>\r\n            <!-- right column end -->\r\n\r\n        </div>\r\n\r\n\r\n\r\n    </section>\r\n\r\n\r\n\r\n</section>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
