#pragma checksum "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75a0dad1075f10c2d8f0c13f5a8eec57d6653399"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CommentPartial), @"mvc.1.0.view", @"/Views/Shared/_CommentPartial.cshtml")]
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
#nullable restore
#line 1 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\_ViewImports.cshtml"
using Сrowdfunding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\_ViewImports.cshtml"
using Сrowdfunding.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75a0dad1075f10c2d8f0c13f5a8eec57d6653399", @"/Views/Shared/_CommentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8383d156ab05850cc9c1a89ef108b36f1ce8744", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CommentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Comment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#commentSection"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Like"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Dislike"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-8 single-comment\">\r\n    <div class=\"row justify-content-between\">\r\n        <div style=\"display: inline-flex\">\r\n");
#nullable restore
#line 9 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
             if (UserManager.FindByNameAsync(Model.Author)?.Result?.ImageUrl != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"nav-item\" style=\"margin-left: 10px\">\r\n                    <img class=\"profile-icon\"");
            BeginWriteAttribute("src", " src=\"", 451, "\"", 529, 1);
#nullable restore
#line 12 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 457, Url.Content(UserManager.FindByNameAsync(Model.Author)?.Result.ImageUrl), 457, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div>\r\n                    <time>");
#nullable restore
#line 15 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
                     Write(Model.PostDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</time>\r\n                    <p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75a0dad1075f10c2d8f0c13f5a8eec57d66533999124", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 18 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
                       Write(Model.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
                                                                      WriteLiteral(UserManager.FindByNameAsync(Model.Author).Result.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("                        \r\n                    </p>\r\n                </div>\r\n");
#nullable restore
#line 22 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""nav-item"" style=""margin-left: 10px"">
                    <img class=""profile-icon"" src=""https://res.cloudinary.com/dwivxsl5s/image/upload/v1638642467/defaultuser_kr3x61.png"">
                </div>
                <div>
                    <time>");
#nullable restore
#line 29 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
                     Write(Model.PostDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</time>\r\n                    <p>");
#nullable restore
#line 30 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
                  Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n");
#nullable restore
#line 32 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n");
#nullable restore
#line 35 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
         if (User.IsInRole("Admin") || User.IsInRole("Moderator") || UserManager.GetUserAsync(User).Result.UserName == Model.Author)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75a0dad1075f10c2d8f0c13f5a8eec57d665339913772", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"CommentId\"");
                BeginWriteAttribute("value", " value=\"", 1796, "\"", 1820, 1);
#nullable restore
#line 39 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 1804, Model.CommentId, 1804, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"CampaignId\"");
                BeginWriteAttribute("value", " value=\"", 1880, "\"", 1905, 1);
#nullable restore
#line 40 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 1888, Model.CampaignId, 1888, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <button class=\"delete-btn\">\r\n                    <i class=\"fa fa-times\" aria-hidden=\"true\"></i>\r\n                </button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 49 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
   Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <hr />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75a0dad1075f10c2d8f0c13f5a8eec57d665339917608", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"CommentId\"");
                BeginWriteAttribute("value", " value=\"", 2388, "\"", 2412, 1);
#nullable restore
#line 54 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 2396, Model.CommentId, 2396, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"CampaignId\"");
                BeginWriteAttribute("value", " value=\"", 2464, "\"", 2489, 1);
#nullable restore
#line 55 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 2472, Model.CampaignId, 2472, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <span>");
#nullable restore
#line 56 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
         Write(Model.LikesCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        <button class=\"like-btn\">\r\n            <i class=\"fa fa-thumbs-o-up\" aria-hidden=\"true\"></i>\r\n        </button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75a0dad1075f10c2d8f0c13f5a8eec57d665339920898", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"CommentId\"");
                BeginWriteAttribute("value", " value=\"", 2903, "\"", 2927, 1);
#nullable restore
#line 63 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 2911, Model.CommentId, 2911, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"CampaignId\"");
                BeginWriteAttribute("value", " value=\"", 2979, "\"", 3004, 1);
#nullable restore
#line 64 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
WriteAttributeValue("", 2987, Model.CampaignId, 2987, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <span>");
#nullable restore
#line 65 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Views\Shared\_CommentPartial.cshtml"
         Write(Model.DislikesCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n        <button class=\"like-btn\">\r\n            <i class=\"fa fa-thumbs-o-down\" aria-hidden=\"true\"></i>\r\n        </button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591
