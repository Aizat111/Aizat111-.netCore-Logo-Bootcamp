#pragma checksum "/Users/aizatesenbekova/Documents/Logo-.netCore/week1/week1/Views/Home/Customer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0df3c0a487703a81159f018b2adaa71e1b618cf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Customer), @"mvc.1.0.view", @"/Views/Home/Customer.cshtml")]
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
#line 1 "/Users/aizatesenbekova/Documents/Logo-.netCore/week1/week1/Views/_ViewImports.cshtml"
using week1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/aizatesenbekova/Documents/Logo-.netCore/week1/week1/Views/_ViewImports.cshtml"
using week1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df3c0a487703a81159f018b2adaa71e1b618cf9", @"/Views/Home/Customer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ebb474b2ffa0d2d3b7c55a5dfdead976c570cab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Customer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h2>New Customer</h2>
<table style=""border:1px solid"">
    <thead style=""border:1px solid"">
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Surname</th>
            <th>Age</th>
            <th>Address</th>
        </tr>
    </thead>
    <tbody style=""border:1px solid"">
");
#nullable restore
#line 16 "/Users/aizatesenbekova/Documents/Logo-.netCore/week1/week1/Views/Home/Customer.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 19 "/Users/aizatesenbekova/Documents/Logo-.netCore/week1/week1/Views/Home/Customer.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 20 "/Users/aizatesenbekova/Documents/Logo-.netCore/week1/week1/Views/Home/Customer.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 21 "/Users/aizatesenbekova/Documents/Logo-.netCore/week1/week1/Views/Home/Customer.cshtml"
               Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 22 "/Users/aizatesenbekova/Documents/Logo-.netCore/week1/week1/Views/Home/Customer.cshtml"
               Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 23 "/Users/aizatesenbekova/Documents/Logo-.netCore/week1/week1/Views/Home/Customer.cshtml"
               Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 25 "/Users/aizatesenbekova/Documents/Logo-.netCore/week1/week1/Views/Home/Customer.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbodystyle=\"border:1px>\n        </tablestyle=\"border:1px>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
