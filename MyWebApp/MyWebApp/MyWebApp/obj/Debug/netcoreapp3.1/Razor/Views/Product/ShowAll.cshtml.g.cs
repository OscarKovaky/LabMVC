#pragma checksum "D:\Documentos\ASP.NET LAB\MyWebApp\MyWebApp\MyWebApp\Views\Product\ShowAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "300024c6f8b77cd32fbfe1ac282bab8feb0e2111"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowAll), @"mvc.1.0.view", @"/Views/Product/ShowAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"300024c6f8b77cd32fbfe1ac282bab8feb0e2111", @"/Views/Product/ShowAll.cshtml")]
    public class Views_Product_ShowAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyWebApp.Models.Product>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "300024c6f8b77cd32fbfe1ac282bab8feb0e21112596", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 5 "D:\Documentos\ASP.NET LAB\MyWebApp\MyWebApp\MyWebApp\Views\Product\ShowAll.cshtml"
   Write(ViewData["Heading"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    <table border=\"1\">\r\n        <tr>\r\n            <td>ID</td>\r\n            <td>Name</td>\r\n            <td>Price</td>\r\n        </tr>\r\n");
#nullable restore
#line 12 "D:\Documentos\ASP.NET LAB\MyWebApp\MyWebApp\MyWebApp\Views\Product\ShowAll.cshtml"
         foreach (var p in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 15 "D:\Documentos\ASP.NET LAB\MyWebApp\MyWebApp\MyWebApp\Views\Product\ShowAll.cshtml"
               Write(p.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 16 "D:\Documentos\ASP.NET LAB\MyWebApp\MyWebApp\MyWebApp\Views\Product\ShowAll.cshtml"
               Write(p.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 17 "D:\Documentos\ASP.NET LAB\MyWebApp\MyWebApp\MyWebApp\Views\Product\ShowAll.cshtml"
               Write(p.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 19 "D:\Documentos\ASP.NET LAB\MyWebApp\MyWebApp\MyWebApp\Views\Product\ShowAll.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MyWebApp.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591