#pragma checksum "C:\Users\User\Documents\Projects\EBookLibrary\EBookLibrary\EBookLibrary\Views\Catalog\CheckOutHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19e461833d67e97c29a37e497e2fd6c5dbbf2ad5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_CheckOutHistory), @"mvc.1.0.view", @"/Views/Catalog/CheckOutHistory.cshtml")]
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
#line 1 "C:\Users\User\Documents\Projects\EBookLibrary\EBookLibrary\EBookLibrary\Views\_ViewImports.cshtml"
using EBookLibrary;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19e461833d67e97c29a37e497e2fd6c5dbbf2ad5", @"/Views/Catalog/CheckOutHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d03679dde9aac24f8c83b82a5b80d681d22b4a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_CheckOutHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EBookLibrary.Models.Catalog.CheckOutIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Documents\Projects\EBookLibrary\EBookLibrary\EBookLibrary\Views\Catalog\CheckOutHistory.cshtml"
  
    ViewData["Title"] = "CheckOutHistory";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-condensed"">
    <thead>
        <tr>
            <th>Image</th>
            <th>Title</th>
            <th>Full Name</th>
            <th>Since</th>
            <th>Until</th>
            <th>Book has been returend</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\User\Documents\Projects\EBookLibrary\EBookLibrary\EBookLibrary\Views\Catalog\CheckOutHistory.cshtml"
         foreach (var item in @Model.checkOutHistoryModel)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <div>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 602, "\"", 643, 2);
            WriteAttributeValue("", 608, "/Images/", 608, 8, true);
#nullable restore
#line 24 "C:\Users\User\Documents\Projects\EBookLibrary\EBookLibrary\EBookLibrary\Views\Catalog\CheckOutHistory.cshtml"
WriteAttributeValue("", 616, item.LibraryAsset.ImageUrl, 616, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"130\" width=\"100\">\r\n                </div>\r\n            </td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\User\Documents\Projects\EBookLibrary\EBookLibrary\EBookLibrary\Views\Catalog\CheckOutHistory.cshtml"
           Write(item.LibraryAsset.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\User\Documents\Projects\EBookLibrary\EBookLibrary\EBookLibrary\Views\Catalog\CheckOutHistory.cshtml"
           Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\User\Documents\Projects\EBookLibrary\EBookLibrary\EBookLibrary\Views\Catalog\CheckOutHistory.cshtml"
           Write(item.Since.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\User\Documents\Projects\EBookLibrary\EBookLibrary\EBookLibrary\Views\Catalog\CheckOutHistory.cshtml"
           Write(item.Until.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 31 "C:\Users\User\Documents\Projects\EBookLibrary\EBookLibrary\EBookLibrary\Views\Catalog\CheckOutHistory.cshtml"
              if(item.Confirm)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Yes</td>\r\n");
#nullable restore
#line 34 "C:\Users\User\Documents\Projects\EBookLibrary\EBookLibrary\EBookLibrary\Views\Catalog\CheckOutHistory.cshtml"
             }
             else
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <td>Not yet</td>\r\n");
#nullable restore
#line 38 "C:\Users\User\Documents\Projects\EBookLibrary\EBookLibrary\EBookLibrary\Views\Catalog\CheckOutHistory.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\User\Documents\Projects\EBookLibrary\EBookLibrary\EBookLibrary\Views\Catalog\CheckOutHistory.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EBookLibrary.Models.Catalog.CheckOutIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
