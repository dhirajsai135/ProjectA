#pragma checksum "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d7990d86b9069818b2f76e388b162641db05105"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointments_DeleteView), @"mvc.1.0.view", @"/Views/Appointments/DeleteView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d7990d86b9069818b2f76e388b162641db05105", @"/Views/Appointments/DeleteView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df17917953c2ced2ada77b98e55ae0c87a816690", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointments_DeleteView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClinincManagementSystemProject.Models.Appointment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
  
    ViewData["Title"] = "DeleteView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cancel Appointment</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
           Write(Html.DisplayNameFor(model => model.Doctor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
           Write(Html.DisplayNameFor(model => model.SpecializationRequired));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
           Write(Html.DisplayNameFor(model => model.Patient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
           Write(Html.DisplayNameFor(model => model.DoctorAvailability));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
           Write(Html.DisplayNameFor(model => model.VisitDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
           Write(Html.DisplayNameFor(model => model.VisitTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Doctor.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
           Write(Html.DisplayFor(modelItem => item.SpecializationRequired));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Patient.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
           Write(Html.DisplayFor(modelItem => item.DoctorAvailability));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
           Write(Html.DisplayFor(modelItem => item.VisitDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
           Write(Html.DisplayFor(modelItem => item.VisitTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d7990d86b9069818b2f76e388b162641db051059222", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
                                                                WriteLiteral(item.AppointmentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 60 "C:\Users\dhira\source\repos\ClinincManagementSystemProject\ClinincManagementSystemProject\Views\Appointments\DeleteView.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClinincManagementSystemProject.Models.Appointment>> Html { get; private set; }
    }
}
#pragma warning restore 1591