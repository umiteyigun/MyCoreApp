#pragma checksum "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42cbb65aceea8528cc2781c87bf226df16b51abd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserInvoices_Details), @"mvc.1.0.view", @"/Views/UserInvoices/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserInvoices/Details.cshtml", typeof(AspNetCore.Views_UserInvoices_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42cbb65aceea8528cc2781c87bf226df16b51abd", @"/Views/UserInvoices/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"224f88aa75ff6d3c99933279967dd8620010770e", @"/Views/_ViewImports.cshtml")]
    public class Views_UserInvoices_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyCoreApp.Models.UserInvoices>
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 126, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>UserInvoices</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(210, 44, false);
#line 14 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(254, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(298, 40, false);
#line 17 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(338, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(382, 41, false);
#line 20 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(423, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(467, 37, false);
#line 23 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(504, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(548, 43, false);
#line 26 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Peydate));

#line default
#line hidden
            EndContext();
            BeginContext(591, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(635, 39, false);
#line 29 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayFor(model => model.Peydate));

#line default
#line hidden
            EndContext();
            BeginContext(674, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(718, 42, false);
#line 32 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Expire));

#line default
#line hidden
            EndContext();
            BeginContext(760, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(804, 38, false);
#line 35 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayFor(model => model.Expire));

#line default
#line hidden
            EndContext();
            BeginContext(842, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(886, 42, false);
#line 38 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Packet));

#line default
#line hidden
            EndContext();
            BeginContext(928, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(972, 38, false);
#line 41 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayFor(model => model.Packet));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1054, 42, false);
#line 44 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tdurum));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1140, 38, false);
#line 47 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayFor(model => model.Tdurum));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1222, 45, false);
#line 50 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Taciklama));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1311, 41, false);
#line 53 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayFor(model => model.Taciklama));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1396, 42, false);
#line 56 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tyapan));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1482, 38, false);
#line 59 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayFor(model => model.Tyapan));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1564, 45, false);
#line 62 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Kaciklama));

#line default
#line hidden
            EndContext();
            BeginContext(1609, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1653, 41, false);
#line 65 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayFor(model => model.Kaciklama));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1738, 42, false);
#line 68 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Kmesaj));

#line default
#line hidden
            EndContext();
            BeginContext(1780, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1824, 38, false);
#line 71 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayFor(model => model.Kmesaj));

#line default
#line hidden
            EndContext();
            BeginContext(1862, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1906, 42, false);
#line 74 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Taksit));

#line default
#line hidden
            EndContext();
            BeginContext(1948, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1992, 38, false);
#line 77 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayFor(model => model.Taksit));

#line default
#line hidden
            EndContext();
            BeginContext(2030, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2074, 42, false);
#line 80 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tekrar));

#line default
#line hidden
            EndContext();
            BeginContext(2116, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2160, 38, false);
#line 83 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayFor(model => model.Tekrar));

#line default
#line hidden
            EndContext();
            BeginContext(2198, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2242, 43, false);
#line 86 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Otarihi));

#line default
#line hidden
            EndContext();
            BeginContext(2285, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2329, 39, false);
#line 89 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayFor(model => model.Otarihi));

#line default
#line hidden
            EndContext();
            BeginContext(2368, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2412, 39, false);
#line 92 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sms));

#line default
#line hidden
            EndContext();
            BeginContext(2451, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2495, 35, false);
#line 95 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayFor(model => model.Sms));

#line default
#line hidden
            EndContext();
            BeginContext(2530, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2574, 41, false);
#line 98 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mcoid));

#line default
#line hidden
            EndContext();
            BeginContext(2615, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2659, 37, false);
#line 101 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
       Write(Html.DisplayFor(model => model.Mcoid));

#line default
#line hidden
            EndContext();
            BeginContext(2696, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2743, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91188c01e73f46c384098178836c639b", async() => {
                BeginContext(2789, 4, true);
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
#line 106 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Details.cshtml"
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
            BeginContext(2797, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2805, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "add719bd42084990b258bae2d2730761", async() => {
                BeginContext(2827, 12, true);
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
            BeginContext(2843, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyCoreApp.Models.UserInvoices> Html { get; private set; }
    }
}
#pragma warning restore 1591