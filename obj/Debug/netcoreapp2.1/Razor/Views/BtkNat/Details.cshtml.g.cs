#pragma checksum "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f305b92a954c6854032febd135d575603b981651"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BtkNat_Details), @"mvc.1.0.view", @"/Views/BtkNat/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BtkNat/Details.cshtml", typeof(AspNetCore.Views_BtkNat_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f305b92a954c6854032febd135d575603b981651", @"/Views/BtkNat/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"224f88aa75ff6d3c99933279967dd8620010770e", @"/Views/_ViewImports.cshtml")]
    public class Views_BtkNat_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyCoreApp.Models.BtkNat>
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(77, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>BtkNat</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(198, 47, false);
#line 14 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.KullaniciAd));

#line default
#line hidden
            EndContext();
            BeginContext(245, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(289, 43, false);
#line 17 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.KullaniciAd));

#line default
#line hidden
            EndContext();
            BeginContext(332, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(376, 42, false);
#line 20 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OzelIp));

#line default
#line hidden
            EndContext();
            BeginContext(418, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(462, 38, false);
#line 23 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.OzelIp));

#line default
#line hidden
            EndContext();
            BeginContext(500, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(544, 43, false);
#line 26 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OIpPBas));

#line default
#line hidden
            EndContext();
            BeginContext(587, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(631, 39, false);
#line 29 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.OIpPBas));

#line default
#line hidden
            EndContext();
            BeginContext(670, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(714, 43, false);
#line 32 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OIpPBit));

#line default
#line hidden
            EndContext();
            BeginContext(757, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(801, 39, false);
#line 35 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.OIpPBit));

#line default
#line hidden
            EndContext();
            BeginContext(840, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(884, 44, false);
#line 38 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GercekIp));

#line default
#line hidden
            EndContext();
            BeginContext(928, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(972, 40, false);
#line 41 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.GercekIp));

#line default
#line hidden
            EndContext();
            BeginContext(1012, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1056, 43, false);
#line 44 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GIpPBas));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1143, 39, false);
#line 47 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.GIpPBas));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1226, 43, false);
#line 50 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GIpPBit));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1313, 39, false);
#line 53 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.GIpPBit));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1396, 45, false);
#line 56 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OBasTarih));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1485, 41, false);
#line 59 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.OBasTarih));

#line default
#line hidden
            EndContext();
            BeginContext(1526, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1570, 45, false);
#line 62 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OBitTarih));

#line default
#line hidden
            EndContext();
            BeginContext(1615, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1659, 41, false);
#line 65 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.OBitTarih));

#line default
#line hidden
            EndContext();
            BeginContext(1700, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1744, 42, false);
#line 68 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpByte));

#line default
#line hidden
            EndContext();
            BeginContext(1786, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1830, 38, false);
#line 71 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.UpByte));

#line default
#line hidden
            EndContext();
            BeginContext(1868, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1912, 44, false);
#line 74 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DownByte));

#line default
#line hidden
            EndContext();
            BeginContext(1956, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2000, 40, false);
#line 77 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.DownByte));

#line default
#line hidden
            EndContext();
            BeginContext(2040, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2084, 39, false);
#line 80 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BKM));

#line default
#line hidden
            EndContext();
            BeginContext(2123, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2167, 35, false);
#line 83 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.BKM));

#line default
#line hidden
            EndContext();
            BeginContext(2202, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2246, 42, false);
#line 86 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ODurum));

#line default
#line hidden
            EndContext();
            BeginContext(2288, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2332, 38, false);
#line 89 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.ODurum));

#line default
#line hidden
            EndContext();
            BeginContext(2370, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2414, 40, false);
#line 92 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BPvc));

#line default
#line hidden
            EndContext();
            BeginContext(2454, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2498, 36, false);
#line 95 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.BPvc));

#line default
#line hidden
            EndContext();
            BeginContext(2534, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2578, 44, false);
#line 98 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ServisNo));

#line default
#line hidden
            EndContext();
            BeginContext(2622, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2666, 40, false);
#line 101 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.ServisNo));

#line default
#line hidden
            EndContext();
            BeginContext(2706, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2750, 40, false);
#line 104 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OKod));

#line default
#line hidden
            EndContext();
            BeginContext(2790, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2834, 36, false);
#line 107 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.OKod));

#line default
#line hidden
            EndContext();
            BeginContext(2870, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2914, 40, false);
#line 110 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Imza));

#line default
#line hidden
            EndContext();
            BeginContext(2954, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2998, 36, false);
#line 113 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
       Write(Html.DisplayFor(model => model.Imza));

#line default
#line hidden
            EndContext();
            BeginContext(3034, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3081, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc50424e27014f2181174f9a900e470c", async() => {
                BeginContext(3127, 4, true);
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
#line 118 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/BtkNat/Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(3135, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3143, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "380189c0be064137896206a2040a8c18", async() => {
                BeginContext(3165, 12, true);
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
            BeginContext(3181, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyCoreApp.Models.BtkNat> Html { get; private set; }
    }
}
#pragma warning restore 1591
