#pragma checksum "C:\Users\NHAN-TTCNTT\Documents\4-Github\IdentityCoreApp\IdentityCoreApp\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67efee223277655d76b0b606d503134cba81b5b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LoginPartial.cshtml", typeof(AspNetCore.Views_Shared__LoginPartial))]
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
#line 1 "C:\Users\NHAN-TTCNTT\Documents\4-Github\IdentityCoreApp\IdentityCoreApp\Views\_ViewImports.cshtml"
using IdentityCoreApp;

#line default
#line hidden
#line 2 "C:\Users\NHAN-TTCNTT\Documents\4-Github\IdentityCoreApp\IdentityCoreApp\Views\_ViewImports.cshtml"
using IdentityCoreApp.Authorization;

#line default
#line hidden
#line 3 "C:\Users\NHAN-TTCNTT\Documents\4-Github\IdentityCoreApp\IdentityCoreApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Users\NHAN-TTCNTT\Documents\4-Github\IdentityCoreApp\IdentityCoreApp\Views\_ViewImports.cshtml"
using IdentityCoreApp.Models;

#line default
#line hidden
#line 5 "C:\Users\NHAN-TTCNTT\Documents\4-Github\IdentityCoreApp\IdentityCoreApp\Views\_ViewImports.cshtml"
using IdentityCoreApp.Models.AccountViewModels;

#line default
#line hidden
#line 6 "C:\Users\NHAN-TTCNTT\Documents\4-Github\IdentityCoreApp\IdentityCoreApp\Views\_ViewImports.cshtml"
using IdentityCoreApp.Models.ManageViewModels;

#line default
#line hidden
#line 7 "C:\Users\NHAN-TTCNTT\Documents\4-Github\IdentityCoreApp\IdentityCoreApp\Views\_ViewImports.cshtml"
using IdentityCoreApp.Data.Entities;

#line default
#line hidden
#line 8 "C:\Users\NHAN-TTCNTT\Documents\4-Github\IdentityCoreApp\IdentityCoreApp\Views\_ViewImports.cshtml"
using IdentityCoreApp.Application.ViewModels.System;

#line default
#line hidden
#line 1 "C:\Users\NHAN-TTCNTT\Documents\4-Github\IdentityCoreApp\IdentityCoreApp\Views\Shared\_LoginPartial.cshtml"
using IdentityCoreApp.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67efee223277655d76b0b606d503134cba81b5b7", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0fda2bedb81bda18adf7b400eaef458e78d784", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/account/logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(125, 272, true);
            WriteLiteral(@"
<li class=""nav-item dropdown no-arrow"">
    <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button""
       data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
        <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">Hello ");
            EndContext();
            BeginContext(398, 33, false);
#line 9 "C:\Users\NHAN-TTCNTT\Documents\4-Github\IdentityCoreApp\IdentityCoreApp\Views\Shared\_LoginPartial.cshtml"
                                                                   Write(User.GetSpecificClaim("FullName"));

#line default
#line hidden
            EndContext();
            BeginContext(431, 1847, true);
            WriteLiteral(@"</span>
        <img class=""img-profile rounded-circle""
             src=""/img/undraw_profile.svg"">
    </a>
    <!-- Dropdown - User Information -->
    <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in""
         aria-labelledby=""userDropdown"">
        <a class=""dropdown-item"" href=""/account/index"">
            <i class=""fas fa-user fa-sm fa-fw mr-2 text-gray-400""></i>
            Profile
        </a>
        <a class=""dropdown-item"" href=""#"">
            <i class=""fas fa-cogs fa-sm fa-fw mr-2 text-gray-400""></i>
            Settings
        </a>
        <a class=""dropdown-item"" href=""#"">
            <i class=""fas fa-list fa-sm fa-fw mr-2 text-gray-400""></i>
            Activity Log
        </a>
        <div class=""dropdown-divider""></div>
        <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
            <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
            Logout
        </a>
    </div>
</li>

<!-- L");
            WriteLiteral(@"ogout Modal-->
<div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">??</span>
                </button>
            </div>
            <div class=""modal-body"">Select ""Logout"" below if you are ready to end your current session.</div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                ");
            EndContext();
            BeginContext(2278, 178, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67efee223277655d76b0b606d503134cba81b5b78525", async() => {
                BeginContext(2339, 110, true);
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-primary\" href=\"#\">Logout</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            EndContext();
            BeginContext(2456, 58, true);
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
