#pragma checksum "C:\Users\Waseem's PC\Documents\c#\RandomPasscode\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33e293102afb30cc1d99088452d7aca1fa974a1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Waseem's PC\Documents\c#\RandomPasscode\Views\_ViewImports.cshtml"
using RandomPasscode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Waseem's PC\Documents\c#\RandomPasscode\Views\_ViewImports.cshtml"
using RandomPasscode.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Waseem's PC\Documents\c#\RandomPasscode\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33e293102afb30cc1d99088452d7aca1fa974a1c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bc65b3b6b44fa152a122d3d61c9560dafec0c77", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Waseem's PC\Documents\c#\RandomPasscode\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Random Passcode <span>(passcode #");
#nullable restore
#line 4 "C:\Users\Waseem's PC\Documents\c#\RandomPasscode\Views\Home\Index.cshtml"
                                Write(Context.Session.GetInt32("count"));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span></h1>\r\n    <h1>");
#nullable restore
#line 5 "C:\Users\Waseem's PC\Documents\c#\RandomPasscode\Views\Home\Index.cshtml"
   Write(Model.result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<a href=\"/\">Generate</a>\r\n");
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
