#pragma checksum "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Notification\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4193cd02476591645a7097df78935a6131595c9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Notification_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Notification/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4193cd02476591645a7097df78935a6131595c9b", @"/Areas/Member/Views/Notification/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9340433af9a2ca889a82c03abe35b90a7e46156", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Notification_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Notification\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Notification\Index.cshtml"
 foreach (var item in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Notification\Index.cshtml"
     using (Html.BeginForm())
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"hidden\" name=\"ID\"");
            BeginWriteAttribute("value", " value=\"", 247, "\"", 263, 1);
#nullable restore
#line 12 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Notification\Index.cshtml"
WriteAttributeValue("", 255, item.ID, 255, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <p>");
#nullable restore
#line 13 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Notification\Index.cshtml"
      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <button type=\"submit\" class=\"btn btn-primary\">okundu</button>\r\n        <hr />\r\n");
#nullable restore
#line 16 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Notification\Index.cshtml"





    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ysnbj\Desktop\Business_Tracking\Business_Tracking.UI\Areas\Member\Views\Notification\Index.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591