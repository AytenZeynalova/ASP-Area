#pragma checksum "C:\Users\Ayten\Desktop\ASP-Pustok\ASP-Pustok\Areas\Manage\Views\Author\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7358584ac43468d4555aa6da5a5c993777e0d885"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Author_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Author/Index.cshtml")]
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
#line 4 "C:\Users\Ayten\Desktop\ASP-Pustok\ASP-Pustok\Areas\Manage\Views\_ViewImports.cshtml"
using ASP_Pustok.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7358584ac43468d4555aa6da5a5c993777e0d885", @"/Areas/Manage/Views/Author/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f25d19c7ede985af9e25d98e531cf6d629460367", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Author_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Author>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ayten\Desktop\ASP-Pustok\ASP-Pustok\Areas\Manage\Views\Author\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-10"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">First</th>
                        <th scope=""col"">Last</th>
                        <th scope=""col"">Handle</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 20 "C:\Users\Ayten\Desktop\ASP-Pustok\ASP-Pustok\Areas\Manage\Views\Author\Index.cshtml"
                     foreach (var auth in Model)
                    {
                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 24 "C:\Users\Ayten\Desktop\ASP-Pustok\ASP-Pustok\Areas\Manage\Views\Author\Index.cshtml"
                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\Ayten\Desktop\ASP-Pustok\ASP-Pustok\Areas\Manage\Views\Author\Index.cshtml"
                           Write(auth.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\Ayten\Desktop\ASP-Pustok\ASP-Pustok\Areas\Manage\Views\Author\Index.cshtml"
                           Write(auth.BirthDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\Ayten\Desktop\ASP-Pustok\ASP-Pustok\Areas\Manage\Views\Author\Index.cshtml"
                           Write(auth.Books.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a class=\"btn btn-warning\">Edit</a>\r\n                                <a class=\"btn btn-danger\">Delete</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Ayten\Desktop\ASP-Pustok\ASP-Pustok\Areas\Manage\Views\Author\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591