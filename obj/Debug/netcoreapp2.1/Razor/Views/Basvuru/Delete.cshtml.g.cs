#pragma checksum "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bb6f84fd62cc9291c9cd213e78f929c8ba5d43f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basvuru_Delete), @"mvc.1.0.view", @"/Views/Basvuru/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Basvuru/Delete.cshtml", typeof(AspNetCore.Views_Basvuru_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bb6f84fd62cc9291c9cd213e78f929c8ba5d43f", @"/Views/Basvuru/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"224f88aa75ff6d3c99933279967dd8620010770e", @"/Views/_ViewImports.cshtml")]
    public class Views_Basvuru_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyCoreApp.Models.Basvuru>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(77, 168, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Basvuru</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(246, 40, false);
#line 15 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Badi));

#line default
#line hidden
            EndContext();
            BeginContext(286, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(330, 36, false);
#line 18 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Badi));

#line default
#line hidden
            EndContext();
            BeginContext(366, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(410, 43, false);
#line 21 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bsoyadi));

#line default
#line hidden
            EndContext();
            BeginContext(453, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(497, 39, false);
#line 24 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bsoyadi));

#line default
#line hidden
            EndContext();
            BeginContext(536, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(580, 39, false);
#line 27 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Btc));

#line default
#line hidden
            EndContext();
            BeginContext(619, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(663, 35, false);
#line 30 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Btc));

#line default
#line hidden
            EndContext();
            BeginContext(698, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(742, 42, false);
#line 33 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bemail));

#line default
#line hidden
            EndContext();
            BeginContext(784, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(828, 38, false);
#line 36 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bemail));

#line default
#line hidden
            EndContext();
            BeginContext(866, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(910, 43, false);
#line 39 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Badresi));

#line default
#line hidden
            EndContext();
            BeginContext(953, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(997, 39, false);
#line 42 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Badresi));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1080, 45, false);
#line 45 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Btelefon1));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1169, 41, false);
#line 48 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Btelefon1));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1254, 45, false);
#line 51 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Btelefon2));

#line default
#line hidden
            EndContext();
            BeginContext(1299, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1343, 41, false);
#line 54 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Btelefon2));

#line default
#line hidden
            EndContext();
            BeginContext(1384, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1428, 45, false);
#line 57 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Btelefon3));

#line default
#line hidden
            EndContext();
            BeginContext(1473, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1517, 41, false);
#line 60 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Btelefon3));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1602, 42, false);
#line 63 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bpaket));

#line default
#line hidden
            EndContext();
            BeginContext(1644, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1688, 38, false);
#line 66 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bpaket));

#line default
#line hidden
            EndContext();
            BeginContext(1726, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1770, 42, false);
#line 69 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bftipi));

#line default
#line hidden
            EndContext();
            BeginContext(1812, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1856, 38, false);
#line 72 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bftipi));

#line default
#line hidden
            EndContext();
            BeginContext(1894, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1938, 39, false);
#line 75 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bil));

#line default
#line hidden
            EndContext();
            BeginContext(1977, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2021, 35, false);
#line 78 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bil));

#line default
#line hidden
            EndContext();
            BeginContext(2056, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2100, 41, false);
#line 81 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bilce));

#line default
#line hidden
            EndContext();
            BeginContext(2141, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2185, 37, false);
#line 84 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bilce));

#line default
#line hidden
            EndContext();
            BeginContext(2222, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2266, 44, false);
#line 87 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Brandevu));

#line default
#line hidden
            EndContext();
            BeginContext(2310, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2354, 40, false);
#line 90 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Brandevu));

#line default
#line hidden
            EndContext();
            BeginContext(2394, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2438, 40, false);
#line 93 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bsms));

#line default
#line hidden
            EndContext();
            BeginContext(2478, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2522, 36, false);
#line 96 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bsms));

#line default
#line hidden
            EndContext();
            BeginContext(2558, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2602, 42, false);
#line 99 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bsmsid));

#line default
#line hidden
            EndContext();
            BeginContext(2644, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2688, 38, false);
#line 102 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bsmsid));

#line default
#line hidden
            EndContext();
            BeginContext(2726, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2770, 45, false);
#line 105 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bbildiren));

#line default
#line hidden
            EndContext();
            BeginContext(2815, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2859, 41, false);
#line 108 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bbildiren));

#line default
#line hidden
            EndContext();
            BeginContext(2900, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2944, 42, false);
#line 111 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bsonuc));

#line default
#line hidden
            EndContext();
            BeginContext(2986, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3030, 38, false);
#line 114 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bsonuc));

#line default
#line hidden
            EndContext();
            BeginContext(3068, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3112, 45, false);
#line 117 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Baciklama));

#line default
#line hidden
            EndContext();
            BeginContext(3157, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3201, 41, false);
#line 120 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Baciklama));

#line default
#line hidden
            EndContext();
            BeginContext(3242, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3286, 44, false);
#line 123 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Bhakedis));

#line default
#line hidden
            EndContext();
            BeginContext(3330, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3374, 40, false);
#line 126 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Bhakedis));

#line default
#line hidden
            EndContext();
            BeginContext(3414, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3452, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c55d30d3df0490fa0c0bbf59fe946f7", async() => {
                BeginContext(3478, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3488, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b20dd44e5737418e8f9806108f8d111a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 131 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Basvuru/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3524, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3608, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9c08b204f42487ea62a9b2900af75c6", async() => {
                    BeginContext(3630, 12, true);
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
                BeginContext(3646, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3659, 10, true);
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