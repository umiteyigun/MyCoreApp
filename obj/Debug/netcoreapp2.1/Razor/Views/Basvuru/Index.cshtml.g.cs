#pragma checksum "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a161c893f99b018054ff96f9c818fb76be43f28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basvuru_Index), @"mvc.1.0.view", @"/Views/Basvuru/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Basvuru/Index.cshtml", typeof(AspNetCore.Views_Basvuru_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a161c893f99b018054ff96f9c818fb76be43f28", @"/Views/Basvuru/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"224f88aa75ff6d3c99933279967dd8620010770e", @"/Views/_ViewImports.cshtml")]
    public class Views_Basvuru_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyCoreApp.Models.Basvuru>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(118, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b961e98980f4a5fabd7e22f6d1b9e56", async() => {
                BeginContext(141, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(155, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(248, 40, false);
#line 16 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Badi));

#line default
#line hidden
            EndContext();
            BeginContext(288, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(344, 43, false);
#line 19 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bsoyadi));

#line default
#line hidden
            EndContext();
            BeginContext(387, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(443, 39, false);
#line 22 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Btc));

#line default
#line hidden
            EndContext();
            BeginContext(482, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(538, 42, false);
#line 25 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bemail));

#line default
#line hidden
            EndContext();
            BeginContext(580, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(636, 43, false);
#line 28 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Badresi));

#line default
#line hidden
            EndContext();
            BeginContext(679, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(735, 45, false);
#line 31 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Btelefon1));

#line default
#line hidden
            EndContext();
            BeginContext(780, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(836, 45, false);
#line 34 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Btelefon2));

#line default
#line hidden
            EndContext();
            BeginContext(881, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(937, 45, false);
#line 37 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Btelefon3));

#line default
#line hidden
            EndContext();
            BeginContext(982, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1038, 42, false);
#line 40 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bpaket));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1136, 42, false);
#line 43 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bftipi));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1234, 39, false);
#line 46 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bil));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1329, 41, false);
#line 49 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bilce));

#line default
#line hidden
            EndContext();
            BeginContext(1370, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1426, 44, false);
#line 52 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Brandevu));

#line default
#line hidden
            EndContext();
            BeginContext(1470, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1526, 40, false);
#line 55 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bsms));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1622, 42, false);
#line 58 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bsmsid));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1720, 45, false);
#line 61 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bbildiren));

#line default
#line hidden
            EndContext();
            BeginContext(1765, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1821, 42, false);
#line 64 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bsonuc));

#line default
#line hidden
            EndContext();
            BeginContext(1863, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1919, 45, false);
#line 67 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Baciklama));

#line default
#line hidden
            EndContext();
            BeginContext(1964, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2020, 44, false);
#line 70 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bhakedis));

#line default
#line hidden
            EndContext();
            BeginContext(2064, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 76 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2182, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2231, 39, false);
#line 79 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Badi));

#line default
#line hidden
            EndContext();
            BeginContext(2270, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2326, 42, false);
#line 82 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bsoyadi));

#line default
#line hidden
            EndContext();
            BeginContext(2368, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2424, 38, false);
#line 85 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Btc));

#line default
#line hidden
            EndContext();
            BeginContext(2462, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2518, 41, false);
#line 88 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bemail));

#line default
#line hidden
            EndContext();
            BeginContext(2559, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2615, 42, false);
#line 91 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Badresi));

#line default
#line hidden
            EndContext();
            BeginContext(2657, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2713, 44, false);
#line 94 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Btelefon1));

#line default
#line hidden
            EndContext();
            BeginContext(2757, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2813, 44, false);
#line 97 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Btelefon2));

#line default
#line hidden
            EndContext();
            BeginContext(2857, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2913, 44, false);
#line 100 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Btelefon3));

#line default
#line hidden
            EndContext();
            BeginContext(2957, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3013, 41, false);
#line 103 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bpaket));

#line default
#line hidden
            EndContext();
            BeginContext(3054, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3110, 41, false);
#line 106 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bftipi));

#line default
#line hidden
            EndContext();
            BeginContext(3151, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3207, 38, false);
#line 109 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bil));

#line default
#line hidden
            EndContext();
            BeginContext(3245, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3301, 40, false);
#line 112 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bilce));

#line default
#line hidden
            EndContext();
            BeginContext(3341, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3397, 43, false);
#line 115 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Brandevu));

#line default
#line hidden
            EndContext();
            BeginContext(3440, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3496, 39, false);
#line 118 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bsms));

#line default
#line hidden
            EndContext();
            BeginContext(3535, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3591, 41, false);
#line 121 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bsmsid));

#line default
#line hidden
            EndContext();
            BeginContext(3632, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3688, 44, false);
#line 124 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bbildiren));

#line default
#line hidden
            EndContext();
            BeginContext(3732, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3788, 41, false);
#line 127 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bsonuc));

#line default
#line hidden
            EndContext();
            BeginContext(3829, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3885, 44, false);
#line 130 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Baciklama));

#line default
#line hidden
            EndContext();
            BeginContext(3929, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3985, 43, false);
#line 133 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bhakedis));

#line default
#line hidden
            EndContext();
            BeginContext(4028, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4083, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fc1bccd687943d0a009421d78d32177", async() => {
                BeginContext(4128, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 136 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
                                       WriteLiteral(item.id);

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
            BeginContext(4136, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4156, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "404957e3915f4b60a5643ac93dd633a1", async() => {
                BeginContext(4204, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 137 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
                                          WriteLiteral(item.id);

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
            BeginContext(4215, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4235, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbc99267b3904302b96f1a34a6fe1304", async() => {
                BeginContext(4282, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 138 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
                                         WriteLiteral(item.id);

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
            BeginContext(4292, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 141 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Index.cshtml"
}

#line default
#line hidden
            BeginContext(4331, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyCoreApp.Models.Basvuru>> Html { get; private set; }
    }
}
#pragma warning restore 1591
