#pragma checksum "C:\Users\DELL-AMD\source\repos\dapm_final\dapm_final\Views\Checkout\CheckoutSuccess.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "676c7c4fb7e854e9b0be0a7df611ca4326f619c2c445c365a7d1e47b0f9a1a2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_CheckoutSuccess), @"mvc.1.0.view", @"/Views/Checkout/CheckoutSuccess.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"676c7c4fb7e854e9b0be0a7df611ca4326f619c2c445c365a7d1e47b0f9a1a2c", @"/Views/Checkout/CheckoutSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7e15c14824fd0781eec70e751f66969c207632a5960b7dba728e5cc6738eb04b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Checkout_CheckoutSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dapm_final.ModelViews.MuaHangSuccessVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Accounts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL-AMD\source\repos\dapm_final\dapm_final\Views\Checkout\CheckoutSuccess.cshtml"
  
    ViewData["Title"] = "Mua hàng";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""/assets/images/banner/2-1-1920x523.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading"">THÔNG TIN MUA HÀNG</h2>
                        <ul>
                            <li>
                                <a href=""/"">Trang chủ <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>THÔNG TIN MUA HÀNG</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""checkout-area section-space-y-axis-100"">
        <div class=""container"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "676c7c4fb7e854e9b0be0a7df611ca4326f619c2c445c365a7d1e47b0f9a1a2c5360", async() => {
                WriteLiteral("\n                <div class=\"row\">\n                    <div class=\"col-lg-6 col-12\">\n\n                        <div class=\"checkbox-form\">\n                            <h3>Đặt hàng thành công</h3>\n                            <p>Mã đơn hàng: #");
#nullable restore
#line 53 "C:\Users\DELL-AMD\source\repos\dapm_final\dapm_final\Views\Checkout\CheckoutSuccess.cshtml"
                                        Write(Model.DonHangID);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            <p>Cảm ơn bạn đã đặt hàng</p>
                            <br />
                            <h3>THÔNG TIN ĐƠN HÀNG</h3>
                            <p>Thông tin giao hàng</p>
                            <p>Người nhận hàng: ");
#nullable restore
#line 58 "C:\Users\DELL-AMD\source\repos\dapm_final\dapm_final\Views\Checkout\CheckoutSuccess.cshtml"
                                           Write(Model.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                            <p>Số điện thoại: ");
#nullable restore
#line 59 "C:\Users\DELL-AMD\source\repos\dapm_final\dapm_final\Views\Checkout\CheckoutSuccess.cshtml"
                                         Write(Model.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                            <p>Địa chỉ: ");
#nullable restore
#line 60 "C:\Users\DELL-AMD\source\repos\dapm_final\dapm_final\Views\Checkout\CheckoutSuccess.cshtml"
                                   Write(Model.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                            <br />\n                            Để xem chi tiết đơn hàng vui lòng truy cập vào ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "676c7c4fb7e854e9b0be0a7df611ca4326f619c2c445c365a7d1e47b0f9a1a2c7443", async() => {
                    WriteLiteral("<strong>Tài khoản cá nhân.</strong>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@" Cần hỗ trợ? Liên hệ với chúng tôi qua số điện thoại 0123456789
                        </div>
                    </div>
                    <div class=""col-lg-6 col-12"">
                        <img src=""/assets/images/thanh-cong.jpeg"" />
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n        </div>\n    </div>\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dapm_final.ModelViews.MuaHangSuccessVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
