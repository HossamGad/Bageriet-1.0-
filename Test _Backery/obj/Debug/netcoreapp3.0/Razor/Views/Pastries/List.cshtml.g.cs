#pragma checksum "C:\Users\hoss_\Desktop\final\Test _Backery\Views\Pastries\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4cf0a85f732cdb356e1da06e1a0f5b59109eece"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pastries_List), @"mvc.1.0.view", @"/Views/Pastries/List.cshtml")]
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
#line 1 "C:\Users\hoss_\Desktop\final\Test _Backery\Views\_ViewImports.cshtml"
using BackeryShop.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hoss_\Desktop\final\Test _Backery\Views\_ViewImports.cshtml"
using BackeryShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4cf0a85f732cdb356e1da06e1a0f5b59109eece", @"/Views/Pastries/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b02d0e200ed32b8f844fe00ba9c95b5bdab34712", @"/Views/_ViewImports.cshtml")]
    public class Views_Pastries_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PastriesListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n    <h1>Here comes a list of pies:-</h1>\n    <h1>");
#nullable restore
#line 4 "C:\Users\hoss_\Desktop\final\Test _Backery\Views\Pastries\List.cshtml"
   Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 5 "C:\Users\hoss_\Desktop\final\Test _Backery\Views\Pastries\List.cshtml"
     foreach (var pastries in Model.Pastries)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\n        <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n            <div class=\"thumbnail\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 276, "\"", 309, 1);
#nullable restore
#line 10 "C:\Users\hoss_\Desktop\final\Test _Backery\Views\Pastries\List.cshtml"
WriteAttributeValue("", 282, pastries.ImageThumbnailUrl, 282, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 310, "\"", 316, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"caption\">\r\n                    <h3 class=\"pull-right\">");
#nullable restore
#line 12 "C:\Users\hoss_\Desktop\final\Test _Backery\Views\Pastries\List.cshtml"
                                      Write(pastries.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h3>\r\n                        <a>");
#nullable restore
#line 14 "C:\Users\hoss_\Desktop\final\Test _Backery\Views\Pastries\List.cshtml"
                      Write(pastries.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </h3>\r\n                    <p>");
#nullable restore
#line 16 "C:\Users\hoss_\Desktop\final\Test _Backery\Views\Pastries\List.cshtml"
                  Write(pastries.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\n    </div>\n");
#nullable restore
#line 21 "C:\Users\hoss_\Desktop\final\Test _Backery\Views\Pastries\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PastriesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
