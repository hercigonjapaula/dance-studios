#pragma checksum "C:\Users\Paula\source\repos\DanceClubs\DanceClubs\Views\Club\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bb811c810cd3d32ab64a49b162ab5e2aaa1e719"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Club_Index), @"mvc.1.0.view", @"/Views/Club/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Club/Index.cshtml", typeof(AspNetCore.Views_Club_Index))]
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
#line 1 "C:\Users\Paula\source\repos\DanceClubs\DanceClubs\Views\_ViewImports.cshtml"
using DanceClubs;

#line default
#line hidden
#line 2 "C:\Users\Paula\source\repos\DanceClubs\DanceClubs\Views\_ViewImports.cshtml"
using DanceClubs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bb811c810cd3d32ab64a49b162ab5e2aaa1e719", @"/Views/Club/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e19d7d478353f2c5563b105eb2e6d82fb69e898", @"/Views/_ViewImports.cshtml")]
    public class Views_Club_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DanceClubs.Models.ClubIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Club", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddNewClub", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 74, true);
            WriteLiteral("\r\n\r\n<h1>Plesni klubovi</h1>\r\n<div style=\"float:right; padding:15px\">\r\n    ");
            EndContext();
            BeginContext(115, 224, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bb811c810cd3d32ab64a49b162ab5e2aaa1e7194314", async() => {
                BeginContext(180, 152, true);
                WriteLiteral("\r\n        <a class=\"btn btn-primary btn-md\" href=\"/Club/AddNewClub\" style=\"background-color:mediumpurple;border-color:mediumpurple\">Dodaj klub</a>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(339, 109, true);
            WriteLiteral("\r\n</div>\r\n<table class=\"table table-hover\" id=\"clubIndexTable\">\r\n    <tbody style=\"background-color:white\">\r\n");
            EndContext();
#line 12 "C:\Users\Paula\source\repos\DanceClubs\DanceClubs\Views\Club\Index.cshtml"
         foreach (var club in Model.ClubList)
        {

#line default
#line hidden
            BeginContext(506, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("id", " id=", 521, "", 533, 1);
#line 14 "C:\Users\Paula\source\repos\DanceClubs\DanceClubs\Views\Club\Index.cshtml"
WriteAttributeValue("", 525, club.Id, 525, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(533, 53, true);
            WriteLiteral(">\r\n                <td>\r\n                    <center>");
            EndContext();
            BeginContext(587, 9, false);
#line 16 "C:\Users\Paula\source\repos\DanceClubs\DanceClubs\Views\Club\Index.cshtml"
                       Write(club.Name);

#line default
#line hidden
            EndContext();
            BeginContext(596, 53, true);
            WriteLiteral("</center>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 19 "C:\Users\Paula\source\repos\DanceClubs\DanceClubs\Views\Club\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(660, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DanceClubs.Models.ClubIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
