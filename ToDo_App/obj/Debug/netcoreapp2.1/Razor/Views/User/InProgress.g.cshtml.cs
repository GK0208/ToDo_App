#pragma checksum "C:\Users\Angela\source\repos\ToDo_App\ToDo_App\Views\User\InProgress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03bf2434df1856506be3c9615eb78ed46e93edbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_InProgress), @"mvc.1.0.view", @"/Views/User/InProgress.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/InProgress.cshtml", typeof(AspNetCore.Views_User_InProgress))]
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
#line 1 "C:\Users\Angela\source\repos\ToDo_App\ToDo_App\Views\_ViewImports.cshtml"
using ToDo_App.Models.DomainModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03bf2434df1856506be3c9615eb78ed46e93edbd", @"/Views/User/InProgress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b30b9ebe5de0b1b3e2abc1dff87b08e7692a0e4", @"/Views/_ViewImports.cshtml")]
    public class Views_User_InProgress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Angela\source\repos\ToDo_App\ToDo_App\Views\User\InProgress.cshtml"
  
    ViewBag.Title = "InProgress";

#line default
#line hidden
            BeginContext(57, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(62, 13, false);
#line 6 "C:\Users\Angela\source\repos\ToDo_App\ToDo_App\Views\User\InProgress.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(75, 122, true);
            WriteLiteral("</h2>\r\n\r\n<table style=\"border:2px solid black; width:100%\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(198, 13, false);
#line 12 "C:\Users\Angela\source\repos\ToDo_App\ToDo_App\Views\User\InProgress.cshtml"
           Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(211, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 17 "C:\Users\Angela\source\repos\ToDo_App\ToDo_App\Views\User\InProgress.cshtml"
         foreach (var task in Model.Tasks)
        {
            if (task.Status == Status.InProgress)
            {

#line default
#line hidden
            BeginContext(395, 103, true);
            WriteLiteral("                <tr>\r\n                    <td style=\"border:1px solid black\">\r\n                        ");
            EndContext();
            BeginContext(499, 10, false);
#line 23 "C:\Users\Angela\source\repos\ToDo_App\ToDo_App\Views\User\InProgress.cshtml"
                   Write(task.Title);

#line default
#line hidden
            EndContext();
            BeginContext(509, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 26 "C:\Users\Angela\source\repos\ToDo_App\ToDo_App\Views\User\InProgress.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(587, 26, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
