#pragma checksum "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb7ed2d56047a1ef0a345e1c6bd045fd011ff929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserInvoices_Delete), @"mvc.1.0.view", @"/Views/UserInvoices/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserInvoices/Delete.cshtml", typeof(AspNetCore.Views_UserInvoices_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7ed2d56047a1ef0a345e1c6bd045fd011ff929", @"/Views/UserInvoices/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"224f88aa75ff6d3c99933279967dd8620010770e", @"/Views/_ViewImports.cshtml")]
    public class Views_UserInvoices_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyCoreApp.Models.UserInvoices>
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(82, 173, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>UserInvoices</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(256, 44, false);
#line 15 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(300, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(344, 40, false);
#line 18 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(384, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(428, 41, false);
#line 21 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(469, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(513, 37, false);
#line 24 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(550, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(594, 43, false);
#line 27 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Peydate));

#line default
#line hidden
            EndContext();
            BeginContext(637, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(681, 39, false);
#line 30 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Peydate));

#line default
#line hidden
            EndContext();
            BeginContext(720, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(764, 42, false);
#line 33 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Expire));

#line default
#line hidden
            EndContext();
            BeginContext(806, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(850, 38, false);
#line 36 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Expire));

#line default
#line hidden
            EndContext();
            BeginContext(888, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(932, 42, false);
#line 39 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Packet));

#line default
#line hidden
            EndContext();
            BeginContext(974, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1018, 38, false);
#line 42 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Packet));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1100, 42, false);
#line 45 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tdurum));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1186, 38, false);
#line 48 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tdurum));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1268, 45, false);
#line 51 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Taciklama));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1357, 41, false);
#line 54 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Taciklama));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1442, 42, false);
#line 57 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tyapan));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1528, 38, false);
#line 60 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tyapan));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1610, 45, false);
#line 63 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Kaciklama));

#line default
#line hidden
            EndContext();
            BeginContext(1655, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1699, 41, false);
#line 66 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Kaciklama));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1784, 42, false);
#line 69 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Kmesaj));

#line default
#line hidden
            EndContext();
            BeginContext(1826, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1870, 38, false);
#line 72 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Kmesaj));

#line default
#line hidden
            EndContext();
            BeginContext(1908, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1952, 42, false);
#line 75 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Taksit));

#line default
#line hidden
            EndContext();
            BeginContext(1994, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2038, 38, false);
#line 78 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Taksit));

#line default
#line hidden
            EndContext();
            BeginContext(2076, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2120, 42, false);
#line 81 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tekrar));

#line default
#line hidden
            EndContext();
            BeginContext(2162, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2206, 38, false);
#line 84 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tekrar));

#line default
#line hidden
            EndContext();
            BeginContext(2244, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2288, 43, false);
#line 87 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Otarihi));

#line default
#line hidden
            EndContext();
            BeginContext(2331, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2375, 39, false);
#line 90 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Otarihi));

#line default
#line hidden
            EndContext();
            BeginContext(2414, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2458, 39, false);
#line 93 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Sms));

#line default
#line hidden
            EndContext();
            BeginContext(2497, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2541, 35, false);
#line 96 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Sms));

#line default
#line hidden
            EndContext();
            BeginContext(2576, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2620, 41, false);
#line 99 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mcoid));

#line default
#line hidden
            EndContext();
            BeginContext(2661, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2705, 37, false);
#line 102 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mcoid));

#line default
#line hidden
            EndContext();
            BeginContext(2742, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2780, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e63deb282bf4cb798f54a18fdf01ae7", async() => {
                BeginContext(2806, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2816, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e85b13cc1984b15a1ac4003e8cb56d9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 107 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/UserInvoices/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

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
                BeginContext(2852, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2936, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f2007b723140f4a83c365be5210d50", async() => {
                    BeginContext(2958, 12, true);
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
                BeginContext(2974, 6, true);
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
            BeginContext(2987, 10, true);
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
