#pragma checksum "C:\Users\alena\source\repos\Module-32\CoreVSApp\MvcStartApp\Views\Users\_Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "490e61de2338a2dd2d57d0ab03850fa20b93f47b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users__Thanks), @"mvc.1.0.view", @"/Views/Users/_Thanks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"490e61de2338a2dd2d57d0ab03850fa20b93f47b", @"/Views/Users/_Thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c6813c071ceeda9a7f9331cc9b2b8fb5a72ee91", @"/Views/_ViewImports.cshtml")]
    public class Views_Users__Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-center\">\r\n    <br>\r\n    <div>\r\n        <br>\r\n        <p>");
#nullable restore
#line 5 "C:\Users\alena\source\repos\Module-32\CoreVSApp\MvcStartApp\Views\Users\_Thanks.cshtml"
      Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", спасибо за регистрацию!</p>\r\n    </div>\r\n</div>");
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
