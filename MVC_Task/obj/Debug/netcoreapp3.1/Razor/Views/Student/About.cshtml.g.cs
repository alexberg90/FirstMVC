#pragma checksum "C:\Users\ProBook\Desktop\BackEnd\MVC\MVC_Task\MVC_Task\Views\Student\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f03bda54c591ac1ee55e96136fedc149a13a82fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_About), @"mvc.1.0.view", @"/Views/Student/About.cshtml")]
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
#line 1 "C:\Users\ProBook\Desktop\BackEnd\MVC\MVC_Task\MVC_Task\Views\Student\About.cshtml"
using MVC_Task.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f03bda54c591ac1ee55e96136fedc149a13a82fb", @"/Views/Student/About.cshtml")]
    #nullable restore
    public class Views_Student_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ProBook\Desktop\BackEnd\MVC\MVC_Task\MVC_Task\Views\Student\About.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Name: ");
#nullable restore
#line 6 "C:\Users\ProBook\Desktop\BackEnd\MVC\MVC_Task\MVC_Task\Views\Student\About.cshtml"
         Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>Id: ");
#nullable restore
#line 7 "C:\Users\ProBook\Desktop\BackEnd\MVC\MVC_Task\MVC_Task\Views\Student\About.cshtml"
      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Age: ");
#nullable restore
#line 8 "C:\Users\ProBook\Desktop\BackEnd\MVC\MVC_Task\MVC_Task\Views\Student\About.cshtml"
       Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>GroupId: ");
#nullable restore
#line 9 "C:\Users\ProBook\Desktop\BackEnd\MVC\MVC_Task\MVC_Task\Views\Student\About.cshtml"
           Write(item.GroupId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <hr >\r\n");
#nullable restore
#line 11 "C:\Users\ProBook\Desktop\BackEnd\MVC\MVC_Task\MVC_Task\Views\Student\About.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
