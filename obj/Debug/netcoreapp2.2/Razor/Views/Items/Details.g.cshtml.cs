#pragma checksum "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Items/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "846a1ce6be91eeffd001d551efcf7a48a1fee940"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Details), @"mvc.1.0.view", @"/Views/Items/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Details.cshtml", typeof(AspNetCore.Views_Items_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"846a1ce6be91eeffd001d551efcf7a48a1fee940", @"/Views/Items/Details.cshtml")]
    public class Views_Items_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Items/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(56, 34, true);
            WriteLiteral("\n<h2>Item Details</h2>\n<hr />\n<h3>");
            EndContext();
            BeginContext(91, 47, false);
#line 9 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Items/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(138, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(141, 43, false);
#line 9 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Items/Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(184, 9, true);
            WriteLiteral("</h3>\n<p>");
            EndContext();
            BeginContext(194, 40, false);
#line 10 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Items/Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(234, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(243, 63, false);
#line 11 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Items/Details.cshtml"
Write(Html.ActionLink("Edit Item", "Edit", new { id = Model.ItemId }));

#line default
#line hidden
            EndContext();
            BeginContext(306, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(315, 67, false);
#line 12 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Items/Details.cshtml"
Write(Html.ActionLink("Delete Item", "Delete", new { id = Model.ItemId }));

#line default
#line hidden
            EndContext();
            BeginContext(382, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591