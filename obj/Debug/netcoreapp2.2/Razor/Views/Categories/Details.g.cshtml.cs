#pragma checksum "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b88d49c49d9eb9c1aa5c30f1f092b9f12ff87946"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Details), @"mvc.1.0.view", @"/Views/Categories/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Details.cshtml", typeof(AspNetCore.Views_Categories_Details))]
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
#line 5 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Details.cshtml"
using ToDoList.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b88d49c49d9eb9c1aa5c30f1f092b9f12ff87946", @"/Views/Categories/Details.cshtml")]
    public class Views_Categories_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(85, 38, true);
            WriteLiteral("\n<h2>Category Details</h2>\n<hr />\n<h3>");
            EndContext();
            BeginContext(124, 40, false);
#line 10 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(164, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(167, 36, false);
#line 10 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(203, 12, true);
            WriteLiteral("</h3>\n\n<ul>\n");
            EndContext();
#line 13 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Details.cshtml"
 if (@Model.Items.Count == 0)
{

#line default
#line hidden
            BeginContext(247, 24, true);
            WriteLiteral("  <p>no items found</p>\n");
            EndContext();
#line 16 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Details.cshtml"
}

#line default
#line hidden
            BeginContext(273, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 18 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Details.cshtml"
 foreach (Item item in @Model.Items)
{

#line default
#line hidden
            BeginContext(313, 19, true);
            WriteLiteral("  <li>Description: ");
            EndContext();
            BeginContext(333, 16, false);
#line 20 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Details.cshtml"
              Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(349, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 21 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Details.cshtml"
}

#line default
#line hidden
            BeginContext(357, 10, true);
            WriteLiteral("</ul>\n\n<p>");
            EndContext();
            BeginContext(368, 46, false);
#line 24 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Details.cshtml"
Write(Html.ActionLink("Back to categories", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(414, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(423, 71, false);
#line 25 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Details.cshtml"
Write(Html.ActionLink("Edit Category", "Edit", new { id = Model.CategoryId }));

#line default
#line hidden
            EndContext();
            BeginContext(494, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(503, 75, false);
#line 26 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Details.cshtml"
Write(Html.ActionLink("Delete Category", "Delete", new { id = Model.CategoryId }));

#line default
#line hidden
            EndContext();
            BeginContext(578, 5, true);
            WriteLiteral("</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
