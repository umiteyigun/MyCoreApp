#pragma checksum "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b515e62f9cc343636faa3d9b3bf583363268b186"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basvuru_Details), @"mvc.1.0.view", @"/Views/Basvuru/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Basvuru/Details.cshtml", typeof(AspNetCore.Views_Basvuru_Details))]
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
#line 1 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/_ViewImports.cshtml"
using MyCoreApp;

#line default
#line hidden
#line 2 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/_ViewImports.cshtml"
using MyCoreApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b515e62f9cc343636faa3d9b3bf583363268b186", @"/Views/Basvuru/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"224f88aa75ff6d3c99933279967dd8620010770e", @"/Views/_ViewImports.cshtml")]
    public class Views_Basvuru_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyCoreApp.Models.Basvuru>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Basvuru</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(200, 40, false);
#line 14 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Badi));

#line default
#line hidden
            EndContext();
            BeginContext(240, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(284, 36, false);
#line 17 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Badi));

#line default
#line hidden
            EndContext();
            BeginContext(320, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(364, 43, false);
#line 20 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bsoyadi));

#line default
#line hidden
            EndContext();
            BeginContext(407, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(451, 39, false);
#line 23 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bsoyadi));

#line default
#line hidden
            EndContext();
            BeginContext(490, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(534, 39, false);
#line 26 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Btc));

#line default
#line hidden
            EndContext();
            BeginContext(573, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(617, 35, false);
#line 29 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Btc));

#line default
#line hidden
            EndContext();
            BeginContext(652, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(696, 42, false);
#line 32 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bemail));

#line default
#line hidden
            EndContext();
            BeginContext(738, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(782, 38, false);
#line 35 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bemail));

#line default
#line hidden
            EndContext();
            BeginContext(820, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(864, 43, false);
#line 38 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Badresi));

#line default
#line hidden
            EndContext();
            BeginContext(907, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(951, 39, false);
#line 41 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Badresi));

#line default
#line hidden
            EndContext();
            BeginContext(990, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1034, 45, false);
#line 44 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Btelefon1));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1123, 41, false);
#line 47 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Btelefon1));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1208, 45, false);
#line 50 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Btelefon2));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1297, 41, false);
#line 53 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Btelefon2));

#line default
#line hidden
            EndContext();
            BeginContext(1338, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1382, 45, false);
#line 56 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Btelefon3));

#line default
#line hidden
            EndContext();
            BeginContext(1427, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1471, 41, false);
#line 59 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Btelefon3));

#line default
#line hidden
            EndContext();
            BeginContext(1512, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1556, 42, false);
#line 62 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bpaket));

#line default
#line hidden
            EndContext();
            BeginContext(1598, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1642, 38, false);
#line 65 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bpaket));

#line default
#line hidden
            EndContext();
            BeginContext(1680, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1724, 42, false);
#line 68 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bftipi));

#line default
#line hidden
            EndContext();
            BeginContext(1766, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1810, 38, false);
#line 71 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bftipi));

#line default
#line hidden
            EndContext();
            BeginContext(1848, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1892, 39, false);
#line 74 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bil));

#line default
#line hidden
            EndContext();
            BeginContext(1931, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1975, 35, false);
#line 77 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bil));

#line default
#line hidden
            EndContext();
            BeginContext(2010, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2054, 41, false);
#line 80 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bilce));

#line default
#line hidden
            EndContext();
            BeginContext(2095, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2139, 37, false);
#line 83 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bilce));

#line default
#line hidden
            EndContext();
            BeginContext(2176, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2220, 44, false);
#line 86 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Brandevu));

#line default
#line hidden
            EndContext();
            BeginContext(2264, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2308, 40, false);
#line 89 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Brandevu));

#line default
#line hidden
            EndContext();
            BeginContext(2348, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2392, 40, false);
#line 92 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bsms));

#line default
#line hidden
            EndContext();
            BeginContext(2432, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2476, 36, false);
#line 95 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bsms));

#line default
#line hidden
            EndContext();
            BeginContext(2512, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2556, 42, false);
#line 98 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bsmsid));

#line default
#line hidden
            EndContext();
            BeginContext(2598, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2642, 38, false);
#line 101 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bsmsid));

#line default
#line hidden
            EndContext();
            BeginContext(2680, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2724, 45, false);
#line 104 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bbildiren));

#line default
#line hidden
            EndContext();
            BeginContext(2769, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2813, 41, false);
#line 107 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bbildiren));

#line default
#line hidden
            EndContext();
            BeginContext(2854, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2898, 42, false);
#line 110 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bsonuc));

#line default
#line hidden
            EndContext();
            BeginContext(2940, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2984, 38, false);
#line 113 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bsonuc));

#line default
#line hidden
            EndContext();
            BeginContext(3022, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3066, 45, false);
#line 116 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Baciklama));

#line default
#line hidden
            EndContext();
            BeginContext(3111, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3155, 41, false);
#line 119 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Baciklama));

#line default
#line hidden
            EndContext();
            BeginContext(3196, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3240, 44, false);
#line 122 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bhakedis));

#line default
#line hidden
            EndContext();
            BeginContext(3284, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3328, 40, false);
#line 125 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bhakedis));

#line default
#line hidden
            EndContext();
            BeginContext(3368, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3415, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d0ecd95d269419888df25c6bd34bf64", async() => {
                BeginContext(3461, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 130 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Details.cshtml"
                           WriteLiteral(Model.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3469, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3477, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1aa533269bb469b912afde5e438394b", async() => {
                BeginContext(3499, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3515, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyCoreApp.Models.Basvuru> Html { get; private set; }
    }
}
#pragma warning restore 1591