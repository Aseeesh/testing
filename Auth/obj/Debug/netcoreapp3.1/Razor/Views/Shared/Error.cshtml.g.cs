#pragma checksum "C:\Users\a\Desktop\angular\new\OnlineStore\Auth\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4af44a8c1daae4b550cb9d56e5aa06086e1361c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\a\Desktop\angular\new\OnlineStore\Auth\Views\_ViewImports.cshtml"
using Auth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a\Desktop\angular\new\OnlineStore\Auth\Views\_ViewImports.cshtml"
using IdentityServer4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\a\Desktop\angular\new\OnlineStore\Auth\Views\_ViewImports.cshtml"
using IdentityServer4.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af44a8c1daae4b550cb9d56e5aa06086e1361c2", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae3be0c35d7e35a3ec6e0b31d307bbb2eb16e6d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\a\Desktop\angular\new\OnlineStore\Auth\Views\Shared\Error.cshtml"
  
    var error = Model?.Error?.Error;
    var errorDescription = Model?.Error?.ErrorDescription;
    var request_id = Model?.Error?.RequestId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"error-page\">\r\n    <div class=\"page-header\">\r\n        <h1>Error</h1>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <div class=\"alert alert-danger\">\r\n                Sorry, there was an error\r\n\r\n");
#nullable restore
#line 19 "C:\Users\a\Desktop\angular\new\OnlineStore\Auth\Views\Shared\Error.cshtml"
                 if (error != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <strong>\r\n                        <em>\r\n                            : ");
#nullable restore
#line 23 "C:\Users\a\Desktop\angular\new\OnlineStore\Auth\Views\Shared\Error.cshtml"
                         Write(error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </em>\r\n                    </strong>\r\n");
#nullable restore
#line 26 "C:\Users\a\Desktop\angular\new\OnlineStore\Auth\Views\Shared\Error.cshtml"

                    if (errorDescription != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>");
#nullable restore
#line 29 "C:\Users\a\Desktop\angular\new\OnlineStore\Auth\Views\Shared\Error.cshtml"
                        Write(errorDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 30 "C:\Users\a\Desktop\angular\new\OnlineStore\Auth\Views\Shared\Error.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n");
#nullable restore
#line 34 "C:\Users\a\Desktop\angular\new\OnlineStore\Auth\Views\Shared\Error.cshtml"
             if (request_id != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"request-id\">Request Id: ");
#nullable restore
#line 36 "C:\Users\a\Desktop\angular\new\OnlineStore\Auth\Views\Shared\Error.cshtml"
                                               Write(request_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 37 "C:\Users\a\Desktop\angular\new\OnlineStore\Auth\Views\Shared\Error.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591