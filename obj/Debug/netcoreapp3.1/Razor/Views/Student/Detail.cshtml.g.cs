#pragma checksum "C:\Users\User\OneDrive\Desktop\Model-ViewModel\Views\Student\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb2b67752026fd3422512844d5af57911e55fdd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Detail), @"mvc.1.0.view", @"/Views/Student/Detail.cshtml")]
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
#line 1 "C:\Users\User\OneDrive\Desktop\Model-ViewModel\Views\_ViewImports.cshtml"
using Model_ViewModel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Desktop\Model-ViewModel\Views\_ViewImports.cshtml"
using Model_ViewModel.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2b67752026fd3422512844d5af57911e55fdd3", @"/Views/Student/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cadd556b36cc16e3228696696ea1f18e4671ebe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\OneDrive\Desktop\Model-ViewModel\Views\Student\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detail</h1>\r\n\r\n<h2>Student Id: ");
#nullable restore
#line 8 "C:\Users\User\OneDrive\Desktop\Model-ViewModel\Views\Student\Detail.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Student Full Name: ");
#nullable restore
#line 9 "C:\Users\User\OneDrive\Desktop\Model-ViewModel\Views\Student\Detail.cshtml"
                  Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Student Point: ");
#nullable restore
#line 10 "C:\Users\User\OneDrive\Desktop\Model-ViewModel\Views\Student\Detail.cshtml"
              Write(Model.Point);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
