#pragma checksum "C:\Users\alena\source\repos\Module-32\CoreVSApp\MvcStartApp\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ca1994f25baf0b4bceab70515029b8121948562"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "C:\Users\alena\source\repos\Module-32\CoreVSApp\MvcStartApp\Views\_ViewImports.cshtml"
using MvcStartApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alena\source\repos\Module-32\CoreVSApp\MvcStartApp\Views\_ViewImports.cshtml"
using MvcStartApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ca1994f25baf0b4bceab70515029b8121948562", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c6813c071ceeda9a7f9331cc9b2b8fb5a72ee91", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\alena\source\repos\Module-32\CoreVSApp\MvcStartApp\Views\Users\Index.cshtml"
  
   ViewData["Title"] = "View project authors";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    table {
        border-spacing: 0 15px;
        align-self: center;
    }

    th {
        background-color: #4287f5;
        color: white;
    }

    th,
    td {
        width: 150px;
        text-align: center;
        border: 1px solid black;
        padding: 5px;
    }

    h2 {
        color: #4287f5;
    }
</style>

<div class=""text-center"">
    <h2 class=""display-4"" style=""text-align: left"">Пользователи проекта</h2>
    <br>
    <table>
        <tr>
            <td>Идентификатор</td>
            <td>Имя</td>
            <td>Дата регистрации</td>
        </tr>
");
#nullable restore
#line 38 "C:\Users\alena\source\repos\Module-32\CoreVSApp\MvcStartApp\Views\Users\Index.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\alena\source\repos\Module-32\CoreVSApp\MvcStartApp\Views\Users\Index.cshtml"
           Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\alena\source\repos\Module-32\CoreVSApp\MvcStartApp\Views\Users\Index.cshtml"
           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\alena\source\repos\Module-32\CoreVSApp\MvcStartApp\Views\Users\Index.cshtml"
           Write(user.JoinDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\alena\source\repos\Module-32\CoreVSApp\MvcStartApp\Views\Users\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
