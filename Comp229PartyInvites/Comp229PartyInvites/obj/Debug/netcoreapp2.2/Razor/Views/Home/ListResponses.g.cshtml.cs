#pragma checksum "C:\Users\micha\OneDrive\Desktop\Centennial college semester 3\Comp 229\Week 2\Comp229PartyInvites\Comp229PartyInvites\Views\Home\ListResponses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aeac8ffcf17eb296899662f8a45f4f0e105fc6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListResponses), @"mvc.1.0.view", @"/Views/Home/ListResponses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListResponses.cshtml", typeof(AspNetCore.Views_Home_ListResponses))]
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
#line 1 "C:\Users\micha\OneDrive\Desktop\Centennial college semester 3\Comp 229\Week 2\Comp229PartyInvites\Comp229PartyInvites\Views\_ViewImports.cshtml"
using Comp229PartyInvites;

#line default
#line hidden
#line 2 "C:\Users\micha\OneDrive\Desktop\Centennial college semester 3\Comp 229\Week 2\Comp229PartyInvites\Comp229PartyInvites\Views\_ViewImports.cshtml"
using Comp229PartyInvites.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aeac8ffcf17eb296899662f8a45f4f0e105fc6f", @"/Views/Home/ListResponses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a25a5d9bbe33afdfe132fd0dc812e63ed201e6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListResponses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Comp229PartyInvites.Models.GuestResponse>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/twitter-bootstrap/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\micha\OneDrive\Desktop\Centennial college semester 3\Comp 229\Week 2\Comp229PartyInvites\Comp229PartyInvites\Views\Home\ListResponses.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(89, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(118, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aeac8ffcf17eb296899662f8a45f4f0e105fc6f4764", async() => {
                BeginContext(124, 65, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
                EndContext();
                BeginContext(189, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5aeac8ffcf17eb296899662f8a45f4f0e105fc6f5215", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(263, 32, true);
                WriteLiteral("\r\n    <title>Responses</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(302, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(304, 746, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5aeac8ffcf17eb296899662f8a45f4f0e105fc6f7376", async() => {
                BeginContext(310, 382, true);
                WriteLiteral(@"
    <div class=""panel-body"">
        <h2>Here is the list of people attending the party</h2>
        <table class=""table table-sm table-striped table-bordered"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Phone</th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 26 "C:\Users\micha\OneDrive\Desktop\Centennial college semester 3\Comp 229\Week 2\Comp229PartyInvites\Comp229PartyInvites\Views\Home\ListResponses.cshtml"
                 foreach (Comp229PartyInvites.Models.GuestResponse r in Model)
                {

#line default
#line hidden
                BeginContext(791, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(846, 6, false);
#line 29 "C:\Users\micha\OneDrive\Desktop\Centennial college semester 3\Comp 229\Week 2\Comp229PartyInvites\Comp229PartyInvites\Views\Home\ListResponses.cshtml"
                       Write(r.Name);

#line default
#line hidden
                EndContext();
                BeginContext(852, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(888, 7, false);
#line 30 "C:\Users\micha\OneDrive\Desktop\Centennial college semester 3\Comp 229\Week 2\Comp229PartyInvites\Comp229PartyInvites\Views\Home\ListResponses.cshtml"
                       Write(r.Email);

#line default
#line hidden
                EndContext();
                BeginContext(895, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(931, 7, false);
#line 31 "C:\Users\micha\OneDrive\Desktop\Centennial college semester 3\Comp 229\Week 2\Comp229PartyInvites\Comp229PartyInvites\Views\Home\ListResponses.cshtml"
                       Write(r.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(938, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 33 "C:\Users\micha\OneDrive\Desktop\Centennial college semester 3\Comp 229\Week 2\Comp229PartyInvites\Comp229PartyInvites\Views\Home\ListResponses.cshtml"
                }

#line default
#line hidden
                BeginContext(991, 52, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1050, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Comp229PartyInvites.Models.GuestResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
