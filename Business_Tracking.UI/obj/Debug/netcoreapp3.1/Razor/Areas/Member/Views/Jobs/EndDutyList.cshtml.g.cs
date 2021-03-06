#pragma checksum "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Jobs\EndDutyList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a483889d13483ccf3797c2644a04d6318b743f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Jobs_EndDutyList), @"mvc.1.0.view", @"/Areas/Member/Views/Jobs/EndDutyList.cshtml")]
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
#line 2 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\_ViewImports.cshtml"
using Business_Tracking.Entities.ORM.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\_ViewImports.cshtml"
using Business_Tracking.DTOs.DTOs.AppUserDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\_ViewImports.cshtml"
using Business_Tracking.DTOs.DTOs.JobsDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\_ViewImports.cshtml"
using Business_Tracking.DTOs.DTOs.RaporsDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a483889d13483ccf3797c2644a04d6318b743f4", @"/Areas/Member/Views/Jobs/EndDutyList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9340433af9a2ca889a82c03abe35b90a7e46156", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Jobs_EndDutyList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Jobs>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EndDutyList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Jobs\EndDutyList.cshtml"
  
    ViewData["Title"] = "EndDutyList";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Tamamladığım İşler</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Jobs\EndDutyList.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 14 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Jobs\EndDutyList.cshtml"
                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 15 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Jobs\EndDutyList.cshtml"
                            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 19 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Jobs\EndDutyList.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination\">\r\n\r\n");
#nullable restore
#line 22 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Jobs\EndDutyList.cshtml"
     for (int i = 1; i <= ViewBag.sumpage; i++)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a483889d13483ccf3797c2644a04d6318b743f46255", async() => {
#nullable restore
#line 26 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Jobs\EndDutyList.cshtml"
                                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activepage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Jobs\EndDutyList.cshtml"
                                                                                      WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activepage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activepage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activepage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 27 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Jobs\EndDutyList.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>\r\n\r\n\r\n\r\n    -\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Jobs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
