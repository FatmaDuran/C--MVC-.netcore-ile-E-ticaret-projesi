#pragma checksum "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6171b2288adc0a7d86362825cc6dc8287eb1a4f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Details.cshtml", typeof(AspNetCore.Views_Product_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6171b2288adc0a7d86362825cc6dc8287eb1a4f1", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca56290ea2b4e6e706bf8f2f5a368239875dd5ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(71, 394, true);
            WriteLiteral(@"
    <section id=""content"">

        <!-- shop section start -->
        <section id=""shop"" class=""container"">

            <!-- row start -->
            <div class=""row"">

                <!-- sidebar start -->
                <div id=""sidebar"" class=""col-md-3"">

                    <!-- search widget start -->
                    <div class=""widget"">
                        ");
            EndContext();
            BeginContext(465, 490, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6171b2288adc0a7d86362825cc6dc8287eb1a4f16021", async() => {
                BeginContext(491, 457, true);
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
            BeginContext(955, 152, true);
            WriteLiteral("\r\n                    </div>\r\n                    <!-- search widget end -->\r\n                    <!-- categories widget start -->\r\n                    ");
            EndContext();
            BeginContext(1108, 43, false);
#line 30 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
               Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 135, true);
            WriteLiteral("\r\n                    <!-- categories widget end -->\r\n                    <!-- featured products widget start -->\r\n                    ");
            EndContext();
            BeginContext(1287, 47, false);
#line 33 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
               Write(await Component.InvokeAsync("FeaturedProducts"));

#line default
#line hidden
            EndContext();
            BeginContext(1334, 611, true);
            WriteLiteral(@"
                    <!-- featured products widget end -->

                </div>
                <!-- sidebar end -->
                <!-- main column start -->
                <div class=""col-md-9"">

                    <div class=""row"">


                        <!-- product page top info start -->
                        <div class=""col-md-12 product"">
                            <div class=""row"">
                                <div class=""col-md-6"">

                                    <div id=""product-gallery"" class=""owl-carousel owl-theme"" style=""opacity: 1; display: block;"">

");
            EndContext();
#line 51 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
                                         foreach (var img in Model.ProductImages)
                                        {

#line default
#line hidden
            BeginContext(2071, 112, true);
            WriteLiteral("                                            <div class=\"item\">\r\n                                                ");
            EndContext();
            BeginContext(2183, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6171b2288adc0a7d86362825cc6dc8287eb1a4f110136", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2223, "~/images/products/", 2223, 18, true);
#line 54 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 2241, img.ImageName, 2241, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2259, 54, true);
            WriteLiteral("\r\n                                            </div>\r\n");
            EndContext();
#line 56 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2356, 282, true);
            WriteLiteral(@"


                                    </div>

                                </div>

                                <div class=""col-md-6"">

                                    <div class=""padding15"">
                                        <h2 class=""product-title""><b>");
            EndContext();
            BeginContext(2639, 25, false);
#line 67 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
                                                                Write(Model.Product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2664, 386, true);
            WriteLiteral(@"</b></h2>
                                        <p>
                                            <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                         
                                        </p>
                                        <p class=""product-price"">");
            EndContext();
            BeginContext(3051, 19, false);
#line 72 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
                                                            Write(Model.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3070, 92, true);
            WriteLiteral(" ???</p>\r\n                                    </div>\r\n                                    <p> ");
            EndContext();
            BeginContext(3163, 25, false);
#line 74 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
                                   Write(Model.Product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3188, 113, true);
            WriteLiteral("</p>\r\n\r\n\r\n                                    <div class=\"padding15\">\r\n\r\n                                        ");
            EndContext();
            BeginContext(3301, 951, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6171b2288adc0a7d86362825cc6dc8287eb1a4f114255", async() => {
                BeginContext(3387, 83, true);
                WriteLiteral("\r\n                                            <input type=\"hidden\" name=\"ProductId\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 3470, "", 3501, 1);
#line 80 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
WriteAttributeValue("", 3477, Model.Product.ProductId, 3477, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3501, 744, true);
                WriteLiteral(@"/>

                                            <div class=""form-group qty"">
                                                <div class=""input-group"">
                                                    <span class=""input-group-addon"">Adet</span>
                                                    <input type=""number"" size=""4"" name=""quantity"" class=""form-control"" value=""1"" min=""1"" step=""1"">
                                                </div>
                                            </div>
                                            <button type=""submit"" class=""btn btn-primary"">
                                            <i class=""fa fa-cart-plus fa-fw""></i> Sepete Ekle</button>
                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4252, 146, true);
            WriteLiteral("\r\n\r\n                                    </div>\r\n\r\n                                    <p><b>Category:</b> \r\n                                    \r\n");
            EndContext();
#line 96 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
                                     foreach (var item in Model.Categories)
                                    {

#line default
#line hidden
            BeginContext(4514, 49, true);
            WriteLiteral("                                     <a href=\"#\">");
            EndContext();
            BeginContext(4564, 17, false);
#line 98 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
                                            Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(4581, 7, true);
            WriteLiteral("</a> \r\n");
            EndContext();
#line 99 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
                                     }

#line default
#line hidden
            BeginContext(4628, 599, true);
            WriteLiteral(@"
                                    </p>

                                </div>
                            </div>
                        </div>
                        <!-- product page top info end -->
                        <!-- product page middle info start -->
                        <div class=""col-md-12 padding25"">


                            <ul class=""nav nav-tabs"">
                                <li class=""active""><a data-toggle=""tab"" href=""#description"">A????klama</a></li>
                                <li><a data-toggle=""tab"" href=""#spec"">??zellikler</a></li>
");
            EndContext();
            BeginContext(5326, 286, true);
            WriteLiteral(@"                            </ul>


                            <div class=""tab-content"">

                                <!-- description tab start -->
                                <div id=""description"" class=""tab-pane fade in active"">
                                      ");
            EndContext();
            BeginContext(5613, 35, false);
#line 122 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
                                 Write(Html.Raw(Model.Product.HtmlContent));

#line default
#line hidden
            EndContext();
            BeginContext(5648, 486, true);
            WriteLiteral(@"
                                
                                </div>
                                <!-- description tab end -->
                                <!-- Specifications tab start -->
                                <div id=""spec"" class=""tab-pane fade"">
                                    <div class=""table-responsive"">
                                        <table class=""table table-striped table-hover"">
                                            <tbody>
");
            EndContext();
#line 131 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
                                                 foreach (var item in Model.ProductAttributes)
                                                {

#line default
#line hidden
            BeginContext(6281, 121, true);
            WriteLiteral("                                                    <tr>\r\n                                                        <td><b>");
            EndContext();
            BeginContext(6403, 14, false);
#line 134 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
                                                          Write(item.Attribute);

#line default
#line hidden
            EndContext();
            BeginContext(6417, 71, true);
            WriteLiteral("</b></td>\r\n                                                        <td>");
            EndContext();
            BeginContext(6489, 10, false);
#line 135 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
                                                       Write(item.Value);

#line default
#line hidden
            EndContext();
            BeginContext(6499, 66, true);
            WriteLiteral("</td>\r\n                                                    </tr>\r\n");
            EndContext();
#line 137 "C:\Users\Fatma Duran\Desktop\Eshop\Eshop.WebUI\Views\Product\Details.cshtml"
                                                }

#line default
#line hidden
            BeginContext(6616, 319, true);
            WriteLiteral(@"


                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <!-- Specifications tab end -->
                                <!-- reviews tab start -->
");
            EndContext();
            BeginContext(11980, 420, true);
            WriteLiteral(@"                                <!-- reviews tab end -->

                            </div>

                        </div>
                       

                    </div>
                    <!-- row end -->

                </div>
                <!-- main column end -->

            </div>
            <!-- row end -->

        </section>
        <!-- shop section end -->

    </section>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
