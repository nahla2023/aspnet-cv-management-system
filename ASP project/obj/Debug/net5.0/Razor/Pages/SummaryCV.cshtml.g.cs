#pragma checksum "C:\Users\Nahla Abu Shakra\source\repos\ASP Project\ASP project\Pages\SummaryCV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "137aea295f57487d873057125ed167a535c2abf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ASP_project.Pages.Pages_SummaryCV), @"mvc.1.0.razor-page", @"/Pages/SummaryCV.cshtml")]
namespace ASP_project.Pages
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
#line 1 "C:\Users\Nahla Abu Shakra\source\repos\ASP Project\ASP project\Pages\_ViewImports.cshtml"
using ASP_project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{FirstName}/{LastName}/{Nationality}/{grade}/{Gender}/{Skills}/{Email}/{sum}/{date}/{img}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"137aea295f57487d873057125ed167a535c2abf5", @"/Pages/SummaryCV.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49c06dd7a58221811d23a0cd8855da67181f1dfa", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_SummaryCV : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50%;height:50%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Summary CV</h1>\r\n<hr />\r\n<h4>Grade:</h4>\r\n<h6>");
#nullable restore
#line 9 "C:\Users\Nahla Abu Shakra\source\repos\ASP Project\ASP project\Pages\SummaryCV.cshtml"
Write(Model.SV.grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><br />\r\n\r\n<h4>First Name:</h4>\r\n<h6>");
#nullable restore
#line 12 "C:\Users\Nahla Abu Shakra\source\repos\ASP Project\ASP project\Pages\SummaryCV.cshtml"
Write(Model.SV.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><br />\r\n\r\n<h4>Last Name:</h4>\r\n<h6>");
#nullable restore
#line 15 "C:\Users\Nahla Abu Shakra\source\repos\ASP Project\ASP project\Pages\SummaryCV.cshtml"
Write(Model.SV.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><br />\r\n\r\n<h4>Nationality:</h4>\r\n<h6>");
#nullable restore
#line 18 "C:\Users\Nahla Abu Shakra\source\repos\ASP Project\ASP project\Pages\SummaryCV.cshtml"
Write(Model.SV.Nationality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><br />\r\n\r\n<h4>Gender:</h4>\r\n<h6>");
#nullable restore
#line 21 "C:\Users\Nahla Abu Shakra\source\repos\ASP Project\ASP project\Pages\SummaryCV.cshtml"
Write(Model.SV.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><br />\r\n\r\n<h4>Programming Skills:</h4>\r\n<h6>");
#nullable restore
#line 24 "C:\Users\Nahla Abu Shakra\source\repos\ASP Project\ASP project\Pages\SummaryCV.cshtml"
Write(Model.SV.Skills.Replace("I", " "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><br />\r\n\r\n<h4>Email:</h4>\r\n<h6>");
#nullable restore
#line 27 "C:\Users\Nahla Abu Shakra\source\repos\ASP Project\ASP project\Pages\SummaryCV.cshtml"
Write(Model.SV.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><br />\r\n\r\n<h4>sum:</h4>\r\n<h6>");
#nullable restore
#line 30 "C:\Users\Nahla Abu Shakra\source\repos\ASP Project\ASP project\Pages\SummaryCV.cshtml"
Write(Model.SV.sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><br />\r\n\r\n<h4>date:</h4>\r\n<h6>");
#nullable restore
#line 33 "C:\Users\Nahla Abu Shakra\source\repos\ASP Project\ASP project\Pages\SummaryCV.cshtml"
Write(Model.SV.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6><br />\r\n\r\n<h4>Photo:</h4>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "137aea295f57487d873057125ed167a535c2abf56931", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 733, "~/photos/", 733, 9, true);
#nullable restore
#line 37 "C:\Users\Nahla Abu Shakra\source\repos\ASP Project\ASP project\Pages\SummaryCV.cshtml"
AddHtmlAttributeValue("", 742, Model.SV.img, 742, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "137aea295f57487d873057125ed167a535c2abf58584", async() => {
                WriteLiteral("\r\n\t<button   type=\"submit\" class=\"btn btn-primary\">Download pdf</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP_project.Pages.SummaryCVModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ASP_project.Pages.SummaryCVModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ASP_project.Pages.SummaryCVModel>)PageContext?.ViewData;
        public ASP_project.Pages.SummaryCVModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
