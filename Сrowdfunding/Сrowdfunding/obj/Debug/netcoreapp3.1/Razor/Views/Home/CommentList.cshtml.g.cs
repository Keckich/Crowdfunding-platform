#pragma checksum "D:\Itra-crowdfunding\Сrowdfunding\Сrowdfunding\Views\Home\CommentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19fbe97b4ee025844eb922185069ba5052998047"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CommentList), @"mvc.1.0.view", @"/Views/Home/CommentList.cshtml")]
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
#line 1 "D:\Itra-crowdfunding\Сrowdfunding\Сrowdfunding\Views\_ViewImports.cshtml"
using Сrowdfunding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Itra-crowdfunding\Сrowdfunding\Сrowdfunding\Views\_ViewImports.cshtml"
using Сrowdfunding.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19fbe97b4ee025844eb922185069ba5052998047", @"/Views/Home/CommentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8383d156ab05850cc9c1a89ef108b36f1ce8744", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CommentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Сrowdfunding.Models.ViewModels.CommentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Itra-crowdfunding\Сrowdfunding\Сrowdfunding\Views\Home\CommentList.cshtml"
 foreach (var comment in Model.Comments)
{
    if (comment.CampaignId == Model.Campaign.Id)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Itra-crowdfunding\Сrowdfunding\Сrowdfunding\Views\Home\CommentList.cshtml"
   Write(await Html.PartialAsync("_CommentPartial", comment));

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Itra-crowdfunding\Сrowdfunding\Сrowdfunding\Views\Home\CommentList.cshtml"
                                                            
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Сrowdfunding.Models.ViewModels.CommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
