#pragma checksum "C:\Users\DELL-AMD\source\repos\dapm_final\dapm_final\Views\Search\ListProductsSearchPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "dcae96af4f00013191f436e270b6f34f8b79e74ce2ae25f5a8bf49c61cfad7b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_ListProductsSearchPartial), @"mvc.1.0.view", @"/Views/Search/ListProductsSearchPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\DELL-AMD\source\repos\dapm_final\dapm_final\Views\_ViewImports.cshtml"
using dapm_final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL-AMD\source\repos\dapm_final\dapm_final\Views\_ViewImports.cshtml"
using dapm_final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"dcae96af4f00013191f436e270b6f34f8b79e74ce2ae25f5a8bf49c61cfad7b9", @"/Views/Search/ListProductsSearchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7e15c14824fd0781eec70e751f66969c207632a5960b7dba728e5cc6738eb04b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Search_ListProductsSearchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL-AMD\source\repos\dapm_final\dapm_final\Views\Search\ListProductsSearchPartial.cshtml"
 if (Model != null)
{
    foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n\n    <td>\n        ");
#nullable restore
#line 9 "C:\Users\DELL-AMD\source\repos\dapm_final\dapm_final\Views\Search\ListProductsSearchPartial.cshtml"
   Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 12 "C:\Users\DELL-AMD\source\repos\dapm_final\dapm_final\Views\Search\ListProductsSearchPartial.cshtml"
   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n\n    <td>");
#nullable restore
#line 15 "C:\Users\DELL-AMD\source\repos\dapm_final\dapm_final\Views\Search\ListProductsSearchPartial.cshtml"
   Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\n\n\n</tr>");
#nullable restore
#line 18 "C:\Users\DELL-AMD\source\repos\dapm_final\dapm_final\Views\Search\ListProductsSearchPartial.cshtml"
     }
            }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
