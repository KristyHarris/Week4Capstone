#pragma checksum "C:\Users\harri\source\repos\Week4Capstone\Views\Product\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "114b457b99d0a93487dd9a82a44b7fe5e0014e73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Checkout), @"mvc.1.0.view", @"/Views/Product/Checkout.cshtml")]
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
#line 1 "C:\Users\harri\source\repos\Week4Capstone\Views\_ViewImports.cshtml"
using Week4Capstone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\harri\source\repos\Week4Capstone\Views\_ViewImports.cshtml"
using Week4Capstone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114b457b99d0a93487dd9a82a44b7fe5e0014e73", @"/Views/Product/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab782fb0ca33be34dbc9c7ca52b8697575af4096", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\harri\source\repos\Week4Capstone\Views\Product\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Checkout</h1>
<br />
<br />
<table class=""table"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Price
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 23 "C:\Users\harri\source\repos\Week4Capstone\Views\Product\Checkout.cshtml"
         foreach (var product in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 27 "C:\Users\harri\source\repos\Week4Capstone\Views\Product\Checkout.cshtml"
               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\harri\source\repos\Week4Capstone\Views\Product\Checkout.cshtml"
               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\harri\source\repos\Week4Capstone\Views\Product\Checkout.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tfoot>\r\n        <tr>\r\n            <td align=\"right\">\r\n                <b>Grand Total:</b>\r\n            </td>\r\n            <td>\r\n                <b> ");
#nullable restore
#line 40 "C:\Users\harri\source\repos\Week4Capstone\Views\Product\Checkout.cshtml"
               Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\r\n            </td>\r\n \r\n        </tr>\r\n    </tfoot>\r\n\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
