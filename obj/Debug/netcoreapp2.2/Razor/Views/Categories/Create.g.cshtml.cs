#pragma checksum "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e44dc211e276459b6f5b0a8808a0b346f71314b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Create), @"mvc.1.0.view", @"/Views/Categories/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Create.cshtml", typeof(AspNetCore.Views_Categories_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e44dc211e276459b6f5b0a8808a0b346f71314b", @"/Views/Categories/Create.cshtml")]
    public class Views_Categories_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 29, true);
            WriteLiteral("\n<h4>Add a new category</h4>\n");
            EndContext();
#line 8 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(122, 34, false);
#line 10 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(162, 36, false);
#line 11 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(199, 53, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new category\" />\n");
            EndContext();
#line 13 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Create.cshtml"
}

#line default
#line hidden
            BeginContext(254, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(258, 47, false);
#line 14 "/Users/teresarosinski/Desktop/Week4.Solution/ToDoList/Views/Categories/Create.cshtml"
Write(Html.ActionLink("Show all categories", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(305, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
