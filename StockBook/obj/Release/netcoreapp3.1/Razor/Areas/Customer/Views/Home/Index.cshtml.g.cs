#pragma checksum "C:\Users\S1\Source\Repos\sim1zzo\stockBook\StockBook\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9ea2cc53ddced8540bfe9b24600c87e8986b2e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\S1\Source\Repos\sim1zzo\stockBook\StockBook\Areas\Customer\Views\_ViewImports.cshtml"
using StockBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\S1\Source\Repos\sim1zzo\stockBook\StockBook\Areas\Customer\Views\_ViewImports.cshtml"
using StockBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9ea2cc53ddced8540bfe9b24600c87e8986b2e7", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a8d7532960c5efc21e672528c535c66f5df2a5f", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StockBook.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"row pb-3 backgroundWhite\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\S1\Source\Repos\sim1zzo\stockBook\StockBook\Areas\Customer\Views\Home\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-lg-3 col-md-6"">
            <div class=""row p-2"">
                <div class=""col-12  p-1"" style=""border:1px solid #008cba; border-radius: 5px;"">
                    <div class=""card"" style=""border:0px;"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 395, "\"", 418, 1);
#nullable restore
#line 11 "C:\Users\S1\Source\Repos\sim1zzo\stockBook\StockBook\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 401, product.ImageUrl, 401, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top rounded\" />\r\n                        <div class=\"pl-1\">\r\n                            <p class=\"card-title h5\"><b style=\"color:#2c3e50\">");
#nullable restore
#line 13 "C:\Users\S1\Source\Repos\sim1zzo\stockBook\StockBook\Areas\Customer\Views\Home\Index.cshtml"
                                                                         Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                            <p class=\"card-title text-primary\">by <b>");
#nullable restore
#line 14 "C:\Users\S1\Source\Repos\sim1zzo\stockBook\StockBook\Areas\Customer\Views\Home\Index.cshtml"
                                                                Write(product.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                        </div>\r\n                        <div style=\"padding-left:5px;\">\r\n                            <p>List Price: <strike><b");
            BeginWriteAttribute("class", " class=\"", 835, "\"", 843, 0);
            EndWriteAttribute();
            WriteLiteral(">$");
#nullable restore
#line 17 "C:\Users\S1\Source\Repos\sim1zzo\stockBook\StockBook\Areas\Customer\Views\Home\Index.cshtml"
                                                           Write(product.ListPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></strike></p>\r\n                        </div>\r\n                        <div style=\"padding-left:5px;\">\r\n                            <p style=\"color:maroon\">As low as: <b");
            BeginWriteAttribute("class", " class=\"", 1054, "\"", 1062, 0);
            EndWriteAttribute();
            WriteLiteral(">$");
#nullable restore
#line 20 "C:\Users\S1\Source\Repos\sim1zzo\stockBook\StockBook\Areas\Customer\Views\Home\Index.cshtml"
                                                                       Write(product.Price100.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                        </div>\r\n                    </div>\r\n                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9ea2cc53ddced8540bfe9b24600c87e8986b2e77045", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "C:\Users\S1\Source\Repos\sim1zzo\stockBook\StockBook\Areas\Customer\Views\Home\Index.cshtml"
                                                                                       WriteLiteral(product.Id);

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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\S1\Source\Repos\sim1zzo\stockBook\StockBook\Areas\Customer\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StockBook.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
