#pragma checksum "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fa7a5277171a5f0564d65ff40945b2f7e25af13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Radacct_Delete), @"mvc.1.0.view", @"/Views/Radacct/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Radacct/Delete.cshtml", typeof(AspNetCore.Views_Radacct_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa7a5277171a5f0564d65ff40945b2f7e25af13", @"/Views/Radacct/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"224f88aa75ff6d3c99933279967dd8620010770e", @"/Views/_ViewImports.cshtml")]
    public class Views_Radacct_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyCoreApp.Models.Radacct>
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
#line 3 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(77, 168, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Radacct</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(246, 49, false);
#line 15 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Acctsessionid));

#line default
#line hidden
            EndContext();
            BeginContext(295, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(339, 45, false);
#line 18 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Acctsessionid));

#line default
#line hidden
            EndContext();
            BeginContext(384, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(428, 48, false);
#line 21 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Acctuniqueid));

#line default
#line hidden
            EndContext();
            BeginContext(476, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(520, 44, false);
#line 24 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Acctuniqueid));

#line default
#line hidden
            EndContext();
            BeginContext(564, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(608, 44, false);
#line 27 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(652, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(696, 40, false);
#line 30 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(736, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(780, 45, false);
#line 33 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Groupname));

#line default
#line hidden
            EndContext();
            BeginContext(825, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(869, 41, false);
#line 36 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Groupname));

#line default
#line hidden
            EndContext();
            BeginContext(910, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(954, 41, false);
#line 39 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Realm));

#line default
#line hidden
            EndContext();
            BeginContext(995, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1039, 37, false);
#line 42 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Realm));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1120, 48, false);
#line 45 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nasipaddress));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1212, 44, false);
#line 48 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nasipaddress));

#line default
#line hidden
            EndContext();
            BeginContext(1256, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1300, 45, false);
#line 51 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nasportid));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1389, 41, false);
#line 54 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nasportid));

#line default
#line hidden
            EndContext();
            BeginContext(1430, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1474, 47, false);
#line 57 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nasporttype));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1565, 43, false);
#line 60 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nasporttype));

#line default
#line hidden
            EndContext();
            BeginContext(1608, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1652, 49, false);
#line 63 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Acctstarttime));

#line default
#line hidden
            EndContext();
            BeginContext(1701, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1745, 45, false);
#line 66 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Acctstarttime));

#line default
#line hidden
            EndContext();
            BeginContext(1790, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1834, 48, false);
#line 69 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Acctstoptime));

#line default
#line hidden
            EndContext();
            BeginContext(1882, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1926, 44, false);
#line 72 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Acctstoptime));

#line default
#line hidden
            EndContext();
            BeginContext(1970, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2014, 51, false);
#line 75 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Acctsessiontime));

#line default
#line hidden
            EndContext();
            BeginContext(2065, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2109, 47, false);
#line 78 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Acctsessiontime));

#line default
#line hidden
            EndContext();
            BeginContext(2156, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2200, 49, false);
#line 81 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Acctauthentic));

#line default
#line hidden
            EndContext();
            BeginContext(2249, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2293, 45, false);
#line 84 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Acctauthentic));

#line default
#line hidden
            EndContext();
            BeginContext(2338, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2382, 52, false);
#line 87 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ConnectinfoStart));

#line default
#line hidden
            EndContext();
            BeginContext(2434, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2478, 48, false);
#line 90 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.ConnectinfoStart));

#line default
#line hidden
            EndContext();
            BeginContext(2526, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2570, 51, false);
#line 93 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ConnectinfoStop));

#line default
#line hidden
            EndContext();
            BeginContext(2621, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2665, 47, false);
#line 96 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.ConnectinfoStop));

#line default
#line hidden
            EndContext();
            BeginContext(2712, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2756, 51, false);
#line 99 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Acctinputoctets));

#line default
#line hidden
            EndContext();
            BeginContext(2807, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2851, 47, false);
#line 102 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Acctinputoctets));

#line default
#line hidden
            EndContext();
            BeginContext(2898, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2942, 52, false);
#line 105 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Acctoutputoctets));

#line default
#line hidden
            EndContext();
            BeginContext(2994, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3038, 48, false);
#line 108 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Acctoutputoctets));

#line default
#line hidden
            EndContext();
            BeginContext(3086, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3130, 51, false);
#line 111 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Calledstationid));

#line default
#line hidden
            EndContext();
            BeginContext(3181, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3225, 47, false);
#line 114 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Calledstationid));

#line default
#line hidden
            EndContext();
            BeginContext(3272, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3316, 52, false);
#line 117 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Callingstationid));

#line default
#line hidden
            EndContext();
            BeginContext(3368, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3412, 48, false);
#line 120 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Callingstationid));

#line default
#line hidden
            EndContext();
            BeginContext(3460, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3504, 54, false);
#line 123 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Acctterminatecause));

#line default
#line hidden
            EndContext();
            BeginContext(3558, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3602, 50, false);
#line 126 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Acctterminatecause));

#line default
#line hidden
            EndContext();
            BeginContext(3652, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3696, 47, false);
#line 129 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Servicetype));

#line default
#line hidden
            EndContext();
            BeginContext(3743, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3787, 43, false);
#line 132 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Servicetype));

#line default
#line hidden
            EndContext();
            BeginContext(3830, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3874, 50, false);
#line 135 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Framedprotocol));

#line default
#line hidden
            EndContext();
            BeginContext(3924, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3968, 46, false);
#line 138 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Framedprotocol));

#line default
#line hidden
            EndContext();
            BeginContext(4014, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4058, 51, false);
#line 141 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Framedipaddress));

#line default
#line hidden
            EndContext();
            BeginContext(4109, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4153, 47, false);
#line 144 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Framedipaddress));

#line default
#line hidden
            EndContext();
            BeginContext(4200, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4244, 50, false);
#line 147 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Acctstartdelay));

#line default
#line hidden
            EndContext();
            BeginContext(4294, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4338, 46, false);
#line 150 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Acctstartdelay));

#line default
#line hidden
            EndContext();
            BeginContext(4384, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4428, 49, false);
#line 153 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Acctstopdelay));

#line default
#line hidden
            EndContext();
            BeginContext(4477, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4521, 45, false);
#line 156 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Acctstopdelay));

#line default
#line hidden
            EndContext();
            BeginContext(4566, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4610, 56, false);
#line 159 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Xascendsessionsvrkey));

#line default
#line hidden
            EndContext();
            BeginContext(4666, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4710, 52, false);
#line 162 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Xascendsessionsvrkey));

#line default
#line hidden
            EndContext();
            BeginContext(4762, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4806, 39, false);
#line 165 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Btk));

#line default
#line hidden
            EndContext();
            BeginContext(4845, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4889, 35, false);
#line 168 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Btk));

#line default
#line hidden
            EndContext();
            BeginContext(4924, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(4962, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3acf6d9e1e114dcda03d3dc2619c9608", async() => {
                BeginContext(4988, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(4998, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d8afe1a42fd7456c9ed0bf06832ec773", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 173 "/Users/umit/DotnetWEB/MyCoreApp/MyCoreApp/Views/Radacct/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Radacctid);

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
                BeginContext(5041, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(5125, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54d23bb5100e424d8fb85466661b2d46", async() => {
                    BeginContext(5147, 12, true);
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
                BeginContext(5163, 6, true);
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
            BeginContext(5176, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyCoreApp.Models.Radacct> Html { get; private set; }
    }
}
#pragma warning restore 1591
