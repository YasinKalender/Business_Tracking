#pragma checksum "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Admin\Views\Urgency\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b12b2d6a262652ff57c3ea26ebe92da1bb2b589"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Urgency_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Urgency/Index.cshtml")]
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
#line 3 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Admin\Views\_ViewImports.cshtml"
using Business_Tracking.Entities.ORM.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Admin\Views\_ViewImports.cshtml"
using Business_Tracking.DTOs.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Admin\Views\_ViewImports.cshtml"
using Business_Tracking.DTOs.DTOs.JobsDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Admin\Views\_ViewImports.cshtml"
using Business_Tracking.DTOs.DTOs.AppUserDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b12b2d6a262652ff57c3ea26ebe92da1bb2b589", @"/Areas/Admin/Views/Urgency/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a91397bcc7fee68fd10a87eb0b2aecea6eeb6ef", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Urgency_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Urgency>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UrgencyUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Admin\Views\Urgency\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Admin\Views\Urgency\Index.cshtml"
Write(Html.ActionLink("Aciliyet Ekle","UrgencyAdd","Urgency",new {@class="btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Admin\Views\Urgency\Index.cshtml"
 if (Model.Count > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered\">\r\n\r\n\r\n        <thead>\r\n\r\n            <tr>\r\n                <th>Aciliyet İsmi</th>\r\n                <th></th>\r\n\r\n\r\n            </tr>\r\n\r\n        </thead>\r\n\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 28 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Admin\Views\Urgency\Index.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Admin\Views\Urgency\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b12b2d6a262652ff57c3ea26ebe92da1bb2b5896051", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Admin\Views\Urgency\Index.cshtml"
                                                        WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Admin\Views\Urgency\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n\r\n\r\n    </table>\r\n");
#nullable restore
#line 44 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Admin\Views\Urgency\Index.cshtml"


}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"lead text-center\">Aciliyet durumunuz yoktur</p>\r\n");
#nullable restore
#line 51 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Admin\Views\Urgency\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Urgency>> Html { get; private set; }
    }
}
#pragma warning restore 1591
