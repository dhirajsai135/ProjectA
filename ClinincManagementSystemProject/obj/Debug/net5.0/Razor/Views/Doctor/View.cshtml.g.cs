#pragma checksum "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aa113f61ca3d7cc43f3d8d4a80a6ff22aeb8ca0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_View), @"mvc.1.0.view", @"/Views/Doctor/View.cshtml")]
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
#line 1 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\_ViewImports.cshtml"
using ClinincManagementSystemProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\_ViewImports.cshtml"
using ClinincManagementSystemProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aa113f61ca3d7cc43f3d8d4a80a6ff22aeb8ca0", @"/Views/Doctor/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df17917953c2ced2ada77b98e55ae0c87a816690", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClinincManagementSystemProject.Models.Doctor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
  
    ViewData["Title"] = "View";
    Layout = "~/Views/Shared/_IframeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Doctor Information</h2>\r\n<p>\r\n");
#nullable restore
#line 10 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("Specialization Required &nbsp; &nbsp;");
#nullable restore
#line 12 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
                                                     Write(Html.DropDownList("spec", new SelectList(ViewBag.Name)));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input class=\"btn btn-primary ml-3\" type=\"submit\" value=\"Search\" />\r\n");
#nullable restore
#line 14 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Specialization));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
           Write(Html.DisplayNameFor(model => model.AvailableFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
           Write(Html.DisplayNameFor(model => model.AvailableTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.Specialization));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.AvailableFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.AvailableTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 62 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Doctor\View.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClinincManagementSystemProject.Models.Doctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
