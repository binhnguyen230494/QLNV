#pragma checksum "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e852b8ee46a8f0484193c253bb4c59f689d844b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhongBan_Index), @"mvc.1.0.view", @"/Views/PhongBan/Index.cshtml")]
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
#line 1 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\_ViewImports.cshtml"
using QLNV.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\_ViewImports.cshtml"
using QLNV.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e852b8ee46a8f0484193c253bb4c59f689d844b", @"/Views/PhongBan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4aad06113d223a4e39fc1cd600fc11508d56039", @"/Views/_ViewImports.cshtml")]
    public class Views_PhongBan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QLNV.WEB.Models.PhongBan.PhongBanVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PhongBan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TaoPhongBan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
  
    ViewData["Title"] = "PhongBan";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        setTimeout(function () {\r\n            $(\'#msgAlert\').fadeOut(\'slow\');\r\n        }, 2000);\r\n    </script>\r\n");
            }
            );
            WriteLiteral("<h1>Phong Ban</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e852b8ee46a8f0484193c253bb4c59f689d844b4634", async() => {
                WriteLiteral("TaoPhongBan");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 19 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
 if (TempData["Thanhcong"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"msgAlert\" class=\"alert alert-success\">");
#nullable restore
#line 21 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
                                              Write(TempData["Thanhcong"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 22 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-striped table-bordered table-hover\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaPhongBan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenPhongBan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TongSoNhanVien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaPhongBan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenPhongBan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TongSoNhanVien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
               Write(Html.ActionLink("Sửa", "SuaPhongBan", "PhongBan", new { id = item.ID }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 59 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
               Write(Html.ActionLink("Nhân Viên", "Index", "NhanVien", new {  id=item.ID }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 60 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
               Write(Html.ActionLink("Xóa", "XoaPhongBan", "PhongBan", new { id = item.ID }, new { @class = "btn btn-danger", onclick = "return confirm('Ban co muon xoa phong ban nay khong?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\rrrrr\source\repos\QLNV.API\QLNV.WEB\Views\PhongBan\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QLNV.WEB.Models.PhongBan.PhongBanVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591