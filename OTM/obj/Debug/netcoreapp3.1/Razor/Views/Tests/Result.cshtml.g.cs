#pragma checksum "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72b7edd3ab436b63c83a63d319b3bca158449050"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tests_Result), @"mvc.1.0.view", @"/Views/Tests/Result.cshtml")]
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
#line 1 "C:\Users\jayra\source\repos\OTM3\OTM\Views\_ViewImports.cshtml"
using OTM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jayra\source\repos\OTM3\OTM\Views\_ViewImports.cshtml"
using OTM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72b7edd3ab436b63c83a63d319b3bca158449050", @"/Views/Tests/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68ee29076e0f657b0b6638012119222c34c78809", @"/Views/_ViewImports.cshtml")]
    public class Views_Tests_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OTM.Models.TestResults>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Result</h1>\r\n<table class=\"table table-responsive\">\r\n    <tbody>\r\n        <tr>\r\n            <td>\r\n                Test Name : <b>");
#nullable restore
#line 12 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
                          Write(ViewBag.TestName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            </td>\r\n            <td>\r\n                Test Description : <b>");
#nullable restore
#line 15 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
                                 Write(ViewBag.TestDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Test Date : <b>");
#nullable restore
#line 20 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
                          Write(ViewBag.TestDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            </td>\r\n            <td>\r\n                Test End Date : <b>");
#nullable restore
#line 23 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
                              Write(ViewBag.TestEndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Faculty : <b>");
#nullable restore
#line 28 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
                        Write(ViewBag.Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            </td>\r\n            <td>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                Total Question : <b>");
#nullable restore
#line 35 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
                               Write(ViewBag.totQues);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            </td>\r\n            <td>\r\n                Total Marks : <b>");
#nullable restore
#line 38 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
                            Write(ViewBag.OutFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
           Write(Html.DisplayNameFor(model => model.rollno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
           Write(Html.DisplayNameFor(model => model.sname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
           Write(Html.DisplayNameFor(model => model.marks));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p class=\"d-inline\"><font color=\"red\">[Out From : ");
#nullable restore
#line 53 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
                                                                                                        Write(ViewBag.OutFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("]</font></p>\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 58 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
               Write(Html.DisplayFor(modelItem => item.rollno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
               Write(Html.DisplayFor(modelItem => item.sname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
               Write(Html.DisplayFor(modelItem => item.marks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 71 "C:\Users\jayra\source\repos\OTM3\OTM\Views\Tests\Result.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OTM.Models.TestResults>> Html { get; private set; }
    }
}
#pragma warning restore 1591
