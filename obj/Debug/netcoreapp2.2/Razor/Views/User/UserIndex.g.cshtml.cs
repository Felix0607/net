#pragma checksum "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39359531923e230bae3c471dc1952f35350771e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserIndex), @"mvc.1.0.view", @"/Views/User/UserIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/UserIndex.cshtml", typeof(AspNetCore.Views_User_UserIndex))]
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
#line 1 "C:\Users\Felix\Desktop\netcore\net\Views\_ViewImports.cshtml"
using net;

#line default
#line hidden
#line 2 "C:\Users\Felix\Desktop\netcore\net\Views\_ViewImports.cshtml"
using net.Models;

#line default
#line hidden
#line 1 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 2 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39359531923e230bae3c471dc1952f35350771e4", @"/Views/User/UserIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f3d04bf94f4d2deebc6f2b2cc795f188a252cbe", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<net.ViewModel.UserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(150, 17, true);
            WriteLiteral("\r\nCurrentCulture:");
            EndContext();
            BeginContext(168, 31, false);
#line 6 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
          Write(CultureInfo.CurrentCulture.Name);

#line default
#line hidden
            EndContext();
            BeginContext(199, 25, true);
            WriteLiteral(" <br/>\r\nCurrentUICulture:");
            EndContext();
            BeginContext(225, 33, false);
#line 7 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
            Write(CultureInfo.CurrentUICulture.Name);

#line default
#line hidden
            EndContext();
            BeginContext(258, 16, true);
            WriteLiteral(" <br/>\r\n\r\n\r\n<h1>");
            EndContext();
            BeginContext(275, 26, false);
#line 10 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
Write(ViewLocalizer["newMember"]);

#line default
#line hidden
            EndContext();
            BeginContext(301, 34, true);
            WriteLiteral("</h1>\r\n<div class=\"text-center\">\r\n");
            EndContext();
#line 12 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
     using (Html.BeginForm("CreateUser", "User", FormMethod.Post, new { role = "form"}))
    {

#line default
#line hidden
            BeginContext(432, 91, true);
            WriteLiteral("    <div class=\"form-inline\">\r\n        <div class=\"form-group\">\r\n            <label for=\"\">");
            EndContext();
            BeginContext(524, 21, false);
#line 16 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
                     Write(ViewLocalizer["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(545, 23, true);
            WriteLiteral(" </label>\r\n            ");
            EndContext();
            BeginContext(569, 105, false);
#line 17 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
       Write(Html.EditorFor(x => x.User.Name, new { htmlAttributes = new { @class = "form-control ", @id = "Name" } }));

#line default
#line hidden
            EndContext();
            BeginContext(674, 78, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"\">");
            EndContext();
            BeginContext(753, 22, false);
#line 20 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
                     Write(ViewLocalizer["Phone"]);

#line default
#line hidden
            EndContext();
            BeginContext(775, 23, true);
            WriteLiteral(" </label>\r\n            ");
            EndContext();
            BeginContext(799, 107, false);
#line 21 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
       Write(Html.EditorFor(x => x.User.Phone, new { htmlAttributes = new { @class = "form-control ", @id = "Phone" } }));

#line default
#line hidden
            EndContext();
            BeginContext(906, 78, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"\">");
            EndContext();
            BeginContext(985, 22, false);
#line 24 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
                     Write(ViewLocalizer["Email"]);

#line default
#line hidden
            EndContext();
            BeginContext(1007, 23, true);
            WriteLiteral(" </label>\r\n            ");
            EndContext();
            BeginContext(1031, 120, false);
#line 25 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
       Write(Html.EditorFor(x => x.User.Email, new { htmlAttributes = new { @class = "form-control ", @id = "Email" }
            }));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 142, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <button type=\"submit\" class=\"btn-black\"><i class=\"ion-ios-search-strong\"></i> ");
            EndContext();
            BeginContext(1294, 21, false);
#line 29 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
                                                                                     Write(ViewLocalizer["Send"]);

#line default
#line hidden
            EndContext();
            BeginContext(1315, 40, true);
            WriteLiteral(" </button>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 32 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
    }

#line default
#line hidden
            BeginContext(1362, 76, true);
            WriteLiteral("    <br>\r\n    <table border=\"1\">\r\n        <tr>\r\n            <td colspan=\"3\">");
            EndContext();
            BeginContext(1439, 25, false);
#line 36 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
                       Write(ViewLocalizer["UserData"]);

#line default
#line hidden
            EndContext();
            BeginContext(1464, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
     if(Model.UserList.Count.Equals(0)){

#line default
#line hidden
            BeginContext(1528, 42, true);
            WriteLiteral("        <tr>\r\n            <td colspan=\"3\">");
            EndContext();
            BeginContext(1571, 21, false);
#line 40 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
                       Write(ViewLocalizer["Send"]);

#line default
#line hidden
            EndContext();
            BeginContext(1592, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 42 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
    }
    else{

#line default
#line hidden
            BeginContext(1632, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1663, 21, false);
#line 45 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
           Write(ViewLocalizer["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(1684, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1708, 22, false);
#line 46 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
           Write(ViewLocalizer["Phone"]);

#line default
#line hidden
            EndContext();
            BeginContext(1730, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1754, 22, false);
#line 47 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
           Write(ViewLocalizer["Email"]);

#line default
#line hidden
            EndContext();
            BeginContext(1776, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 49 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
        foreach (var item in Model.UserList)
        {

#line default
#line hidden
            BeginContext(1855, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1886, 9, false);
#line 52 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1895, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1919, 10, false);
#line 53 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
           Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1929, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1953, 10, false);
#line 54 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1963, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 56 "C:\Users\Felix\Desktop\netcore\net\Views\User\UserIndex.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(2003, 28, true);
            WriteLiteral("\r\n    </table>\r\n\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer ViewLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<net.ViewModel.UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591