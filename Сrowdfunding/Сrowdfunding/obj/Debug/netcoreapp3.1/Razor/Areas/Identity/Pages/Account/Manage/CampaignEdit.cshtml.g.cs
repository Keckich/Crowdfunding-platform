#pragma checksum "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\Account\Manage\CampaignEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c00a6403b45de2f53e8d0209a854d9836cab9919"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_CampaignEdit), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/CampaignEdit.cshtml")]
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
#line 1 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\_ViewImports.cshtml"
using Сrowdfunding.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\_ViewImports.cshtml"
using Сrowdfunding.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Сrowdfunding.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using Сrowdfunding.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c00a6403b45de2f53e8d0209a854d9836cab9919", @"/Areas/Identity/Pages/Account/Manage/CampaignEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"176f513c904389f7b7d6e2c0826778484a861db5", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"627959020bc91c00e2c2748e98af58be1277f351", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82846fae5a55fae59b77e36b77c11c2a331f40ee", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_CampaignEdit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c00a6403b45de2f53e8d0209a854d9836cab99195722", async() => {
                WriteLiteral("\r\n    <fieldset>\r\n        <div class=\"form-group\">\r\n            <label>Category:</label>\r\n            <select name=\"CategoryId\">\r\n");
#nullable restore
#line 10 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\Account\Manage\CampaignEdit.cshtml"
                 foreach (var category in Model.CampaignEdit.Categories)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\Account\Manage\CampaignEdit.cshtml"
                     if (category.Id == Model.CampaignEdit.Campaign.CategoryId)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c00a6403b45de2f53e8d0209a854d9836cab99196818", async() => {
#nullable restore
#line 14 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\Account\Manage\CampaignEdit.cshtml"
                                                                    Write(category.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\Account\Manage\CampaignEdit.cshtml"
                                               WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 15 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\Account\Manage\CampaignEdit.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c00a6403b45de2f53e8d0209a854d9836cab99199259", async() => {
#nullable restore
#line 18 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\Account\Manage\CampaignEdit.cshtml"
                                                Write(category.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\Account\Manage\CampaignEdit.cshtml"
                           WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 19 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\Account\Manage\CampaignEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\Account\Manage\CampaignEdit.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Name:</label>\r\n            <input type=\"text\" class=\"form-control\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 912, "\"", 953, 1);
#nullable restore
#line 26 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\Account\Manage\CampaignEdit.cshtml"
WriteAttributeValue("", 920, Model.CampaignEdit.Campaign.Name, 920, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Short description:</label>\r\n            <input type=\"text\" class=\"form-control\" name=\"ShortDescription\"");
                BeginWriteAttribute("value", " value=\"", 1131, "\"", 1184, 1);
#nullable restore
#line 30 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\Account\Manage\CampaignEdit.cshtml"
WriteAttributeValue("", 1139, Model.CampaignEdit.Campaign.ShortDescription, 1139, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <div>\r\n            <label>Story:</label>\r\n            <textarea id=\"editor1\" class=\"form-control\" style=\"resize: none;\" name=\"Story\">\r\n                ");
#nullable restore
#line 35 "D:\1Project-crowdfunding\Crowdfunding-platform\Сrowdfunding\Сrowdfunding\Areas\Identity\Pages\Account\Manage\CampaignEdit.cshtml"
           Write(Model.CampaignEdit.Campaign.Story);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </textarea>\r\n        </div>\r\n        <input type=\"submit\" class=\"btn btn-success\" value=\"Edit\">\r\n    </fieldset>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Сrowdfunding.Areas.Identity.Pages.Account.Manage.CampaignEditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Сrowdfunding.Areas.Identity.Pages.Account.Manage.CampaignEditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Сrowdfunding.Areas.Identity.Pages.Account.Manage.CampaignEditModel>)PageContext?.ViewData;
        public Сrowdfunding.Areas.Identity.Pages.Account.Manage.CampaignEditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
